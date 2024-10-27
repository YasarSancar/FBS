// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace common.ai.container.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum ParameterValue : byte
{
  NONE = 0,
  ParameterValue_Int = 1,
  ParameterValue_Float = 2,
  ParameterValue_Bool = 3,
  ParameterValue_Vector3 = 4,
  ParameterValue_String = 5,
  ParameterValue_FnvHash = 6,
};

public class ParameterValueUnion {
  public ParameterValue Type { get; set; }
  public object Value { get; set; }

  public ParameterValueUnion() {
    this.Type = ParameterValue.NONE;
    this.Value = null;
  }

  public T As<T>() where T : class { return this.Value as T; }
  public common.ai.container.fb.ParameterValue_IntT AsParameterValue_Int() { return this.As<common.ai.container.fb.ParameterValue_IntT>(); }
  public common.ai.container.fb.ParameterValue_FloatT AsParameterValue_Float() { return this.As<common.ai.container.fb.ParameterValue_FloatT>(); }
  public common.ai.container.fb.ParameterValue_BoolT AsParameterValue_Bool() { return this.As<common.ai.container.fb.ParameterValue_BoolT>(); }
  public common.ai.container.fb.ParameterValue_Vector3T AsParameterValue_Vector3() { return this.As<common.ai.container.fb.ParameterValue_Vector3T>(); }
  public common.ai.container.fb.ParameterValue_StringT AsParameterValue_String() { return this.As<common.ai.container.fb.ParameterValue_StringT>(); }
  public common.ai.container.fb.ParameterValue_FnvHashT AsParameterValue_FnvHash() { return this.As<common.ai.container.fb.ParameterValue_FnvHashT>(); }

  public static int Pack(FlatBuffers.FlatBufferBuilder builder, ParameterValueUnion _o) {
    switch (_o.Type) {
      default: return 0;
      case ParameterValue.ParameterValue_Int: return common.ai.container.fb.ParameterValue_Int.Pack(builder, _o.AsParameterValue_Int()).Value;
      case ParameterValue.ParameterValue_Float: return common.ai.container.fb.ParameterValue_Float.Pack(builder, _o.AsParameterValue_Float()).Value;
      case ParameterValue.ParameterValue_Bool: return common.ai.container.fb.ParameterValue_Bool.Pack(builder, _o.AsParameterValue_Bool()).Value;
      case ParameterValue.ParameterValue_Vector3: return common.ai.container.fb.ParameterValue_Vector3.Pack(builder, _o.AsParameterValue_Vector3()).Value;
      case ParameterValue.ParameterValue_String: return common.ai.container.fb.ParameterValue_String.Pack(builder, _o.AsParameterValue_String()).Value;
      case ParameterValue.ParameterValue_FnvHash: return common.ai.container.fb.ParameterValue_FnvHash.Pack(builder, _o.AsParameterValue_FnvHash()).Value;
    }
  }
}

