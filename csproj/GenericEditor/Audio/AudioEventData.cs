// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace GenericEditor.Plugin.Audio
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct AudioEventData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static AudioEventData GetRootAsAudioEventData(ByteBuffer _bb) { return GetRootAsAudioEventData(_bb, new AudioEventData()); }
  public static AudioEventData GetRootAsAudioEventData(ByteBuffer _bb, AudioEventData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AudioEventData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string EventName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEventNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetEventNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetEventNameArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<GenericEditor.Plugin.Audio.AudioEventData> CreateAudioEventData(FlatBufferBuilder builder,
      StringOffset eventNameOffset = default(StringOffset)) {
    builder.StartTable(1);
    AudioEventData.AddEventName(builder, eventNameOffset);
    return AudioEventData.EndAudioEventData(builder);
  }

  public static void StartAudioEventData(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset) { builder.AddOffset(0, eventNameOffset.Value, 0); }
  public static Offset<GenericEditor.Plugin.Audio.AudioEventData> EndAudioEventData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<GenericEditor.Plugin.Audio.AudioEventData>(o);
  }
  public static void FinishAudioEventDataBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Audio.AudioEventData> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedAudioEventDataBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Audio.AudioEventData> offset) { builder.FinishSizePrefixed(offset.Value); }
  public AudioEventDataT UnPack() {
    var _o = new AudioEventDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AudioEventDataT _o) {
    _o.EventName = this.EventName;
  }
  public static Offset<GenericEditor.Plugin.Audio.AudioEventData> Pack(FlatBufferBuilder builder, AudioEventDataT _o) {
    if (_o == null) return default(Offset<GenericEditor.Plugin.Audio.AudioEventData>);
    var _eventName = _o.EventName == null ? default(StringOffset) : builder.CreateString(_o.EventName);
    return CreateAudioEventData(
      builder,
      _eventName);
  }
};

public class AudioEventDataT
{
  [Newtonsoft.Json.JsonProperty("eventName")]
  public string EventName { get; set; }

  public AudioEventDataT() {
    this.EventName = null;
  }

  public static AudioEventDataT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<AudioEventDataT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static AudioEventDataT DeserializeFromBinary(byte[] fbBuffer) {
    return AudioEventData.GetRootAsAudioEventData(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    AudioEventData.FinishAudioEventDataBuffer(fbb, AudioEventData.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
