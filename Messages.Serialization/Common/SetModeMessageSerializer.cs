//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MavLink4Net.Messages.Serialization.Common
{
    
    
    public class SetModeMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.IMessage message)
        {
            MavLink4Net.Messages.Common.SetModeMessage tMessage = message as MavLink4Net.Messages.Common.SetModeMessage;
            writer.Write(tMessage.CustomMode);
            writer.Write(tMessage.TargetSystem);
            writer.Write(((byte)(tMessage.BaseMode)));
        }
        
        public MavLink4Net.Messages.IMessage Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.SetModeMessage message = new MavLink4Net.Messages.Common.SetModeMessage();
            message.CustomMode = reader.ReadUInt32();
            message.TargetSystem = reader.ReadByte();
            message.BaseMode = ((MavLink4Net.Messages.Common.Mode)(reader.ReadByte()));
            return message;
        }
    }
}
