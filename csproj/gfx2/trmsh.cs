// <auto-generated />

namespace gfl.gfx2.fb
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IndexBufferType : uint
    {
        Unknown = 0,
        Short = 1,
        Int = 2,
        Count = 3,
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum VertexAttributeFormat : uint
    {
        Unknown = 0,
        R4G4_UNORM = 1,
        R8_UNORM = 2,
        R8_SNORM = 3,
        R8_UINT = 4,
        R8_SINT = 5,
        R8_UI2F = 6,
        R8_I2F = 7,
        R8G8_UNORM = 8,
        R8G8_SNORM = 9,
        R8G8_UINT = 10,
        R8G8_SINT = 11,
        R8G8_UI2F = 12,
        R8G8_I2F = 13,
        R16_UNORM = 14,
        R16_SNORM = 15,
        R16_UINT = 16,
        R16_SINT = 17,
        R16_UI2F = 18,
        R16_I2F = 19,
        R8G8B8A8_UNORM = 20,
        R8G8B8A8_SNORM = 21,
        R8G8B8A8_UINT = 22,
        R8G8B8A8_SINT = 23,
        R8G8B8A8_UI2F = 24,
        R8G8B8A8_I2F = 25,
        R10G10B10A2_UNORM = 26,
        R10G10B10A2_SNORM = 27,
        R10G10B10A2_UINT = 28,
        R10G10B10A2_SINT = 29,
        R16G16_UNORM = 30,
        R16G16_SNORM = 31,
        R16G16_UINT = 32,
        R16G16_SINT = 33,
        R16G16_UI2F = 34,
        R16G16_I2F = 35,
        R32_UINT = 36,
        R32_SINT = 37,
        R32_FLOAT = 38,
        R16G16B16A16_UNORM = 39,
        R16G16B16A16_SNORM = 40,
        R16G16B16A16_UINT = 41,
        R16G16B16A16_SINT = 42,
        R16G16B16A16_FLOAT = 43,
        R16G16B16A16_UI2F = 44,
        R16G16B16A16_I2F = 45,
        R32G32_UINT = 46,
        R32G32_SINT = 47,
        R32G32_FLOAT = 48,
        R32G32B32_UINT = 49,
        R32G32B32_SINT = 50,
        R32G32B32_FLOAT = 51,
        R32G32B32A32_UINT = 52,
        R32G32B32A32_SINT = 53,
        R32G32B32A32_FLOAT = 54,
        Count = 55,
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum VertexAttributeSemantic : uint
    {
        Unknown = 0,
        Position = 1,
        Normal = 2,
        Tangent = 3,
        Binormal = 4,
        Color = 5,
        TexCoord = 6,
        JointIndices = 7,
        JointWeight = 8,
        VertexIndex = 9,
        TargetVertexIndex = 10,
        Count = 11,
    }

    public class BlendShapeInfo
    {
        [Newtonsoft.Json.JsonProperty("vertex_layer_id")]
        public uint VertexLayerId { get; set; } = 0u;

        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("morph_add_blend")]
        public bool MorphAddBlend { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.BlendShapeInfo FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.BlendShapeInfo>(jsonText);
        }
    }

    public class JointTotalWeight
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public uint Id { get; set; } = 0u;

        [Newtonsoft.Json.JsonProperty("weight")]
        public float Weight { get; set; } = 0.0f;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.JointTotalWeight FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.JointTotalWeight>(jsonText);
        }
    }

    public class Mesh
    {
        [Newtonsoft.Json.JsonProperty("version")]
        public uint Version { get; set; } = 1u;

        [Newtonsoft.Json.JsonProperty("item_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.MeshItem> ItemList { get; set; }

        [Newtonsoft.Json.JsonProperty("mesh_buffer_path")]
        public string MeshBufferPath { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.Mesh FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.Mesh>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static gfl.gfx2.fb.Mesh FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "";

        public static readonly string BFBS_BASE64 = "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";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }

    public class MeshItem
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("aabb")]
        public gfl.gfx2.fb.AABB Aabb { get; set; }

        [Newtonsoft.Json.JsonProperty("index_buffer_type")]
        public gfl.gfx2.fb.IndexBufferType IndexBufferType { get; set; } = (gfl.gfx2.fb.IndexBufferType)0;

        [Newtonsoft.Json.JsonProperty("vertex_layer_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.VertexLayer> VertexLayerList { get; set; }

        [Newtonsoft.Json.JsonProperty("sub_mesh_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.SubMesh> SubMeshList { get; set; }

        [Newtonsoft.Json.JsonProperty("draw_layer")]
        public int DrawLayer { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("sorting_priority")]
        public int SortingPriority { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("cast_shadow")]
        public bool CastShadow { get; set; } = true;

        [Newtonsoft.Json.JsonProperty("receive_shadow")]
        public bool ReceiveShadow { get; set; } = true;

        [Newtonsoft.Json.JsonProperty("bounding_sphere")]
        public gfl.gfx2.fb.Vector4f BoundingSphere { get; set; }

        [Newtonsoft.Json.JsonProperty("joint_total_weight_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.JointTotalWeight> JointTotalWeightList { get; set; }

        [Newtonsoft.Json.JsonProperty("blend_shape_info_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.BlendShapeInfo> BlendShapeInfoList { get; set; }

        [Newtonsoft.Json.JsonProperty("parent_node_name")]
        public string ParentNodeName { get; set; }

        [Newtonsoft.Json.JsonProperty("state_visible_for_capture")]
        public int StateVisibleForCapture { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("partial_blend_shape_info_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.PartialBlendShapeInfo> PartialBlendShapeInfoList { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.MeshItem FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.MeshItem>(jsonText);
        }
    }

    public class PartialBlendShapeInfo
    {
        [Newtonsoft.Json.JsonProperty("vertex_layer_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.VertexLayer> VertexLayerList { get; set; }

        [Newtonsoft.Json.JsonProperty("blend_shape_info_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.BlendShapeInfo> BlendShapeInfoList { get; set; }

        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.PartialBlendShapeInfo FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.PartialBlendShapeInfo>(jsonText);
        }
    }

    public class SubMesh
    {
        [Newtonsoft.Json.JsonProperty("count")]
        public int Count { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("index_offset")]
        public int IndexOffset { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("vertex_offset")]
        public int VertexOffset { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("material_name")]
        public string MaterialName { get; set; }

        [Newtonsoft.Json.JsonProperty("index_buffer_id")]
        public int IndexBufferId { get; set; } = -1;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.SubMesh FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.SubMesh>(jsonText);
        }
    }

    public class VertexAttribute
    {
        [Newtonsoft.Json.JsonProperty("stream_id")]
        public int StreamId { get; set; } = -1;

        [Newtonsoft.Json.JsonProperty("semantic")]
        public gfl.gfx2.fb.VertexAttributeSemantic Semantic { get; set; } = (gfl.gfx2.fb.VertexAttributeSemantic)0;

        [Newtonsoft.Json.JsonProperty("semantic_id")]
        public int SemanticId { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("format")]
        public gfl.gfx2.fb.VertexAttributeFormat Format { get; set; } = (gfl.gfx2.fb.VertexAttributeFormat)0;

        [Newtonsoft.Json.JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.VertexAttribute FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.VertexAttribute>(jsonText);
        }
    }

    public class VertexLayer
    {
        [Newtonsoft.Json.JsonProperty("attribute_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.VertexAttribute> AttributeList { get; set; }

        [Newtonsoft.Json.JsonProperty("stream_list")]
        public System.Collections.Generic.List<gfl.gfx2.fb.VertexStream> StreamList { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.VertexLayer FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.VertexLayer>(jsonText);
        }
    }

    public class VertexStream
    {
        [Newtonsoft.Json.JsonProperty("stride")]
        public int Stride { get; set; } = 0;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static gfl.gfx2.fb.VertexStream FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<gfl.gfx2.fb.VertexStream>(jsonText);
        }
    }
}