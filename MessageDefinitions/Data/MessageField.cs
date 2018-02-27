﻿namespace MavLink4Net.MessageDefinitions.Data
{
    public class MessageField
    {
        public MessageFieldType Type { get; set; }

        public string Name { get; set; }

        public string Enum { get; set; }

        public string Units { get; set; }

        public string Display { get; set; }

        public string Text { get; set; }

        public bool IsEnum => !string.IsNullOrWhiteSpace(Enum);
    }
}