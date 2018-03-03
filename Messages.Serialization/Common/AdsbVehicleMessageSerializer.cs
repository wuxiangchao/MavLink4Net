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


namespace MavLink4Net.Messages.Serialization.Common
{
    
    
    public class AdsbVehicleMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.IMessage message)
        {
            MavLink4Net.Messages.Common.AdsbVehicleMessage tMessage = message as MavLink4Net.Messages.Common.AdsbVehicleMessage;
            writer.Write(tMessage.IcaoAddress);
            writer.Write(tMessage.Lat);
            writer.Write(tMessage.Lon);
            writer.Write(tMessage.Altitude);
            writer.Write(tMessage.Heading);
            writer.Write(tMessage.HorVelocity);
            writer.Write(tMessage.VerVelocity);
            writer.Write(((ushort)(tMessage.Flags)));
            writer.Write(tMessage.Squawk);
            writer.Write(((byte)(tMessage.AltitudeType)));
            writer.Write(tMessage.Callsign[0]);
            writer.Write(tMessage.Callsign[1]);
            writer.Write(tMessage.Callsign[2]);
            writer.Write(tMessage.Callsign[3]);
            writer.Write(tMessage.Callsign[4]);
            writer.Write(tMessage.Callsign[5]);
            writer.Write(tMessage.Callsign[6]);
            writer.Write(tMessage.Callsign[7]);
            writer.Write(tMessage.Callsign[8]);
            writer.Write(((byte)(tMessage.EmitterType)));
            writer.Write(tMessage.Tslc);
        }
        
        public MavLink4Net.Messages.IMessage Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.AdsbVehicleMessage message = new MavLink4Net.Messages.Common.AdsbVehicleMessage();
            message.IcaoAddress = reader.ReadUInt32();
            message.Lat = reader.ReadInt32();
            message.Lon = reader.ReadInt32();
            message.Altitude = reader.ReadInt32();
            message.Heading = reader.ReadUInt16();
            message.HorVelocity = reader.ReadUInt16();
            message.VerVelocity = reader.ReadInt16();
            message.Flags = ((MavLink4Net.Messages.Common.AdsbFlags)(reader.ReadUInt16()));
            message.Squawk = reader.ReadUInt16();
            message.AltitudeType = ((MavLink4Net.Messages.Common.AdsbAltitudeType)(reader.ReadByte()));
            message.Callsign[0] = reader.ReadChar();
            message.Callsign[1] = reader.ReadChar();
            message.Callsign[2] = reader.ReadChar();
            message.Callsign[3] = reader.ReadChar();
            message.Callsign[4] = reader.ReadChar();
            message.Callsign[5] = reader.ReadChar();
            message.Callsign[6] = reader.ReadChar();
            message.Callsign[7] = reader.ReadChar();
            message.Callsign[8] = reader.ReadChar();
            message.EmitterType = ((MavLink4Net.Messages.Common.AdsbEmitterType)(reader.ReadByte()));
            message.Tslc = reader.ReadByte();
            return message;
        }
    }
}