public class ParameterValueUnion_JsonConverter : Newtonsoft.Json.JsonConverter {
  public override bool CanConvert(System.Type objectType) {
    return objectType == typeof(ParameterValueUnion) || objectType == typeof(System.Collections.Generic.List<ParameterValueUnion>);
  }
  public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) {
    var _olist = value as System.Collections.Generic.List<ParameterValueUnion>;
    if (_olist != null) {
      writer.WriteStartArray();
      foreach (var _o in _olist) { this.WriteJson(writer, _o, serializer); }
      writer.WriteEndArray();
    } else {
      this.WriteJson(writer, value as ParameterValueUnion, serializer);
    }
  }
  public void WriteJson(Newtonsoft.Json.JsonWriter writer, ParameterValueUnion _o, Newtonsoft.Json.JsonSerializer serializer) {
    if (_o == null) return;
    serializer.Serialize(writer, _o.Value);
  }
  public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) {
    var _olist = existingValue as System.Collections.Generic.List<ParameterValueUnion>;
    if (_olist != null) {
      for (var _j = 0; _j < _olist.Count; ++_j) {
        reader.Read();
        _olist[_j] = this.ReadJson(reader, _olist[_j], serializer);
      }
      reader.Read();
      return _olist;
    } else {
      return this.ReadJson(reader, existingValue as ParameterValueUnion, serializer);
    }
  }
  public ParameterValueUnion ReadJson(Newtonsoft.Json.JsonReader reader, ParameterValueUnion _o, Newtonsoft.Json.JsonSerializer serializer) {
    if (_o == null) return null;
    switch (_o.Type) {
      default: break;
      case ParameterValue.ParameterValue_Int: _o.Value = serializer.Deserialize<common.ai.container.fb.ParameterValue_IntT>(reader); break;
      case ParameterValue.ParameterValue_Float: _o.Value = serializer.Deserialize<common.ai.container.fb.ParameterValue_FloatT>(reader); break;
      case ParameterValue.ParameterValue_Bool: _o.Value = serializer.Deserialize<common.ai.container.fb.ParameterValue_BoolT>(reader); break;
      case ParameterValue.ParameterValue_Vector3: _o.Value = serializer.Deserialize<common.ai.container.fb.ParameterValue_Vector3T>(reader); break;
      case ParameterValue.ParameterValue_String: _o.Value = serializer.Deserialize<common.ai.container.fb.ParameterValue_StringT>(reader); break;
      case ParameterValue.ParameterValue_FnvHash: _o.Value = serializer.Deserialize<common.ai.container.fb.ParameterValue_FnvHashT>(reader); break;
    }
    return _o;
  }
}

