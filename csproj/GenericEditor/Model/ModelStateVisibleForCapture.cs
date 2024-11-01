// <auto-generated />


namespace GenericEditor.Plugin.Model
{
    public class ModelStateVisibleForCapture
    {
        [Newtonsoft.Json.JsonProperty("instanceName")]
        public string InstanceName { get; set; }

        [Newtonsoft.Json.JsonProperty("baseMeshName")]
        public string BaseMeshName { get; set; }

        [Newtonsoft.Json.JsonProperty("state")]
        public int State { get; set; } = 0;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static GenericEditor.Plugin.Model.ModelStateVisibleForCapture FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericEditor.Plugin.Model.ModelStateVisibleForCapture>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static GenericEditor.Plugin.Model.ModelStateVisibleForCapture FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "";

        public static readonly string BFBS_BASE64 = "GAAAAEJGQlMQABwABAAIAAwAEAAUABgAEAAAADAAAAAoAAAAHAAAABAAAAA0AAAABAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEAAAAQAAAADAAQAAQACAAAAAwADAAAABwAAAAIAAAAAQAAAAMAAAB4AAAArAAAAEAAAAA2AAAAR2VuZXJpY0VkaXRvci5QbHVnaW4uTW9kZWwuTW9kZWxTdGF0ZVZpc2libGVGb3JDYXB0dXJlAADc////AgAIABAAAAAEAAAAlv///wAAAAcFAAAAc3RhdGUAAAAMABAACAAMAAQABgAMAAAAAQAGABAAAAAEAAAAxv///wAAAA0MAAAAYmFzZU1lc2hOYW1lAAAAAAwAEgAIAAwAAAAGAAwAAAAAAAQAGAAAAAwAAAAAAAYACAAHAAYAAAAAAAANDAAAAGluc3RhbmNlTmFtZQAAAAA=";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }
}
