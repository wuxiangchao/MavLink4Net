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
    /// WIP: Message appropriate for high latency connections like Iridium (version 2)
    /// </summary>
    /// <remarks>
    /// HIGH_LATENCY2
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.HighLatency2, Name="HIGH_LATENCY2", Description="WIP: Message appropriate for high latency connections like Iridium (version 2)")]
    public class HighLatency2Message : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (milliseconds since boot or Unix epoch)
        /// </summary>
        /// <remarks>
        /// timestamp
        /// </remarks>
        private uint _timestamp;
        
        /// <summary>
        /// Type of the MAV (quadrotor, helicopter, etc., up to 15 types, defined in MAV_TYPE ENUM)
        /// </summary>
        /// <remarks>
        /// type
        /// </remarks>
        private MavLink4Net.Messages.Common.Type _type;
        
        /// <summary>
        /// Autopilot type / class. defined in MAV_AUTOPILOT ENUM
        /// </summary>
        /// <remarks>
        /// autopilot
        /// </remarks>
        private MavLink4Net.Messages.Common.Autopilot _autopilot;
        
        /// <summary>
        /// A bitfield for use for autopilot-specific flags (2 byte version).
        /// </summary>
        /// <remarks>
        /// custom_mode
        /// </remarks>
        private ushort _customMode;
        
        /// <summary>
        /// Latitude, expressed as degrees * 1E7
        /// </summary>
        /// <remarks>
        /// latitude
        /// </remarks>
        private int _latitude;
        
        /// <summary>
        /// Longitude, expressed as degrees * 1E7
        /// </summary>
        /// <remarks>
        /// longitude
        /// </remarks>
        private int _longitude;
        
        /// <summary>
        /// Altitude above mean sea level
        /// </summary>
        /// <remarks>
        /// altitude
        /// </remarks>
        private short _altitude;
        
        /// <summary>
        /// Altitude setpoint
        /// </summary>
        /// <remarks>
        /// target_altitude
        /// </remarks>
        private short _targetAltitude;
        
        /// <summary>
        /// Heading (degrees / 2)
        /// </summary>
        /// <remarks>
        /// heading
        /// </remarks>
        private byte _heading;
        
        /// <summary>
        /// Heading setpoint (degrees / 2)
        /// </summary>
        /// <remarks>
        /// target_heading
        /// </remarks>
        private byte _targetHeading;
        
        /// <summary>
        /// Distance to target waypoint or position (meters / 10)
        /// </summary>
        /// <remarks>
        /// target_distance
        /// </remarks>
        private ushort _targetDistance;
        
        /// <summary>
        /// Throttle (percentage)
        /// </summary>
        /// <remarks>
        /// throttle
        /// </remarks>
        private byte _throttle;
        
        /// <summary>
        /// Airspeed (m/s * 5)
        /// </summary>
        /// <remarks>
        /// airspeed
        /// </remarks>
        private byte _airspeed;
        
        /// <summary>
        /// Airspeed setpoint (m/s * 5)
        /// </summary>
        /// <remarks>
        /// airspeed_sp
        /// </remarks>
        private byte _airspeedSp;
        
        /// <summary>
        /// Groundspeed (m/s * 5)
        /// </summary>
        /// <remarks>
        /// groundspeed
        /// </remarks>
        private byte _groundspeed;
        
        /// <summary>
        /// Windspeed (m/s * 5)
        /// </summary>
        /// <remarks>
        /// windspeed
        /// </remarks>
        private byte _windspeed;
        
        /// <summary>
        /// Wind heading (deg / 2)
        /// </summary>
        /// <remarks>
        /// wind_heading
        /// </remarks>
        private byte _windHeading;
        
        /// <summary>
        /// Maximum error horizontal position since last message (m * 10)
        /// </summary>
        /// <remarks>
        /// eph
        /// </remarks>
        private byte _eph;
        
        /// <summary>
        /// Maximum error vertical position since last message (m * 10)
        /// </summary>
        /// <remarks>
        /// epv
        /// </remarks>
        private byte _epv;
        
        /// <summary>
        /// Air temperature (degrees C) from airspeed sensor
        /// </summary>
        /// <remarks>
        /// temperature_air
        /// </remarks>
        private sbyte _temperatureAir;
        
        /// <summary>
        /// Maximum climb rate magnitude since last message (m/s * 10)
        /// </summary>
        /// <remarks>
        /// climb_rate
        /// </remarks>
        private sbyte _climbRate;
        
        /// <summary>
        /// Battery (percentage, -1 for DNU)
        /// </summary>
        /// <remarks>
        /// battery
        /// </remarks>
        private sbyte _battery;
        
        /// <summary>
        /// Current waypoint number
        /// </summary>
        /// <remarks>
        /// wp_num
        /// </remarks>
        private ushort _wpNum;
        
        /// <summary>
        /// Indicates failures as defined in HL_FAILURE_FLAG ENUM.
        /// </summary>
        /// <remarks>
        /// failure_flags
        /// </remarks>
        private MavLink4Net.Messages.Common.HlFailureFlag _failureFlags;
        
        /// <summary>
        /// Field for custom payload.
        /// </summary>
        /// <remarks>
        /// custom0
        /// </remarks>
        private sbyte _custom0;
        
        /// <summary>
        /// Field for custom payload.
        /// </summary>
        /// <remarks>
        /// custom1
        /// </remarks>
        private sbyte _custom1;
        
        /// <summary>
        /// Field for custom payload.
        /// </summary>
        /// <remarks>
        /// custom2
        /// </remarks>
        private sbyte _custom2;
        
        public HighLatency2Message() : 
                base(MavLink4Net.Messages.MavMessageType.HighLatency2)
        {
        }
        
        /// <summary>
        /// Timestamp (milliseconds since boot or Unix epoch)
        /// </summary>
        [MessageFieldMetadata(Name="timestamp", Type="uint32_t", Units="ms", Description="Timestamp (milliseconds since boot or Unix epoch)")]
        public uint Timestamp
        {
            get
            {
                return this._timestamp;
            }
            set
            {
                this._timestamp = value;
            }
        }
        
        /// <summary>
        /// Type of the MAV (quadrotor, helicopter, etc., up to 15 types, defined in MAV_TYPE ENUM)
        /// </summary>
        [MessageFieldMetadata(Name="type", Type="MAV_TYPE enum", Description="Type of the MAV (quadrotor, helicopter, etc., up to 15 types, defined in MAV_TYPE" +
            " ENUM)")]
        public MavLink4Net.Messages.Common.Type Type
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
        
        /// <summary>
        /// Autopilot type / class. defined in MAV_AUTOPILOT ENUM
        /// </summary>
        [MessageFieldMetadata(Name="autopilot", Type="MAV_AUTOPILOT enum", Description="Autopilot type / class. defined in MAV_AUTOPILOT ENUM")]
        public MavLink4Net.Messages.Common.Autopilot Autopilot
        {
            get
            {
                return this._autopilot;
            }
            set
            {
                this._autopilot = value;
            }
        }
        
        /// <summary>
        /// A bitfield for use for autopilot-specific flags (2 byte version).
        /// </summary>
        [MessageFieldMetadata(Name="custom_mode", Type="uint16_t", Display="bitmask", Description="A bitfield for use for autopilot-specific flags (2 byte version).")]
        public ushort CustomMode
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
        
        /// <summary>
        /// Latitude, expressed as degrees * 1E7
        /// </summary>
        [MessageFieldMetadata(Name="latitude", Type="int32_t", Units="degE7", Description="Latitude, expressed as degrees * 1E7")]
        public int Latitude
        {
            get
            {
                return this._latitude;
            }
            set
            {
                this._latitude = value;
            }
        }
        
        /// <summary>
        /// Longitude, expressed as degrees * 1E7
        /// </summary>
        [MessageFieldMetadata(Name="longitude", Type="int32_t", Units="degE7", Description="Longitude, expressed as degrees * 1E7")]
        public int Longitude
        {
            get
            {
                return this._longitude;
            }
            set
            {
                this._longitude = value;
            }
        }
        
        /// <summary>
        /// Altitude above mean sea level
        /// </summary>
        [MessageFieldMetadata(Name="altitude", Type="int16_t", Units="m", Description="Altitude above mean sea level")]
        public short Altitude
        {
            get
            {
                return this._altitude;
            }
            set
            {
                this._altitude = value;
            }
        }
        
        /// <summary>
        /// Altitude setpoint
        /// </summary>
        [MessageFieldMetadata(Name="target_altitude", Type="int16_t", Units="m", Description="Altitude setpoint")]
        public short TargetAltitude
        {
            get
            {
                return this._targetAltitude;
            }
            set
            {
                this._targetAltitude = value;
            }
        }
        
        /// <summary>
        /// Heading (degrees / 2)
        /// </summary>
        [MessageFieldMetadata(Name="heading", Type="uint8_t", Units="deg/2", Description="Heading (degrees / 2)")]
        public byte Heading
        {
            get
            {
                return this._heading;
            }
            set
            {
                this._heading = value;
            }
        }
        
        /// <summary>
        /// Heading setpoint (degrees / 2)
        /// </summary>
        [MessageFieldMetadata(Name="target_heading", Type="uint8_t", Units="deg/2", Description="Heading setpoint (degrees / 2)")]
        public byte TargetHeading
        {
            get
            {
                return this._targetHeading;
            }
            set
            {
                this._targetHeading = value;
            }
        }
        
        /// <summary>
        /// Distance to target waypoint or position (meters / 10)
        /// </summary>
        [MessageFieldMetadata(Name="target_distance", Type="uint16_t", Units="dam", Description="Distance to target waypoint or position (meters / 10)")]
        public ushort TargetDistance
        {
            get
            {
                return this._targetDistance;
            }
            set
            {
                this._targetDistance = value;
            }
        }
        
        /// <summary>
        /// Throttle (percentage)
        /// </summary>
        [MessageFieldMetadata(Name="throttle", Type="uint8_t", Units="%", Description="Throttle (percentage)")]
        public byte Throttle
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
        /// Airspeed (m/s * 5)
        /// </summary>
        [MessageFieldMetadata(Name="airspeed", Type="uint8_t", Units="m/s*5", Description="Airspeed (m/s * 5)")]
        public byte Airspeed
        {
            get
            {
                return this._airspeed;
            }
            set
            {
                this._airspeed = value;
            }
        }
        
        /// <summary>
        /// Airspeed setpoint (m/s * 5)
        /// </summary>
        [MessageFieldMetadata(Name="airspeed_sp", Type="uint8_t", Units="m/s*5", Description="Airspeed setpoint (m/s * 5)")]
        public byte AirspeedSp
        {
            get
            {
                return this._airspeedSp;
            }
            set
            {
                this._airspeedSp = value;
            }
        }
        
        /// <summary>
        /// Groundspeed (m/s * 5)
        /// </summary>
        [MessageFieldMetadata(Name="groundspeed", Type="uint8_t", Units="m/s*5", Description="Groundspeed (m/s * 5)")]
        public byte Groundspeed
        {
            get
            {
                return this._groundspeed;
            }
            set
            {
                this._groundspeed = value;
            }
        }
        
        /// <summary>
        /// Windspeed (m/s * 5)
        /// </summary>
        [MessageFieldMetadata(Name="windspeed", Type="uint8_t", Units="m/s*5", Description="Windspeed (m/s * 5)")]
        public byte Windspeed
        {
            get
            {
                return this._windspeed;
            }
            set
            {
                this._windspeed = value;
            }
        }
        
        /// <summary>
        /// Wind heading (deg / 2)
        /// </summary>
        [MessageFieldMetadata(Name="wind_heading", Type="uint8_t", Units="deg/2", Description="Wind heading (deg / 2)")]
        public byte WindHeading
        {
            get
            {
                return this._windHeading;
            }
            set
            {
                this._windHeading = value;
            }
        }
        
        /// <summary>
        /// Maximum error horizontal position since last message (m * 10)
        /// </summary>
        [MessageFieldMetadata(Name="eph", Type="uint8_t", Units="dm", Description="Maximum error horizontal position since last message (m * 10)")]
        public byte Eph
        {
            get
            {
                return this._eph;
            }
            set
            {
                this._eph = value;
            }
        }
        
        /// <summary>
        /// Maximum error vertical position since last message (m * 10)
        /// </summary>
        [MessageFieldMetadata(Name="epv", Type="uint8_t", Units="dm", Description="Maximum error vertical position since last message (m * 10)")]
        public byte Epv
        {
            get
            {
                return this._epv;
            }
            set
            {
                this._epv = value;
            }
        }
        
        /// <summary>
        /// Air temperature (degrees C) from airspeed sensor
        /// </summary>
        [MessageFieldMetadata(Name="temperature_air", Type="int8_t", Units="degC", Description="Air temperature (degrees C) from airspeed sensor")]
        public sbyte TemperatureAir
        {
            get
            {
                return this._temperatureAir;
            }
            set
            {
                this._temperatureAir = value;
            }
        }
        
        /// <summary>
        /// Maximum climb rate magnitude since last message (m/s * 10)
        /// </summary>
        [MessageFieldMetadata(Name="climb_rate", Type="int8_t", Units="dm/s", Description="Maximum climb rate magnitude since last message (m/s * 10)")]
        public sbyte ClimbRate
        {
            get
            {
                return this._climbRate;
            }
            set
            {
                this._climbRate = value;
            }
        }
        
        /// <summary>
        /// Battery (percentage, -1 for DNU)
        /// </summary>
        [MessageFieldMetadata(Name="battery", Type="int8_t", Units="%", Description="Battery (percentage, -1 for DNU)")]
        public sbyte Battery
        {
            get
            {
                return this._battery;
            }
            set
            {
                this._battery = value;
            }
        }
        
        /// <summary>
        /// Current waypoint number
        /// </summary>
        [MessageFieldMetadata(Name="wp_num", Type="uint16_t", Description="Current waypoint number")]
        public ushort WpNum
        {
            get
            {
                return this._wpNum;
            }
            set
            {
                this._wpNum = value;
            }
        }
        
        /// <summary>
        /// Indicates failures as defined in HL_FAILURE_FLAG ENUM.
        /// </summary>
        [MessageFieldMetadata(Name="failure_flags", Type="HL_FAILURE_FLAG enum", Display="bitmask", Description="Indicates failures as defined in HL_FAILURE_FLAG ENUM.")]
        public MavLink4Net.Messages.Common.HlFailureFlag FailureFlags
        {
            get
            {
                return this._failureFlags;
            }
            set
            {
                this._failureFlags = value;
            }
        }
        
        /// <summary>
        /// Field for custom payload.
        /// </summary>
        [MessageFieldMetadata(Name="custom0", Type="int8_t", Description="Field for custom payload.")]
        public sbyte Custom0
        {
            get
            {
                return this._custom0;
            }
            set
            {
                this._custom0 = value;
            }
        }
        
        /// <summary>
        /// Field for custom payload.
        /// </summary>
        [MessageFieldMetadata(Name="custom1", Type="int8_t", Description="Field for custom payload.")]
        public sbyte Custom1
        {
            get
            {
                return this._custom1;
            }
            set
            {
                this._custom1 = value;
            }
        }
        
        /// <summary>
        /// Field for custom payload.
        /// </summary>
        [MessageFieldMetadata(Name="custom2", Type="int8_t", Description="Field for custom payload.")]
        public sbyte Custom2
        {
            get
            {
                return this._custom2;
            }
            set
            {
                this._custom2 = value;
            }
        }
    }
}
