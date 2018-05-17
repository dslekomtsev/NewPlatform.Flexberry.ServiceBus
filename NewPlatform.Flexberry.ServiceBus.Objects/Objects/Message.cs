﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ServiceBus
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Message.
    /// </summary>
    // *** Start programmer edit section *** (Message CustomAttributes)

    // *** End programmer edit section *** (Message CustomAttributes)
    [ClassStorage("Сообщение")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.@this)]
    [View("EditView", new string[] {
            "Sender as \'Отправитель\'",
            "Recipient as \'Получатель\'",
            "Recipient.Name",
            "MessageType as \'Тип сообщения\'",
            "MessageType.Name",
            "SendingTime as \'Время следующей отправки\'",
            "ReceivingTime as \'Время формирования\'",
            "IsSending as \'Отправляется\'",
            "Group as \'Имя группы\'",
            "Priority as \'Приоритет\'",
            "ErrorCount as \'Количество неудачных попыток отправки\'",
            "Body as \'Тело сообщения\'",
            "Attachment as \'Вложение\'",
            "Tags as \'Теги\'"}, Hidden=new string[] {
            "Recipient.Name",
            "MessageType.Name"})]
    [MasterViewDefineAttribute("EditView", "Recipient", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [MasterViewDefineAttribute("EditView", "MessageType", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [View("ListView", new string[] {
            "Sender as \'Отправитель\'",
            "Recipient",
            "Recipient.Name as \'Получатель\'",
            "MessageType",
            "MessageType.Name as \'Тип сообщения\'",
            "SendingTime as \'Время следующей отправки\'",
            "ReceivingTime as \'Время формирования\'",
            "IsSending as \'Отправляется\'",
            "Priority as \'Приоритет\'",
            "ErrorCount as \'Количество неудачных попыток отправки\'"}, Hidden=new string[] {
            "Recipient",
            "MessageType"})]
    [View("LookupView", new string[] {
            "Sender as \'Отправитель\'",
            "Recipient",
            "Recipient.Name as \'Получатель\'",
            "MessageType",
            "MessageType.Name as \'Тип сообщения\'",
            "SendingTime as \'Время следующей отправки\'",
            "ReceivingTime as \'Время формирования\'",
            "ErrorCount as \'Количество неудачных попыток отправки\'"}, Hidden=new string[] {
            "Recipient",
            "MessageType"})]
    [View("MessageEditView", new string[] {
            "SendingTime as \'Время следующей отправки\'",
            "ReceivingTime as \'Время формирования\'",
            "Body as \'Тело сообщения\'",
            "Sender as \'Отправитель\'",
            "Attachment as \'Вложение\'",
            "Priority as \'Приоритет\'",
            "IsSending as \'Отправляется\'",
            "ErrorCount as \'Количество неудачных попыток отправки\'",
            "Group as \'Имя группы\'",
            "Tags as \'Теги\'",
            "MessageType",
            "MessageType.ID",
            "MessageType.Name as \'Тип сообщения\'",
            "Recipient",
            "Recipient.ID",
            "Recipient.Name as \'Получатель\'"}, Hidden=new string[] {
            "MessageType",
            "MessageType.ID",
            "Recipient",
            "Recipient.ID"})]
    [View("MessageLightView", new string[] {
            "SendingTime",
            "ReceivingTime",
            "IsSending",
            "ErrorCount",
            "Priority",
            "Group",
            "Tags",
            "MessageType",
            "Recipient"})]
    [View("MessageListView", new string[] {
            "SendingTime as \'Время следующей отправки\'",
            "ReceivingTime as \'Время формирования\'",
            "Sender as \'Отправитель\'",
            "Priority as \'Приоритет\'",
            "ErrorCount as \'Количество неудачных попыток отправки\'",
            "Recipient",
            "Recipient.Name as \'Получатель\'",
            "MessageType",
            "MessageType.Name as \'Тип сообщения\'"}, Hidden=new string[] {
            "Recipient",
            "MessageType"})]
    [View("SendingByCallbackView", new string[] {
            "SendingTime",
            "ReceivingTime",
            "IsSending",
            "ErrorCount",
            "Sender",
            "Body",
            "Attachment",
            "Priority",
            "MessageType",
            "MessageType.ID",
            "Recipient",
            "Recipient.ID",
            "Recipient.SequentialSent"})]
    public class Message : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fSendingTime = System.DateTime.Now;
        
        private System.DateTime fReceivingTime = System.DateTime.Now;
        
        private bool fIsSending;
        
        private int fErrorCount;
        
        private string fSender;
        
        private string fBody;
        
        private string fAttachment;
        
        private int fPriority;
        
        private string fGroup;
        
        private string fTags;
        
        private string fLogs;
        
        private NewPlatform.Flexberry.ServiceBus.MessageType fMessageType;
        
        private NewPlatform.Flexberry.ServiceBus.Client fRecipient;
        
        // *** Start programmer edit section *** (Message CustomMembers)

        // *** End programmer edit section *** (Message CustomMembers)

        
        /// <summary>
        /// SendingTime.
        /// </summary>
        // *** Start programmer edit section *** (Message.SendingTime CustomAttributes)

        // *** End programmer edit section *** (Message.SendingTime CustomAttributes)
        [PropertyStorage("ВремяСледующейОтправки")]
        [NotNull()]
        public virtual System.DateTime SendingTime
        {
            get
            {
                // *** Start programmer edit section *** (Message.SendingTime Get start)

                // *** End programmer edit section *** (Message.SendingTime Get start)
                System.DateTime result = this.fSendingTime;
                // *** Start programmer edit section *** (Message.SendingTime Get end)

                // *** End programmer edit section *** (Message.SendingTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.SendingTime Set start)

                // *** End programmer edit section *** (Message.SendingTime Set start)
                this.fSendingTime = value;
                // *** Start programmer edit section *** (Message.SendingTime Set end)

                // *** End programmer edit section *** (Message.SendingTime Set end)
            }
        }
        
        /// <summary>
        /// ReceivingTime.
        /// </summary>
        // *** Start programmer edit section *** (Message.ReceivingTime CustomAttributes)

        // *** End programmer edit section *** (Message.ReceivingTime CustomAttributes)
        [PropertyStorage("ВремяФормирования")]
        [NotNull()]
        public virtual System.DateTime ReceivingTime
        {
            get
            {
                // *** Start programmer edit section *** (Message.ReceivingTime Get start)

                // *** End programmer edit section *** (Message.ReceivingTime Get start)
                System.DateTime result = this.fReceivingTime;
                // *** Start programmer edit section *** (Message.ReceivingTime Get end)

                // *** End programmer edit section *** (Message.ReceivingTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.ReceivingTime Set start)

                // *** End programmer edit section *** (Message.ReceivingTime Set start)
                this.fReceivingTime = value;
                // *** Start programmer edit section *** (Message.ReceivingTime Set end)

                // *** End programmer edit section *** (Message.ReceivingTime Set end)
            }
        }
        
        /// <summary>
        /// IsSending.
        /// </summary>
        // *** Start programmer edit section *** (Message.IsSending CustomAttributes)

        // *** End programmer edit section *** (Message.IsSending CustomAttributes)
        [PropertyStorage("Отправляется")]
        public virtual bool IsSending
        {
            get
            {
                // *** Start programmer edit section *** (Message.IsSending Get start)

                // *** End programmer edit section *** (Message.IsSending Get start)
                bool result = this.fIsSending;
                // *** Start programmer edit section *** (Message.IsSending Get end)

                // *** End programmer edit section *** (Message.IsSending Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.IsSending Set start)

                // *** End programmer edit section *** (Message.IsSending Set start)
                this.fIsSending = value;
                // *** Start programmer edit section *** (Message.IsSending Set end)

                // *** End programmer edit section *** (Message.IsSending Set end)
            }
        }
        
        /// <summary>
        /// ErrorCount.
        /// </summary>
        // *** Start programmer edit section *** (Message.ErrorCount CustomAttributes)

        // *** End programmer edit section *** (Message.ErrorCount CustomAttributes)
        [PropertyStorage("FailsCount")]
        public virtual int ErrorCount
        {
            get
            {
                // *** Start programmer edit section *** (Message.ErrorCount Get start)

                // *** End programmer edit section *** (Message.ErrorCount Get start)
                int result = this.fErrorCount;
                // *** Start programmer edit section *** (Message.ErrorCount Get end)

                // *** End programmer edit section *** (Message.ErrorCount Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.ErrorCount Set start)

                // *** End programmer edit section *** (Message.ErrorCount Set start)
                this.fErrorCount = value;
                // *** Start programmer edit section *** (Message.ErrorCount Set end)

                // *** End programmer edit section *** (Message.ErrorCount Set end)
            }
        }
        
        /// <summary>
        /// Sender.
        /// </summary>
        // *** Start programmer edit section *** (Message.Sender CustomAttributes)

        // *** End programmer edit section *** (Message.Sender CustomAttributes)
        [PropertyStorage("Отправитель")]
        [StrLen(255)]
        public virtual string Sender
        {
            get
            {
                // *** Start programmer edit section *** (Message.Sender Get start)

                // *** End programmer edit section *** (Message.Sender Get start)
                string result = this.fSender;
                // *** Start programmer edit section *** (Message.Sender Get end)

                // *** End programmer edit section *** (Message.Sender Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.Sender Set start)

                // *** End programmer edit section *** (Message.Sender Set start)
                this.fSender = value;
                // *** Start programmer edit section *** (Message.Sender Set end)

                // *** End programmer edit section *** (Message.Sender Set end)
            }
        }
        
        /// <summary>
        /// Body.
        /// </summary>
        // *** Start programmer edit section *** (Message.Body CustomAttributes)

        // *** End programmer edit section *** (Message.Body CustomAttributes)
        [PropertyStorage("Тело")]
        public virtual string Body
        {
            get
            {
                // *** Start programmer edit section *** (Message.Body Get start)

                // *** End programmer edit section *** (Message.Body Get start)
                string result = this.fBody;
                // *** Start programmer edit section *** (Message.Body Get end)

                // *** End programmer edit section *** (Message.Body Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.Body Set start)

                // *** End programmer edit section *** (Message.Body Set start)
                this.fBody = value;
                // *** Start programmer edit section *** (Message.Body Set end)

                // *** End programmer edit section *** (Message.Body Set end)
            }
        }
        
        /// <summary>
        /// Attachment.
        /// </summary>
        // *** Start programmer edit section *** (Message.Attachment CustomAttributes)

        // *** End programmer edit section *** (Message.Attachment CustomAttributes)
        [PropertyStorage("ВложениеДляБазы")]
        public virtual string Attachment
        {
            get
            {
                // *** Start programmer edit section *** (Message.Attachment Get start)

                // *** End programmer edit section *** (Message.Attachment Get start)
                string result = this.fAttachment;
                // *** Start programmer edit section *** (Message.Attachment Get end)

                // *** End programmer edit section *** (Message.Attachment Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.Attachment Set start)

                // *** End programmer edit section *** (Message.Attachment Set start)
                this.fAttachment = value;
                // *** Start programmer edit section *** (Message.Attachment Set end)

                // *** End programmer edit section *** (Message.Attachment Set end)
            }
        }
        
        /// <summary>
        /// BinaryAttachment.
        /// </summary>
        // *** Start programmer edit section *** (Message.BinaryAttachment CustomAttributes)

        // *** End programmer edit section *** (Message.BinaryAttachment CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        public virtual byte[] BinaryAttachment
        {
            get
            {
                // *** Start programmer edit section *** (Message.BinaryAttachment Get)

                return 0;
                // *** End programmer edit section *** (Message.BinaryAttachment Get)
            }
            set
            {
                // *** Start programmer edit section *** (Message.BinaryAttachment Set)

                // *** End programmer edit section *** (Message.BinaryAttachment Set)
            }
        }
        
        /// <summary>
        /// Priority.
        /// </summary>
        // *** Start programmer edit section *** (Message.Priority CustomAttributes)

        // *** End programmer edit section *** (Message.Priority CustomAttributes)
        [PropertyStorage("Приоритет")]
        public virtual int Priority
        {
            get
            {
                // *** Start programmer edit section *** (Message.Priority Get start)

                // *** End programmer edit section *** (Message.Priority Get start)
                int result = this.fPriority;
                // *** Start programmer edit section *** (Message.Priority Get end)

                // *** End programmer edit section *** (Message.Priority Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.Priority Set start)

                // *** End programmer edit section *** (Message.Priority Set start)
                this.fPriority = value;
                // *** Start programmer edit section *** (Message.Priority Set end)

                // *** End programmer edit section *** (Message.Priority Set end)
            }
        }
        
        /// <summary>
        /// Group.
        /// </summary>
        // *** Start programmer edit section *** (Message.Group CustomAttributes)

        // *** End programmer edit section *** (Message.Group CustomAttributes)
        [PropertyStorage("ИмяГруппы")]
        [StrLen(255)]
        public virtual string Group
        {
            get
            {
                // *** Start programmer edit section *** (Message.Group Get start)

                // *** End programmer edit section *** (Message.Group Get start)
                string result = this.fGroup;
                // *** Start programmer edit section *** (Message.Group Get end)

                // *** End programmer edit section *** (Message.Group Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.Group Set start)

                // *** End programmer edit section *** (Message.Group Set start)
                this.fGroup = value;
                // *** Start programmer edit section *** (Message.Group Set end)

                // *** End programmer edit section *** (Message.Group Set end)
            }
        }
        
        /// <summary>
        /// Tags.
        /// </summary>
        // *** Start programmer edit section *** (Message.Tags CustomAttributes)

        // *** End programmer edit section *** (Message.Tags CustomAttributes)
        [PropertyStorage("Тэги")]
        public virtual string Tags
        {
            get
            {
                // *** Start programmer edit section *** (Message.Tags Get start)

                // *** End programmer edit section *** (Message.Tags Get start)
                string result = this.fTags;
                // *** Start programmer edit section *** (Message.Tags Get end)

                // *** End programmer edit section *** (Message.Tags Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.Tags Set start)

                // *** End programmer edit section *** (Message.Tags Set start)
                this.fTags = value;
                // *** Start programmer edit section *** (Message.Tags Set end)

                // *** End programmer edit section *** (Message.Tags Set end)
            }
        }
        
        /// <summary>
        /// Logs.
        /// </summary>
        // *** Start programmer edit section *** (Message.Logs CustomAttributes)

        // *** End programmer edit section *** (Message.Logs CustomAttributes)
        [PropertyStorage("LogMessages")]
        public virtual string Logs
        {
            get
            {
                // *** Start programmer edit section *** (Message.Logs Get start)

                // *** End programmer edit section *** (Message.Logs Get start)
                string result = this.fLogs;
                // *** Start programmer edit section *** (Message.Logs Get end)

                // *** End programmer edit section *** (Message.Logs Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.Logs Set start)

                // *** End programmer edit section *** (Message.Logs Set start)
                this.fLogs = value;
                // *** Start programmer edit section *** (Message.Logs Set end)

                // *** End programmer edit section *** (Message.Logs Set end)
            }
        }
        
        /// <summary>
        /// Message.
        /// </summary>
        // *** Start programmer edit section *** (Message.MessageType CustomAttributes)

        // *** End programmer edit section *** (Message.MessageType CustomAttributes)
        [PropertyStorage(new string[] {
                "ТипСообщения_m0"})]
        [NotNull()]
        public virtual NewPlatform.Flexberry.ServiceBus.MessageType MessageType
        {
            get
            {
                // *** Start programmer edit section *** (Message.MessageType Get start)

                // *** End programmer edit section *** (Message.MessageType Get start)
                NewPlatform.Flexberry.ServiceBus.MessageType result = this.fMessageType;
                // *** Start programmer edit section *** (Message.MessageType Get end)

                // *** End programmer edit section *** (Message.MessageType Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.MessageType Set start)

                // *** End programmer edit section *** (Message.MessageType Set start)
                this.fMessageType = value;
                // *** Start programmer edit section *** (Message.MessageType Set end)

                // *** End programmer edit section *** (Message.MessageType Set end)
            }
        }
        
        /// <summary>
        /// Message.
        /// </summary>
        // *** Start programmer edit section *** (Message.Recipient CustomAttributes)

        // *** End programmer edit section *** (Message.Recipient CustomAttributes)
        [PropertyStorage(new string[] {
                "Получатель_m0"})]
        [TypeUsage(new string[] {
                "NewPlatform.Flexberry.ServiceBus.Client"})]
        [NotNull()]
        public virtual NewPlatform.Flexberry.ServiceBus.Client Recipient
        {
            get
            {
                // *** Start programmer edit section *** (Message.Recipient Get start)

                // *** End programmer edit section *** (Message.Recipient Get start)
                NewPlatform.Flexberry.ServiceBus.Client result = this.fRecipient;
                // *** Start programmer edit section *** (Message.Recipient Get end)

                // *** End programmer edit section *** (Message.Recipient Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Message.Recipient Set start)

                // *** End programmer edit section *** (Message.Recipient Set start)
                this.fRecipient = value;
                // *** Start programmer edit section *** (Message.Recipient Set end)

                // *** End programmer edit section *** (Message.Recipient Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "EditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EditView", typeof(NewPlatform.Flexberry.ServiceBus.Message));
                }
            }
            
            /// <summary>
            /// "ListView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ListView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ListView", typeof(NewPlatform.Flexberry.ServiceBus.Message));
                }
            }
            
            /// <summary>
            /// "LookupView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View LookupView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("LookupView", typeof(NewPlatform.Flexberry.ServiceBus.Message));
                }
            }
            
            /// <summary>
            /// "MessageEditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View MessageEditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("MessageEditView", typeof(NewPlatform.Flexberry.ServiceBus.Message));
                }
            }
            
            /// <summary>
            /// "MessageLightView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View MessageLightView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("MessageLightView", typeof(NewPlatform.Flexberry.ServiceBus.Message));
                }
            }
            
            /// <summary>
            /// "MessageListView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View MessageListView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("MessageListView", typeof(NewPlatform.Flexberry.ServiceBus.Message));
                }
            }
            
            /// <summary>
            /// "SendingByCallbackView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SendingByCallbackView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SendingByCallbackView", typeof(NewPlatform.Flexberry.ServiceBus.Message));
                }
            }
        }
    }
}
