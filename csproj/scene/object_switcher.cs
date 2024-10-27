// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct ObjectSwitcher : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ObjectSwitcher GetRootAsObjectSwitcher(ByteBuffer _bb) { return GetRootAsObjectSwitcher(_bb, new ObjectSwitcher()); }
  public static ObjectSwitcher GetRootAsObjectSwitcher(ByteBuffer _bb, ObjectSwitcher obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ObjectSwitcher __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string PackageName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPackageNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetPackageNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetPackageNameArray() { return __p.__vector_as_array<byte>(4); }
  public string FunctionName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFunctionNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetFunctionNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetFunctionNameArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<gfl.scene.fb.ObjectSwitcher> CreateObjectSwitcher(FlatBufferBuilder builder,
      StringOffset packageNameOffset = default(StringOffset),
      StringOffset functionNameOffset = default(StringOffset)) {
    builder.StartTable(2);
    ObjectSwitcher.AddFunctionName(builder, functionNameOffset);
    ObjectSwitcher.AddPackageName(builder, packageNameOffset);
    return ObjectSwitcher.EndObjectSwitcher(builder);
  }

  public static void StartObjectSwitcher(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddPackageName(FlatBufferBuilder builder, StringOffset packageNameOffset) { builder.AddOffset(0, packageNameOffset.Value, 0); }
  public static void AddFunctionName(FlatBufferBuilder builder, StringOffset functionNameOffset) { builder.AddOffset(1, functionNameOffset.Value, 0); }
  public static Offset<gfl.scene.fb.ObjectSwitcher> EndObjectSwitcher(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.ObjectSwitcher>(o);
  }
  public static void FinishObjectSwitcherBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.ObjectSwitcher> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedObjectSwitcherBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.ObjectSwitcher> offset) { builder.FinishSizePrefixed(offset.Value); }
  public ObjectSwitcherT UnPack() {
    var _o = new ObjectSwitcherT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ObjectSwitcherT _o) {
    _o.PackageName = this.PackageName;
    _o.FunctionName = this.FunctionName;
  }
  public static Offset<gfl.scene.fb.ObjectSwitcher> Pack(FlatBufferBuilder builder, ObjectSwitcherT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.ObjectSwitcher>);
    var _packageName = _o.PackageName == null ? default(StringOffset) : builder.CreateString(_o.PackageName);
    var _functionName = _o.FunctionName == null ? default(StringOffset) : builder.CreateString(_o.FunctionName);
    return CreateObjectSwitcher(
      builder,
      _packageName,
      _functionName);
  }
};

public class ObjectSwitcherT
{
  [Newtonsoft.Json.JsonProperty("packageName")]
  public string PackageName { get; set; }
  [Newtonsoft.Json.JsonProperty("functionName")]
  public string FunctionName { get; set; }

  public ObjectSwitcherT() {
    this.PackageName = null;
    this.FunctionName = null;
  }

  public static ObjectSwitcherT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<ObjectSwitcherT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static ObjectSwitcherT DeserializeFromBinary(byte[] fbBuffer) {
    return ObjectSwitcher.GetRootAsObjectSwitcher(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    ObjectSwitcher.FinishObjectSwitcherBuffer(fbb, ObjectSwitcher.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
