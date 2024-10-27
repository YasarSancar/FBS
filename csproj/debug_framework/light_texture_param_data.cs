// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.debug_framework.fb.light
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct TextureParamData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static TextureParamData GetRootAsTextureParamData(ByteBuffer _bb) { return GetRootAsTextureParamData(_bb, new TextureParamData()); }
  public static TextureParamData GetRootAsTextureParamData(ByteBuffer _bb, TextureParamData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TextureParamData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string LightName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLightNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetLightNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetLightNameArray() { return __p.__vector_as_array<byte>(4); }
  public string TypeName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTypeNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetTypeNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetTypeNameArray() { return __p.__vector_as_array<byte>(6); }
  public string ParamaterName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetParamaterNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetParamaterNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetParamaterNameArray() { return __p.__vector_as_array<byte>(8); }
  public string FilePath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFilePathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetFilePathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetFilePathArray() { return __p.__vector_as_array<byte>(10); }
  public string LightUniqueId { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLightUniqueIdBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetLightUniqueIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetLightUniqueIdArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<gfl.debug_framework.fb.light.TextureParamData> CreateTextureParamData(FlatBufferBuilder builder,
      StringOffset lightNameOffset = default(StringOffset),
      StringOffset typeNameOffset = default(StringOffset),
      StringOffset paramaterNameOffset = default(StringOffset),
      StringOffset filePathOffset = default(StringOffset),
      StringOffset lightUniqueIdOffset = default(StringOffset)) {
    builder.StartTable(5);
    TextureParamData.AddLightUniqueId(builder, lightUniqueIdOffset);
    TextureParamData.AddFilePath(builder, filePathOffset);
    TextureParamData.AddParamaterName(builder, paramaterNameOffset);
    TextureParamData.AddTypeName(builder, typeNameOffset);
    TextureParamData.AddLightName(builder, lightNameOffset);
    return TextureParamData.EndTextureParamData(builder);
  }

  public static void StartTextureParamData(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddLightName(FlatBufferBuilder builder, StringOffset lightNameOffset) { builder.AddOffset(0, lightNameOffset.Value, 0); }
  public static void AddTypeName(FlatBufferBuilder builder, StringOffset typeNameOffset) { builder.AddOffset(1, typeNameOffset.Value, 0); }
  public static void AddParamaterName(FlatBufferBuilder builder, StringOffset paramaterNameOffset) { builder.AddOffset(2, paramaterNameOffset.Value, 0); }
  public static void AddFilePath(FlatBufferBuilder builder, StringOffset filePathOffset) { builder.AddOffset(3, filePathOffset.Value, 0); }
  public static void AddLightUniqueId(FlatBufferBuilder builder, StringOffset lightUniqueIdOffset) { builder.AddOffset(4, lightUniqueIdOffset.Value, 0); }
  public static Offset<gfl.debug_framework.fb.light.TextureParamData> EndTextureParamData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.debug_framework.fb.light.TextureParamData>(o);
  }
  public static void FinishTextureParamDataBuffer(FlatBufferBuilder builder, Offset<gfl.debug_framework.fb.light.TextureParamData> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedTextureParamDataBuffer(FlatBufferBuilder builder, Offset<gfl.debug_framework.fb.light.TextureParamData> offset) { builder.FinishSizePrefixed(offset.Value); }
  public TextureParamDataT UnPack() {
    var _o = new TextureParamDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TextureParamDataT _o) {
    _o.LightName = this.LightName;
    _o.TypeName = this.TypeName;
    _o.ParamaterName = this.ParamaterName;
    _o.FilePath = this.FilePath;
    _o.LightUniqueId = this.LightUniqueId;
  }
  public static Offset<gfl.debug_framework.fb.light.TextureParamData> Pack(FlatBufferBuilder builder, TextureParamDataT _o) {
    if (_o == null) return default(Offset<gfl.debug_framework.fb.light.TextureParamData>);
    var _lightName = _o.LightName == null ? default(StringOffset) : builder.CreateString(_o.LightName);
    var _typeName = _o.TypeName == null ? default(StringOffset) : builder.CreateString(_o.TypeName);
    var _paramaterName = _o.ParamaterName == null ? default(StringOffset) : builder.CreateString(_o.ParamaterName);
    var _filePath = _o.FilePath == null ? default(StringOffset) : builder.CreateString(_o.FilePath);
    var _lightUniqueId = _o.LightUniqueId == null ? default(StringOffset) : builder.CreateString(_o.LightUniqueId);
    return CreateTextureParamData(
      builder,
      _lightName,
      _typeName,
      _paramaterName,
      _filePath,
      _lightUniqueId);
  }
};

public class TextureParamDataT
{
  [Newtonsoft.Json.JsonProperty("lightName")]
  public string LightName { get; set; }
  [Newtonsoft.Json.JsonProperty("typeName")]
  public string TypeName { get; set; }
  [Newtonsoft.Json.JsonProperty("paramaterName")]
  public string ParamaterName { get; set; }
  [Newtonsoft.Json.JsonProperty("filePath")]
  public string FilePath { get; set; }
  [Newtonsoft.Json.JsonProperty("lightUniqueId")]
  public string LightUniqueId { get; set; }

  public TextureParamDataT() {
    this.LightName = null;
    this.TypeName = null;
    this.ParamaterName = null;
    this.FilePath = null;
    this.LightUniqueId = null;
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