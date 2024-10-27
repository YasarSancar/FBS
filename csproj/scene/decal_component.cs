// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum BlendStateColorPreset : uint
{
  Opaque = 0,
  Blend = 1,
  BlendPremultiAlpha = 2,
  BlendSrc1Color = 3,
  Add = 4,
  AddAlphaOne = 5,
  Mul = 6,
  Screen = 7,
  Sub = 8,
  RevSub = 9,
  Min = 10,
  Max = 11,
};

public struct DecalComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static DecalComponent GetRootAsDecalComponent(ByteBuffer _bb) { return GetRootAsDecalComponent(_bb, new DecalComponent()); }
  public static DecalComponent GetRootAsDecalComponent(ByteBuffer _bb, DecalComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DecalComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string ResourceName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetResourceNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetResourceNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetResourceNameArray() { return __p.__vector_as_array<byte>(4); }
  public string FilePath { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFilePathBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetFilePathBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetFilePathArray() { return __p.__vector_as_array<byte>(6); }
  public gfl.math.fb.Vector4f? Color { get { int o = __p.__offset(8); return o != 0 ? (gfl.math.fb.Vector4f?)(new gfl.math.fb.Vector4f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public gfl.scene.fb.BlendStateColorPreset BlendState { get { int o = __p.__offset(10); return o != 0 ? (gfl.scene.fb.BlendStateColorPreset)__p.bb.GetUint(o + __p.bb_pos) : gfl.scene.fb.BlendStateColorPreset.Opaque; } }
  public bool ShowWireFrame { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsColorPolarCordinate { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public gfl.math.fb.Vector4f? MainColorUV { get { int o = __p.__offset(16); return o != 0 ? (gfl.math.fb.Vector4f?)(new gfl.math.fb.Vector4f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public string MaskTexturePath { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMaskTexturePathBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetMaskTexturePathBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetMaskTexturePathArray() { return __p.__vector_as_array<byte>(18); }
  public bool IsMaskPolarCordinate { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public gfl.math.fb.Vector4f? MaskUV { get { int o = __p.__offset(22); return o != 0 ? (gfl.math.fb.Vector4f?)(new gfl.math.fb.Vector4f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public string DistortionTexturePath { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDistortionTexturePathBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetDistortionTexturePathBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetDistortionTexturePathArray() { return __p.__vector_as_array<byte>(24); }
  public bool IsDistortionPolarCordinate { get { int o = __p.__offset(26); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public gfl.math.fb.Vector4f? DistortionUV { get { int o = __p.__offset(28); return o != 0 ? (gfl.math.fb.Vector4f?)(new gfl.math.fb.Vector4f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public string DisolveTexturePath { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDisolveTexturePathBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetDisolveTexturePathBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetDisolveTexturePathArray() { return __p.__vector_as_array<byte>(30); }
  public bool IsDisolvePolarCordinate { get { int o = __p.__offset(32); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public gfl.math.fb.Vector4f? DisolveUV { get { int o = __p.__offset(34); return o != 0 ? (gfl.math.fb.Vector4f?)(new gfl.math.fb.Vector4f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public float DistortionCorrectX { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DistortionCorrectY { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float MaskCorrect { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DisolveCorrect { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool LightenColor { get { int o = __p.__offset(44); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public gfl.math.fb.Vector4f? DisableCategory { get { int o = __p.__offset(46); return o != 0 ? (gfl.math.fb.Vector4f?)(new gfl.math.fb.Vector4f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public float LightenRatio { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<gfl.scene.fb.DecalComponent> CreateDecalComponent(FlatBufferBuilder builder,
      StringOffset resourceNameOffset = default(StringOffset),
      StringOffset filePathOffset = default(StringOffset),
      gfl.math.fb.Vector4fT color = null,
      gfl.scene.fb.BlendStateColorPreset blendState = gfl.scene.fb.BlendStateColorPreset.Opaque,
      bool showWireFrame = false,
      bool isColorPolarCordinate = false,
      gfl.math.fb.Vector4fT mainColorUV = null,
      StringOffset maskTexturePathOffset = default(StringOffset),
      bool isMaskPolarCordinate = false,
      gfl.math.fb.Vector4fT maskUV = null,
      StringOffset distortionTexturePathOffset = default(StringOffset),
      bool isDistortionPolarCordinate = false,
      gfl.math.fb.Vector4fT distortionUV = null,
      StringOffset disolveTexturePathOffset = default(StringOffset),
      bool isDisolvePolarCordinate = false,
      gfl.math.fb.Vector4fT disolveUV = null,
      float distortionCorrectX = 0.0f,
      float distortionCorrectY = 0.0f,
      float maskCorrect = 0.0f,
      float disolveCorrect = 0.0f,
      bool lightenColor = false,
      gfl.math.fb.Vector4fT disableCategory = null,
      float lightenRatio = 0.0f) {
    builder.StartTable(23);
    DecalComponent.AddLightenRatio(builder, lightenRatio);
    DecalComponent.AddDisableCategory(builder, gfl.math.fb.Vector4f.Pack(builder, disableCategory));
    DecalComponent.AddDisolveCorrect(builder, disolveCorrect);
    DecalComponent.AddMaskCorrect(builder, maskCorrect);
    DecalComponent.AddDistortionCorrectY(builder, distortionCorrectY);
    DecalComponent.AddDistortionCorrectX(builder, distortionCorrectX);
    DecalComponent.AddDisolveUV(builder, gfl.math.fb.Vector4f.Pack(builder, disolveUV));
    DecalComponent.AddDisolveTexturePath(builder, disolveTexturePathOffset);
    DecalComponent.AddDistortionUV(builder, gfl.math.fb.Vector4f.Pack(builder, distortionUV));
    DecalComponent.AddDistortionTexturePath(builder, distortionTexturePathOffset);
    DecalComponent.AddMaskUV(builder, gfl.math.fb.Vector4f.Pack(builder, maskUV));
    DecalComponent.AddMaskTexturePath(builder, maskTexturePathOffset);
    DecalComponent.AddMainColorUV(builder, gfl.math.fb.Vector4f.Pack(builder, mainColorUV));
    DecalComponent.AddBlendState(builder, blendState);
    DecalComponent.AddColor(builder, gfl.math.fb.Vector4f.Pack(builder, color));
    DecalComponent.AddFilePath(builder, filePathOffset);
    DecalComponent.AddResourceName(builder, resourceNameOffset);
    DecalComponent.AddLightenColor(builder, lightenColor);
    DecalComponent.AddIsDisolvePolarCordinate(builder, isDisolvePolarCordinate);
    DecalComponent.AddIsDistortionPolarCordinate(builder, isDistortionPolarCordinate);
    DecalComponent.AddIsMaskPolarCordinate(builder, isMaskPolarCordinate);
    DecalComponent.AddIsColorPolarCordinate(builder, isColorPolarCordinate);
    DecalComponent.AddShowWireFrame(builder, showWireFrame);
    return DecalComponent.EndDecalComponent(builder);
  }

  public static void StartDecalComponent(FlatBufferBuilder builder) { builder.StartTable(23); }
  public static void AddResourceName(FlatBufferBuilder builder, StringOffset resourceNameOffset) { builder.AddOffset(0, resourceNameOffset.Value, 0); }
  public static void AddFilePath(FlatBufferBuilder builder, StringOffset filePathOffset) { builder.AddOffset(1, filePathOffset.Value, 0); }
  public static void AddColor(FlatBufferBuilder builder, Offset<gfl.math.fb.Vector4f> colorOffset) { builder.AddStruct(2, colorOffset.Value, 0); }
  public static void AddBlendState(FlatBufferBuilder builder, gfl.scene.fb.BlendStateColorPreset blendState) { builder.AddUint(3, (uint)blendState, 0); }
  public static void AddShowWireFrame(FlatBufferBuilder builder, bool showWireFrame) { builder.AddBool(4, showWireFrame, false); }
  public static void AddIsColorPolarCordinate(FlatBufferBuilder builder, bool isColorPolarCordinate) { builder.AddBool(5, isColorPolarCordinate, false); }
  public static void AddMainColorUV(FlatBufferBuilder builder, Offset<gfl.math.fb.Vector4f> mainColorUVOffset) { builder.AddStruct(6, mainColorUVOffset.Value, 0); }
  public static void AddMaskTexturePath(FlatBufferBuilder builder, StringOffset maskTexturePathOffset) { builder.AddOffset(7, maskTexturePathOffset.Value, 0); }
  public static void AddIsMaskPolarCordinate(FlatBufferBuilder builder, bool isMaskPolarCordinate) { builder.AddBool(8, isMaskPolarCordinate, false); }
  public static void AddMaskUV(FlatBufferBuilder builder, Offset<gfl.math.fb.Vector4f> maskUVOffset) { builder.AddStruct(9, maskUVOffset.Value, 0); }
  public static void AddDistortionTexturePath(FlatBufferBuilder builder, StringOffset distortionTexturePathOffset) { builder.AddOffset(10, distortionTexturePathOffset.Value, 0); }
  public static void AddIsDistortionPolarCordinate(FlatBufferBuilder builder, bool isDistortionPolarCordinate) { builder.AddBool(11, isDistortionPolarCordinate, false); }
  public static void AddDistortionUV(FlatBufferBuilder builder, Offset<gfl.math.fb.Vector4f> distortionUVOffset) { builder.AddStruct(12, distortionUVOffset.Value, 0); }
  public static void AddDisolveTexturePath(FlatBufferBuilder builder, StringOffset disolveTexturePathOffset) { builder.AddOffset(13, disolveTexturePathOffset.Value, 0); }
  public static void AddIsDisolvePolarCordinate(FlatBufferBuilder builder, bool isDisolvePolarCordinate) { builder.AddBool(14, isDisolvePolarCordinate, false); }
  public static void AddDisolveUV(FlatBufferBuilder builder, Offset<gfl.math.fb.Vector4f> disolveUVOffset) { builder.AddStruct(15, disolveUVOffset.Value, 0); }
  public static void AddDistortionCorrectX(FlatBufferBuilder builder, float distortionCorrectX) { builder.AddFloat(16, distortionCorrectX, 0.0f); }
  public static void AddDistortionCorrectY(FlatBufferBuilder builder, float distortionCorrectY) { builder.AddFloat(17, distortionCorrectY, 0.0f); }
  public static void AddMaskCorrect(FlatBufferBuilder builder, float maskCorrect) { builder.AddFloat(18, maskCorrect, 0.0f); }
  public static void AddDisolveCorrect(FlatBufferBuilder builder, float disolveCorrect) { builder.AddFloat(19, disolveCorrect, 0.0f); }
  public static void AddLightenColor(FlatBufferBuilder builder, bool lightenColor) { builder.AddBool(20, lightenColor, false); }
  public static void AddDisableCategory(FlatBufferBuilder builder, Offset<gfl.math.fb.Vector4f> disableCategoryOffset) { builder.AddStruct(21, disableCategoryOffset.Value, 0); }
  public static void AddLightenRatio(FlatBufferBuilder builder, float lightenRatio) { builder.AddFloat(22, lightenRatio, 0.0f); }
  public static Offset<gfl.scene.fb.DecalComponent> EndDecalComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.DecalComponent>(o);
  }
  public static void FinishDecalComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.DecalComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedDecalComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.DecalComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public DecalComponentT UnPack() {
    var _o = new DecalComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(DecalComponentT _o) {
    _o.ResourceName = this.ResourceName;
    _o.FilePath = this.FilePath;
    _o.Color = this.Color.HasValue ? this.Color.Value.UnPack() : null;
    _o.BlendState = this.BlendState;
    _o.ShowWireFrame = this.ShowWireFrame;
    _o.IsColorPolarCordinate = this.IsColorPolarCordinate;
    _o.MainColorUV = this.MainColorUV.HasValue ? this.MainColorUV.Value.UnPack() : null;
    _o.MaskTexturePath = this.MaskTexturePath;
    _o.IsMaskPolarCordinate = this.IsMaskPolarCordinate;
    _o.MaskUV = this.MaskUV.HasValue ? this.MaskUV.Value.UnPack() : null;
    _o.DistortionTexturePath = this.DistortionTexturePath;
    _o.IsDistortionPolarCordinate = this.IsDistortionPolarCordinate;
    _o.DistortionUV = this.DistortionUV.HasValue ? this.DistortionUV.Value.UnPack() : null;
    _o.DisolveTexturePath = this.DisolveTexturePath;
    _o.IsDisolvePolarCordinate = this.IsDisolvePolarCordinate;
    _o.DisolveUV = this.DisolveUV.HasValue ? this.DisolveUV.Value.UnPack() : null;
    _o.DistortionCorrectX = this.DistortionCorrectX;
    _o.DistortionCorrectY = this.DistortionCorrectY;
    _o.MaskCorrect = this.MaskCorrect;
    _o.DisolveCorrect = this.DisolveCorrect;
    _o.LightenColor = this.LightenColor;
    _o.DisableCategory = this.DisableCategory.HasValue ? this.DisableCategory.Value.UnPack() : null;
    _o.LightenRatio = this.LightenRatio;
  }
  public static Offset<gfl.scene.fb.DecalComponent> Pack(FlatBufferBuilder builder, DecalComponentT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.DecalComponent>);
    var _resourceName = _o.ResourceName == null ? default(StringOffset) : builder.CreateString(_o.ResourceName);
    var _filePath = _o.FilePath == null ? default(StringOffset) : builder.CreateString(_o.FilePath);
    var _maskTexturePath = _o.MaskTexturePath == null ? default(StringOffset) : builder.CreateString(_o.MaskTexturePath);
    var _distortionTexturePath = _o.DistortionTexturePath == null ? default(StringOffset) : builder.CreateString(_o.DistortionTexturePath);
    var _disolveTexturePath = _o.DisolveTexturePath == null ? default(StringOffset) : builder.CreateString(_o.DisolveTexturePath);
    return CreateDecalComponent(
      builder,
      _resourceName,
      _filePath,
      _o.Color,
      _o.BlendState,
      _o.ShowWireFrame,
      _o.IsColorPolarCordinate,
      _o.MainColorUV,
      _maskTexturePath,
      _o.IsMaskPolarCordinate,
      _o.MaskUV,
      _distortionTexturePath,
      _o.IsDistortionPolarCordinate,
      _o.DistortionUV,
      _disolveTexturePath,
      _o.IsDisolvePolarCordinate,
      _o.DisolveUV,
      _o.DistortionCorrectX,
      _o.DistortionCorrectY,
      _o.MaskCorrect,
      _o.DisolveCorrect,
      _o.LightenColor,
      _o.DisableCategory,
      _o.LightenRatio);
  }
};

public class DecalComponentT
{
  [Newtonsoft.Json.JsonProperty("resourceName")]
  public string ResourceName { get; set; }
  [Newtonsoft.Json.JsonProperty("filePath")]
  public string FilePath { get; set; }
  [Newtonsoft.Json.JsonProperty("color")]
  public gfl.math.fb.Vector4fT Color { get; set; }
  [Newtonsoft.Json.JsonProperty("blendState")]
  public gfl.scene.fb.BlendStateColorPreset BlendState { get; set; }
  [Newtonsoft.Json.JsonProperty("showWireFrame")]
  public bool ShowWireFrame { get; set; }
  [Newtonsoft.Json.JsonProperty("isColorPolarCordinate")]
  public bool IsColorPolarCordinate { get; set; }
  [Newtonsoft.Json.JsonProperty("mainColorUV")]
  public gfl.math.fb.Vector4fT MainColorUV { get; set; }
  [Newtonsoft.Json.JsonProperty("maskTexturePath")]
  public string MaskTexturePath { get; set; }
  [Newtonsoft.Json.JsonProperty("isMaskPolarCordinate")]
  public bool IsMaskPolarCordinate { get; set; }
  [Newtonsoft.Json.JsonProperty("maskUV")]
  public gfl.math.fb.Vector4fT MaskUV { get; set; }
  [Newtonsoft.Json.JsonProperty("distortionTexturePath")]
  public string DistortionTexturePath { get; set; }
  [Newtonsoft.Json.JsonProperty("isDistortionPolarCordinate")]
  public bool IsDistortionPolarCordinate { get; set; }
  [Newtonsoft.Json.JsonProperty("distortionUV")]
  public gfl.math.fb.Vector4fT DistortionUV { get; set; }
  [Newtonsoft.Json.JsonProperty("disolveTexturePath")]
  public string DisolveTexturePath { get; set; }
  [Newtonsoft.Json.JsonProperty("isDisolvePolarCordinate")]
  public bool IsDisolvePolarCordinate { get; set; }
  [Newtonsoft.Json.JsonProperty("disolveUV")]
  public gfl.math.fb.Vector4fT DisolveUV { get; set; }
  [Newtonsoft.Json.JsonProperty("distortionCorrectX")]
  public float DistortionCorrectX { get; set; }
  [Newtonsoft.Json.JsonProperty("distortionCorrectY")]
  public float DistortionCorrectY { get; set; }
  [Newtonsoft.Json.JsonProperty("maskCorrect")]
  public float MaskCorrect { get; set; }
  [Newtonsoft.Json.JsonProperty("disolveCorrect")]
  public float DisolveCorrect { get; set; }
  [Newtonsoft.Json.JsonProperty("lightenColor")]
  public bool LightenColor { get; set; }
  [Newtonsoft.Json.JsonProperty("disableCategory")]
  public gfl.math.fb.Vector4fT DisableCategory { get; set; }
  [Newtonsoft.Json.JsonProperty("lightenRatio")]
  public float LightenRatio { get; set; }

  public DecalComponentT() {
    this.ResourceName = null;
    this.FilePath = null;
    this.Color = new gfl.math.fb.Vector4fT();
    this.BlendState = gfl.scene.fb.BlendStateColorPreset.Opaque;
    this.ShowWireFrame = false;
    this.IsColorPolarCordinate = false;
    this.MainColorUV = new gfl.math.fb.Vector4fT();
    this.MaskTexturePath = null;
    this.IsMaskPolarCordinate = false;
    this.MaskUV = new gfl.math.fb.Vector4fT();
    this.DistortionTexturePath = null;
    this.IsDistortionPolarCordinate = false;
    this.DistortionUV = new gfl.math.fb.Vector4fT();
    this.DisolveTexturePath = null;
    this.IsDisolvePolarCordinate = false;
    this.DisolveUV = new gfl.math.fb.Vector4fT();
    this.DistortionCorrectX = 0.0f;
    this.DistortionCorrectY = 0.0f;
    this.MaskCorrect = 0.0f;
    this.DisolveCorrect = 0.0f;
    this.LightenColor = false;
    this.DisableCategory = new gfl.math.fb.Vector4fT();
    this.LightenRatio = 0.0f;
  }

  public static DecalComponentT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<DecalComponentT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static DecalComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return DecalComponent.GetRootAsDecalComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    DecalComponent.FinishDecalComponentBuffer(fbb, DecalComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
