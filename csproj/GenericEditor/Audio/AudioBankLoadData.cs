// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace GenericEditor.Plugin.Audio
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct AudioBankLoadData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static AudioBankLoadData GetRootAsAudioBankLoadData(ByteBuffer _bb) { return GetRootAsAudioBankLoadData(_bb, new AudioBankLoadData()); }
  public static AudioBankLoadData GetRootAsAudioBankLoadData(ByteBuffer _bb, AudioBankLoadData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AudioBankLoadData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string BankName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBankNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetBankNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetBankNameArray() { return __p.__vector_as_array<byte>(4); }
  public bool Load { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<GenericEditor.Plugin.Audio.AudioBankLoadData> CreateAudioBankLoadData(FlatBufferBuilder builder,
      StringOffset bankNameOffset = default(StringOffset),
      bool load = false) {
    builder.StartTable(2);
    AudioBankLoadData.AddBankName(builder, bankNameOffset);
    AudioBankLoadData.AddLoad(builder, load);
    return AudioBankLoadData.EndAudioBankLoadData(builder);
  }

  public static void StartAudioBankLoadData(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddBankName(FlatBufferBuilder builder, StringOffset bankNameOffset) { builder.AddOffset(0, bankNameOffset.Value, 0); }
  public static void AddLoad(FlatBufferBuilder builder, bool load) { builder.AddBool(1, load, false); }
  public static Offset<GenericEditor.Plugin.Audio.AudioBankLoadData> EndAudioBankLoadData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<GenericEditor.Plugin.Audio.AudioBankLoadData>(o);
  }
  public static void FinishAudioBankLoadDataBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Audio.AudioBankLoadData> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedAudioBankLoadDataBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Audio.AudioBankLoadData> offset) { builder.FinishSizePrefixed(offset.Value); }
  public AudioBankLoadDataT UnPack() {
    var _o = new AudioBankLoadDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AudioBankLoadDataT _o) {
    _o.BankName = this.BankName;
    _o.Load = this.Load;
  }
  public static Offset<GenericEditor.Plugin.Audio.AudioBankLoadData> Pack(FlatBufferBuilder builder, AudioBankLoadDataT _o) {
    if (_o == null) return default(Offset<GenericEditor.Plugin.Audio.AudioBankLoadData>);
    var _bankName = _o.BankName == null ? default(StringOffset) : builder.CreateString(_o.BankName);
    return CreateAudioBankLoadData(
      builder,
      _bankName,
      _o.Load);
  }
};

public class AudioBankLoadDataT
{
  [Newtonsoft.Json.JsonProperty("bankName")]
  public string BankName { get; set; }
  [Newtonsoft.Json.JsonProperty("load")]
  public bool Load { get; set; }

  public AudioBankLoadDataT() {
    this.BankName = null;
    this.Load = false;
  }

  public static AudioBankLoadDataT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<AudioBankLoadDataT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static AudioBankLoadDataT DeserializeFromBinary(byte[] fbBuffer) {
    return AudioBankLoadData.GetRootAsAudioBankLoadData(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    AudioBankLoadData.FinishAudioBankLoadDataBuffer(fbb, AudioBankLoadData.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
