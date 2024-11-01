// <auto-generated />


namespace GenericEditor.Plugin.Model
{
    public class LocatorUpdateData
    {
        [Newtonsoft.Json.JsonProperty("instanceName")]
        public string InstanceName { get; set; }

        [Newtonsoft.Json.JsonProperty("filePath")]
        public string FilePath { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static GenericEditor.Plugin.Model.LocatorUpdateData FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericEditor.Plugin.Model.LocatorUpdateData>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static GenericEditor.Plugin.Model.LocatorUpdateData FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "";

        public static readonly string BFBS_BASE64 = "GAAAAEJGQlMQABwABAAIAAwAEAAUABgAEAAAADAAAAAoAAAAHAAAABAAAAA0AAAABAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEAAAAQAAAADAAQAAQACAAAAAwADAAAABgAAAAIAAAAAQAAAAIAAABIAAAAeAAAACwAAABHZW5lcmljRWRpdG9yLlBsdWdpbi5Nb2RlbC5Mb2NhdG9yVXBkYXRlRGF0YQAAAAAMABAACAAMAAQABgAMAAAAAQAGABAAAAAEAAAAyv///wAAAA0IAAAAZmlsZVBhdGgAAAAADAASAAgADAAAAAYADAAAAAAABAAYAAAADAAAAAAABgAIAAcABgAAAAAAAA0MAAAAaW5zdGFuY2VOYW1lAAAAAA==";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }
}
