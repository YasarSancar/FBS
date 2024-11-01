// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace GenericEditor.Plugin.Model
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct ModelPreviewWireFrame : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ModelPreviewWireFrame GetRootAsModelPreviewWireFrame(ByteBuffer _bb) { return GetRootAsModelPreviewWireFrame(_bb, new ModelPreviewWireFrame()); }
  public static ModelPreviewWireFrame GetRootAsModelPreviewWireFrame(ByteBuffer _bb, ModelPreviewWireFrame obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ModelPreviewWireFrame __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string InstanceName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInstanceNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetInstanceNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetInstanceNameArray() { return __p.__vector_as_array<byte>(4); }
  public string TargetMeshName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTargetMeshNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetTargetMeshNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetTargetMeshNameArray() { return __p.__vector_as_array<byte>(6); }
  public bool WireFrame { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public GenericEditor.Plugin.Model.DataType DataType { get { int o = __p.__offset(10); return o != 0 ? (GenericEditor.Plugin.Model.DataType)__p.bb.GetUint(o + __p.bb_pos) : GenericEditor.Plugin.Model.DataType.ModelPreviewWireFrame; } }

  public static Offset<GenericEditor.Plugin.Model.ModelPreviewWireFrame> CreateModelPreviewWireFrame(FlatBufferBuilder builder,
      StringOffset instanceNameOffset = default(StringOffset),
      StringOffset targetMeshNameOffset = default(StringOffset),
      bool wireFrame = false,
      GenericEditor.Plugin.Model.DataType dataType = GenericEditor.Plugin.Model.DataType.ModelPreviewWireFrame) {
    builder.StartTable(4);
    ModelPreviewWireFrame.AddDataType(builder, dataType);
    ModelPreviewWireFrame.AddTargetMeshName(builder, targetMeshNameOffset);
    ModelPreviewWireFrame.AddInstanceName(builder, instanceNameOffset);
    ModelPreviewWireFrame.AddWireFrame(builder, wireFrame);
    return ModelPreviewWireFrame.EndModelPreviewWireFrame(builder);
  }

  public static void StartModelPreviewWireFrame(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddInstanceName(FlatBufferBuilder builder, StringOffset instanceNameOffset) { builder.AddOffset(0, instanceNameOffset.Value, 0); }
  public static void AddTargetMeshName(FlatBufferBuilder builder, StringOffset targetMeshNameOffset) { builder.AddOffset(1, targetMeshNameOffset.Value, 0); }
  public static void AddWireFrame(FlatBufferBuilder builder, bool wireFrame) { builder.AddBool(2, wireFrame, false); }
  public static void AddDataType(FlatBufferBuilder builder, GenericEditor.Plugin.Model.DataType dataType) { builder.AddUint(3, (uint)dataType, 16); }
  public static Offset<GenericEditor.Plugin.Model.ModelPreviewWireFrame> EndModelPreviewWireFrame(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<GenericEditor.Plugin.Model.ModelPreviewWireFrame>(o);
  }
  public static void FinishModelPreviewWireFrameBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Model.ModelPreviewWireFrame> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedModelPreviewWireFrameBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Model.ModelPreviewWireFrame> offset) { builder.FinishSizePrefixed(offset.Value); }
  public ModelPreviewWireFrameT UnPack() {
    var _o = new ModelPreviewWireFrameT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ModelPreviewWireFrameT _o) {
    _o.InstanceName = this.InstanceName;
    _o.TargetMeshName = this.TargetMeshName;
    _o.WireFrame = this.WireFrame;
    _o.DataType = this.DataType;
  }
  public static Offset<GenericEditor.Plugin.Model.ModelPreviewWireFrame> Pack(FlatBufferBuilder builder, ModelPreviewWireFrameT _o) {
    if (_o == null) return default(Offset<GenericEditor.Plugin.Model.ModelPreviewWireFrame>);
    var _instanceName = _o.InstanceName == null ? default(StringOffset) : builder.CreateString(_o.InstanceName);
    var _targetMeshName = _o.TargetMeshName == null ? default(StringOffset) : builder.CreateString(_o.TargetMeshName);
    return CreateModelPreviewWireFrame(
      builder,
      _instanceName,
      _targetMeshName,
      _o.WireFrame,
      _o.DataType);
  }
};

public class ModelPreviewWireFrameT
{
  [Newtonsoft.Json.JsonProperty("instanceName")]
  public string InstanceName { get; set; }
  [Newtonsoft.Json.JsonProperty("targetMeshName")]
  public string TargetMeshName { get; set; }
  [Newtonsoft.Json.JsonProperty("wireFrame")]
  public bool WireFrame { get; set; }
  [Newtonsoft.Json.JsonProperty("dataType")]
  public GenericEditor.Plugin.Model.DataType DataType { get; set; }

  public ModelPreviewWireFrameT() {
    this.InstanceName = null;
    this.TargetMeshName = null;
    this.WireFrame = false;
    this.DataType = GenericEditor.Plugin.Model.DataType.ModelPreviewWireFrame;
  }

  public static ModelPreviewWireFrameT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<ModelPreviewWireFrameT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static ModelPreviewWireFrameT DeserializeFromBinary(byte[] fbBuffer) {
    return ModelPreviewWireFrame.GetRootAsModelPreviewWireFrame(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    ModelPreviewWireFrame.FinishModelPreviewWireFrameBuffer(fbb, ModelPreviewWireFrame.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
