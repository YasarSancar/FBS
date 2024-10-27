// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.protocol.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct CreateElement : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static CreateElement GetRootAsCreateElement(ByteBuffer _bb) { return GetRootAsCreateElement(_bb, new CreateElement()); }
  public static CreateElement GetRootAsCreateElement(ByteBuffer _bb, CreateElement obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CreateElement __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string NodeId { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNodeIdBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNodeIdBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNodeIdArray() { return __p.__vector_as_array<byte>(4); }
  public string Type { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTypeBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetTypeBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetTypeArray() { return __p.__vector_as_array<byte>(6); }
  public string Name { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(8); }
  public string ResourceName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetResourceNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetResourceNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetResourceNameArray() { return __p.__vector_as_array<byte>(10); }
  public byte Data(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int DataLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDataBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetDataBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetDataArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<gfl.protocol.scene.fb.CreateElement> CreateCreateElement(FlatBufferBuilder builder,
      StringOffset nodeIdOffset = default(StringOffset),
      StringOffset typeOffset = default(StringOffset),
      StringOffset nameOffset = default(StringOffset),
      StringOffset resourceNameOffset = default(StringOffset),
      VectorOffset dataOffset = default(VectorOffset)) {
    builder.StartTable(5);
    CreateElement.AddData(builder, dataOffset);
    CreateElement.AddResourceName(builder, resourceNameOffset);
    CreateElement.AddName(builder, nameOffset);
    CreateElement.AddType(builder, typeOffset);
    CreateElement.AddNodeId(builder, nodeIdOffset);
    return CreateElement.EndCreateElement(builder);
  }

  public static void StartCreateElement(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddNodeId(FlatBufferBuilder builder, StringOffset nodeIdOffset) { builder.AddOffset(0, nodeIdOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset) { builder.AddOffset(1, typeOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(2, nameOffset.Value, 0); }
  public static void AddResourceName(FlatBufferBuilder builder, StringOffset resourceNameOffset) { builder.AddOffset(3, resourceNameOffset.Value, 0); }
  public static void AddData(FlatBufferBuilder builder, VectorOffset dataOffset) { builder.AddOffset(4, dataOffset.Value, 0); }
  public static VectorOffset CreateDataVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDataVectorBlock(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartDataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static Offset<gfl.protocol.scene.fb.CreateElement> EndCreateElement(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.protocol.scene.fb.CreateElement>(o);
  }
  public static void FinishCreateElementBuffer(FlatBufferBuilder builder, Offset<gfl.protocol.scene.fb.CreateElement> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedCreateElementBuffer(FlatBufferBuilder builder, Offset<gfl.protocol.scene.fb.CreateElement> offset) { builder.FinishSizePrefixed(offset.Value); }
  public CreateElementT UnPack() {
    var _o = new CreateElementT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CreateElementT _o) {
    _o.NodeId = this.NodeId;
    _o.Type = this.Type;
    _o.Name = this.Name;
    _o.ResourceName = this.ResourceName;
    _o.Data = new List<byte>();
    for (var _j = 0; _j < this.DataLength; ++_j) {_o.Data.Add(this.Data(_j));}
  }
  public static Offset<gfl.protocol.scene.fb.CreateElement> Pack(FlatBufferBuilder builder, CreateElementT _o) {
    if (_o == null) return default(Offset<gfl.protocol.scene.fb.CreateElement>);
    var _nodeId = _o.NodeId == null ? default(StringOffset) : builder.CreateString(_o.NodeId);
    var _type = _o.Type == null ? default(StringOffset) : builder.CreateString(_o.Type);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _resourceName = _o.ResourceName == null ? default(StringOffset) : builder.CreateString(_o.ResourceName);
    var _data = default(VectorOffset);
    if (_o.Data != null) {
      var __data = _o.Data.ToArray();
      _data = CreateDataVector(builder, __data);
    }
    return CreateCreateElement(
      builder,
      _nodeId,
      _type,
      _name,
      _resourceName,
      _data);
  }
};

public class CreateElementT
{
  [Newtonsoft.Json.JsonProperty("nodeId")]
  public string NodeId { get; set; }
  [Newtonsoft.Json.JsonProperty("type")]
  public string Type { get; set; }
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("resourceName")]
  public string ResourceName { get; set; }
  [Newtonsoft.Json.JsonProperty("data")]
  public List<byte> Data { get; set; }

  public CreateElementT() {
    this.NodeId = null;
    this.Type = null;
    this.Name = null;
    this.ResourceName = null;
    this.Data = null;
  }

  public static CreateElementT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<CreateElementT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static CreateElementT DeserializeFromBinary(byte[] fbBuffer) {
    return CreateElement.GetRootAsCreateElement(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    CreateElement.FinishCreateElementBuffer(fbb, CreateElement.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
