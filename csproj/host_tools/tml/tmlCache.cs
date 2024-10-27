// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace TimelineEditor.Cache
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct TmlCache : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static TmlCache GetRootAsTmlCache(ByteBuffer _bb) { return GetRootAsTmlCache(_bb, new TmlCache()); }
  public static TmlCache GetRootAsTmlCache(ByteBuffer _bb, TmlCache obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TmlCache __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string RecentFilePaths(int j) { int o = __p.__offset(4); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int RecentFilePathsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string SearchDirectoryPath { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSearchDirectoryPathBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetSearchDirectoryPathBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetSearchDirectoryPathArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<TimelineEditor.Cache.TmlCache> CreateTmlCache(FlatBufferBuilder builder,
      VectorOffset recentFilePathsOffset = default(VectorOffset),
      StringOffset searchDirectoryPathOffset = default(StringOffset)) {
    builder.StartTable(2);
    TmlCache.AddSearchDirectoryPath(builder, searchDirectoryPathOffset);
    TmlCache.AddRecentFilePaths(builder, recentFilePathsOffset);
    return TmlCache.EndTmlCache(builder);
  }

  public static void StartTmlCache(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddRecentFilePaths(FlatBufferBuilder builder, VectorOffset recentFilePathsOffset) { builder.AddOffset(0, recentFilePathsOffset.Value, 0); }
  public static VectorOffset CreateRecentFilePathsVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRecentFilePathsVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartRecentFilePathsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSearchDirectoryPath(FlatBufferBuilder builder, StringOffset searchDirectoryPathOffset) { builder.AddOffset(1, searchDirectoryPathOffset.Value, 0); }
  public static Offset<TimelineEditor.Cache.TmlCache> EndTmlCache(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<TimelineEditor.Cache.TmlCache>(o);
  }
  public static void FinishTmlCacheBuffer(FlatBufferBuilder builder, Offset<TimelineEditor.Cache.TmlCache> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedTmlCacheBuffer(FlatBufferBuilder builder, Offset<TimelineEditor.Cache.TmlCache> offset) { builder.FinishSizePrefixed(offset.Value); }
  public TmlCacheT UnPack() {
    var _o = new TmlCacheT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TmlCacheT _o) {
    _o.RecentFilePaths = new List<string>();
    for (var _j = 0; _j < this.RecentFilePathsLength; ++_j) {_o.RecentFilePaths.Add(this.RecentFilePaths(_j));}
    _o.SearchDirectoryPath = this.SearchDirectoryPath;
  }
  public static Offset<TimelineEditor.Cache.TmlCache> Pack(FlatBufferBuilder builder, TmlCacheT _o) {
    if (_o == null) return default(Offset<TimelineEditor.Cache.TmlCache>);
    var _recentFilePaths = default(VectorOffset);
    if (_o.RecentFilePaths != null) {
      var __recentFilePaths = new StringOffset[_o.RecentFilePaths.Count];
      for (var _j = 0; _j < __recentFilePaths.Length; ++_j) { __recentFilePaths[_j] = builder.CreateString(_o.RecentFilePaths[_j]); }
      _recentFilePaths = CreateRecentFilePathsVector(builder, __recentFilePaths);
    }
    var _searchDirectoryPath = _o.SearchDirectoryPath == null ? default(StringOffset) : builder.CreateString(_o.SearchDirectoryPath);
    return CreateTmlCache(
      builder,
      _recentFilePaths,
      _searchDirectoryPath);
  }
};

public class TmlCacheT
{
  [Newtonsoft.Json.JsonProperty("recentFilePaths")]
  public List<string> RecentFilePaths { get; set; }
  [Newtonsoft.Json.JsonProperty("searchDirectoryPath")]
  public string SearchDirectoryPath { get; set; }

  public TmlCacheT() {
    this.RecentFilePaths = null;
    this.SearchDirectoryPath = null;
  }

  public static TmlCacheT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<TmlCacheT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static TmlCacheT DeserializeFromBinary(byte[] fbBuffer) {
    return TmlCache.GetRootAsTmlCache(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    TmlCache.FinishTmlCacheBuffer(fbb, TmlCache.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
