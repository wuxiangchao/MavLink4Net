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
    /// Request that the vehicle report terrain height at the given location. Used by GCS to check if vehicle has all terrain data needed for a mission.
    /// </summary>
    /// <remarks>
    /// TERRAIN_CHECK
    /// </remarks>
    public class TerrainCheckMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Latitude (degrees *10^7)
        /// </summary>
        /// <remarks>
        /// lat
        /// </remarks>
        private int _lat;
        
        /// <summary>
        /// Longitude (degrees *10^7)
        /// </summary>
        /// <remarks>
        /// lon
        /// </remarks>
        private int _lon;
        
        public TerrainCheckMessage() : 
                base(MavLink4Net.Messages.MavMessageType.TerrainCheck, 203)
        {
        }
        
        /// <summary>
        /// Latitude (degrees *10^7)
        /// </summary>
        public int Lat
        {
            get
            {
                return this._lat;
            }
            set
            {
                this._lat = value;
            }
        }
        
        /// <summary>
        /// Longitude (degrees *10^7)
        /// </summary>
        public int Lon
        {
            get
            {
                return this._lon;
            }
            set
            {
                this._lon = value;
            }
        }
    }
}