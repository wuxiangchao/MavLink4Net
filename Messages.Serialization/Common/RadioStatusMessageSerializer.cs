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
    
    
    public class RadioStatusMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.RadioStatusMessage tMessage = message as MavLink4Net.Messages.Common.RadioStatusMessage;
            writer.Write(tMessage.Rxerrors);
            writer.Write(tMessage.Fixed);
            writer.Write(tMessage.Rssi);
            writer.Write(tMessage.Remrssi);
            writer.Write(tMessage.Txbuf);
            writer.Write(tMessage.Noise);
            writer.Write(tMessage.Remnoise);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.RadioStatusMessage message = new MavLink4Net.Messages.Common.RadioStatusMessage();
            message.Rxerrors = reader.ReadUInt16();
            message.Fixed = reader.ReadUInt16();
            message.Rssi = reader.ReadByte();
            message.Remrssi = reader.ReadByte();
            message.Txbuf = reader.ReadByte();
            message.Noise = reader.ReadByte();
            message.Remnoise = reader.ReadByte();
            return message;
        }
    }
}