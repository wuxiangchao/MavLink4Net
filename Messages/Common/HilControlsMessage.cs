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
    /// Sent from autopilot to simulation. Hardware in the loop control outputs
    /// </summary>
    /// <remarks>
    /// HIL_CONTROLS
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.HilControls, Name="HIL_CONTROLS", Description="Sent from autopilot to simulation. Hardware in the loop control outputs")]
    public class HilControlsMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (microseconds since UNIX epoch or microseconds since system boot)
        /// </summary>
        /// <remarks>
        /// time_usec
        /// </remarks>
        private ulong _timeUsec;
        
        /// <summary>
        /// Control output -1 .. 1
        /// </summary>
        /// <remarks>
        /// roll_ailerons
        /// </remarks>
        private float _rollAilerons;
        
        /// <summary>
        /// Control output -1 .. 1
        /// </summary>
        /// <remarks>
        /// pitch_elevator
        /// </remarks>
        private float _pitchElevator;
        
        /// <summary>
        /// Control output -1 .. 1
        /// </summary>
        /// <remarks>
        /// yaw_rudder
        /// </remarks>
        private float _yawRudder;
        
        /// <summary>
        /// Throttle 0 .. 1
        /// </summary>
        /// <remarks>
        /// throttle
        /// </remarks>
        private float _throttle;
        
        /// <summary>
        /// Aux 1, -1 .. 1
        /// </summary>
        /// <remarks>
        /// aux1
        /// </remarks>
        private float _aux1;
        
        /// <summary>
        /// Aux 2, -1 .. 1
        /// </summary>
        /// <remarks>
        /// aux2
        /// </remarks>
        private float _aux2;
        
        /// <summary>
        /// Aux 3, -1 .. 1
        /// </summary>
        /// <remarks>
        /// aux3
        /// </remarks>
        private float _aux3;
        
        /// <summary>
        /// Aux 4, -1 .. 1
        /// </summary>
        /// <remarks>
        /// aux4
        /// </remarks>
        private float _aux4;
        
        /// <summary>
        /// System mode (MAV_MODE)
        /// </summary>
        /// <remarks>
        /// mode
        /// </remarks>
        private MavLink4Net.Messages.Common.Mode _mode;
        
        /// <summary>
        /// Navigation mode (MAV_NAV_MODE)
        /// </summary>
        /// <remarks>
        /// nav_mode
        /// </remarks>
        private byte _navMode;
        
        public HilControlsMessage() : 
                base(MavLink4Net.Messages.MavMessageType.HilControls, 63)
        {
        }
        
        /// <summary>
        /// Timestamp (microseconds since UNIX epoch or microseconds since system boot)
        /// </summary>
        [MessageFieldMetadata(Name="time_usec", Type="uint64_t", Units="us", Description="Timestamp (microseconds since UNIX epoch or microseconds since system boot)")]
        public ulong TimeUsec
        {
            get
            {
                return this._timeUsec;
            }
            set
            {
                this._timeUsec = value;
            }
        }
        
        /// <summary>
        /// Control output -1 .. 1
        /// </summary>
        [MessageFieldMetadata(Name="roll_ailerons", Type="float", Description="Control output -1 .. 1")]
        public float RollAilerons
        {
            get
            {
                return this._rollAilerons;
            }
            set
            {
                this._rollAilerons = value;
            }
        }
        
        /// <summary>
        /// Control output -1 .. 1
        /// </summary>
        [MessageFieldMetadata(Name="pitch_elevator", Type="float", Description="Control output -1 .. 1")]
        public float PitchElevator
        {
            get
            {
                return this._pitchElevator;
            }
            set
            {
                this._pitchElevator = value;
            }
        }
        
        /// <summary>
        /// Control output -1 .. 1
        /// </summary>
        [MessageFieldMetadata(Name="yaw_rudder", Type="float", Description="Control output -1 .. 1")]
        public float YawRudder
        {
            get
            {
                return this._yawRudder;
            }
            set
            {
                this._yawRudder = value;
            }
        }
        
        /// <summary>
        /// Throttle 0 .. 1
        /// </summary>
        [MessageFieldMetadata(Name="throttle", Type="float", Description="Throttle 0 .. 1")]
        public float Throttle
        {
            get
            {
                return this._throttle;
            }
            set
            {
                this._throttle = value;
            }
        }
        
        /// <summary>
        /// Aux 1, -1 .. 1
        /// </summary>
        [MessageFieldMetadata(Name="aux1", Type="float", Description="Aux 1, -1 .. 1")]
        public float Aux1
        {
            get
            {
                return this._aux1;
            }
            set
            {
                this._aux1 = value;
            }
        }
        
        /// <summary>
        /// Aux 2, -1 .. 1
        /// </summary>
        [MessageFieldMetadata(Name="aux2", Type="float", Description="Aux 2, -1 .. 1")]
        public float Aux2
        {
            get
            {
                return this._aux2;
            }
            set
            {
                this._aux2 = value;
            }
        }
        
        /// <summary>
        /// Aux 3, -1 .. 1
        /// </summary>
        [MessageFieldMetadata(Name="aux3", Type="float", Description="Aux 3, -1 .. 1")]
        public float Aux3
        {
            get
            {
                return this._aux3;
            }
            set
            {
                this._aux3 = value;
            }
        }
        
        /// <summary>
        /// Aux 4, -1 .. 1
        /// </summary>
        [MessageFieldMetadata(Name="aux4", Type="float", Description="Aux 4, -1 .. 1")]
        public float Aux4
        {
            get
            {
                return this._aux4;
            }
            set
            {
                this._aux4 = value;
            }
        }
        
        /// <summary>
        /// System mode (MAV_MODE)
        /// </summary>
        [MessageFieldMetadata(Name="mode", Type="MAV_MODE enum", Description="System mode (MAV_MODE)")]
        public MavLink4Net.Messages.Common.Mode Mode
        {
            get
            {
                return this._mode;
            }
            set
            {
                this._mode = value;
            }
        }
        
        /// <summary>
        /// Navigation mode (MAV_NAV_MODE)
        /// </summary>
        [MessageFieldMetadata(Name="nav_mode", Type="uint8_t", Description="Navigation mode (MAV_NAV_MODE)")]
        public byte NavMode
        {
            get
            {
                return this._navMode;
            }
            set
            {
                this._navMode = value;
            }
        }
    }
}
