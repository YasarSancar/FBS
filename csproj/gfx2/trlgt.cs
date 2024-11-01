// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.gfx2.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct Light : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static Light GetRootAsLight(ByteBuffer _bb) { return GetRootAsLight(_bb, new Light()); }
  public static Light GetRootAsLight(ByteBuffer _bb, Light obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Light __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Version { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)1; } }
  public gfl.gfx2.fb.LightItem? ItemList(int j) { int o = __p.__offset(6); return o != 0 ? (gfl.gfx2.fb.LightItem?)(new gfl.gfx2.fb.LightItem()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ItemListLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<gfl.gfx2.fb.Light> CreateLight(FlatBufferBuilder builder,
      uint version = 1,
      VectorOffset item_listOffset = default(VectorOffset)) {
    builder.StartTable(2);
    Light.AddItemList(builder, item_listOffset);
    Light.AddVersion(builder, version);
    return Light.EndLight(builder);
  }

  public static void StartLight(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddVersion(FlatBufferBuilder builder, uint version) { builder.AddUint(0, version, 1); }
  public static void AddItemList(FlatBufferBuilder builder, VectorOffset itemListOffset) { builder.AddOffset(1, itemListOffset.Value, 0); }
  public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, Offset<gfl.gfx2.fb.LightItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateItemListVectorBlock(FlatBufferBuilder builder, Offset<gfl.gfx2.fb.LightItem>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<gfl.gfx2.fb.Light> EndLight(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.gfx2.fb.Light>(o);
  }
  public static void FinishLightBuffer(FlatBufferBuilder builder, Offset<gfl.gfx2.fb.Light> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedLightBuffer(FlatBufferBuilder builder, Offset<gfl.gfx2.fb.Light> offset) { builder.FinishSizePrefixed(offset.Value); }
  public LightT UnPack() {
    var _o = new LightT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LightT _o) {
    _o.Version = this.Version;
    _o.ItemList = new List<gfl.gfx2.fb.LightItemT>();
    for (var _j = 0; _j < this.ItemListLength; ++_j) {_o.ItemList.Add(this.ItemList(_j).HasValue ? this.ItemList(_j).Value.UnPack() : null);}
  }
  public static Offset<gfl.gfx2.fb.Light> Pack(FlatBufferBuilder builder, LightT _o) {
    if (_o == null) return default(Offset<gfl.gfx2.fb.Light>);
    var _item_list = default(VectorOffset);
    if (_o.ItemList != null) {
      var __item_list = new Offset<gfl.gfx2.fb.LightItem>[_o.ItemList.Count];
      for (var _j = 0; _j < __item_list.Length; ++_j) { __item_list[_j] = gfl.gfx2.fb.LightItem.Pack(builder, _o.ItemList[_j]); }
      _item_list = CreateItemListVector(builder, __item_list);
    }
    return CreateLight(
      builder,
      _o.Version,
      _item_list);
  }
};

public class LightT
{
  [Newtonsoft.Json.JsonProperty("version")]
  public uint Version { get; set; }
  [Newtonsoft.Json.JsonProperty("item_list")]
  public List<gfl.gfx2.fb.LightItemT> ItemList { get; set; }

  public LightT() {
    this.Version = 1;
    this.ItemList = null;
  }

  public static LightT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<LightT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static LightT DeserializeFromBinary(byte[] fbBuffer) {
    return Light.GetRootAsLight(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    Light.FinishLightBuffer(fbb, Light.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
