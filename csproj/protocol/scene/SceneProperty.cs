// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.protocol.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct SceneProperty : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static SceneProperty GetRootAsSceneProperty(ByteBuffer _bb) { return GetRootAsSceneProperty(_bb, new SceneProperty()); }
  public static SceneProperty GetRootAsSceneProperty(ByteBuffer _bb, SceneProperty obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SceneProperty __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string TimerLevelName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTimerLevelNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetTimerLevelNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetTimerLevelNameArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<gfl.protocol.scene.fb.SceneProperty> CreateSceneProperty(FlatBufferBuilder builder,
      StringOffset timerLevelNameOffset = default(StringOffset)) {
    builder.StartTable(1);
    SceneProperty.AddTimerLevelName(builder, timerLevelNameOffset);
    return SceneProperty.EndSceneProperty(builder);
  }

  public static void StartSceneProperty(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddTimerLevelName(FlatBufferBuilder builder, StringOffset timerLevelNameOffset) { builder.AddOffset(0, timerLevelNameOffset.Value, 0); }
  public static Offset<gfl.protocol.scene.fb.SceneProperty> EndSceneProperty(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.protocol.scene.fb.SceneProperty>(o);
  }
  public static void FinishScenePropertyBuffer(FlatBufferBuilder builder, Offset<gfl.protocol.scene.fb.SceneProperty> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedScenePropertyBuffer(FlatBufferBuilder builder, Offset<gfl.protocol.scene.fb.SceneProperty> offset) { builder.FinishSizePrefixed(offset.Value); }
  public ScenePropertyT UnPack() {
    var _o = new ScenePropertyT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ScenePropertyT _o) {
    _o.TimerLevelName = this.TimerLevelName;
  }
  public static Offset<gfl.protocol.scene.fb.SceneProperty> Pack(FlatBufferBuilder builder, ScenePropertyT _o) {
    if (_o == null) return default(Offset<gfl.protocol.scene.fb.SceneProperty>);
    var _timerLevelName = _o.TimerLevelName == null ? default(StringOffset) : builder.CreateString(_o.TimerLevelName);
    return CreateSceneProperty(
      builder,
      _timerLevelName);
  }
};

public class ScenePropertyT
{
  [Newtonsoft.Json.JsonProperty("timerLevelName")]
  public string TimerLevelName { get; set; }

  public ScenePropertyT() {
    this.TimerLevelName = null;
  }

  public static ScenePropertyT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<ScenePropertyT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static ScenePropertyT DeserializeFromBinary(byte[] fbBuffer) {
    return SceneProperty.GetRootAsSceneProperty(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    SceneProperty.FinishScenePropertyBuffer(fbb, SceneProperty.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
