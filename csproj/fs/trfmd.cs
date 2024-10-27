// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.fs.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct FileMetaDictionary : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static FileMetaDictionary GetRootAsFileMetaDictionary(ByteBuffer _bb) { return GetRootAsFileMetaDictionary(_bb, new FileMetaDictionary()); }
  public static FileMetaDictionary GetRootAsFileMetaDictionary(ByteBuffer _bb, FileMetaDictionary obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FileMetaDictionary __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ulong Hashs(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUlong(__p.__vector(o) + j * 8) : (ulong)0; }
  public int HashsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<ulong> GetHashsBytes() { return __p.__vector_as_span<ulong>(4, 8); }
#else
  public ArraySegment<byte>? GetHashsBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public ulong[] GetHashsArray() { return __p.__vector_as_array<ulong>(4); }
  public gfl.fs.fb.FileMeta? Metas(int j) { int o = __p.__offset(6); return o != 0 ? (gfl.fs.fb.FileMeta?)(new gfl.fs.fb.FileMeta()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int MetasLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<gfl.fs.fb.FileMetaDictionary> CreateFileMetaDictionary(FlatBufferBuilder builder,
      VectorOffset hashsOffset = default(VectorOffset),
      VectorOffset metasOffset = default(VectorOffset)) {
    builder.StartTable(2);
    FileMetaDictionary.AddMetas(builder, metasOffset);
    FileMetaDictionary.AddHashs(builder, hashsOffset);
    return FileMetaDictionary.EndFileMetaDictionary(builder);
  }

  public static void StartFileMetaDictionary(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddHashs(FlatBufferBuilder builder, VectorOffset hashsOffset) { builder.AddOffset(0, hashsOffset.Value, 0); }
  public static VectorOffset CreateHashsVector(FlatBufferBuilder builder, ulong[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddUlong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateHashsVectorBlock(FlatBufferBuilder builder, ulong[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static void StartHashsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMetas(FlatBufferBuilder builder, VectorOffset metasOffset) { builder.AddOffset(1, metasOffset.Value, 0); }
  public static VectorOffset CreateMetasVector(FlatBufferBuilder builder, Offset<gfl.fs.fb.FileMeta>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateMetasVectorBlock(FlatBufferBuilder builder, Offset<gfl.fs.fb.FileMeta>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartMetasVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<gfl.fs.fb.FileMetaDictionary> EndFileMetaDictionary(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.fs.fb.FileMetaDictionary>(o);
  }
  public static void FinishFileMetaDictionaryBuffer(FlatBufferBuilder builder, Offset<gfl.fs.fb.FileMetaDictionary> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedFileMetaDictionaryBuffer(FlatBufferBuilder builder, Offset<gfl.fs.fb.FileMetaDictionary> offset) { builder.FinishSizePrefixed(offset.Value); }
  public FileMetaDictionaryT UnPack() {
    var _o = new FileMetaDictionaryT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FileMetaDictionaryT _o) {
    _o.Hashs = new List<ulong>();
    for (var _j = 0; _j < this.HashsLength; ++_j) {_o.Hashs.Add(this.Hashs(_j));}
    _o.Metas = new List<gfl.fs.fb.FileMetaT>();
    for (var _j = 0; _j < this.MetasLength; ++_j) {_o.Metas.Add(this.Metas(_j).HasValue ? this.Metas(_j).Value.UnPack() : null);}
  }
  public static Offset<gfl.fs.fb.FileMetaDictionary> Pack(FlatBufferBuilder builder, FileMetaDictionaryT _o) {
    if (_o == null) return default(Offset<gfl.fs.fb.FileMetaDictionary>);
    var _hashs = default(VectorOffset);
    if (_o.Hashs != null) {
      var __hashs = _o.Hashs.ToArray();
      _hashs = CreateHashsVector(builder, __hashs);
    }
    var _metas = default(VectorOffset);
    if (_o.Metas != null) {
      var __metas = new Offset<gfl.fs.fb.FileMeta>[_o.Metas.Count];
      for (var _j = 0; _j < __metas.Length; ++_j) { __metas[_j] = gfl.fs.fb.FileMeta.Pack(builder, _o.Metas[_j]); }
      _metas = CreateMetasVector(builder, __metas);
    }
    return CreateFileMetaDictionary(
      builder,
      _hashs,
      _metas);
  }
};

public class FileMetaDictionaryT
{
  [Newtonsoft.Json.JsonProperty("hashs")]
  public List<ulong> Hashs { get; set; }
  [Newtonsoft.Json.JsonProperty("metas")]
  public List<gfl.fs.fb.FileMetaT> Metas { get; set; }

  public FileMetaDictionaryT() {
    this.Hashs = null;
    this.Metas = null;
  }

  public static FileMetaDictionaryT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<FileMetaDictionaryT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static FileMetaDictionaryT DeserializeFromBinary(byte[] fbBuffer) {
    return FileMetaDictionary.GetRootAsFileMetaDictionary(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    FileMetaDictionary.FinishFileMetaDictionaryBuffer(fbb, FileMetaDictionary.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
