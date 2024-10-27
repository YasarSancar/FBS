// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.audio.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct AudioComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static AudioComponent GetRootAsAudioComponent(ByteBuffer _bb) { return GetRootAsAudioComponent(_bb, new AudioComponent()); }
  public static AudioComponent GetRootAsAudioComponent(ByteBuffer _bb, AudioComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AudioComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public bool ShouldUpdatePosition { get { int o = __p.__offset(4); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)true; } }
  public int UpdatePositionIntervalMin { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool StopOnDestroy { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)true; } }
  public int UpdatePositionIntervalMax { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float UpdatePositionMaxDistance { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool ShouldRegisterOnlyWhenActive { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<gfl.audio.fb.AudioComponent> CreateAudioComponent(FlatBufferBuilder builder,
      bool shouldUpdatePosition = true,
      int updatePositionIntervalMin = 0,
      bool stopOnDestroy = true,
      int updatePositionIntervalMax = 0,
      float updatePositionMaxDistance = 0.0f,
      bool shouldRegisterOnlyWhenActive = false) {
    builder.StartTable(6);
    AudioComponent.AddUpdatePositionMaxDistance(builder, updatePositionMaxDistance);
    AudioComponent.AddUpdatePositionIntervalMax(builder, updatePositionIntervalMax);
    AudioComponent.AddUpdatePositionIntervalMin(builder, updatePositionIntervalMin);
    AudioComponent.AddShouldRegisterOnlyWhenActive(builder, shouldRegisterOnlyWhenActive);
    AudioComponent.AddStopOnDestroy(builder, stopOnDestroy);
    AudioComponent.AddShouldUpdatePosition(builder, shouldUpdatePosition);
    return AudioComponent.EndAudioComponent(builder);
  }

  public static void StartAudioComponent(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddShouldUpdatePosition(FlatBufferBuilder builder, bool shouldUpdatePosition) { builder.AddBool(0, shouldUpdatePosition, true); }
  public static void AddUpdatePositionIntervalMin(FlatBufferBuilder builder, int updatePositionIntervalMin) { builder.AddInt(1, updatePositionIntervalMin, 0); }
  public static void AddStopOnDestroy(FlatBufferBuilder builder, bool stopOnDestroy) { builder.AddBool(2, stopOnDestroy, true); }
  public static void AddUpdatePositionIntervalMax(FlatBufferBuilder builder, int updatePositionIntervalMax) { builder.AddInt(3, updatePositionIntervalMax, 0); }
  public static void AddUpdatePositionMaxDistance(FlatBufferBuilder builder, float updatePositionMaxDistance) { builder.AddFloat(4, updatePositionMaxDistance, 0.0f); }
  public static void AddShouldRegisterOnlyWhenActive(FlatBufferBuilder builder, bool shouldRegisterOnlyWhenActive) { builder.AddBool(5, shouldRegisterOnlyWhenActive, false); }
  public static Offset<gfl.audio.fb.AudioComponent> EndAudioComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.audio.fb.AudioComponent>(o);
  }
  public static void FinishAudioComponentBuffer(FlatBufferBuilder builder, Offset<gfl.audio.fb.AudioComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedAudioComponentBuffer(FlatBufferBuilder builder, Offset<gfl.audio.fb.AudioComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public AudioComponentT UnPack() {
    var _o = new AudioComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AudioComponentT _o) {
    _o.ShouldUpdatePosition = this.ShouldUpdatePosition;
    _o.UpdatePositionIntervalMin = this.UpdatePositionIntervalMin;
    _o.StopOnDestroy = this.StopOnDestroy;
    _o.UpdatePositionIntervalMax = this.UpdatePositionIntervalMax;
    _o.UpdatePositionMaxDistance = this.UpdatePositionMaxDistance;
    _o.ShouldRegisterOnlyWhenActive = this.ShouldRegisterOnlyWhenActive;
  }
  public static Offset<gfl.audio.fb.AudioComponent> Pack(FlatBufferBuilder builder, AudioComponentT _o) {
    if (_o == null) return default(Offset<gfl.audio.fb.AudioComponent>);
    return CreateAudioComponent(
      builder,
      _o.ShouldUpdatePosition,
      _o.UpdatePositionIntervalMin,
      _o.StopOnDestroy,
      _o.UpdatePositionIntervalMax,
      _o.UpdatePositionMaxDistance,
      _o.ShouldRegisterOnlyWhenActive);
  }
};

public class AudioComponentT
{
  [Newtonsoft.Json.JsonProperty("shouldUpdatePosition")]
  public bool ShouldUpdatePosition { get; set; }
  [Newtonsoft.Json.JsonProperty("updatePositionIntervalMin")]
  public int UpdatePositionIntervalMin { get; set; }
  [Newtonsoft.Json.JsonProperty("stopOnDestroy")]
  public bool StopOnDestroy { get; set; }
  [Newtonsoft.Json.JsonProperty("updatePositionIntervalMax")]
  public int UpdatePositionIntervalMax { get; set; }
  [Newtonsoft.Json.JsonProperty("updatePositionMaxDistance")]
  public float UpdatePositionMaxDistance { get; set; }
  [Newtonsoft.Json.JsonProperty("shouldRegisterOnlyWhenActive")]
  public bool ShouldRegisterOnlyWhenActive { get; set; }

  public AudioComponentT() {
    this.ShouldUpdatePosition = true;
    this.UpdatePositionIntervalMin = 0;
    this.StopOnDestroy = true;
    this.UpdatePositionIntervalMax = 0;
    this.UpdatePositionMaxDistance = 0.0f;
    this.ShouldRegisterOnlyWhenActive = false;
  }

  public static AudioComponentT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<AudioComponentT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static AudioComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return AudioComponent.GetRootAsAudioComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    AudioComponent.FinishAudioComponentBuffer(fbb, AudioComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
