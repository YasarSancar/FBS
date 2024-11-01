// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.communicator.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum LiveEditBody : byte
{
  NONE = 0,
  SendMessage = 1,
  ReplayMessage = 2,
  HotReload = 3,
};

public class LiveEditBodyUnion {
  public LiveEditBody Type { get; set; }
  public object Value { get; set; }

  public LiveEditBodyUnion() {
    this.Type = LiveEditBody.NONE;
    this.Value = null;
  }

  public T As<T>() where T : class { return this.Value as T; }
  public gfl.communicator.fb.SendMessageT AsSendMessage() { return this.As<gfl.communicator.fb.SendMessageT>(); }
  public gfl.communicator.fb.ReplayMessageT AsReplayMessage() { return this.As<gfl.communicator.fb.ReplayMessageT>(); }
  public gfl.communicator.fb.HotReloadT AsHotReload() { return this.As<gfl.communicator.fb.HotReloadT>(); }

  public static int Pack(FlatBuffers.FlatBufferBuilder builder, LiveEditBodyUnion _o) {
    switch (_o.Type) {
      default: return 0;
      case LiveEditBody.SendMessage: return gfl.communicator.fb.SendMessage.Pack(builder, _o.AsSendMessage()).Value;
      case LiveEditBody.ReplayMessage: return gfl.communicator.fb.ReplayMessage.Pack(builder, _o.AsReplayMessage()).Value;
      case LiveEditBody.HotReload: return gfl.communicator.fb.HotReload.Pack(builder, _o.AsHotReload()).Value;
    }
  }
}

public class LiveEditBodyUnion_JsonConverter : Newtonsoft.Json.JsonConverter {
  public override bool CanConvert(System.Type objectType) {
    return objectType == typeof(LiveEditBodyUnion) || objectType == typeof(System.Collections.Generic.List<LiveEditBodyUnion>);
  }
  public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) {
    var _olist = value as System.Collections.Generic.List<LiveEditBodyUnion>;
    if (_olist != null) {
      writer.WriteStartArray();
      foreach (var _o in _olist) { this.WriteJson(writer, _o, serializer); }
      writer.WriteEndArray();
    } else {
      this.WriteJson(writer, value as LiveEditBodyUnion, serializer);
    }
  }
  public void WriteJson(Newtonsoft.Json.JsonWriter writer, LiveEditBodyUnion _o, Newtonsoft.Json.JsonSerializer serializer) {
    if (_o == null) return;
    serializer.Serialize(writer, _o.Value);
  }
  public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) {
    var _olist = existingValue as System.Collections.Generic.List<LiveEditBodyUnion>;
    if (_olist != null) {
      for (var _j = 0; _j < _olist.Count; ++_j) {
        reader.Read();
        _olist[_j] = this.ReadJson(reader, _olist[_j], serializer);
      }
      reader.Read();
      return _olist;
    } else {
      return this.ReadJson(reader, existingValue as LiveEditBodyUnion, serializer);
    }
  }
  public LiveEditBodyUnion ReadJson(Newtonsoft.Json.JsonReader reader, LiveEditBodyUnion _o, Newtonsoft.Json.JsonSerializer serializer) {
    if (_o == null) return null;
    switch (_o.Type) {
      default: break;
      case LiveEditBody.SendMessage: _o.Value = serializer.Deserialize<gfl.communicator.fb.SendMessageT>(reader); break;
      case LiveEditBody.ReplayMessage: _o.Value = serializer.Deserialize<gfl.communicator.fb.ReplayMessageT>(reader); break;
      case LiveEditBody.HotReload: _o.Value = serializer.Deserialize<gfl.communicator.fb.HotReloadT>(reader); break;
    }
    return _o;
  }
}

