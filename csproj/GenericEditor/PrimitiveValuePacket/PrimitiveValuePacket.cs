// <auto-generated />

namespace GenericEditor.Plugin.PrimitiveValuePacket
{
    public abstract class ValueUnion
    {
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum UnionType : uint
        {
            NONE = 0,
            IntValue = 1,
            FloatValue = 2,
            StringValue = 3,
            BoolValue = 4,
        }

        public static ValueUnion.UnionType GetUnionType(ValueUnion obj)
        {
            switch (obj)
            {
            default: return UnionType.NONE;
            case IntValue _: return UnionType.IntValue;
            case FloatValue _: return UnionType.FloatValue;
            case StringValue _: return UnionType.StringValue;
            case BoolValue _: return UnionType.BoolValue;
            }
        }

        public class Converter : Newtonsoft.Json.JsonConverter
        {
            public static UnionType UnionType { get; set; }

            public override bool CanConvert(System.Type objectType)
            {
                return objectType == typeof(ValueUnion);
            }

            public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
                switch (UnionType)
                {
                default: return null;
                case UnionType.IntValue: return serializer.Deserialize<IntValue>(reader);
                case UnionType.FloatValue: return serializer.Deserialize<FloatValue>(reader);
                case UnionType.StringValue: return serializer.Deserialize<StringValue>(reader);
                case UnionType.BoolValue: return serializer.Deserialize<BoolValue>(reader);
                }
            }

            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }

    }

    public class BoolValue : GenericEditor.Plugin.PrimitiveValuePacket.ValueUnion
    {
        [Newtonsoft.Json.JsonProperty("value")]
        public System.Collections.Generic.List<bool> Value { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static GenericEditor.Plugin.PrimitiveValuePacket.BoolValue FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericEditor.Plugin.PrimitiveValuePacket.BoolValue>(jsonText);
        }
    }

    public class Data
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("value_type")]
        public GenericEditor.Plugin.PrimitiveValuePacket.ValueUnion.UnionType ValueType
        {
            get => GenericEditor.Plugin.PrimitiveValuePacket.ValueUnion.GetUnionType(this.Value);
            private set => GenericEditor.Plugin.PrimitiveValuePacket.ValueUnion.Converter.UnionType = value;
        }

        [Newtonsoft.Json.JsonProperty("value"), Newtonsoft.Json.JsonConverter(typeof(GenericEditor.Plugin.PrimitiveValuePacket.ValueUnion.Converter))]
        public GenericEditor.Plugin.PrimitiveValuePacket.ValueUnion Value { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static GenericEditor.Plugin.PrimitiveValuePacket.Data FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericEditor.Plugin.PrimitiveValuePacket.Data>(jsonText);
        }
    }

    public class FloatValue : GenericEditor.Plugin.PrimitiveValuePacket.ValueUnion
    {
        [Newtonsoft.Json.JsonProperty("value")]
        public System.Collections.Generic.List<float> Value { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static GenericEditor.Plugin.PrimitiveValuePacket.FloatValue FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericEditor.Plugin.PrimitiveValuePacket.FloatValue>(jsonText);
        }
    }

    public class IntValue : GenericEditor.Plugin.PrimitiveValuePacket.ValueUnion
    {
        [Newtonsoft.Json.JsonProperty("value")]
        public System.Collections.Generic.List<int> Value { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static GenericEditor.Plugin.PrimitiveValuePacket.IntValue FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericEditor.Plugin.PrimitiveValuePacket.IntValue>(jsonText);
        }
    }

    public class Root
    {
        [Newtonsoft.Json.JsonProperty("list")]
        public System.Collections.Generic.List<GenericEditor.Plugin.PrimitiveValuePacket.Data> List { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static GenericEditor.Plugin.PrimitiveValuePacket.Root FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericEditor.Plugin.PrimitiveValuePacket.Root>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static GenericEditor.Plugin.PrimitiveValuePacket.Root FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "";

        public static readonly string BFBS_BASE64 = "HAAAAEJGQlMAAAAAEAAcAAQACAAMABAAFAAYABAAAAA0AAAAKAAAABwAAAAQAAAA3AEAAAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEAAAAsAAAABgAAADgDAAAwAgAAHAQAAJwEAACkAQAAmAMAAAwAFAAIAAwABwAQAAwAAAAAAAABMAAAABQAAAAEAAAAXv3//wAAAAEAAAAABQAAAEwBAAAEAQAAwAAAAHwAAABAAAAANAAAAEdlbmVyaWNFZGl0b3IuUGx1Z2luLlByaW1pdGl2ZVZhbHVlUGFja2V0LlZhbHVlVW5pb24AAAAAVP///yQAAACYAgAAEAAAAAQAAAAAAAAAAAAAANr9//8AAAAPAAAAAAkAAABCb29sVmFsdWUAAADM////IAAAANQCAAAMAAAAAwAAAAAAAAAO/v//AAAADwUAAAALAAAAU3RyaW5nVmFsdWUADAAYAAQAEAAIAAwADAAAACAAAAAMAwAADAAAAAIAAAAAAAAATv7//wAAAA8CAAAACgAAAEZsb2F0VmFsdWUAAAwAHAAEABAACAAMAAwAAAAkAAAAUAMAABAAAAABAAAAAAAAAAAAAACS/v//AAAADwMAAAAIAAAASW50VmFsdWUAAAAADAAMAAQAAAAAAAgADAAAABAAAAAIAAAABAAEAAQAAAAEAAAATk9ORQAAAAAY/f//FAAAAAgAAAABAAAAAQAAADgAAAAuAAAAR2VuZXJpY0VkaXRvci5QbHVnaW4uUHJpbWl0aXZlVmFsdWVQYWNrZXQuUm9vdAAAAP///wAABAAgAAAAEAAAAAAACgAMAAYABwAIAAoAAAAAAA4PAQAAAAQAAABsaXN0AAAAAJj9//8cAAAACAAAAAEAAAADAAAAxAAAAEgAAAB4AAAALgAAAEdlbmVyaWNFZGl0b3IuUGx1Z2luLlByaW1pdGl2ZVZhbHVlUGFja2V0LkRhdGEAAAwAEAAIAAwABAAGAAwAAAACAAgAFAAAAAQAAADK////AAAAEAAAAAAFAAAAdmFsdWUAAAAMABIACAAMAAQABgAMAAAAAQAGACAAAAAQAAAAAAAKAAwABwAAAAgACgAAAAAAAAEAAAAACgAAAHZhbHVlX3R5cGUAAAwAEgAIAAwAAAAGAAwAAAAAAAQAGAAAAAwAAAAAAAYACAAHAAYAAAAAAAANBAAAAG5hbWUAAAAAnP7//xQAAAAIAAAAAQAAAAEAAAA8AAAAMwAAAEdlbmVyaWNFZGl0b3IuUGx1Z2luLlByaW1pdGl2ZVZhbHVlUGFja2V0LkJvb2xWYWx1ZQCQ/v//AAAEABAAAAAEAAAAhP7//wAADgIFAAAAdmFsdWUAAAAQ////FAAAAAgAAAABAAAAAQAAAEAAAAA1AAAAR2VuZXJpY0VkaXRvci5QbHVnaW4uUHJpbWl0aXZlVmFsdWVQYWNrZXQuU3RyaW5nVmFsdWUAAAAI////AAAEABAAAAAEAAAA/P7//wAADg0FAAAAdmFsdWUAAACI////FAAAAAgAAAABAAAAAQAAAEAAAAA0AAAAR2VuZXJpY0VkaXRvci5QbHVnaW4uUHJpbWl0aXZlVmFsdWVQYWNrZXQuRmxvYXRWYWx1ZQAAAACA////AAAEABAAAAAEAAAAdP///wAADgsFAAAAdmFsdWUAAAAMABAABAAIAAAADAAMAAAAFAAAAAgAAAABAAAAAQAAAEgAAAAyAAAAR2VuZXJpY0VkaXRvci5QbHVnaW4uUHJpbWl0aXZlVmFsdWVQYWNrZXQuSW50VmFsdWUAAAwAEAAIAAwAAAAGAAwAAAAAAAQAGAAAAAwAAAAIAAgABgAHAAgAAAAAAA4HBQAAAHZhbHVlAAAA";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }

    public class StringValue : GenericEditor.Plugin.PrimitiveValuePacket.ValueUnion
    {
        [Newtonsoft.Json.JsonProperty("value")]
        public System.Collections.Generic.List<string> Value { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static GenericEditor.Plugin.PrimitiveValuePacket.StringValue FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericEditor.Plugin.PrimitiveValuePacket.StringValue>(jsonText);
        }
    }
}
