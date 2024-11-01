// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.audio.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct AudioJointComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static AudioJointComponent GetRootAsAudioJointComponent(ByteBuffer _bb) { return GetRootAsAudioJointComponent(_bb, new AudioJointComponent()); }
  public static AudioJointComponent GetRootAsAudioJointComponent(ByteBuffer _bb, AudioJointComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AudioJointComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string DefaultPartName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDefaultPartNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetDefaultPartNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetDefaultPartNameArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<gfl.audio.fb.AudioJointComponent> CreateAudioJointComponent(FlatBufferBuilder builder,
      StringOffset defaultPartNameOffset = default(StringOffset)) {
    builder.StartTable(1);
    AudioJointComponent.AddDefaultPartName(builder, defaultPartNameOffset);
    return AudioJointComponent.EndAudioJointComponent(builder);
  }

  public static void StartAudioJointComponent(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDefaultPartName(FlatBufferBuilder builder, StringOffset defaultPartNameOffset) { builder.AddOffset(0, defaultPartNameOffset.Value, 0); }
  public static Offset<gfl.audio.fb.AudioJointComponent> EndAudioJointComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.audio.fb.AudioJointComponent>(o);
  }
  public static void FinishAudioJointComponentBuffer(FlatBufferBuilder builder, Offset<gfl.audio.fb.AudioJointComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedAudioJointComponentBuffer(FlatBufferBuilder builder, Offset<gfl.audio.fb.AudioJointComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public AudioJointComponentT UnPack() {
    var _o = new AudioJointComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AudioJointComponentT _o) {
    _o.DefaultPartName = this.DefaultPartName;
  }
  public static Offset<gfl.audio.fb.AudioJointComponent> Pack(FlatBufferBuilder builder, AudioJointComponentT _o) {
    if (_o == null) return default(Offset<gfl.audio.fb.AudioJointComponent>);
    var _defaultPartName = _o.DefaultPartName == null ? default(StringOffset) : builder.CreateString(_o.DefaultPartName);
    return CreateAudioJointComponent(
      builder,
      _defaultPartName);
  }
};

public class AudioJointComponentT
{
  [Newtonsoft.Json.JsonProperty("defaultPartName")]
  public string DefaultPartName { get; set; }

  public AudioJointComponentT() {
    this.DefaultPartName = null;
  }

  public static AudioJointComponentT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<AudioJointComponentT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static AudioJointComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return AudioJointComponent.GetRootAsAudioJointComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    AudioJointComponent.FinishAudioJointComponentBuffer(fbb, AudioJointComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
