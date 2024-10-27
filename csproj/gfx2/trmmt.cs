// <auto-generated />


namespace gfl.gfx2.fb
{
    public class BoolParam
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("value")]
        public bool Value { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.BoolParam FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.BoolParam>(jsonText);
        }
    }

    public class ModelMetadata
    {
        [Newtonsoft.Json.JsonProperty("version")]
        public uint Version { get; set; } = 2u;

        [Newtonsoft.Json.JsonProperty("trmdlFilePath")]
        public string TrmdlFilePath { get; set; }

        [Newtonsoft.Json.JsonProperty("item_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.ModelMetadataItem> ItemList { get; set; }

        [Newtonsoft.Json.JsonProperty("ruleFilePath")]
        public string RuleFilePath { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.ModelMetadata FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.ModelMetadata>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static gfl.gfx2.fb.ModelMetadata FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "";

        public static readonly string BFBS_BASE64 = "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";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }

    public class ModelMetadataAttribute
    {
        [Newtonsoft.Json.JsonProperty("mesh_name")]
        public string MeshName { get; set; }

        [Newtonsoft.Json.JsonProperty("material_name")]
        public string MaterialName { get; set; }

        [Newtonsoft.Json.JsonProperty("attribute_name")]
        public string AttributeName { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.ModelMetadataAttribute FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.ModelMetadataAttribute>(jsonText);
        }
    }

    public class ModelMetadataDeformer
    {
        [Newtonsoft.Json.JsonProperty("deformer_name")]
        public string DeformerName { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.ModelMetadataDeformer FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.ModelMetadataDeformer>(jsonText);
        }
    }

    public class ModelMetadataItem
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("material_path_list")]
        public System.Collections.Generic.List<string> MaterialPathList { get; set; }

        [Newtonsoft.Json.JsonProperty("mesh_visibility_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.BoolParam> MeshVisibilityList { get; set; }

        [Newtonsoft.Json.JsonProperty("param_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.ModelMetadataParam> ParamList { get; set; }

        [Newtonsoft.Json.JsonProperty("mesh_anime_file_path")]
        public string MeshAnimeFilePath { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.ModelMetadataItem FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.ModelMetadataItem>(jsonText);
        }
    }

    public class ModelMetadataParam
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("attribute_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.ModelMetadataAttribute> AttributeList { get; set; }

        [Newtonsoft.Json.JsonProperty("min_value")]
        public int MinValue { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("max_value")]
        public int MaxValue { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("mesh_anime_data")]
        public gfl.gfx2.fb.Blob MeshAnimeData { get; set; }

        [Newtonsoft.Json.JsonProperty("visibility_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.ModelMetadataVisibility> VisibilityList { get; set; }

        [Newtonsoft.Json.JsonProperty("deformer_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.ModelMetadataDeformer> DeformerList { get; set; }

        [Newtonsoft.Json.JsonProperty("rule")]
        public gfl.gfx2.fb.mmr.Parameter Rule { get; set; }

        [Newtonsoft.Json.JsonProperty("override_default_value")]
        public int OverrideDefaultValue { get; set; } = -1;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.ModelMetadataParam FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.ModelMetadataParam>(jsonText);
        }
    }

    public class ModelMetadataVisibility
    {
        [Newtonsoft.Json.JsonProperty("mesh_name")]
        public string MeshName { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.ModelMetadataVisibility FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.ModelMetadataVisibility>(jsonText);
        }
    }
}
