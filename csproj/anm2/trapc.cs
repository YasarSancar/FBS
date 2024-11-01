// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.anm2.fbj
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct PreviewOrderGroup : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static PreviewOrderGroup GetRootAsPreviewOrderGroup(ByteBuffer _bb) { return GetRootAsPreviewOrderGroup(_bb, new PreviewOrderGroup()); }
  public static PreviewOrderGroup GetRootAsPreviewOrderGroup(ByteBuffer _bb, PreviewOrderGroup obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PreviewOrderGroup __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public string OrderList(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int OrderListLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<gfl.anm2.fbj.PreviewOrderGroup> CreatePreviewOrderGroup(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      VectorOffset orderListOffset = default(VectorOffset)) {
    builder.StartTable(2);
    PreviewOrderGroup.AddOrderList(builder, orderListOffset);
    PreviewOrderGroup.AddName(builder, nameOffset);
    return PreviewOrderGroup.EndPreviewOrderGroup(builder);
  }

  public static void StartPreviewOrderGroup(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddOrderList(FlatBufferBuilder builder, VectorOffset orderListOffset) { builder.AddOffset(1, orderListOffset.Value, 0); }
  public static VectorOffset CreateOrderListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateOrderListVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartOrderListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<gfl.anm2.fbj.PreviewOrderGroup> EndPreviewOrderGroup(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fbj.PreviewOrderGroup>(o);
  }
  public PreviewOrderGroupT UnPack() {
    var _o = new PreviewOrderGroupT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PreviewOrderGroupT _o) {
    _o.Name = this.Name;
    _o.OrderList = new List<string>();
    for (var _j = 0; _j < this.OrderListLength; ++_j) {_o.OrderList.Add(this.OrderList(_j));}
  }
  public static Offset<gfl.anm2.fbj.PreviewOrderGroup> Pack(FlatBufferBuilder builder, PreviewOrderGroupT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fbj.PreviewOrderGroup>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _orderList = default(VectorOffset);
    if (_o.OrderList != null) {
      var __orderList = new StringOffset[_o.OrderList.Count];
      for (var _j = 0; _j < __orderList.Length; ++_j) { __orderList[_j] = builder.CreateString(_o.OrderList[_j]); }
      _orderList = CreateOrderListVector(builder, __orderList);
    }
    return CreatePreviewOrderGroup(
      builder,
      _name,
      _orderList);
  }
};

public class PreviewOrderGroupT
{
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("orderList")]
  public List<string> OrderList { get; set; }

  public PreviewOrderGroupT() {
    this.Name = null;
    this.OrderList = null;
  }
}

public struct PreviewConfig : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static PreviewConfig GetRootAsPreviewConfig(ByteBuffer _bb) { return GetRootAsPreviewConfig(_bb, new PreviewConfig()); }
  public static PreviewConfig GetRootAsPreviewConfig(ByteBuffer _bb, PreviewConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PreviewConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.anm2.fbj.PreviewOrderGroup? GroupList(int j) { int o = __p.__offset(4); return o != 0 ? (gfl.anm2.fbj.PreviewOrderGroup?)(new gfl.anm2.fbj.PreviewOrderGroup()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int GroupListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<gfl.anm2.fbj.PreviewConfig> CreatePreviewConfig(FlatBufferBuilder builder,
      VectorOffset groupListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    PreviewConfig.AddGroupList(builder, groupListOffset);
    return PreviewConfig.EndPreviewConfig(builder);
  }

  public static void StartPreviewConfig(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddGroupList(FlatBufferBuilder builder, VectorOffset groupListOffset) { builder.AddOffset(0, groupListOffset.Value, 0); }
  public static VectorOffset CreateGroupListVector(FlatBufferBuilder builder, Offset<gfl.anm2.fbj.PreviewOrderGroup>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateGroupListVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fbj.PreviewOrderGroup>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartGroupListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<gfl.anm2.fbj.PreviewConfig> EndPreviewConfig(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fbj.PreviewConfig>(o);
  }
  public static void FinishPreviewConfigBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fbj.PreviewConfig> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedPreviewConfigBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fbj.PreviewConfig> offset) { builder.FinishSizePrefixed(offset.Value); }
  public PreviewConfigT UnPack() {
    var _o = new PreviewConfigT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PreviewConfigT _o) {
    _o.GroupList = new List<gfl.anm2.fbj.PreviewOrderGroupT>();
    for (var _j = 0; _j < this.GroupListLength; ++_j) {_o.GroupList.Add(this.GroupList(_j).HasValue ? this.GroupList(_j).Value.UnPack() : null);}
  }
  public static Offset<gfl.anm2.fbj.PreviewConfig> Pack(FlatBufferBuilder builder, PreviewConfigT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fbj.PreviewConfig>);
    var _groupList = default(VectorOffset);
    if (_o.GroupList != null) {
      var __groupList = new Offset<gfl.anm2.fbj.PreviewOrderGroup>[_o.GroupList.Count];
      for (var _j = 0; _j < __groupList.Length; ++_j) { __groupList[_j] = gfl.anm2.fbj.PreviewOrderGroup.Pack(builder, _o.GroupList[_j]); }
      _groupList = CreateGroupListVector(builder, __groupList);
    }
    return CreatePreviewConfig(
      builder,
      _groupList);
  }
};

public class PreviewConfigT
{
  [Newtonsoft.Json.JsonProperty("groupList")]
  public List<gfl.anm2.fbj.PreviewOrderGroupT> GroupList { get; set; }

  public PreviewConfigT() {
    this.GroupList = null;
  }

  public static PreviewConfigT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<PreviewConfigT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static PreviewConfigT DeserializeFromBinary(byte[] fbBuffer) {
    return PreviewConfig.GetRootAsPreviewConfig(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    PreviewConfig.FinishPreviewConfigBuffer(fbb, PreviewConfig.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
