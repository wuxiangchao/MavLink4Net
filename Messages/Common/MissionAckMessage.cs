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
    /// Ack message during waypoint handling. The type field states if this message is a positive ack (type=0) or if an error happened (type=non-zero).
    /// </summary>
    /// <remarks>
    /// MISSION_ACK
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.MissionAck, Name="MISSION_ACK", Description="Ack message during waypoint handling. The type field states if this message is a " +
        "positive ack (type=0) or if an error happened (type=non-zero).")]
    public class MissionAckMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// System ID
        /// </summary>
        /// <remarks>
        /// target_system
        /// </remarks>
        private byte _targetSystem;
        
        /// <summary>
        /// Component ID
        /// </summary>
        /// <remarks>
        /// target_component
        /// </remarks>
        private byte _targetComponent;
        
        /// <summary>
        /// See MAV_MISSION_RESULT enum
        /// </summary>
        /// <remarks>
        /// type
        /// </remarks>
        private MavLink4Net.Messages.Common.MissionResult _type;
        
        public MissionAckMessage() : 
                base(MavLink4Net.Messages.MavMessageType.MissionAck, 153)
        {
        }
        
        /// <summary>
        /// System ID
        /// </summary>
        [MessageFieldMetadata(Name="target_system", Type="uint8_t", Description="System ID")]
        public byte TargetSystem
        {
            get
            {
                return this._targetSystem;
            }
            set
            {
                this._targetSystem = value;
            }
        }
        
        /// <summary>
        /// Component ID
        /// </summary>
        [MessageFieldMetadata(Name="target_component", Type="uint8_t", Description="Component ID")]
        public byte TargetComponent
        {
            get
            {
                return this._targetComponent;
            }
            set
            {
                this._targetComponent = value;
            }
        }
        
        /// <summary>
        /// See MAV_MISSION_RESULT enum
        /// </summary>
        [MessageFieldMetadata(Name="type", Type="MAV_MISSION_RESULT enum", Description="See MAV_MISSION_RESULT enum")]
        public MavLink4Net.Messages.Common.MissionResult Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
}
