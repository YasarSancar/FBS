// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum CollisionData : byte
{
  NONE = 0,
  BodyCollision = 1,
  CharacterCollision = 2,
};

public class CollisionDataUnion {
  public CollisionData Type { get; set; }
  public object Value { get; set; }

  public CollisionDataUnion() {
    this.Type = CollisionData.NONE;
    this.Value = null;
  }

  public T As<T>() where T : class { return this.Value as T; }
  public gfl.scene.fb.BodyCollisionT AsBodyCollision() { return this.As<gfl.scene.fb.BodyCollisionT>(); }
  public gfl.scene.fb.CharacterCollisionT AsCharacterCollision() { return this.As<gfl.scene.fb.CharacterCollisionT>(); }

  public static int Pack(FlatBuffers.FlatBufferBuilder builder, CollisionDataUnion _o) {
    switch (_o.Type) {
      default: return 0;
      case CollisionData.BodyCollision: return gfl.scene.fb.BodyCollision.Pack(builder, _o.AsBodyCollision()).Value;
      case CollisionData.CharacterCollision: return gfl.scene.fb.CharacterCollision.Pack(builder, _o.AsCharacterCollision()).Value;
    }
  }
}

public class CollisionDataUnion_JsonConverter : Newtonsoft.Json.JsonConverter {
  public override bool CanConvert(System.Type objectType) {
    return objectType == typeof(CollisionDataUnion) || objectType == typeof(System.Collections.Generic.List<CollisionDataUnion>);
  }
  public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) {
    var _olist = value as System.Collections.Generic.List<CollisionDataUnion>;
    if (_olist != null) {
      writer.WriteStartArray();
      foreach (var _o in _olist) { this.WriteJson(writer, _o, serializer); }
      writer.WriteEndArray();
    } else {
      this.WriteJson(writer, value as CollisionDataUnion, serializer);
    }
  }
  public void WriteJson(Newtonsoft.Json.JsonWriter writer, CollisionDataUnion _o, Newtonsoft.Json.JsonSerializer serializer) {
    if (_o == null) return;
    serializer.Serialize(writer, _o.Value);
  }
  public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) {
    var _olist = existingValue as System.Collections.Generic.List<CollisionDataUnion>;
    if (_olist != null) {
      for (var _j = 0; _j < _olist.Count; ++_j) {
        reader.Read();
        _olist[_j] = this.ReadJson(reader, _olist[_j], serializer);
      }
      reader.Read();
      return _olist;
    } else {
      return this.ReadJson(reader, existingValue as CollisionDataUnion, serializer);
    }
  }
  public CollisionDataUnion ReadJson(Newtonsoft.Json.JsonReader reader, CollisionDataUnion _o, Newtonsoft.Json.JsonSerializer serializer) {
    if (_o == null) return null;
    switch (_o.Type) {
      default: break;
      case CollisionData.BodyCollision: _o.Value = serializer.Deserialize<gfl.scene.fb.BodyCollisionT>(reader); break;
      case CollisionData.CharacterCollision: _o.Value = serializer.Deserialize<gfl.scene.fb.CharacterCollisionT>(reader); break;
    }
    return _o;
  }
}

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum MotionType : int
{
  Static = 0,
  Keyframed = 1,
  Dynamic = 2,
};

