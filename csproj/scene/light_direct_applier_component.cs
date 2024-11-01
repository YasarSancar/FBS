// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct LightDirectApplierComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static LightDirectApplierComponent GetRootAsLightDirectApplierComponent(ByteBuffer _bb) { return GetRootAsLightDirectApplierComponent(_bb, new LightDirectApplierComponent()); }
  public static LightDirectApplierComponent GetRootAsLightDirectApplierComponent(ByteBuffer _bb, LightDirectApplierComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LightDirectApplierComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Priority { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<gfl.scene.fb.LightDirectApplierComponent> CreateLightDirectApplierComponent(FlatBufferBuilder builder,
      int priority = 0) {
    builder.StartTable(1);
    LightDirectApplierComponent.AddPriority(builder, priority);
    return LightDirectApplierComponent.EndLightDirectApplierComponent(builder);
  }

  public static void StartLightDirectApplierComponent(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddPriority(FlatBufferBuilder builder, int priority) { builder.AddInt(0, priority, 0); }
  public static Offset<gfl.scene.fb.LightDirectApplierComponent> EndLightDirectApplierComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.LightDirectApplierComponent>(o);
  }
  public static void FinishLightDirectApplierComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.LightDirectApplierComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedLightDirectApplierComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.LightDirectApplierComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public LightDirectApplierComponentT UnPack() {
    var _o = new LightDirectApplierComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LightDirectApplierComponentT _o) {
    _o.Priority = this.Priority;
  }
  public static Offset<gfl.scene.fb.LightDirectApplierComponent> Pack(FlatBufferBuilder builder, LightDirectApplierComponentT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.LightDirectApplierComponent>);
    return CreateLightDirectApplierComponent(
      builder,
      _o.Priority);
  }
};

public class LightDirectApplierComponentT
{
  [Newtonsoft.Json.JsonProperty("priority")]
  public int Priority { get; set; }

  public LightDirectApplierComponentT() {
    this.Priority = 0;
  }

  public static LightDirectApplierComponentT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<LightDirectApplierComponentT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static LightDirectApplierComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return LightDirectApplierComponent.GetRootAsLightDirectApplierComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    LightDirectApplierComponent.FinishLightDirectApplierComponentBuffer(fbb, LightDirectApplierComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
