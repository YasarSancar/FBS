// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum CollisionEventType : int
{
  Trigger = 0,
  Manifold = 1,
  ContactImpulse = 2,
};

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum CollisionTriggerTiming : int
{
  Is = 0,
  Was = 1,
  Trigger = 2,
  Release = 3,
  Both = 4,
  Any = 5,
  XOR = 6,
  Not = 7,
  Always = 8,
};

public struct CollisionEventTriggerComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static CollisionEventTriggerComponent GetRootAsCollisionEventTriggerComponent(ByteBuffer _bb) { return GetRootAsCollisionEventTriggerComponent(_bb, new CollisionEventTriggerComponent()); }
  public static CollisionEventTriggerComponent GetRootAsCollisionEventTriggerComponent(ByteBuffer _bb, CollisionEventTriggerComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CollisionEventTriggerComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string SceneObject { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSceneObjectBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetSceneObjectBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetSceneObjectArray() { return __p.__vector_as_array<byte>(4); }
  public string ResourceName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetResourceNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetResourceNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetResourceNameArray() { return __p.__vector_as_array<byte>(6); }
  public gfl.scene.fb.CollisionEventType EventType { get { int o = __p.__offset(8); return o != 0 ? (gfl.scene.fb.CollisionEventType)__p.bb.GetInt(o + __p.bb_pos) : gfl.scene.fb.CollisionEventType.Trigger; } }
  public gfl.scene.fb.CollisionTriggerTiming TriggerTiming { get { int o = __p.__offset(10); return o != 0 ? (gfl.scene.fb.CollisionTriggerTiming)__p.bb.GetInt(o + __p.bb_pos) : gfl.scene.fb.CollisionTriggerTiming.Is; } }
  public string TriggerName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTriggerNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetTriggerNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetTriggerNameArray() { return __p.__vector_as_array<byte>(12); }
  public string EventNames(int j) { int o = __p.__offset(14); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int EventNamesLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<gfl.scene.fb.CollisionEventTriggerComponent> CreateCollisionEventTriggerComponent(FlatBufferBuilder builder,
      StringOffset sceneObjectOffset = default(StringOffset),
      StringOffset resourceNameOffset = default(StringOffset),
      gfl.scene.fb.CollisionEventType eventType = gfl.scene.fb.CollisionEventType.Trigger,
      gfl.scene.fb.CollisionTriggerTiming triggerTiming = gfl.scene.fb.CollisionTriggerTiming.Is,
      StringOffset triggerNameOffset = default(StringOffset),
      VectorOffset eventNamesOffset = default(VectorOffset)) {
    builder.StartTable(6);
    CollisionEventTriggerComponent.AddEventNames(builder, eventNamesOffset);
    CollisionEventTriggerComponent.AddTriggerName(builder, triggerNameOffset);
    CollisionEventTriggerComponent.AddTriggerTiming(builder, triggerTiming);
    CollisionEventTriggerComponent.AddEventType(builder, eventType);
    CollisionEventTriggerComponent.AddResourceName(builder, resourceNameOffset);
    CollisionEventTriggerComponent.AddSceneObject(builder, sceneObjectOffset);
    return CollisionEventTriggerComponent.EndCollisionEventTriggerComponent(builder);
  }

  public static void StartCollisionEventTriggerComponent(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddSceneObject(FlatBufferBuilder builder, StringOffset sceneObjectOffset) { builder.AddOffset(0, sceneObjectOffset.Value, 0); }
  public static void AddResourceName(FlatBufferBuilder builder, StringOffset resourceNameOffset) { builder.AddOffset(1, resourceNameOffset.Value, 0); }
  public static void AddEventType(FlatBufferBuilder builder, gfl.scene.fb.CollisionEventType eventType) { builder.AddInt(2, (int)eventType, 0); }
  public static void AddTriggerTiming(FlatBufferBuilder builder, gfl.scene.fb.CollisionTriggerTiming triggerTiming) { builder.AddInt(3, (int)triggerTiming, 0); }
  public static void AddTriggerName(FlatBufferBuilder builder, StringOffset triggerNameOffset) { builder.AddOffset(4, triggerNameOffset.Value, 0); }
  public static void AddEventNames(FlatBufferBuilder builder, VectorOffset eventNamesOffset) { builder.AddOffset(5, eventNamesOffset.Value, 0); }
  public static VectorOffset CreateEventNamesVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateEventNamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartEventNamesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<gfl.scene.fb.CollisionEventTriggerComponent> EndCollisionEventTriggerComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.CollisionEventTriggerComponent>(o);
  }
  public static void FinishCollisionEventTriggerComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.CollisionEventTriggerComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedCollisionEventTriggerComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.CollisionEventTriggerComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public CollisionEventTriggerComponentT UnPack() {
    var _o = new CollisionEventTriggerComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CollisionEventTriggerComponentT _o) {
    _o.SceneObject = this.SceneObject;
    _o.ResourceName = this.ResourceName;
    _o.EventType = this.EventType;
    _o.TriggerTiming = this.TriggerTiming;
    _o.TriggerName = this.TriggerName;
    _o.EventNames = new List<string>();
    for (var _j = 0; _j < this.EventNamesLength; ++_j) {_o.EventNames.Add(this.EventNames(_j));}
  }
  public static Offset<gfl.scene.fb.CollisionEventTriggerComponent> Pack(FlatBufferBuilder builder, CollisionEventTriggerComponentT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.CollisionEventTriggerComponent>);
    var _sceneObject = _o.SceneObject == null ? default(StringOffset) : builder.CreateString(_o.SceneObject);
    var _resourceName = _o.ResourceName == null ? default(StringOffset) : builder.CreateString(_o.ResourceName);
    var _triggerName = _o.TriggerName == null ? default(StringOffset) : builder.CreateString(_o.TriggerName);
    var _eventNames = default(VectorOffset);
    if (_o.EventNames != null) {
      var __eventNames = new StringOffset[_o.EventNames.Count];
      for (var _j = 0; _j < __eventNames.Length; ++_j) { __eventNames[_j] = builder.CreateString(_o.EventNames[_j]); }
      _eventNames = CreateEventNamesVector(builder, __eventNames);
    }
    return CreateCollisionEventTriggerComponent(
      builder,
      _sceneObject,
      _resourceName,
      _o.EventType,
      _o.TriggerTiming,
      _triggerName,
      _eventNames);
  }
};

public class CollisionEventTriggerComponentT
{
  [Newtonsoft.Json.JsonProperty("sceneObject")]
  public string SceneObject { get; set; }
  [Newtonsoft.Json.JsonProperty("resourceName")]
  public string ResourceName { get; set; }
  [Newtonsoft.Json.JsonProperty("eventType")]
  public gfl.scene.fb.CollisionEventType EventType { get; set; }
  [Newtonsoft.Json.JsonProperty("triggerTiming")]
  public gfl.scene.fb.CollisionTriggerTiming TriggerTiming { get; set; }
  [Newtonsoft.Json.JsonProperty("triggerName")]
  public string TriggerName { get; set; }
  [Newtonsoft.Json.JsonProperty("eventNames")]
  public List<string> EventNames { get; set; }

  public CollisionEventTriggerComponentT() {
    this.SceneObject = null;
    this.ResourceName = null;
    this.EventType = gfl.scene.fb.CollisionEventType.Trigger;
    this.TriggerTiming = gfl.scene.fb.CollisionTriggerTiming.Is;
    this.TriggerName = null;
    this.EventNames = null;
  }

  public static CollisionEventTriggerComponentT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<CollisionEventTriggerComponentT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static CollisionEventTriggerComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return CollisionEventTriggerComponent.GetRootAsCollisionEventTriggerComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    CollisionEventTriggerComponent.FinishCollisionEventTriggerComponentBuffer(fbb, CollisionEventTriggerComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}