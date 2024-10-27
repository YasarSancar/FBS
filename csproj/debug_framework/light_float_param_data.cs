// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.debug_framework.fb.light
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct FloatParamData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static FloatParamData GetRootAsFloatParamData(ByteBuffer _bb) { return GetRootAsFloatParamData(_bb, new FloatParamData()); }
  public static FloatParamData GetRootAsFloatParamData(ByteBuffer _bb, FloatParamData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FloatParamData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

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
  public float Value { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public gfl.gfx2.fb.RuntimeCurveFloat? CurveValue { get { int o = __p.__offset(12); return o != 0 ? (gfl.gfx2.fb.RuntimeCurveFloat?)(new gfl.gfx2.fb.RuntimeCurveFloat()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public string LightUniqueId { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLightUniqueIdBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetLightUniqueIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetLightUniqueIdArray() { return __p.__vector_as_array<byte>(14); }

  public static Offset<gfl.debug_framework.fb.light.FloatParamData> CreateFloatParamData(FlatBufferBuilder builder,
      StringOffset lightNameOffset = default(StringOffset),
      StringOffset typeNameOffset = default(StringOffset),
      StringOffset paramaterNameOffset = default(StringOffset),
      float value = 0.0f,
      Offset<gfl.gfx2.fb.RuntimeCurveFloat> curveValueOffset = default(Offset<gfl.gfx2.fb.RuntimeCurveFloat>),
      StringOffset lightUniqueIdOffset = default(StringOffset)) {
    builder.StartTable(6);
    FloatParamData.AddLightUniqueId(builder, lightUniqueIdOffset);
    FloatParamData.AddCurveValue(builder, curveValueOffset);
    FloatParamData.AddValue(builder, value);
    FloatParamData.AddParamaterName(builder, paramaterNameOffset);
    FloatParamData.AddTypeName(builder, typeNameOffset);
    FloatParamData.AddLightName(builder, lightNameOffset);
    return FloatParamData.EndFloatParamData(builder);
  }

  public static void StartFloatParamData(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddLightName(FlatBufferBuilder builder, StringOffset lightNameOffset) { builder.AddOffset(0, lightNameOffset.Value, 0); }
  public static void AddTypeName(FlatBufferBuilder builder, StringOffset typeNameOffset) { builder.AddOffset(1, typeNameOffset.Value, 0); }
  public static void AddParamaterName(FlatBufferBuilder builder, StringOffset paramaterNameOffset) { builder.AddOffset(2, paramaterNameOffset.Value, 0); }
  public static void AddValue(FlatBufferBuilder builder, float value) { builder.AddFloat(3, value, 0.0f); }
  public static void AddCurveValue(FlatBufferBuilder builder, Offset<gfl.gfx2.fb.RuntimeCurveFloat> curveValueOffset) { builder.AddOffset(4, curveValueOffset.Value, 0); }
  public static void AddLightUniqueId(FlatBufferBuilder builder, StringOffset lightUniqueIdOffset) { builder.AddOffset(5, lightUniqueIdOffset.Value, 0); }
  public static Offset<gfl.debug_framework.fb.light.FloatParamData> EndFloatParamData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.debug_framework.fb.light.FloatParamData>(o);
  }
  public static void FinishFloatParamDataBuffer(FlatBufferBuilder builder, Offset<gfl.debug_framework.fb.light.FloatParamData> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedFloatParamDataBuffer(FlatBufferBuilder builder, Offset<gfl.debug_framework.fb.light.FloatParamData> offset) { builder.FinishSizePrefixed(offset.Value); }
  public FloatParamDataT UnPack() {
    var _o = new FloatParamDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FloatParamDataT _o) {
    _o.LightName = this.LightName;
    _o.TypeName = this.TypeName;
    _o.ParamaterName = this.ParamaterName;
    _o.Value = this.Value;
    _o.CurveValue = this.CurveValue.HasValue ? this.CurveValue.Value.UnPack() : null;
    _o.LightUniqueId = this.LightUniqueId;
  }
  public static Offset<gfl.debug_framework.fb.light.FloatParamData> Pack(FlatBufferBuilder builder, FloatParamDataT _o) {
    if (_o == null) return default(Offset<gfl.debug_framework.fb.light.FloatParamData>);
    var _lightName = _o.LightName == null ? default(StringOffset) : builder.CreateString(_o.LightName);
    var _typeName = _o.TypeName == null ? default(StringOffset) : builder.CreateString(_o.TypeName);
    var _paramaterName = _o.ParamaterName == null ? default(StringOffset) : builder.CreateString(_o.ParamaterName);
    var _curveValue = _o.CurveValue == null ? default(Offset<gfl.gfx2.fb.RuntimeCurveFloat>) : gfl.gfx2.fb.RuntimeCurveFloat.Pack(builder, _o.CurveValue);
    var _lightUniqueId = _o.LightUniqueId == null ? default(StringOffset) : builder.CreateString(_o.LightUniqueId);
    return CreateFloatParamData(
      builder,
      _lightName,
      _typeName,
      _paramaterName,
      _o.Value,
      _curveValue,
      _lightUniqueId);
  }
};

public class FloatParamDataT
{
  [Newtonsoft.Json.JsonProperty("lightName")]
  public string LightName { get; set; }
  [Newtonsoft.Json.JsonProperty("typeName")]
  public string TypeName { get; set; }
  [Newtonsoft.Json.JsonProperty("paramaterName")]
  public string ParamaterName { get; set; }
  [Newtonsoft.Json.JsonProperty("value")]
  public float Value { get; set; }
  [Newtonsoft.Json.JsonProperty("curveValue")]
  public gfl.gfx2.fb.RuntimeCurveFloatT CurveValue { get; set; }
  [Newtonsoft.Json.JsonProperty("lightUniqueId")]
  public string LightUniqueId { get; set; }

  public FloatParamDataT() {
    this.LightName = null;
    this.TypeName = null;
    this.ParamaterName = null;
    this.Value = 0.0f;
    this.CurveValue = null;
    this.LightUniqueId = null;
  }

  public static FloatParamDataT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<FloatParamDataT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static FloatParamDataT DeserializeFromBinary(byte[] fbBuffer) {
    return FloatParamData.GetRootAsFloatParamData(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    FloatParamData.FinishFloatParamDataBuffer(fbb, FloatParamData.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
