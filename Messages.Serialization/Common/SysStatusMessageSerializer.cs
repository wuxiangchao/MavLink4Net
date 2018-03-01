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
    
    
    public class SysStatusMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.SysStatusMessage tMessage = message as MavLink4Net.Messages.Common.SysStatusMessage;
            writer.Write(((uint)(tMessage.OnboardControlSensorsPresent)));
            writer.Write(((uint)(tMessage.OnboardControlSensorsEnabled)));
            writer.Write(((uint)(tMessage.OnboardControlSensorsHealth)));
            writer.Write(tMessage.Load);
            writer.Write(tMessage.VoltageBattery);
            writer.Write(tMessage.CurrentBattery);
            writer.Write(tMessage.DropRateComm);
            writer.Write(tMessage.ErrorsComm);
            writer.Write(tMessage.ErrorsCount1);
            writer.Write(tMessage.ErrorsCount2);
            writer.Write(tMessage.ErrorsCount3);
            writer.Write(tMessage.ErrorsCount4);
            writer.Write(tMessage.BatteryRemaining);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.SysStatusMessage message = new MavLink4Net.Messages.Common.SysStatusMessage();
            message.OnboardControlSensorsPresent = ((MavLink4Net.Messages.Common.SysStatusSensor)(reader.ReadUInt32()));
            message.OnboardControlSensorsEnabled = ((MavLink4Net.Messages.Common.SysStatusSensor)(reader.ReadUInt32()));
            message.OnboardControlSensorsHealth = ((MavLink4Net.Messages.Common.SysStatusSensor)(reader.ReadUInt32()));
            message.Load = reader.ReadUInt16();
            message.VoltageBattery = reader.ReadUInt16();
            message.CurrentBattery = reader.ReadInt16();
            message.DropRateComm = reader.ReadUInt16();
            message.ErrorsComm = reader.ReadUInt16();
            message.ErrorsCount1 = reader.ReadUInt16();
            message.ErrorsCount2 = reader.ReadUInt16();
            message.ErrorsCount3 = reader.ReadUInt16();
            message.ErrorsCount4 = reader.ReadUInt16();
            message.BatteryRemaining = reader.ReadSByte();
            return message;
        }
    }
}