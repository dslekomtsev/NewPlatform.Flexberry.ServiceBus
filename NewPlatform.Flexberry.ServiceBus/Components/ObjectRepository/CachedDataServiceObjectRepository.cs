﻿namespace NewPlatform.Flexberry.ServiceBus.Components
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Business.LINQProvider;
    using MultiTasking;

    /// <summary>
    /// Implementation of <see cref="IObjectRepository"/> using <see cref="IDataService"/> with cache.
    /// </summary>
    internal class CachedDataServiceObjectRepository : BaseServiceBusComponent, IObjectRepository, ICacheable
    {
        /// <summary>
        /// Cache for types of messages.
        /// </summary>
        private static readonly List<MessageType> MessageTypes = new List<MessageType>();

        /// <summary>
        /// Cache for service buses.
        /// </summary>
        private static readonly List<Bus> ServiceBuses = new List<Bus>();

        /// <summary>
        /// Cache for restrictions.
        /// </summary>
        private static readonly List<SendingPermission> Restrictions = new List<SendingPermission>();

        /// <summary>
        /// Lock object for types of messages.
        /// </summary>
        private static readonly object MessageTypesLockObject = new object();

        /// <summary>
        /// Lock object for service buses.
        /// </summary>
        private static readonly object ServiceBusesLockObject = new object();

        /// <summary>
        /// Lock object for restrictions.
        /// </summary>
        private static readonly object RestrictionsLockObject = new object();

        /// <summary>
        /// Logger.
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// The data service for loading objects.
        /// </summary>
        private readonly IDataService _dataService;

        /// <summary>
        /// Period of updating data from database.
        /// </summary>
        public int UpdatePeriodMilliseconds { get; set; } = 60000;

        /// <summary>
        /// Timer for periodical update of data.
        /// </summary>
        private readonly PeriodicalTimer _periodicalTimer;

        /// <summary>
        /// Statistics service
        /// </summary>
        private readonly IStatisticsService _statisticsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataServiceObjectRepository"/> class with specified logger and data service.
        /// </summary>
        /// <param name="logger">Logger.</param>
        /// <param name="dataService">Data service.</param>
        public CachedDataServiceObjectRepository(ILogger logger, IDataService dataService, IStatisticsService statisticsService)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            if (dataService == null)
                throw new ArgumentNullException(nameof(dataService));

            if (statisticsService == null)
                throw new ArgumentNullException(nameof(statisticsService));

            _logger = logger;
            _dataService = dataService;

            _periodicalTimer = new PeriodicalTimer();
            _statisticsService = statisticsService;
        }

        /// <summary>
        /// Gets all message types.
        /// </summary>
        /// <returns>The list of all stored message types.</returns>
        public IEnumerable<MessageType> GetAllMessageTypes()
        {
            lock (MessageTypesLockObject)
            {
                return new List<MessageType>(MessageTypes);
            }
        }

        /// <summary>
        /// Returns all sending restrictions.
        /// </summary>
        /// <returns>The list of all stored restrictions.</returns>
        public IEnumerable<SendingPermission> GetAllRestrictions()
        {
            lock (Restrictions)
            {
                return new List<SendingPermission>(Restrictions);
            }
        }

        /// <summary>
        /// Gets all service buses.
        /// </summary>
        /// <returns>The list of all stored remote services buses.</returns>
        public IEnumerable<Bus> GetAllServiceBuses()
        {
            lock (ServiceBusesLockObject)
            {
                return new List<Bus>(ServiceBuses);
            }
        }

        /// <summary>
        /// Returns sending restrictions for client.
        /// </summary>
        /// <param name="senderId">Client's ID.</param>
        /// <returns>Restrictions for client.</returns>
        public IEnumerable<SendingPermission> GetRestrictionsForClient(string senderId)
        {
            lock (RestrictionsLockObject)
            {
                return (from x in Restrictions where x.Client.ID == senderId select x).ToList();
            }
        }

        /// <summary>
        /// Returns sending restrictions for message type.
        /// </summary>
        /// <param name="messageTypeId">Message type's ID.</param>
        /// <returns>Restrictions for messge type.</returns>
        public IEnumerable<SendingPermission> GetRestrictionsForMsgType(string messageTypeId)
        {
            lock (RestrictionsLockObject)
            {
                return (from x in Restrictions where x.MessageType.ID == messageTypeId select x).ToList();
            }
        }

        /// <summary>
        /// Initialize component.
        /// </summary>
        public override void Prepare()
        {
            base.Prepare();
            UpdateFromDb();
        }

        /// <summary>
        /// Start working.
        /// </summary>
        public override void Start()
        {
            base.Start();
            if (_periodicalTimer.State != PeriodicalTimer.TimerState.Working)
                _periodicalTimer.Start(UpdateFromDb, UpdatePeriodMilliseconds);
        }

        /// <summary>
        /// Stop working.
        /// </summary>
        public override void Stop()
        {
            base.Stop();
            if (_periodicalTimer.State == PeriodicalTimer.TimerState.Working)
                _periodicalTimer.Stop();
        }

        /// <summary>
        /// Clear cached data.
        /// </summary>
        public void ClearCache()
        {
            MessageTypes.Clear();
            ServiceBuses.Clear();
            Restrictions.Clear();
        }

        /// <summary>
        /// Update data from database (once).
        /// </summary>
        private void UpdateFromDb()
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                var messageTypes = (from x in _dataService.Query<MessageType>(MessageType.Views.ListView) select x).ToList();
                stopwatch.Stop();
                long time = stopwatch.ElapsedMilliseconds;
                _statisticsService.NotifyAvgTimeSql(null, (int)time, "CachedDataServiceObjectRepository.UpdateFromDb() load ТипСообщения");

                lock (MessageTypesLockObject)
                {
                    MessageTypes.Clear();
                    MessageTypes.AddRange(messageTypes);
                }

                stopwatch = new Stopwatch();
                stopwatch.Start();
                var serviceBuses = (from x in _dataService.Query<Bus>(Bus.Views.ListView) select x).ToList();
                stopwatch.Stop();
                time = stopwatch.ElapsedMilliseconds;
                _statisticsService.NotifyAvgTimeSql(null, (int)time, "CachedDataServiceObjectRepository.UpdateFromDb() load Шина");

                lock (ServiceBusesLockObject)
                {
                    ServiceBuses.Clear();
                    ServiceBuses.AddRange(serviceBuses);
                }

                stopwatch = new Stopwatch();
                stopwatch.Start();
                var restrictions = (from x in _dataService.Query<SendingPermission>(SendingPermission.Views.ServiceBusView) select x).ToList();
                stopwatch.Stop();
                time = stopwatch.ElapsedMilliseconds;
                _statisticsService.NotifyAvgTimeSql(null, (int)time, "CachedDataServiceObjectRepository.UpdateFromDb() load OutboundMessageTypeRestriction");

                lock (RestrictionsLockObject)
                {
                    Restrictions.Clear();
                    Restrictions.AddRange(restrictions);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError("Update data from database (once) error", exception.ToString());
            }
        }
    }
}
