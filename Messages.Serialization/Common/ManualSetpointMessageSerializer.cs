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
    
    
    public class ManualSetpointMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.IMessage message)
        {
            MavLink4Net.Messages.Common.ManualSetpointMessage tMessage = message as MavLink4Net.Messages.Common.ManualSetpointMessage;
            writer.Write(tMessage.TimeBootMs);
            writer.Write(tMessage.Roll);
            writer.Write(tMessage.Pitch);
            writer.Write(tMessage.Yaw);
            writer.Write(tMessage.Thrust);
            writer.Write(tMessage.ModeSwitch);
            writer.Write(tMessage.ManualOverrideSwitch);
        }
        
        public MavLink4Net.Messages.IMessage Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.ManualSetpointMessage message = new MavLink4Net.Messages.Common.ManualSetpointMessage();
            message.TimeBootMs = reader.ReadUInt32();
            message.Roll = reader.ReadSingle();
            message.Pitch = reader.ReadSingle();
            message.Yaw = reader.ReadSingle();
            message.Thrust = reader.ReadSingle();
            message.ModeSwitch = reader.ReadByte();
            message.ManualOverrideSwitch = reader.ReadByte();
            return message;
        }
    }
}
