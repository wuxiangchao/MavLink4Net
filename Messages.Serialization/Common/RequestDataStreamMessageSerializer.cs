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
    
    
    public class RequestDataStreamMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.RequestDataStreamMessage tMessage = message as MavLink4Net.Messages.Common.RequestDataStreamMessage;
            writer.Write(tMessage.ReqMessageRate);
            writer.Write(tMessage.TargetSystem);
            writer.Write(tMessage.TargetComponent);
            writer.Write(tMessage.ReqStreamId);
            writer.Write(tMessage.StartStop);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.RequestDataStreamMessage message = new MavLink4Net.Messages.Common.RequestDataStreamMessage();
            message.ReqMessageRate = reader.ReadUInt16();
            message.TargetSystem = reader.ReadByte();
            message.TargetComponent = reader.ReadByte();
            message.ReqStreamId = reader.ReadByte();
            message.StartStop = reader.ReadByte();
            return message;
        }
    }
}