// <auto-generated />

namespace gfl.terrain.fb
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TerrainConfigType : uint
    {
        None = 0,
        Detail = 1,
    }

    public class DetailConfigItem
    {
        [Newtonsoft.Json.JsonProperty("index")]
        public int Index { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("detail")]
        public gfl.terrain.fb.Detail Detail { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.terrain.fb.DetailConfigItem FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.terrain.fb.DetailConfigItem>(jsonText);
        }
    }

    public class TerrainConfig
    {
        [Newtonsoft.Json.JsonProperty("version")]
        public uint Version { get; set; } = 1u;

        [Newtonsoft.Json.JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [Newtonsoft.Json.JsonProperty("config_item_list")]
        public System.Collections.Generic.List<gfl.terrain.fb.TerrainConfigItem> ConfigItemList { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.terrain.fb.TerrainConfig FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.terrain.fb.TerrainConfig>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static gfl.terrain.fb.TerrainConfig FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "trtrcj";

        public static readonly string BFBS_BASE64 = "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AAAADwsAAAADAAAAbWF4AAwAEgAIAAwAAAAGAAwAAAAAAAQAIAAAABAAAAAAAAoADAAHAAAACAAKAAAAAAAADwsAAAADAAAAbWluADb///8AAAABJAAAAAwAAAAEAAAAEAAAAAQAAAAsAAAAkAAAAGQAAABAAAAAFgAAAGdmbC50ZXJyYWluLmZiLlZlY3RvcjQAAAz///8DAAwAEAAAAAQAAADa/v//AAAACwEAAAB3AAAALP///wIACAAQAAAABAAAAPr+//8AAAALAQAAAHoAAABM////AQAEABAAAAAEAAAAGv///wAAAAsBAAAAeQAAAAgADAAEAAgACAAAABAAAAAEAAAAPv///wAAAAsBAAAAeAAOABgACAAMAAcAEAAUAA4AAAAAAAABIAAAAAwAAAAEAAAADAAAAAMAAAB8AAAAUAAAACAAAAAWAAAAZ2ZsLnRlcnJhaW4uZmIuVmVjdG9yMwAA4P///wIACAAQAAAABAAAAK7///8AAAALAQAAAHoAAAAMABAACAAMAAQABgAMAAAAAQAEABAAAAAEAAAA2v///wAAAAsBAAAAeQAAAAgADgAEAAgACAAAABgAAAAMAAAAAAAGAAgABwAGAAAAAAAACwEAAAB4AAAA";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }

    public class TerrainConfigItem
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("type")]
        public gfl.terrain.fb.TerrainConfigType Type { get; set; } = (gfl.terrain.fb.TerrainConfigType)0;

        [Newtonsoft.Json.JsonProperty("detail_config_item")]
        public gfl.terrain.fb.DetailConfigItem DetailConfigItem { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.terrain.fb.TerrainConfigItem FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.terrain.fb.TerrainConfigItem>(jsonText);
        }
    }
}
