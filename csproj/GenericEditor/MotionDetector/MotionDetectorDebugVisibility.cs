// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace GenericEditor.Plugin.MotionDetector
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct MotionDetectorDebugVisibility : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static MotionDetectorDebugVisibility GetRootAsMotionDetectorDebugVisibility(ByteBuffer _bb) { return GetRootAsMotionDetectorDebugVisibility(_bb, new MotionDetectorDebugVisibility()); }
  public static MotionDetectorDebugVisibility GetRootAsMotionDetectorDebugVisibility(ByteBuffer _bb, MotionDetectorDebugVisibility obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MotionDetectorDebugVisibility __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string FileName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFileNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetFileNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetFileNameArray() { return __p.__vector_as_array<byte>(4); }
  public bool Visible { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorDebugVisibility> CreateMotionDetectorDebugVisibility(FlatBufferBuilder builder,
      StringOffset fileNameOffset = default(StringOffset),
      bool visible = false) {
    builder.StartTable(2);
    MotionDetectorDebugVisibility.AddFileName(builder, fileNameOffset);
    MotionDetectorDebugVisibility.AddVisible(builder, visible);
    return MotionDetectorDebugVisibility.EndMotionDetectorDebugVisibility(builder);
  }

  public static void StartMotionDetectorDebugVisibility(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddFileName(FlatBufferBuilder builder, StringOffset fileNameOffset) { builder.AddOffset(0, fileNameOffset.Value, 0); }
  public static void AddVisible(FlatBufferBuilder builder, bool visible) { builder.AddBool(1, visible, false); }
  public static Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorDebugVisibility> EndMotionDetectorDebugVisibility(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorDebugVisibility>(o);
  }
  public static void FinishMotionDetectorDebugVisibilityBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorDebugVisibility> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedMotionDetectorDebugVisibilityBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorDebugVisibility> offset) { builder.FinishSizePrefixed(offset.Value); }
  public MotionDetectorDebugVisibilityT UnPack() {
    var _o = new MotionDetectorDebugVisibilityT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MotionDetectorDebugVisibilityT _o) {
    _o.FileName = this.FileName;
    _o.Visible = this.Visible;
  }
  public static Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorDebugVisibility> Pack(FlatBufferBuilder builder, MotionDetectorDebugVisibilityT _o) {
    if (_o == null) return default(Offset<GenericEditor.Plugin.MotionDetector.MotionDetectorDebugVisibility>);
    var _fileName = _o.FileName == null ? default(StringOffset) : builder.CreateString(_o.FileName);
    return CreateMotionDetectorDebugVisibility(
      builder,
      _fileName,
      _o.Visible);
  }
};

public class MotionDetectorDebugVisibilityT
{
  [Newtonsoft.Json.JsonProperty("fileName")]
  public string FileName { get; set; }
  [Newtonsoft.Json.JsonProperty("visible")]
  public bool Visible { get; set; }

  public MotionDetectorDebugVisibilityT() {
    this.FileName = null;
    this.Visible = false;
  }

  public static MotionDetectorDebugVisibilityT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<MotionDetectorDebugVisibilityT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static MotionDetectorDebugVisibilityT DeserializeFromBinary(byte[] fbBuffer) {
    return MotionDetectorDebugVisibility.GetRootAsMotionDetectorDebugVisibility(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    MotionDetectorDebugVisibility.FinishMotionDetectorDebugVisibilityBuffer(fbb, MotionDetectorDebugVisibility.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}