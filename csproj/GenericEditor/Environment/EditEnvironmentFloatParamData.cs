// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace GenericEditor.Plugin.Environment
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct EnvironmentFloatParamData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static EnvironmentFloatParamData GetRootAsEnvironmentFloatParamData(ByteBuffer _bb) { return GetRootAsEnvironmentFloatParamData(_bb, new EnvironmentFloatParamData()); }
  public static EnvironmentFloatParamData GetRootAsEnvironmentFloatParamData(ByteBuffer _bb, EnvironmentFloatParamData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EnvironmentFloatParamData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string ParamaterName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetParamaterNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetParamaterNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetParamaterNameArray() { return __p.__vector_as_array<byte>(4); }
  public float Value { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<GenericEditor.Plugin.Environment.EnvironmentFloatParamData> CreateEnvironmentFloatParamData(FlatBufferBuilder builder,
      StringOffset paramaterNameOffset = default(StringOffset),
      float value = 0.0f) {
    builder.StartTable(2);
    EnvironmentFloatParamData.AddValue(builder, value);
    EnvironmentFloatParamData.AddParamaterName(builder, paramaterNameOffset);
    return EnvironmentFloatParamData.EndEnvironmentFloatParamData(builder);
  }

  public static void StartEnvironmentFloatParamData(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddParamaterName(FlatBufferBuilder builder, StringOffset paramaterNameOffset) { builder.AddOffset(0, paramaterNameOffset.Value, 0); }
  public static void AddValue(FlatBufferBuilder builder, float value) { builder.AddFloat(1, value, 0.0f); }
  public static Offset<GenericEditor.Plugin.Environment.EnvironmentFloatParamData> EndEnvironmentFloatParamData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<GenericEditor.Plugin.Environment.EnvironmentFloatParamData>(o);
  }
  public static void FinishEnvironmentFloatParamDataBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Environment.EnvironmentFloatParamData> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedEnvironmentFloatParamDataBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Environment.EnvironmentFloatParamData> offset) { builder.FinishSizePrefixed(offset.Value); }
  public EnvironmentFloatParamDataT UnPack() {
    var _o = new EnvironmentFloatParamDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EnvironmentFloatParamDataT _o) {
    _o.ParamaterName = this.ParamaterName;
    _o.Value = this.Value;
  }
  public static Offset<GenericEditor.Plugin.Environment.EnvironmentFloatParamData> Pack(FlatBufferBuilder builder, EnvironmentFloatParamDataT _o) {
    if (_o == null) return default(Offset<GenericEditor.Plugin.Environment.EnvironmentFloatParamData>);
    var _paramaterName = _o.ParamaterName == null ? default(StringOffset) : builder.CreateString(_o.ParamaterName);
    return CreateEnvironmentFloatParamData(
      builder,
      _paramaterName,
      _o.Value);
  }
};

public class EnvironmentFloatParamDataT
{
  [Newtonsoft.Json.JsonProperty("paramaterName")]
  public string ParamaterName { get; set; }
  [Newtonsoft.Json.JsonProperty("value")]
  public float Value { get; set; }

  public EnvironmentFloatParamDataT() {
    this.ParamaterName = null;
    this.Value = 0.0f;
  }

  public static EnvironmentFloatParamDataT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<EnvironmentFloatParamDataT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static EnvironmentFloatParamDataT DeserializeFromBinary(byte[] fbBuffer) {
    return EnvironmentFloatParamData.GetRootAsEnvironmentFloatParamData(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    EnvironmentFloatParamData.FinishEnvironmentFloatParamDataBuffer(fbb, EnvironmentFloatParamData.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}