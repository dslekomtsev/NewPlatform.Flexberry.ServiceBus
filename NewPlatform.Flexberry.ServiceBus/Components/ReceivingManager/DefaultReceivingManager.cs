﻿namespace NewPlatform.Flexberry.ServiceBus.Components
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.FunctionalLanguage;
    using ICSSoft.STORMNET.KeyGen;
    using ICSSoft.STORMNET.Windows.Forms;

    using NewPlatform.Flexberry.ServiceBus.Utils;

    /// <summary>
    /// Класс для приема сообщений в шину от клиентов, использующий <see cref="IDataService"/> для работы с сообщениями.
    /// </summary>
    internal class DefaultReceivingManager : BaseReceivingManager
    {
        /// <summary>
        /// Instance of <see cref="KeyLocker{T1, T2}"/> for managing locks when receiving messages with a group.
        /// </summary>
        private readonly KeyLocker<Tuple<Guid, string>, object> locker = new KeyLocker<Tuple<Guid, string>, object>();

        /// <summary>
        /// Язык для ограничений.
        /// </summary>
        private static readonly ExternalLangDef _langDef = ExternalLangDef.LanguageDef;

        private readonly ILogger _logger;

        private readonly IObjectRepository _objectRepository;

        private readonly ISubscriptionsManager _subscriptionsManager;

        private readonly ISendingManager _sendingManager;

        private readonly IDataService _dataService;

        private readonly IStatisticsService _statisticsService;

        public DefaultReceivingManager(
            ILogger logger,
            IObjectRepository objectRepository,
            ISubscriptionsManager subscriptionsManager,
            ISendingManager sendingManager,
            IDataService dataService,
            IStatisticsService statisticsService)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            if (objectRepository == null)
                throw new ArgumentNullException(nameof(objectRepository));

            if (subscriptionsManager == null)
                throw new ArgumentNullException(nameof(subscriptionsManager));

            if (sendingManager == null)
                throw new ArgumentNullException(nameof(sendingManager));

            if (dataService == null)
                throw new ArgumentNullException(nameof(dataService));

            if (statisticsService == null)
                throw new ArgumentNullException(nameof(statisticsService));

            _logger = logger;
            _objectRepository = objectRepository;
            _subscriptionsManager = subscriptionsManager;
            _sendingManager = sendingManager;
            _dataService = dataService;
            _statisticsService = statisticsService;
        }

        /// <summary>
        /// Принять сообщение.
        /// </summary>
        /// <param name="message">Принимаемое сообщение.</param>
        public override void AcceptMessage(ServiceBusMessage message)
        {
            _logger.LogIncomingMessage(message);
            try
            {
                if (!_objectRepository.GetRestrictionsForClient(message.ClientID).Any(x => x.MessageType.ID == message.MessageTypeID))
                {
                    _logger.LogInformation("Отправка запрещена.", $"Клиент {message.ClientID} не имеет прав на отправку сообщения типа {message.MessageTypeID}.");
                    return;
                }

                IEnumerable<Subscription> subscriptions = _subscriptionsManager.GetSubscriptionsForMsgType(message.MessageTypeID, message.ClientID);

                if (!subscriptions.Any())
                    _logger.LogInformation("Для сообщения нет ни одной подписки.", $"Было получено сообщение, для которого нет ни одной активной подписки (ID типа сообщения: {message.MessageTypeID}).");

                // Формируем для найденных подписчиков сообщения.
                var messages = new List<Message>();
                foreach (var subscription in subscriptions)
                {
                    var msg = new Message()
                    {
                        ReceivingTime = DateTime.Now,
                        Recipient = subscription.Client,
                        Priority = 0,
                        IsSending = false,
                    };

                    ServiceHelper.AddSenderToMessage(message, msg, null, _dataService, _logger, _statisticsService);
                    ServiceHelper.SaveTag(message, msg);

                    msg.MessageType = subscription.MessageType;
                    msg.Body = message.Body;
                    msg.BinaryAttachment = message.Attachment;
                    msg.Priority = message.Priority;
                    msg.SendingTime = DateTime.Now;

                    messages.Add(msg);

                    if (subscription.IsCallback)
                        _sendingManager.QueueForSending(msg);

                    _statisticsService.NotifyMessageReceived(subscription);
                }

                var dobjs = messages.Cast<DataObject>().ToArray();

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                _dataService.UpdateObjects(ref dobjs);

                stopwatch.Stop();
                long time = stopwatch.ElapsedMilliseconds;
                _statisticsService.NotifyAvgTimeSql(null, (int)time, "DefaultReceivingManager.AcceptMessage(MessageForESB message) update Сообщения.");

            }
            catch (Exception e)
            {
                _logger.LogUnhandledException(e);
                throw;
            }
        }

        /// <summary>
        /// Принять сообщение с именем группы.
        /// </summary>
        /// <param name="message">Принимаемое сообщение.</param>
        /// <param name="groupName">Имя группы.</param>
        public override void AcceptMessage(ServiceBusMessage message, string groupName)
        {
            _logger.LogIncomingMessage(message);
            try
            {
                if (!_objectRepository.GetRestrictionsForClient(message.ClientID).Any(x => x.MessageType.ID == message.MessageTypeID))
                {
                    _logger.LogInformation("Отправка запрещена.", $"Клиент {message.ClientID} не имеет прав на отправку сообщения типа {message.MessageTypeID}.");
                    return;
                }

                IEnumerable<Subscription> subscriptions = _subscriptionsManager.GetSubscriptionsForMsgType(message.MessageTypeID, message.ClientID);

                if (!subscriptions.Any())
                {
                    _logger.LogInformation("Для сообщения нет ни одной подписки.", $"Было получено сообщение, для которого нет ни одной активной подписки (ID типа сообщения: {message.MessageTypeID}).");
                    return;
                }

                string signature = $"{nameof(DefaultReceivingManager)}.{nameof(AcceptMessage)}({nameof(ServiceBusMessage)} {nameof(message)}, string {nameof(groupName)})";
                foreach (var subscription in subscriptions)
                {
                    Tuple<Guid, string> lockKey = Tuple.Create(((KeyGuid)subscription.__PrimaryKey).Guid, groupName);
                    object lockObject = locker.GetLock(lockKey);
                    try
                    {
                        lock (lockObject)
                        {
                            LoadingCustomizationStruct lcs = MessageBS.GetMessagesWithGroupLCS(subscription.Client, subscription.MessageType, groupName);
                            lcs.ColumnsSort = new[] { new ColumnsSortDef(Information.ExtractPropertyPath<Message>(m => m.SendingTime), SortOrder.Desc) };

                            Stopwatch stopwatch = Stopwatch.StartNew();
                            DataObject[] existingMessages = _dataService.LoadObjects(lcs);
                            stopwatch.Stop();

                            _statisticsService.NotifyAvgTimeSql(subscription, (int)stopwatch.ElapsedMilliseconds, $"{signature} - find existing message.");

                            var messageWithGroup = new Message();
                            if (existingMessages.Length > 0)
                            {
                                messageWithGroup.SetExistObjectPrimaryKey(existingMessages[0].__PrimaryKey);

                                stopwatch = Stopwatch.StartNew();
                                _dataService.LoadObject(Message.Views.MessageEditView, messageWithGroup);
                                stopwatch.Stop();

                                _statisticsService.NotifyAvgTimeSql(subscription, (int)stopwatch.ElapsedMilliseconds, $"{signature} - load existing message.");
                            }

                            ServiceHelper.SetMessageWithGroupValues(message, subscription, messageWithGroup, groupName, _dataService, _logger, _statisticsService);
                            messageWithGroup.SendingTime = DateTime.Now;

                            stopwatch = Stopwatch.StartNew();
                            _dataService.UpdateObject(messageWithGroup);
                            stopwatch.Stop();

                            _statisticsService.NotifyAvgTimeSql(subscription, (int)stopwatch.ElapsedMilliseconds, $"{signature} - update message.");
                        }
                    }
                    finally
                    {
                        locker.FreeLock(lockKey);
                    }

                    _statisticsService.NotifyMessageReceived(subscription);
                }
            }
            catch (Exception e)
            {
                _logger.LogUnhandledException(e);
                throw;
            }
        }
    }
}
