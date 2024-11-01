// <auto-generated />


namespace pe.network.fb
{
    public class NetworkScriptRPCComponent
    {
        [Newtonsoft.Json.JsonProperty("index")]
        public int Index { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("stackSize")]
        public int StackSize { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("bufferSize")]
        public int BufferSize { get; set; } = 0;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static pe.network.fb.NetworkScriptRPCComponent FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<pe.network.fb.NetworkScriptRPCComponent>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static pe.network.fb.NetworkScriptRPCComponent FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "";

        public static readonly string BFBS_BASE64 = "GAAAAEJGQlMQABwABAAIAAwAEAAUABgAEAAAADAAAAAoAAAAHAAAABAAAAA0AAAABAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEAAAAQAAAADAAQAAQACAAAAAwADAAAABwAAAAIAAAAAQAAAAMAAAA4AAAAnAAAAGQAAAAnAAAAcGUubmV0d29yay5mYi5OZXR3b3JrU2NyaXB0UlBDQ29tcG9uZW50ANj///8CAAgAEAAAAAQAAACW////AAAABwoAAABidWZmZXJTaXplAAAMABAACAAMAAQABgAMAAAAAQAGABAAAAAEAAAAyv///wAAAAcJAAAAc3RhY2tTaXplAAAADAASAAgADAAAAAYADAAAAAAABAAYAAAADAAAAAAABgAIAAcABgAAAAAAAAcFAAAAaW5kZXgAAAA=";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }
}
