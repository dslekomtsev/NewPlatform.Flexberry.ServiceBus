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
    /// ILogger.
    /// </summary>
    // *** Start programmer edit section *** (ILogger CustomAttributes)

    // *** End programmer edit section *** (ILogger CustomAttributes)
    public interface ILogger : NewPlatform.Flexberry.ServiceBus.Components.IServiceBusComponent
    {
        
        // *** Start programmer edit section *** (ILogger CustomMembers)

        // *** End programmer edit section *** (ILogger CustomMembers)

        
        // *** Start programmer edit section *** (ILogger.LogUnhandledException System.Exception NewPlatform.Flexberry.ServiceBus.Message System.String System.String CustomAttributes)

        // *** End programmer edit section *** (ILogger.LogUnhandledException System.Exception NewPlatform.Flexberry.ServiceBus.Message System.String System.String CustomAttributes)
        void LogUnhandledException(System.Exception exception, NewPlatform.Flexberry.ServiceBus.Message linkedMessage = null, string title = null, string message = null);
        
        // *** Start programmer edit section *** (ILogger.LogError System.String System.String NewPlatform.Flexberry.ServiceBus.Message CustomAttributes)

        // *** End programmer edit section *** (ILogger.LogError System.String System.String NewPlatform.Flexberry.ServiceBus.Message CustomAttributes)
        void LogError(string title, string message, NewPlatform.Flexberry.ServiceBus.Message linkedMessage = null);
        
        // *** Start programmer edit section *** (ILogger.LogIncomingMessage NewPlatform.Flexberry.ServiceBus.MessageForESB CustomAttributes)

        // *** End programmer edit section *** (ILogger.LogIncomingMessage NewPlatform.Flexberry.ServiceBus.MessageForESB CustomAttributes)
        void LogIncomingMessage(NewPlatform.Flexberry.ServiceBus.MessageForESB message);
        
        // *** Start programmer edit section *** (ILogger.LogOutgoingMessage NewPlatform.Flexberry.ServiceBus.Message CustomAttributes)

        // *** End programmer edit section *** (ILogger.LogOutgoingMessage NewPlatform.Flexberry.ServiceBus.Message CustomAttributes)
        void LogOutgoingMessage(NewPlatform.Flexberry.ServiceBus.Message message);
        
        // *** Start programmer edit section *** (ILogger.LogInformation System.String System.String CustomAttributes)

        // *** End programmer edit section *** (ILogger.LogInformation System.String System.String CustomAttributes)
        void LogInformation(string title, string message);
        
        // *** Start programmer edit section *** (ILogger.LogDebugMessage System.String System.String CustomAttributes)

        // *** End programmer edit section *** (ILogger.LogDebugMessage System.String System.String CustomAttributes)
        void LogDebugMessage(string title, string message);
    }
}
