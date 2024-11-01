// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace pe.field.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct AmbientWindComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static AmbientWindComponent GetRootAsAmbientWindComponent(ByteBuffer _bb) { return GetRootAsAmbientWindComponent(_bb, new AmbientWindComponent()); }
  public static AmbientWindComponent GetRootAsAmbientWindComponent(ByteBuffer _bb, AmbientWindComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AmbientWindComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string InstanceName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInstanceNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetInstanceNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetInstanceNameArray() { return __p.__vector_as_array<byte>(4); }
  public gfl.math.fb.Vector3f? Direction { get { int o = __p.__offset(6); return o != 0 ? (gfl.math.fb.Vector3f?)(new gfl.math.fb.Vector3f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public float Speed { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float NoiseScale { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Strength { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool ScriptControlOnly { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<pe.field.fb.AmbientWindComponent> CreateAmbientWindComponent(FlatBufferBuilder builder,
      StringOffset instanceNameOffset = default(StringOffset),
      gfl.math.fb.Vector3fT direction = null,
      float speed = 0.0f,
      float noiseScale = 0.0f,
      float strength = 0.0f,
      bool scriptControlOnly = false) {
    builder.StartTable(6);
    AmbientWindComponent.AddStrength(builder, strength);
    AmbientWindComponent.AddNoiseScale(builder, noiseScale);
    AmbientWindComponent.AddSpeed(builder, speed);
    AmbientWindComponent.AddDirection(builder, gfl.math.fb.Vector3f.Pack(builder, direction));
    AmbientWindComponent.AddInstanceName(builder, instanceNameOffset);
    AmbientWindComponent.AddScriptControlOnly(builder, scriptControlOnly);
    return AmbientWindComponent.EndAmbientWindComponent(builder);
  }

  public static void StartAmbientWindComponent(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddInstanceName(FlatBufferBuilder builder, StringOffset instanceNameOffset) { builder.AddOffset(0, instanceNameOffset.Value, 0); }
  public static void AddDirection(FlatBufferBuilder builder, Offset<gfl.math.fb.Vector3f> directionOffset) { builder.AddStruct(1, directionOffset.Value, 0); }
  public static void AddSpeed(FlatBufferBuilder builder, float speed) { builder.AddFloat(2, speed, 0.0f); }
  public static void AddNoiseScale(FlatBufferBuilder builder, float noiseScale) { builder.AddFloat(3, noiseScale, 0.0f); }
  public static void AddStrength(FlatBufferBuilder builder, float strength) { builder.AddFloat(4, strength, 0.0f); }
  public static void AddScriptControlOnly(FlatBufferBuilder builder, bool scriptControlOnly) { builder.AddBool(5, scriptControlOnly, false); }
  public static Offset<pe.field.fb.AmbientWindComponent> EndAmbientWindComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<pe.field.fb.AmbientWindComponent>(o);
  }
  public static void FinishAmbientWindComponentBuffer(FlatBufferBuilder builder, Offset<pe.field.fb.AmbientWindComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedAmbientWindComponentBuffer(FlatBufferBuilder builder, Offset<pe.field.fb.AmbientWindComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public AmbientWindComponentT UnPack() {
    var _o = new AmbientWindComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AmbientWindComponentT _o) {
    _o.InstanceName = this.InstanceName;
    _o.Direction = this.Direction.HasValue ? this.Direction.Value.UnPack() : null;
    _o.Speed = this.Speed;
    _o.NoiseScale = this.NoiseScale;
    _o.Strength = this.Strength;
    _o.ScriptControlOnly = this.ScriptControlOnly;
  }
  public static Offset<pe.field.fb.AmbientWindComponent> Pack(FlatBufferBuilder builder, AmbientWindComponentT _o) {
    if (_o == null) return default(Offset<pe.field.fb.AmbientWindComponent>);
    var _instanceName = _o.InstanceName == null ? default(StringOffset) : builder.CreateString(_o.InstanceName);
    return CreateAmbientWindComponent(
      builder,
      _instanceName,
      _o.Direction,
      _o.Speed,
      _o.NoiseScale,
      _o.Strength,
      _o.ScriptControlOnly);
  }
};

public class AmbientWindComponentT
{
  [Newtonsoft.Json.JsonProperty("instanceName")]
  public string InstanceName { get; set; }
  [Newtonsoft.Json.JsonProperty("direction")]
  public gfl.math.fb.Vector3fT Direction { get; set; }
  [Newtonsoft.Json.JsonProperty("speed")]
  public float Speed { get; set; }
  [Newtonsoft.Json.JsonProperty("noiseScale")]
  public float NoiseScale { get; set; }
  [Newtonsoft.Json.JsonProperty("strength")]
  public float Strength { get; set; }
  [Newtonsoft.Json.JsonProperty("scriptControlOnly")]
  public bool ScriptControlOnly { get; set; }

  public AmbientWindComponentT() {
    this.InstanceName = null;
    this.Direction = new gfl.math.fb.Vector3fT();
    this.Speed = 0.0f;
    this.NoiseScale = 0.0f;
    this.Strength = 0.0f;
    this.ScriptControlOnly = false;
  }

  public static AmbientWindComponentT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<AmbientWindComponentT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static AmbientWindComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return AmbientWindComponent.GetRootAsAmbientWindComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    AmbientWindComponent.FinishAmbientWindComponentBuffer(fbb, AmbientWindComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
