// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace AiEditor
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct BootConfig : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static BootConfig GetRootAsBootConfig(ByteBuffer _bb) { return GetRootAsBootConfig(_bb, new BootConfig()); }
  public static BootConfig GetRootAsBootConfig(ByteBuffer _bb, BootConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BootConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string UserGuideURL { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUserGuideURLBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetUserGuideURLBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetUserGuideURLArray() { return __p.__vector_as_array<byte>(4); }
  public string BlackboardRootPath { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBlackboardRootPathBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetBlackboardRootPathBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetBlackboardRootPathArray() { return __p.__vector_as_array<byte>(6); }
  public string BehaviorTreeRootPath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBehaviorTreeRootPathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetBehaviorTreeRootPathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetBehaviorTreeRootPathArray() { return __p.__vector_as_array<byte>(8); }
  public string TemplateRootPath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTemplateRootPathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetTemplateRootPathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetTemplateRootPathArray() { return __p.__vector_as_array<byte>(10); }
  public bool IsBackupExit { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string UniConsPath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUniConsPathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetUniConsPathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetUniConsPathArray() { return __p.__vector_as_array<byte>(14); }
  public string UniConsPipelineFilePath { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUniConsPipelineFilePathBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetUniConsPipelineFilePathBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetUniConsPipelineFilePathArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<AiEditor.BootConfig> CreateBootConfig(FlatBufferBuilder builder,
      StringOffset UserGuideURLOffset = default(StringOffset),
      StringOffset BlackboardRootPathOffset = default(StringOffset),
      StringOffset BehaviorTreeRootPathOffset = default(StringOffset),
      StringOffset TemplateRootPathOffset = default(StringOffset),
      bool IsBackupExit = false,
      StringOffset UniConsPathOffset = default(StringOffset),
      StringOffset UniConsPipelineFilePathOffset = default(StringOffset)) {
    builder.StartTable(7);
    BootConfig.AddUniConsPipelineFilePath(builder, UniConsPipelineFilePathOffset);
    BootConfig.AddUniConsPath(builder, UniConsPathOffset);
    BootConfig.AddTemplateRootPath(builder, TemplateRootPathOffset);
    BootConfig.AddBehaviorTreeRootPath(builder, BehaviorTreeRootPathOffset);
    BootConfig.AddBlackboardRootPath(builder, BlackboardRootPathOffset);
    BootConfig.AddUserGuideURL(builder, UserGuideURLOffset);
    BootConfig.AddIsBackupExit(builder, IsBackupExit);
    return BootConfig.EndBootConfig(builder);
  }

  public static void StartBootConfig(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddUserGuideURL(FlatBufferBuilder builder, StringOffset UserGuideURLOffset) { builder.AddOffset(0, UserGuideURLOffset.Value, 0); }
  public static void AddBlackboardRootPath(FlatBufferBuilder builder, StringOffset BlackboardRootPathOffset) { builder.AddOffset(1, BlackboardRootPathOffset.Value, 0); }
  public static void AddBehaviorTreeRootPath(FlatBufferBuilder builder, StringOffset BehaviorTreeRootPathOffset) { builder.AddOffset(2, BehaviorTreeRootPathOffset.Value, 0); }
  public static void AddTemplateRootPath(FlatBufferBuilder builder, StringOffset TemplateRootPathOffset) { builder.AddOffset(3, TemplateRootPathOffset.Value, 0); }
  public static void AddIsBackupExit(FlatBufferBuilder builder, bool IsBackupExit) { builder.AddBool(4, IsBackupExit, false); }
  public static void AddUniConsPath(FlatBufferBuilder builder, StringOffset UniConsPathOffset) { builder.AddOffset(5, UniConsPathOffset.Value, 0); }
  public static void AddUniConsPipelineFilePath(FlatBufferBuilder builder, StringOffset UniConsPipelineFilePathOffset) { builder.AddOffset(6, UniConsPipelineFilePathOffset.Value, 0); }
  public static Offset<AiEditor.BootConfig> EndBootConfig(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<AiEditor.BootConfig>(o);
  }
  public static void FinishBootConfigBuffer(FlatBufferBuilder builder, Offset<AiEditor.BootConfig> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedBootConfigBuffer(FlatBufferBuilder builder, Offset<AiEditor.BootConfig> offset) { builder.FinishSizePrefixed(offset.Value); }
  public BootConfigT UnPack() {
    var _o = new BootConfigT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BootConfigT _o) {
    _o.UserGuideURL = this.UserGuideURL;
    _o.BlackboardRootPath = this.BlackboardRootPath;
    _o.BehaviorTreeRootPath = this.BehaviorTreeRootPath;
    _o.TemplateRootPath = this.TemplateRootPath;
    _o.IsBackupExit = this.IsBackupExit;
    _o.UniConsPath = this.UniConsPath;
    _o.UniConsPipelineFilePath = this.UniConsPipelineFilePath;
  }
  public static Offset<AiEditor.BootConfig> Pack(FlatBufferBuilder builder, BootConfigT _o) {
    if (_o == null) return default(Offset<AiEditor.BootConfig>);
    var _UserGuideURL = _o.UserGuideURL == null ? default(StringOffset) : builder.CreateString(_o.UserGuideURL);
    var _BlackboardRootPath = _o.BlackboardRootPath == null ? default(StringOffset) : builder.CreateString(_o.BlackboardRootPath);
    var _BehaviorTreeRootPath = _o.BehaviorTreeRootPath == null ? default(StringOffset) : builder.CreateString(_o.BehaviorTreeRootPath);
    var _TemplateRootPath = _o.TemplateRootPath == null ? default(StringOffset) : builder.CreateString(_o.TemplateRootPath);
    var _UniConsPath = _o.UniConsPath == null ? default(StringOffset) : builder.CreateString(_o.UniConsPath);
    var _UniConsPipelineFilePath = _o.UniConsPipelineFilePath == null ? default(StringOffset) : builder.CreateString(_o.UniConsPipelineFilePath);
    return CreateBootConfig(
      builder,
      _UserGuideURL,
      _BlackboardRootPath,
      _BehaviorTreeRootPath,
      _TemplateRootPath,
      _o.IsBackupExit,
      _UniConsPath,
      _UniConsPipelineFilePath);
  }
};

public class BootConfigT
{
  [Newtonsoft.Json.JsonProperty("UserGuideURL")]
  public string UserGuideURL { get; set; }
  [Newtonsoft.Json.JsonProperty("BlackboardRootPath")]
  public string BlackboardRootPath { get; set; }
  [Newtonsoft.Json.JsonProperty("BehaviorTreeRootPath")]
  public string BehaviorTreeRootPath { get; set; }
  [Newtonsoft.Json.JsonProperty("TemplateRootPath")]
  public string TemplateRootPath { get; set; }
  [Newtonsoft.Json.JsonProperty("IsBackupExit")]
  public bool IsBackupExit { get; set; }
  [Newtonsoft.Json.JsonProperty("UniConsPath")]
  public string UniConsPath { get; set; }
  [Newtonsoft.Json.JsonProperty("UniConsPipelineFilePath")]
  public string UniConsPipelineFilePath { get; set; }

  public BootConfigT() {
    this.UserGuideURL = null;
    this.BlackboardRootPath = null;
    this.BehaviorTreeRootPath = null;
    this.TemplateRootPath = null;
    this.IsBackupExit = false;
    this.UniConsPath = null;
    this.UniConsPipelineFilePath = null;
  }

  public static BootConfigT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<BootConfigT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static BootConfigT DeserializeFromBinary(byte[] fbBuffer) {
    return BootConfig.GetRootAsBootConfig(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    BootConfig.FinishBootConfigBuffer(fbb, BootConfig.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}