//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;


namespace MavLink4Net.Messages.Common
{
    
    
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// DISTANCE_SENSOR
    /// </remarks>
    public class DistanceSensorMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Time since system boot
        /// </summary>
        /// <remarks>
        /// time_boot_ms
        /// </remarks>
        private uint _timeBootMs;
        
        /// <summary>
        /// Minimum distance the sensor can measure in centimeters
        /// </summary>
        /// <remarks>
        /// min_distance
        /// </remarks>
        private ushort _minDistance;
        
        /// <summary>
        /// Maximum distance the sensor can measure in centimeters
        /// </summary>
        /// <remarks>
        /// max_distance
        /// </remarks>
        private ushort _maxDistance;
        
        /// <summary>
        /// Current distance reading
        /// </summary>
        /// <remarks>
        /// current_distance
        /// </remarks>
        private ushort _currentDistance;
        
        /// <summary>
        /// Type from MAV_DISTANCE_SENSOR enum.
        /// </summary>
        /// <remarks>
        /// type
        /// </remarks>
        private DistanceSensor _type;
        
        /// <summary>
        /// Onboard ID of the sensor
        /// </summary>
        /// <remarks>
        /// id
        /// </remarks>
        private byte _id;
        
        /// <summary>
        /// Direction the sensor faces from MAV_SENSOR_ORIENTATION enum. downward-facing: ROTATION_PITCH_270, upward-facing: ROTATION_PITCH_90, backward-facing: ROTATION_PITCH_180, forward-facing: ROTATION_NONE, left-facing: ROTATION_YAW_90, right-facing: ROTATION_YAW_270
        /// </summary>
        /// <remarks>
        /// orientation
        /// </remarks>
        private SensorOrientation _orientation;
        
        /// <summary>
        /// Measurement covariance in centimeters, 0 for unknown / invalid readings
        /// </summary>
        /// <remarks>
        /// covariance
        /// </remarks>
        private byte _covariance;
        
        public DistanceSensorMessage() : 
                base(MavLink4Net.Messages.MavMessageType.DistanceSensor, 85)
        {
        }
        
        /// <summary>
        /// Time since system boot
        /// </summary>
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
        /// Minimum distance the sensor can measure in centimeters
        /// </summary>
        public ushort MinDistance
        {
            get
            {
                return this._minDistance;
            }
            set
            {
                this._minDistance = value;
            }
        }
        
        /// <summary>
        /// Maximum distance the sensor can measure in centimeters
        /// </summary>
        public ushort MaxDistance
        {
            get
            {
                return this._maxDistance;
            }
            set
            {
                this._maxDistance = value;
            }
        }
        
        /// <summary>
        /// Current distance reading
        /// </summary>
        public ushort CurrentDistance
        {
            get
            {
                return this._currentDistance;
            }
            set
            {
                this._currentDistance = value;
            }
        }
        
        /// <summary>
        /// Type from MAV_DISTANCE_SENSOR enum.
        /// </summary>
        public DistanceSensor Type
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
        /// Onboard ID of the sensor
        /// </summary>
        public byte Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        /// <summary>
        /// Direction the sensor faces from MAV_SENSOR_ORIENTATION enum. downward-facing: ROTATION_PITCH_270, upward-facing: ROTATION_PITCH_90, backward-facing: ROTATION_PITCH_180, forward-facing: ROTATION_NONE, left-facing: ROTATION_YAW_90, right-facing: ROTATION_YAW_270
        /// </summary>
        public SensorOrientation Orientation
        {
            get
            {
                return this._orientation;
            }
            set
            {
                this._orientation = value;
            }
        }
        
        /// <summary>
        /// Measurement covariance in centimeters, 0 for unknown / invalid readings
        /// </summary>
        public byte Covariance
        {
            get
            {
                return this._covariance;
            }
            set
            {
                this._covariance = value;
            }
        }
    }
}