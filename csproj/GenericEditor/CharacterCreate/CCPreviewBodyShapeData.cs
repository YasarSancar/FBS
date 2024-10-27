// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace GenericEditor.Plugin.CharacterCreate.FB
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct CCPreviewBodyShapeData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static CCPreviewBodyShapeData GetRootAsCCPreviewBodyShapeData(ByteBuffer _bb) { return GetRootAsCCPreviewBodyShapeData(_bb, new CCPreviewBodyShapeData()); }
  public static CCPreviewBodyShapeData GetRootAsCCPreviewBodyShapeData(ByteBuffer _bb, CCPreviewBodyShapeData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CCPreviewBodyShapeData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string InstanceId { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInstanceIdBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetInstanceIdBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetInstanceIdArray() { return __p.__vector_as_array<byte>(4); }
  public gfl.cc.fb.CCModifierScalar? ScalarList(int j) { int o = __p.__offset(6); return o != 0 ? (gfl.cc.fb.CCModifierScalar?)(new gfl.cc.fb.CCModifierScalar()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ScalarListLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public gfl.cc.fb.CCModifierRatio? RatioList(int j) { int o = __p.__offset(8); return o != 0 ? (gfl.cc.fb.CCModifierRatio?)(new gfl.cc.fb.CCModifierRatio()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int RatioListLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<GenericEditor.Plugin.CharacterCreate.FB.CCPreviewBodyShapeData> CreateCCPreviewBodyShapeData(FlatBufferBuilder builder,
      StringOffset instanceIdOffset = default(StringOffset),
      VectorOffset scalarListOffset = default(VectorOffset),
      VectorOffset ratioListOffset = default(VectorOffset)) {
    builder.StartTable(3);
    CCPreviewBodyShapeData.AddRatioList(builder, ratioListOffset);
    CCPreviewBodyShapeData.AddScalarList(builder, scalarListOffset);
    CCPreviewBodyShapeData.AddInstanceId(builder, instanceIdOffset);
    return CCPreviewBodyShapeData.EndCCPreviewBodyShapeData(builder);
  }

  public static void StartCCPreviewBodyShapeData(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddInstanceId(FlatBufferBuilder builder, StringOffset instanceIdOffset) { builder.AddOffset(0, instanceIdOffset.Value, 0); }
  public static void AddScalarList(FlatBufferBuilder builder, VectorOffset scalarListOffset) { builder.AddOffset(1, scalarListOffset.Value, 0); }
  public static VectorOffset CreateScalarListVector(FlatBufferBuilder builder, Offset<gfl.cc.fb.CCModifierScalar>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateScalarListVectorBlock(FlatBufferBuilder builder, Offset<gfl.cc.fb.CCModifierScalar>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartScalarListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRatioList(FlatBufferBuilder builder, VectorOffset ratioListOffset) { builder.AddOffset(2, ratioListOffset.Value, 0); }
  public static VectorOffset CreateRatioListVector(FlatBufferBuilder builder, Offset<gfl.cc.fb.CCModifierRatio>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRatioListVectorBlock(FlatBufferBuilder builder, Offset<gfl.cc.fb.CCModifierRatio>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartRatioListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<GenericEditor.Plugin.CharacterCreate.FB.CCPreviewBodyShapeData> EndCCPreviewBodyShapeData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<GenericEditor.Plugin.CharacterCreate.FB.CCPreviewBodyShapeData>(o);
  }
  public static void FinishCCPreviewBodyShapeDataBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.CharacterCreate.FB.CCPreviewBodyShapeData> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedCCPreviewBodyShapeDataBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.CharacterCreate.FB.CCPreviewBodyShapeData> offset) { builder.FinishSizePrefixed(offset.Value); }
  public CCPreviewBodyShapeDataT UnPack() {
    var _o = new CCPreviewBodyShapeDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CCPreviewBodyShapeDataT _o) {
    _o.InstanceId = this.InstanceId;
    _o.ScalarList = new List<gfl.cc.fb.CCModifierScalarT>();
    for (var _j = 0; _j < this.ScalarListLength; ++_j) {_o.ScalarList.Add(this.ScalarList(_j).HasValue ? this.ScalarList(_j).Value.UnPack() : null);}
    _o.RatioList = new List<gfl.cc.fb.CCModifierRatioT>();
    for (var _j = 0; _j < this.RatioListLength; ++_j) {_o.RatioList.Add(this.RatioList(_j).HasValue ? this.RatioList(_j).Value.UnPack() : null);}
  }
  public static Offset<GenericEditor.Plugin.CharacterCreate.FB.CCPreviewBodyShapeData> Pack(FlatBufferBuilder builder, CCPreviewBodyShapeDataT _o) {
    if (_o == null) return default(Offset<GenericEditor.Plugin.CharacterCreate.FB.CCPreviewBodyShapeData>);
    var _instanceId = _o.InstanceId == null ? default(StringOffset) : builder.CreateString(_o.InstanceId);
    var _scalarList = default(VectorOffset);
    if (_o.ScalarList != null) {
      var __scalarList = new Offset<gfl.cc.fb.CCModifierScalar>[_o.ScalarList.Count];
      for (var _j = 0; _j < __scalarList.Length; ++_j) { __scalarList[_j] = gfl.cc.fb.CCModifierScalar.Pack(builder, _o.ScalarList[_j]); }
      _scalarList = CreateScalarListVector(builder, __scalarList);
    }
    var _ratioList = default(VectorOffset);
    if (_o.RatioList != null) {
      var __ratioList = new Offset<gfl.cc.fb.CCModifierRatio>[_o.RatioList.Count];
      for (var _j = 0; _j < __ratioList.Length; ++_j) { __ratioList[_j] = gfl.cc.fb.CCModifierRatio.Pack(builder, _o.RatioList[_j]); }
      _ratioList = CreateRatioListVector(builder, __ratioList);
    }
    return CreateCCPreviewBodyShapeData(
      builder,
      _instanceId,
      _scalarList,
      _ratioList);
  }
};

public class CCPreviewBodyShapeDataT
{
  [Newtonsoft.Json.JsonProperty("instanceId")]
  public string InstanceId { get; set; }
  [Newtonsoft.Json.JsonProperty("scalarList")]
  public List<gfl.cc.fb.CCModifierScalarT> ScalarList { get; set; }
  [Newtonsoft.Json.JsonProperty("ratioList")]
  public List<gfl.cc.fb.CCModifierRatioT> RatioList { get; set; }

  public CCPreviewBodyShapeDataT() {
    this.InstanceId = null;
    this.ScalarList = null;
    this.RatioList = null;
  }

  public static CCPreviewBodyShapeDataT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<CCPreviewBodyShapeDataT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static CCPreviewBodyShapeDataT DeserializeFromBinary(byte[] fbBuffer) {
    return CCPreviewBodyShapeData.GetRootAsCCPreviewBodyShapeData(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    CCPreviewBodyShapeData.FinishCCPreviewBodyShapeDataBuffer(fbb, CCPreviewBodyShapeData.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}