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
    /// SubscriptionStatisticsMonitor.
    /// </summary>
    // *** Start programmer edit section *** (SubscriptionStatisticsMonitor CustomAttributes)

    // *** End programmer edit section *** (SubscriptionStatisticsMonitor CustomAttributes)
    [ClassStorage("SubStatisticsMonitor")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.@this)]
    [View("AuditView", new string[] {
            "Number as \'Номер п/п\'",
            "Category as \'Категория\'",
            "Name as \'Наименование\'",
            "Subscription as \'Подписка\'",
            "Subscription.Description as \'Description\'"}, Hidden=new string[] {
            "Subscription.Description"})]
    [MasterViewDefineAttribute("AuditView", "Subscription", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Description")]
    [View("DetailView", new string[] {
            "Number as \'Номер п/п\'",
            "Name as \'Наименование\'",
            "Category as \'Категория\'",
            "Subscription as \'Подписка\'",
            "Subscription.Description",
            "Subscription.Client",
            "Subscription.Client.ID",
            "Subscription.Client.Name",
            "Subscription.MessageType",
            "Subscription.MessageType.ID",
            "Subscription.MessageType.Name",
            "StatisticsMonitor"}, Hidden=new string[] {
            "Subscription.Description",
            "Subscription.Client",
            "Subscription.Client.ID",
            "Subscription.Client.Name",
            "Subscription.MessageType",
            "Subscription.MessageType.ID",
            "Subscription.MessageType.Name",
            "StatisticsMonitor"})]
    [MasterViewDefineAttribute("DetailView", "Subscription", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Description")]
    public class SubscriptionStatisticsMonitor : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private int fNumber;
        
        private string fCategory;
        
        private string fName;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private NewPlatform.Flexberry.ServiceBus.Subscription fSubscription;
        
        private NewPlatform.Flexberry.ServiceBus.StatisticsMonitor fStatisticsMonitor;
        
        // *** Start programmer edit section *** (SubscriptionStatisticsMonitor CustomMembers)

        // *** End programmer edit section *** (SubscriptionStatisticsMonitor CustomMembers)

        
        /// <summary>
        /// Number.
        /// </summary>
        // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Number CustomAttributes)

        // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Number CustomAttributes)
        [PropertyStorage("Код")]
        [NotNull()]
        [Order()]
        public virtual int Number
        {
            get
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Number Get start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Number Get start)
                int result = this.fNumber;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Number Get end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Number Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Number Set start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Number Set start)
                this.fNumber = value;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Number Set end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Number Set end)
            }
        }
        
        /// <summary>
        /// Category.
        /// </summary>
        // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Category CustomAttributes)

        // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Category CustomAttributes)
        [PropertyStorage("Категория")]
        [StrLen(255)]
        public virtual string Category
        {
            get
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Category Get start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Category Get start)
                string result = this.fCategory;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Category Get end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Category Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Category Set start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Category Set start)
                this.fCategory = value;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Category Set end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Category Set end)
            }
        }
        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Name CustomAttributes)

        // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Name CustomAttributes)
        [PropertyStorage("Наименование")]
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Name Get start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Name Get end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Name Set start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Name Set end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Name Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.CreateTime CustomAttributes)

        // *** End programmer edit section *** (SubscriptionStatisticsMonitor.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.CreateTime Get start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.CreateTime Get end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.CreateTime Set start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.CreateTime Set end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Creator CustomAttributes)

        // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Creator Get start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Creator Get end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Creator Set start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Creator Set end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.EditTime CustomAttributes)

        // *** End programmer edit section *** (SubscriptionStatisticsMonitor.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.EditTime Get start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.EditTime Get end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.EditTime Set start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.EditTime Set end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Editor CustomAttributes)

        // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Editor Get start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Editor Get end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Editor Set start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Editor Set end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Editor Set end)
            }
        }
        
        /// <summary>
        /// SubscriptionStatisticsMonitor.
        /// </summary>
        // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Subscription CustomAttributes)

        // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Subscription CustomAttributes)
        [PropertyStorage(new string[] {
                "Подписка"})]
        [NotNull()]
        public virtual NewPlatform.Flexberry.ServiceBus.Subscription Subscription
        {
            get
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Subscription Get start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Subscription Get start)
                NewPlatform.Flexberry.ServiceBus.Subscription result = this.fSubscription;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Subscription Get end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Subscription Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Subscription Set start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Subscription Set start)
                this.fSubscription = value;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.Subscription Set end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.Subscription Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.Flexberry.ServiceBus.StatisticsMonitor.
        /// </summary>
        // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.StatisticsMonitor CustomAttributes)

        // *** End programmer edit section *** (SubscriptionStatisticsMonitor.StatisticsMonitor CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "StatisticsMonitor"})]
        public virtual NewPlatform.Flexberry.ServiceBus.StatisticsMonitor StatisticsMonitor
        {
            get
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.StatisticsMonitor Get start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.StatisticsMonitor Get start)
                NewPlatform.Flexberry.ServiceBus.StatisticsMonitor result = this.fStatisticsMonitor;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.StatisticsMonitor Get end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.StatisticsMonitor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.StatisticsMonitor Set start)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.StatisticsMonitor Set start)
                this.fStatisticsMonitor = value;
                // *** Start programmer edit section *** (SubscriptionStatisticsMonitor.StatisticsMonitor Set end)

                // *** End programmer edit section *** (SubscriptionStatisticsMonitor.StatisticsMonitor Set end)
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
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(NewPlatform.Flexberry.ServiceBus.SubscriptionStatisticsMonitor));
                }
            }
            
            /// <summary>
            /// "DetailView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View DetailView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("DetailView", typeof(NewPlatform.Flexberry.ServiceBus.SubscriptionStatisticsMonitor));
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
    /// Detail array of SubscriptionStatisticsMonitor.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfSubscriptionStatisticsMonitor CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfSubscriptionStatisticsMonitor CustomAttributes)
    public class DetailArrayOfSubscriptionStatisticsMonitor : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.Flexberry.ServiceBus.DetailArrayOfSubscriptionStatisticsMonitor members)

        // *** End programmer edit section *** (NewPlatform.Flexberry.ServiceBus.DetailArrayOfSubscriptionStatisticsMonitor members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type SubscriptionStatisticsMonitor by index.
        /// </summary>
        /// <summary>
        /// Adds object with type SubscriptionStatisticsMonitor.
        /// </summary>
        public DetailArrayOfSubscriptionStatisticsMonitor(NewPlatform.Flexberry.ServiceBus.StatisticsMonitor fStatisticsMonitor) : 
                base(typeof(SubscriptionStatisticsMonitor), ((ICSSoft.STORMNET.DataObject)(fStatisticsMonitor)))
        {
        }
        
        public NewPlatform.Flexberry.ServiceBus.SubscriptionStatisticsMonitor this[int index]
        {
            get
            {
                return ((NewPlatform.Flexberry.ServiceBus.SubscriptionStatisticsMonitor)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.Flexberry.ServiceBus.SubscriptionStatisticsMonitor dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
