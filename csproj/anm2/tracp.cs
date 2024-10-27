// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.anm2.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum ParameterType : uint
{
  Int = 0,
  Float = 1,
  Bool = 2,
  Trigger = 3,
};

public struct IntParameter : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static IntParameter GetRootAsIntParameter(ByteBuffer _bb) { return GetRootAsIntParameter(_bb, new IntParameter()); }
  public static IntParameter GetRootAsIntParameter(ByteBuffer _bb, IntParameter obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public IntParameter __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public int MinValue { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MaxValue { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DefaultValue { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool Trigger { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<gfl.anm2.fb.IntParameter> CreateIntParameter(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      int minValue = 0,
      int maxValue = 0,
      int defaultValue = 0,
      bool trigger = false) {
    builder.StartTable(5);
    IntParameter.AddDefaultValue(builder, defaultValue);
    IntParameter.AddMaxValue(builder, maxValue);
    IntParameter.AddMinValue(builder, minValue);
    IntParameter.AddName(builder, nameOffset);
    IntParameter.AddTrigger(builder, trigger);
    return IntParameter.EndIntParameter(builder);
  }

  public static void StartIntParameter(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddMinValue(FlatBufferBuilder builder, int minValue) { builder.AddInt(1, minValue, 0); }
  public static void AddMaxValue(FlatBufferBuilder builder, int maxValue) { builder.AddInt(2, maxValue, 0); }
  public static void AddDefaultValue(FlatBufferBuilder builder, int defaultValue) { builder.AddInt(3, defaultValue, 0); }
  public static void AddTrigger(FlatBufferBuilder builder, bool trigger) { builder.AddBool(4, trigger, false); }
  public static Offset<gfl.anm2.fb.IntParameter> EndIntParameter(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.IntParameter>(o);
  }
  public IntParameterT UnPack() {
    var _o = new IntParameterT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(IntParameterT _o) {
    _o.Name = this.Name;
    _o.MinValue = this.MinValue;
    _o.MaxValue = this.MaxValue;
    _o.DefaultValue = this.DefaultValue;
    _o.Trigger = this.Trigger;
  }
  public static Offset<gfl.anm2.fb.IntParameter> Pack(FlatBufferBuilder builder, IntParameterT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.IntParameter>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    return CreateIntParameter(
      builder,
      _name,
      _o.MinValue,
      _o.MaxValue,
      _o.DefaultValue,
      _o.Trigger);
  }
};

public class IntParameterT
{
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("minValue")]
  public int MinValue { get; set; }
  [Newtonsoft.Json.JsonProperty("maxValue")]
  public int MaxValue { get; set; }
  [Newtonsoft.Json.JsonProperty("defaultValue")]
  public int DefaultValue { get; set; }
  [Newtonsoft.Json.JsonProperty("trigger")]
  public bool Trigger { get; set; }

  public IntParameterT() {
    this.Name = null;
    this.MinValue = 0;
    this.MaxValue = 0;
    this.DefaultValue = 0;
    this.Trigger = false;
  }
}

public struct FloatParameter : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static FloatParameter GetRootAsFloatParameter(ByteBuffer _bb) { return GetRootAsFloatParameter(_bb, new FloatParameter()); }
  public static FloatParameter GetRootAsFloatParameter(ByteBuffer _bb, FloatParameter obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FloatParameter __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public float MinValue { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float MaxValue { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DefaultValue { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<gfl.anm2.fb.FloatParameter> CreateFloatParameter(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      float minValue = 0.0f,
      float maxValue = 0.0f,
      float defaultValue = 0.0f) {
    builder.StartTable(4);
    FloatParameter.AddDefaultValue(builder, defaultValue);
    FloatParameter.AddMaxValue(builder, maxValue);
    FloatParameter.AddMinValue(builder, minValue);
    FloatParameter.AddName(builder, nameOffset);
    return FloatParameter.EndFloatParameter(builder);
  }

  public static void StartFloatParameter(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddMinValue(FlatBufferBuilder builder, float minValue) { builder.AddFloat(1, minValue, 0.0f); }
  public static void AddMaxValue(FlatBufferBuilder builder, float maxValue) { builder.AddFloat(2, maxValue, 0.0f); }
  public static void AddDefaultValue(FlatBufferBuilder builder, float defaultValue) { builder.AddFloat(3, defaultValue, 0.0f); }
  public static Offset<gfl.anm2.fb.FloatParameter> EndFloatParameter(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.FloatParameter>(o);
  }
  public FloatParameterT UnPack() {
    var _o = new FloatParameterT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FloatParameterT _o) {
    _o.Name = this.Name;
    _o.MinValue = this.MinValue;
    _o.MaxValue = this.MaxValue;
    _o.DefaultValue = this.DefaultValue;
  }
  public static Offset<gfl.anm2.fb.FloatParameter> Pack(FlatBufferBuilder builder, FloatParameterT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.FloatParameter>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    return CreateFloatParameter(
      builder,
      _name,
      _o.MinValue,
      _o.MaxValue,
      _o.DefaultValue);
  }
};

public class FloatParameterT
{
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("minValue")]
  public float MinValue { get; set; }
  [Newtonsoft.Json.JsonProperty("maxValue")]
  public float MaxValue { get; set; }
  [Newtonsoft.Json.JsonProperty("defaultValue")]
  public float DefaultValue { get; set; }

  public FloatParameterT() {
    this.Name = null;
    this.MinValue = 0.0f;
    this.MaxValue = 0.0f;
    this.DefaultValue = 0.0f;
  }
}

public struct BoolParameter : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static BoolParameter GetRootAsBoolParameter(ByteBuffer _bb) { return GetRootAsBoolParameter(_bb, new BoolParameter()); }
  public static BoolParameter GetRootAsBoolParameter(ByteBuffer _bb, BoolParameter obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BoolParameter __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public bool DefaultValue { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Trigger { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<gfl.anm2.fb.BoolParameter> CreateBoolParameter(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      bool defaultValue = false,
      bool trigger = false) {
    builder.StartTable(3);
    BoolParameter.AddName(builder, nameOffset);
    BoolParameter.AddTrigger(builder, trigger);
    BoolParameter.AddDefaultValue(builder, defaultValue);
    return BoolParameter.EndBoolParameter(builder);
  }

  public static void StartBoolParameter(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddDefaultValue(FlatBufferBuilder builder, bool defaultValue) { builder.AddBool(1, defaultValue, false); }
  public static void AddTrigger(FlatBufferBuilder builder, bool trigger) { builder.AddBool(2, trigger, false); }
  public static Offset<gfl.anm2.fb.BoolParameter> EndBoolParameter(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.BoolParameter>(o);
  }
  public BoolParameterT UnPack() {
    var _o = new BoolParameterT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BoolParameterT _o) {
    _o.Name = this.Name;
    _o.DefaultValue = this.DefaultValue;
    _o.Trigger = this.Trigger;
  }
  public static Offset<gfl.anm2.fb.BoolParameter> Pack(FlatBufferBuilder builder, BoolParameterT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.BoolParameter>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    return CreateBoolParameter(
      builder,
      _name,
      _o.DefaultValue,
      _o.Trigger);
  }
};

public class BoolParameterT
{
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("defaultValue")]
  public bool DefaultValue { get; set; }
  [Newtonsoft.Json.JsonProperty("trigger")]
  public bool Trigger { get; set; }

  public BoolParameterT() {
    this.Name = null;
    this.DefaultValue = false;
    this.Trigger = false;
  }
}

public struct TriggerParameter : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static TriggerParameter GetRootAsTriggerParameter(ByteBuffer _bb) { return GetRootAsTriggerParameter(_bb, new TriggerParameter()); }
  public static TriggerParameter GetRootAsTriggerParameter(ByteBuffer _bb, TriggerParameter obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TriggerParameter __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<gfl.anm2.fb.TriggerParameter> CreateTriggerParameter(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset)) {
    builder.StartTable(1);
    TriggerParameter.AddName(builder, nameOffset);
    return TriggerParameter.EndTriggerParameter(builder);
  }

  public static void StartTriggerParameter(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static Offset<gfl.anm2.fb.TriggerParameter> EndTriggerParameter(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.TriggerParameter>(o);
  }
  public TriggerParameterT UnPack() {
    var _o = new TriggerParameterT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TriggerParameterT _o) {
    _o.Name = this.Name;
  }
  public static Offset<gfl.anm2.fb.TriggerParameter> Pack(FlatBufferBuilder builder, TriggerParameterT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.TriggerParameter>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    return CreateTriggerParameter(
      builder,
      _name);
  }
};

public class TriggerParameterT
{
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }

  public TriggerParameterT() {
    this.Name = null;
  }
}

public struct SortInfoItem : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static SortInfoItem GetRootAsSortInfoItem(ByteBuffer _bb) { return GetRootAsSortInfoItem(_bb, new SortInfoItem()); }
  public static SortInfoItem GetRootAsSortInfoItem(ByteBuffer _bb, SortInfoItem obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SortInfoItem __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.anm2.fb.ParameterType ParameterType { get { int o = __p.__offset(4); return o != 0 ? (gfl.anm2.fb.ParameterType)__p.bb.GetUint(o + __p.bb_pos) : gfl.anm2.fb.ParameterType.Int; } }
  public int Index { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<gfl.anm2.fb.SortInfoItem> CreateSortInfoItem(FlatBufferBuilder builder,
      gfl.anm2.fb.ParameterType parameterType = gfl.anm2.fb.ParameterType.Int,
      int index = 0) {
    builder.StartTable(2);
    SortInfoItem.AddIndex(builder, index);
    SortInfoItem.AddParameterType(builder, parameterType);
    return SortInfoItem.EndSortInfoItem(builder);
  }

  public static void StartSortInfoItem(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddParameterType(FlatBufferBuilder builder, gfl.anm2.fb.ParameterType parameterType) { builder.AddUint(0, (uint)parameterType, 0); }
  public static void AddIndex(FlatBufferBuilder builder, int index) { builder.AddInt(1, index, 0); }
  public static Offset<gfl.anm2.fb.SortInfoItem> EndSortInfoItem(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.SortInfoItem>(o);
  }
  public SortInfoItemT UnPack() {
    var _o = new SortInfoItemT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SortInfoItemT _o) {
    _o.ParameterType = this.ParameterType;
    _o.Index = this.Index;
  }
  public static Offset<gfl.anm2.fb.SortInfoItem> Pack(FlatBufferBuilder builder, SortInfoItemT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.SortInfoItem>);
    return CreateSortInfoItem(
      builder,
      _o.ParameterType,
      _o.Index);
  }
};

public class SortInfoItemT
{
  [Newtonsoft.Json.JsonProperty("parameterType")]
  public gfl.anm2.fb.ParameterType ParameterType { get; set; }
  [Newtonsoft.Json.JsonProperty("index")]
  public int Index { get; set; }

  public SortInfoItemT() {
    this.ParameterType = gfl.anm2.fb.ParameterType.Int;
    this.Index = 0;
  }
}

public struct ParameterConfig : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ParameterConfig GetRootAsParameterConfig(ByteBuffer _bb) { return GetRootAsParameterConfig(_bb, new ParameterConfig()); }
  public static ParameterConfig GetRootAsParameterConfig(ByteBuffer _bb, ParameterConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ParameterConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.anm2.fb.IntParameter? IntParameters(int j) { int o = __p.__offset(4); return o != 0 ? (gfl.anm2.fb.IntParameter?)(new gfl.anm2.fb.IntParameter()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int IntParametersLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public gfl.anm2.fb.FloatParameter? FloatParameters(int j) { int o = __p.__offset(6); return o != 0 ? (gfl.anm2.fb.FloatParameter?)(new gfl.anm2.fb.FloatParameter()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int FloatParametersLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public gfl.anm2.fb.BoolParameter? BoolParameters(int j) { int o = __p.__offset(8); return o != 0 ? (gfl.anm2.fb.BoolParameter?)(new gfl.anm2.fb.BoolParameter()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int BoolParametersLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  public gfl.anm2.fb.TriggerParameter? TriggerParameters(int j) { int o = __p.__offset(10); return o != 0 ? (gfl.anm2.fb.TriggerParameter?)(new gfl.anm2.fb.TriggerParameter()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int TriggerParametersLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public gfl.anm2.fb.SortInfoItem? SortInfo(int j) { int o = __p.__offset(12); return o != 0 ? (gfl.anm2.fb.SortInfoItem?)(new gfl.anm2.fb.SortInfoItem()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int SortInfoLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<gfl.anm2.fb.ParameterConfig> CreateParameterConfig(FlatBufferBuilder builder,
      VectorOffset intParametersOffset = default(VectorOffset),
      VectorOffset floatParametersOffset = default(VectorOffset),
      VectorOffset boolParametersOffset = default(VectorOffset),
      VectorOffset triggerParametersOffset = default(VectorOffset),
      VectorOffset sortInfoOffset = default(VectorOffset)) {
    builder.StartTable(5);
    ParameterConfig.AddSortInfo(builder, sortInfoOffset);
    ParameterConfig.AddTriggerParameters(builder, triggerParametersOffset);
    ParameterConfig.AddBoolParameters(builder, boolParametersOffset);
    ParameterConfig.AddFloatParameters(builder, floatParametersOffset);
    ParameterConfig.AddIntParameters(builder, intParametersOffset);
    return ParameterConfig.EndParameterConfig(builder);
  }

  public static void StartParameterConfig(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddIntParameters(FlatBufferBuilder builder, VectorOffset intParametersOffset) { builder.AddOffset(0, intParametersOffset.Value, 0); }
  public static VectorOffset CreateIntParametersVector(FlatBufferBuilder builder, Offset<gfl.anm2.fb.IntParameter>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateIntParametersVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fb.IntParameter>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartIntParametersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFloatParameters(FlatBufferBuilder builder, VectorOffset floatParametersOffset) { builder.AddOffset(1, floatParametersOffset.Value, 0); }
  public static VectorOffset CreateFloatParametersVector(FlatBufferBuilder builder, Offset<gfl.anm2.fb.FloatParameter>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateFloatParametersVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fb.FloatParameter>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartFloatParametersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBoolParameters(FlatBufferBuilder builder, VectorOffset boolParametersOffset) { builder.AddOffset(2, boolParametersOffset.Value, 0); }
  public static VectorOffset CreateBoolParametersVector(FlatBufferBuilder builder, Offset<gfl.anm2.fb.BoolParameter>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateBoolParametersVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fb.BoolParameter>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartBoolParametersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTriggerParameters(FlatBufferBuilder builder, VectorOffset triggerParametersOffset) { builder.AddOffset(3, triggerParametersOffset.Value, 0); }
  public static VectorOffset CreateTriggerParametersVector(FlatBufferBuilder builder, Offset<gfl.anm2.fb.TriggerParameter>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateTriggerParametersVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fb.TriggerParameter>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartTriggerParametersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSortInfo(FlatBufferBuilder builder, VectorOffset sortInfoOffset) { builder.AddOffset(4, sortInfoOffset.Value, 0); }
  public static VectorOffset CreateSortInfoVector(FlatBufferBuilder builder, Offset<gfl.anm2.fb.SortInfoItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateSortInfoVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fb.SortInfoItem>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartSortInfoVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<gfl.anm2.fb.ParameterConfig> EndParameterConfig(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.ParameterConfig>(o);
  }
  public ParameterConfigT UnPack() {
    var _o = new ParameterConfigT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ParameterConfigT _o) {
    _o.IntParameters = new List<gfl.anm2.fb.IntParameterT>();
    for (var _j = 0; _j < this.IntParametersLength; ++_j) {_o.IntParameters.Add(this.IntParameters(_j).HasValue ? this.IntParameters(_j).Value.UnPack() : null);}
    _o.FloatParameters = new List<gfl.anm2.fb.FloatParameterT>();
    for (var _j = 0; _j < this.FloatParametersLength; ++_j) {_o.FloatParameters.Add(this.FloatParameters(_j).HasValue ? this.FloatParameters(_j).Value.UnPack() : null);}
    _o.BoolParameters = new List<gfl.anm2.fb.BoolParameterT>();
    for (var _j = 0; _j < this.BoolParametersLength; ++_j) {_o.BoolParameters.Add(this.BoolParameters(_j).HasValue ? this.BoolParameters(_j).Value.UnPack() : null);}
    _o.TriggerParameters = new List<gfl.anm2.fb.TriggerParameterT>();
    for (var _j = 0; _j < this.TriggerParametersLength; ++_j) {_o.TriggerParameters.Add(this.TriggerParameters(_j).HasValue ? this.TriggerParameters(_j).Value.UnPack() : null);}
    _o.SortInfo = new List<gfl.anm2.fb.SortInfoItemT>();
    for (var _j = 0; _j < this.SortInfoLength; ++_j) {_o.SortInfo.Add(this.SortInfo(_j).HasValue ? this.SortInfo(_j).Value.UnPack() : null);}
  }
  public static Offset<gfl.anm2.fb.ParameterConfig> Pack(FlatBufferBuilder builder, ParameterConfigT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.ParameterConfig>);
    var _intParameters = default(VectorOffset);
    if (_o.IntParameters != null) {
      var __intParameters = new Offset<gfl.anm2.fb.IntParameter>[_o.IntParameters.Count];
      for (var _j = 0; _j < __intParameters.Length; ++_j) { __intParameters[_j] = gfl.anm2.fb.IntParameter.Pack(builder, _o.IntParameters[_j]); }
      _intParameters = CreateIntParametersVector(builder, __intParameters);
    }
    var _floatParameters = default(VectorOffset);
    if (_o.FloatParameters != null) {
      var __floatParameters = new Offset<gfl.anm2.fb.FloatParameter>[_o.FloatParameters.Count];
      for (var _j = 0; _j < __floatParameters.Length; ++_j) { __floatParameters[_j] = gfl.anm2.fb.FloatParameter.Pack(builder, _o.FloatParameters[_j]); }
      _floatParameters = CreateFloatParametersVector(builder, __floatParameters);
    }
    var _boolParameters = default(VectorOffset);
    if (_o.BoolParameters != null) {
      var __boolParameters = new Offset<gfl.anm2.fb.BoolParameter>[_o.BoolParameters.Count];
      for (var _j = 0; _j < __boolParameters.Length; ++_j) { __boolParameters[_j] = gfl.anm2.fb.BoolParameter.Pack(builder, _o.BoolParameters[_j]); }
      _boolParameters = CreateBoolParametersVector(builder, __boolParameters);
    }
    var _triggerParameters = default(VectorOffset);
    if (_o.TriggerParameters != null) {
      var __triggerParameters = new Offset<gfl.anm2.fb.TriggerParameter>[_o.TriggerParameters.Count];
      for (var _j = 0; _j < __triggerParameters.Length; ++_j) { __triggerParameters[_j] = gfl.anm2.fb.TriggerParameter.Pack(builder, _o.TriggerParameters[_j]); }
      _triggerParameters = CreateTriggerParametersVector(builder, __triggerParameters);
    }
    var _sortInfo = default(VectorOffset);
    if (_o.SortInfo != null) {
      var __sortInfo = new Offset<gfl.anm2.fb.SortInfoItem>[_o.SortInfo.Count];
      for (var _j = 0; _j < __sortInfo.Length; ++_j) { __sortInfo[_j] = gfl.anm2.fb.SortInfoItem.Pack(builder, _o.SortInfo[_j]); }
      _sortInfo = CreateSortInfoVector(builder, __sortInfo);
    }
    return CreateParameterConfig(
      builder,
      _intParameters,
      _floatParameters,
      _boolParameters,
      _triggerParameters,
      _sortInfo);
  }
};

public class ParameterConfigT
{
  [Newtonsoft.Json.JsonProperty("intParameters")]
  public List<gfl.anm2.fb.IntParameterT> IntParameters { get; set; }
  [Newtonsoft.Json.JsonProperty("floatParameters")]
  public List<gfl.anm2.fb.FloatParameterT> FloatParameters { get; set; }
  [Newtonsoft.Json.JsonProperty("boolParameters")]
  public List<gfl.anm2.fb.BoolParameterT> BoolParameters { get; set; }
  [Newtonsoft.Json.JsonProperty("triggerParameters")]
  public List<gfl.anm2.fb.TriggerParameterT> TriggerParameters { get; set; }
  [Newtonsoft.Json.JsonProperty("sortInfo")]
  public List<gfl.anm2.fb.SortInfoItemT> SortInfo { get; set; }

  public ParameterConfigT() {
    this.IntParameters = null;
    this.FloatParameters = null;
    this.BoolParameters = null;
    this.TriggerParameters = null;
    this.SortInfo = null;
  }
}

public struct AnimationParameterConfig : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static AnimationParameterConfig GetRootAsAnimationParameterConfig(ByteBuffer _bb) { return GetRootAsAnimationParameterConfig(_bb, new AnimationParameterConfig()); }
  public static AnimationParameterConfig GetRootAsAnimationParameterConfig(ByteBuffer _bb, AnimationParameterConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AnimationParameterConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.anm2.fb.ParameterConfig? ParameterConfig { get { int o = __p.__offset(4); return o != 0 ? (gfl.anm2.fb.ParameterConfig?)(new gfl.anm2.fb.ParameterConfig()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<gfl.anm2.fb.AnimationParameterConfig> CreateAnimationParameterConfig(FlatBufferBuilder builder,
      Offset<gfl.anm2.fb.ParameterConfig> parameterConfigOffset = default(Offset<gfl.anm2.fb.ParameterConfig>)) {
    builder.StartTable(1);
    AnimationParameterConfig.AddParameterConfig(builder, parameterConfigOffset);
    return AnimationParameterConfig.EndAnimationParameterConfig(builder);
  }

  public static void StartAnimationParameterConfig(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddParameterConfig(FlatBufferBuilder builder, Offset<gfl.anm2.fb.ParameterConfig> parameterConfigOffset) { builder.AddOffset(0, parameterConfigOffset.Value, 0); }
  public static Offset<gfl.anm2.fb.AnimationParameterConfig> EndAnimationParameterConfig(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.AnimationParameterConfig>(o);
  }
  public static void FinishAnimationParameterConfigBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fb.AnimationParameterConfig> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedAnimationParameterConfigBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fb.AnimationParameterConfig> offset) { builder.FinishSizePrefixed(offset.Value); }
  public AnimationParameterConfigT UnPack() {
    var _o = new AnimationParameterConfigT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AnimationParameterConfigT _o) {
    _o.ParameterConfig = this.ParameterConfig.HasValue ? this.ParameterConfig.Value.UnPack() : null;
  }
  public static Offset<gfl.anm2.fb.AnimationParameterConfig> Pack(FlatBufferBuilder builder, AnimationParameterConfigT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.AnimationParameterConfig>);
    var _parameterConfig = _o.ParameterConfig == null ? default(Offset<gfl.anm2.fb.ParameterConfig>) : gfl.anm2.fb.ParameterConfig.Pack(builder, _o.ParameterConfig);
    return CreateAnimationParameterConfig(
      builder,
      _parameterConfig);
  }
};

public class AnimationParameterConfigT
{
  [Newtonsoft.Json.JsonProperty("parameterConfig")]
  public gfl.anm2.fb.ParameterConfigT ParameterConfig { get; set; }

  public AnimationParameterConfigT() {
    this.ParameterConfig = null;
  }

  public static AnimationParameterConfigT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<AnimationParameterConfigT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static AnimationParameterConfigT DeserializeFromBinary(byte[] fbBuffer) {
    return AnimationParameterConfig.GetRootAsAnimationParameterConfig(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    AnimationParameterConfig.FinishAnimationParameterConfigBuffer(fbb, AnimationParameterConfig.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}