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
    
    
    public class VisionSpeedEstimateMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.IMessage message)
        {
            MavLink4Net.Messages.Common.VisionSpeedEstimateMessage tMessage = message as MavLink4Net.Messages.Common.VisionSpeedEstimateMessage;
            writer.Write(tMessage.Usec);
            writer.Write(tMessage.X);
            writer.Write(tMessage.Y);
            writer.Write(tMessage.Z);
        }
        
        public MavLink4Net.Messages.IMessage Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.VisionSpeedEstimateMessage message = new MavLink4Net.Messages.Common.VisionSpeedEstimateMessage();
            message.Usec = reader.ReadUInt64();
            message.X = reader.ReadSingle();
            message.Y = reader.ReadSingle();
            message.Z = reader.ReadSingle();
            return message;
        }
    }
}