public struct ParameterValue_Int : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ParameterValue_Int GetRootAsParameterValue_Int(ByteBuffer _bb) { return GetRootAsParameterValue_Int(_bb, new ParameterValue_Int()); }
  public static ParameterValue_Int GetRootAsParameterValue_Int(ByteBuffer _bb, ParameterValue_Int obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ParameterValue_Int __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Value { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<common.ai.container.fb.ParameterValue_Int> CreateParameterValue_Int(FlatBufferBuilder builder,
      int value = 0) {
    builder.StartTable(1);
    ParameterValue_Int.AddValue(builder, value);
    return ParameterValue_Int.EndParameterValue_Int(builder);
  }

  public static void StartParameterValue_Int(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddValue(FlatBufferBuilder builder, int value) { builder.AddInt(0, value, 0); }
  public static Offset<common.ai.container.fb.ParameterValue_Int> EndParameterValue_Int(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<common.ai.container.fb.ParameterValue_Int>(o);
  }
  public ParameterValue_IntT UnPack() {
    var _o = new ParameterValue_IntT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ParameterValue_IntT _o) {
    _o.Value = this.Value;
  }
  public static Offset<common.ai.container.fb.ParameterValue_Int> Pack(FlatBufferBuilder builder, ParameterValue_IntT _o) {
    if (_o == null) return default(Offset<common.ai.container.fb.ParameterValue_Int>);
    return CreateParameterValue_Int(
      builder,
      _o.Value);
  }
};

public class ParameterValue_IntT
{
  [Newtonsoft.Json.JsonProperty("value")]
  public int Value { get; set; }

  public ParameterValue_IntT() {
    this.Value = 0;
  }
}

public struct ParameterValue_Float : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ParameterValue_Float GetRootAsParameterValue_Float(ByteBuffer _bb) { return GetRootAsParameterValue_Float(_bb, new ParameterValue_Float()); }
  public static ParameterValue_Float GetRootAsParameterValue_Float(ByteBuffer _bb, ParameterValue_Float obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ParameterValue_Float __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float Value { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<common.ai.container.fb.ParameterValue_Float> CreateParameterValue_Float(FlatBufferBuilder builder,
      float value = 0.0f) {
    builder.StartTable(1);
    ParameterValue_Float.AddValue(builder, value);
    return ParameterValue_Float.EndParameterValue_Float(builder);
  }

  public static void StartParameterValue_Float(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddValue(FlatBufferBuilder builder, float value) { builder.AddFloat(0, value, 0.0f); }
  public static Offset<common.ai.container.fb.ParameterValue_Float> EndParameterValue_Float(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<common.ai.container.fb.ParameterValue_Float>(o);
  }
  public ParameterValue_FloatT UnPack() {
    var _o = new ParameterValue_FloatT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ParameterValue_FloatT _o) {
    _o.Value = this.Value;
  }
  public static Offset<common.ai.container.fb.ParameterValue_Float> Pack(FlatBufferBuilder builder, ParameterValue_FloatT _o) {
    if (_o == null) return default(Offset<common.ai.container.fb.ParameterValue_Float>);
    return CreateParameterValue_Float(
      builder,
      _o.Value);
  }
};

public class ParameterValue_FloatT
{
  [Newtonsoft.Json.JsonProperty("value")]
  public float Value { get; set; }

  public ParameterValue_FloatT() {
    this.Value = 0.0f;
  }
}

public struct ParameterValue_Bool : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ParameterValue_Bool GetRootAsParameterValue_Bool(ByteBuffer _bb) { return GetRootAsParameterValue_Bool(_bb, new ParameterValue_Bool()); }
  public static ParameterValue_Bool GetRootAsParameterValue_Bool(ByteBuffer _bb, ParameterValue_Bool obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ParameterValue_Bool __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public bool Value { get { int o = __p.__offset(4); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<common.ai.container.fb.ParameterValue_Bool> CreateParameterValue_Bool(FlatBufferBuilder builder,
      bool value = false) {
    builder.StartTable(1);
    ParameterValue_Bool.AddValue(builder, value);
    return ParameterValue_Bool.EndParameterValue_Bool(builder);
  }

  public static void StartParameterValue_Bool(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddValue(FlatBufferBuilder builder, bool value) { builder.AddBool(0, value, false); }
  public static Offset<common.ai.container.fb.ParameterValue_Bool> EndParameterValue_Bool(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<common.ai.container.fb.ParameterValue_Bool>(o);
  }
  public ParameterValue_BoolT UnPack() {
    var _o = new ParameterValue_BoolT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ParameterValue_BoolT _o) {
    _o.Value = this.Value;
  }
  public static Offset<common.ai.container.fb.ParameterValue_Bool> Pack(FlatBufferBuilder builder, ParameterValue_BoolT _o) {
    if (_o == null) return default(Offset<common.ai.container.fb.ParameterValue_Bool>);
    return CreateParameterValue_Bool(
      builder,
      _o.Value);
  }
};

public class ParameterValue_BoolT
{
  [Newtonsoft.Json.JsonProperty("value")]
  public bool Value { get; set; }

  public ParameterValue_BoolT() {
    this.Value = false;
  }
}

public struct ParameterValue_Vector3 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ParameterValue_Vector3 GetRootAsParameterValue_Vector3(ByteBuffer _bb) { return GetRootAsParameterValue_Vector3(_bb, new ParameterValue_Vector3()); }
  public static ParameterValue_Vector3 GetRootAsParameterValue_Vector3(ByteBuffer _bb, ParameterValue_Vector3 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ParameterValue_Vector3 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Y { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Z { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<common.ai.container.fb.ParameterValue_Vector3> CreateParameterValue_Vector3(FlatBufferBuilder builder,
      float x = 0.0f,
      float y = 0.0f,
      float z = 0.0f) {
    builder.StartTable(3);
    ParameterValue_Vector3.AddZ(builder, z);
    ParameterValue_Vector3.AddY(builder, y);
    ParameterValue_Vector3.AddX(builder, x);
    return ParameterValue_Vector3.EndParameterValue_Vector3(builder);
  }

  public static void StartParameterValue_Vector3(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddX(FlatBufferBuilder builder, float x) { builder.AddFloat(0, x, 0.0f); }
  public static void AddY(FlatBufferBuilder builder, float y) { builder.AddFloat(1, y, 0.0f); }
  public static void AddZ(FlatBufferBuilder builder, float z) { builder.AddFloat(2, z, 0.0f); }
  public static Offset<common.ai.container.fb.ParameterValue_Vector3> EndParameterValue_Vector3(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<common.ai.container.fb.ParameterValue_Vector3>(o);
  }
  public ParameterValue_Vector3T UnPack() {
    var _o = new ParameterValue_Vector3T();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ParameterValue_Vector3T _o) {
    _o.X = this.X;
    _o.Y = this.Y;
    _o.Z = this.Z;
  }
  public static Offset<common.ai.container.fb.ParameterValue_Vector3> Pack(FlatBufferBuilder builder, ParameterValue_Vector3T _o) {
    if (_o == null) return default(Offset<common.ai.container.fb.ParameterValue_Vector3>);
    return CreateParameterValue_Vector3(
      builder,
      _o.X,
      _o.Y,
      _o.Z);
  }
};

public class ParameterValue_Vector3T
{
  [Newtonsoft.Json.JsonProperty("x")]
  public float X { get; set; }
  [Newtonsoft.Json.JsonProperty("y")]
  public float Y { get; set; }
  [Newtonsoft.Json.JsonProperty("z")]
  public float Z { get; set; }

  public ParameterValue_Vector3T() {
    this.X = 0.0f;
    this.Y = 0.0f;
    this.Z = 0.0f;
  }
}

public struct ParameterValue_String : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ParameterValue_String GetRootAsParameterValue_String(ByteBuffer _bb) { return GetRootAsParameterValue_String(_bb, new ParameterValue_String()); }
  public static ParameterValue_String GetRootAsParameterValue_String(ByteBuffer _bb, ParameterValue_String obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ParameterValue_String __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Value { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetValueBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetValueBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetValueArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<common.ai.container.fb.ParameterValue_String> CreateParameterValue_String(FlatBufferBuilder builder,
      StringOffset valueOffset = default(StringOffset)) {
    builder.StartTable(1);
    ParameterValue_String.AddValue(builder, valueOffset);
    return ParameterValue_String.EndParameterValue_String(builder);
  }

  public static void StartParameterValue_String(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset) { builder.AddOffset(0, valueOffset.Value, 0); }
  public static Offset<common.ai.container.fb.ParameterValue_String> EndParameterValue_String(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<common.ai.container.fb.ParameterValue_String>(o);
  }
  public ParameterValue_StringT UnPack() {
    var _o = new ParameterValue_StringT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ParameterValue_StringT _o) {
    _o.Value = this.Value;
  }
  public static Offset<common.ai.container.fb.ParameterValue_String> Pack(FlatBufferBuilder builder, ParameterValue_StringT _o) {
    if (_o == null) return default(Offset<common.ai.container.fb.ParameterValue_String>);
    var _value = _o.Value == null ? default(StringOffset) : builder.CreateString(_o.Value);
    return CreateParameterValue_String(
      builder,
      _value);
  }
};

public class ParameterValue_StringT
{
  [Newtonsoft.Json.JsonProperty("value")]
  public string Value { get; set; }

  public ParameterValue_StringT() {
    this.Value = null;
  }
}

public struct ParameterValue_FnvHash : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ParameterValue_FnvHash GetRootAsParameterValue_FnvHash(ByteBuffer _bb) { return GetRootAsParameterValue_FnvHash(_bb, new ParameterValue_FnvHash()); }
  public static ParameterValue_FnvHash GetRootAsParameterValue_FnvHash(ByteBuffer _bb, ParameterValue_FnvHash obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ParameterValue_FnvHash __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Value { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetValueBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetValueBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetValueArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<common.ai.container.fb.ParameterValue_FnvHash> CreateParameterValue_FnvHash(FlatBufferBuilder builder,
      StringOffset valueOffset = default(StringOffset)) {
    builder.StartTable(1);
    ParameterValue_FnvHash.AddValue(builder, valueOffset);
    return ParameterValue_FnvHash.EndParameterValue_FnvHash(builder);
  }

  public static void StartParameterValue_FnvHash(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset) { builder.AddOffset(0, valueOffset.Value, 0); }
  public static Offset<common.ai.container.fb.ParameterValue_FnvHash> EndParameterValue_FnvHash(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<common.ai.container.fb.ParameterValue_FnvHash>(o);
  }
  public ParameterValue_FnvHashT UnPack() {
    var _o = new ParameterValue_FnvHashT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ParameterValue_FnvHashT _o) {
    _o.Value = this.Value;
  }
  public static Offset<common.ai.container.fb.ParameterValue_FnvHash> Pack(FlatBufferBuilder builder, ParameterValue_FnvHashT _o) {
    if (_o == null) return default(Offset<common.ai.container.fb.ParameterValue_FnvHash>);
    var _value = _o.Value == null ? default(StringOffset) : builder.CreateString(_o.Value);
    return CreateParameterValue_FnvHash(
      builder,
      _value);
  }
};

public class ParameterValue_FnvHashT
{
  [Newtonsoft.Json.JsonProperty("value")]
  public string Value { get; set; }

  public ParameterValue_FnvHashT() {
    this.Value = null;
  }
}

public struct Parameter : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static Parameter GetRootAsParameter(ByteBuffer _bb) { return GetRootAsParameter(_bb, new Parameter()); }
  public static Parameter GetRootAsParameter(ByteBuffer _bb, Parameter obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Parameter __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public common.ai.container.fb.ParameterValue ValueType { get { int o = __p.__offset(6); return o != 0 ? (common.ai.container.fb.ParameterValue)__p.bb.Get(o + __p.bb_pos) : common.ai.container.fb.ParameterValue.NONE; } }
  public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(8); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }
  public bool IsShared { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<common.ai.container.fb.Parameter> CreateParameter(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      common.ai.container.fb.ParameterValue value_type = common.ai.container.fb.ParameterValue.NONE,
      int valueOffset = 0,
      bool isShared = false) {
    builder.StartTable(4);
    Parameter.AddValue(builder, valueOffset);
    Parameter.AddName(builder, nameOffset);
    Parameter.AddIsShared(builder, isShared);
    Parameter.AddValueType(builder, value_type);
    return Parameter.EndParameter(builder);
  }

  public static void StartParameter(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddValueType(FlatBufferBuilder builder, common.ai.container.fb.ParameterValue valueType) { builder.AddByte(1, (byte)valueType, 0); }
  public static void AddValue(FlatBufferBuilder builder, int valueOffset) { builder.AddOffset(2, valueOffset, 0); }
  public static void AddIsShared(FlatBufferBuilder builder, bool isShared) { builder.AddBool(3, isShared, false); }
  public static Offset<common.ai.container.fb.Parameter> EndParameter(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<common.ai.container.fb.Parameter>(o);
  }
  public ParameterT UnPack() {
    var _o = new ParameterT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ParameterT _o) {
    _o.Name = this.Name;
    _o.Value = new common.ai.container.fb.ParameterValueUnion();
    _o.Value.Type = this.ValueType;
    switch (this.ValueType) {
      default: break;
      case common.ai.container.fb.ParameterValue.ParameterValue_Int:
        _o.Value.Value = this.Value<common.ai.container.fb.ParameterValue_Int>().HasValue ? this.Value<common.ai.container.fb.ParameterValue_Int>().Value.UnPack() : null;
        break;
      case common.ai.container.fb.ParameterValue.ParameterValue_Float:
        _o.Value.Value = this.Value<common.ai.container.fb.ParameterValue_Float>().HasValue ? this.Value<common.ai.container.fb.ParameterValue_Float>().Value.UnPack() : null;
        break;
      case common.ai.container.fb.ParameterValue.ParameterValue_Bool:
        _o.Value.Value = this.Value<common.ai.container.fb.ParameterValue_Bool>().HasValue ? this.Value<common.ai.container.fb.ParameterValue_Bool>().Value.UnPack() : null;
        break;
      case common.ai.container.fb.ParameterValue.ParameterValue_Vector3:
        _o.Value.Value = this.Value<common.ai.container.fb.ParameterValue_Vector3>().HasValue ? this.Value<common.ai.container.fb.ParameterValue_Vector3>().Value.UnPack() : null;
        break;
      case common.ai.container.fb.ParameterValue.ParameterValue_String:
        _o.Value.Value = this.Value<common.ai.container.fb.ParameterValue_String>().HasValue ? this.Value<common.ai.container.fb.ParameterValue_String>().Value.UnPack() : null;
        break;
      case common.ai.container.fb.ParameterValue.ParameterValue_FnvHash:
        _o.Value.Value = this.Value<common.ai.container.fb.ParameterValue_FnvHash>().HasValue ? this.Value<common.ai.container.fb.ParameterValue_FnvHash>().Value.UnPack() : null;
        break;
    }
    _o.IsShared = this.IsShared;
  }
  public static Offset<common.ai.container.fb.Parameter> Pack(FlatBufferBuilder builder, ParameterT _o) {
    if (_o == null) return default(Offset<common.ai.container.fb.Parameter>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _value_type = _o.Value == null ? common.ai.container.fb.ParameterValue.NONE : _o.Value.Type;
    var _value = _o.Value == null ? 0 : common.ai.container.fb.ParameterValueUnion.Pack(builder, _o.Value);
    return CreateParameter(
      builder,
      _name,
      _value_type,
      _value,
      _o.IsShared);
  }
};

public class ParameterT
{
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("value_type")]
  private common.ai.container.fb.ParameterValue ValueType {
    get {
      return this.Value != null ? this.Value.Type : common.ai.container.fb.ParameterValue.NONE;
    }
    set {
      this.Value = new common.ai.container.fb.ParameterValueUnion();
      this.Value.Type = value;
    }
  }
  [Newtonsoft.Json.JsonProperty("value")]
  [Newtonsoft.Json.JsonConverter(typeof(common.ai.container.fb.ParameterValueUnion_JsonConverter))]
  public common.ai.container.fb.ParameterValueUnion Value { get; set; }
  [Newtonsoft.Json.JsonProperty("isShared")]
  public bool IsShared { get; set; }

  public ParameterT() {
    this.Name = null;
    this.Value = null;
    this.IsShared = false;
  }
}

public struct Header : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static Header GetRootAsHeader(ByteBuffer _bb) { return GetRootAsHeader(_bb, new Header()); }
  public static Header GetRootAsHeader(ByteBuffer _bb, Header obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Header __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string GlobalID { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGlobalIDBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetGlobalIDBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetGlobalIDArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<common.ai.container.fb.Header> CreateHeader(FlatBufferBuilder builder,
      StringOffset globalIDOffset = default(StringOffset)) {
    builder.StartTable(1);
    Header.AddGlobalID(builder, globalIDOffset);
    return Header.EndHeader(builder);
  }

  public static void StartHeader(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddGlobalID(FlatBufferBuilder builder, StringOffset globalIDOffset) { builder.AddOffset(0, globalIDOffset.Value, 0); }
  public static Offset<common.ai.container.fb.Header> EndHeader(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<common.ai.container.fb.Header>(o);
  }
  public HeaderT UnPack() {
    var _o = new HeaderT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(HeaderT _o) {
    _o.GlobalID = this.GlobalID;
  }
  public static Offset<common.ai.container.fb.Header> Pack(FlatBufferBuilder builder, HeaderT _o) {
    if (_o == null) return default(Offset<common.ai.container.fb.Header>);
    var _globalID = _o.GlobalID == null ? default(StringOffset) : builder.CreateString(_o.GlobalID);
    return CreateHeader(
      builder,
      _globalID);
  }
};

public class HeaderT
{
  [Newtonsoft.Json.JsonProperty("globalID")]
  public string GlobalID { get; set; }

  public HeaderT() {
    this.GlobalID = null;
  }
}

public struct BlackboardData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static BlackboardData GetRootAsBlackboardData(ByteBuffer _bb) { return GetRootAsBlackboardData(_bb, new BlackboardData()); }
  public static BlackboardData GetRootAsBlackboardData(ByteBuffer _bb, BlackboardData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BlackboardData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public common.ai.container.fb.Header? Header { get { int o = __p.__offset(4); return o != 0 ? (common.ai.container.fb.Header?)(new common.ai.container.fb.Header()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public common.ai.container.fb.Parameter? Parameters(int j) { int o = __p.__offset(6); return o != 0 ? (common.ai.container.fb.Parameter?)(new common.ai.container.fb.Parameter()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ParametersLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<common.ai.container.fb.BlackboardData> CreateBlackboardData(FlatBufferBuilder builder,
      Offset<common.ai.container.fb.Header> headerOffset = default(Offset<common.ai.container.fb.Header>),
      VectorOffset parametersOffset = default(VectorOffset)) {
    builder.StartTable(2);
    BlackboardData.AddParameters(builder, parametersOffset);
    BlackboardData.AddHeader(builder, headerOffset);
    return BlackboardData.EndBlackboardData(builder);
  }

  public static void StartBlackboardData(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddHeader(FlatBufferBuilder builder, Offset<common.ai.container.fb.Header> headerOffset) { builder.AddOffset(0, headerOffset.Value, 0); }
  public static void AddParameters(FlatBufferBuilder builder, VectorOffset parametersOffset) { builder.AddOffset(1, parametersOffset.Value, 0); }
  public static VectorOffset CreateParametersVector(FlatBufferBuilder builder, Offset<common.ai.container.fb.Parameter>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateParametersVectorBlock(FlatBufferBuilder builder, Offset<common.ai.container.fb.Parameter>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartParametersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<common.ai.container.fb.BlackboardData> EndBlackboardData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<common.ai.container.fb.BlackboardData>(o);
  }
  public static void FinishBlackboardDataBuffer(FlatBufferBuilder builder, Offset<common.ai.container.fb.BlackboardData> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedBlackboardDataBuffer(FlatBufferBuilder builder, Offset<common.ai.container.fb.BlackboardData> offset) { builder.FinishSizePrefixed(offset.Value); }
  public BlackboardDataT UnPack() {
    var _o = new BlackboardDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BlackboardDataT _o) {
    _o.Header = this.Header.HasValue ? this.Header.Value.UnPack() : null;
    _o.Parameters = new List<common.ai.container.fb.ParameterT>();
    for (var _j = 0; _j < this.ParametersLength; ++_j) {_o.Parameters.Add(this.Parameters(_j).HasValue ? this.Parameters(_j).Value.UnPack() : null);}
  }
  public static Offset<common.ai.container.fb.BlackboardData> Pack(FlatBufferBuilder builder, BlackboardDataT _o) {
    if (_o == null) return default(Offset<common.ai.container.fb.BlackboardData>);
    var _header = _o.Header == null ? default(Offset<common.ai.container.fb.Header>) : common.ai.container.fb.Header.Pack(builder, _o.Header);
    var _parameters = default(VectorOffset);
    if (_o.Parameters != null) {
      var __parameters = new Offset<common.ai.container.fb.Parameter>[_o.Parameters.Count];
      for (var _j = 0; _j < __parameters.Length; ++_j) { __parameters[_j] = common.ai.container.fb.Parameter.Pack(builder, _o.Parameters[_j]); }
      _parameters = CreateParametersVector(builder, __parameters);
    }
    return CreateBlackboardData(
      builder,
      _header,
      _parameters);
  }
};

public class BlackboardDataT
{
  [Newtonsoft.Json.JsonProperty("header")]
  public common.ai.container.fb.HeaderT Header { get; set; }
  [Newtonsoft.Json.JsonProperty("parameters")]
  public List<common.ai.container.fb.ParameterT> Parameters { get; set; }

  public BlackboardDataT() {
    this.Header = null;
    this.Parameters = null;
  }

  public static BlackboardDataT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<BlackboardDataT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static BlackboardDataT DeserializeFromBinary(byte[] fbBuffer) {
    return BlackboardData.GetRootAsBlackboardData(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    BlackboardData.FinishBlackboardDataBuffer(fbb, BlackboardData.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}