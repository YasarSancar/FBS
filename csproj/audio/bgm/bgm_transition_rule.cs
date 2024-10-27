// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.audio.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum AudioCurveType : int
{
  Log3 = 0,
  Sine = 1,
  Log1 = 2,
  InvSCurve = 3,
  Linear = 4,
  SCurve = 5,
  Exp1 = 6,
  SineRecip = 7,
  Exp3 = 8,
};

public struct BGMTransition : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static BGMTransition GetRootAsBGMTransition(ByteBuffer _bb) { return GetRootAsBGMTransition(_bb, new BGMTransition()); }
  public static BGMTransition GetRootAsBGMTransition(ByteBuffer _bb, BGMTransition obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BGMTransition __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float FadeInTime { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float FadeOutTime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DelayTime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float HoldTime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public gfl.audio.fb.AudioCurveType FadeInCurve { get { int o = __p.__offset(12); return o != 0 ? (gfl.audio.fb.AudioCurveType)__p.bb.GetInt(o + __p.bb_pos) : gfl.audio.fb.AudioCurveType.Linear; } }
  public gfl.audio.fb.AudioCurveType FadeOutCurve { get { int o = __p.__offset(14); return o != 0 ? (gfl.audio.fb.AudioCurveType)__p.bb.GetInt(o + __p.bb_pos) : gfl.audio.fb.AudioCurveType.Linear; } }

  public static Offset<gfl.audio.fb.BGMTransition> CreateBGMTransition(FlatBufferBuilder builder,
      float fadeInTime = 0.0f,
      float fadeOutTime = 0.0f,
      float delayTime = 0.0f,
      float holdTime = 0.0f,
      gfl.audio.fb.AudioCurveType fadeInCurve = gfl.audio.fb.AudioCurveType.Linear,
      gfl.audio.fb.AudioCurveType fadeOutCurve = gfl.audio.fb.AudioCurveType.Linear) {
    builder.StartTable(6);
    BGMTransition.AddFadeOutCurve(builder, fadeOutCurve);
    BGMTransition.AddFadeInCurve(builder, fadeInCurve);
    BGMTransition.AddHoldTime(builder, holdTime);
    BGMTransition.AddDelayTime(builder, delayTime);
    BGMTransition.AddFadeOutTime(builder, fadeOutTime);
    BGMTransition.AddFadeInTime(builder, fadeInTime);
    return BGMTransition.EndBGMTransition(builder);
  }

  public static void StartBGMTransition(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime) { builder.AddFloat(0, fadeInTime, 0.0f); }
  public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime) { builder.AddFloat(1, fadeOutTime, 0.0f); }
  public static void AddDelayTime(FlatBufferBuilder builder, float delayTime) { builder.AddFloat(2, delayTime, 0.0f); }
  public static void AddHoldTime(FlatBufferBuilder builder, float holdTime) { builder.AddFloat(3, holdTime, 0.0f); }
  public static void AddFadeInCurve(FlatBufferBuilder builder, gfl.audio.fb.AudioCurveType fadeInCurve) { builder.AddInt(4, (int)fadeInCurve, 4); }
  public static void AddFadeOutCurve(FlatBufferBuilder builder, gfl.audio.fb.AudioCurveType fadeOutCurve) { builder.AddInt(5, (int)fadeOutCurve, 4); }
  public static Offset<gfl.audio.fb.BGMTransition> EndBGMTransition(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.audio.fb.BGMTransition>(o);
  }
  public BGMTransitionT UnPack() {
    var _o = new BGMTransitionT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BGMTransitionT _o) {
    _o.FadeInTime = this.FadeInTime;
    _o.FadeOutTime = this.FadeOutTime;
    _o.DelayTime = this.DelayTime;
    _o.HoldTime = this.HoldTime;
    _o.FadeInCurve = this.FadeInCurve;
    _o.FadeOutCurve = this.FadeOutCurve;
  }
  public static Offset<gfl.audio.fb.BGMTransition> Pack(FlatBufferBuilder builder, BGMTransitionT _o) {
    if (_o == null) return default(Offset<gfl.audio.fb.BGMTransition>);
    return CreateBGMTransition(
      builder,
      _o.FadeInTime,
      _o.FadeOutTime,
      _o.DelayTime,
      _o.HoldTime,
      _o.FadeInCurve,
      _o.FadeOutCurve);
  }
};

