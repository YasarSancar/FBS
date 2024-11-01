// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.anm2.fb.trbsm
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum ScalerAxis : byte
{
  None = 0,
  X = 1,
  Y = 2,
  XY = 3,
  Z = 4,
  ZX = 5,
  YZ = 6,
  XYZ = 7,
};

public struct RatioModifier : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static RatioModifier GetRootAsRatioModifier(ByteBuffer _bb) { return GetRootAsRatioModifier(_bb, new RatioModifier()); }
  public static RatioModifier GetRootAsRatioModifier(ByteBuffer _bb, RatioModifier obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RatioModifier __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Tag { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTagBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetTagBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetTagArray() { return __p.__vector_as_array<byte>(4); }
  public string JointNames(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int JointNamesLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public float Value { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool Descendants { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<gfl.anm2.fb.trbsm.RatioModifier> CreateRatioModifier(FlatBufferBuilder builder,
      StringOffset tagOffset = default(StringOffset),
      VectorOffset jointNamesOffset = default(VectorOffset),
      float value = 0.0f,
      bool descendants = false) {
    builder.StartTable(4);
    RatioModifier.AddValue(builder, value);
    RatioModifier.AddJointNames(builder, jointNamesOffset);
    RatioModifier.AddTag(builder, tagOffset);
    RatioModifier.AddDescendants(builder, descendants);
    return RatioModifier.EndRatioModifier(builder);
  }

  public static void StartRatioModifier(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddTag(FlatBufferBuilder builder, StringOffset tagOffset) { builder.AddOffset(0, tagOffset.Value, 0); }
  public static void AddJointNames(FlatBufferBuilder builder, VectorOffset jointNamesOffset) { builder.AddOffset(1, jointNamesOffset.Value, 0); }
  public static VectorOffset CreateJointNamesVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateJointNamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartJointNamesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddValue(FlatBufferBuilder builder, float value) { builder.AddFloat(2, value, 0.0f); }
  public static void AddDescendants(FlatBufferBuilder builder, bool descendants) { builder.AddBool(3, descendants, false); }
  public static Offset<gfl.anm2.fb.trbsm.RatioModifier> EndRatioModifier(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.trbsm.RatioModifier>(o);
  }
  public RatioModifierT UnPack() {
    var _o = new RatioModifierT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RatioModifierT _o) {
    _o.Tag = this.Tag;
    _o.JointNames = new List<string>();
    for (var _j = 0; _j < this.JointNamesLength; ++_j) {_o.JointNames.Add(this.JointNames(_j));}
    _o.Value = this.Value;
    _o.Descendants = this.Descendants;
  }
  public static Offset<gfl.anm2.fb.trbsm.RatioModifier> Pack(FlatBufferBuilder builder, RatioModifierT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.trbsm.RatioModifier>);
    var _tag = _o.Tag == null ? default(StringOffset) : builder.CreateString(_o.Tag);
    var _jointNames = default(VectorOffset);
    if (_o.JointNames != null) {
      var __jointNames = new StringOffset[_o.JointNames.Count];
      for (var _j = 0; _j < __jointNames.Length; ++_j) { __jointNames[_j] = builder.CreateString(_o.JointNames[_j]); }
      _jointNames = CreateJointNamesVector(builder, __jointNames);
    }
    return CreateRatioModifier(
      builder,
      _tag,
      _jointNames,
      _o.Value,
      _o.Descendants);
  }
};

public class RatioModifierT
{
  [Newtonsoft.Json.JsonProperty("tag")]
  public string Tag { get; set; }
  [Newtonsoft.Json.JsonProperty("jointNames")]
  public List<string> JointNames { get; set; }
  [Newtonsoft.Json.JsonProperty("value")]
  public float Value { get; set; }
  [Newtonsoft.Json.JsonProperty("descendants")]
  public bool Descendants { get; set; }

  public RatioModifierT() {
    this.Tag = null;
    this.JointNames = null;
    this.Value = 0.0f;
    this.Descendants = false;
  }
}

public struct ScalerModifier : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ScalerModifier GetRootAsScalerModifier(ByteBuffer _bb) { return GetRootAsScalerModifier(_bb, new ScalerModifier()); }
  public static ScalerModifier GetRootAsScalerModifier(ByteBuffer _bb, ScalerModifier obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScalerModifier __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Tag { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTagBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetTagBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetTagArray() { return __p.__vector_as_array<byte>(4); }
  public string JointNames(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int JointNamesLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public gfl.anm2.fb.trbsm.ScalerAxis ScalerAxis { get { int o = __p.__offset(8); return o != 0 ? (gfl.anm2.fb.trbsm.ScalerAxis)__p.bb.Get(o + __p.bb_pos) : gfl.anm2.fb.trbsm.ScalerAxis.None; } }
  public float Values(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int ValuesLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetValuesBytes() { return __p.__vector_as_span<float>(10, 4); }
#else
  public ArraySegment<byte>? GetValuesBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public float[] GetValuesArray() { return __p.__vector_as_array<float>(10); }

  public static Offset<gfl.anm2.fb.trbsm.ScalerModifier> CreateScalerModifier(FlatBufferBuilder builder,
      StringOffset tagOffset = default(StringOffset),
      VectorOffset jointNamesOffset = default(VectorOffset),
      gfl.anm2.fb.trbsm.ScalerAxis scalerAxis = gfl.anm2.fb.trbsm.ScalerAxis.None,
      VectorOffset valuesOffset = default(VectorOffset)) {
    builder.StartTable(4);
    ScalerModifier.AddValues(builder, valuesOffset);
    ScalerModifier.AddJointNames(builder, jointNamesOffset);
    ScalerModifier.AddTag(builder, tagOffset);
    ScalerModifier.AddScalerAxis(builder, scalerAxis);
    return ScalerModifier.EndScalerModifier(builder);
  }

  public static void StartScalerModifier(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddTag(FlatBufferBuilder builder, StringOffset tagOffset) { builder.AddOffset(0, tagOffset.Value, 0); }
  public static void AddJointNames(FlatBufferBuilder builder, VectorOffset jointNamesOffset) { builder.AddOffset(1, jointNamesOffset.Value, 0); }
  public static VectorOffset CreateJointNamesVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateJointNamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartJointNamesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddScalerAxis(FlatBufferBuilder builder, gfl.anm2.fb.trbsm.ScalerAxis scalerAxis) { builder.AddByte(2, (byte)scalerAxis, 0); }
  public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset) { builder.AddOffset(3, valuesOffset.Value, 0); }
  public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartValuesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<gfl.anm2.fb.trbsm.ScalerModifier> EndScalerModifier(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.trbsm.ScalerModifier>(o);
  }
  public ScalerModifierT UnPack() {
    var _o = new ScalerModifierT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ScalerModifierT _o) {
    _o.Tag = this.Tag;
    _o.JointNames = new List<string>();
    for (var _j = 0; _j < this.JointNamesLength; ++_j) {_o.JointNames.Add(this.JointNames(_j));}
    _o.ScalerAxis = this.ScalerAxis;
    _o.Values = new List<float>();
    for (var _j = 0; _j < this.ValuesLength; ++_j) {_o.Values.Add(this.Values(_j));}
  }
  public static Offset<gfl.anm2.fb.trbsm.ScalerModifier> Pack(FlatBufferBuilder builder, ScalerModifierT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.trbsm.ScalerModifier>);
    var _tag = _o.Tag == null ? default(StringOffset) : builder.CreateString(_o.Tag);
    var _jointNames = default(VectorOffset);
    if (_o.JointNames != null) {
      var __jointNames = new StringOffset[_o.JointNames.Count];
      for (var _j = 0; _j < __jointNames.Length; ++_j) { __jointNames[_j] = builder.CreateString(_o.JointNames[_j]); }
      _jointNames = CreateJointNamesVector(builder, __jointNames);
    }
    var _values = default(VectorOffset);
    if (_o.Values != null) {
      var __values = _o.Values.ToArray();
      _values = CreateValuesVector(builder, __values);
    }
    return CreateScalerModifier(
      builder,
      _tag,
      _jointNames,
      _o.ScalerAxis,
      _values);
  }
};

public class ScalerModifierT
{
  [Newtonsoft.Json.JsonProperty("tag")]
  public string Tag { get; set; }
  [Newtonsoft.Json.JsonProperty("jointNames")]
  public List<string> JointNames { get; set; }
  [Newtonsoft.Json.JsonProperty("scalerAxis")]
  public gfl.anm2.fb.trbsm.ScalerAxis ScalerAxis { get; set; }
  [Newtonsoft.Json.JsonProperty("values")]
  public List<float> Values { get; set; }

  public ScalerModifierT() {
    this.Tag = null;
    this.JointNames = null;
    this.ScalerAxis = gfl.anm2.fb.trbsm.ScalerAxis.None;
    this.Values = null;
  }
}

public struct RatioToTransModifier : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static RatioToTransModifier GetRootAsRatioToTransModifier(ByteBuffer _bb) { return GetRootAsRatioToTransModifier(_bb, new RatioToTransModifier()); }
  public static RatioToTransModifier GetRootAsRatioToTransModifier(ByteBuffer _bb, RatioToTransModifier obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RatioToTransModifier __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string RatioTag { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRatioTagBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetRatioTagBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetRatioTagArray() { return __p.__vector_as_array<byte>(4); }
  public string JointNames(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int JointNamesLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<gfl.anm2.fb.trbsm.RatioToTransModifier> CreateRatioToTransModifier(FlatBufferBuilder builder,
      StringOffset ratioTagOffset = default(StringOffset),
      VectorOffset jointNamesOffset = default(VectorOffset)) {
    builder.StartTable(2);
    RatioToTransModifier.AddJointNames(builder, jointNamesOffset);
    RatioToTransModifier.AddRatioTag(builder, ratioTagOffset);
    return RatioToTransModifier.EndRatioToTransModifier(builder);
  }

  public static void StartRatioToTransModifier(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddRatioTag(FlatBufferBuilder builder, StringOffset ratioTagOffset) { builder.AddOffset(0, ratioTagOffset.Value, 0); }
  public static void AddJointNames(FlatBufferBuilder builder, VectorOffset jointNamesOffset) { builder.AddOffset(1, jointNamesOffset.Value, 0); }
  public static VectorOffset CreateJointNamesVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateJointNamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartJointNamesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<gfl.anm2.fb.trbsm.RatioToTransModifier> EndRatioToTransModifier(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.trbsm.RatioToTransModifier>(o);
  }
  public RatioToTransModifierT UnPack() {
    var _o = new RatioToTransModifierT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RatioToTransModifierT _o) {
    _o.RatioTag = this.RatioTag;
    _o.JointNames = new List<string>();
    for (var _j = 0; _j < this.JointNamesLength; ++_j) {_o.JointNames.Add(this.JointNames(_j));}
  }
  public static Offset<gfl.anm2.fb.trbsm.RatioToTransModifier> Pack(FlatBufferBuilder builder, RatioToTransModifierT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.trbsm.RatioToTransModifier>);
    var _ratioTag = _o.RatioTag == null ? default(StringOffset) : builder.CreateString(_o.RatioTag);
    var _jointNames = default(VectorOffset);
    if (_o.JointNames != null) {
      var __jointNames = new StringOffset[_o.JointNames.Count];
      for (var _j = 0; _j < __jointNames.Length; ++_j) { __jointNames[_j] = builder.CreateString(_o.JointNames[_j]); }
      _jointNames = CreateJointNamesVector(builder, __jointNames);
    }
    return CreateRatioToTransModifier(
      builder,
      _ratioTag,
      _jointNames);
  }
};

public class RatioToTransModifierT
{
  [Newtonsoft.Json.JsonProperty("ratioTag")]
  public string RatioTag { get; set; }
  [Newtonsoft.Json.JsonProperty("jointNames")]
  public List<string> JointNames { get; set; }

  public RatioToTransModifierT() {
    this.RatioTag = null;
    this.JointNames = null;
  }
}

public struct RatioToRootMotionTransScale : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static RatioToRootMotionTransScale GetRootAsRatioToRootMotionTransScale(ByteBuffer _bb) { return GetRootAsRatioToRootMotionTransScale(_bb, new RatioToRootMotionTransScale()); }
  public static RatioToRootMotionTransScale GetRootAsRatioToRootMotionTransScale(ByteBuffer _bb, RatioToRootMotionTransScale obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RatioToRootMotionTransScale __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string RatioTag { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRatioTagBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetRatioTagBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetRatioTagArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<gfl.anm2.fb.trbsm.RatioToRootMotionTransScale> CreateRatioToRootMotionTransScale(FlatBufferBuilder builder,
      StringOffset ratioTagOffset = default(StringOffset)) {
    builder.StartTable(1);
    RatioToRootMotionTransScale.AddRatioTag(builder, ratioTagOffset);
    return RatioToRootMotionTransScale.EndRatioToRootMotionTransScale(builder);
  }

  public static void StartRatioToRootMotionTransScale(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddRatioTag(FlatBufferBuilder builder, StringOffset ratioTagOffset) { builder.AddOffset(0, ratioTagOffset.Value, 0); }
  public static Offset<gfl.anm2.fb.trbsm.RatioToRootMotionTransScale> EndRatioToRootMotionTransScale(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.trbsm.RatioToRootMotionTransScale>(o);
  }
  public RatioToRootMotionTransScaleT UnPack() {
    var _o = new RatioToRootMotionTransScaleT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RatioToRootMotionTransScaleT _o) {
    _o.RatioTag = this.RatioTag;
  }
  public static Offset<gfl.anm2.fb.trbsm.RatioToRootMotionTransScale> Pack(FlatBufferBuilder builder, RatioToRootMotionTransScaleT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.trbsm.RatioToRootMotionTransScale>);
    var _ratioTag = _o.RatioTag == null ? default(StringOffset) : builder.CreateString(_o.RatioTag);
    return CreateRatioToRootMotionTransScale(
      builder,
      _ratioTag);
  }
};

public class RatioToRootMotionTransScaleT
{
  [Newtonsoft.Json.JsonProperty("ratioTag")]
  public string RatioTag { get; set; }

  public RatioToRootMotionTransScaleT() {
    this.RatioTag = null;
  }
}

public struct Root : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static Root GetRootAsRoot(ByteBuffer _bb) { return GetRootAsRoot(_bb, new Root()); }
  public static Root GetRootAsRoot(ByteBuffer _bb, Root obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool RootBufferHasIdentifier(ByteBuffer _bb) { return Table.__has_identifier(_bb, "TRBS"); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Root __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.anm2.fb.trbsm.RatioModifier? RatioModifiers(int j) { int o = __p.__offset(4); return o != 0 ? (gfl.anm2.fb.trbsm.RatioModifier?)(new gfl.anm2.fb.trbsm.RatioModifier()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int RatioModifiersLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public gfl.anm2.fb.trbsm.ScalerModifier? ScalerModifiers(int j) { int o = __p.__offset(6); return o != 0 ? (gfl.anm2.fb.trbsm.ScalerModifier?)(new gfl.anm2.fb.trbsm.ScalerModifier()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ScalerModifiersLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public gfl.anm2.fb.trbsm.RatioToTransModifier? RatioToTransModifiers(int j) { int o = __p.__offset(8); return o != 0 ? (gfl.anm2.fb.trbsm.RatioToTransModifier?)(new gfl.anm2.fb.trbsm.RatioToTransModifier()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int RatioToTransModifiersLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  public gfl.anm2.fb.trbsm.RatioToRootMotionTransScale? RatioToRootMotionTransScale { get { int o = __p.__offset(10); return o != 0 ? (gfl.anm2.fb.trbsm.RatioToRootMotionTransScale?)(new gfl.anm2.fb.trbsm.RatioToRootMotionTransScale()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<gfl.anm2.fb.trbsm.Root> CreateRoot(FlatBufferBuilder builder,
      VectorOffset ratioModifiersOffset = default(VectorOffset),
      VectorOffset scalerModifiersOffset = default(VectorOffset),
      VectorOffset ratioToTransModifiersOffset = default(VectorOffset),
      Offset<gfl.anm2.fb.trbsm.RatioToRootMotionTransScale> ratioToRootMotionTransScaleOffset = default(Offset<gfl.anm2.fb.trbsm.RatioToRootMotionTransScale>)) {
    builder.StartTable(4);
    Root.AddRatioToRootMotionTransScale(builder, ratioToRootMotionTransScaleOffset);
    Root.AddRatioToTransModifiers(builder, ratioToTransModifiersOffset);
    Root.AddScalerModifiers(builder, scalerModifiersOffset);
    Root.AddRatioModifiers(builder, ratioModifiersOffset);
    return Root.EndRoot(builder);
  }

  public static void StartRoot(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddRatioModifiers(FlatBufferBuilder builder, VectorOffset ratioModifiersOffset) { builder.AddOffset(0, ratioModifiersOffset.Value, 0); }
  public static VectorOffset CreateRatioModifiersVector(FlatBufferBuilder builder, Offset<gfl.anm2.fb.trbsm.RatioModifier>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRatioModifiersVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fb.trbsm.RatioModifier>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartRatioModifiersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddScalerModifiers(FlatBufferBuilder builder, VectorOffset scalerModifiersOffset) { builder.AddOffset(1, scalerModifiersOffset.Value, 0); }
  public static VectorOffset CreateScalerModifiersVector(FlatBufferBuilder builder, Offset<gfl.anm2.fb.trbsm.ScalerModifier>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateScalerModifiersVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fb.trbsm.ScalerModifier>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartScalerModifiersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRatioToTransModifiers(FlatBufferBuilder builder, VectorOffset ratioToTransModifiersOffset) { builder.AddOffset(2, ratioToTransModifiersOffset.Value, 0); }
  public static VectorOffset CreateRatioToTransModifiersVector(FlatBufferBuilder builder, Offset<gfl.anm2.fb.trbsm.RatioToTransModifier>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRatioToTransModifiersVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fb.trbsm.RatioToTransModifier>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartRatioToTransModifiersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRatioToRootMotionTransScale(FlatBufferBuilder builder, Offset<gfl.anm2.fb.trbsm.RatioToRootMotionTransScale> ratioToRootMotionTransScaleOffset) { builder.AddOffset(3, ratioToRootMotionTransScaleOffset.Value, 0); }
  public static Offset<gfl.anm2.fb.trbsm.Root> EndRoot(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.trbsm.Root>(o);
  }
  public static void FinishRootBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fb.trbsm.Root> offset) { builder.Finish(offset.Value, "TRBS"); }
  public static void FinishSizePrefixedRootBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fb.trbsm.Root> offset) { builder.FinishSizePrefixed(offset.Value, "TRBS"); }
  public RootT UnPack() {
    var _o = new RootT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RootT _o) {
    _o.RatioModifiers = new List<gfl.anm2.fb.trbsm.RatioModifierT>();
    for (var _j = 0; _j < this.RatioModifiersLength; ++_j) {_o.RatioModifiers.Add(this.RatioModifiers(_j).HasValue ? this.RatioModifiers(_j).Value.UnPack() : null);}
    _o.ScalerModifiers = new List<gfl.anm2.fb.trbsm.ScalerModifierT>();
    for (var _j = 0; _j < this.ScalerModifiersLength; ++_j) {_o.ScalerModifiers.Add(this.ScalerModifiers(_j).HasValue ? this.ScalerModifiers(_j).Value.UnPack() : null);}
    _o.RatioToTransModifiers = new List<gfl.anm2.fb.trbsm.RatioToTransModifierT>();
    for (var _j = 0; _j < this.RatioToTransModifiersLength; ++_j) {_o.RatioToTransModifiers.Add(this.RatioToTransModifiers(_j).HasValue ? this.RatioToTransModifiers(_j).Value.UnPack() : null);}
    _o.RatioToRootMotionTransScale = this.RatioToRootMotionTransScale.HasValue ? this.RatioToRootMotionTransScale.Value.UnPack() : null;
  }
  public static Offset<gfl.anm2.fb.trbsm.Root> Pack(FlatBufferBuilder builder, RootT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.trbsm.Root>);
    var _ratioModifiers = default(VectorOffset);
    if (_o.RatioModifiers != null) {
      var __ratioModifiers = new Offset<gfl.anm2.fb.trbsm.RatioModifier>[_o.RatioModifiers.Count];
      for (var _j = 0; _j < __ratioModifiers.Length; ++_j) { __ratioModifiers[_j] = gfl.anm2.fb.trbsm.RatioModifier.Pack(builder, _o.RatioModifiers[_j]); }
      _ratioModifiers = CreateRatioModifiersVector(builder, __ratioModifiers);
    }
    var _scalerModifiers = default(VectorOffset);
    if (_o.ScalerModifiers != null) {
      var __scalerModifiers = new Offset<gfl.anm2.fb.trbsm.ScalerModifier>[_o.ScalerModifiers.Count];
      for (var _j = 0; _j < __scalerModifiers.Length; ++_j) { __scalerModifiers[_j] = gfl.anm2.fb.trbsm.ScalerModifier.Pack(builder, _o.ScalerModifiers[_j]); }
      _scalerModifiers = CreateScalerModifiersVector(builder, __scalerModifiers);
    }
    var _ratioToTransModifiers = default(VectorOffset);
    if (_o.RatioToTransModifiers != null) {
      var __ratioToTransModifiers = new Offset<gfl.anm2.fb.trbsm.RatioToTransModifier>[_o.RatioToTransModifiers.Count];
      for (var _j = 0; _j < __ratioToTransModifiers.Length; ++_j) { __ratioToTransModifiers[_j] = gfl.anm2.fb.trbsm.RatioToTransModifier.Pack(builder, _o.RatioToTransModifiers[_j]); }
      _ratioToTransModifiers = CreateRatioToTransModifiersVector(builder, __ratioToTransModifiers);
    }
    var _ratioToRootMotionTransScale = _o.RatioToRootMotionTransScale == null ? default(Offset<gfl.anm2.fb.trbsm.RatioToRootMotionTransScale>) : gfl.anm2.fb.trbsm.RatioToRootMotionTransScale.Pack(builder, _o.RatioToRootMotionTransScale);
    return CreateRoot(
      builder,
      _ratioModifiers,
      _scalerModifiers,
      _ratioToTransModifiers,
      _ratioToRootMotionTransScale);
  }
};

public class RootT
{
  [Newtonsoft.Json.JsonProperty("ratioModifiers")]
  public List<gfl.anm2.fb.trbsm.RatioModifierT> RatioModifiers { get; set; }
  [Newtonsoft.Json.JsonProperty("scalerModifiers")]
  public List<gfl.anm2.fb.trbsm.ScalerModifierT> ScalerModifiers { get; set; }
  [Newtonsoft.Json.JsonProperty("ratioToTransModifiers")]
  public List<gfl.anm2.fb.trbsm.RatioToTransModifierT> RatioToTransModifiers { get; set; }
  [Newtonsoft.Json.JsonProperty("ratioToRootMotionTransScale")]
  public gfl.anm2.fb.trbsm.RatioToRootMotionTransScaleT RatioToRootMotionTransScale { get; set; }

  public RootT() {
    this.RatioModifiers = null;
    this.ScalerModifiers = null;
    this.RatioToTransModifiers = null;
    this.RatioToRootMotionTransScale = null;
  }

  public static RootT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<RootT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static RootT DeserializeFromBinary(byte[] fbBuffer) {
    return Root.GetRootAsRoot(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    Root.FinishRootBuffer(fbb, Root.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
