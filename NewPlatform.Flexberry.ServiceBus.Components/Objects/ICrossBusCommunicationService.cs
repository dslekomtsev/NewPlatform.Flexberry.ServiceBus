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
    /// ICrossBusCommunicationService.
    /// </summary>
    // *** Start programmer edit section *** (ICrossBusCommunicationService CustomAttributes)

    // *** End programmer edit section *** (ICrossBusCommunicationService CustomAttributes)
    public interface ICrossBusCommunicationService : NewPlatform.Flexberry.ServiceBus.Components.IServiceBusComponent
    {
        
        // *** Start programmer edit section *** (ICrossBusCommunicationService CustomMembers)

        // *** End programmer edit section *** (ICrossBusCommunicationService CustomMembers)

        
        /// <summary>
        /// Enabled.
        /// </summary>
        // *** Start programmer edit section *** (Enabled CustomAttributes)

        // *** End programmer edit section *** (Enabled CustomAttributes)
        bool Enabled
        {
            get;
            set;
        }
        
        /// <summary>
        /// ServiceID4SB.
        /// </summary>
        // *** Start programmer edit section *** (ServiceID4SB CustomAttributes)

        // *** End programmer edit section *** (ServiceID4SB CustomAttributes)
        string ServiceID4SB
        {
            get;
            set;
        }
        
        /// <summary>
        /// ScanningTimeout.
        /// </summary>
        // *** Start programmer edit section *** (ScanningTimeout CustomAttributes)

        // *** End programmer edit section *** (ScanningTimeout CustomAttributes)
        int ScanningTimeout
        {
            get;
            set;
        }
        
        /// <summary>
        /// CloneMessageTypesScanningCycles.
        /// </summary>
        // *** Start programmer edit section *** (CloneMessageTypesScanningCycles CustomAttributes)

        // *** End programmer edit section *** (CloneMessageTypesScanningCycles CustomAttributes)
        int CloneMessageTypesScanningCycles
        {
            get;
            set;
        }
    }
}
