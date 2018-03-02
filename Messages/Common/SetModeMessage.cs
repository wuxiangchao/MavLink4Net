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
    /// THIS INTERFACE IS DEPRECATED. USE COMMAND_LONG with MAV_CMD_DO_SET_MODE INSTEAD. Set the system mode, as defined by enum MAV_MODE. There is no target component id as the mode is by definition for the overall aircraft, not only for one component.
    /// </summary>
    /// <remarks>
    /// SET_MODE
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.SetMode, Name="SET_MODE", Description="THIS INTERFACE IS DEPRECATED. USE COMMAND_LONG with MAV_CMD_DO_SET_MODE INSTEAD. " +
        "Set the system mode, as defined by enum MAV_MODE. There is no target component i" +
        "d as the mode is by definition for the overall aircraft, not only for one compon" +
        "ent.")]
    public class SetModeMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// The system setting the mode
        /// </summary>
        /// <remarks>
        /// target_system
        /// </remarks>
        private byte _targetSystem;
        
        /// <summary>
        /// The new base mode
        /// </summary>
        /// <remarks>
        /// base_mode
        /// </remarks>
        private MavLink4Net.Messages.Common.Mode _baseMode;
        
        /// <summary>
        /// The new autopilot-specific mode. This field can be ignored by an autopilot.
        /// </summary>
        /// <remarks>
        /// custom_mode
        /// </remarks>
        private uint _customMode;
        
        public SetModeMessage() : 
                base(MavLink4Net.Messages.MavMessageType.SetMode, 89)
        {
        }
        
        /// <summary>
        /// The system setting the mode
        /// </summary>
        [MessageFieldMetadata(Name="target_system", Type="uint8_t", Description="The system setting the mode")]
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
        /// The new base mode
        /// </summary>
        [MessageFieldMetadata(Name="base_mode", Type="MAV_MODE enum", Description="The new base mode")]
        public MavLink4Net.Messages.Common.Mode BaseMode
        {
            get
            {
                return this._baseMode;
            }
            set
            {
                this._baseMode = value;
            }
        }
        
        /// <summary>
        /// The new autopilot-specific mode. This field can be ignored by an autopilot.
        /// </summary>
        [MessageFieldMetadata(Name="custom_mode", Type="uint32_t", Description="The new autopilot-specific mode. This field can be ignored by an autopilot.")]
        public uint CustomMode
        {
            get
            {
                return this._customMode;
            }
            set
            {
                this._customMode = value;
            }
        }
    }
}
