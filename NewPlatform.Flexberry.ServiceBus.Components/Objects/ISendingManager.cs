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
    /// ISendingManager.
    /// </summary>
    // *** Start programmer edit section *** (ISendingManager CustomAttributes)

    // *** End programmer edit section *** (ISendingManager CustomAttributes)
    public interface ISendingManager : NewPlatform.Flexberry.ServiceBus.Components.IServiceBusComponent
    {
        
        // *** Start programmer edit section *** (ISendingManager CustomMembers)

        // *** End programmer edit section *** (ISendingManager CustomMembers)

        
        // *** Start programmer edit section *** (ISendingManager.QueueForSending NewPlatform.Flexberry.ServiceBus.Message CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.QueueForSending NewPlatform.Flexberry.ServiceBus.Message CustomAttributes)
        void QueueForSending(NewPlatform.Flexberry.ServiceBus.Message msg);
        
        // *** Start programmer edit section *** (ISendingManager.GetCurrentMessageCount System.String CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.GetCurrentMessageCount System.String CustomAttributes)
        int GetCurrentMessageCount(string clientId);
        
        // *** Start programmer edit section *** (ISendingManager.GetCurrentMessageCount System.String System.String CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.GetCurrentMessageCount System.String System.String CustomAttributes)
        int GetCurrentMessageCount(string clientId, string messageTypeId);
        
        // *** Start programmer edit section *** (ISendingManager.GetMessagesInfo System.String System.Int32 CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.GetMessagesInfo System.String System.Int32 CustomAttributes)
        MessageInfoFromESB[] GetMessagesInfo(string clientId, int maxCount = 0);
        
        // *** Start programmer edit section *** (ISendingManager.GetMessagesInfo System.String System.String System.Int32 CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.GetMessagesInfo System.String System.String System.Int32 CustomAttributes)
        MessageInfoFromESB[] GetMessagesInfo(string clientId, string messageTypeId, int maxCount = 0);
        
        // *** Start programmer edit section *** (ISendingManager.GetMessagesInfo System.String System.String System.String System.Int32 CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.GetMessagesInfo System.String System.String System.String System.Int32 CustomAttributes)
        MessageInfoFromESB[] GetMessagesInfo(string clientId, string messageTypeId, string groupName, int maxCount = 0);
        
        // *** Start programmer edit section *** (ISendingManager.GetMessagesInfo System.String System.String string[] System.Int32 CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.GetMessagesInfo System.String System.String string[] System.Int32 CustomAttributes)
        MessageInfoFromESB[] GetMessagesInfo(string clientId, string messageTypeId, string[] tags, int maxCount = 0);
        
        // *** Start programmer edit section *** (ISendingManager.ReadMessage System.String CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.ReadMessage System.String CustomAttributes)
        NewPlatform.Flexberry.ServiceBus.Message ReadMessage(string id);
        
        // *** Start programmer edit section *** (ISendingManager.ReadMessage System.String System.String CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.ReadMessage System.String System.String CustomAttributes)
        NewPlatform.Flexberry.ServiceBus.Message ReadMessage(string clientId, string messageTypeId);
        
        // *** Start programmer edit section *** (ISendingManager.ReadMessage System.String System.String System.Int32 CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.ReadMessage System.String System.String System.Int32 CustomAttributes)
        NewPlatform.Flexberry.ServiceBus.Message ReadMessage(string clientId, string messageTypeId, int index);
        
        // *** Start programmer edit section *** (ISendingManager.ReadMessage System.String System.String System.String CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.ReadMessage System.String System.String System.String CustomAttributes)
        NewPlatform.Flexberry.ServiceBus.Message ReadMessage(string clientId, string messageTypeId, string groupName);
        
        // *** Start programmer edit section *** (ISendingManager.ReadMessage System.String System.String string[] CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.ReadMessage System.String System.String string[] CustomAttributes)
        NewPlatform.Flexberry.ServiceBus.Message ReadMessage(string clientId, string messageTypeId, string[] tags);
        
        // *** Start programmer edit section *** (ISendingManager.CheckEventIsRaised System.String System.String CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.CheckEventIsRaised System.String System.String CustomAttributes)
        bool CheckEventIsRaised(string clientId, string eventTypeId);
        
        // *** Start programmer edit section *** (ISendingManager.DeleteMessage System.String CustomAttributes)

        // *** End programmer edit section *** (ISendingManager.DeleteMessage System.String CustomAttributes)
        bool DeleteMessage(string id);
    }
}
