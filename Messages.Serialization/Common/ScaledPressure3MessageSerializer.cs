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
    
    
    public class ScaledPressure3MessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.IMessage message)
        {
            MavLink4Net.Messages.Common.ScaledPressure3Message tMessage = message as MavLink4Net.Messages.Common.ScaledPressure3Message;
            writer.Write(tMessage.TimeBootMs);
            writer.Write(tMessage.PressAbs);
            writer.Write(tMessage.PressDiff);
            writer.Write(tMessage.Temperature);
        }
        
        public MavLink4Net.Messages.IMessage Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.ScaledPressure3Message message = new MavLink4Net.Messages.Common.ScaledPressure3Message();
            message.TimeBootMs = reader.ReadUInt32();
            message.PressAbs = reader.ReadSingle();
            message.PressDiff = reader.ReadSingle();
            message.Temperature = reader.ReadInt16();
            return message;
        }
    }
}
