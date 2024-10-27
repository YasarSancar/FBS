// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum LodType : sbyte
{
  Direct = 0,
  CameraDistance = 1,
};

public struct DetailInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static DetailInfo GetRootAsDetailInfo(ByteBuffer _bb) { return GetRootAsDetailInfo(_bb, new DetailInfo()); }
  public static DetailInfo GetRootAsDetailInfo(ByteBuffer _bb, DetailInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DetailInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public bool OverrideParameter { get { int o = __p.__offset(4); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float MinScale { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float MaxScale { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Spread { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float NoiseScaleH { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float NoiseScaleV { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float NoiseOffsetX { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float NoiseOffsetZ { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float NoiseOffsetS { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float TileSize { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int CellResolutionPerTile { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TileResolutionLevel { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string OverrideFileName { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOverrideFileNameBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetOverrideFileNameBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetOverrideFileNameArray() { return __p.__vector_as_array<byte>(28); }

  public static Offset<gfl.scene.fb.DetailInfo> CreateDetailInfo(FlatBufferBuilder builder,
      bool overrideParameter = false,
      float minScale = 0.0f,
      float maxScale = 0.0f,
      float spread = 0.0f,
      float noiseScaleH = 0.0f,
      float noiseScaleV = 0.0f,
      float noiseOffsetX = 0.0f,
      float noiseOffsetZ = 0.0f,
      float noiseOffsetS = 0.0f,
      float tileSize = 0.0f,
      int cellResolutionPerTile = 0,
      int tileResolutionLevel = 0,
      StringOffset overrideFileNameOffset = default(StringOffset)) {
    builder.StartTable(13);
    DetailInfo.AddOverrideFileName(builder, overrideFileNameOffset);
    DetailInfo.AddTileResolutionLevel(builder, tileResolutionLevel);
    DetailInfo.AddCellResolutionPerTile(builder, cellResolutionPerTile);
    DetailInfo.AddTileSize(builder, tileSize);
    DetailInfo.AddNoiseOffsetS(builder, noiseOffsetS);
    DetailInfo.AddNoiseOffsetZ(builder, noiseOffsetZ);
    DetailInfo.AddNoiseOffsetX(builder, noiseOffsetX);
    DetailInfo.AddNoiseScaleV(builder, noiseScaleV);
    DetailInfo.AddNoiseScaleH(builder, noiseScaleH);
    DetailInfo.AddSpread(builder, spread);
    DetailInfo.AddMaxScale(builder, maxScale);
    DetailInfo.AddMinScale(builder, minScale);
    DetailInfo.AddOverrideParameter(builder, overrideParameter);
    return DetailInfo.EndDetailInfo(builder);
  }

  public static void StartDetailInfo(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddOverrideParameter(FlatBufferBuilder builder, bool overrideParameter) { builder.AddBool(0, overrideParameter, false); }
  public static void AddMinScale(FlatBufferBuilder builder, float minScale) { builder.AddFloat(1, minScale, 0.0f); }
  public static void AddMaxScale(FlatBufferBuilder builder, float maxScale) { builder.AddFloat(2, maxScale, 0.0f); }
  public static void AddSpread(FlatBufferBuilder builder, float spread) { builder.AddFloat(3, spread, 0.0f); }
  public static void AddNoiseScaleH(FlatBufferBuilder builder, float noiseScaleH) { builder.AddFloat(4, noiseScaleH, 0.0f); }
  public static void AddNoiseScaleV(FlatBufferBuilder builder, float noiseScaleV) { builder.AddFloat(5, noiseScaleV, 0.0f); }
  public static void AddNoiseOffsetX(FlatBufferBuilder builder, float noiseOffsetX) { builder.AddFloat(6, noiseOffsetX, 0.0f); }
  public static void AddNoiseOffsetZ(FlatBufferBuilder builder, float noiseOffsetZ) { builder.AddFloat(7, noiseOffsetZ, 0.0f); }
  public static void AddNoiseOffsetS(FlatBufferBuilder builder, float noiseOffsetS) { builder.AddFloat(8, noiseOffsetS, 0.0f); }
  public static void AddTileSize(FlatBufferBuilder builder, float tileSize) { builder.AddFloat(9, tileSize, 0.0f); }
  public static void AddCellResolutionPerTile(FlatBufferBuilder builder, int cellResolutionPerTile) { builder.AddInt(10, cellResolutionPerTile, 0); }
  public static void AddTileResolutionLevel(FlatBufferBuilder builder, int tileResolutionLevel) { builder.AddInt(11, tileResolutionLevel, 0); }
  public static void AddOverrideFileName(FlatBufferBuilder builder, StringOffset overrideFileNameOffset) { builder.AddOffset(12, overrideFileNameOffset.Value, 0); }
  public static Offset<gfl.scene.fb.DetailInfo> EndDetailInfo(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.DetailInfo>(o);
  }
  public DetailInfoT UnPack() {
    var _o = new DetailInfoT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(DetailInfoT _o) {
    _o.OverrideParameter = this.OverrideParameter;
    _o.MinScale = this.MinScale;
    _o.MaxScale = this.MaxScale;
    _o.Spread = this.Spread;
    _o.NoiseScaleH = this.NoiseScaleH;
    _o.NoiseScaleV = this.NoiseScaleV;
    _o.NoiseOffsetX = this.NoiseOffsetX;
    _o.NoiseOffsetZ = this.NoiseOffsetZ;
    _o.NoiseOffsetS = this.NoiseOffsetS;
    _o.TileSize = this.TileSize;
    _o.CellResolutionPerTile = this.CellResolutionPerTile;
    _o.TileResolutionLevel = this.TileResolutionLevel;
    _o.OverrideFileName = this.OverrideFileName;
  }
  public static Offset<gfl.scene.fb.DetailInfo> Pack(FlatBufferBuilder builder, DetailInfoT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.DetailInfo>);
    var _overrideFileName = _o.OverrideFileName == null ? default(StringOffset) : builder.CreateString(_o.OverrideFileName);
    return CreateDetailInfo(
      builder,
      _o.OverrideParameter,
      _o.MinScale,
      _o.MaxScale,
      _o.Spread,
      _o.NoiseScaleH,
      _o.NoiseScaleV,
      _o.NoiseOffsetX,
      _o.NoiseOffsetZ,
      _o.NoiseOffsetS,
      _o.TileSize,
      _o.CellResolutionPerTile,
      _o.TileResolutionLevel,
      _overrideFileName);
  }
};

public class DetailInfoT
{
  [Newtonsoft.Json.JsonProperty("overrideParameter")]
  public bool OverrideParameter { get; set; }
  [Newtonsoft.Json.JsonProperty("minScale")]
  public float MinScale { get; set; }
  [Newtonsoft.Json.JsonProperty("maxScale")]
  public float MaxScale { get; set; }
  [Newtonsoft.Json.JsonProperty("spread")]
  public float Spread { get; set; }
  [Newtonsoft.Json.JsonProperty("noiseScaleH")]
  public float NoiseScaleH { get; set; }
  [Newtonsoft.Json.JsonProperty("noiseScaleV")]
  public float NoiseScaleV { get; set; }
  [Newtonsoft.Json.JsonProperty("noiseOffsetX")]
  public float NoiseOffsetX { get; set; }
  [Newtonsoft.Json.JsonProperty("noiseOffsetZ")]
  public float NoiseOffsetZ { get; set; }
  [Newtonsoft.Json.JsonProperty("noiseOffsetS")]
  public float NoiseOffsetS { get; set; }
  [Newtonsoft.Json.JsonProperty("tileSize")]
  public float TileSize { get; set; }
  [Newtonsoft.Json.JsonProperty("cellResolutionPerTile")]
  public int CellResolutionPerTile { get; set; }
  [Newtonsoft.Json.JsonProperty("tileResolutionLevel")]
  public int TileResolutionLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("overrideFileName")]
  public string OverrideFileName { get; set; }

  public DetailInfoT() {
    this.OverrideParameter = false;
    this.MinScale = 0.0f;
    this.MaxScale = 0.0f;
    this.Spread = 0.0f;
    this.NoiseScaleH = 0.0f;
    this.NoiseScaleV = 0.0f;
    this.NoiseOffsetX = 0.0f;
    this.NoiseOffsetZ = 0.0f;
    this.NoiseOffsetS = 0.0f;
    this.TileSize = 0.0f;
    this.CellResolutionPerTile = 0;
    this.TileResolutionLevel = 0;
    this.OverrideFileName = null;
  }
}

public struct TerrainEntity : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static TerrainEntity GetRootAsTerrainEntity(ByteBuffer _bb) { return GetRootAsTerrainEntity(_bb, new TerrainEntity()); }
  public static TerrainEntity GetRootAsTerrainEntity(ByteBuffer _bb, TerrainEntity obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TerrainEntity __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public string FilePath { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFilePathBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetFilePathBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetFilePathArray() { return __p.__vector_as_array<byte>(6); }
  public gfl.scene.fb.LodType LodType { get { int o = __p.__offset(8); return o != 0 ? (gfl.scene.fb.LodType)__p.bb.GetSbyte(o + __p.bb_pos) : gfl.scene.fb.LodType.Direct; } }
  public int LodLevel { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float LodDistance { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string TerrainMaterialLow { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTerrainMaterialLowBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetTerrainMaterialLowBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetTerrainMaterialLowArray() { return __p.__vector_as_array<byte>(14); }
  public string TerrainMaterialMiddle { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTerrainMaterialMiddleBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetTerrainMaterialMiddleBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetTerrainMaterialMiddleArray() { return __p.__vector_as_array<byte>(16); }
  public string TerrainMaterialHigh { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTerrainMaterialHighBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetTerrainMaterialHighBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetTerrainMaterialHighArray() { return __p.__vector_as_array<byte>(18); }
  public gfl.scene.fb.DetailInfo? DetailInfos(int j) { int o = __p.__offset(20); return o != 0 ? (gfl.scene.fb.DetailInfo?)(new gfl.scene.fb.DetailInfo()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DetailInfosLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
  public bool OverrideTreeLodDistance { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float TreeLodDistance0 { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float TreeLodDistance1 { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float TreeLodDistance2 { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string DetailFilePaths(int j) { int o = __p.__offset(30); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int DetailFilePathsLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
  public bool Enable { get { int o = __p.__offset(32); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)true; } }

  public static Offset<gfl.scene.fb.TerrainEntity> CreateTerrainEntity(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      StringOffset filePathOffset = default(StringOffset),
      gfl.scene.fb.LodType lodType = gfl.scene.fb.LodType.Direct,
      int lodLevel = 0,
      float lodDistance = 0.0f,
      StringOffset terrainMaterialLowOffset = default(StringOffset),
      StringOffset terrainMaterialMiddleOffset = default(StringOffset),
      StringOffset terrainMaterialHighOffset = default(StringOffset),
      VectorOffset detailInfosOffset = default(VectorOffset),
      bool overrideTreeLodDistance = false,
      float treeLodDistance0 = 0.0f,
      float treeLodDistance1 = 0.0f,
      float treeLodDistance2 = 0.0f,
      VectorOffset detailFilePathsOffset = default(VectorOffset),
      bool enable = true) {
    builder.StartTable(15);
    TerrainEntity.AddDetailFilePaths(builder, detailFilePathsOffset);
    TerrainEntity.AddTreeLodDistance2(builder, treeLodDistance2);
    TerrainEntity.AddTreeLodDistance1(builder, treeLodDistance1);
    TerrainEntity.AddTreeLodDistance0(builder, treeLodDistance0);
    TerrainEntity.AddDetailInfos(builder, detailInfosOffset);
    TerrainEntity.AddTerrainMaterialHigh(builder, terrainMaterialHighOffset);
    TerrainEntity.AddTerrainMaterialMiddle(builder, terrainMaterialMiddleOffset);
    TerrainEntity.AddTerrainMaterialLow(builder, terrainMaterialLowOffset);
    TerrainEntity.AddLodDistance(builder, lodDistance);
    TerrainEntity.AddLodLevel(builder, lodLevel);
    TerrainEntity.AddFilePath(builder, filePathOffset);
    TerrainEntity.AddName(builder, nameOffset);
    TerrainEntity.AddEnable(builder, enable);
    TerrainEntity.AddOverrideTreeLodDistance(builder, overrideTreeLodDistance);
    TerrainEntity.AddLodType(builder, lodType);
    return TerrainEntity.EndTerrainEntity(builder);
  }

  public static void StartTerrainEntity(FlatBufferBuilder builder) { builder.StartTable(15); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddFilePath(FlatBufferBuilder builder, StringOffset filePathOffset) { builder.AddOffset(1, filePathOffset.Value, 0); }
  public static void AddLodType(FlatBufferBuilder builder, gfl.scene.fb.LodType lodType) { builder.AddSbyte(2, (sbyte)lodType, 0); }
  public static void AddLodLevel(FlatBufferBuilder builder, int lodLevel) { builder.AddInt(3, lodLevel, 0); }
  public static void AddLodDistance(FlatBufferBuilder builder, float lodDistance) { builder.AddFloat(4, lodDistance, 0.0f); }
  public static void AddTerrainMaterialLow(FlatBufferBuilder builder, StringOffset terrainMaterialLowOffset) { builder.AddOffset(5, terrainMaterialLowOffset.Value, 0); }
  public static void AddTerrainMaterialMiddle(FlatBufferBuilder builder, StringOffset terrainMaterialMiddleOffset) { builder.AddOffset(6, terrainMaterialMiddleOffset.Value, 0); }
  public static void AddTerrainMaterialHigh(FlatBufferBuilder builder, StringOffset terrainMaterialHighOffset) { builder.AddOffset(7, terrainMaterialHighOffset.Value, 0); }
  public static void AddDetailInfos(FlatBufferBuilder builder, VectorOffset detailInfosOffset) { builder.AddOffset(8, detailInfosOffset.Value, 0); }
  public static VectorOffset CreateDetailInfosVector(FlatBufferBuilder builder, Offset<gfl.scene.fb.DetailInfo>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDetailInfosVectorBlock(FlatBufferBuilder builder, Offset<gfl.scene.fb.DetailInfo>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartDetailInfosVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOverrideTreeLodDistance(FlatBufferBuilder builder, bool overrideTreeLodDistance) { builder.AddBool(9, overrideTreeLodDistance, false); }
  public static void AddTreeLodDistance0(FlatBufferBuilder builder, float treeLodDistance0) { builder.AddFloat(10, treeLodDistance0, 0.0f); }
  public static void AddTreeLodDistance1(FlatBufferBuilder builder, float treeLodDistance1) { builder.AddFloat(11, treeLodDistance1, 0.0f); }
  public static void AddTreeLodDistance2(FlatBufferBuilder builder, float treeLodDistance2) { builder.AddFloat(12, treeLodDistance2, 0.0f); }
  public static void AddDetailFilePaths(FlatBufferBuilder builder, VectorOffset detailFilePathsOffset) { builder.AddOffset(13, detailFilePathsOffset.Value, 0); }
  public static VectorOffset CreateDetailFilePathsVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDetailFilePathsVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartDetailFilePathsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEnable(FlatBufferBuilder builder, bool enable) { builder.AddBool(14, enable, true); }
  public static Offset<gfl.scene.fb.TerrainEntity> EndTerrainEntity(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.TerrainEntity>(o);
  }
  public static void FinishTerrainEntityBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.TerrainEntity> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedTerrainEntityBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.TerrainEntity> offset) { builder.FinishSizePrefixed(offset.Value); }
  public TerrainEntityT UnPack() {
    var _o = new TerrainEntityT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TerrainEntityT _o) {
    _o.Name = this.Name;
    _o.FilePath = this.FilePath;
    _o.LodType = this.LodType;
    _o.LodLevel = this.LodLevel;
    _o.LodDistance = this.LodDistance;
    _o.TerrainMaterialLow = this.TerrainMaterialLow;
    _o.TerrainMaterialMiddle = this.TerrainMaterialMiddle;
    _o.TerrainMaterialHigh = this.TerrainMaterialHigh;
    _o.DetailInfos = new List<gfl.scene.fb.DetailInfoT>();
    for (var _j = 0; _j < this.DetailInfosLength; ++_j) {_o.DetailInfos.Add(this.DetailInfos(_j).HasValue ? this.DetailInfos(_j).Value.UnPack() : null);}
    _o.OverrideTreeLodDistance = this.OverrideTreeLodDistance;
    _o.TreeLodDistance0 = this.TreeLodDistance0;
    _o.TreeLodDistance1 = this.TreeLodDistance1;
    _o.TreeLodDistance2 = this.TreeLodDistance2;
    _o.DetailFilePaths = new List<string>();
    for (var _j = 0; _j < this.DetailFilePathsLength; ++_j) {_o.DetailFilePaths.Add(this.DetailFilePaths(_j));}
    _o.Enable = this.Enable;
  }
  public static Offset<gfl.scene.fb.TerrainEntity> Pack(FlatBufferBuilder builder, TerrainEntityT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.TerrainEntity>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _filePath = _o.FilePath == null ? default(StringOffset) : builder.CreateString(_o.FilePath);
    var _terrainMaterialLow = _o.TerrainMaterialLow == null ? default(StringOffset) : builder.CreateString(_o.TerrainMaterialLow);
    var _terrainMaterialMiddle = _o.TerrainMaterialMiddle == null ? default(StringOffset) : builder.CreateString(_o.TerrainMaterialMiddle);
    var _terrainMaterialHigh = _o.TerrainMaterialHigh == null ? default(StringOffset) : builder.CreateString(_o.TerrainMaterialHigh);
    var _detailInfos = default(VectorOffset);
    if (_o.DetailInfos != null) {
      var __detailInfos = new Offset<gfl.scene.fb.DetailInfo>[_o.DetailInfos.Count];
      for (var _j = 0; _j < __detailInfos.Length; ++_j) { __detailInfos[_j] = gfl.scene.fb.DetailInfo.Pack(builder, _o.DetailInfos[_j]); }
      _detailInfos = CreateDetailInfosVector(builder, __detailInfos);
    }
    var _detailFilePaths = default(VectorOffset);
    if (_o.DetailFilePaths != null) {
      var __detailFilePaths = new StringOffset[_o.DetailFilePaths.Count];
      for (var _j = 0; _j < __detailFilePaths.Length; ++_j) { __detailFilePaths[_j] = builder.CreateString(_o.DetailFilePaths[_j]); }
      _detailFilePaths = CreateDetailFilePathsVector(builder, __detailFilePaths);
    }
    return CreateTerrainEntity(
      builder,
      _name,
      _filePath,
      _o.LodType,
      _o.LodLevel,
      _o.LodDistance,
      _terrainMaterialLow,
      _terrainMaterialMiddle,
      _terrainMaterialHigh,
      _detailInfos,
      _o.OverrideTreeLodDistance,
      _o.TreeLodDistance0,
      _o.TreeLodDistance1,
      _o.TreeLodDistance2,
      _detailFilePaths,
      _o.Enable);
  }
};

public class TerrainEntityT
{
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("filePath")]
  public string FilePath { get; set; }
  [Newtonsoft.Json.JsonProperty("lodType")]
  public gfl.scene.fb.LodType LodType { get; set; }
  [Newtonsoft.Json.JsonProperty("lodLevel")]
  public int LodLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("lodDistance")]
  public float LodDistance { get; set; }
  [Newtonsoft.Json.JsonProperty("terrainMaterialLow")]
  public string TerrainMaterialLow { get; set; }
  [Newtonsoft.Json.JsonProperty("terrainMaterialMiddle")]
  public string TerrainMaterialMiddle { get; set; }
  [Newtonsoft.Json.JsonProperty("terrainMaterialHigh")]
  public string TerrainMaterialHigh { get; set; }
  [Newtonsoft.Json.JsonProperty("detailInfos")]
  public List<gfl.scene.fb.DetailInfoT> DetailInfos { get; set; }
  [Newtonsoft.Json.JsonProperty("overrideTreeLodDistance")]
  public bool OverrideTreeLodDistance { get; set; }
  [Newtonsoft.Json.JsonProperty("treeLodDistance0")]
  public float TreeLodDistance0 { get; set; }
  [Newtonsoft.Json.JsonProperty("treeLodDistance1")]
  public float TreeLodDistance1 { get; set; }
  [Newtonsoft.Json.JsonProperty("treeLodDistance2")]
  public float TreeLodDistance2 { get; set; }
  [Newtonsoft.Json.JsonProperty("detailFilePaths")]
  public List<string> DetailFilePaths { get; set; }
  [Newtonsoft.Json.JsonProperty("enable")]
  public bool Enable { get; set; }

  public TerrainEntityT() {
    this.Name = null;
    this.FilePath = null;
    this.LodType = gfl.scene.fb.LodType.Direct;
    this.LodLevel = 0;
    this.LodDistance = 0.0f;
    this.TerrainMaterialLow = null;
    this.TerrainMaterialMiddle = null;
    this.TerrainMaterialHigh = null;
    this.DetailInfos = null;
    this.OverrideTreeLodDistance = false;
    this.TreeLodDistance0 = 0.0f;
    this.TreeLodDistance1 = 0.0f;
    this.TreeLodDistance2 = 0.0f;
    this.DetailFilePaths = null;
    this.Enable = true;
  }

  public static TerrainEntityT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<TerrainEntityT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static TerrainEntityT DeserializeFromBinary(byte[] fbBuffer) {
    return TerrainEntity.GetRootAsTerrainEntity(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    TerrainEntity.FinishTerrainEntityBuffer(fbb, TerrainEntity.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
