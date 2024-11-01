// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace GenericEditor.Plugin.MotionDetector
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct MotionDetectorMessage : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static MotionDetectorMessage GetRootAsMotionDetectorMessage(ByteBuffer _bb) { return GetRootAsMotionDetectorMessage(_bb, new MotionDetectorMessage()); }
  public static MotionDetectorMessage GetRootAsMotionDetectorMessage(ByteBuffer _bb, MotionDetectorMessage obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MotionDetectorMessage __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float Values(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int ValuesLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetValuesBytes() { return __p.__vector_as_span<float>(4, 4); }
#else
  public ArraySegment<byte>? GetValuesBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public float[] GetValuesArray() { return __p.__vector_as_array<float>(4); }
  public string FileNames(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int FileNamesLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorMessage> CreateMotionDetectorMessage(FlatBufferBuilder builder,
      VectorOffset valuesOffset = default(VectorOffset),
      VectorOffset fileNamesOffset = default(VectorOffset)) {
    builder.StartTable(2);
    MotionDetectorMessage.AddFileNames(builder, fileNamesOffset);
    MotionDetectorMessage.AddValues(builder, valuesOffset);
    return MotionDetectorMessage.EndMotionDetectorMessage(builder);
  }

  public static void StartMotionDetectorMessage(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset) { builder.AddOffset(0, valuesOffset.Value, 0); }
  public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartValuesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFileNames(FlatBufferBuilder builder, VectorOffset fileNamesOffset) { builder.AddOffset(1, fileNamesOffset.Value, 0); }
  public static VectorOffset CreateFileNamesVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateFileNamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartFileNamesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorMessage> EndMotionDetectorMessage(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorMessage>(o);
  }
  public static void FinishMotionDetectorMessageBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorMessage> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedMotionDetectorMessageBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorMessage> offset) { builder.FinishSizePrefixed(offset.Value); }
  public MotionDetectorMessageT UnPack() {
    var _o = new MotionDetectorMessageT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MotionDetectorMessageT _o) {
    _o.Values = new List<float>();
    for (var _j = 0; _j < this.ValuesLength; ++_j) {_o.Values.Add(this.Values(_j));}
    _o.FileNames = new List<string>();
    for (var _j = 0; _j < this.FileNamesLength; ++_j) {_o.FileNames.Add(this.FileNames(_j));}
  }
  public static Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorMessage> Pack(FlatBufferBuilder builder, MotionDetectorMessageT _o) {
    if (_o == null) return default(Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorMessage>);
    var _values = default(VectorOffset);
    if (_o.Values != null) {
      var __values = _o.Values.ToArray();
      _values = CreateValuesVector(builder, __values);
    }
    var _fileNames = default(VectorOffset);
    if (_o.FileNames != null) {
      var __fileNames = new StringOffset[_o.FileNames.Count];
      for (var _j = 0; _j < __fileNames.Length; ++_j) { __fileNames[_j] = builder.CreateString(_o.FileNames[_j]); }
      _fileNames = CreateFileNamesVector(builder, __fileNames);
    }
    return CreateMotionDetectorMessage(
      builder,
      _values,
      _fileNames);
  }
};

public class MotionDetectorMessageT
{
  [Newtonsoft.Json.JsonProperty("values")]
  public List<float> Values { get; set; }
  [Newtonsoft.Json.JsonProperty("fileNames")]
  public List<string> FileNames { get; set; }

  public MotionDetectorMessageT() {
    this.Values = null;
    this.FileNames = null;
  }

  public static MotionDetectorMessageT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<MotionDetectorMessageT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static MotionDetectorMessageT DeserializeFromBinary(byte[] fbBuffer) {
    return MotionDetectorMessage.GetRootAsMotionDetectorMessage(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    MotionDetectorMessage.FinishMotionDetectorMessageBuffer(fbb, MotionDetectorMessage.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
