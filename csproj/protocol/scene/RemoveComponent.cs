// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.protocol.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct RemoveComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static RemoveComponent GetRootAsRemoveComponent(ByteBuffer _bb) { return GetRootAsRemoveComponent(_bb, new RemoveComponent()); }
  public static RemoveComponent GetRootAsRemoveComponent(ByteBuffer _bb, RemoveComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RemoveComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string InstanceName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInstanceNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetInstanceNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetInstanceNameArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<gfl.protocol.scene.fb.RemoveComponent> CreateRemoveComponent(FlatBufferBuilder builder,
      StringOffset instanceNameOffset = default(StringOffset)) {
    builder.StartTable(1);
    RemoveComponent.AddInstanceName(builder, instanceNameOffset);
    return RemoveComponent.EndRemoveComponent(builder);
  }

  public static void StartRemoveComponent(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddInstanceName(FlatBufferBuilder builder, StringOffset instanceNameOffset) { builder.AddOffset(0, instanceNameOffset.Value, 0); }
  public static Offset<gfl.protocol.scene.fb.RemoveComponent> EndRemoveComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.protocol.scene.fb.RemoveComponent>(o);
  }
  public static void FinishRemoveComponentBuffer(FlatBufferBuilder builder, Offset<gfl.protocol.scene.fb.RemoveComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedRemoveComponentBuffer(FlatBufferBuilder builder, Offset<gfl.protocol.scene.fb.RemoveComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public RemoveComponentT UnPack() {
    var _o = new RemoveComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RemoveComponentT _o) {
    _o.InstanceName = this.InstanceName;
  }
  public static Offset<gfl.protocol.scene.fb.RemoveComponent> Pack(FlatBufferBuilder builder, RemoveComponentT _o) {
    if (_o == null) return default(Offset<gfl.protocol.scene.fb.RemoveComponent>);
    var _instanceName = _o.InstanceName == null ? default(StringOffset) : builder.CreateString(_o.InstanceName);
    return CreateRemoveComponent(
      builder,
      _instanceName);
  }
};

public class RemoveComponentT
{
  [Newtonsoft.Json.JsonProperty("instanceName")]
  public string InstanceName { get; set; }

  public RemoveComponentT() {
    this.InstanceName = null;
  }

  public static RemoveComponentT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<RemoveComponentT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static RemoveComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return RemoveComponent.GetRootAsRemoveComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    RemoveComponent.FinishRemoveComponentBuffer(fbb, RemoveComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
