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
    /// Reports the current commanded vehicle position, velocity, and acceleration as specified by the autopilot. This should match the commands sent in SET_POSITION_TARGET_LOCAL_NED if the vehicle is being controlled this way.
    /// </summary>
    /// <remarks>
    /// POSITION_TARGET_LOCAL_NED
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.PositionTargetLocalNed, Name="POSITION_TARGET_LOCAL_NED", Description="Reports the current commanded vehicle position, velocity, and acceleration as spe" +
        "cified by the autopilot. This should match the commands sent in SET_POSITION_TAR" +
        "GET_LOCAL_NED if the vehicle is being controlled this way.")]
    public class PositionTargetLocalNedMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp in milliseconds since system boot
        /// </summary>
        /// <remarks>
        /// time_boot_ms
        /// </remarks>
        private uint _timeBootMs;
        
        /// <summary>
        /// Valid options are: MAV_FRAME_LOCAL_NED = 1, MAV_FRAME_LOCAL_OFFSET_NED = 7, MAV_FRAME_BODY_NED = 8, MAV_FRAME_BODY_OFFSET_NED = 9
        /// </summary>
        /// <remarks>
        /// coordinate_frame
        /// </remarks>
        private MavLink4Net.Messages.Common.Frame _coordinateFrame;
        
        /// <summary>
        /// Bitmask to indicate which dimensions should be ignored by the vehicle: a value of 0b0000000000000000 or 0b0000001000000000 indicates that none of the setpoint dimensions should be ignored. If bit 10 is set the floats afx afy afz should be interpreted as force instead of acceleration. Mapping: bit 1: x, bit 2: y, bit 3: z, bit 4: vx, bit 5: vy, bit 6: vz, bit 7: ax, bit 8: ay, bit 9: az, bit 10: is force setpoint, bit 11: yaw, bit 12: yaw rate
        /// </summary>
        /// <remarks>
        /// type_mask
        /// </remarks>
        private ushort _typeMask;
        
        /// <summary>
        /// X Position in NED frame in meters
        /// </summary>
        /// <remarks>
        /// x
        /// </remarks>
        private float _x;
        
        /// <summary>
        /// Y Position in NED frame in meters
        /// </summary>
        /// <remarks>
        /// y
        /// </remarks>
        private float _y;
        
        /// <summary>
        /// Z Position in NED frame in meters (note, altitude is negative in NED)
        /// </summary>
        /// <remarks>
        /// z
        /// </remarks>
        private float _z;
        
        /// <summary>
        /// X velocity in NED frame in meter / s
        /// </summary>
        /// <remarks>
        /// vx
        /// </remarks>
        private float _vx;
        
        /// <summary>
        /// Y velocity in NED frame in meter / s
        /// </summary>
        /// <remarks>
        /// vy
        /// </remarks>
        private float _vy;
        
        /// <summary>
        /// Z velocity in NED frame in meter / s
        /// </summary>
        /// <remarks>
        /// vz
        /// </remarks>
        private float _vz;
        
        /// <summary>
        /// X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N
        /// </summary>
        /// <remarks>
        /// afx
        /// </remarks>
        private float _afx;
        
        /// <summary>
        /// Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N
        /// </summary>
        /// <remarks>
        /// afy
        /// </remarks>
        private float _afy;
        
        /// <summary>
        /// Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N
        /// </summary>
        /// <remarks>
        /// afz
        /// </remarks>
        private float _afz;
        
        /// <summary>
        /// yaw setpoint in rad
        /// </summary>
        /// <remarks>
        /// yaw
        /// </remarks>
        private float _yaw;
        
        /// <summary>
        /// yaw rate setpoint in rad/s
        /// </summary>
        /// <remarks>
        /// yaw_rate
        /// </remarks>
        private float _yawRate;
        
        public PositionTargetLocalNedMessage() : 
                base(MavLink4Net.Messages.MavMessageType.PositionTargetLocalNed, 140)
        {
        }
        
        /// <summary>
        /// Timestamp in milliseconds since system boot
        /// </summary>
        [MessageFieldMetadata(Name="time_boot_ms", Type="uint32_t", Units="ms", Description="Timestamp in milliseconds since system boot")]
        public uint TimeBootMs
        {
            get
            {
                return this._timeBootMs;
            }
            set
            {
                this._timeBootMs = value;
            }
        }
        
        /// <summary>
        /// Valid options are: MAV_FRAME_LOCAL_NED = 1, MAV_FRAME_LOCAL_OFFSET_NED = 7, MAV_FRAME_BODY_NED = 8, MAV_FRAME_BODY_OFFSET_NED = 9
        /// </summary>
        [MessageFieldMetadata(Name="coordinate_frame", Type="MAV_FRAME enum", Description="Valid options are: MAV_FRAME_LOCAL_NED = 1, MAV_FRAME_LOCAL_OFFSET_NED = 7, MAV_F" +
            "RAME_BODY_NED = 8, MAV_FRAME_BODY_OFFSET_NED = 9")]
        public MavLink4Net.Messages.Common.Frame CoordinateFrame
        {
            get
            {
                return this._coordinateFrame;
            }
            set
            {
                this._coordinateFrame = value;
            }
        }
        
        /// <summary>
        /// Bitmask to indicate which dimensions should be ignored by the vehicle: a value of 0b0000000000000000 or 0b0000001000000000 indicates that none of the setpoint dimensions should be ignored. If bit 10 is set the floats afx afy afz should be interpreted as force instead of acceleration. Mapping: bit 1: x, bit 2: y, bit 3: z, bit 4: vx, bit 5: vy, bit 6: vz, bit 7: ax, bit 8: ay, bit 9: az, bit 10: is force setpoint, bit 11: yaw, bit 12: yaw rate
        /// </summary>
        [MessageFieldMetadata(Name="type_mask", Type="uint16_t", Display="bitmask", Description=@"Bitmask to indicate which dimensions should be ignored by the vehicle: a value of 0b0000000000000000 or 0b0000001000000000 indicates that none of the setpoint dimensions should be ignored. If bit 10 is set the floats afx afy afz should be interpreted as force instead of acceleration. Mapping: bit 1: x, bit 2: y, bit 3: z, bit 4: vx, bit 5: vy, bit 6: vz, bit 7: ax, bit 8: ay, bit 9: az, bit 10: is force setpoint, bit 11: yaw, bit 12: yaw rate")]
        public ushort TypeMask
        {
            get
            {
                return this._typeMask;
            }
            set
            {
                this._typeMask = value;
            }
        }
        
        /// <summary>
        /// X Position in NED frame in meters
        /// </summary>
        [MessageFieldMetadata(Name="x", Type="float", Units="m", Description="X Position in NED frame in meters")]
        public float X
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
        /// Y Position in NED frame in meters
        /// </summary>
        [MessageFieldMetadata(Name="y", Type="float", Units="m", Description="Y Position in NED frame in meters")]
        public float Y
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
        /// Z Position in NED frame in meters (note, altitude is negative in NED)
        /// </summary>
        [MessageFieldMetadata(Name="z", Type="float", Units="m", Description="Z Position in NED frame in meters (note, altitude is negative in NED)")]
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
        
        /// <summary>
        /// X velocity in NED frame in meter / s
        /// </summary>
        [MessageFieldMetadata(Name="vx", Type="float", Units="m/s", Description="X velocity in NED frame in meter / s")]
        public float Vx
        {
            get
            {
                return this._vx;
            }
            set
            {
                this._vx = value;
            }
        }
        
        /// <summary>
        /// Y velocity in NED frame in meter / s
        /// </summary>
        [MessageFieldMetadata(Name="vy", Type="float", Units="m/s", Description="Y velocity in NED frame in meter / s")]
        public float Vy
        {
            get
            {
                return this._vy;
            }
            set
            {
                this._vy = value;
            }
        }
        
        /// <summary>
        /// Z velocity in NED frame in meter / s
        /// </summary>
        [MessageFieldMetadata(Name="vz", Type="float", Units="m/s", Description="Z velocity in NED frame in meter / s")]
        public float Vz
        {
            get
            {
                return this._vz;
            }
            set
            {
                this._vz = value;
            }
        }
        
        /// <summary>
        /// X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N
        /// </summary>
        [MessageFieldMetadata(Name="afx", Type="float", Units="m/s/s", Description="X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s" +
            "^2 or N")]
        public float Afx
        {
            get
            {
                return this._afx;
            }
            set
            {
                this._afx = value;
            }
        }
        
        /// <summary>
        /// Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N
        /// </summary>
        [MessageFieldMetadata(Name="afy", Type="float", Units="m/s/s", Description="Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s" +
            "^2 or N")]
        public float Afy
        {
            get
            {
                return this._afy;
            }
            set
            {
                this._afy = value;
            }
        }
        
        /// <summary>
        /// Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N
        /// </summary>
        [MessageFieldMetadata(Name="afz", Type="float", Units="m/s/s", Description="Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s" +
            "^2 or N")]
        public float Afz
        {
            get
            {
                return this._afz;
            }
            set
            {
                this._afz = value;
            }
        }
        
        /// <summary>
        /// yaw setpoint in rad
        /// </summary>
        [MessageFieldMetadata(Name="yaw", Type="float", Units="rad", Description="yaw setpoint in rad")]
        public float Yaw
        {
            get
            {
                return this._yaw;
            }
            set
            {
                this._yaw = value;
            }
        }
        
        /// <summary>
        /// yaw rate setpoint in rad/s
        /// </summary>
        [MessageFieldMetadata(Name="yaw_rate", Type="float", Units="rad/s", Description="yaw rate setpoint in rad/s")]
        public float YawRate
        {
            get
            {
                return this._yawRate;
            }
            set
            {
                this._yawRate = value;
            }
        }
    }
}
