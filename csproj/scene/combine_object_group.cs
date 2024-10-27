// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct CombineObjectGroup : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static CombineObjectGroup GetRootAsCombineObjectGroup(ByteBuffer _bb) { return GetRootAsCombineObjectGroup(_bb, new CombineObjectGroup()); }
  public static CombineObjectGroup GetRootAsCombineObjectGroup(ByteBuffer _bb, CombineObjectGroup obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CombineObjectGroup __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string CombineModelPath { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCombineModelPathBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetCombineModelPathBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetCombineModelPathArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<gfl.scene.fb.CombineObjectGroup> CreateCombineObjectGroup(FlatBufferBuilder builder,
      StringOffset combineModelPathOffset = default(StringOffset)) {
    builder.StartTable(1);
    CombineObjectGroup.AddCombineModelPath(builder, combineModelPathOffset);
    return CombineObjectGroup.EndCombineObjectGroup(builder);
  }

  public static void StartCombineObjectGroup(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddCombineModelPath(FlatBufferBuilder builder, StringOffset combineModelPathOffset) { builder.AddOffset(0, combineModelPathOffset.Value, 0); }
  public static Offset<gfl.scene.fb.CombineObjectGroup> EndCombineObjectGroup(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.CombineObjectGroup>(o);
  }
  public static void FinishCombineObjectGroupBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.CombineObjectGroup> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedCombineObjectGroupBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.CombineObjectGroup> offset) { builder.FinishSizePrefixed(offset.Value); }
  public CombineObjectGroupT UnPack() {
    var _o = new CombineObjectGroupT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CombineObjectGroupT _o) {
    _o.CombineModelPath = this.CombineModelPath;
  }
  public static Offset<gfl.scene.fb.CombineObjectGroup> Pack(FlatBufferBuilder builder, CombineObjectGroupT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.CombineObjectGroup>);
    var _combineModelPath = _o.CombineModelPath == null ? default(StringOffset) : builder.CreateString(_o.CombineModelPath);
    return CreateCombineObjectGroup(
      builder,
      _combineModelPath);
  }
};

public class CombineObjectGroupT
{
  [Newtonsoft.Json.JsonProperty("combineModelPath")]
  public string CombineModelPath { get; set; }

  public CombineObjectGroupT() {
    this.CombineModelPath = null;
  }

  public static CombineObjectGroupT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<CombineObjectGroupT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static CombineObjectGroupT DeserializeFromBinary(byte[] fbBuffer) {
    return CombineObjectGroup.GetRootAsCombineObjectGroup(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    CombineObjectGroup.FinishCombineObjectGroupBuffer(fbb, CombineObjectGroup.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
