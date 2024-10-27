// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public enum SceneObjectPriority : sbyte
{
  Lowest = 0,
  Low = 1,
  Middle = 2,
  High = 3,
  Highest = 4,
};

public struct SceneObjectLayer : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static SceneObjectLayer GetRootAsSceneObjectLayer(ByteBuffer _bb) { return GetRootAsSceneObjectLayer(_bb, new SceneObjectLayer()); }
  public static SceneObjectLayer GetRootAsSceneObjectLayer(ByteBuffer _bb, SceneObjectLayer obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SceneObjectLayer __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Priority { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public gfl.math.fb.SRT? Srt { get { int o = __p.__offset(8); return o != 0 ? (gfl.math.fb.SRT?)(new gfl.math.fb.SRT()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<gfl.scene.fb.SceneObjectLayer> CreateSceneObjectLayer(FlatBufferBuilder builder,
      int priority = 0,
      StringOffset nameOffset = default(StringOffset),
      Offset<gfl.math.fb.SRT> srtOffset = default(Offset<gfl.math.fb.SRT>)) {
    builder.StartTable(3);
    SceneObjectLayer.AddSrt(builder, srtOffset);
    SceneObjectLayer.AddName(builder, nameOffset);
    SceneObjectLayer.AddPriority(builder, priority);
    return SceneObjectLayer.EndSceneObjectLayer(builder);
  }

  public static void StartSceneObjectLayer(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddPriority(FlatBufferBuilder builder, int priority) { builder.AddInt(0, priority, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddSrt(FlatBufferBuilder builder, Offset<gfl.math.fb.SRT> srtOffset) { builder.AddOffset(2, srtOffset.Value, 0); }
  public static Offset<gfl.scene.fb.SceneObjectLayer> EndSceneObjectLayer(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.SceneObjectLayer>(o);
  }
  public SceneObjectLayerT UnPack() {
    var _o = new SceneObjectLayerT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SceneObjectLayerT _o) {
    _o.Priority = this.Priority;
    _o.Name = this.Name;
    _o.Srt = this.Srt.HasValue ? this.Srt.Value.UnPack() : null;
  }
  public static Offset<gfl.scene.fb.SceneObjectLayer> Pack(FlatBufferBuilder builder, SceneObjectLayerT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.SceneObjectLayer>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _srt = _o.Srt == null ? default(Offset<gfl.math.fb.SRT>) : gfl.math.fb.SRT.Pack(builder, _o.Srt);
    return CreateSceneObjectLayer(
      builder,
      _o.Priority,
      _name,
      _srt);
  }
};

public class SceneObjectLayerT
{
  [Newtonsoft.Json.JsonProperty("priority")]
  public int Priority { get; set; }
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("srt")]
  public gfl.math.fb.SRTT Srt { get; set; }

  public SceneObjectLayerT() {
    this.Priority = 0;
    this.Name = null;
    this.Srt = null;
  }
}

public struct SceneObject : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static SceneObject GetRootAsSceneObject(ByteBuffer _bb) { return GetRootAsSceneObject(_bb, new SceneObject()); }
  public static SceneObject GetRootAsSceneObject(ByteBuffer _bb, SceneObject obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SceneObject __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public gfl.math.fb.SRT? Srt { get { int o = __p.__offset(6); return o != 0 ? (gfl.math.fb.SRT?)(new gfl.math.fb.SRT()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public bool KeepWorldSRT { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool AttachTransformEnable { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string AttachJointName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAttachJointNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetAttachJointNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetAttachJointNameArray() { return __p.__vector_as_array<byte>(12); }
  public bool IsScriptable { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public gfl.scene.fb.SceneObjectPriority Priority { get { int o = __p.__offset(16); return o != 0 ? (gfl.scene.fb.SceneObjectPriority)__p.bb.GetSbyte(o + __p.bb_pos) : gfl.scene.fb.SceneObjectPriority.Middle; } }
  public gfl.scene.fb.SceneObjectLayer? LayerList(int j) { int o = __p.__offset(18); return o != 0 ? (gfl.scene.fb.SceneObjectLayer?)(new gfl.scene.fb.SceneObjectLayer()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int LayerListLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string TagList(int j) { int o = __p.__offset(20); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int TagListLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
  public gfl.math.fb.Sphere? BoundingSphere { get { int o = __p.__offset(22); return o != 0 ? (gfl.math.fb.Sphere?)(new gfl.math.fb.Sphere()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<gfl.scene.fb.SceneObject> CreateSceneObject(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      Offset<gfl.math.fb.SRT> srtOffset = default(Offset<gfl.math.fb.SRT>),
      bool keepWorldSRT = false,
      bool attachTransformEnable = false,
      StringOffset attachJointNameOffset = default(StringOffset),
      bool isScriptable = false,
      gfl.scene.fb.SceneObjectPriority priority = gfl.scene.fb.SceneObjectPriority.Middle,
      VectorOffset layerListOffset = default(VectorOffset),
      VectorOffset tagListOffset = default(VectorOffset),
      Offset<gfl.math.fb.Sphere> boundingSphereOffset = default(Offset<gfl.math.fb.Sphere>)) {
    builder.StartTable(10);
    SceneObject.AddBoundingSphere(builder, boundingSphereOffset);
    SceneObject.AddTagList(builder, tagListOffset);
    SceneObject.AddLayerList(builder, layerListOffset);
    SceneObject.AddAttachJointName(builder, attachJointNameOffset);
    SceneObject.AddSrt(builder, srtOffset);
    SceneObject.AddName(builder, nameOffset);
    SceneObject.AddPriority(builder, priority);
    SceneObject.AddIsScriptable(builder, isScriptable);
    SceneObject.AddAttachTransformEnable(builder, attachTransformEnable);
    SceneObject.AddKeepWorldSRT(builder, keepWorldSRT);
    return SceneObject.EndSceneObject(builder);
  }

  public static void StartSceneObject(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddSrt(FlatBufferBuilder builder, Offset<gfl.math.fb.SRT> srtOffset) { builder.AddOffset(1, srtOffset.Value, 0); }
  public static void AddKeepWorldSRT(FlatBufferBuilder builder, bool keepWorldSRT) { builder.AddBool(2, keepWorldSRT, false); }
  public static void AddAttachTransformEnable(FlatBufferBuilder builder, bool attachTransformEnable) { builder.AddBool(3, attachTransformEnable, false); }
  public static void AddAttachJointName(FlatBufferBuilder builder, StringOffset attachJointNameOffset) { builder.AddOffset(4, attachJointNameOffset.Value, 0); }
  public static void AddIsScriptable(FlatBufferBuilder builder, bool isScriptable) { builder.AddBool(5, isScriptable, false); }
  public static void AddPriority(FlatBufferBuilder builder, gfl.scene.fb.SceneObjectPriority priority) { builder.AddSbyte(6, (sbyte)priority, 2); }
  public static void AddLayerList(FlatBufferBuilder builder, VectorOffset layerListOffset) { builder.AddOffset(7, layerListOffset.Value, 0); }
  public static VectorOffset CreateLayerListVector(FlatBufferBuilder builder, Offset<gfl.scene.fb.SceneObjectLayer>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateLayerListVectorBlock(FlatBufferBuilder builder, Offset<gfl.scene.fb.SceneObjectLayer>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartLayerListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTagList(FlatBufferBuilder builder, VectorOffset tagListOffset) { builder.AddOffset(8, tagListOffset.Value, 0); }
  public static VectorOffset CreateTagListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateTagListVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartTagListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBoundingSphere(FlatBufferBuilder builder, Offset<gfl.math.fb.Sphere> boundingSphereOffset) { builder.AddOffset(9, boundingSphereOffset.Value, 0); }
  public static Offset<gfl.scene.fb.SceneObject> EndSceneObject(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.SceneObject>(o);
  }
  public static void FinishSceneObjectBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.SceneObject> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedSceneObjectBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.SceneObject> offset) { builder.FinishSizePrefixed(offset.Value); }
  public SceneObjectT UnPack() {
    var _o = new SceneObjectT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SceneObjectT _o) {
    _o.Name = this.Name;
    _o.Srt = this.Srt.HasValue ? this.Srt.Value.UnPack() : null;
    _o.KeepWorldSRT = this.KeepWorldSRT;
    _o.AttachTransformEnable = this.AttachTransformEnable;
    _o.AttachJointName = this.AttachJointName;
    _o.IsScriptable = this.IsScriptable;
    _o.Priority = this.Priority;
    _o.LayerList = new List<gfl.scene.fb.SceneObjectLayerT>();
    for (var _j = 0; _j < this.LayerListLength; ++_j) {_o.LayerList.Add(this.LayerList(_j).HasValue ? this.LayerList(_j).Value.UnPack() : null);}
    _o.TagList = new List<string>();
    for (var _j = 0; _j < this.TagListLength; ++_j) {_o.TagList.Add(this.TagList(_j));}
    _o.BoundingSphere = this.BoundingSphere.HasValue ? this.BoundingSphere.Value.UnPack() : null;
  }
  public static Offset<gfl.scene.fb.SceneObject> Pack(FlatBufferBuilder builder, SceneObjectT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.SceneObject>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _srt = _o.Srt == null ? default(Offset<gfl.math.fb.SRT>) : gfl.math.fb.SRT.Pack(builder, _o.Srt);
    var _attachJointName = _o.AttachJointName == null ? default(StringOffset) : builder.CreateString(_o.AttachJointName);
    var _layerList = default(VectorOffset);
    if (_o.LayerList != null) {
      var __layerList = new Offset<gfl.scene.fb.SceneObjectLayer>[_o.LayerList.Count];
      for (var _j = 0; _j < __layerList.Length; ++_j) { __layerList[_j] = gfl.scene.fb.SceneObjectLayer.Pack(builder, _o.LayerList[_j]); }
      _layerList = CreateLayerListVector(builder, __layerList);
    }
    var _tagList = default(VectorOffset);
    if (_o.TagList != null) {
      var __tagList = new StringOffset[_o.TagList.Count];
      for (var _j = 0; _j < __tagList.Length; ++_j) { __tagList[_j] = builder.CreateString(_o.TagList[_j]); }
      _tagList = CreateTagListVector(builder, __tagList);
    }
    var _boundingSphere = _o.BoundingSphere == null ? default(Offset<gfl.math.fb.Sphere>) : gfl.math.fb.Sphere.Pack(builder, _o.BoundingSphere);
    return CreateSceneObject(
      builder,
      _name,
      _srt,
      _o.KeepWorldSRT,
      _o.AttachTransformEnable,
      _attachJointName,
      _o.IsScriptable,
      _o.Priority,
      _layerList,
      _tagList,
      _boundingSphere);
  }
};

public class SceneObjectT
{
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("srt")]
  public gfl.math.fb.SRTT Srt { get; set; }
  [Newtonsoft.Json.JsonProperty("keepWorldSRT")]
  public bool KeepWorldSRT { get; set; }
  [Newtonsoft.Json.JsonProperty("attachTransformEnable")]
  public bool AttachTransformEnable { get; set; }
  [Newtonsoft.Json.JsonProperty("attachJointName")]
  public string AttachJointName { get; set; }
  [Newtonsoft.Json.JsonProperty("isScriptable")]
  public bool IsScriptable { get; set; }
  [Newtonsoft.Json.JsonProperty("priority")]
  public gfl.scene.fb.SceneObjectPriority Priority { get; set; }
  [Newtonsoft.Json.JsonProperty("layerList")]
  public List<gfl.scene.fb.SceneObjectLayerT> LayerList { get; set; }
  [Newtonsoft.Json.JsonProperty("tagList")]
  public List<string> TagList { get; set; }
  [Newtonsoft.Json.JsonProperty("boundingSphere")]
  public gfl.math.fb.SphereT BoundingSphere { get; set; }

  public SceneObjectT() {
    this.Name = null;
    this.Srt = null;
    this.KeepWorldSRT = false;
    this.AttachTransformEnable = false;
    this.AttachJointName = null;
    this.IsScriptable = false;
    this.Priority = gfl.scene.fb.SceneObjectPriority.Middle;
    this.LayerList = null;
    this.TagList = null;
    this.BoundingSphere = null;
  }

  public static SceneObjectT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<SceneObjectT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static SceneObjectT DeserializeFromBinary(byte[] fbBuffer) {
    return SceneObject.GetRootAsSceneObject(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    SceneObject.FinishSceneObjectBuffer(fbb, SceneObject.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}