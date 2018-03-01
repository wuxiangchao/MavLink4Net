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
    /// Status generated by radio and injected into MAVLink stream.
    /// </summary>
    /// <remarks>
    /// RADIO_STATUS
    /// </remarks>
    public class RadioStatusMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Local signal strength
        /// </summary>
        /// <remarks>
        /// rssi
        /// </remarks>
        private byte _rssi;
        
        /// <summary>
        /// Remote signal strength
        /// </summary>
        /// <remarks>
        /// remrssi
        /// </remarks>
        private byte _remrssi;
        
        /// <summary>
        /// Remaining free buffer space in percent.
        /// </summary>
        /// <remarks>
        /// txbuf
        /// </remarks>
        private byte _txbuf;
        
        /// <summary>
        /// Background noise level
        /// </summary>
        /// <remarks>
        /// noise
        /// </remarks>
        private byte _noise;
        
        /// <summary>
        /// Remote background noise level
        /// </summary>
        /// <remarks>
        /// remnoise
        /// </remarks>
        private byte _remnoise;
        
        /// <summary>
        /// Receive errors
        /// </summary>
        /// <remarks>
        /// rxerrors
        /// </remarks>
        private ushort _rxerrors;
        
        /// <summary>
        /// Count of error corrected packets
        /// </summary>
        /// <remarks>
        /// fixed
        /// </remarks>
        private ushort _fixed;
        
        public RadioStatusMessage() : 
                base(MavLink4Net.Messages.MavMessageType.RadioStatus, 185)
        {
        }
        
        /// <summary>
        /// Local signal strength
        /// </summary>
        public byte Rssi
        {
            get
            {
                return this._rssi;
            }
            set
            {
                this._rssi = value;
            }
        }
        
        /// <summary>
        /// Remote signal strength
        /// </summary>
        public byte Remrssi
        {
            get
            {
                return this._remrssi;
            }
            set
            {
                this._remrssi = value;
            }
        }
        
        /// <summary>
        /// Remaining free buffer space in percent.
        /// </summary>
        public byte Txbuf
        {
            get
            {
                return this._txbuf;
            }
            set
            {
                this._txbuf = value;
            }
        }
        
        /// <summary>
        /// Background noise level
        /// </summary>
        public byte Noise
        {
            get
            {
                return this._noise;
            }
            set
            {
                this._noise = value;
            }
        }
        
        /// <summary>
        /// Remote background noise level
        /// </summary>
        public byte Remnoise
        {
            get
            {
                return this._remnoise;
            }
            set
            {
                this._remnoise = value;
            }
        }
        
        /// <summary>
        /// Receive errors
        /// </summary>
        public ushort Rxerrors
        {
            get
            {
                return this._rxerrors;
            }
            set
            {
                this._rxerrors = value;
            }
        }
        
        /// <summary>
        /// Count of error corrected packets
        /// </summary>
        public ushort Fixed
        {
            get
            {
                return this._fixed;
            }
            set
            {
                this._fixed = value;
            }
        }
    }
}