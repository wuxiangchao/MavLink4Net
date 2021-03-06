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
    /// The RAW IMU readings for the usual 9DOF sensor setup. This message should always contain the true raw values without any scaling to allow data capture and system debugging.
    /// </summary>
    /// <remarks>
    /// RAW_IMU
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.RawImu, Name="RAW_IMU", Description="The RAW IMU readings for the usual 9DOF sensor setup. This message should always " +
        "contain the true raw values without any scaling to allow data capture and system" +
        " debugging.")]
    public class RawImuMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (microseconds since UNIX epoch or microseconds since system boot)
        /// </summary>
        /// <remarks>
        /// time_usec
        /// </remarks>
        private ulong _timeUsec;
        
        /// <summary>
        /// X acceleration (raw)
        /// </summary>
        /// <remarks>
        /// xacc
        /// </remarks>
        private short _xacc;
        
        /// <summary>
        /// Y acceleration (raw)
        /// </summary>
        /// <remarks>
        /// yacc
        /// </remarks>
        private short _yacc;
        
        /// <summary>
        /// Z acceleration (raw)
        /// </summary>
        /// <remarks>
        /// zacc
        /// </remarks>
        private short _zacc;
        
        /// <summary>
        /// Angular speed around X axis (raw)
        /// </summary>
        /// <remarks>
        /// xgyro
        /// </remarks>
        private short _xgyro;
        
        /// <summary>
        /// Angular speed around Y axis (raw)
        /// </summary>
        /// <remarks>
        /// ygyro
        /// </remarks>
        private short _ygyro;
        
        /// <summary>
        /// Angular speed around Z axis (raw)
        /// </summary>
        /// <remarks>
        /// zgyro
        /// </remarks>
        private short _zgyro;
        
        /// <summary>
        /// X Magnetic field (raw)
        /// </summary>
        /// <remarks>
        /// xmag
        /// </remarks>
        private short _xmag;
        
        /// <summary>
        /// Y Magnetic field (raw)
        /// </summary>
        /// <remarks>
        /// ymag
        /// </remarks>
        private short _ymag;
        
        /// <summary>
        /// Z Magnetic field (raw)
        /// </summary>
        /// <remarks>
        /// zmag
        /// </remarks>
        private short _zmag;
        
        public RawImuMessage() : 
                base(MavLink4Net.Messages.MavMessageType.RawImu)
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
        /// X acceleration (raw)
        /// </summary>
        [MessageFieldMetadata(Name="xacc", Type="int16_t", Description="X acceleration (raw)")]
        public short Xacc
        {
            get
            {
                return this._xacc;
            }
            set
            {
                this._xacc = value;
            }
        }
        
        /// <summary>
        /// Y acceleration (raw)
        /// </summary>
        [MessageFieldMetadata(Name="yacc", Type="int16_t", Description="Y acceleration (raw)")]
        public short Yacc
        {
            get
            {
                return this._yacc;
            }
            set
            {
                this._yacc = value;
            }
        }
        
        /// <summary>
        /// Z acceleration (raw)
        /// </summary>
        [MessageFieldMetadata(Name="zacc", Type="int16_t", Description="Z acceleration (raw)")]
        public short Zacc
        {
            get
            {
                return this._zacc;
            }
            set
            {
                this._zacc = value;
            }
        }
        
        /// <summary>
        /// Angular speed around X axis (raw)
        /// </summary>
        [MessageFieldMetadata(Name="xgyro", Type="int16_t", Description="Angular speed around X axis (raw)")]
        public short Xgyro
        {
            get
            {
                return this._xgyro;
            }
            set
            {
                this._xgyro = value;
            }
        }
        
        /// <summary>
        /// Angular speed around Y axis (raw)
        /// </summary>
        [MessageFieldMetadata(Name="ygyro", Type="int16_t", Description="Angular speed around Y axis (raw)")]
        public short Ygyro
        {
            get
            {
                return this._ygyro;
            }
            set
            {
                this._ygyro = value;
            }
        }
        
        /// <summary>
        /// Angular speed around Z axis (raw)
        /// </summary>
        [MessageFieldMetadata(Name="zgyro", Type="int16_t", Description="Angular speed around Z axis (raw)")]
        public short Zgyro
        {
            get
            {
                return this._zgyro;
            }
            set
            {
                this._zgyro = value;
            }
        }
        
        /// <summary>
        /// X Magnetic field (raw)
        /// </summary>
        [MessageFieldMetadata(Name="xmag", Type="int16_t", Description="X Magnetic field (raw)")]
        public short Xmag
        {
            get
            {
                return this._xmag;
            }
            set
            {
                this._xmag = value;
            }
        }
        
        /// <summary>
        /// Y Magnetic field (raw)
        /// </summary>
        [MessageFieldMetadata(Name="ymag", Type="int16_t", Description="Y Magnetic field (raw)")]
        public short Ymag
        {
            get
            {
                return this._ymag;
            }
            set
            {
                this._ymag = value;
            }
        }
        
        /// <summary>
        /// Z Magnetic field (raw)
        /// </summary>
        [MessageFieldMetadata(Name="zmag", Type="int16_t", Description="Z Magnetic field (raw)")]
        public short Zmag
        {
            get
            {
                return this._zmag;
            }
            set
            {
                this._zmag = value;
            }
        }
    }
}
