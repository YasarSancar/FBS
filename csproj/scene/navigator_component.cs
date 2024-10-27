// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct NavigatorComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static NavigatorComponent GetRootAsNavigatorComponent(ByteBuffer _bb) { return GetRootAsNavigatorComponent(_bb, new NavigatorComponent()); }
  public static NavigatorComponent GetRootAsNavigatorComponent(ByteBuffer _bb, NavigatorComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public NavigatorComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string InstanceName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInstanceNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetInstanceNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetInstanceNameArray() { return __p.__vector_as_array<byte>(4); }
  public float NavigatorRadius { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float NavigatorSearchRadius { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float NavigatorVerticalTolerance { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float NavigatorHorizontalTolerance { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float AvoidanceCharacterMaximumSpeed { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float AvoidanceCharacterPreferredSpeed { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float AvoidanceCharacterRadius { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float AvoidanceSensorTopExtent { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float AvoidanceSensorBottomExtent { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float AvoidanceSensorHalfWidth { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float SteeringPropertiesWallFollowingAngle { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float SteeringPropertiesDodgingPenalty { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float SteeringPropertiesCollisionPenalty { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float SteeringPropertiesPenetrationPenalty { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float SteeringPropertiesWeight { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int SteeringPropertiesPriority { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<gfl.scene.fb.NavigatorComponent> CreateNavigatorComponent(FlatBufferBuilder builder,
      StringOffset instanceNameOffset = default(StringOffset),
      float navigatorRadius = 0.0f,
      float navigatorSearchRadius = 0.0f,
      float navigatorVerticalTolerance = 0.0f,
      float navigatorHorizontalTolerance = 0.0f,
      float avoidanceCharacterMaximumSpeed = 0.0f,
      float avoidanceCharacterPreferredSpeed = 0.0f,
      float avoidanceCharacterRadius = 0.0f,
      float avoidanceSensorTopExtent = 0.0f,
      float avoidanceSensorBottomExtent = 0.0f,
      float avoidanceSensorHalfWidth = 0.0f,
      float steeringPropertiesWallFollowingAngle = 0.0f,
      float steeringPropertiesDodgingPenalty = 0.0f,
      float steeringPropertiesCollisionPenalty = 0.0f,
      float steeringPropertiesPenetrationPenalty = 0.0f,
      float steeringPropertiesWeight = 0.0f,
      int steeringPropertiesPriority = 0) {
    builder.StartTable(17);
    NavigatorComponent.AddSteeringPropertiesPriority(builder, steeringPropertiesPriority);
    NavigatorComponent.AddSteeringPropertiesWeight(builder, steeringPropertiesWeight);
    NavigatorComponent.AddSteeringPropertiesPenetrationPenalty(builder, steeringPropertiesPenetrationPenalty);
    NavigatorComponent.AddSteeringPropertiesCollisionPenalty(builder, steeringPropertiesCollisionPenalty);
    NavigatorComponent.AddSteeringPropertiesDodgingPenalty(builder, steeringPropertiesDodgingPenalty);
    NavigatorComponent.AddSteeringPropertiesWallFollowingAngle(builder, steeringPropertiesWallFollowingAngle);
    NavigatorComponent.AddAvoidanceSensorHalfWidth(builder, avoidanceSensorHalfWidth);
    NavigatorComponent.AddAvoidanceSensorBottomExtent(builder, avoidanceSensorBottomExtent);
    NavigatorComponent.AddAvoidanceSensorTopExtent(builder, avoidanceSensorTopExtent);
    NavigatorComponent.AddAvoidanceCharacterRadius(builder, avoidanceCharacterRadius);
    NavigatorComponent.AddAvoidanceCharacterPreferredSpeed(builder, avoidanceCharacterPreferredSpeed);
    NavigatorComponent.AddAvoidanceCharacterMaximumSpeed(builder, avoidanceCharacterMaximumSpeed);
    NavigatorComponent.AddNavigatorHorizontalTolerance(builder, navigatorHorizontalTolerance);
    NavigatorComponent.AddNavigatorVerticalTolerance(builder, navigatorVerticalTolerance);
    NavigatorComponent.AddNavigatorSearchRadius(builder, navigatorSearchRadius);
    NavigatorComponent.AddNavigatorRadius(builder, navigatorRadius);
    NavigatorComponent.AddInstanceName(builder, instanceNameOffset);
    return NavigatorComponent.EndNavigatorComponent(builder);
  }

  public static void StartNavigatorComponent(FlatBufferBuilder builder) { builder.StartTable(17); }
  public static void AddInstanceName(FlatBufferBuilder builder, StringOffset instanceNameOffset) { builder.AddOffset(0, instanceNameOffset.Value, 0); }
  public static void AddNavigatorRadius(FlatBufferBuilder builder, float navigatorRadius) { builder.AddFloat(1, navigatorRadius, 0.0f); }
  public static void AddNavigatorSearchRadius(FlatBufferBuilder builder, float navigatorSearchRadius) { builder.AddFloat(2, navigatorSearchRadius, 0.0f); }
  public static void AddNavigatorVerticalTolerance(FlatBufferBuilder builder, float navigatorVerticalTolerance) { builder.AddFloat(3, navigatorVerticalTolerance, 0.0f); }
  public static void AddNavigatorHorizontalTolerance(FlatBufferBuilder builder, float navigatorHorizontalTolerance) { builder.AddFloat(4, navigatorHorizontalTolerance, 0.0f); }
  public static void AddAvoidanceCharacterMaximumSpeed(FlatBufferBuilder builder, float avoidanceCharacterMaximumSpeed) { builder.AddFloat(5, avoidanceCharacterMaximumSpeed, 0.0f); }
  public static void AddAvoidanceCharacterPreferredSpeed(FlatBufferBuilder builder, float avoidanceCharacterPreferredSpeed) { builder.AddFloat(6, avoidanceCharacterPreferredSpeed, 0.0f); }
  public static void AddAvoidanceCharacterRadius(FlatBufferBuilder builder, float avoidanceCharacterRadius) { builder.AddFloat(7, avoidanceCharacterRadius, 0.0f); }
  public static void AddAvoidanceSensorTopExtent(FlatBufferBuilder builder, float avoidanceSensorTopExtent) { builder.AddFloat(8, avoidanceSensorTopExtent, 0.0f); }
  public static void AddAvoidanceSensorBottomExtent(FlatBufferBuilder builder, float avoidanceSensorBottomExtent) { builder.AddFloat(9, avoidanceSensorBottomExtent, 0.0f); }
  public static void AddAvoidanceSensorHalfWidth(FlatBufferBuilder builder, float avoidanceSensorHalfWidth) { builder.AddFloat(10, avoidanceSensorHalfWidth, 0.0f); }
  public static void AddSteeringPropertiesWallFollowingAngle(FlatBufferBuilder builder, float steeringPropertiesWallFollowingAngle) { builder.AddFloat(11, steeringPropertiesWallFollowingAngle, 0.0f); }
  public static void AddSteeringPropertiesDodgingPenalty(FlatBufferBuilder builder, float steeringPropertiesDodgingPenalty) { builder.AddFloat(12, steeringPropertiesDodgingPenalty, 0.0f); }
  public static void AddSteeringPropertiesCollisionPenalty(FlatBufferBuilder builder, float steeringPropertiesCollisionPenalty) { builder.AddFloat(13, steeringPropertiesCollisionPenalty, 0.0f); }
  public static void AddSteeringPropertiesPenetrationPenalty(FlatBufferBuilder builder, float steeringPropertiesPenetrationPenalty) { builder.AddFloat(14, steeringPropertiesPenetrationPenalty, 0.0f); }
  public static void AddSteeringPropertiesWeight(FlatBufferBuilder builder, float steeringPropertiesWeight) { builder.AddFloat(15, steeringPropertiesWeight, 0.0f); }
  public static void AddSteeringPropertiesPriority(FlatBufferBuilder builder, int steeringPropertiesPriority) { builder.AddInt(16, steeringPropertiesPriority, 0); }
  public static Offset<gfl.scene.fb.NavigatorComponent> EndNavigatorComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.NavigatorComponent>(o);
  }
  public static void FinishNavigatorComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.NavigatorComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedNavigatorComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.NavigatorComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public NavigatorComponentT UnPack() {
    var _o = new NavigatorComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(NavigatorComponentT _o) {
    _o.InstanceName = this.InstanceName;
    _o.NavigatorRadius = this.NavigatorRadius;
    _o.NavigatorSearchRadius = this.NavigatorSearchRadius;
    _o.NavigatorVerticalTolerance = this.NavigatorVerticalTolerance;
    _o.NavigatorHorizontalTolerance = this.NavigatorHorizontalTolerance;
    _o.AvoidanceCharacterMaximumSpeed = this.AvoidanceCharacterMaximumSpeed;
    _o.AvoidanceCharacterPreferredSpeed = this.AvoidanceCharacterPreferredSpeed;
    _o.AvoidanceCharacterRadius = this.AvoidanceCharacterRadius;
    _o.AvoidanceSensorTopExtent = this.AvoidanceSensorTopExtent;
    _o.AvoidanceSensorBottomExtent = this.AvoidanceSensorBottomExtent;
    _o.AvoidanceSensorHalfWidth = this.AvoidanceSensorHalfWidth;
    _o.SteeringPropertiesWallFollowingAngle = this.SteeringPropertiesWallFollowingAngle;
    _o.SteeringPropertiesDodgingPenalty = this.SteeringPropertiesDodgingPenalty;
    _o.SteeringPropertiesCollisionPenalty = this.SteeringPropertiesCollisionPenalty;
    _o.SteeringPropertiesPenetrationPenalty = this.SteeringPropertiesPenetrationPenalty;
    _o.SteeringPropertiesWeight = this.SteeringPropertiesWeight;
    _o.SteeringPropertiesPriority = this.SteeringPropertiesPriority;
  }
  public static Offset<gfl.scene.fb.NavigatorComponent> Pack(FlatBufferBuilder builder, NavigatorComponentT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.NavigatorComponent>);
    var _instanceName = _o.InstanceName == null ? default(StringOffset) : builder.CreateString(_o.InstanceName);
    return CreateNavigatorComponent(
      builder,
      _instanceName,
      _o.NavigatorRadius,
      _o.NavigatorSearchRadius,
      _o.NavigatorVerticalTolerance,
      _o.NavigatorHorizontalTolerance,
      _o.AvoidanceCharacterMaximumSpeed,
      _o.AvoidanceCharacterPreferredSpeed,
      _o.AvoidanceCharacterRadius,
      _o.AvoidanceSensorTopExtent,
      _o.AvoidanceSensorBottomExtent,
      _o.AvoidanceSensorHalfWidth,
      _o.SteeringPropertiesWallFollowingAngle,
      _o.SteeringPropertiesDodgingPenalty,
      _o.SteeringPropertiesCollisionPenalty,
      _o.SteeringPropertiesPenetrationPenalty,
      _o.SteeringPropertiesWeight,
      _o.SteeringPropertiesPriority);
  }
};

public class NavigatorComponentT
{
  [Newtonsoft.Json.JsonProperty("instanceName")]
  public string InstanceName { get; set; }
  [Newtonsoft.Json.JsonProperty("navigatorRadius")]
  public float NavigatorRadius { get; set; }
  [Newtonsoft.Json.JsonProperty("navigatorSearchRadius")]
  public float NavigatorSearchRadius { get; set; }
  [Newtonsoft.Json.JsonProperty("navigatorVerticalTolerance")]
  public float NavigatorVerticalTolerance { get; set; }
  [Newtonsoft.Json.JsonProperty("navigatorHorizontalTolerance")]
  public float NavigatorHorizontalTolerance { get; set; }
  [Newtonsoft.Json.JsonProperty("avoidanceCharacterMaximumSpeed")]
  public float AvoidanceCharacterMaximumSpeed { get; set; }
  [Newtonsoft.Json.JsonProperty("avoidanceCharacterPreferredSpeed")]
  public float AvoidanceCharacterPreferredSpeed { get; set; }
  [Newtonsoft.Json.JsonProperty("avoidanceCharacterRadius")]
  public float AvoidanceCharacterRadius { get; set; }
  [Newtonsoft.Json.JsonProperty("avoidanceSensorTopExtent")]
  public float AvoidanceSensorTopExtent { get; set; }
  [Newtonsoft.Json.JsonProperty("avoidanceSensorBottomExtent")]
  public float AvoidanceSensorBottomExtent { get; set; }
  [Newtonsoft.Json.JsonProperty("avoidanceSensorHalfWidth")]
  public float AvoidanceSensorHalfWidth { get; set; }
  [Newtonsoft.Json.JsonProperty("steeringPropertiesWallFollowingAngle")]
  public float SteeringPropertiesWallFollowingAngle { get; set; }
  [Newtonsoft.Json.JsonProperty("steeringPropertiesDodgingPenalty")]
  public float SteeringPropertiesDodgingPenalty { get; set; }
  [Newtonsoft.Json.JsonProperty("steeringPropertiesCollisionPenalty")]
  public float SteeringPropertiesCollisionPenalty { get; set; }
  [Newtonsoft.Json.JsonProperty("steeringPropertiesPenetrationPenalty")]
  public float SteeringPropertiesPenetrationPenalty { get; set; }
  [Newtonsoft.Json.JsonProperty("steeringPropertiesWeight")]
  public float SteeringPropertiesWeight { get; set; }
  [Newtonsoft.Json.JsonProperty("steeringPropertiesPriority")]
  public int SteeringPropertiesPriority { get; set; }

  public NavigatorComponentT() {
    this.InstanceName = null;
    this.NavigatorRadius = 0.0f;
    this.NavigatorSearchRadius = 0.0f;
    this.NavigatorVerticalTolerance = 0.0f;
    this.NavigatorHorizontalTolerance = 0.0f;
    this.AvoidanceCharacterMaximumSpeed = 0.0f;
    this.AvoidanceCharacterPreferredSpeed = 0.0f;
    this.AvoidanceCharacterRadius = 0.0f;
    this.AvoidanceSensorTopExtent = 0.0f;
    this.AvoidanceSensorBottomExtent = 0.0f;
    this.AvoidanceSensorHalfWidth = 0.0f;
    this.SteeringPropertiesWallFollowingAngle = 0.0f;
    this.SteeringPropertiesDodgingPenalty = 0.0f;
    this.SteeringPropertiesCollisionPenalty = 0.0f;
    this.SteeringPropertiesPenetrationPenalty = 0.0f;
    this.SteeringPropertiesWeight = 0.0f;
    this.SteeringPropertiesPriority = 0;
  }

  public static NavigatorComponentT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<NavigatorComponentT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static NavigatorComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return NavigatorComponent.GetRootAsNavigatorComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    NavigatorComponent.FinishNavigatorComponentBuffer(fbb, NavigatorComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}