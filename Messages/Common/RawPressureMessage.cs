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
    /// The RAW pressure readings for the typical setup of one absolute pressure and one differential pressure sensor. The sensor values should be the raw, UNSCALED ADC values.
    /// </summary>
    /// <remarks>
    /// RAW_PRESSURE
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.RawPressure, Name="RAW_PRESSURE", Description="The RAW pressure readings for the typical setup of one absolute pressure and one " +
        "differential pressure sensor. The sensor values should be the raw, UNSCALED ADC " +
        "values.")]
    public class RawPressureMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (microseconds since UNIX epoch or microseconds since system boot)
        /// </summary>
        /// <remarks>
        /// time_usec
        /// </remarks>
        private ulong _timeUsec;
        
        /// <summary>
        /// Absolute pressure (raw)
        /// </summary>
        /// <remarks>
        /// press_abs
        /// </remarks>
        private short _pressAbs;
        
        /// <summary>
        /// Differential pressure 1 (raw, 0 if nonexistant)
        /// </summary>
        /// <remarks>
        /// press_diff1
        /// </remarks>
        private short _pressDiff1;
        
        /// <summary>
        /// Differential pressure 2 (raw, 0 if nonexistant)
        /// </summary>
        /// <remarks>
        /// press_diff2
        /// </remarks>
        private short _pressDiff2;
        
        /// <summary>
        /// Raw Temperature measurement (raw)
        /// </summary>
        /// <remarks>
        /// temperature
        /// </remarks>
        private short _temperature;
        
        public RawPressureMessage() : 
                base(MavLink4Net.Messages.MavMessageType.RawPressure)
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
        /// Absolute pressure (raw)
        /// </summary>
        [MessageFieldMetadata(Name="press_abs", Type="int16_t", Description="Absolute pressure (raw)")]
        public short PressAbs
        {
            get
            {
                return this._pressAbs;
            }
            set
            {
                this._pressAbs = value;
            }
        }
        
        /// <summary>
        /// Differential pressure 1 (raw, 0 if nonexistant)
        /// </summary>
        [MessageFieldMetadata(Name="press_diff1", Type="int16_t", Description="Differential pressure 1 (raw, 0 if nonexistant)")]
        public short PressDiff1
        {
            get
            {
                return this._pressDiff1;
            }
            set
            {
                this._pressDiff1 = value;
            }
        }
        
        /// <summary>
        /// Differential pressure 2 (raw, 0 if nonexistant)
        /// </summary>
        [MessageFieldMetadata(Name="press_diff2", Type="int16_t", Description="Differential pressure 2 (raw, 0 if nonexistant)")]
        public short PressDiff2
        {
            get
            {
                return this._pressDiff2;
            }
            set
            {
                this._pressDiff2 = value;
            }
        }
        
        /// <summary>
        /// Raw Temperature measurement (raw)
        /// </summary>
        [MessageFieldMetadata(Name="temperature", Type="int16_t", Description="Raw Temperature measurement (raw)")]
        public short Temperature
        {
            get
            {
                return this._temperature;
            }
            set
            {
                this._temperature = value;
            }
        }
    }
}
