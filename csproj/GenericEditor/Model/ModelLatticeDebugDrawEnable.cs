// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace GenericEditor.Plugin.Model
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct ModelLatticeDebugDrawEnable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ModelLatticeDebugDrawEnable GetRootAsModelLatticeDebugDrawEnable(ByteBuffer _bb) { return GetRootAsModelLatticeDebugDrawEnable(_bb, new ModelLatticeDebugDrawEnable()); }
  public static ModelLatticeDebugDrawEnable GetRootAsModelLatticeDebugDrawEnable(ByteBuffer _bb, ModelLatticeDebugDrawEnable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ModelLatticeDebugDrawEnable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string InstanceName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInstanceNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetInstanceNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetInstanceNameArray() { return __p.__vector_as_array<byte>(4); }
  public bool DebugDrawEnable { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public GenericEditor.Plugin.Model.DataType DataType { get { int o = __p.__offset(8); return o != 0 ? (GenericEditor.Plugin.Model.DataType)__p.bb.GetUint(o + __p.bb_pos) : GenericEditor.Plugin.Model.DataType.ModelLatticeDebugDrawEnable; } }

  public static Offset<GenericEditor.Plugin.Model.ModelLatticeDebugDrawEnable> CreateModelLatticeDebugDrawEnable(FlatBufferBuilder builder,
      StringOffset instanceNameOffset = default(StringOffset),
      bool debugDrawEnable = false,
      GenericEditor.Plugin.Model.DataType dataType = GenericEditor.Plugin.Model.DataType.ModelLatticeDebugDrawEnable) {
    builder.StartTable(3);
    ModelLatticeDebugDrawEnable.AddDataType(builder, dataType);
    ModelLatticeDebugDrawEnable.AddInstanceName(builder, instanceNameOffset);
    ModelLatticeDebugDrawEnable.AddDebugDrawEnable(builder, debugDrawEnable);
    return ModelLatticeDebugDrawEnable.EndModelLatticeDebugDrawEnable(builder);
  }

  public static void StartModelLatticeDebugDrawEnable(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddInstanceName(FlatBufferBuilder builder, StringOffset instanceNameOffset) { builder.AddOffset(0, instanceNameOffset.Value, 0); }
  public static void AddDebugDrawEnable(FlatBufferBuilder builder, bool debugDrawEnable) { builder.AddBool(1, debugDrawEnable, false); }
  public static void AddDataType(FlatBufferBuilder builder, GenericEditor.Plugin.Model.DataType dataType) { builder.AddUint(2, (uint)dataType, 15); }
  public static Offset<GenericEditor.Plugin.Model.ModelLatticeDebugDrawEnable> EndModelLatticeDebugDrawEnable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<GenericEditor.Plugin.Model.ModelLatticeDebugDrawEnable>(o);
  }
  public static void FinishModelLatticeDebugDrawEnableBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Model.ModelLatticeDebugDrawEnable> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedModelLatticeDebugDrawEnableBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Model.ModelLatticeDebugDrawEnable> offset) { builder.FinishSizePrefixed(offset.Value); }
  public ModelLatticeDebugDrawEnableT UnPack() {
    var _o = new ModelLatticeDebugDrawEnableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ModelLatticeDebugDrawEnableT _o) {
    _o.InstanceName = this.InstanceName;
    _o.DebugDrawEnable = this.DebugDrawEnable;
    _o.DataType = this.DataType;
  }
  public static Offset<GenericEditor.Plugin.Model.ModelLatticeDebugDrawEnable> Pack(FlatBufferBuilder builder, ModelLatticeDebugDrawEnableT _o) {
    if (_o == null) return default(Offset<GenericEditor.Plugin.Model.ModelLatticeDebugDrawEnable>);
    var _instanceName = _o.InstanceName == null ? default(StringOffset) : builder.CreateString(_o.InstanceName);
    return CreateModelLatticeDebugDrawEnable(
      builder,
      _instanceName,
      _o.DebugDrawEnable,
      _o.DataType);
  }
};

public class ModelLatticeDebugDrawEnableT
{
  [Newtonsoft.Json.JsonProperty("instanceName")]
  public string InstanceName { get; set; }
  [Newtonsoft.Json.JsonProperty("debugDrawEnable")]
  public bool DebugDrawEnable { get; set; }
  [Newtonsoft.Json.JsonProperty("dataType")]
  public GenericEditor.Plugin.Model.DataType DataType { get; set; }

  public ModelLatticeDebugDrawEnableT() {
    this.InstanceName = null;
    this.DebugDrawEnable = false;
    this.DataType = GenericEditor.Plugin.Model.DataType.ModelLatticeDebugDrawEnable;
  }

  public static ModelLatticeDebugDrawEnableT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<ModelLatticeDebugDrawEnableT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static ModelLatticeDebugDrawEnableT DeserializeFromBinary(byte[] fbBuffer) {
    return ModelLatticeDebugDrawEnable.GetRootAsModelLatticeDebugDrawEnable(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    ModelLatticeDebugDrawEnable.FinishModelLatticeDebugDrawEnableBuffer(fbb, ModelLatticeDebugDrawEnable.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