public struct SendMessage : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static SendMessage GetRootAsSendMessage(ByteBuffer _bb) { return GetRootAsSendMessage(_bb, new SendMessage()); }
  public static SendMessage GetRootAsSendMessage(ByteBuffer _bb, SendMessage obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SendMessage __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public byte Data(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int DataLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDataBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDataBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDataArray() { return __p.__vector_as_array<byte>(8); }

  public static Offset<gfl.communicator.fb.SendMessage> CreateSendMessage(FlatBufferBuilder builder,
      uint id = 0,
      StringOffset nameOffset = default(StringOffset),
      VectorOffset dataOffset = default(VectorOffset)) {
    builder.StartTable(3);
    SendMessage.AddData(builder, dataOffset);
    SendMessage.AddName(builder, nameOffset);
    SendMessage.AddId(builder, id);
    return SendMessage.EndSendMessage(builder);
  }

  public static void StartSendMessage(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddId(FlatBufferBuilder builder, uint id) { builder.AddUint(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddData(FlatBufferBuilder builder, VectorOffset dataOffset) { builder.AddOffset(2, dataOffset.Value, 0); }
  public static VectorOffset CreateDataVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDataVectorBlock(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartDataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static Offset<gfl.communicator.fb.SendMessage> EndSendMessage(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.communicator.fb.SendMessage>(o);
  }
  public SendMessageT UnPack() {
    var _o = new SendMessageT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SendMessageT _o) {
    _o.Id = this.Id;
    _o.Name = this.Name;
    _o.Data = new List<byte>();
    for (var _j = 0; _j < this.DataLength; ++_j) {_o.Data.Add(this.Data(_j));}
  }
  public static Offset<gfl.communicator.fb.SendMessage> Pack(FlatBufferBuilder builder, SendMessageT _o) {
    if (_o == null) return default(Offset<gfl.communicator.fb.SendMessage>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _data = default(VectorOffset);
    if (_o.Data != null) {
      var __data = _o.Data.ToArray();
      _data = CreateDataVector(builder, __data);
    }
    return CreateSendMessage(
      builder,
      _o.Id,
      _name,
      _data);
  }
};

public class SendMessageT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public uint Id { get; set; }
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("data")]
  public List<byte> Data { get; set; }

  public SendMessageT() {
    this.Id = 0;
    this.Name = null;
    this.Data = null;
  }
}

public struct ReplayMessage : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ReplayMessage GetRootAsReplayMessage(ByteBuffer _bb) { return GetRootAsReplayMessage(_bb, new ReplayMessage()); }
  public static ReplayMessage GetRootAsReplayMessage(ByteBuffer _bb, ReplayMessage obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ReplayMessage __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public byte Data(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int DataLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDataBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetDataBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetDataArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<gfl.communicator.fb.ReplayMessage> CreateReplayMessage(FlatBufferBuilder builder,
      uint id = 0,
      VectorOffset dataOffset = default(VectorOffset)) {
    builder.StartTable(2);
    ReplayMessage.AddData(builder, dataOffset);
    ReplayMessage.AddId(builder, id);
    return ReplayMessage.EndReplayMessage(builder);
  }

  public static void StartReplayMessage(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddId(FlatBufferBuilder builder, uint id) { builder.AddUint(0, id, 0); }
  public static void AddData(FlatBufferBuilder builder, VectorOffset dataOffset) { builder.AddOffset(1, dataOffset.Value, 0); }
  public static VectorOffset CreateDataVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDataVectorBlock(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartDataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static Offset<gfl.communicator.fb.ReplayMessage> EndReplayMessage(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.communicator.fb.ReplayMessage>(o);
  }
  public ReplayMessageT UnPack() {
    var _o = new ReplayMessageT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ReplayMessageT _o) {
    _o.Id = this.Id;
    _o.Data = new List<byte>();
    for (var _j = 0; _j < this.DataLength; ++_j) {_o.Data.Add(this.Data(_j));}
  }
  public static Offset<gfl.communicator.fb.ReplayMessage> Pack(FlatBufferBuilder builder, ReplayMessageT _o) {
    if (_o == null) return default(Offset<gfl.communicator.fb.ReplayMessage>);
    var _data = default(VectorOffset);
    if (_o.Data != null) {
      var __data = _o.Data.ToArray();
      _data = CreateDataVector(builder, __data);
    }
    return CreateReplayMessage(
      builder,
      _o.Id,
      _data);
  }
};

public class ReplayMessageT
{
  [Newtonsoft.Json.JsonProperty("id")]
  public uint Id { get; set; }
  [Newtonsoft.Json.JsonProperty("data")]
  public List<byte> Data { get; set; }

  public ReplayMessageT() {
    this.Id = 0;
    this.Data = null;
  }
}

public struct HotReload : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static HotReload GetRootAsHotReload(ByteBuffer _bb) { return GetRootAsHotReload(_bb, new HotReload()); }
  public static HotReload GetRootAsHotReload(ByteBuffer _bb, HotReload obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public HotReload __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Path { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPathBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetPathBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetPathArray() { return __p.__vector_as_array<byte>(4); }
  public byte Data(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int DataLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDataBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetDataBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetDataArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<gfl.communicator.fb.HotReload> CreateHotReload(FlatBufferBuilder builder,
      StringOffset pathOffset = default(StringOffset),
      VectorOffset dataOffset = default(VectorOffset)) {
    builder.StartTable(2);
    HotReload.AddData(builder, dataOffset);
    HotReload.AddPath(builder, pathOffset);
    return HotReload.EndHotReload(builder);
  }

  public static void StartHotReload(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset) { builder.AddOffset(0, pathOffset.Value, 0); }
  public static void AddData(FlatBufferBuilder builder, VectorOffset dataOffset) { builder.AddOffset(1, dataOffset.Value, 0); }
  public static VectorOffset CreateDataVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDataVectorBlock(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartDataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static Offset<gfl.communicator.fb.HotReload> EndHotReload(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.communicator.fb.HotReload>(o);
  }
  public HotReloadT UnPack() {
    var _o = new HotReloadT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(HotReloadT _o) {
    _o.Path = this.Path;
    _o.Data = new List<byte>();
    for (var _j = 0; _j < this.DataLength; ++_j) {_o.Data.Add(this.Data(_j));}
  }
  public static Offset<gfl.communicator.fb.HotReload> Pack(FlatBufferBuilder builder, HotReloadT _o) {
    if (_o == null) return default(Offset<gfl.communicator.fb.HotReload>);
    var _path = _o.Path == null ? default(StringOffset) : builder.CreateString(_o.Path);
    var _data = default(VectorOffset);
    if (_o.Data != null) {
      var __data = _o.Data.ToArray();
      _data = CreateDataVector(builder, __data);
    }
    return CreateHotReload(
      builder,
      _path,
      _data);
  }
};

public class HotReloadT
{
  [Newtonsoft.Json.JsonProperty("path")]
  public string Path { get; set; }
  [Newtonsoft.Json.JsonProperty("data")]
  public List<byte> Data { get; set; }

  public HotReloadT() {
    this.Path = null;
    this.Data = null;
  }
}

public struct LiveEditProtocol : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static LiveEditProtocol GetRootAsLiveEditProtocol(ByteBuffer _bb) { return GetRootAsLiveEditProtocol(_bb, new LiveEditProtocol()); }
  public static LiveEditProtocol GetRootAsLiveEditProtocol(ByteBuffer _bb, LiveEditProtocol obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LiveEditProtocol __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.communicator.fb.LiveEditBody BodyType { get { int o = __p.__offset(4); return o != 0 ? (gfl.communicator.fb.LiveEditBody)__p.bb.Get(o + __p.bb_pos) : gfl.communicator.fb.LiveEditBody.NONE; } }
  public TTable? Body<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }

  public static Offset<gfl.communicator.fb.LiveEditProtocol> CreateLiveEditProtocol(FlatBufferBuilder builder,
      gfl.communicator.fb.LiveEditBody body_type = gfl.communicator.fb.LiveEditBody.NONE,
      int bodyOffset = 0) {
    builder.StartTable(2);
    LiveEditProtocol.AddBody(builder, bodyOffset);
    LiveEditProtocol.AddBodyType(builder, body_type);
    return LiveEditProtocol.EndLiveEditProtocol(builder);
  }

  public static void StartLiveEditProtocol(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddBodyType(FlatBufferBuilder builder, gfl.communicator.fb.LiveEditBody bodyType) { builder.AddByte(0, (byte)bodyType, 0); }
  public static void AddBody(FlatBufferBuilder builder, int bodyOffset) { builder.AddOffset(1, bodyOffset, 0); }
  public static Offset<gfl.communicator.fb.LiveEditProtocol> EndLiveEditProtocol(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.communicator.fb.LiveEditProtocol>(o);
  }
  public static void FinishLiveEditProtocolBuffer(FlatBufferBuilder builder, Offset<gfl.communicator.fb.LiveEditProtocol> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedLiveEditProtocolBuffer(FlatBufferBuilder builder, Offset<gfl.communicator.fb.LiveEditProtocol> offset) { builder.FinishSizePrefixed(offset.Value); }
  public LiveEditProtocolT UnPack() {
    var _o = new LiveEditProtocolT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LiveEditProtocolT _o) {
    _o.Body = new gfl.communicator.fb.LiveEditBodyUnion();
    _o.Body.Type = this.BodyType;
    switch (this.BodyType) {
      default: break;
      case gfl.communicator.fb.LiveEditBody.SendMessage:
        _o.Body.Value = this.Body<gfl.communicator.fb.SendMessage>().HasValue ? this.Body<gfl.communicator.fb.SendMessage>().Value.UnPack() : null;
        break;
      case gfl.communicator.fb.LiveEditBody.ReplayMessage:
        _o.Body.Value = this.Body<gfl.communicator.fb.ReplayMessage>().HasValue ? this.Body<gfl.communicator.fb.ReplayMessage>().Value.UnPack() : null;
        break;
      case gfl.communicator.fb.LiveEditBody.HotReload:
        _o.Body.Value = this.Body<gfl.communicator.fb.HotReload>().HasValue ? this.Body<gfl.communicator.fb.HotReload>().Value.UnPack() : null;
        break;
    }
  }
  public static Offset<gfl.communicator.fb.LiveEditProtocol> Pack(FlatBufferBuilder builder, LiveEditProtocolT _o) {
    if (_o == null) return default(Offset<gfl.communicator.fb.LiveEditProtocol>);
    var _body_type = _o.Body == null ? gfl.communicator.fb.LiveEditBody.NONE : _o.Body.Type;
    var _body = _o.Body == null ? 0 : gfl.communicator.fb.LiveEditBodyUnion.Pack(builder, _o.Body);
    return CreateLiveEditProtocol(
      builder,
      _body_type,
      _body);
  }
};

public class LiveEditProtocolT
{
  [Newtonsoft.Json.JsonProperty("body_type")]
  private gfl.communicator.fb.LiveEditBody BodyType {
    get {
      return this.Body != null ? this.Body.Type : gfl.communicator.fb.LiveEditBody.NONE;
    }
    set {
      this.Body = new gfl.communicator.fb.LiveEditBodyUnion();
      this.Body.Type = value;
    }
  }
  [Newtonsoft.Json.JsonProperty("body")]
  [Newtonsoft.Json.JsonConverter(typeof(gfl.communicator.fb.LiveEditBodyUnion_JsonConverter))]
  public gfl.communicator.fb.LiveEditBodyUnion Body { get; set; }

  public LiveEditProtocolT() {
    this.Body = null;
  }

  public static LiveEditProtocolT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<LiveEditProtocolT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static LiveEditProtocolT DeserializeFromBinary(byte[] fbBuffer) {
    return LiveEditProtocol.GetRootAsLiveEditProtocol(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    LiveEditProtocol.FinishLiveEditProtocolBuffer(fbb, LiveEditProtocol.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
