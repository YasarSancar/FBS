// <auto-generated />


namespace gfl.gfx2.fb
{
    public class LocatorData
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("parent_name")]
        public string ParentName { get; set; }

        [Newtonsoft.Json.JsonProperty("position")]
        public gfl.gfx2.fb.Vector Position { get; set; }

        [Newtonsoft.Json.JsonProperty("rotation")]
        public gfl.gfx2.fb.Vector Rotation { get; set; }

        [Newtonsoft.Json.JsonProperty("scale")]
        public gfl.gfx2.fb.Vector Scale { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.LocatorData FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.LocatorData>(jsonText);
        }
    }

    public class LocatorDataParameter
    {
        [Newtonsoft.Json.JsonProperty("LocatorDataArray")]
        public System.Collections.Generic.List<gfl.gfx2.fb.LocatorData> LocatorDataArray { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.LocatorDataParameter FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.LocatorDataParameter>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static gfl.gfx2.fb.LocatorDataParameter FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "trloc";

        public static readonly string BFBS_BASE64 = "GAAAAEJGQlMQABwABAAIAAwAEAAUABgAEAAAADQAAAAsAAAAIAAAABAAAAA0AAAABAAAAAAAAAAFAAAAdHJsb2MAAAAAAAAAAAAAAAAAAAADAAAAjAAAAAgAAADEAQAATP7//xQAAAAIAAAAAQAAAAEAAAAsAAAAIAAAAGdmbC5nZngyLmZiLkxvY2F0b3JEYXRhUGFyYW1ldGVyAAAAAPz9//8AAAQAIAAAABAAAAAAAAoADAAGAAcACAAKAAAAAAAODwAAAAAQAAAATG9jYXRvckRhdGFBcnJheQAAAADM/v//JAAAAAgAAAABAAAABQAAAPwAAADEAAAAiAAAAEwAAAAgAAAAFwAAAGdmbC5nZngyLmZiLkxvY2F0b3JEYXRhAKz+//8EAAwAFAAAAAQAAACe////AAAADwIAAAAFAAAAc2NhbGUAAADU/v//AwAKABQAAAAEAAAAxv///wAAAA8CAAAACAAAAHJvdGF0aW9uAAAAAAwAEgAIAAwABAAGAAwAAAACAAgAIAAAABAAAAAAAAoADAAHAAAACAAKAAAAAAAADwIAAAAIAAAAcG9zaXRpb24AAAAARP///wEABgAQAAAABAAAAAr///8AAAANCwAAAHBhcmVudF9uYW1lAAwAEAAIAAwAAAAGAAwAAAAAAAQAEAAAAAQAAAA+////AAAADQQAAABuYW1lAAAAAAwAEAAEAAgAAAAMAAwAAAAcAAAACAAAAAEAAAADAAAAfAAAAEwAAAAcAAAAEgAAAGdmbC5nZngyLmZiLlZlY3RvcgAA4P///wIACAAQAAAABAAAAKb///8AAAALAQAAAHoAAAAMABAACAAMAAQABgAMAAAAAQAGABAAAAAEAAAA0v///wAAAAsBAAAAeQAAAAwAEgAIAAwAAAAGAAwAAAAAAAQAGAAAAAwAAAAAAAYACAAHAAYAAAAAAAALAQAAAHgAAAA=";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }

    public class Vector
    {
        [Newtonsoft.Json.JsonProperty("x")]
        public float X { get; set; } = 0.0f;

        [Newtonsoft.Json.JsonProperty("y")]
        public float Y { get; set; } = 0.0f;

        [Newtonsoft.Json.JsonProperty("z")]
        public float Z { get; set; } = 0.0f;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.Vector FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.Vector>(jsonText);
        }
    }
}