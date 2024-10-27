// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum EventStateTriggerTiming : int
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

public struct EventStateEventTriggerComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static EventStateEventTriggerComponent GetRootAsEventStateEventTriggerComponent(ByteBuffer _bb) { return GetRootAsEventStateEventTriggerComponent(_bb, new EventStateEventTriggerComponent()); }
  public static EventStateEventTriggerComponent GetRootAsEventStateEventTriggerComponent(ByteBuffer _bb, EventStateEventTriggerComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventStateEventTriggerComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string EventName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEventNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetEventNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetEventNameArray() { return __p.__vector_as_array<byte>(4); }
  public string EventStateName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEventStateNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetEventStateNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetEventStateNameArray() { return __p.__vector_as_array<byte>(6); }
  public string ResourceName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetResourceNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetResourceNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetResourceNameArray() { return __p.__vector_as_array<byte>(8); }
  public gfl.scene.fb.EventStateTriggerTiming TriggerTiming { get { int o = __p.__offset(10); return o != 0 ? (gfl.scene.fb.EventStateTriggerTiming)__p.bb.GetInt(o + __p.bb_pos) : gfl.scene.fb.EventStateTriggerTiming.Is; } }

  public static Offset<gfl.scene.fb.EventStateEventTriggerComponent> CreateEventStateEventTriggerComponent(FlatBufferBuilder builder,
      StringOffset eventNameOffset = default(StringOffset),
      StringOffset eventStateNameOffset = default(StringOffset),
      StringOffset resourceNameOffset = default(StringOffset),
      gfl.scene.fb.EventStateTriggerTiming triggerTiming = gfl.scene.fb.EventStateTriggerTiming.Is) {
    builder.StartTable(4);
    EventStateEventTriggerComponent.AddTriggerTiming(builder, triggerTiming);
    EventStateEventTriggerComponent.AddResourceName(builder, resourceNameOffset);
    EventStateEventTriggerComponent.AddEventStateName(builder, eventStateNameOffset);
    EventStateEventTriggerComponent.AddEventName(builder, eventNameOffset);
    return EventStateEventTriggerComponent.EndEventStateEventTriggerComponent(builder);
  }

  public static void StartEventStateEventTriggerComponent(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset) { builder.AddOffset(0, eventNameOffset.Value, 0); }
  public static void AddEventStateName(FlatBufferBuilder builder, StringOffset eventStateNameOffset) { builder.AddOffset(1, eventStateNameOffset.Value, 0); }
  public static void AddResourceName(FlatBufferBuilder builder, StringOffset resourceNameOffset) { builder.AddOffset(2, resourceNameOffset.Value, 0); }
  public static void AddTriggerTiming(FlatBufferBuilder builder, gfl.scene.fb.EventStateTriggerTiming triggerTiming) { builder.AddInt(3, (int)triggerTiming, 0); }
  public static Offset<gfl.scene.fb.EventStateEventTriggerComponent> EndEventStateEventTriggerComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.EventStateEventTriggerComponent>(o);
  }
  public static void FinishEventStateEventTriggerComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.EventStateEventTriggerComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedEventStateEventTriggerComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.EventStateEventTriggerComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public EventStateEventTriggerComponentT UnPack() {
    var _o = new EventStateEventTriggerComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventStateEventTriggerComponentT _o) {
    _o.EventName = this.EventName;
    _o.EventStateName = this.EventStateName;
    _o.ResourceName = this.ResourceName;
    _o.TriggerTiming = this.TriggerTiming;
  }
  public static Offset<gfl.scene.fb.EventStateEventTriggerComponent> Pack(FlatBufferBuilder builder, EventStateEventTriggerComponentT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.EventStateEventTriggerComponent>);
    var _eventName = _o.EventName == null ? default(StringOffset) : builder.CreateString(_o.EventName);
    var _eventStateName = _o.EventStateName == null ? default(StringOffset) : builder.CreateString(_o.EventStateName);
    var _resourceName = _o.ResourceName == null ? default(StringOffset) : builder.CreateString(_o.ResourceName);
    return CreateEventStateEventTriggerComponent(
      builder,
      _eventName,
      _eventStateName,
      _resourceName,
      _o.TriggerTiming);
  }
};

public class EventStateEventTriggerComponentT
{
  [Newtonsoft.Json.JsonProperty("eventName")]
  public string EventName { get; set; }
  [Newtonsoft.Json.JsonProperty("eventStateName")]
  public string EventStateName { get; set; }
  [Newtonsoft.Json.JsonProperty("resourceName")]
  public string ResourceName { get; set; }
  [Newtonsoft.Json.JsonProperty("triggerTiming")]
  public gfl.scene.fb.EventStateTriggerTiming TriggerTiming { get; set; }

  public EventStateEventTriggerComponentT() {
    this.EventName = null;
    this.EventStateName = null;
    this.ResourceName = null;
    this.TriggerTiming = gfl.scene.fb.EventStateTriggerTiming.Is;
  }

  public static EventStateEventTriggerComponentT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<EventStateEventTriggerComponentT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static EventStateEventTriggerComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return EventStateEventTriggerComponent.GetRootAsEventStateEventTriggerComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    EventStateEventTriggerComponent.FinishEventStateEventTriggerComponentBuffer(fbb, EventStateEventTriggerComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}