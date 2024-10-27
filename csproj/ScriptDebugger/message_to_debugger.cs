// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sdp
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct ToDebuggerMessage : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ToDebuggerMessage GetRootAsToDebuggerMessage(ByteBuffer _bb) { return GetRootAsToDebuggerMessage(_bb, new ToDebuggerMessage()); }
  public static ToDebuggerMessage GetRootAsToDebuggerMessage(ByteBuffer _bb, ToDebuggerMessage obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ToDebuggerMessage __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public sdp.ToDebuggerMessageType MessageType { get { int o = __p.__offset(4); return o != 0 ? (sdp.ToDebuggerMessageType)__p.bb.Get(o + __p.bb_pos) : sdp.ToDebuggerMessageType.NONE; } }
  public TTable? Message<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }

  public static Offset<sdp.ToDebuggerMessage> CreateToDebuggerMessage(FlatBufferBuilder builder,
      sdp.ToDebuggerMessageType message_type = sdp.ToDebuggerMessageType.NONE,
      int messageOffset = 0) {
    builder.StartTable(2);
    ToDebuggerMessage.AddMessage(builder, messageOffset);
    ToDebuggerMessage.AddMessageType(builder, message_type);
    return ToDebuggerMessage.EndToDebuggerMessage(builder);
  }

  public static void StartToDebuggerMessage(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddMessageType(FlatBufferBuilder builder, sdp.ToDebuggerMessageType messageType) { builder.AddByte(0, (byte)messageType, 0); }
  public static void AddMessage(FlatBufferBuilder builder, int messageOffset) { builder.AddOffset(1, messageOffset, 0); }
  public static Offset<sdp.ToDebuggerMessage> EndToDebuggerMessage(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<sdp.ToDebuggerMessage>(o);
  }
  public static void FinishToDebuggerMessageBuffer(FlatBufferBuilder builder, Offset<sdp.ToDebuggerMessage> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedToDebuggerMessageBuffer(FlatBufferBuilder builder, Offset<sdp.ToDebuggerMessage> offset) { builder.FinishSizePrefixed(offset.Value); }
  public ToDebuggerMessageT UnPack() {
    var _o = new ToDebuggerMessageT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ToDebuggerMessageT _o) {
    _o.Message = new sdp.ToDebuggerMessageTypeUnion();
    _o.Message.Type = this.MessageType;
    switch (this.MessageType) {
      default: break;
      case sdp.ToDebuggerMessageType.StoppedEvent:
        _o.Message.Value = this.Message<sdp.StoppedEvent>().HasValue ? this.Message<sdp.StoppedEvent>().Value.UnPack() : null;
        break;
      case sdp.ToDebuggerMessageType.LoadedSourceEvent:
        _o.Message.Value = this.Message<sdp.LoadedSourceEvent>().HasValue ? this.Message<sdp.LoadedSourceEvent>().Value.UnPack() : null;
        break;
      case sdp.ToDebuggerMessageType.DebugStartResponse:
        _o.Message.Value = this.Message<sdp.DebugStartResponse>().HasValue ? this.Message<sdp.DebugStartResponse>().Value.UnPack() : null;
        break;
      case sdp.ToDebuggerMessageType.SetBreakpointsResponse:
        _o.Message.Value = this.Message<sdp.SetBreakpointsResponse>().HasValue ? this.Message<sdp.SetBreakpointsResponse>().Value.UnPack() : null;
        break;
      case sdp.ToDebuggerMessageType.StackTraceResponse:
        _o.Message.Value = this.Message<sdp.StackTraceResponse>().HasValue ? this.Message<sdp.StackTraceResponse>().Value.UnPack() : null;
        break;
      case sdp.ToDebuggerMessageType.DebugActionResponse:
        _o.Message.Value = this.Message<sdp.DebugActionResponse>().HasValue ? this.Message<sdp.DebugActionResponse>().Value.UnPack() : null;
        break;
      case sdp.ToDebuggerMessageType.LocalVariablesResponse:
        _o.Message.Value = this.Message<sdp.LocalVariablesResponse>().HasValue ? this.Message<sdp.LocalVariablesResponse>().Value.UnPack() : null;
        break;
      case sdp.ToDebuggerMessageType.GlobalVariablesResponse:
        _o.Message.Value = this.Message<sdp.GlobalVariablesResponse>().HasValue ? this.Message<sdp.GlobalVariablesResponse>().Value.UnPack() : null;
        break;
    }
  }
  public static Offset<sdp.ToDebuggerMessage> Pack(FlatBufferBuilder builder, ToDebuggerMessageT _o) {
    if (_o == null) return default(Offset<sdp.ToDebuggerMessage>);
    var _message_type = _o.Message == null ? sdp.ToDebuggerMessageType.NONE : _o.Message.Type;
    var _message = _o.Message == null ? 0 : sdp.ToDebuggerMessageTypeUnion.Pack(builder, _o.Message);
    return CreateToDebuggerMessage(
      builder,
      _message_type,
      _message);
  }
};

public class ToDebuggerMessageT
{
  [Newtonsoft.Json.JsonProperty("message_type")]
  private sdp.ToDebuggerMessageType MessageType {
    get {
      return this.Message != null ? this.Message.Type : sdp.ToDebuggerMessageType.NONE;
    }
    set {
      this.Message = new sdp.ToDebuggerMessageTypeUnion();
      this.Message.Type = value;
    }
  }
  [Newtonsoft.Json.JsonProperty("message")]
  [Newtonsoft.Json.JsonConverter(typeof(sdp.ToDebuggerMessageTypeUnion_JsonConverter))]
  public sdp.ToDebuggerMessageTypeUnion Message { get; set; }

  public ToDebuggerMessageT() {
    this.Message = null;
  }

  public static ToDebuggerMessageT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<ToDebuggerMessageT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static ToDebuggerMessageT DeserializeFromBinary(byte[] fbBuffer) {
    return ToDebuggerMessage.GetRootAsToDebuggerMessage(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    ToDebuggerMessage.FinishToDebuggerMessageBuffer(fbb, ToDebuggerMessage.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}