// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.anm2.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct TrackData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static TrackData GetRootAsTrackData(ByteBuffer _bb) { return GetRootAsTrackData(_bb, new TrackData()); }
  public static TrackData GetRootAsTrackData(ByteBuffer _bb, TrackData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TrackData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public string Path { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPathBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetPathBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetPathArray() { return __p.__vector_as_array<byte>(6); }
  public string TemplateName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTemplateNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetTemplateNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetTemplateNameArray() { return __p.__vector_as_array<byte>(8); }

  public static Offset<gfl.anm2.fb.TrackData> CreateTrackData(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      StringOffset pathOffset = default(StringOffset),
      StringOffset templateNameOffset = default(StringOffset)) {
    builder.StartTable(3);
    TrackData.AddTemplateName(builder, templateNameOffset);
    TrackData.AddPath(builder, pathOffset);
    TrackData.AddName(builder, nameOffset);
    return TrackData.EndTrackData(builder);
  }

  public static void StartTrackData(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset) { builder.AddOffset(1, pathOffset.Value, 0); }
  public static void AddTemplateName(FlatBufferBuilder builder, StringOffset templateNameOffset) { builder.AddOffset(2, templateNameOffset.Value, 0); }
  public static Offset<gfl.anm2.fb.TrackData> EndTrackData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.TrackData>(o);
  }
  public TrackDataT UnPack() {
    var _o = new TrackDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TrackDataT _o) {
    _o.Name = this.Name;
    _o.Path = this.Path;
    _o.TemplateName = this.TemplateName;
  }
  public static Offset<gfl.anm2.fb.TrackData> Pack(FlatBufferBuilder builder, TrackDataT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.TrackData>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _path = _o.Path == null ? default(StringOffset) : builder.CreateString(_o.Path);
    var _templateName = _o.TemplateName == null ? default(StringOffset) : builder.CreateString(_o.TemplateName);
    return CreateTrackData(
      builder,
      _name,
      _path,
      _templateName);
  }
};

public class TrackDataT
{
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("path")]
  public string Path { get; set; }
  [Newtonsoft.Json.JsonProperty("templateName")]
  public string TemplateName { get; set; }

  public TrackDataT() {
    this.Name = null;
    this.Path = null;
    this.TemplateName = null;
  }
}

public struct AnimationEventData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static AnimationEventData GetRootAsAnimationEventData(ByteBuffer _bb) { return GetRootAsAnimationEventData(_bb, new AnimationEventData()); }
  public static AnimationEventData GetRootAsAnimationEventData(ByteBuffer _bb, AnimationEventData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AnimationEventData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.anm2.fb.EventData? Events(int j) { int o = __p.__offset(4); return o != 0 ? (gfl.anm2.fb.EventData?)(new gfl.anm2.fb.EventData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int EventsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public gfl.anm2.fb.TrackData? Tracks(int j) { int o = __p.__offset(6); return o != 0 ? (gfl.anm2.fb.TrackData?)(new gfl.anm2.fb.TrackData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int TracksLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<gfl.anm2.fb.AnimationEventData> CreateAnimationEventData(FlatBufferBuilder builder,
      VectorOffset eventsOffset = default(VectorOffset),
      VectorOffset tracksOffset = default(VectorOffset)) {
    builder.StartTable(2);
    AnimationEventData.AddTracks(builder, tracksOffset);
    AnimationEventData.AddEvents(builder, eventsOffset);
    return AnimationEventData.EndAnimationEventData(builder);
  }

  public static void StartAnimationEventData(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddEvents(FlatBufferBuilder builder, VectorOffset eventsOffset) { builder.AddOffset(0, eventsOffset.Value, 0); }
  public static VectorOffset CreateEventsVector(FlatBufferBuilder builder, Offset<gfl.anm2.fb.EventData>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateEventsVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fb.EventData>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartEventsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTracks(FlatBufferBuilder builder, VectorOffset tracksOffset) { builder.AddOffset(1, tracksOffset.Value, 0); }
  public static VectorOffset CreateTracksVector(FlatBufferBuilder builder, Offset<gfl.anm2.fb.TrackData>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateTracksVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fb.TrackData>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartTracksVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<gfl.anm2.fb.AnimationEventData> EndAnimationEventData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.AnimationEventData>(o);
  }
  public static void FinishAnimationEventDataBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fb.AnimationEventData> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedAnimationEventDataBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fb.AnimationEventData> offset) { builder.FinishSizePrefixed(offset.Value); }
  public AnimationEventDataT UnPack() {
    var _o = new AnimationEventDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AnimationEventDataT _o) {
    _o.Events = new List<gfl.anm2.fb.EventDataT>();
    for (var _j = 0; _j < this.EventsLength; ++_j) {_o.Events.Add(this.Events(_j).HasValue ? this.Events(_j).Value.UnPack() : null);}
    _o.Tracks = new List<gfl.anm2.fb.TrackDataT>();
    for (var _j = 0; _j < this.TracksLength; ++_j) {_o.Tracks.Add(this.Tracks(_j).HasValue ? this.Tracks(_j).Value.UnPack() : null);}
  }
  public static Offset<gfl.anm2.fb.AnimationEventData> Pack(FlatBufferBuilder builder, AnimationEventDataT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.AnimationEventData>);
    var _events = default(VectorOffset);
    if (_o.Events != null) {
      var __events = new Offset<gfl.anm2.fb.EventData>[_o.Events.Count];
      for (var _j = 0; _j < __events.Length; ++_j) { __events[_j] = gfl.anm2.fb.EventData.Pack(builder, _o.Events[_j]); }
      _events = CreateEventsVector(builder, __events);
    }
    var _tracks = default(VectorOffset);
    if (_o.Tracks != null) {
      var __tracks = new Offset<gfl.anm2.fb.TrackData>[_o.Tracks.Count];
      for (var _j = 0; _j < __tracks.Length; ++_j) { __tracks[_j] = gfl.anm2.fb.TrackData.Pack(builder, _o.Tracks[_j]); }
      _tracks = CreateTracksVector(builder, __tracks);
    }
    return CreateAnimationEventData(
      builder,
      _events,
      _tracks);
  }
};

public class AnimationEventDataT
{
  [Newtonsoft.Json.JsonProperty("events")]
  public List<gfl.anm2.fb.EventDataT> Events { get; set; }
  [Newtonsoft.Json.JsonProperty("tracks")]
  public List<gfl.anm2.fb.TrackDataT> Tracks { get; set; }

  public AnimationEventDataT() {
    this.Events = null;
    this.Tracks = null;
  }

  public static AnimationEventDataT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<AnimationEventDataT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static AnimationEventDataT DeserializeFromBinary(byte[] fbBuffer) {
    return AnimationEventData.GetRootAsAnimationEventData(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    AnimationEventData.FinishAnimationEventDataBuffer(fbb, AnimationEventData.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}