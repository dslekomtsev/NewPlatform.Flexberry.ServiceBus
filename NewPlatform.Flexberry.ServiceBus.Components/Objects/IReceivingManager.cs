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
    /// IReceivingManager.
    /// </summary>
    // *** Start programmer edit section *** (IReceivingManager CustomAttributes)

    // *** End programmer edit section *** (IReceivingManager CustomAttributes)
    public interface IReceivingManager : NewPlatform.Flexberry.ServiceBus.Components.IServiceBusComponent
    {
        
        // *** Start programmer edit section *** (IReceivingManager CustomMembers)

        // *** End programmer edit section *** (IReceivingManager CustomMembers)

        
        // *** Start programmer edit section *** (IReceivingManager.AcceptMessage NewPlatform.Flexberry.ServiceBus.MessageForESB CustomAttributes)

        // *** End programmer edit section *** (IReceivingManager.AcceptMessage NewPlatform.Flexberry.ServiceBus.MessageForESB CustomAttributes)
        void AcceptMessage(NewPlatform.Flexberry.ServiceBus.MessageForESB message);
        
        // *** Start programmer edit section *** (IReceivingManager.AcceptMessage NewPlatform.Flexberry.ServiceBus.MessageForESB System.String CustomAttributes)

        // *** End programmer edit section *** (IReceivingManager.AcceptMessage NewPlatform.Flexberry.ServiceBus.MessageForESB System.String CustomAttributes)
        void AcceptMessage(NewPlatform.Flexberry.ServiceBus.MessageForESB message, string groupName);
        
        // *** Start programmer edit section *** (IReceivingManager.RaiseEvent System.String System.String CustomAttributes)

        // *** End programmer edit section *** (IReceivingManager.RaiseEvent System.String System.String CustomAttributes)
        void RaiseEvent(string clientId, string eventTypeId);
    }
}
