// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.fs.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct PrefetchFileList : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static PrefetchFileList GetRootAsPrefetchFileList(ByteBuffer _bb) { return GetRootAsPrefetchFileList(_bb, new PrefetchFileList()); }
  public static PrefetchFileList GetRootAsPrefetchFileList(ByteBuffer _bb, PrefetchFileList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PrefetchFileList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ulong Hashs(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUlong(__p.__vector(o) + j * 8) : (ulong)0; }
  public int HashsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<ulong> GetHashsBytes() { return __p.__vector_as_span<ulong>(4, 8); }
#else
  public ArraySegment<byte>? GetHashsBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public ulong[] GetHashsArray() { return __p.__vector_as_array<ulong>(4); }

  public static Offset<gfl.fs.fb.PrefetchFileList> CreatePrefetchFileList(FlatBufferBuilder builder,
      VectorOffset hashsOffset = default(VectorOffset)) {
    builder.StartTable(1);
    PrefetchFileList.AddHashs(builder, hashsOffset);
    return PrefetchFileList.EndPrefetchFileList(builder);
  }

  public static void StartPrefetchFileList(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddHashs(FlatBufferBuilder builder, VectorOffset hashsOffset) { builder.AddOffset(0, hashsOffset.Value, 0); }
  public static VectorOffset CreateHashsVector(FlatBufferBuilder builder, ulong[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddUlong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateHashsVectorBlock(FlatBufferBuilder builder, ulong[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static void StartHashsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<gfl.fs.fb.PrefetchFileList> EndPrefetchFileList(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.fs.fb.PrefetchFileList>(o);
  }
  public static void FinishPrefetchFileListBuffer(FlatBufferBuilder builder, Offset<gfl.fs.fb.PrefetchFileList> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedPrefetchFileListBuffer(FlatBufferBuilder builder, Offset<gfl.fs.fb.PrefetchFileList> offset) { builder.FinishSizePrefixed(offset.Value); }
  public PrefetchFileListT UnPack() {
    var _o = new PrefetchFileListT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PrefetchFileListT _o) {
    _o.Hashs = new List<ulong>();
    for (var _j = 0; _j < this.HashsLength; ++_j) {_o.Hashs.Add(this.Hashs(_j));}
  }
  public static Offset<gfl.fs.fb.PrefetchFileList> Pack(FlatBufferBuilder builder, PrefetchFileListT _o) {
    if (_o == null) return default(Offset<gfl.fs.fb.PrefetchFileList>);
    var _hashs = default(VectorOffset);
    if (_o.Hashs != null) {
      var __hashs = _o.Hashs.ToArray();
      _hashs = CreateHashsVector(builder, __hashs);
    }
    return CreatePrefetchFileList(
      builder,
      _hashs);
  }
};

public class PrefetchFileListT
{
  [Newtonsoft.Json.JsonProperty("hashs")]
  public List<ulong> Hashs { get; set; }

  public PrefetchFileListT() {
    this.Hashs = null;
  }

  public static PrefetchFileListT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<PrefetchFileListT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static PrefetchFileListT DeserializeFromBinary(byte[] fbBuffer) {
    return PrefetchFileList.GetRootAsPrefetchFileList(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    PrefetchFileList.FinishPrefetchFileListBuffer(fbb, PrefetchFileList.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}