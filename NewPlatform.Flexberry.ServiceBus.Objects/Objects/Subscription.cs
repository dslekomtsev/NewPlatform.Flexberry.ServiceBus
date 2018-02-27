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
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Business.Audit.Objects;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Subscription.
    /// </summary>
    // *** Start programmer edit section *** (Subscription CustomAttributes)

    // *** End programmer edit section *** (Subscription CustomAttributes)
    [ClassStorage("Подписка")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.@this)]
    [View("AuditView", new string[] {
            "Description as \'Description\'",
            "ExpiryDate as \'Expiry date\'",
            "IsCallback as \'Is callback\'",
            "TransportType as \'Transport type\'",
            "MessageType as \'Message type\'",
            "MessageType.ID as \'ID\'"}, Hidden=new string[] {
            "MessageType.ID"})]
    [MasterViewDefineAttribute("AuditView", "MessageType", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ID")]
    [View("DetailView", new string[] {
            "IsCallback as \'Callback\'",
            "Client",
            "MessageType as \'Message type\'",
            "MessageType.Name",
            "ExpiryDate as \'Expiry date\'",
            "TransportType as \'Transport type\'"}, Hidden=new string[] {
            "Client",
            "MessageType.Name"})]
    [MasterViewDefineAttribute("DetailView", "MessageType", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [View("EditView", new string[] {
            "Client as \'Client\'",
            "Client.Name",
            "Client.Address as \'Client address\'",
            "MessageType as \'Message type\'",
            "MessageType.Name",
            "ExpiryDate as \'Expiry date\'",
            "Description as \'Description\'",
            "IsCallback as \'Callback\'",
            "TransportType as \'Transport type\'"}, Hidden=new string[] {
            "Client.Name",
            "MessageType.Name"})]
    [MasterViewDefineAttribute("EditView", "Client", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [MasterViewDefineAttribute("EditView", "MessageType", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [View("ListView", new string[] {
            "IsCallback as \'Callback\'",
            "Client",
            "Client.Name as \'Client\'",
            "MessageType",
            "MessageType.Name as \'Message type\'",
            "ExpiryDate as \'Expiry date\'",
            "TransportType as \'Transport type\'"}, Hidden=new string[] {
            "Client",
            "MessageType"})]
    [View("LookupView", new string[] {
            "IsCallback as \'Callback\'",
            "Description as \'Description\'",
            "ExpiryDate as \'Expiry date\'",
            "TransportType as \'Transport type\'",
            "Client",
            "Client.ID",
            "Client.Name",
            "MessageType",
            "MessageType.ID",
            "MessageType.Name"}, Hidden=new string[] {
            "Client",
            "Client.ID",
            "Client.Name",
            "MessageType",
            "MessageType.ID",
            "MessageType.Name"})]
    [View("SendingByCallbackView", new string[] {
            "Description",
            "ExpiryDate",
            "IsCallback",
            "TransportType",
            "Client",
            "Client.ID",
            "Client.Name",
            "Client.Address",
            "Client.DnsIdentity",
            "Client.ConnectionsLimit",
            "MessageType",
            "MessageType.ID"})]
    [View("SubscriptionsManagerView", new string[] {
            "ExpiryDate",
            "IsCallback",
            "TransportType",
            "Client",
            "Client.ID",
            "MessageType",
            "MessageType.ID"})]
    public class Subscription : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private string fDescription;
        
        private System.DateTime fExpiryDate = System.DateTime.Now;
        
        private bool fIsCallback;
        
        private NewPlatform.Flexberry.ServiceBus.TransportType fTransportType;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private NewPlatform.Flexberry.ServiceBus.MessageType fMessageType;
        
        private NewPlatform.Flexberry.ServiceBus.Client fClient;
        
        // *** Start programmer edit section *** (Subscription CustomMembers)

        // *** End programmer edit section *** (Subscription CustomMembers)

        
        /// <summary>
        /// Description.
        /// </summary>
        // *** Start programmer edit section *** (Subscription.Description CustomAttributes)

        // *** End programmer edit section *** (Subscription.Description CustomAttributes)
        [PropertyStorage("Описание")]
        public virtual string Description
        {
            get
            {
                // *** Start programmer edit section *** (Subscription.Description Get start)

                // *** End programmer edit section *** (Subscription.Description Get start)
                string result = this.fDescription;
                // *** Start programmer edit section *** (Subscription.Description Get end)
                if (string.IsNullOrWhiteSpace(result) && Client != null && MessageType != null)
                {
                    var client = string.IsNullOrWhiteSpace(Client.Name) ? Client.ID : Client.Name;
                    var messageType = string.IsNullOrWhiteSpace(MessageType.Name) ? MessageType.ID : MessageType.Name;
                    result = $"{client} - {messageType}";
                }
                // *** End programmer edit section *** (Subscription.Description Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Subscription.Description Set start)

                // *** End programmer edit section *** (Subscription.Description Set start)
                this.fDescription = value;
                // *** Start programmer edit section *** (Subscription.Description Set end)

                // *** End programmer edit section *** (Subscription.Description Set end)
            }
        }
        
        /// <summary>
        /// ExpiryDate.
        /// </summary>
        // *** Start programmer edit section *** (Subscription.ExpiryDate CustomAttributes)

        // *** End programmer edit section *** (Subscription.ExpiryDate CustomAttributes)
        [NotNull()]
        public virtual System.DateTime ExpiryDate
        {
            get
            {
                // *** Start programmer edit section *** (Subscription.ExpiryDate Get start)

                // *** End programmer edit section *** (Subscription.ExpiryDate Get start)
                System.DateTime result = this.fExpiryDate;
                // *** Start programmer edit section *** (Subscription.ExpiryDate Get end)

                // *** End programmer edit section *** (Subscription.ExpiryDate Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Subscription.ExpiryDate Set start)

                // *** End programmer edit section *** (Subscription.ExpiryDate Set start)
                this.fExpiryDate = value;
                // *** Start programmer edit section *** (Subscription.ExpiryDate Set end)

                // *** End programmer edit section *** (Subscription.ExpiryDate Set end)
            }
        }
        
        /// <summary>
        /// IsCallback.
        /// </summary>
        // *** Start programmer edit section *** (Subscription.IsCallback CustomAttributes)

        // *** End programmer edit section *** (Subscription.IsCallback CustomAttributes)
        public virtual bool IsCallback
        {
            get
            {
                // *** Start programmer edit section *** (Subscription.IsCallback Get start)

                // *** End programmer edit section *** (Subscription.IsCallback Get start)
                bool result = this.fIsCallback;
                // *** Start programmer edit section *** (Subscription.IsCallback Get end)

                // *** End programmer edit section *** (Subscription.IsCallback Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Subscription.IsCallback Set start)

                // *** End programmer edit section *** (Subscription.IsCallback Set start)
                this.fIsCallback = value;
                // *** Start programmer edit section *** (Subscription.IsCallback Set end)

                // *** End programmer edit section *** (Subscription.IsCallback Set end)
            }
        }
        
        /// <summary>
        /// TransportType.
        /// </summary>
        // *** Start programmer edit section *** (Subscription.TransportType CustomAttributes)

        // *** End programmer edit section *** (Subscription.TransportType CustomAttributes)
        [PropertyStorage("ПередаватьПо")]
        public virtual NewPlatform.Flexberry.ServiceBus.TransportType TransportType
        {
            get
            {
                // *** Start programmer edit section *** (Subscription.TransportType Get start)

                // *** End programmer edit section *** (Subscription.TransportType Get start)
                NewPlatform.Flexberry.ServiceBus.TransportType result = this.fTransportType;
                // *** Start programmer edit section *** (Subscription.TransportType Get end)

                // *** End programmer edit section *** (Subscription.TransportType Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Subscription.TransportType Set start)

                // *** End programmer edit section *** (Subscription.TransportType Set start)
                this.fTransportType = value;
                // *** Start programmer edit section *** (Subscription.TransportType Set end)

                // *** End programmer edit section *** (Subscription.TransportType Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (Subscription.CreateTime CustomAttributes)

        // *** End programmer edit section *** (Subscription.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (Subscription.CreateTime Get start)

                // *** End programmer edit section *** (Subscription.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (Subscription.CreateTime Get end)

                // *** End programmer edit section *** (Subscription.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Subscription.CreateTime Set start)

                // *** End programmer edit section *** (Subscription.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (Subscription.CreateTime Set end)

                // *** End programmer edit section *** (Subscription.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (Subscription.Creator CustomAttributes)

        // *** End programmer edit section *** (Subscription.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (Subscription.Creator Get start)

                // *** End programmer edit section *** (Subscription.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (Subscription.Creator Get end)

                // *** End programmer edit section *** (Subscription.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Subscription.Creator Set start)

                // *** End programmer edit section *** (Subscription.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (Subscription.Creator Set end)

                // *** End programmer edit section *** (Subscription.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (Subscription.EditTime CustomAttributes)

        // *** End programmer edit section *** (Subscription.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (Subscription.EditTime Get start)

                // *** End programmer edit section *** (Subscription.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (Subscription.EditTime Get end)

                // *** End programmer edit section *** (Subscription.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Subscription.EditTime Set start)

                // *** End programmer edit section *** (Subscription.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (Subscription.EditTime Set end)

                // *** End programmer edit section *** (Subscription.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (Subscription.Editor CustomAttributes)

        // *** End programmer edit section *** (Subscription.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (Subscription.Editor Get start)

                // *** End programmer edit section *** (Subscription.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (Subscription.Editor Get end)

                // *** End programmer edit section *** (Subscription.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Subscription.Editor Set start)

                // *** End programmer edit section *** (Subscription.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (Subscription.Editor Set end)

                // *** End programmer edit section *** (Subscription.Editor Set end)
            }
        }
        
        /// <summary>
        /// Subscription.
        /// </summary>
        // *** Start programmer edit section *** (Subscription.MessageType CustomAttributes)

        // *** End programmer edit section *** (Subscription.MessageType CustomAttributes)
        [PropertyStorage(new string[] {
                "ТипСообщения_m0"})]
        [NotNull()]
        public virtual NewPlatform.Flexberry.ServiceBus.MessageType MessageType
        {
            get
            {
                // *** Start programmer edit section *** (Subscription.MessageType Get start)

                // *** End programmer edit section *** (Subscription.MessageType Get start)
                NewPlatform.Flexberry.ServiceBus.MessageType result = this.fMessageType;
                // *** Start programmer edit section *** (Subscription.MessageType Get end)

                // *** End programmer edit section *** (Subscription.MessageType Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Subscription.MessageType Set start)

                // *** End programmer edit section *** (Subscription.MessageType Set start)
                this.fMessageType = value;
                // *** Start programmer edit section *** (Subscription.MessageType Set end)

                // *** End programmer edit section *** (Subscription.MessageType Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.Flexberry.ServiceBus.Client.
        /// </summary>
        // *** Start programmer edit section *** (Subscription.Client CustomAttributes)

        // *** End programmer edit section *** (Subscription.Client CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Клиент_m0"})]
        [TypeUsage(new string[] {
                "NewPlatform.Flexberry.ServiceBus.Client"})]
        public virtual NewPlatform.Flexberry.ServiceBus.Client Client
        {
            get
            {
                // *** Start programmer edit section *** (Subscription.Client Get start)

                // *** End programmer edit section *** (Subscription.Client Get start)
                NewPlatform.Flexberry.ServiceBus.Client result = this.fClient;
                // *** Start programmer edit section *** (Subscription.Client Get end)

                // *** End programmer edit section *** (Subscription.Client Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Subscription.Client Set start)

                // *** End programmer edit section *** (Subscription.Client Set start)
                this.fClient = value;
                // *** Start programmer edit section *** (Subscription.Client Set end)

                // *** End programmer edit section *** (Subscription.Client Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "AuditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AuditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(NewPlatform.Flexberry.ServiceBus.Subscription));
                }
            }
            
            /// <summary>
            /// "DetailView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View DetailView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("DetailView", typeof(NewPlatform.Flexberry.ServiceBus.Subscription));
                }
            }
            
            /// <summary>
            /// "EditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EditView", typeof(NewPlatform.Flexberry.ServiceBus.Subscription));
                }
            }
            
            /// <summary>
            /// "ListView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ListView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ListView", typeof(NewPlatform.Flexberry.ServiceBus.Subscription));
                }
            }
            
            /// <summary>
            /// "LookupView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View LookupView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("LookupView", typeof(NewPlatform.Flexberry.ServiceBus.Subscription));
                }
            }
            
            /// <summary>
            /// "SendingByCallbackView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SendingByCallbackView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SendingByCallbackView", typeof(NewPlatform.Flexberry.ServiceBus.Subscription));
                }
            }
            
            /// <summary>
            /// "SubscriptionsManagerView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View SubscriptionsManagerView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("SubscriptionsManagerView", typeof(NewPlatform.Flexberry.ServiceBus.Subscription));
                }
            }
        }
        
        /// <summary>
        /// Audit class settings.
        /// </summary>
        public class AuditSettings
        {
            
            /// <summary>
            /// Включён ли аудит для класса.
            /// </summary>
            public static bool AuditEnabled = true;
            
            /// <summary>
            /// Использовать имя представления для аудита по умолчанию.
            /// </summary>
            public static bool UseDefaultView = false;
            
            /// <summary>
            /// Включён ли аудит операции чтения.
            /// </summary>
            public static bool SelectAudit = false;
            
            /// <summary>
            /// Имя представления для аудирования операции чтения.
            /// </summary>
            public static string SelectAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции создания.
            /// </summary>
            public static bool InsertAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции создания.
            /// </summary>
            public static string InsertAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции изменения.
            /// </summary>
            public static bool UpdateAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции изменения.
            /// </summary>
            public static string UpdateAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции удаления.
            /// </summary>
            public static bool DeleteAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции удаления.
            /// </summary>
            public static string DeleteAuditViewName = "AuditView";
            
            /// <summary>
            /// Путь к форме просмотра результатов аудита.
            /// </summary>
            public static string FormUrl = "";
            
            /// <summary>
            /// Режим записи данных аудита (синхронный или асинхронный).
            /// </summary>
            public static ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode WriteMode = ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode.Synchronous;
            
            /// <summary>
            /// Максимальная длина сохраняемого значения поля (если 0, то строка обрезаться не будет).
            /// </summary>
            public static int PrunningLength = 0;
            
            /// <summary>
            /// Показывать ли пользователям в изменениях первичные ключи.
            /// </summary>
            public static bool ShowPrimaryKey = false;
            
            /// <summary>
            /// Сохранять ли старое значение.
            /// </summary>
            public static bool KeepOldValue = true;
            
            /// <summary>
            /// Сжимать ли сохраняемые значения.
            /// </summary>
            public static bool Compress = false;
            
            /// <summary>
            /// Сохранять ли все значения атрибутов, а не только изменяемые.
            /// </summary>
            public static bool KeepAllValues = false;
        }
    }
    
    /// <summary>
    /// Detail array of Subscription.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfSubscription CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfSubscription CustomAttributes)
    public class DetailArrayOfSubscription : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.Flexberry.ServiceBus.DetailArrayOfSubscription members)

        // *** End programmer edit section *** (NewPlatform.Flexberry.ServiceBus.DetailArrayOfSubscription members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Subscription by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Subscription.
        /// </summary>
        public DetailArrayOfSubscription(NewPlatform.Flexberry.ServiceBus.Client fClient) : 
                base(typeof(Subscription), ((ICSSoft.STORMNET.DataObject)(fClient)))
        {
        }
        
        public NewPlatform.Flexberry.ServiceBus.Subscription this[int index]
        {
            get
            {
                return ((NewPlatform.Flexberry.ServiceBus.Subscription)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.Flexberry.ServiceBus.Subscription dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
