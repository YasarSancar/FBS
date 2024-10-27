// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace GenericEditor.Plugin.Camera.FB
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct CameraSettingData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static CameraSettingData GetRootAsCameraSettingData(ByteBuffer _bb) { return GetRootAsCameraSettingData(_bb, new CameraSettingData()); }
  public static CameraSettingData GetRootAsCameraSettingData(ByteBuffer _bb, CameraSettingData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CameraSettingData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float Fovy { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float NearDistance { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float FarDistance { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<GenericEditor.Plugin.Camera.FB.CameraSettingData> CreateCameraSettingData(FlatBufferBuilder builder,
      float fovy = 0.0f,
      float nearDistance = 0.0f,
      float farDistance = 0.0f) {
    builder.StartTable(3);
    CameraSettingData.AddFarDistance(builder, farDistance);
    CameraSettingData.AddNearDistance(builder, nearDistance);
    CameraSettingData.AddFovy(builder, fovy);
    return CameraSettingData.EndCameraSettingData(builder);
  }

  public static void StartCameraSettingData(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddFovy(FlatBufferBuilder builder, float fovy) { builder.AddFloat(0, fovy, 0.0f); }
  public static void AddNearDistance(FlatBufferBuilder builder, float nearDistance) { builder.AddFloat(1, nearDistance, 0.0f); }
  public static void AddFarDistance(FlatBufferBuilder builder, float farDistance) { builder.AddFloat(2, farDistance, 0.0f); }
  public static Offset<GenericEditor.Plugin.Camera.FB.CameraSettingData> EndCameraSettingData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<GenericEditor.Plugin.Camera.FB.CameraSettingData>(o);
  }
  public static void FinishCameraSettingDataBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Camera.FB.CameraSettingData> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedCameraSettingDataBuffer(FlatBufferBuilder builder, Offset<GenericEditor.Plugin.Camera.FB.CameraSettingData> offset) { builder.FinishSizePrefixed(offset.Value); }
  public CameraSettingDataT UnPack() {
    var _o = new CameraSettingDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CameraSettingDataT _o) {
    _o.Fovy = this.Fovy;
    _o.NearDistance = this.NearDistance;
    _o.FarDistance = this.FarDistance;
  }
  public static Offset<GenericEditor.Plugin.Camera.FB.CameraSettingData> Pack(FlatBufferBuilder builder, CameraSettingDataT _o) {
    if (_o == null) return default(Offset<GenericEditor.Plugin.Camera.FB.CameraSettingData>);
    return CreateCameraSettingData(
      builder,
      _o.Fovy,
      _o.NearDistance,
      _o.FarDistance);
  }
};

public class CameraSettingDataT
{
  [Newtonsoft.Json.JsonProperty("fovy")]
  public float Fovy { get; set; }
  [Newtonsoft.Json.JsonProperty("nearDistance")]
  public float NearDistance { get; set; }
  [Newtonsoft.Json.JsonProperty("farDistance")]
  public float FarDistance { get; set; }

  public CameraSettingDataT() {
    this.Fovy = 0.0f;
    this.NearDistance = 0.0f;
    this.FarDistance = 0.0f;
  }

  public static CameraSettingDataT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<CameraSettingDataT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static CameraSettingDataT DeserializeFromBinary(byte[] fbBuffer) {
    return CameraSettingData.GetRootAsCameraSettingData(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    CameraSettingData.FinishCameraSettingDataBuffer(fbb, CameraSettingData.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
