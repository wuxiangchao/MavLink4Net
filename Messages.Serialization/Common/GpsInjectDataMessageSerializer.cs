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
    
    
    public class GpsInjectDataMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.IMessage message)
        {
            MavLink4Net.Messages.Common.GpsInjectDataMessage tMessage = message as MavLink4Net.Messages.Common.GpsInjectDataMessage;
            writer.Write(tMessage.TargetSystem);
            writer.Write(tMessage.TargetComponent);
            writer.Write(tMessage.Len);
            writer.Write(tMessage.Data[0]);
            writer.Write(tMessage.Data[1]);
            writer.Write(tMessage.Data[2]);
            writer.Write(tMessage.Data[3]);
            writer.Write(tMessage.Data[4]);
            writer.Write(tMessage.Data[5]);
            writer.Write(tMessage.Data[6]);
            writer.Write(tMessage.Data[7]);
            writer.Write(tMessage.Data[8]);
            writer.Write(tMessage.Data[9]);
            writer.Write(tMessage.Data[10]);
            writer.Write(tMessage.Data[11]);
            writer.Write(tMessage.Data[12]);
            writer.Write(tMessage.Data[13]);
            writer.Write(tMessage.Data[14]);
            writer.Write(tMessage.Data[15]);
            writer.Write(tMessage.Data[16]);
            writer.Write(tMessage.Data[17]);
            writer.Write(tMessage.Data[18]);
            writer.Write(tMessage.Data[19]);
            writer.Write(tMessage.Data[20]);
            writer.Write(tMessage.Data[21]);
            writer.Write(tMessage.Data[22]);
            writer.Write(tMessage.Data[23]);
            writer.Write(tMessage.Data[24]);
            writer.Write(tMessage.Data[25]);
            writer.Write(tMessage.Data[26]);
            writer.Write(tMessage.Data[27]);
            writer.Write(tMessage.Data[28]);
            writer.Write(tMessage.Data[29]);
            writer.Write(tMessage.Data[30]);
            writer.Write(tMessage.Data[31]);
            writer.Write(tMessage.Data[32]);
            writer.Write(tMessage.Data[33]);
            writer.Write(tMessage.Data[34]);
            writer.Write(tMessage.Data[35]);
            writer.Write(tMessage.Data[36]);
            writer.Write(tMessage.Data[37]);
            writer.Write(tMessage.Data[38]);
            writer.Write(tMessage.Data[39]);
            writer.Write(tMessage.Data[40]);
            writer.Write(tMessage.Data[41]);
            writer.Write(tMessage.Data[42]);
            writer.Write(tMessage.Data[43]);
            writer.Write(tMessage.Data[44]);
            writer.Write(tMessage.Data[45]);
            writer.Write(tMessage.Data[46]);
            writer.Write(tMessage.Data[47]);
            writer.Write(tMessage.Data[48]);
            writer.Write(tMessage.Data[49]);
            writer.Write(tMessage.Data[50]);
            writer.Write(tMessage.Data[51]);
            writer.Write(tMessage.Data[52]);
            writer.Write(tMessage.Data[53]);
            writer.Write(tMessage.Data[54]);
            writer.Write(tMessage.Data[55]);
            writer.Write(tMessage.Data[56]);
            writer.Write(tMessage.Data[57]);
            writer.Write(tMessage.Data[58]);
            writer.Write(tMessage.Data[59]);
            writer.Write(tMessage.Data[60]);
            writer.Write(tMessage.Data[61]);
            writer.Write(tMessage.Data[62]);
            writer.Write(tMessage.Data[63]);
            writer.Write(tMessage.Data[64]);
            writer.Write(tMessage.Data[65]);
            writer.Write(tMessage.Data[66]);
            writer.Write(tMessage.Data[67]);
            writer.Write(tMessage.Data[68]);
            writer.Write(tMessage.Data[69]);
            writer.Write(tMessage.Data[70]);
            writer.Write(tMessage.Data[71]);
            writer.Write(tMessage.Data[72]);
            writer.Write(tMessage.Data[73]);
            writer.Write(tMessage.Data[74]);
            writer.Write(tMessage.Data[75]);
            writer.Write(tMessage.Data[76]);
            writer.Write(tMessage.Data[77]);
            writer.Write(tMessage.Data[78]);
            writer.Write(tMessage.Data[79]);
            writer.Write(tMessage.Data[80]);
            writer.Write(tMessage.Data[81]);
            writer.Write(tMessage.Data[82]);
            writer.Write(tMessage.Data[83]);
            writer.Write(tMessage.Data[84]);
            writer.Write(tMessage.Data[85]);
            writer.Write(tMessage.Data[86]);
            writer.Write(tMessage.Data[87]);
            writer.Write(tMessage.Data[88]);
            writer.Write(tMessage.Data[89]);
            writer.Write(tMessage.Data[90]);
            writer.Write(tMessage.Data[91]);
            writer.Write(tMessage.Data[92]);
            writer.Write(tMessage.Data[93]);
            writer.Write(tMessage.Data[94]);
            writer.Write(tMessage.Data[95]);
            writer.Write(tMessage.Data[96]);
            writer.Write(tMessage.Data[97]);
            writer.Write(tMessage.Data[98]);
            writer.Write(tMessage.Data[99]);
            writer.Write(tMessage.Data[100]);
            writer.Write(tMessage.Data[101]);
            writer.Write(tMessage.Data[102]);
            writer.Write(tMessage.Data[103]);
            writer.Write(tMessage.Data[104]);
            writer.Write(tMessage.Data[105]);
            writer.Write(tMessage.Data[106]);
            writer.Write(tMessage.Data[107]);
            writer.Write(tMessage.Data[108]);
            writer.Write(tMessage.Data[109]);
        }
        
        public MavLink4Net.Messages.IMessage Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.GpsInjectDataMessage message = new MavLink4Net.Messages.Common.GpsInjectDataMessage();
            message.TargetSystem = reader.ReadByte();
            message.TargetComponent = reader.ReadByte();
            message.Len = reader.ReadByte();
            message.Data[0] = reader.ReadByte();
            message.Data[1] = reader.ReadByte();
            message.Data[2] = reader.ReadByte();
            message.Data[3] = reader.ReadByte();
            message.Data[4] = reader.ReadByte();
            message.Data[5] = reader.ReadByte();
            message.Data[6] = reader.ReadByte();
            message.Data[7] = reader.ReadByte();
            message.Data[8] = reader.ReadByte();
            message.Data[9] = reader.ReadByte();
            message.Data[10] = reader.ReadByte();
            message.Data[11] = reader.ReadByte();
            message.Data[12] = reader.ReadByte();
            message.Data[13] = reader.ReadByte();
            message.Data[14] = reader.ReadByte();
            message.Data[15] = reader.ReadByte();
            message.Data[16] = reader.ReadByte();
            message.Data[17] = reader.ReadByte();
            message.Data[18] = reader.ReadByte();
            message.Data[19] = reader.ReadByte();
            message.Data[20] = reader.ReadByte();
            message.Data[21] = reader.ReadByte();
            message.Data[22] = reader.ReadByte();
            message.Data[23] = reader.ReadByte();
            message.Data[24] = reader.ReadByte();
            message.Data[25] = reader.ReadByte();
            message.Data[26] = reader.ReadByte();
            message.Data[27] = reader.ReadByte();
            message.Data[28] = reader.ReadByte();
            message.Data[29] = reader.ReadByte();
            message.Data[30] = reader.ReadByte();
            message.Data[31] = reader.ReadByte();
            message.Data[32] = reader.ReadByte();
            message.Data[33] = reader.ReadByte();
            message.Data[34] = reader.ReadByte();
            message.Data[35] = reader.ReadByte();
            message.Data[36] = reader.ReadByte();
            message.Data[37] = reader.ReadByte();
            message.Data[38] = reader.ReadByte();
            message.Data[39] = reader.ReadByte();
            message.Data[40] = reader.ReadByte();
            message.Data[41] = reader.ReadByte();
            message.Data[42] = reader.ReadByte();
            message.Data[43] = reader.ReadByte();
            message.Data[44] = reader.ReadByte();
            message.Data[45] = reader.ReadByte();
            message.Data[46] = reader.ReadByte();
            message.Data[47] = reader.ReadByte();
            message.Data[48] = reader.ReadByte();
            message.Data[49] = reader.ReadByte();
            message.Data[50] = reader.ReadByte();
            message.Data[51] = reader.ReadByte();
            message.Data[52] = reader.ReadByte();
            message.Data[53] = reader.ReadByte();
            message.Data[54] = reader.ReadByte();
            message.Data[55] = reader.ReadByte();
            message.Data[56] = reader.ReadByte();
            message.Data[57] = reader.ReadByte();
            message.Data[58] = reader.ReadByte();
            message.Data[59] = reader.ReadByte();
            message.Data[60] = reader.ReadByte();
            message.Data[61] = reader.ReadByte();
            message.Data[62] = reader.ReadByte();
            message.Data[63] = reader.ReadByte();
            message.Data[64] = reader.ReadByte();
            message.Data[65] = reader.ReadByte();
            message.Data[66] = reader.ReadByte();
            message.Data[67] = reader.ReadByte();
            message.Data[68] = reader.ReadByte();
            message.Data[69] = reader.ReadByte();
            message.Data[70] = reader.ReadByte();
            message.Data[71] = reader.ReadByte();
            message.Data[72] = reader.ReadByte();
            message.Data[73] = reader.ReadByte();
            message.Data[74] = reader.ReadByte();
            message.Data[75] = reader.ReadByte();
            message.Data[76] = reader.ReadByte();
            message.Data[77] = reader.ReadByte();
            message.Data[78] = reader.ReadByte();
            message.Data[79] = reader.ReadByte();
            message.Data[80] = reader.ReadByte();
            message.Data[81] = reader.ReadByte();
            message.Data[82] = reader.ReadByte();
            message.Data[83] = reader.ReadByte();
            message.Data[84] = reader.ReadByte();
            message.Data[85] = reader.ReadByte();
            message.Data[86] = reader.ReadByte();
            message.Data[87] = reader.ReadByte();
            message.Data[88] = reader.ReadByte();
            message.Data[89] = reader.ReadByte();
            message.Data[90] = reader.ReadByte();
            message.Data[91] = reader.ReadByte();
            message.Data[92] = reader.ReadByte();
            message.Data[93] = reader.ReadByte();
            message.Data[94] = reader.ReadByte();
            message.Data[95] = reader.ReadByte();
            message.Data[96] = reader.ReadByte();
            message.Data[97] = reader.ReadByte();
            message.Data[98] = reader.ReadByte();
            message.Data[99] = reader.ReadByte();
            message.Data[100] = reader.ReadByte();
            message.Data[101] = reader.ReadByte();
            message.Data[102] = reader.ReadByte();
            message.Data[103] = reader.ReadByte();
            message.Data[104] = reader.ReadByte();
            message.Data[105] = reader.ReadByte();
            message.Data[106] = reader.ReadByte();
            message.Data[107] = reader.ReadByte();
            message.Data[108] = reader.ReadByte();
            message.Data[109] = reader.ReadByte();
            return message;
        }
    }
}
