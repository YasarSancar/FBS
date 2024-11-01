// <auto-generated />


namespace pe.field.fb
{
    public class ReceiveWindSpringBoneComponent
    {
        [Newtonsoft.Json.JsonProperty("instanceName")]
        public string InstanceName { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static pe.field.fb.ReceiveWindSpringBoneComponent FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<pe.field.fb.ReceiveWindSpringBoneComponent>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static pe.field.fb.ReceiveWindSpringBoneComponent FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "";

        public static readonly string BFBS_BASE64 = "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";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }
}
