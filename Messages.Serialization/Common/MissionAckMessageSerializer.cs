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
    
    
    public class MissionAckMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.IMessage message)
        {
            MavLink4Net.Messages.Common.MissionAckMessage tMessage = message as MavLink4Net.Messages.Common.MissionAckMessage;
            writer.Write(tMessage.TargetSystem);
            writer.Write(tMessage.TargetComponent);
            writer.Write(((byte)(tMessage.Type)));
        }
        
        public MavLink4Net.Messages.IMessage Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.MissionAckMessage message = new MavLink4Net.Messages.Common.MissionAckMessage();
            message.TargetSystem = reader.ReadByte();
            message.TargetComponent = reader.ReadByte();
            message.Type = ((MavLink4Net.Messages.Common.MissionResult)(reader.ReadByte()));
            return message;
        }
    }
}
