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
    
    
    public class TerrainRequestMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.IMessage message)
        {
            MavLink4Net.Messages.Common.TerrainRequestMessage tMessage = message as MavLink4Net.Messages.Common.TerrainRequestMessage;
            writer.Write(tMessage.Mask);
            writer.Write(tMessage.Lat);
            writer.Write(tMessage.Lon);
            writer.Write(tMessage.GridSpacing);
        }
        
        public MavLink4Net.Messages.IMessage Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.TerrainRequestMessage message = new MavLink4Net.Messages.Common.TerrainRequestMessage();
            message.Mask = reader.ReadUInt64();
            message.Lat = reader.ReadInt32();
            message.Lon = reader.ReadInt32();
            message.GridSpacing = reader.ReadUInt16();
            return message;
        }
    }
}
