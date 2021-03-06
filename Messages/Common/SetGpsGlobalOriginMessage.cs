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
    /// As local waypoints exist, the global waypoint reference allows to transform between the local coordinate frame and the global (GPS) coordinate frame. This can be necessary when e.g. in- and outdoor settings are connected and the MAV should move from in- to outdoor.
    /// </summary>
    /// <remarks>
    /// SET_GPS_GLOBAL_ORIGIN
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.SetGpsGlobalOrigin, Name="SET_GPS_GLOBAL_ORIGIN", Description=@"As local waypoints exist, the global waypoint reference allows to transform between the local coordinate frame and the global (GPS) coordinate frame. This can be necessary when e.g. in- and outdoor settings are connected and the MAV should move from in- to outdoor.")]
    public class SetGpsGlobalOriginMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// System ID
        /// </summary>
        /// <remarks>
        /// target_system
        /// </remarks>
        private byte _targetSystem;
        
        /// <summary>
        /// Latitude (WGS84), in degrees * 1E7
        /// </summary>
        /// <remarks>
        /// latitude
        /// </remarks>
        private int _latitude;
        
        /// <summary>
        /// Longitude (WGS84), in degrees * 1E7
        /// </summary>
        /// <remarks>
        /// longitude
        /// </remarks>
        private int _longitude;
        
        /// <summary>
        /// Altitude (AMSL), in meters * 1000 (positive for up)
        /// </summary>
        /// <remarks>
        /// altitude
        /// </remarks>
        private int _altitude;
        
        public SetGpsGlobalOriginMessage() : 
                base(MavLink4Net.Messages.MavMessageType.SetGpsGlobalOrigin)
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
        /// Latitude (WGS84), in degrees * 1E7
        /// </summary>
        [MessageFieldMetadata(Name="latitude", Type="int32_t", Units="degE7", Description="Latitude (WGS84), in degrees * 1E7")]
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
        /// Longitude (WGS84), in degrees * 1E7
        /// </summary>
        [MessageFieldMetadata(Name="longitude", Type="int32_t", Units="degE7", Description="Longitude (WGS84), in degrees * 1E7")]
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
        /// Altitude (AMSL), in meters * 1000 (positive for up)
        /// </summary>
        [MessageFieldMetadata(Name="altitude", Type="int32_t", Units="mm", Description="Altitude (AMSL), in meters * 1000 (positive for up)")]
        public int Altitude
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
    }
}
