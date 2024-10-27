// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.protocol.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum LogLevel : sbyte
{
  Debug = 0,
  Info = 1,
  Warning = 2,
  Error = 3,
  Fatal = 4,
};

public struct LogMessage : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static LogMessage GetRootAsLogMessage(ByteBuffer _bb) { return GetRootAsLogMessage(_bb, new LogMessage()); }
  public static LogMessage GetRootAsLogMessage(ByteBuffer _bb, LogMessage obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LogMessage __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.protocol.scene.fb.LogLevel Level { get { int o = __p.__offset(4); return o != 0 ? (gfl.protocol.scene.fb.LogLevel)__p.bb.GetSbyte(o + __p.bb_pos) : gfl.protocol.scene.fb.LogLevel.Debug; } }
  public string Key { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKeyBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetKeyBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetKeyArray() { return __p.__vector_as_array<byte>(6); }
  public string Message { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMessageBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetMessageBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetMessageArray() { return __p.__vector_as_array<byte>(8); }
  public string Filename { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFilenameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetFilenameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetFilenameArray() { return __p.__vector_as_array<byte>(10); }
  public int Line { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<gfl.protocol.scene.fb.LogMessage> CreateLogMessage(FlatBufferBuilder builder,
      gfl.protocol.scene.fb.LogLevel level = gfl.protocol.scene.fb.LogLevel.Debug,
      StringOffset keyOffset = default(StringOffset),
      StringOffset messageOffset = default(StringOffset),
      StringOffset filenameOffset = default(StringOffset),
      int line = 0) {
    builder.StartTable(5);
    LogMessage.AddLine(builder, line);
    LogMessage.AddFilename(builder, filenameOffset);
    LogMessage.AddMessage(builder, messageOffset);
    LogMessage.AddKey(builder, keyOffset);
    LogMessage.AddLevel(builder, level);
    return LogMessage.EndLogMessage(builder);
  }

  public static void StartLogMessage(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddLevel(FlatBufferBuilder builder, gfl.protocol.scene.fb.LogLevel level) { builder.AddSbyte(0, (sbyte)level, 0); }
  public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset) { builder.AddOffset(1, keyOffset.Value, 0); }
  public static void AddMessage(FlatBufferBuilder builder, StringOffset messageOffset) { builder.AddOffset(2, messageOffset.Value, 0); }
  public static void AddFilename(FlatBufferBuilder builder, StringOffset filenameOffset) { builder.AddOffset(3, filenameOffset.Value, 0); }
  public static void AddLine(FlatBufferBuilder builder, int line) { builder.AddInt(4, line, 0); }
  public static Offset<gfl.protocol.scene.fb.LogMessage> EndLogMessage(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.protocol.scene.fb.LogMessage>(o);
  }
  public static void FinishLogMessageBuffer(FlatBufferBuilder builder, Offset<gfl.protocol.scene.fb.LogMessage> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedLogMessageBuffer(FlatBufferBuilder builder, Offset<gfl.protocol.scene.fb.LogMessage> offset) { builder.FinishSizePrefixed(offset.Value); }
  public LogMessageT UnPack() {
    var _o = new LogMessageT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LogMessageT _o) {
    _o.Level = this.Level;
    _o.Key = this.Key;
    _o.Message = this.Message;
    _o.Filename = this.Filename;
    _o.Line = this.Line;
  }
  public static Offset<gfl.protocol.scene.fb.LogMessage> Pack(FlatBufferBuilder builder, LogMessageT _o) {
    if (_o == null) return default(Offset<gfl.protocol.scene.fb.LogMessage>);
    var _key = _o.Key == null ? default(StringOffset) : builder.CreateString(_o.Key);
    var _message = _o.Message == null ? default(StringOffset) : builder.CreateString(_o.Message);
    var _filename = _o.Filename == null ? default(StringOffset) : builder.CreateString(_o.Filename);
    return CreateLogMessage(
      builder,
      _o.Level,
      _key,
      _message,
      _filename,
      _o.Line);
  }
};

public class LogMessageT
{
  [Newtonsoft.Json.JsonProperty("level")]
  public gfl.protocol.scene.fb.LogLevel Level { get; set; }
  [Newtonsoft.Json.JsonProperty("key")]
  public string Key { get; set; }
  [Newtonsoft.Json.JsonProperty("message")]
  public string Message { get; set; }
  [Newtonsoft.Json.JsonProperty("filename")]
  public string Filename { get; set; }
  [Newtonsoft.Json.JsonProperty("line")]
  public int Line { get; set; }

  public LogMessageT() {
    this.Level = gfl.protocol.scene.fb.LogLevel.Debug;
    this.Key = null;
    this.Message = null;
    this.Filename = null;
    this.Line = 0;
  }

  public static LogMessageT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<LogMessageT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static LogMessageT DeserializeFromBinary(byte[] fbBuffer) {
    return LogMessage.GetRootAsLogMessage(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    LogMessage.FinishLogMessageBuffer(fbb, LogMessage.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}