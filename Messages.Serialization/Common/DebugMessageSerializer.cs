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
    
    
    public class DebugMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.IMessage message)
        {
            MavLink4Net.Messages.Common.DebugMessage tMessage = message as MavLink4Net.Messages.Common.DebugMessage;
            writer.Write(tMessage.TimeBootMs);
            writer.Write(tMessage.Value);
            writer.Write(tMessage.Ind);
        }
        
        public MavLink4Net.Messages.IMessage Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.DebugMessage message = new MavLink4Net.Messages.Common.DebugMessage();
            message.TimeBootMs = reader.ReadUInt32();
            message.Value = reader.ReadSingle();
            message.Ind = reader.ReadByte();
            return message;
        }
    }
}
