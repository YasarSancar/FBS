// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct CompoundPencilShape : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static CompoundPencilShape GetRootAsCompoundPencilShape(ByteBuffer _bb) { return GetRootAsCompoundPencilShape(_bb, new CompoundPencilShape()); }
  public static CompoundPencilShape GetRootAsCompoundPencilShape(ByteBuffer _bb, CompoundPencilShape obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CompoundPencilShape __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string ResourceName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetResourceNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetResourceNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetResourceNameArray() { return __p.__vector_as_array<byte>(4); }
  public gfl.math.fb.Vector3f? Pos { get { int o = __p.__offset(6); return o != 0 ? (gfl.math.fb.Vector3f?)(new gfl.math.fb.Vector3f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public float Radius { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CylinderHeight { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float TipHeight { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int SliceCount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<gfl.scene.fb.CompoundPencilShape> CreateCompoundPencilShape(FlatBufferBuilder builder,
      StringOffset resourceNameOffset = default(StringOffset),
      gfl.math.fb.Vector3fT pos = null,
      float radius = 0.0f,
      float cylinderHeight = 0.0f,
      float tipHeight = 0.0f,
      int sliceCount = 0) {
    builder.StartTable(6);
    CompoundPencilShape.AddSliceCount(builder, sliceCount);
    CompoundPencilShape.AddTipHeight(builder, tipHeight);
    CompoundPencilShape.AddCylinderHeight(builder, cylinderHeight);
    CompoundPencilShape.AddRadius(builder, radius);
    CompoundPencilShape.AddPos(builder, gfl.math.fb.Vector3f.Pack(builder, pos));
    CompoundPencilShape.AddResourceName(builder, resourceNameOffset);
    return CompoundPencilShape.EndCompoundPencilShape(builder);
  }

  public static void StartCompoundPencilShape(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddResourceName(FlatBufferBuilder builder, StringOffset resourceNameOffset) { builder.AddOffset(0, resourceNameOffset.Value, 0); }
  public static void AddPos(FlatBufferBuilder builder, Offset<gfl.math.fb.Vector3f> posOffset) { builder.AddStruct(1, posOffset.Value, 0); }
  public static void AddRadius(FlatBufferBuilder builder, float radius) { builder.AddFloat(2, radius, 0.0f); }
  public static void AddCylinderHeight(FlatBufferBuilder builder, float cylinderHeight) { builder.AddFloat(3, cylinderHeight, 0.0f); }
  public static void AddTipHeight(FlatBufferBuilder builder, float tipHeight) { builder.AddFloat(4, tipHeight, 0.0f); }
  public static void AddSliceCount(FlatBufferBuilder builder, int sliceCount) { builder.AddInt(5, sliceCount, 0); }
  public static Offset<gfl.scene.fb.CompoundPencilShape> EndCompoundPencilShape(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.CompoundPencilShape>(o);
  }
  public static void FinishCompoundPencilShapeBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.CompoundPencilShape> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedCompoundPencilShapeBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.CompoundPencilShape> offset) { builder.FinishSizePrefixed(offset.Value); }
  public CompoundPencilShapeT UnPack() {
    var _o = new CompoundPencilShapeT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CompoundPencilShapeT _o) {
    _o.ResourceName = this.ResourceName;
    _o.Pos = this.Pos.HasValue ? this.Pos.Value.UnPack() : null;
    _o.Radius = this.Radius;
    _o.CylinderHeight = this.CylinderHeight;
    _o.TipHeight = this.TipHeight;
    _o.SliceCount = this.SliceCount;
  }
  public static Offset<gfl.scene.fb.CompoundPencilShape> Pack(FlatBufferBuilder builder, CompoundPencilShapeT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.CompoundPencilShape>);
    var _resourceName = _o.ResourceName == null ? default(StringOffset) : builder.CreateString(_o.ResourceName);
    return CreateCompoundPencilShape(
      builder,
      _resourceName,
      _o.Pos,
      _o.Radius,
      _o.CylinderHeight,
      _o.TipHeight,
      _o.SliceCount);
  }
};

public class CompoundPencilShapeT
{
  [Newtonsoft.Json.JsonProperty("resourceName")]
  public string ResourceName { get; set; }
  [Newtonsoft.Json.JsonProperty("pos")]
  public gfl.math.fb.Vector3fT Pos { get; set; }
  [Newtonsoft.Json.JsonProperty("radius")]
  public float Radius { get; set; }
  [Newtonsoft.Json.JsonProperty("cylinderHeight")]
  public float CylinderHeight { get; set; }
  [Newtonsoft.Json.JsonProperty("tipHeight")]
  public float TipHeight { get; set; }
  [Newtonsoft.Json.JsonProperty("sliceCount")]
  public int SliceCount { get; set; }

  public CompoundPencilShapeT() {
    this.ResourceName = null;
    this.Pos = new gfl.math.fb.Vector3fT();
    this.Radius = 0.0f;
    this.CylinderHeight = 0.0f;
    this.TipHeight = 0.0f;
    this.SliceCount = 0;
  }

  public static CompoundPencilShapeT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<CompoundPencilShapeT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static CompoundPencilShapeT DeserializeFromBinary(byte[] fbBuffer) {
    return CompoundPencilShape.GetRootAsCompoundPencilShape(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    CompoundPencilShape.FinishCompoundPencilShapeBuffer(fbb, CompoundPencilShape.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