public class BGMTransitionT
{
  [Newtonsoft.Json.JsonProperty("fadeInTime")]
  public float FadeInTime { get; set; }
  [Newtonsoft.Json.JsonProperty("fadeOutTime")]
  public float FadeOutTime { get; set; }
  [Newtonsoft.Json.JsonProperty("delayTime")]
  public float DelayTime { get; set; }
  [Newtonsoft.Json.JsonProperty("holdTime")]
  public float HoldTime { get; set; }
  [Newtonsoft.Json.JsonProperty("fadeInCurve")]
  public gfl.audio.fb.AudioCurveType FadeInCurve { get; set; }
  [Newtonsoft.Json.JsonProperty("fadeOutCurve")]
  public gfl.audio.fb.AudioCurveType FadeOutCurve { get; set; }

  public BGMTransitionT() {
    this.FadeInTime = 0.0f;
    this.FadeOutTime = 0.0f;
    this.DelayTime = 0.0f;
    this.HoldTime = 0.0f;
    this.FadeInCurve = gfl.audio.fb.AudioCurveType.Linear;
    this.FadeOutCurve = gfl.audio.fb.AudioCurveType.Linear;
  }
}

public struct BGMLayerTransitionRule : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static BGMLayerTransitionRule GetRootAsBGMLayerTransitionRule(ByteBuffer _bb) { return GetRootAsBGMLayerTransitionRule(_bb, new BGMLayerTransitionRule()); }
  public static BGMLayerTransitionRule GetRootAsBGMLayerTransitionRule(ByteBuffer _bb, BGMLayerTransitionRule obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BGMLayerTransitionRule __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string LayerName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLayerNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetLayerNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetLayerNameArray() { return __p.__vector_as_array<byte>(4); }
  public gfl.audio.fb.BGMTransition? Transition { get { int o = __p.__offset(6); return o != 0 ? (gfl.audio.fb.BGMTransition?)(new gfl.audio.fb.BGMTransition()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<gfl.audio.fb.BGMLayerTransitionRule> CreateBGMLayerTransitionRule(FlatBufferBuilder builder,
      StringOffset layerNameOffset = default(StringOffset),
      Offset<gfl.audio.fb.BGMTransition> transitionOffset = default(Offset<gfl.audio.fb.BGMTransition>)) {
    builder.StartTable(2);
    BGMLayerTransitionRule.AddTransition(builder, transitionOffset);
    BGMLayerTransitionRule.AddLayerName(builder, layerNameOffset);
    return BGMLayerTransitionRule.EndBGMLayerTransitionRule(builder);
  }

  public static void StartBGMLayerTransitionRule(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddLayerName(FlatBufferBuilder builder, StringOffset layerNameOffset) { builder.AddOffset(0, layerNameOffset.Value, 0); }
  public static void AddTransition(FlatBufferBuilder builder, Offset<gfl.audio.fb.BGMTransition> transitionOffset) { builder.AddOffset(1, transitionOffset.Value, 0); }
  public static Offset<gfl.audio.fb.BGMLayerTransitionRule> EndBGMLayerTransitionRule(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.audio.fb.BGMLayerTransitionRule>(o);
  }
  public BGMLayerTransitionRuleT UnPack() {
    var _o = new BGMLayerTransitionRuleT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BGMLayerTransitionRuleT _o) {
    _o.LayerName = this.LayerName;
    _o.Transition = this.Transition.HasValue ? this.Transition.Value.UnPack() : null;
  }
  public static Offset<gfl.audio.fb.BGMLayerTransitionRule> Pack(FlatBufferBuilder builder, BGMLayerTransitionRuleT _o) {
    if (_o == null) return default(Offset<gfl.audio.fb.BGMLayerTransitionRule>);
    var _layerName = _o.LayerName == null ? default(StringOffset) : builder.CreateString(_o.LayerName);
    var _transition = _o.Transition == null ? default(Offset<gfl.audio.fb.BGMTransition>) : gfl.audio.fb.BGMTransition.Pack(builder, _o.Transition);
    return CreateBGMLayerTransitionRule(
      builder,
      _layerName,
      _transition);
  }
};

public class BGMLayerTransitionRuleT
{
  [Newtonsoft.Json.JsonProperty("layerName")]
  public string LayerName { get; set; }
  [Newtonsoft.Json.JsonProperty("transition")]
  public gfl.audio.fb.BGMTransitionT Transition { get; set; }

  public BGMLayerTransitionRuleT() {
    this.LayerName = null;
    this.Transition = null;
  }
}

public struct BGMTransitionRules : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static BGMTransitionRules GetRootAsBGMTransitionRules(ByteBuffer _bb) { return GetRootAsBGMTransitionRules(_bb, new BGMTransitionRules()); }
  public static BGMTransitionRules GetRootAsBGMTransitionRules(ByteBuffer _bb, BGMTransitionRules obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BGMTransitionRules __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.audio.fb.BGMLayerTransitionRule? RulesArray(int j) { int o = __p.__offset(4); return o != 0 ? (gfl.audio.fb.BGMLayerTransitionRule?)(new gfl.audio.fb.BGMLayerTransitionRule()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int RulesArrayLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<gfl.audio.fb.BGMTransitionRules> CreateBGMTransitionRules(FlatBufferBuilder builder,
      VectorOffset rulesArrayOffset = default(VectorOffset)) {
    builder.StartTable(1);
    BGMTransitionRules.AddRulesArray(builder, rulesArrayOffset);
    return BGMTransitionRules.EndBGMTransitionRules(builder);
  }

  public static void StartBGMTransitionRules(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddRulesArray(FlatBufferBuilder builder, VectorOffset rulesArrayOffset) { builder.AddOffset(0, rulesArrayOffset.Value, 0); }
  public static VectorOffset CreateRulesArrayVector(FlatBufferBuilder builder, Offset<gfl.audio.fb.BGMLayerTransitionRule>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRulesArrayVectorBlock(FlatBufferBuilder builder, Offset<gfl.audio.fb.BGMLayerTransitionRule>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartRulesArrayVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<gfl.audio.fb.BGMTransitionRules> EndBGMTransitionRules(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.audio.fb.BGMTransitionRules>(o);
  }
  public static void FinishBGMTransitionRulesBuffer(FlatBufferBuilder builder, Offset<gfl.audio.fb.BGMTransitionRules> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedBGMTransitionRulesBuffer(FlatBufferBuilder builder, Offset<gfl.audio.fb.BGMTransitionRules> offset) { builder.FinishSizePrefixed(offset.Value); }
  public BGMTransitionRulesT UnPack() {
    var _o = new BGMTransitionRulesT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BGMTransitionRulesT _o) {
    _o.RulesArray = new List<gfl.audio.fb.BGMLayerTransitionRuleT>();
    for (var _j = 0; _j < this.RulesArrayLength; ++_j) {_o.RulesArray.Add(this.RulesArray(_j).HasValue ? this.RulesArray(_j).Value.UnPack() : null);}
  }
  public static Offset<gfl.audio.fb.BGMTransitionRules> Pack(FlatBufferBuilder builder, BGMTransitionRulesT _o) {
    if (_o == null) return default(Offset<gfl.audio.fb.BGMTransitionRules>);
    var _rulesArray = default(VectorOffset);
    if (_o.RulesArray != null) {
      var __rulesArray = new Offset<gfl.audio.fb.BGMLayerTransitionRule>[_o.RulesArray.Count];
      for (var _j = 0; _j < __rulesArray.Length; ++_j) { __rulesArray[_j] = gfl.audio.fb.BGMLayerTransitionRule.Pack(builder, _o.RulesArray[_j]); }
      _rulesArray = CreateRulesArrayVector(builder, __rulesArray);
    }
    return CreateBGMTransitionRules(
      builder,
      _rulesArray);
  }
};

public class BGMTransitionRulesT
{
  [Newtonsoft.Json.JsonProperty("rulesArray")]
  public List<gfl.audio.fb.BGMLayerTransitionRuleT> RulesArray { get; set; }

  public BGMTransitionRulesT() {
    this.RulesArray = null;
  }

  public static BGMTransitionRulesT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<BGMTransitionRulesT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static BGMTransitionRulesT DeserializeFromBinary(byte[] fbBuffer) {
    return BGMTransitionRules.GetRootAsBGMTransitionRules(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    BGMTransitionRules.FinishBGMTransitionRulesBuffer(fbb, BGMTransitionRules.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}