public struct CollisionMaterial : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static CollisionMaterial GetRootAsCollisionMaterial(ByteBuffer _bb) { return GetRootAsCollisionMaterial(_bb, new CollisionMaterial()); }
  public static CollisionMaterial GetRootAsCollisionMaterial(ByteBuffer _bb, CollisionMaterial obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CollisionMaterial __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float Mass { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DynamicFriction { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float StaticFriction { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Restitution { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<gfl.scene.fb.CollisionMaterial> CreateCollisionMaterial(FlatBufferBuilder builder,
      float mass = 0.0f,
      float dynamicFriction = 0.0f,
      float staticFriction = 0.0f,
      float restitution = 0.0f) {
    builder.StartTable(4);
    CollisionMaterial.AddRestitution(builder, restitution);
    CollisionMaterial.AddStaticFriction(builder, staticFriction);
    CollisionMaterial.AddDynamicFriction(builder, dynamicFriction);
    CollisionMaterial.AddMass(builder, mass);
    return CollisionMaterial.EndCollisionMaterial(builder);
  }

  public static void StartCollisionMaterial(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddMass(FlatBufferBuilder builder, float mass) { builder.AddFloat(0, mass, 0.0f); }
  public static void AddDynamicFriction(FlatBufferBuilder builder, float dynamicFriction) { builder.AddFloat(1, dynamicFriction, 0.0f); }
  public static void AddStaticFriction(FlatBufferBuilder builder, float staticFriction) { builder.AddFloat(2, staticFriction, 0.0f); }
  public static void AddRestitution(FlatBufferBuilder builder, float restitution) { builder.AddFloat(3, restitution, 0.0f); }
  public static Offset<gfl.scene.fb.CollisionMaterial> EndCollisionMaterial(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.CollisionMaterial>(o);
  }
  public CollisionMaterialT UnPack() {
    var _o = new CollisionMaterialT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CollisionMaterialT _o) {
    _o.Mass = this.Mass;
    _o.DynamicFriction = this.DynamicFriction;
    _o.StaticFriction = this.StaticFriction;
    _o.Restitution = this.Restitution;
  }
  public static Offset<gfl.scene.fb.CollisionMaterial> Pack(FlatBufferBuilder builder, CollisionMaterialT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.CollisionMaterial>);
    return CreateCollisionMaterial(
      builder,
      _o.Mass,
      _o.DynamicFriction,
      _o.StaticFriction,
      _o.Restitution);
  }
};

public class CollisionMaterialT
{
  [Newtonsoft.Json.JsonProperty("mass")]
  public float Mass { get; set; }
  [Newtonsoft.Json.JsonProperty("dynamicFriction")]
  public float DynamicFriction { get; set; }
  [Newtonsoft.Json.JsonProperty("staticFriction")]
  public float StaticFriction { get; set; }
  [Newtonsoft.Json.JsonProperty("restitution")]
  public float Restitution { get; set; }

  public CollisionMaterialT() {
    this.Mass = 0.0f;
    this.DynamicFriction = 0.0f;
    this.StaticFriction = 0.0f;
    this.Restitution = 0.0f;
  }
}

public struct BodyCollision : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static BodyCollision GetRootAsBodyCollision(ByteBuffer _bb) { return GetRootAsBodyCollision(_bb, new BodyCollision()); }
  public static BodyCollision GetRootAsBodyCollision(ByteBuffer _bb, BodyCollision obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BodyCollision __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.scene.fb.CollisionShapeData ShapeType { get { int o = __p.__offset(4); return o != 0 ? (gfl.scene.fb.CollisionShapeData)__p.bb.Get(o + __p.bb_pos) : gfl.scene.fb.CollisionShapeData.NONE; } }
  public TTable? Shape<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }
  public gfl.scene.fb.MotionType MotionType { get { int o = __p.__offset(8); return o != 0 ? (gfl.scene.fb.MotionType)__p.bb.GetInt(o + __p.bb_pos) : gfl.scene.fb.MotionType.Static; } }
  public bool Trigger { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool TriggerModifiable { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool StartWithDisabled { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int Layer { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool SyncParentScaleEnabled { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public gfl.scene.fb.CollisionMaterial? Material { get { int o = __p.__offset(20); return o != 0 ? (gfl.scene.fb.CollisionMaterial?)(new gfl.scene.fb.CollisionMaterial()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public string CollisionName { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCollisionNameBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetCollisionNameBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetCollisionNameArray() { return __p.__vector_as_array<byte>(22); }
  public bool MaterialModifiable { get { int o = __p.__offset(24); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool NotChangeParameters { get { int o = __p.__offset(26); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool DisableEventTrigger { get { int o = __p.__offset(28); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<gfl.scene.fb.BodyCollision> CreateBodyCollision(FlatBufferBuilder builder,
      gfl.scene.fb.CollisionShapeData shape_type = gfl.scene.fb.CollisionShapeData.NONE,
      int shapeOffset = 0,
      gfl.scene.fb.MotionType motionType = gfl.scene.fb.MotionType.Static,
      bool trigger = false,
      bool triggerModifiable = false,
      bool startWithDisabled = false,
      int layer = 0,
      bool syncParentScaleEnabled = false,
      Offset<gfl.scene.fb.CollisionMaterial> materialOffset = default(Offset<gfl.scene.fb.CollisionMaterial>),
      StringOffset collisionNameOffset = default(StringOffset),
      bool materialModifiable = false,
      bool notChangeParameters = false,
      bool disableEventTrigger = false) {
    builder.StartTable(13);
    BodyCollision.AddCollisionName(builder, collisionNameOffset);
    BodyCollision.AddMaterial(builder, materialOffset);
    BodyCollision.AddLayer(builder, layer);
    BodyCollision.AddMotionType(builder, motionType);
    BodyCollision.AddShape(builder, shapeOffset);
    BodyCollision.AddDisableEventTrigger(builder, disableEventTrigger);
    BodyCollision.AddNotChangeParameters(builder, notChangeParameters);
    BodyCollision.AddMaterialModifiable(builder, materialModifiable);
    BodyCollision.AddSyncParentScaleEnabled(builder, syncParentScaleEnabled);
    BodyCollision.AddStartWithDisabled(builder, startWithDisabled);
    BodyCollision.AddTriggerModifiable(builder, triggerModifiable);
    BodyCollision.AddTrigger(builder, trigger);
    BodyCollision.AddShapeType(builder, shape_type);
    return BodyCollision.EndBodyCollision(builder);
  }

  public static void StartBodyCollision(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddShapeType(FlatBufferBuilder builder, gfl.scene.fb.CollisionShapeData shapeType) { builder.AddByte(0, (byte)shapeType, 0); }
  public static void AddShape(FlatBufferBuilder builder, int shapeOffset) { builder.AddOffset(1, shapeOffset, 0); }
  public static void AddMotionType(FlatBufferBuilder builder, gfl.scene.fb.MotionType motionType) { builder.AddInt(2, (int)motionType, 0); }
  public static void AddTrigger(FlatBufferBuilder builder, bool trigger) { builder.AddBool(3, trigger, false); }
  public static void AddTriggerModifiable(FlatBufferBuilder builder, bool triggerModifiable) { builder.AddBool(4, triggerModifiable, false); }
  public static void AddStartWithDisabled(FlatBufferBuilder builder, bool startWithDisabled) { builder.AddBool(5, startWithDisabled, false); }
  public static void AddLayer(FlatBufferBuilder builder, int layer) { builder.AddInt(6, layer, 0); }
  public static void AddSyncParentScaleEnabled(FlatBufferBuilder builder, bool syncParentScaleEnabled) { builder.AddBool(7, syncParentScaleEnabled, false); }
  public static void AddMaterial(FlatBufferBuilder builder, Offset<gfl.scene.fb.CollisionMaterial> materialOffset) { builder.AddOffset(8, materialOffset.Value, 0); }
  public static void AddCollisionName(FlatBufferBuilder builder, StringOffset collisionNameOffset) { builder.AddOffset(9, collisionNameOffset.Value, 0); }
  public static void AddMaterialModifiable(FlatBufferBuilder builder, bool materialModifiable) { builder.AddBool(10, materialModifiable, false); }
  public static void AddNotChangeParameters(FlatBufferBuilder builder, bool notChangeParameters) { builder.AddBool(11, notChangeParameters, false); }
  public static void AddDisableEventTrigger(FlatBufferBuilder builder, bool disableEventTrigger) { builder.AddBool(12, disableEventTrigger, false); }
  public static Offset<gfl.scene.fb.BodyCollision> EndBodyCollision(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.BodyCollision>(o);
  }
  public BodyCollisionT UnPack() {
    var _o = new BodyCollisionT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BodyCollisionT _o) {
    _o.Shape = new gfl.scene.fb.CollisionShapeDataUnion();
    _o.Shape.Type = this.ShapeType;
    switch (this.ShapeType) {
      default: break;
      case gfl.scene.fb.CollisionShapeData.SphereShape:
        _o.Shape.Value = this.Shape<gfl.scene.fb.SphereShape>().HasValue ? this.Shape<gfl.scene.fb.SphereShape>().Value.UnPack() : null;
        break;
      case gfl.scene.fb.CollisionShapeData.BoxShape:
        _o.Shape.Value = this.Shape<gfl.scene.fb.BoxShape>().HasValue ? this.Shape<gfl.scene.fb.BoxShape>().Value.UnPack() : null;
        break;
      case gfl.scene.fb.CollisionShapeData.CapsuleShape:
        _o.Shape.Value = this.Shape<gfl.scene.fb.CapsuleShape>().HasValue ? this.Shape<gfl.scene.fb.CapsuleShape>().Value.UnPack() : null;
        break;
      case gfl.scene.fb.CollisionShapeData.ModelShape:
        _o.Shape.Value = this.Shape<gfl.scene.fb.ModelShape>().HasValue ? this.Shape<gfl.scene.fb.ModelShape>().Value.UnPack() : null;
        break;
      case gfl.scene.fb.CollisionShapeData.CompoundShape:
        _o.Shape.Value = this.Shape<gfl.scene.fb.CompoundShape>().HasValue ? this.Shape<gfl.scene.fb.CompoundShape>().Value.UnPack() : null;
        break;
      case gfl.scene.fb.CollisionShapeData.PencilShape:
        _o.Shape.Value = this.Shape<gfl.scene.fb.PencilShape>().HasValue ? this.Shape<gfl.scene.fb.PencilShape>().Value.UnPack() : null;
        break;
    }
    _o.MotionType = this.MotionType;
    _o.Trigger = this.Trigger;
    _o.TriggerModifiable = this.TriggerModifiable;
    _o.StartWithDisabled = this.StartWithDisabled;
    _o.Layer = this.Layer;
    _o.SyncParentScaleEnabled = this.SyncParentScaleEnabled;
    _o.Material = this.Material.HasValue ? this.Material.Value.UnPack() : null;
    _o.CollisionName = this.CollisionName;
    _o.MaterialModifiable = this.MaterialModifiable;
    _o.NotChangeParameters = this.NotChangeParameters;
    _o.DisableEventTrigger = this.DisableEventTrigger;
  }
  public static Offset<gfl.scene.fb.BodyCollision> Pack(FlatBufferBuilder builder, BodyCollisionT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.BodyCollision>);
    var _shape_type = _o.Shape == null ? gfl.scene.fb.CollisionShapeData.NONE : _o.Shape.Type;
    var _shape = _o.Shape == null ? 0 : gfl.scene.fb.CollisionShapeDataUnion.Pack(builder, _o.Shape);
    var _material = _o.Material == null ? default(Offset<gfl.scene.fb.CollisionMaterial>) : gfl.scene.fb.CollisionMaterial.Pack(builder, _o.Material);
    var _collisionName = _o.CollisionName == null ? default(StringOffset) : builder.CreateString(_o.CollisionName);
    return CreateBodyCollision(
      builder,
      _shape_type,
      _shape,
      _o.MotionType,
      _o.Trigger,
      _o.TriggerModifiable,
      _o.StartWithDisabled,
      _o.Layer,
      _o.SyncParentScaleEnabled,
      _material,
      _collisionName,
      _o.MaterialModifiable,
      _o.NotChangeParameters,
      _o.DisableEventTrigger);
  }
};

public class BodyCollisionT
{
  [Newtonsoft.Json.JsonProperty("shape_type")]
  private gfl.scene.fb.CollisionShapeData ShapeType {
    get {
      return this.Shape != null ? this.Shape.Type : gfl.scene.fb.CollisionShapeData.NONE;
    }
    set {
      this.Shape = new gfl.scene.fb.CollisionShapeDataUnion();
      this.Shape.Type = value;
    }
  }
  [Newtonsoft.Json.JsonProperty("shape")]
  [Newtonsoft.Json.JsonConverter(typeof(gfl.scene.fb.CollisionShapeDataUnion_JsonConverter))]
  public gfl.scene.fb.CollisionShapeDataUnion Shape { get; set; }
  [Newtonsoft.Json.JsonProperty("motionType")]
  public gfl.scene.fb.MotionType MotionType { get; set; }
  [Newtonsoft.Json.JsonProperty("trigger")]
  public bool Trigger { get; set; }
  [Newtonsoft.Json.JsonProperty("triggerModifiable")]
  public bool TriggerModifiable { get; set; }
  [Newtonsoft.Json.JsonProperty("startWithDisabled")]
  public bool StartWithDisabled { get; set; }
  [Newtonsoft.Json.JsonProperty("layer")]
  public int Layer { get; set; }
  [Newtonsoft.Json.JsonProperty("syncParentScaleEnabled")]
  public bool SyncParentScaleEnabled { get; set; }
  [Newtonsoft.Json.JsonProperty("material")]
  public gfl.scene.fb.CollisionMaterialT Material { get; set; }
  [Newtonsoft.Json.JsonProperty("collisionName")]
  public string CollisionName { get; set; }
  [Newtonsoft.Json.JsonProperty("materialModifiable")]
  public bool MaterialModifiable { get; set; }
  [Newtonsoft.Json.JsonProperty("notChangeParameters")]
  public bool NotChangeParameters { get; set; }
  [Newtonsoft.Json.JsonProperty("disableEventTrigger")]
  public bool DisableEventTrigger { get; set; }

  public BodyCollisionT() {
    this.Shape = null;
    this.MotionType = gfl.scene.fb.MotionType.Static;
    this.Trigger = false;
    this.TriggerModifiable = false;
    this.StartWithDisabled = false;
    this.Layer = 0;
    this.SyncParentScaleEnabled = false;
    this.Material = null;
    this.CollisionName = null;
    this.MaterialModifiable = false;
    this.NotChangeParameters = false;
    this.DisableEventTrigger = false;
  }
}

public struct CharacterCollision : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static CharacterCollision GetRootAsCharacterCollision(ByteBuffer _bb) { return GetRootAsCharacterCollision(_bb, new CharacterCollision()); }
  public static CharacterCollision GetRootAsCharacterCollision(ByteBuffer _bb, CharacterCollision obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterCollision __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.scene.fb.CollisionShapeData ShapeType { get { int o = __p.__offset(4); return o != 0 ? (gfl.scene.fb.CollisionShapeData)__p.bb.Get(o + __p.bb_pos) : gfl.scene.fb.CollisionShapeData.NONE; } }
  public TTable? Shape<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }
  public gfl.math.fb.Vector3f? Gravity { get { int o = __p.__offset(8); return o != 0 ? (gfl.math.fb.Vector3f?)(new gfl.math.fb.Vector3f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public float MaxSlope { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool IsControl { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float MoveSpeed { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool StartWithDisabled { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int Layer { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool SyncParentScaleEnabled { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string CollisionName { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCollisionNameBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetCollisionNameBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetCollisionNameArray() { return __p.__vector_as_array<byte>(22); }
  public float KeepDistance { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<gfl.scene.fb.CharacterCollision> CreateCharacterCollision(FlatBufferBuilder builder,
      gfl.scene.fb.CollisionShapeData shape_type = gfl.scene.fb.CollisionShapeData.NONE,
      int shapeOffset = 0,
      gfl.math.fb.Vector3fT gravity = null,
      float maxSlope = 0.0f,
      bool isControl = false,
      float moveSpeed = 0.0f,
      bool startWithDisabled = false,
      int layer = 0,
      bool syncParentScaleEnabled = false,
      StringOffset collisionNameOffset = default(StringOffset),
      float keepDistance = 0.0f) {
    builder.StartTable(11);
    CharacterCollision.AddKeepDistance(builder, keepDistance);
    CharacterCollision.AddCollisionName(builder, collisionNameOffset);
    CharacterCollision.AddLayer(builder, layer);
    CharacterCollision.AddMoveSpeed(builder, moveSpeed);
    CharacterCollision.AddMaxSlope(builder, maxSlope);
    CharacterCollision.AddGravity(builder, gfl.math.fb.Vector3f.Pack(builder, gravity));
    CharacterCollision.AddShape(builder, shapeOffset);
    CharacterCollision.AddSyncParentScaleEnabled(builder, syncParentScaleEnabled);
    CharacterCollision.AddStartWithDisabled(builder, startWithDisabled);
    CharacterCollision.AddIsControl(builder, isControl);
    CharacterCollision.AddShapeType(builder, shape_type);
    return CharacterCollision.EndCharacterCollision(builder);
  }

  public static void StartCharacterCollision(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddShapeType(FlatBufferBuilder builder, gfl.scene.fb.CollisionShapeData shapeType) { builder.AddByte(0, (byte)shapeType, 0); }
  public static void AddShape(FlatBufferBuilder builder, int shapeOffset) { builder.AddOffset(1, shapeOffset, 0); }
  public static void AddGravity(FlatBufferBuilder builder, Offset<gfl.math.fb.Vector3f> gravityOffset) { builder.AddStruct(2, gravityOffset.Value, 0); }
  public static void AddMaxSlope(FlatBufferBuilder builder, float maxSlope) { builder.AddFloat(3, maxSlope, 0.0f); }
  public static void AddIsControl(FlatBufferBuilder builder, bool isControl) { builder.AddBool(4, isControl, false); }
  public static void AddMoveSpeed(FlatBufferBuilder builder, float moveSpeed) { builder.AddFloat(5, moveSpeed, 0.0f); }
  public static void AddStartWithDisabled(FlatBufferBuilder builder, bool startWithDisabled) { builder.AddBool(6, startWithDisabled, false); }
  public static void AddLayer(FlatBufferBuilder builder, int layer) { builder.AddInt(7, layer, 0); }
  public static void AddSyncParentScaleEnabled(FlatBufferBuilder builder, bool syncParentScaleEnabled) { builder.AddBool(8, syncParentScaleEnabled, false); }
  public static void AddCollisionName(FlatBufferBuilder builder, StringOffset collisionNameOffset) { builder.AddOffset(9, collisionNameOffset.Value, 0); }
  public static void AddKeepDistance(FlatBufferBuilder builder, float keepDistance) { builder.AddFloat(10, keepDistance, 0.0f); }
  public static Offset<gfl.scene.fb.CharacterCollision> EndCharacterCollision(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.CharacterCollision>(o);
  }
  public CharacterCollisionT UnPack() {
    var _o = new CharacterCollisionT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CharacterCollisionT _o) {
    _o.Shape = new gfl.scene.fb.CollisionShapeDataUnion();
    _o.Shape.Type = this.ShapeType;
    switch (this.ShapeType) {
      default: break;
      case gfl.scene.fb.CollisionShapeData.SphereShape:
        _o.Shape.Value = this.Shape<gfl.scene.fb.SphereShape>().HasValue ? this.Shape<gfl.scene.fb.SphereShape>().Value.UnPack() : null;
        break;
      case gfl.scene.fb.CollisionShapeData.BoxShape:
        _o.Shape.Value = this.Shape<gfl.scene.fb.BoxShape>().HasValue ? this.Shape<gfl.scene.fb.BoxShape>().Value.UnPack() : null;
        break;
      case gfl.scene.fb.CollisionShapeData.CapsuleShape:
        _o.Shape.Value = this.Shape<gfl.scene.fb.CapsuleShape>().HasValue ? this.Shape<gfl.scene.fb.CapsuleShape>().Value.UnPack() : null;
        break;
      case gfl.scene.fb.CollisionShapeData.ModelShape:
        _o.Shape.Value = this.Shape<gfl.scene.fb.ModelShape>().HasValue ? this.Shape<gfl.scene.fb.ModelShape>().Value.UnPack() : null;
        break;
      case gfl.scene.fb.CollisionShapeData.CompoundShape:
        _o.Shape.Value = this.Shape<gfl.scene.fb.CompoundShape>().HasValue ? this.Shape<gfl.scene.fb.CompoundShape>().Value.UnPack() : null;
        break;
      case gfl.scene.fb.CollisionShapeData.PencilShape:
        _o.Shape.Value = this.Shape<gfl.scene.fb.PencilShape>().HasValue ? this.Shape<gfl.scene.fb.PencilShape>().Value.UnPack() : null;
        break;
    }
    _o.Gravity = this.Gravity.HasValue ? this.Gravity.Value.UnPack() : null;
    _o.MaxSlope = this.MaxSlope;
    _o.IsControl = this.IsControl;
    _o.MoveSpeed = this.MoveSpeed;
    _o.StartWithDisabled = this.StartWithDisabled;
    _o.Layer = this.Layer;
    _o.SyncParentScaleEnabled = this.SyncParentScaleEnabled;
    _o.CollisionName = this.CollisionName;
    _o.KeepDistance = this.KeepDistance;
  }
  public static Offset<gfl.scene.fb.CharacterCollision> Pack(FlatBufferBuilder builder, CharacterCollisionT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.CharacterCollision>);
    var _shape_type = _o.Shape == null ? gfl.scene.fb.CollisionShapeData.NONE : _o.Shape.Type;
    var _shape = _o.Shape == null ? 0 : gfl.scene.fb.CollisionShapeDataUnion.Pack(builder, _o.Shape);
    var _collisionName = _o.CollisionName == null ? default(StringOffset) : builder.CreateString(_o.CollisionName);
    return CreateCharacterCollision(
      builder,
      _shape_type,
      _shape,
      _o.Gravity,
      _o.MaxSlope,
      _o.IsControl,
      _o.MoveSpeed,
      _o.StartWithDisabled,
      _o.Layer,
      _o.SyncParentScaleEnabled,
      _collisionName,
      _o.KeepDistance);
  }
};

public class CharacterCollisionT
{
  [Newtonsoft.Json.JsonProperty("shape_type")]
  private gfl.scene.fb.CollisionShapeData ShapeType {
    get {
      return this.Shape != null ? this.Shape.Type : gfl.scene.fb.CollisionShapeData.NONE;
    }
    set {
      this.Shape = new gfl.scene.fb.CollisionShapeDataUnion();
      this.Shape.Type = value;
    }
  }
  [Newtonsoft.Json.JsonProperty("shape")]
  [Newtonsoft.Json.JsonConverter(typeof(gfl.scene.fb.CollisionShapeDataUnion_JsonConverter))]
  public gfl.scene.fb.CollisionShapeDataUnion Shape { get; set; }
  [Newtonsoft.Json.JsonProperty("gravity")]
  public gfl.math.fb.Vector3fT Gravity { get; set; }
  [Newtonsoft.Json.JsonProperty("maxSlope")]
  public float MaxSlope { get; set; }
  [Newtonsoft.Json.JsonProperty("isControl")]
  public bool IsControl { get; set; }
  [Newtonsoft.Json.JsonProperty("moveSpeed")]
  public float MoveSpeed { get; set; }
  [Newtonsoft.Json.JsonProperty("startWithDisabled")]
  public bool StartWithDisabled { get; set; }
  [Newtonsoft.Json.JsonProperty("layer")]
  public int Layer { get; set; }
  [Newtonsoft.Json.JsonProperty("syncParentScaleEnabled")]
  public bool SyncParentScaleEnabled { get; set; }
  [Newtonsoft.Json.JsonProperty("collisionName")]
  public string CollisionName { get; set; }
  [Newtonsoft.Json.JsonProperty("keepDistance")]
  public float KeepDistance { get; set; }

  public CharacterCollisionT() {
    this.Shape = null;
    this.Gravity = new gfl.math.fb.Vector3fT();
    this.MaxSlope = 0.0f;
    this.IsControl = false;
    this.MoveSpeed = 0.0f;
    this.StartWithDisabled = false;
    this.Layer = 0;
    this.SyncParentScaleEnabled = false;
    this.CollisionName = null;
    this.KeepDistance = 0.0f;
  }
}

public struct CollisionComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static CollisionComponent GetRootAsCollisionComponent(ByteBuffer _bb) { return GetRootAsCollisionComponent(_bb, new CollisionComponent()); }
  public static CollisionComponent GetRootAsCollisionComponent(ByteBuffer _bb, CollisionComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CollisionComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.scene.fb.CollisionData DataType { get { int o = __p.__offset(4); return o != 0 ? (gfl.scene.fb.CollisionData)__p.bb.Get(o + __p.bb_pos) : gfl.scene.fb.CollisionData.NONE; } }
  public TTable? Data<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }

  public static Offset<gfl.scene.fb.CollisionComponent> CreateCollisionComponent(FlatBufferBuilder builder,
      gfl.scene.fb.CollisionData data_type = gfl.scene.fb.CollisionData.NONE,
      int dataOffset = 0) {
    builder.StartTable(2);
    CollisionComponent.AddData(builder, dataOffset);
    CollisionComponent.AddDataType(builder, data_type);
    return CollisionComponent.EndCollisionComponent(builder);
  }

  public static void StartCollisionComponent(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddDataType(FlatBufferBuilder builder, gfl.scene.fb.CollisionData dataType) { builder.AddByte(0, (byte)dataType, 0); }
  public static void AddData(FlatBufferBuilder builder, int dataOffset) { builder.AddOffset(1, dataOffset, 0); }
  public static Offset<gfl.scene.fb.CollisionComponent> EndCollisionComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.CollisionComponent>(o);
  }
  public static void FinishCollisionComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.CollisionComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedCollisionComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.CollisionComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public CollisionComponentT UnPack() {
    var _o = new CollisionComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CollisionComponentT _o) {
    _o.Data = new gfl.scene.fb.CollisionDataUnion();
    _o.Data.Type = this.DataType;
    switch (this.DataType) {
      default: break;
      case gfl.scene.fb.CollisionData.BodyCollision:
        _o.Data.Value = this.Data<gfl.scene.fb.BodyCollision>().HasValue ? this.Data<gfl.scene.fb.BodyCollision>().Value.UnPack() : null;
        break;
      case gfl.scene.fb.CollisionData.CharacterCollision:
        _o.Data.Value = this.Data<gfl.scene.fb.CharacterCollision>().HasValue ? this.Data<gfl.scene.fb.CharacterCollision>().Value.UnPack() : null;
        break;
    }
  }
  public static Offset<gfl.scene.fb.CollisionComponent> Pack(FlatBufferBuilder builder, CollisionComponentT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.CollisionComponent>);
    var _data_type = _o.Data == null ? gfl.scene.fb.CollisionData.NONE : _o.Data.Type;
    var _data = _o.Data == null ? 0 : gfl.scene.fb.CollisionDataUnion.Pack(builder, _o.Data);
    return CreateCollisionComponent(
      builder,
      _data_type,
      _data);
  }
};

public class CollisionComponentT
{
  [Newtonsoft.Json.JsonProperty("data_type")]
  private gfl.scene.fb.CollisionData DataType {
    get {
      return this.Data != null ? this.Data.Type : gfl.scene.fb.CollisionData.NONE;
    }
    set {
      this.Data = new gfl.scene.fb.CollisionDataUnion();
      this.Data.Type = value;
    }
  }
  [Newtonsoft.Json.JsonProperty("data")]
  [Newtonsoft.Json.JsonConverter(typeof(gfl.scene.fb.CollisionDataUnion_JsonConverter))]
  public gfl.scene.fb.CollisionDataUnion Data { get; set; }

  public CollisionComponentT() {
    this.Data = null;
  }

  public static CollisionComponentT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<CollisionComponentT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static CollisionComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return CollisionComponent.GetRootAsCollisionComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    CollisionComponent.FinishCollisionComponentBuffer(fbb, CollisionComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
