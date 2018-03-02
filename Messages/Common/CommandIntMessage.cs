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
    /// Message encoding a command with parameters as scaled integers. Scaling depends on the actual command value.
    /// </summary>
    /// <remarks>
    /// COMMAND_INT
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.CommandInt, Name="COMMAND_INT", Description="Message encoding a command with parameters as scaled integers. Scaling depends on" +
        " the actual command value.")]
    public class CommandIntMessage : MavLink4Net.Messages.Message
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
        /// The coordinate system of the COMMAND. see MAV_FRAME in mavlink_types.h
        /// </summary>
        /// <remarks>
        /// frame
        /// </remarks>
        private MavLink4Net.Messages.Common.Frame _frame;
        
        /// <summary>
        /// The scheduled action for the mission item. see MAV_CMD in common.xml MAVLink specs
        /// </summary>
        /// <remarks>
        /// command
        /// </remarks>
        private MavLink4Net.Messages.Common.Cmd _command;
        
        /// <summary>
        /// false:0, true:1
        /// </summary>
        /// <remarks>
        /// current
        /// </remarks>
        private byte _current;
        
        /// <summary>
        /// autocontinue to next wp
        /// </summary>
        /// <remarks>
        /// autocontinue
        /// </remarks>
        private byte _autocontinue;
        
        /// <summary>
        /// PARAM1, see MAV_CMD enum
        /// </summary>
        /// <remarks>
        /// param1
        /// </remarks>
        private float _param1;
        
        /// <summary>
        /// PARAM2, see MAV_CMD enum
        /// </summary>
        /// <remarks>
        /// param2
        /// </remarks>
        private float _param2;
        
        /// <summary>
        /// PARAM3, see MAV_CMD enum
        /// </summary>
        /// <remarks>
        /// param3
        /// </remarks>
        private float _param3;
        
        /// <summary>
        /// PARAM4, see MAV_CMD enum
        /// </summary>
        /// <remarks>
        /// param4
        /// </remarks>
        private float _param4;
        
        /// <summary>
        /// PARAM5 / local: x position in meters * 1e4, global: latitude in degrees * 10^7
        /// </summary>
        /// <remarks>
        /// x
        /// </remarks>
        private int _x;
        
        /// <summary>
        /// PARAM6 / local: y position in meters * 1e4, global: longitude in degrees * 10^7
        /// </summary>
        /// <remarks>
        /// y
        /// </remarks>
        private int _y;
        
        /// <summary>
        /// PARAM7 / z position: global: altitude in meters (relative or absolute, depending on frame.
        /// </summary>
        /// <remarks>
        /// z
        /// </remarks>
        private float _z;
        
        public CommandIntMessage() : 
                base(MavLink4Net.Messages.MavMessageType.CommandInt, 158)
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
        /// The coordinate system of the COMMAND. see MAV_FRAME in mavlink_types.h
        /// </summary>
        [MessageFieldMetadata(Name="frame", Type="MAV_FRAME enum", Description="The coordinate system of the COMMAND. see MAV_FRAME in mavlink_types.h")]
        public MavLink4Net.Messages.Common.Frame Frame
        {
            get
            {
                return this._frame;
            }
            set
            {
                this._frame = value;
            }
        }
        
        /// <summary>
        /// The scheduled action for the mission item. see MAV_CMD in common.xml MAVLink specs
        /// </summary>
        [MessageFieldMetadata(Name="command", Type="MAV_CMD enum", Description="The scheduled action for the mission item. see MAV_CMD in common.xml MAVLink spec" +
            "s")]
        public MavLink4Net.Messages.Common.Cmd Command
        {
            get
            {
                return this._command;
            }
            set
            {
                this._command = value;
            }
        }
        
        /// <summary>
        /// false:0, true:1
        /// </summary>
        [MessageFieldMetadata(Name="current", Type="uint8_t", Description="false:0, true:1")]
        public byte Current
        {
            get
            {
                return this._current;
            }
            set
            {
                this._current = value;
            }
        }
        
        /// <summary>
        /// autocontinue to next wp
        /// </summary>
        [MessageFieldMetadata(Name="autocontinue", Type="uint8_t", Description="autocontinue to next wp")]
        public byte Autocontinue
        {
            get
            {
                return this._autocontinue;
            }
            set
            {
                this._autocontinue = value;
            }
        }
        
        /// <summary>
        /// PARAM1, see MAV_CMD enum
        /// </summary>
        [MessageFieldMetadata(Name="param1", Type="float", Description="PARAM1, see MAV_CMD enum")]
        public float Param1
        {
            get
            {
                return this._param1;
            }
            set
            {
                this._param1 = value;
            }
        }
        
        /// <summary>
        /// PARAM2, see MAV_CMD enum
        /// </summary>
        [MessageFieldMetadata(Name="param2", Type="float", Description="PARAM2, see MAV_CMD enum")]
        public float Param2
        {
            get
            {
                return this._param2;
            }
            set
            {
                this._param2 = value;
            }
        }
        
        /// <summary>
        /// PARAM3, see MAV_CMD enum
        /// </summary>
        [MessageFieldMetadata(Name="param3", Type="float", Description="PARAM3, see MAV_CMD enum")]
        public float Param3
        {
            get
            {
                return this._param3;
            }
            set
            {
                this._param3 = value;
            }
        }
        
        /// <summary>
        /// PARAM4, see MAV_CMD enum
        /// </summary>
        [MessageFieldMetadata(Name="param4", Type="float", Description="PARAM4, see MAV_CMD enum")]
        public float Param4
        {
            get
            {
                return this._param4;
            }
            set
            {
                this._param4 = value;
            }
        }
        
        /// <summary>
        /// PARAM5 / local: x position in meters * 1e4, global: latitude in degrees * 10^7
        /// </summary>
        [MessageFieldMetadata(Name="x", Type="int32_t", Description="PARAM5 / local: x position in meters * 1e4, global: latitude in degrees * 10^7")]
        public int X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }
        
        /// <summary>
        /// PARAM6 / local: y position in meters * 1e4, global: longitude in degrees * 10^7
        /// </summary>
        [MessageFieldMetadata(Name="y", Type="int32_t", Description="PARAM6 / local: y position in meters * 1e4, global: longitude in degrees * 10^7")]
        public int Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }
        
        /// <summary>
        /// PARAM7 / z position: global: altitude in meters (relative or absolute, depending on frame.
        /// </summary>
        [MessageFieldMetadata(Name="z", Type="float", Description="PARAM7 / z position: global: altitude in meters (relative or absolute, depending " +
            "on frame.")]
        public float Z
        {
            get
            {
                return this._z;
            }
            set
            {
                this._z = value;
            }
        }
    }
}
