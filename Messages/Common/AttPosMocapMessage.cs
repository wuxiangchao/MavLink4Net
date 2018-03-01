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
    /// Motion capture attitude and position
    /// </summary>
    /// <remarks>
    /// ATT_POS_MOCAP
    /// </remarks>
    public class AttPosMocapMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (micros since boot or Unix epoch)
        /// </summary>
        /// <remarks>
        /// time_usec
        /// </remarks>
        private ulong _timeUsec;
        
        /// <summary>
        /// Attitude quaternion (w, x, y, z order, zero-rotation is 1, 0, 0, 0)
        /// </summary>
        /// <remarks>
        /// q
        /// </remarks>
        private float[] _q = new float[4];
        
        /// <summary>
        /// X position in meters (NED)
        /// </summary>
        /// <remarks>
        /// x
        /// </remarks>
        private float _x;
        
        /// <summary>
        /// Y position in meters (NED)
        /// </summary>
        /// <remarks>
        /// y
        /// </remarks>
        private float _y;
        
        /// <summary>
        /// Z position in meters (NED)
        /// </summary>
        /// <remarks>
        /// z
        /// </remarks>
        private float _z;
        
        public AttPosMocapMessage() : 
                base(MavLink4Net.Messages.MavMessageType.AttPosMocap, 109)
        {
        }
        
        /// <summary>
        /// Timestamp (micros since boot or Unix epoch)
        /// </summary>
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
        /// Attitude quaternion (w, x, y, z order, zero-rotation is 1, 0, 0, 0)
        /// </summary>
        public float[] Q
        {
            get
            {
                return this._q;
            }
            set
            {
                this._q = value;
            }
        }
        
        /// <summary>
        /// X position in meters (NED)
        /// </summary>
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
        /// Y position in meters (NED)
        /// </summary>
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
        /// Z position in meters (NED)
        /// </summary>
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