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
    
    
    public class CommandAckMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.CommandAckMessage tMessage = message as MavLink4Net.Messages.Common.CommandAckMessage;
            writer.Write(tMessage.ResultParam2);
            writer.Write(((ushort)(tMessage.Command)));
            writer.Write(((byte)(tMessage.Result)));
            writer.Write(tMessage.Progress);
            writer.Write(tMessage.TargetSystem);
            writer.Write(tMessage.TargetComponent);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.CommandAckMessage message = new MavLink4Net.Messages.Common.CommandAckMessage();
            message.ResultParam2 = reader.ReadInt32();
            message.Command = ((MavLink4Net.Messages.Common.Cmd)(reader.ReadUInt16()));
            message.Result = ((MavLink4Net.Messages.Common.Result)(reader.ReadByte()));
            message.Progress = reader.ReadByte();
            message.TargetSystem = reader.ReadByte();
            message.TargetComponent = reader.ReadByte();
            return message;
        }
    }
}