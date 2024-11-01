// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.anm2.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum TextSearchType : uint
{
  StartWith = 0,
  EndWith = 1,
  Contains = 2,
  ContainsAt = 3,
};

public struct ResourceNameRule : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ResourceNameRule GetRootAsResourceNameRule(ByteBuffer _bb) { return GetRootAsResourceNameRule(_bb, new ResourceNameRule()); }
  public static ResourceNameRule GetRootAsResourceNameRule(ByteBuffer _bb, ResourceNameRule obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ResourceNameRule __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Target { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTargetBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetTargetBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetTargetArray() { return __p.__vector_as_array<byte>(4); }
  public gfl.anm2.fb.TextSearchType Type { get { int o = __p.__offset(6); return o != 0 ? (gfl.anm2.fb.TextSearchType)__p.bb.GetUint(o + __p.bb_pos) : gfl.anm2.fb.TextSearchType.StartWith; } }
  public bool Exclude { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int TargetIndex { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<gfl.anm2.fb.ResourceNameRule> CreateResourceNameRule(FlatBufferBuilder builder,
      StringOffset targetOffset = default(StringOffset),
      gfl.anm2.fb.TextSearchType type = gfl.anm2.fb.TextSearchType.StartWith,
      bool exclude = false,
      int targetIndex = 0) {
    builder.StartTable(4);
    ResourceNameRule.AddTargetIndex(builder, targetIndex);
    ResourceNameRule.AddType(builder, type);
    ResourceNameRule.AddTarget(builder, targetOffset);
    ResourceNameRule.AddExclude(builder, exclude);
    return ResourceNameRule.EndResourceNameRule(builder);
  }

  public static void StartResourceNameRule(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddTarget(FlatBufferBuilder builder, StringOffset targetOffset) { builder.AddOffset(0, targetOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, gfl.anm2.fb.TextSearchType type) { builder.AddUint(1, (uint)type, 0); }
  public static void AddExclude(FlatBufferBuilder builder, bool exclude) { builder.AddBool(2, exclude, false); }
  public static void AddTargetIndex(FlatBufferBuilder builder, int targetIndex) { builder.AddInt(3, targetIndex, 0); }
  public static Offset<gfl.anm2.fb.ResourceNameRule> EndResourceNameRule(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.ResourceNameRule>(o);
  }
  public ResourceNameRuleT UnPack() {
    var _o = new ResourceNameRuleT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ResourceNameRuleT _o) {
    _o.Target = this.Target;
    _o.Type = this.Type;
    _o.Exclude = this.Exclude;
    _o.TargetIndex = this.TargetIndex;
  }
  public static Offset<gfl.anm2.fb.ResourceNameRule> Pack(FlatBufferBuilder builder, ResourceNameRuleT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.ResourceNameRule>);
    var _target = _o.Target == null ? default(StringOffset) : builder.CreateString(_o.Target);
    return CreateResourceNameRule(
      builder,
      _target,
      _o.Type,
      _o.Exclude,
      _o.TargetIndex);
  }
};

public class ResourceNameRuleT
{
  [Newtonsoft.Json.JsonProperty("target")]
  public string Target { get; set; }
  [Newtonsoft.Json.JsonProperty("type")]
  public gfl.anm2.fb.TextSearchType Type { get; set; }
  [Newtonsoft.Json.JsonProperty("exclude")]
  public bool Exclude { get; set; }
  [Newtonsoft.Json.JsonProperty("targetIndex")]
  public int TargetIndex { get; set; }

  public ResourceNameRuleT() {
    this.Target = null;
    this.Type = gfl.anm2.fb.TextSearchType.StartWith;
    this.Exclude = false;
    this.TargetIndex = 0;
  }
}

public struct EventTrackBakeRule : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static EventTrackBakeRule GetRootAsEventTrackBakeRule(ByteBuffer _bb) { return GetRootAsEventTrackBakeRule(_bb, new EventTrackBakeRule()); }
  public static EventTrackBakeRule GetRootAsEventTrackBakeRule(ByteBuffer _bb, EventTrackBakeRule obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventTrackBakeRule __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string TrettPath { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTrettPathBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetTrettPathBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetTrettPathArray() { return __p.__vector_as_array<byte>(4); }
  public bool Overwrite { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public gfl.anm2.fb.ResourceNameRule? Rules(int j) { int o = __p.__offset(8); return o != 0 ? (gfl.anm2.fb.ResourceNameRule?)(new gfl.anm2.fb.ResourceNameRule()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int RulesLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  public bool AndOrFlag { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<gfl.anm2.fb.EventTrackBakeRule> CreateEventTrackBakeRule(FlatBufferBuilder builder,
      StringOffset trettPathOffset = default(StringOffset),
      bool overwrite = false,
      VectorOffset rulesOffset = default(VectorOffset),
      bool andOrFlag = false) {
    builder.StartTable(4);
    EventTrackBakeRule.AddRules(builder, rulesOffset);
    EventTrackBakeRule.AddTrettPath(builder, trettPathOffset);
    EventTrackBakeRule.AddAndOrFlag(builder, andOrFlag);
    EventTrackBakeRule.AddOverwrite(builder, overwrite);
    return EventTrackBakeRule.EndEventTrackBakeRule(builder);
  }

  public static void StartEventTrackBakeRule(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddTrettPath(FlatBufferBuilder builder, StringOffset trettPathOffset) { builder.AddOffset(0, trettPathOffset.Value, 0); }
  public static void AddOverwrite(FlatBufferBuilder builder, bool overwrite) { builder.AddBool(1, overwrite, false); }
  public static void AddRules(FlatBufferBuilder builder, VectorOffset rulesOffset) { builder.AddOffset(2, rulesOffset.Value, 0); }
  public static VectorOffset CreateRulesVector(FlatBufferBuilder builder, Offset<gfl.anm2.fb.ResourceNameRule>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRulesVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fb.ResourceNameRule>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartRulesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAndOrFlag(FlatBufferBuilder builder, bool andOrFlag) { builder.AddBool(3, andOrFlag, false); }
  public static Offset<gfl.anm2.fb.EventTrackBakeRule> EndEventTrackBakeRule(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.EventTrackBakeRule>(o);
  }
  public static void FinishEventTrackBakeRuleBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fb.EventTrackBakeRule> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedEventTrackBakeRuleBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fb.EventTrackBakeRule> offset) { builder.FinishSizePrefixed(offset.Value); }
  public EventTrackBakeRuleT UnPack() {
    var _o = new EventTrackBakeRuleT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventTrackBakeRuleT _o) {
    _o.TrettPath = this.TrettPath;
    _o.Overwrite = this.Overwrite;
    _o.Rules = new List<gfl.anm2.fb.ResourceNameRuleT>();
    for (var _j = 0; _j < this.RulesLength; ++_j) {_o.Rules.Add(this.Rules(_j).HasValue ? this.Rules(_j).Value.UnPack() : null);}
    _o.AndOrFlag = this.AndOrFlag;
  }
  public static Offset<gfl.anm2.fb.EventTrackBakeRule> Pack(FlatBufferBuilder builder, EventTrackBakeRuleT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.EventTrackBakeRule>);
    var _trettPath = _o.TrettPath == null ? default(StringOffset) : builder.CreateString(_o.TrettPath);
    var _rules = default(VectorOffset);
    if (_o.Rules != null) {
      var __rules = new Offset<gfl.anm2.fb.ResourceNameRule>[_o.Rules.Count];
      for (var _j = 0; _j < __rules.Length; ++_j) { __rules[_j] = gfl.anm2.fb.ResourceNameRule.Pack(builder, _o.Rules[_j]); }
      _rules = CreateRulesVector(builder, __rules);
    }
    return CreateEventTrackBakeRule(
      builder,
      _trettPath,
      _o.Overwrite,
      _rules,
      _o.AndOrFlag);
  }
};

public class EventTrackBakeRuleT
{
  [Newtonsoft.Json.JsonProperty("trettPath")]
  public string TrettPath { get; set; }
  [Newtonsoft.Json.JsonProperty("overwrite")]
  public bool Overwrite { get; set; }
  [Newtonsoft.Json.JsonProperty("rules")]
  public List<gfl.anm2.fb.ResourceNameRuleT> Rules { get; set; }
  [Newtonsoft.Json.JsonProperty("andOrFlag")]
  public bool AndOrFlag { get; set; }

  public EventTrackBakeRuleT() {
    this.TrettPath = null;
    this.Overwrite = false;
    this.Rules = null;
    this.AndOrFlag = false;
  }

  public static EventTrackBakeRuleT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<EventTrackBakeRuleT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static EventTrackBakeRuleT DeserializeFromBinary(byte[] fbBuffer) {
    return EventTrackBakeRule.GetRootAsEventTrackBakeRule(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    EventTrackBakeRule.FinishEventTrackBakeRuleBuffer(fbb, EventTrackBakeRule.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
