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
    /// IObjectRepository.
    /// </summary>
    // *** Start programmer edit section *** (IObjectRepository CustomAttributes)

    // *** End programmer edit section *** (IObjectRepository CustomAttributes)
    public interface IObjectRepository : NewPlatform.Flexberry.ServiceBus.Components.IServiceBusComponent
    {
        
        // *** Start programmer edit section *** (IObjectRepository CustomMembers)

        // *** End programmer edit section *** (IObjectRepository CustomMembers)

        
        // *** Start programmer edit section *** (IObjectRepository.GetAllServiceBuses CustomAttributes)

        // *** End programmer edit section *** (IObjectRepository.GetAllServiceBuses CustomAttributes)
        System.Collections.Generic.IEnumerable<Bus> GetAllServiceBuses();
        
        // *** Start programmer edit section *** (IObjectRepository.GetAllMessageTypes CustomAttributes)

        // *** End programmer edit section *** (IObjectRepository.GetAllMessageTypes CustomAttributes)
        System.Collections.Generic.IEnumerable<MessageType> GetAllMessageTypes();
        
        // *** Start programmer edit section *** (IObjectRepository.GetAllRestrictions CustomAttributes)

        // *** End programmer edit section *** (IObjectRepository.GetAllRestrictions CustomAttributes)
        System.Collections.Generic.IEnumerable<SendingPermission> GetAllRestrictions();
        
        // *** Start programmer edit section *** (IObjectRepository.GetRestrictionsForClient System.String CustomAttributes)

        // *** End programmer edit section *** (IObjectRepository.GetRestrictionsForClient System.String CustomAttributes)
        System.Collections.Generic.IEnumerable<SendingPermission> GetRestrictionsForClient(string senderId);
        
        // *** Start programmer edit section *** (IObjectRepository.GetRestrictionsForMsgType System.String CustomAttributes)

        // *** End programmer edit section *** (IObjectRepository.GetRestrictionsForMsgType System.String CustomAttributes)
        System.Collections.Generic.IEnumerable<SendingPermission> GetRestrictionsForMsgType(string messageTypeId);
        
        // *** Start programmer edit section *** (IObjectRepository.CreateSendingPermission System.String CustomAttributes)

        // *** End programmer edit section *** (IObjectRepository.CreateSendingPermission System.String CustomAttributes)
        void CreateSendingPermission(string clientId, string messageTypeId);
        
        // *** Start programmer edit section *** (IObjectRepository.DeleteSendingPermission System.String CustomAttributes)

        // *** End programmer edit section *** (IObjectRepository.DeleteSendingPermission System.String CustomAttributes)
        void DeleteSendingPermission(string clientId, string messageTypeId);
        
        // *** Start programmer edit section *** (IObjectRepository.GetAllClients CustomAttributes)

        // *** End programmer edit section *** (IObjectRepository.GetAllClients CustomAttributes)
        System.Collections.Generic.IEnumerable<Client> GetAllClients();
    }
}
