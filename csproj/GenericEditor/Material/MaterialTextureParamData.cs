// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace GenericEditor.Plugin.Material
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct SimpleSampler : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static SimpleSampler GetRootAsSimpleSampler(ByteBuffer _bb) { return GetRootAsSimpleSampler(_bb, new SimpleSampler()); }
  public static SimpleSampler GetRootAsSimpleSampler(ByteBuffer _bb, SimpleSampler obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SimpleSampler __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint MinFilter { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint MagFilter { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint MipFilter { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint ReductionMode { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public float MaxAnisotropy { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float LodClampMin { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float LodClampMax { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)100.0f; } }
  public float LodBias { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float LodSnap { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public uint WrapU { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint WrapV { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint WrapW { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public gfl.math.fb.Vector4f? BorderColor { get { int o = __p.__offset(28); return o != 0 ? (gfl.math.fb.Vector4f?)(new gfl.math.fb.Vector4f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public uint DepthCompareFunction { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool DepthCompareEnable { get { int o = __p.__offset(32); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<GenericEditor.Plugin.Material.SimpleSampler> CreateSimpleSampler(FlatBufferBuilder builder,
      uint min_filter = 0,
      uint mag_filter = 0,
      uint mip_filter = 0,
      uint reduction_mode = 0,
      float max_anisotropy = 0.0f,
      float lod_clamp_min = 0.0f,
      float lod_clamp_max = 100.0f,
      float lod_bias = 0.0f,
      float lod_snap = 0.0f,
      uint wrap_u = 0,
      uint wrap_v = 0,
      uint wrap_w = 0,
      gfl.math.fb.Vector4fT border_color = null,
      uint depth_compare_function = 0,
      bool depth_compare_enable = false) {
    builder.StartTable(15);
    SimpleSampler.AddDepthCompareFunction(builder, depth_compare_function);
    SimpleSampler.AddBorderColor(builder, gfl.math.fb.Vector4f.Pack(builder, border_color));
    SimpleSampler.AddWrapW(builder, wrap_w);
    SimpleSampler.AddWrapV(builder, wrap_v);
    SimpleSampler.AddWrapU(builder, wrap_u);
    SimpleSampler.AddLodSnap(builder, lod_snap);
    SimpleSampler.AddLodBias(builder, lod_bias);
    SimpleSampler.AddLodClampMax(builder, lod_clamp_max);
    SimpleSampler.AddLodClampMin(builder, lod_clamp_min);
    SimpleSampler.AddMaxAnisotropy(builder, max_anisotropy);
    SimpleSampler.AddReductionMode(builder, reduction_mode);
    SimpleSampler.AddMipFilter(builder, mip_filter);
    SimpleSampler.AddMagFilter(builder, mag_filter);
    SimpleSampler.AddMinFilter(builder, min_filter);
    SimpleSampler.AddDepthCompareEnable(builder, depth_compare_enable);
    return SimpleSampler.EndSimpleSampler(builder);
  }

  public static void StartSimpleSampler(FlatBufferBuilder builder) { builder.StartTable(15); }
  public static void AddMinFilter(FlatBufferBuilder builder, uint minFilter) { builder.AddUint(0, minFilter, 0); }
  public static void AddMagFilter(FlatBufferBuilder builder, uint magFilter) { builder.AddUint(1, magFilter, 0); }
  public static void AddMipFilter(FlatBufferBuilder builder, uint mipFilter) { builder.AddUint(2, mipFilter, 0); }
  public static void AddReductionMode(FlatBufferBuilder builder, uint reductionMode) { builder.AddUint(3, reductionMode, 0); }
  public static void AddMaxAnisotropy(FlatBufferBuilder builder, float maxAnisotropy) { builder.AddFloat(4, maxAnisotropy, 0.0f); }
  public static void AddLodClampMin(FlatBufferBuilder builder, float lodClampMin) { builder.AddFloat(5, lodClampMin, 0.0f); }
  public static void AddLodClampMax(FlatBufferBuilder builder, float lodClampMax) { builder.AddFloat(6, lodClampMax, 100.0f); }
  public static void AddLodBias(FlatBufferBuilder builder, float lodBias) { builder.AddFloat(7, lodBias, 0.0f); }
  public static void AddLodSnap(FlatBufferBuilder builder, float lodSnap) { builder.AddFloat(8, lodSnap, 0.0f); }
  public static void AddWrapU(FlatBufferBuilder builder, uint wrapU) { builder.AddUint(9, wrapU, 0); }
  public static void AddWrapV(FlatBufferBuilder builder, uint wrapV) { builder.AddUint(10, wrapV, 0); }
  public static void AddWrapW(FlatBufferBuilder builder, uint wrapW) { builder.AddUint(11, wrapW, 0); }
  public static void AddBorderColor(FlatBufferBuilder builder, Offset<gfl.math.fb.Vector4f> borderColorOffset) { builder.AddStruct(12, borderColorOffset.Value, 0); }
  public static void AddDepthCompareFunction(FlatBufferBuilder builder, uint depthCompareFunction) { builder.AddUint(13, depthCompareFunction, 0); }
  public static void AddDepthCompareEnable(FlatBufferBuilder builder, bool depthCompareEnable) { builder.AddBool(14, depthCompareEnable, false); }
  public static Offset<GenericEditor.Plugin.Material.SimpleSampler> EndSimpleSampler(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<GenericEditor.Plugin.Material.SimpleSampler>(o);
  }
  public SimpleSamplerT UnPack() {
    var _o = new SimpleSamplerT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SimpleSamplerT _o) {
    _o.MinFilter = this.MinFilter;
    _o.MagFilter = this.MagFilter;
    _o.MipFilter = this.MipFilter;
    _o.ReductionMode = this.ReductionMode;
    _o.MaxAnisotropy = this.MaxAnisotropy;
    _o.LodClampMin = this.LodClampMin;
    _o.LodClampMax = this.LodClampMax;
    _o.LodBias = this.LodBias;
    _o.LodSnap = this.LodSnap;
    _o.WrapU = this.WrapU;
    _o.WrapV = this.WrapV;
    _o.WrapW = this.WrapW;
    _o.BorderColor = this.BorderColor.HasValue ? this.BorderColor.Value.UnPack() : null;
    _o.DepthCompareFunction = this.DepthCompareFunction;
    _o.DepthCompareEnable = this.DepthCompareEnable;
  }
  public static Offset<GenericEditor.Plugin.Material.SimpleSampler> Pack(FlatBufferBuilder builder, SimpleSamplerT _o) {
    if (_o == null) return default(Offset<GenericEditor.Plugin.Material.SimpleSampler>);
    return CreateSimpleSampler(
      builder,
      _o.MinFilter,
      _o.MagFilter,
      _o.MipFilter,
      _o.ReductionMode,
      _o.MaxAnisotropy,
      _o.LodClampMin,
      _o.LodClampMax,
      _o.LodBias,
      _o.LodSnap,
      _o.WrapU,
      _o.WrapV,
      _o.WrapW,
      _o.BorderColor,
      _o.DepthCompareFunction,
      _o.DepthCompareEnable);
  }
};

public class SimpleSamplerT
{
  [Newtonsoft.Json.JsonProperty("min_filter")]
  public uint MinFilter { get; set; }
  [Newtonsoft.Json.JsonProperty("mag_filter")]
  public uint MagFilter { get; set; }
  [Newtonsoft.Json.JsonProperty("mip_filter")]
  public uint MipFilter { get; set; }
  [Newtonsoft.Json.JsonProperty("reduction_mode")]
  public uint ReductionMode { get; set; }
  [Newtonsoft.Json.JsonProperty("max_anisotropy")]
  public float MaxAnisotropy { get; set; }
  [Newtonsoft.Json.JsonProperty("lod_clamp_min")]
  public float LodClampMin { get; set; }
  [Newtonsoft.Json.JsonProperty("lod_clamp_max")]
  public float LodClampMax { get; set; }
  [Newtonsoft.Json.JsonProperty("lod_bias")]
  public float LodBias { get; set; }
  [Newtonsoft.Json.JsonProperty("lod_snap")]
  public float LodSnap { get; set; }
  [Newtonsoft.Json.JsonProperty("wrap_u")]
  public uint WrapU { get; set; }
  [Newtonsoft.Json.JsonProperty("wrap_v")]
  public uint WrapV { get; set; }
  [Newtonsoft.Json.JsonProperty("wrap_w")]
  public uint WrapW { get; set; }
  [Newtonsoft.Json.JsonProperty("border_color")]
  public gfl.math.fb.Vector4fT BorderColor { get; set; }
  [Newtonsoft.Json.JsonProperty("depth_compare_function")]
  public uint DepthCompareFunction { get; set; }
  [Newtonsoft.Json.JsonProperty("depth_compare_enable")]
  public bool DepthCompareEnable { get; set; }

  public SimpleSamplerT() {
    this.MinFilter = 0;
    this.MagFilter = 0;
    this.MipFilter = 0;
    this.ReductionMode = 0;
    this.MaxAnisotropy = 0.0f;
    this.LodClampMin = 0.0f;
    this.LodClampMax = 100.0f;
    this.LodBias = 0.0f;
    this.LodSnap = 0.0f;
    this.WrapU = 0;
    this.WrapV = 0;
    this.WrapW = 0;
    this.BorderColor = new gfl.math.fb.Vector4fT();
    this.DepthCompareFunction = 0;
    this.DepthCompareEnable = false;
  }
}

public struct TextureParamData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static TextureParamData GetRootAsTextureParamData(ByteBuffer _bb) { return GetRootAsTextureParamData(_bb, new TextureParamData()); }
  public static TextureParamData GetRootAsTextureParamData(ByteBuffer _bb, TextureParamData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TextureParamData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string MaterialName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMaterialNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetMaterialNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetMaterialNameArray() { return __p.__vector_as_array<byte>(4); }
  public string ParamaterName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetParamaterNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetParamaterNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetParamaterNameArray() { return __p.__vector_as_array<byte>(6); }
  public string FilePath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFilePathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetFilePathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetFilePathArray() { return __p.__vector_as_array<byte>(8); }
  public GenericEditor.Plugin.Material.SimpleSampler? Sampler { get { int o = __p.__offset(10); return o != 0 ? (GenericEditor.Plugin.Material.SimpleSampler?)(new GenericEditor.Plugin.Material.SimpleSampler()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<GenericEditor.Plugin.Material.TextureParamData> CreateTextureParamData(FlatBufferBuilder builder,
      StringOffset materialNameOffset = default(StringOffset),
      StringOffset paramaterNameOffset = default(StringOffset),
      StringOffset filePathOffset = default(StringOffset),
      Offset<GenericEditor.Plugin.Material.SimpleSampler> samplerOffset = default(Offset<GenericEditor.Plugin.Material.SimpleSampler>)) {
    builder.StartTable(4);
    TextureParamData.AddSampler(builder, samplerOffset);
    TextureParamData.AddFilePath(builder, filePathOffset);
    TextureParamData.AddParamaterName(builder, paramaterNameOffset);
    TextureParamData.AddMaterialName(builder, materialNameOffset);
    return TextureParamData.EndTextureParamData(builder);
  }

  public static void StartTextureParamData(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddMaterialName(FlatBufferBuilder builder, StringOffset materialNameOffset) { builder.AddOffset(0, materialNameOffset.Value, 0); }
  public static void AddParamaterName(FlatBufferBuilder builder, StringOffset paramaterNameOffset) { builder.AddOffset(1, paramaterNameOffset.Value, 0); }
  public static void AddFilePath(FlatBufferBuilder builder, StringOffset filePathOffset) { builder.AddOffset(2, filePathOffset.Value, 0); }
  public static void AddSampler(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Material.SimpleSampler> samplerOffset) { builder.AddOffset(3, samplerOffset.Value, 0); }
  public static Offset<GenericEditor.Plugin.Material.TextureParamData> EndTextureParamData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<GenericEditor.Plugin.Material.TextureParamData>(o);
  }
  public static void FinishTextureParamDataBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Material.TextureParamData> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedTextureParamDataBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Material.TextureParamData> offset) { builder.FinishSizePrefixed(offset.Value); }
  public TextureParamDataT UnPack() {
    var _o = new TextureParamDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TextureParamDataT _o) {
    _o.MaterialName = this.MaterialName;
    _o.ParamaterName = this.ParamaterName;
    _o.FilePath = this.FilePath;
    _o.Sampler = this.Sampler.HasValue ? this.Sampler.Value.UnPack() : null;
  }
  public static Offset<GenericEditor.Plugin.Material.TextureParamData> Pack(FlatBufferBuilder builder, TextureParamDataT _o) {
    if (_o == null) return default(Offset<GenericEditor.Plugin.Material.TextureParamData>);
    var _materialName = _o.MaterialName == null ? default(StringOffset) : builder.CreateString(_o.MaterialName);
    var _paramaterName = _o.ParamaterName == null ? default(StringOffset) : builder.CreateString(_o.ParamaterName);
    var _filePath = _o.FilePath == null ? default(StringOffset) : builder.CreateString(_o.FilePath);
    var _sampler = _o.Sampler == null ? default(Offset<GenericEditor.Plugin.Material.SimpleSampler>) : GenericEditor.Plugin.Material.SimpleSampler.Pack(builder, _o.Sampler);
    return CreateTextureParamData(
      builder,
      _materialName,
      _paramaterName,
      _filePath,
      _sampler);
  }
};

public class TextureParamDataT
{
  [Newtonsoft.Json.JsonProperty("materialName")]
  public string MaterialName { get; set; }
  [Newtonsoft.Json.JsonProperty("paramaterName")]
  public string ParamaterName { get; set; }
  [Newtonsoft.Json.JsonProperty("filePath")]
  public string FilePath { get; set; }
  [Newtonsoft.Json.JsonProperty("sampler")]
  public GenericEditor.Plugin.Material.SimpleSamplerT Sampler { get; set; }

  public TextureParamDataT() {
    this.MaterialName = null;
    this.ParamaterName = null;
    this.FilePath = null;
    this.Sampler = null;
  }

  public static TextureParamDataT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<TextureParamDataT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static TextureParamDataT DeserializeFromBinary(byte[] fbBuffer) {
    return TextureParamData.GetRootAsTextureParamData(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    TextureParamData.FinishTextureParamDataBuffer(fbb, TextureParamData.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
