// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.anm2.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct MotionDetectorConfig : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static MotionDetectorConfig GetRootAsMotionDetectorConfig(ByteBuffer _bb) { return GetRootAsMotionDetectorConfig(_bb, new MotionDetectorConfig()); }
  public static MotionDetectorConfig GetRootAsMotionDetectorConfig(ByteBuffer _bb, MotionDetectorConfig obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MotionDetectorConfig __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string DetectorDataFileList(int j) { int o = __p.__offset(4); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int DetectorDataFileListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<gfl.anm2.fb.MotionDetectorConfig> CreateMotionDetectorConfig(FlatBufferBuilder builder,
      VectorOffset detectorDataFileListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    MotionDetectorConfig.AddDetectorDataFileList(builder, detectorDataFileListOffset);
    return MotionDetectorConfig.EndMotionDetectorConfig(builder);
  }

  public static void StartMotionDetectorConfig(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDetectorDataFileList(FlatBufferBuilder builder, VectorOffset detectorDataFileListOffset) { builder.AddOffset(0, detectorDataFileListOffset.Value, 0); }
  public static VectorOffset CreateDetectorDataFileListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDetectorDataFileListVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartDetectorDataFileListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<gfl.anm2.fb.MotionDetectorConfig> EndMotionDetectorConfig(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.MotionDetectorConfig>(o);
  }
  public static void FinishMotionDetectorConfigBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fb.MotionDetectorConfig> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedMotionDetectorConfigBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fb.MotionDetectorConfig> offset) { builder.FinishSizePrefixed(offset.Value); }
  public MotionDetectorConfigT UnPack() {
    var _o = new MotionDetectorConfigT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MotionDetectorConfigT _o) {
    _o.DetectorDataFileList = new List<string>();
    for (var _j = 0; _j < this.DetectorDataFileListLength; ++_j) {_o.DetectorDataFileList.Add(this.DetectorDataFileList(_j));}
  }
  public static Offset<gfl.anm2.fb.MotionDetectorConfig> Pack(FlatBufferBuilder builder, MotionDetectorConfigT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.MotionDetectorConfig>);
    var _detectorDataFileList = default(VectorOffset);
    if (_o.DetectorDataFileList != null) {
      var __detectorDataFileList = new StringOffset[_o.DetectorDataFileList.Count];
      for (var _j = 0; _j < __detectorDataFileList.Length; ++_j) { __detectorDataFileList[_j] = builder.CreateString(_o.DetectorDataFileList[_j]); }
      _detectorDataFileList = CreateDetectorDataFileListVector(builder, __detectorDataFileList);
    }
    return CreateMotionDetectorConfig(
      builder,
      _detectorDataFileList);
  }
};

public class MotionDetectorConfigT
{
  [Newtonsoft.Json.JsonProperty("detectorDataFileList")]
  public List<string> DetectorDataFileList { get; set; }

  public MotionDetectorConfigT() {
    this.DetectorDataFileList = null;
  }

  public static MotionDetectorConfigT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<MotionDetectorConfigT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static MotionDetectorConfigT DeserializeFromBinary(byte[] fbBuffer) {
    return MotionDetectorConfig.GetRootAsMotionDetectorConfig(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    MotionDetectorConfig.FinishMotionDetectorConfigBuffer(fbb, MotionDetectorConfig.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
