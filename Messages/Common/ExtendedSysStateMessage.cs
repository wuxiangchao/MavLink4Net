//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MavLink4Net.Messages.Metadata;
using System;
using System.ComponentModel;


namespace MavLink4Net.Messages.Common
{
    
    
    /// <summary>
    /// Provides state for additional features
    /// </summary>
    /// <remarks>
    /// EXTENDED_SYS_STATE
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.ExtendedSysState, Name="EXTENDED_SYS_STATE", Description="Provides state for additional features")]
    public class ExtendedSysStateMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// The VTOL state if applicable. Is set to MAV_VTOL_STATE_UNDEFINED if UAV is not in VTOL configuration.
        /// </summary>
        /// <remarks>
        /// vtol_state
        /// </remarks>
        private MavLink4Net.Messages.Common.VtolState _vtolState;
        
        /// <summary>
        /// The landed state. Is set to MAV_LANDED_STATE_UNDEFINED if landed state is unknown.
        /// </summary>
        /// <remarks>
        /// landed_state
        /// </remarks>
        private MavLink4Net.Messages.Common.LandedState _landedState;
        
        public ExtendedSysStateMessage() : 
                base(MavLink4Net.Messages.MavMessageType.ExtendedSysState, 130)
        {
        }
        
        /// <summary>
        /// The VTOL state if applicable. Is set to MAV_VTOL_STATE_UNDEFINED if UAV is not in VTOL configuration.
        /// </summary>
        [MessageFieldMetadata(Name="vtol_state", Type="MAV_VTOL_STATE enum", Description="The VTOL state if applicable. Is set to MAV_VTOL_STATE_UNDEFINED if UAV is not in" +
            " VTOL configuration.")]
        public MavLink4Net.Messages.Common.VtolState VtolState
        {
            get
            {
                return this._vtolState;
            }
            set
            {
                this._vtolState = value;
            }
        }
        
        /// <summary>
        /// The landed state. Is set to MAV_LANDED_STATE_UNDEFINED if landed state is unknown.
        /// </summary>
        [MessageFieldMetadata(Name="landed_state", Type="MAV_LANDED_STATE enum", Description="The landed state. Is set to MAV_LANDED_STATE_UNDEFINED if landed state is unknown" +
            ".")]
        public MavLink4Net.Messages.Common.LandedState LandedState
        {
            get
            {
                return this._landedState;
            }
            set
            {
                this._landedState = value;
            }
        }
    }
}
