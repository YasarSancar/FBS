// <auto-generated />


namespace gfl.gfx2.fb
{
    public class LODGroup
    {
        [Newtonsoft.Json.JsonProperty("lod_info_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.LODInfo> LodInfoList { get; set; }

        [Newtonsoft.Json.JsonProperty("transition_preset")]
        public string TransitionPreset { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.LODGroup FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.LODGroup>(jsonText);
        }
    }

    public class LODInfo
    {
        [Newtonsoft.Json.JsonProperty("mesh_component_id")]
        public int MeshComponentId { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("threshold")]
        public float Threshold { get; set; } = 0.0f;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.LODInfo FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.LODInfo>(jsonText);
        }
    }

    public class MeshComponent
    {
        [Newtonsoft.Json.JsonProperty("file_path")]
        public string FilePath { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.MeshComponent FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.MeshComponent>(jsonText);
        }
    }

    public class Model
    {
        [Newtonsoft.Json.JsonProperty("version")]
        public uint Version { get; set; } = 1u;

        [Newtonsoft.Json.JsonProperty("mesh_component_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.MeshComponent> MeshComponentList { get; set; }

        [Newtonsoft.Json.JsonProperty("skeleton_component")]
        public gfl.gfx2.fb.SkeletonComponent SkeletonComponent { get; set; }

        [Newtonsoft.Json.JsonProperty("material_path_list")]
        public System.Collections.Generic.List<string> MaterialPathList { get; set; }

        [Newtonsoft.Json.JsonProperty("lod_group_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.LODGroup> LodGroupList { get; set; }

        [Newtonsoft.Json.JsonProperty("aabb")]
        public gfl.gfx2.fb.AABB Aabb { get; set; }

        [Newtonsoft.Json.JsonProperty("bounding_sphere")]
        public gfl.gfx2.fb.Vector4f BoundingSphere { get; set; }

        [Newtonsoft.Json.JsonProperty("lattice_deformer_path")]
        public string LatticeDeformerPath { get; set; }

        [Newtonsoft.Json.JsonProperty("is_interior_map")]
        public bool IsInteriorMap { get; set; } = false;

        [Newtonsoft.Json.JsonProperty("shadow_lod_level")]
        public int ShadowLodLevel { get; set; } = 0;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.Model FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.Model>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static gfl.gfx2.fb.Model FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "";

        public static readonly string BFBS_BASE64 = "GAAAAEJGQlMQABwABAAIAAwAEAAUABgAEAAAADAAAAAoAAAAHAAAABAAAABwAAAABAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABMAAABYBwAAfAQAAIQCAAAkAwAAbAkAAHAIAAAIBAAAMAAAADQMAACwBwAAlAMAAKwGAACsBAAAXA4AAKALAACgDQAA+AoAANQMAAAsCgAA3Pb//zgAAAAIAAAAAQAAAAoAAAAAAQAAzAAAAGgAAACQAAAAGAEAAEQBAACkAQAAJAAAAGgBAADcAQAAEQAAAGdmbC5nZngyLmZiLk1vZGVsAAAA0PH//wkAFgAQAAAABAAAAJ7x//8AAAAHEAAAAHNoYWRvd19sb2RfbGV2ZWwAAAAAAPL//wgAFAAQAAAABAAAAM7x//8AAAACDwAAAGlzX2ludGVyaW9yX21hcAAs8v//BwASABAAAAAEAAAA+vH//wAAAA0VAAAAbGF0dGljZV9kZWZvcm1lcl9wYXRoAAAAYPL//wYAEAAUAAAABAAAAO72//8AAAAPEQAAAA8AAABib3VuZGluZ19zcGhlcmUAkPL//wUADgAUAAAABAAAAB73//8AAAAPAAAAAAQAAABhYWJiAAAAALjy//8EAAwAFAAAAAQAAACS/v//AAAODwIAAAAOAAAAbG9kX2dyb3VwX2xpc3QAAOjy//8DAAoAEAAAAAQAAAAI/f//AAAODRIAAABtYXRlcmlhbF9wYXRoX2xpc3QAABjz//8CAAgAFAAAAAQAAACm9///AAAADwoAAAASAAAAc2tlbGV0b25fY29tcG9uZW50AABM8///AQAGABQAAAAEAAAAJv///wAADg8GAAAAEwAAAG1lc2hfY29tcG9uZW50X2xpc3QAAAAOABgACAAMAAAABgAQAA4AAAAAAAQAGAAAAAwAAAABAAAAAAAAAGbz//8AAAAIBwAAAHZlcnNpb24AHPn//xgAAAAIAAAAAQAAAAIAAABUAAAAIAAAABQAAABnZmwuZ2Z4Mi5mYi5MT0RHcm91cAAAAAD08///AQAGABAAAAAEAAAAwvP//wAAAA0RAAAAdHJhbnNpdGlvbl9wcmVzZXQAAADA+P//AAAEACAAAAAQAAAAAAAKAAwABgAHAAgACgAAAAAADg8DAAAADQAAAGxvZF9pbmZvX2xpc3QAAADA+f//GAAAAAgAAAABAAAAAgAAAEgAAAAcAAAAEwAAAGdmbC5nZngyLmZiLkxPREluZm8AlPT//wEABgAQAAAABAAAAGL0//8AAAALCQAAAHRocmVzaG9sZAAAAFD6//8AAAQAEAAAAAQAAACK9P//AAAABxEAAABtZXNoX2NvbXBvbmVudF9pZAAAAEz6//8UAAAACAAAAAEAAAABAAAAKAAAAB0AAABnZmwuZ2Z4Mi5mYi5Ta2VsZXRvbkNvbXBvbmVudAAAALz6//8AAAQAEAAAAAQAAAD29P//AAAADQkAAABmaWxlX3BhdGgAAACw+v//FAAAAAgAAAABAAAAAQAAACQAAAAZAAAAZ2ZsLmdmeDIuZmIuTWVzaENvbXBvbmVudAAAABz7//8AAAQAEAAAAAQAAABW9f//AAAADQkAAABmaWxlX3BhdGgAAAAQ+///FAAAAAgAAAABAAAAAQAAABwAAAAQAAAAZ2ZsLmdmeDIuZmIuQmxvYgAAAAB0+///AAAEABgAAAAMAAAACAAIAAYABwAIAAAAAAAOBAQAAABkYXRhAAAAAGz7//80AAAACAAAAAEAAAAJAAAAyAAAAMABAAAAAQAAjAAAAGAAAAAwAAAAJAEAAFABAAB4AQAAGQAAAGdmbC5nZngyLmZiLlRyYW5zZm9ybU5vZGUAAABk9v//CAAUABAAAAAEAAAAMvb//wAAAAINAAAAcHJpb3JpdHlfcGFzcwAAAJD2//8HABIAEAAAAAQAAABe9v//AAAACAgAAABwcmlvcml0eQAAAAC49v//BgAQABAAAAAEAAAAhvb//wAAAA0QAAAAcGFyZW50X25vZGVfbmFtZQAAAADO////BQAOABgAAAAMAAAA//////////++9v//AAAABw0AAABqb2ludF9pbmZvX2lkAA4AGAAIAAwABAAGABAADgAAAAQADAAYAAAADAAAAP///////////vb//wAAAAcOAAAAcGFyZW50X25vZGVfaWQAAFz3//8DAAoAFAAAAAQAAADq+///AAAADw8AAAAMAAAAcm90YXRlX3Bpdm90AAAAAIz3//8CAAgAFAAAAAQAAAAa/P//AAAADw8AAAALAAAAc2NhbGVfcGl2b3QAuPf//wEABgAUAAAABAAAAEb8//8AAAAPCQAAAAkAAAB0cmFuc2Zvcm0AAAB4/f//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";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }

    public class SkeletonComponent
    {
        [Newtonsoft.Json.JsonProperty("file_path")]
        public string FilePath { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.SkeletonComponent FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.SkeletonComponent>(jsonText);
        }
    }
}