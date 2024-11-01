// <auto-generated />


namespace pokemon_engine.text.fb
{
    public class TextComponent
    {
        [Newtonsoft.Json.JsonProperty("filePath")]
        public string FilePath { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static pokemon_engine.text.fb.TextComponent FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<pokemon_engine.text.fb.TextComponent>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static pokemon_engine.text.fb.TextComponent FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "";

        public static readonly string BFBS_BASE64 = "GAAAAEJGQlMQABwABAAIAAwAEAAUABgAEAAAADAAAAAoAAAAHAAAABAAAAA0AAAABAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEAAAAQAAAADAAQAAQACAAAAAwADAAAABQAAAAIAAAAAQAAAAEAAAA8AAAAJAAAAHBva2Vtb25fZW5naW5lLnRleHQuZmIuVGV4dENvbXBvbmVudAAAAAAMABIACAAMAAAABgAMAAAAAAAEABgAAAAMAAAAAAAGAAgABwAGAAAAAAAADQgAAABmaWxlUGF0aAAAAAA=";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }
}
