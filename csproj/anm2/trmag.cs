// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.anm2.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct AngleParamList : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static AngleParamList GetRootAsAngleParamList(ByteBuffer _bb) { return GetRootAsAngleParamList(_bb, new AngleParamList()); }
  public static AngleParamList GetRootAsAngleParamList(ByteBuffer _bb, AngleParamList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AngleParamList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.anm2.fb.AngleDetectorParam? Params(int j) { int o = __p.__offset(4); return o != 0 ? (gfl.anm2.fb.AngleDetectorParam?)(new gfl.anm2.fb.AngleDetectorParam()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ParamsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<gfl.anm2.fb.AngleParamList> CreateAngleParamList(FlatBufferBuilder builder,
      VectorOffset paramsOffset = default(VectorOffset)) {
    builder.StartTable(1);
    AngleParamList.AddParams(builder, paramsOffset);
    return AngleParamList.EndAngleParamList(builder);
  }

  public static void StartAngleParamList(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddParams(FlatBufferBuilder builder, VectorOffset paramsOffset) { builder.AddOffset(0, paramsOffset.Value, 0); }
  public static VectorOffset CreateParamsVector(FlatBufferBuilder builder, Offset<gfl.anm2.fb.AngleDetectorParam>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, Offset<gfl.anm2.fb.AngleDetectorParam>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartParamsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<gfl.anm2.fb.AngleParamList> EndAngleParamList(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fb.AngleParamList>(o);
  }
  public static void FinishAngleParamListBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fb.AngleParamList> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedAngleParamListBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fb.AngleParamList> offset) { builder.FinishSizePrefixed(offset.Value); }
  public AngleParamListT UnPack() {
    var _o = new AngleParamListT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AngleParamListT _o) {
    _o.Params = new List<gfl.anm2.fb.AngleDetectorParamT>();
    for (var _j = 0; _j < this.ParamsLength; ++_j) {_o.Params.Add(this.Params(_j).HasValue ? this.Params(_j).Value.UnPack() : null);}
  }
  public static Offset<gfl.anm2.fb.AngleParamList> Pack(FlatBufferBuilder builder, AngleParamListT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fb.AngleParamList>);
    var _params = default(VectorOffset);
    if (_o.Params != null) {
      var __params = new Offset<gfl.anm2.fb.AngleDetectorParam>[_o.Params.Count];
      for (var _j = 0; _j < __params.Length; ++_j) { __params[_j] = gfl.anm2.fb.AngleDetectorParam.Pack(builder, _o.Params[_j]); }
      _params = CreateParamsVector(builder, __params);
    }
    return CreateAngleParamList(
      builder,
      _params);
  }
};

public class AngleParamListT
{
  [Newtonsoft.Json.JsonProperty("params")]
  public List<gfl.anm2.fb.AngleDetectorParamT> Params { get; set; }

  public AngleParamListT() {
    this.Params = null;
  }

  public static AngleParamListT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<AngleParamListT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static AngleParamListT DeserializeFromBinary(byte[] fbBuffer) {
    return AngleParamList.GetRootAsAngleParamList(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    AngleParamList.FinishAngleParamListBuffer(fbb, AngleParamList.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}