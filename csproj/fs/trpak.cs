// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.fs.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum CodeKind : sbyte
{
  None = -1,
  Zlib = 0,
  LZ4Default = 1,
  LZ4HC = 2,
  Plugin = 3,
};

public struct FileData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static FileData GetRootAsFileData(ByteBuffer _bb) { return GetRootAsFileData(_bb, new FileData()); }
  public static FileData GetRootAsFileData(ByteBuffer _bb, FileData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FileData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.fs.fb.FileMeta? Meta { get { int o = __p.__offset(4); return o != 0 ? (gfl.fs.fb.FileMeta?)(new gfl.fs.fb.FileMeta()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public gfl.fs.fb.CodeKind CompCodec { get { int o = __p.__offset(6); return o != 0 ? (gfl.fs.fb.CodeKind)__p.bb.GetSbyte(o + __p.bb_pos) : gfl.fs.fb.CodeKind.Zlib; } }
  public sbyte CompLevel { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
  public ulong SrcSize { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUlong(o + __p.bb_pos) : (ulong)0; } }
  public byte DstData(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int DstDataLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDstDataBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetDstDataBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetDstDataArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<gfl.fs.fb.FileData> CreateFileData(FlatBufferBuilder builder,
      Offset<gfl.fs.fb.FileMeta> metaOffset = default(Offset<gfl.fs.fb.FileMeta>),
      gfl.fs.fb.CodeKind compCodec = gfl.fs.fb.CodeKind.Zlib,
      sbyte compLevel = 0,
      ulong srcSize = 0,
      VectorOffset dstDataOffset = default(VectorOffset)) {
    builder.StartTable(5);
    FileData.AddSrcSize(builder, srcSize);
    FileData.AddDstData(builder, dstDataOffset);
    FileData.AddMeta(builder, metaOffset);
    FileData.AddCompLevel(builder, compLevel);
    FileData.AddCompCodec(builder, compCodec);
    return FileData.EndFileData(builder);
  }

  public static void StartFileData(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddMeta(FlatBufferBuilder builder, Offset<gfl.fs.fb.FileMeta> metaOffset) { builder.AddOffset(0, metaOffset.Value, 0); }
  public static void AddCompCodec(FlatBufferBuilder builder, gfl.fs.fb.CodeKind compCodec) { builder.AddSbyte(1, (sbyte)compCodec, 0); }
  public static void AddCompLevel(FlatBufferBuilder builder, sbyte compLevel) { builder.AddSbyte(2, compLevel, 0); }
  public static void AddSrcSize(FlatBufferBuilder builder, ulong srcSize) { builder.AddUlong(3, srcSize, 0); }
  public static void AddDstData(FlatBufferBuilder builder, VectorOffset dstDataOffset) { builder.AddOffset(4, dstDataOffset.Value, 0); }
  public static VectorOffset CreateDstDataVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDstDataVectorBlock(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartDstDataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static Offset<gfl.fs.fb.FileData> EndFileData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.fs.fb.FileData>(o);
  }
  public FileDataT UnPack() {
    var _o = new FileDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FileDataT _o) {
    _o.Meta = this.Meta.HasValue ? this.Meta.Value.UnPack() : null;
    _o.CompCodec = this.CompCodec;
    _o.CompLevel = this.CompLevel;
    _o.SrcSize = this.SrcSize;
    _o.DstData = new List<byte>();
    for (var _j = 0; _j < this.DstDataLength; ++_j) {_o.DstData.Add(this.DstData(_j));}
  }
  public static Offset<gfl.fs.fb.FileData> Pack(FlatBufferBuilder builder, FileDataT _o) {
    if (_o == null) return default(Offset<gfl.fs.fb.FileData>);
    var _meta = _o.Meta == null ? default(Offset<gfl.fs.fb.FileMeta>) : gfl.fs.fb.FileMeta.Pack(builder, _o.Meta);
    var _dstData = default(VectorOffset);
    if (_o.DstData != null) {
      var __dstData = _o.DstData.ToArray();
      _dstData = CreateDstDataVector(builder, __dstData);
    }
    return CreateFileData(
      builder,
      _meta,
      _o.CompCodec,
      _o.CompLevel,
      _o.SrcSize,
      _dstData);
  }
};

public class FileDataT
{
  [Newtonsoft.Json.JsonProperty("meta")]
  public gfl.fs.fb.FileMetaT Meta { get; set; }
  [Newtonsoft.Json.JsonProperty("compCodec")]
  public gfl.fs.fb.CodeKind CompCodec { get; set; }
  [Newtonsoft.Json.JsonProperty("compLevel")]
  public sbyte CompLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("srcSize")]
  public ulong SrcSize { get; set; }
  [Newtonsoft.Json.JsonProperty("dstData")]
  public List<byte> DstData { get; set; }

  public FileDataT() {
    this.Meta = null;
    this.CompCodec = gfl.fs.fb.CodeKind.Zlib;
    this.CompLevel = 0;
    this.SrcSize = 0;
    this.DstData = null;
  }
}

public struct PackData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static PackData GetRootAsPackData(ByteBuffer _bb) { return GetRootAsPackData(_bb, new PackData()); }
  public static PackData GetRootAsPackData(ByteBuffer _bb, PackData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PackData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.fs.fb.CodeKind CompCodec { get { int o = __p.__offset(4); return o != 0 ? (gfl.fs.fb.CodeKind)__p.bb.GetSbyte(o + __p.bb_pos) : gfl.fs.fb.CodeKind.Zlib; } }
  public sbyte CompLevel { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
  public ulong SrcSize { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUlong(o + __p.bb_pos) : (ulong)0; } }
  public byte DstData(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int DstDataLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDstDataBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetDstDataBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetDstDataArray() { return __p.__vector_as_array<byte>(10); }
  public ushort Indexs(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUshort(__p.__vector(o) + j * 2) : (ushort)0; }
  public int IndexsLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<ushort> GetIndexsBytes() { return __p.__vector_as_span<ushort>(12, 2); }
#else
  public ArraySegment<byte>? GetIndexsBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public ushort[] GetIndexsArray() { return __p.__vector_as_array<ushort>(12); }

  public static Offset<gfl.fs.fb.PackData> CreatePackData(FlatBufferBuilder builder,
      gfl.fs.fb.CodeKind compCodec = gfl.fs.fb.CodeKind.Zlib,
      sbyte compLevel = 0,
      ulong srcSize = 0,
      VectorOffset dstDataOffset = default(VectorOffset),
      VectorOffset indexsOffset = default(VectorOffset)) {
    builder.StartTable(5);
    PackData.AddSrcSize(builder, srcSize);
    PackData.AddIndexs(builder, indexsOffset);
    PackData.AddDstData(builder, dstDataOffset);
    PackData.AddCompLevel(builder, compLevel);
    PackData.AddCompCodec(builder, compCodec);
    return PackData.EndPackData(builder);
  }

  public static void StartPackData(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddCompCodec(FlatBufferBuilder builder, gfl.fs.fb.CodeKind compCodec) { builder.AddSbyte(0, (sbyte)compCodec, 0); }
  public static void AddCompLevel(FlatBufferBuilder builder, sbyte compLevel) { builder.AddSbyte(1, compLevel, 0); }
  public static void AddSrcSize(FlatBufferBuilder builder, ulong srcSize) { builder.AddUlong(2, srcSize, 0); }
  public static void AddDstData(FlatBufferBuilder builder, VectorOffset dstDataOffset) { builder.AddOffset(3, dstDataOffset.Value, 0); }
  public static VectorOffset CreateDstDataVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDstDataVectorBlock(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartDstDataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddIndexs(FlatBufferBuilder builder, VectorOffset indexsOffset) { builder.AddOffset(4, indexsOffset.Value, 0); }
  public static VectorOffset CreateIndexsVector(FlatBufferBuilder builder, ushort[] data) { builder.StartVector(2, data.Length, 2); for (int i = data.Length - 1; i >= 0; i--) builder.AddUshort(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateIndexsVectorBlock(FlatBufferBuilder builder, ushort[] data) { builder.StartVector(2, data.Length, 2); builder.Add(data); return builder.EndVector(); }
  public static void StartIndexsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(2, numElems, 2); }
  public static Offset<gfl.fs.fb.PackData> EndPackData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.fs.fb.PackData>(o);
  }
  public PackDataT UnPack() {
    var _o = new PackDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PackDataT _o) {
    _o.CompCodec = this.CompCodec;
    _o.CompLevel = this.CompLevel;
    _o.SrcSize = this.SrcSize;
    _o.DstData = new List<byte>();
    for (var _j = 0; _j < this.DstDataLength; ++_j) {_o.DstData.Add(this.DstData(_j));}
    _o.Indexs = new List<ushort>();
    for (var _j = 0; _j < this.IndexsLength; ++_j) {_o.Indexs.Add(this.Indexs(_j));}
  }
  public static Offset<gfl.fs.fb.PackData> Pack(FlatBufferBuilder builder, PackDataT _o) {
    if (_o == null) return default(Offset<gfl.fs.fb.PackData>);
    var _dstData = default(VectorOffset);
    if (_o.DstData != null) {
      var __dstData = _o.DstData.ToArray();
      _dstData = CreateDstDataVector(builder, __dstData);
    }
    var _indexs = default(VectorOffset);
    if (_o.Indexs != null) {
      var __indexs = _o.Indexs.ToArray();
      _indexs = CreateIndexsVector(builder, __indexs);
    }
    return CreatePackData(
      builder,
      _o.CompCodec,
      _o.CompLevel,
      _o.SrcSize,
      _dstData,
      _indexs);
  }
};

public class PackDataT
{
  [Newtonsoft.Json.JsonProperty("compCodec")]
  public gfl.fs.fb.CodeKind CompCodec { get; set; }
  [Newtonsoft.Json.JsonProperty("compLevel")]
  public sbyte CompLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("srcSize")]
  public ulong SrcSize { get; set; }
  [Newtonsoft.Json.JsonProperty("dstData")]
  public List<byte> DstData { get; set; }
  [Newtonsoft.Json.JsonProperty("indexs")]
  public List<ushort> Indexs { get; set; }

  public PackDataT() {
    this.CompCodec = gfl.fs.fb.CodeKind.Zlib;
    this.CompLevel = 0;
    this.SrcSize = 0;
    this.DstData = null;
    this.Indexs = null;
  }
}

public struct ArchiveFile : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ArchiveFile GetRootAsArchiveFile(ByteBuffer _bb) { return GetRootAsArchiveFile(_bb, new ArchiveFile()); }
  public static ArchiveFile GetRootAsArchiveFile(ByteBuffer _bb, ArchiveFile obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ArchiveFile __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ulong PathHashs(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUlong(__p.__vector(o) + j * 8) : (ulong)0; }
  public int PathHashsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<ulong> GetPathHashsBytes() { return __p.__vector_as_span<ulong>(4, 8); }
#else
  public ArraySegment<byte>? GetPathHashsBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public ulong[] GetPathHashsArray() { return __p.__vector_as_array<ulong>(4); }
  public gfl.fs.fb.FileData? FileDatas(int j) { int o = __p.__offset(6); return o != 0 ? (gfl.fs.fb.FileData?)(new gfl.fs.fb.FileData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int FileDatasLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public gfl.fs.fb.PackData? PackData { get { int o = __p.__offset(8); return o != 0 ? (gfl.fs.fb.PackData?)(new gfl.fs.fb.PackData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<gfl.fs.fb.ArchiveFile> CreateArchiveFile(FlatBufferBuilder builder,
      VectorOffset pathHashsOffset = default(VectorOffset),
      VectorOffset fileDatasOffset = default(VectorOffset),
      Offset<gfl.fs.fb.PackData> packDataOffset = default(Offset<gfl.fs.fb.PackData>)) {
    builder.StartTable(3);
    ArchiveFile.AddPackData(builder, packDataOffset);
    ArchiveFile.AddFileDatas(builder, fileDatasOffset);
    ArchiveFile.AddPathHashs(builder, pathHashsOffset);
    return ArchiveFile.EndArchiveFile(builder);
  }

  public static void StartArchiveFile(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddPathHashs(FlatBufferBuilder builder, VectorOffset pathHashsOffset) { builder.AddOffset(0, pathHashsOffset.Value, 0); }
  public static VectorOffset CreatePathHashsVector(FlatBufferBuilder builder, ulong[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddUlong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePathHashsVectorBlock(FlatBufferBuilder builder, ulong[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static void StartPathHashsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddFileDatas(FlatBufferBuilder builder, VectorOffset fileDatasOffset) { builder.AddOffset(1, fileDatasOffset.Value, 0); }
  public static VectorOffset CreateFileDatasVector(FlatBufferBuilder builder, Offset<gfl.fs.fb.FileData>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateFileDatasVectorBlock(FlatBufferBuilder builder, Offset<gfl.fs.fb.FileData>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartFileDatasVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPackData(FlatBufferBuilder builder, Offset<gfl.fs.fb.PackData> packDataOffset) { builder.AddOffset(2, packDataOffset.Value, 0); }
  public static Offset<gfl.fs.fb.ArchiveFile> EndArchiveFile(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.fs.fb.ArchiveFile>(o);
  }
  public static void FinishArchiveFileBuffer(FlatBufferBuilder builder, Offset<gfl.fs.fb.ArchiveFile> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedArchiveFileBuffer(FlatBufferBuilder builder, Offset<gfl.fs.fb.ArchiveFile> offset) { builder.FinishSizePrefixed(offset.Value); }
  public ArchiveFileT UnPack() {
    var _o = new ArchiveFileT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ArchiveFileT _o) {
    _o.PathHashs = new List<ulong>();
    for (var _j = 0; _j < this.PathHashsLength; ++_j) {_o.PathHashs.Add(this.PathHashs(_j));}
    _o.FileDatas = new List<gfl.fs.fb.FileDataT>();
    for (var _j = 0; _j < this.FileDatasLength; ++_j) {_o.FileDatas.Add(this.FileDatas(_j).HasValue ? this.FileDatas(_j).Value.UnPack() : null);}
    _o.PackData = this.PackData.HasValue ? this.PackData.Value.UnPack() : null;
  }
  public static Offset<gfl.fs.fb.ArchiveFile> Pack(FlatBufferBuilder builder, ArchiveFileT _o) {
    if (_o == null) return default(Offset<gfl.fs.fb.ArchiveFile>);
    var _pathHashs = default(VectorOffset);
    if (_o.PathHashs != null) {
      var __pathHashs = _o.PathHashs.ToArray();
      _pathHashs = CreatePathHashsVector(builder, __pathHashs);
    }
    var _fileDatas = default(VectorOffset);
    if (_o.FileDatas != null) {
      var __fileDatas = new Offset<gfl.fs.fb.FileData>[_o.FileDatas.Count];
      for (var _j = 0; _j < __fileDatas.Length; ++_j) { __fileDatas[_j] = gfl.fs.fb.FileData.Pack(builder, _o.FileDatas[_j]); }
      _fileDatas = CreateFileDatasVector(builder, __fileDatas);
    }
    var _packData = _o.PackData == null ? default(Offset<gfl.fs.fb.PackData>) : gfl.fs.fb.PackData.Pack(builder, _o.PackData);
    return CreateArchiveFile(
      builder,
      _pathHashs,
      _fileDatas,
      _packData);
  }
};

public class ArchiveFileT
{
  [Newtonsoft.Json.JsonProperty("pathHashs")]
  public List<ulong> PathHashs { get; set; }
  [Newtonsoft.Json.JsonProperty("fileDatas")]
  public List<gfl.fs.fb.FileDataT> FileDatas { get; set; }
  [Newtonsoft.Json.JsonProperty("packData")]
  public gfl.fs.fb.PackDataT PackData { get; set; }

  public ArchiveFileT() {
    this.PathHashs = null;
    this.FileDatas = null;
    this.PackData = null;
  }

  public static ArchiveFileT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<ArchiveFileT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static ArchiveFileT DeserializeFromBinary(byte[] fbBuffer) {
    return ArchiveFile.GetRootAsArchiveFile(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    ArchiveFile.FinishArchiveFileBuffer(fbb, ArchiveFile.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
