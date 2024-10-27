// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct TextureBufferComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static TextureBufferComponent GetRootAsTextureBufferComponent(ByteBuffer _bb) { return GetRootAsTextureBufferComponent(_bb, new TextureBufferComponent()); }
  public static TextureBufferComponent GetRootAsTextureBufferComponent(ByteBuffer _bb, TextureBufferComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TextureBufferComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int BufferCount { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<gfl.scene.fb.TextureBufferComponent> CreateTextureBufferComponent(FlatBufferBuilder builder,
      int bufferCount = 0) {
    builder.StartTable(1);
    TextureBufferComponent.AddBufferCount(builder, bufferCount);
    return TextureBufferComponent.EndTextureBufferComponent(builder);
  }

  public static void StartTextureBufferComponent(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddBufferCount(FlatBufferBuilder builder, int bufferCount) { builder.AddInt(0, bufferCount, 0); }
  public static Offset<gfl.scene.fb.TextureBufferComponent> EndTextureBufferComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.TextureBufferComponent>(o);
  }
  public static void FinishTextureBufferComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.TextureBufferComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedTextureBufferComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.TextureBufferComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public TextureBufferComponentT UnPack() {
    var _o = new TextureBufferComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TextureBufferComponentT _o) {
    _o.BufferCount = this.BufferCount;
  }
  public static Offset<gfl.scene.fb.TextureBufferComponent> Pack(FlatBufferBuilder builder, TextureBufferComponentT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.TextureBufferComponent>);
    return CreateTextureBufferComponent(
      builder,
      _o.BufferCount);
  }
};

public class TextureBufferComponentT
{
  [Newtonsoft.Json.JsonProperty("bufferCount")]
  public int BufferCount { get; set; }

  public TextureBufferComponentT() {
    this.BufferCount = 0;
  }

  public static TextureBufferComponentT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<TextureBufferComponentT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static TextureBufferComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return TextureBufferComponent.GetRootAsTextureBufferComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    TextureBufferComponent.FinishTextureBufferComponentBuffer(fbb, TextureBufferComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
