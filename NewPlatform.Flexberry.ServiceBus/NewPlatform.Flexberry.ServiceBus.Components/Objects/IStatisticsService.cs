﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ServiceBus.Components
{
    using System;
    using System.Xml;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// IStatisticsService.
    /// </summary>
    // *** Start programmer edit section *** (IStatisticsService CustomAttributes)

    // *** End programmer edit section *** (IStatisticsService CustomAttributes)
    public interface IStatisticsService : NewPlatform.Flexberry.ServiceBus.Components.IServiceBusComponent
    {
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyMessageReceived Subscription CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyMessageReceived Subscription CustomAttributes)
        void NotifyMessageReceived(Subscription subscription);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyMessageSent Subscription CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyMessageSent Subscription CustomAttributes)
        void NotifyMessageSent(Subscription subscription);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyErrorOccurred Subscription CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyErrorOccurred Subscription CustomAttributes)
        void NotifyErrorOccurred(Subscription subscription);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyAvgTimeSent Subscription System.Int32 CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyAvgTimeSent Subscription System.Int32 CustomAttributes)
        void NotifyAvgTimeSent(Subscription subscription, int time);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyAvgTimeSql Subscription System.Int32 System.String CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyAvgTimeSql Subscription System.Int32 System.String CustomAttributes)
        void NotifyAvgTimeSql(Subscription subscription, int time, string sql);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyIncConnectionCount Subscription CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyIncConnectionCount Subscription CustomAttributes)
        void NotifyIncConnectionCount(Subscription subscription);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyDecConnectionCount Subscription CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyDecConnectionCount Subscription CustomAttributes)
        void NotifyDecConnectionCount(Subscription subscription);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyMessageReceived Client MessageType CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyMessageReceived Client MessageType CustomAttributes)
        void NotifyMessageReceived(Client client, MessageType messageType);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyMessageSent Client MessageType CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyMessageSent Client MessageType CustomAttributes)
        void NotifyMessageSent(Client client, MessageType messageType);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyAvgTimeSent Client MessageType System.Int32 CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyAvgTimeSent Client MessageType System.Int32 CustomAttributes)
        void NotifyAvgTimeSent(Client client, MessageType messageType, int time);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyAvgTimeSql Client MessageType System.Int32 System.String CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyAvgTimeSql Client MessageType System.Int32 System.String CustomAttributes)
        void NotifyAvgTimeSql(Client client, MessageType messageType, int time, string sql);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyIncConnectionCount Client MessageType CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyIncConnectionCount Client MessageType CustomAttributes)
        void NotifyIncConnectionCount(Client client, MessageType messageType);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyDecConnectionCount Client MessageType CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyDecConnectionCount Client MessageType CustomAttributes)
        void NotifyDecConnectionCount(Client client, MessageType messageType);
    }
}
