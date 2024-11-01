// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.scene.fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct CharacterCreationComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static CharacterCreationComponent GetRootAsCharacterCreationComponent(ByteBuffer _bb) { return GetRootAsCharacterCreationComponent(_bb, new CharacterCreationComponent()); }
  public static CharacterCreationComponent GetRootAsCharacterCreationComponent(ByteBuffer _bb, CharacterCreationComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterCreationComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string FilePath { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFilePathBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetFilePathBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetFilePathArray() { return __p.__vector_as_array<byte>(4); }
  public int AnimationSlot { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool OverrideLodDistance { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float LodDistance0 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float LodDistance1 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float LodDistance2 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool JointPriorityEnabled { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float JointPriorityDistance0 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int JointMaxPriority0 { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float JointPriorityDistance1 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int JointMaxPriority1 { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float JointPriorityDistance2 { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int JointMaxPriority2 { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float JointPriorityDistance3 { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int JointMaxPriority3 { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<gfl.scene.fb.CharacterCreationComponent> CreateCharacterCreationComponent(FlatBufferBuilder builder,
      StringOffset filePathOffset = default(StringOffset),
      int animationSlot = 0,
      bool overrideLodDistance = false,
      float lodDistance0 = 0.0f,
      float lodDistance1 = 0.0f,
      float lodDistance2 = 0.0f,
      bool jointPriorityEnabled = false,
      float jointPriorityDistance0 = 0.0f,
      int jointMaxPriority0 = 0,
      float jointPriorityDistance1 = 0.0f,
      int jointMaxPriority1 = 0,
      float jointPriorityDistance2 = 0.0f,
      int jointMaxPriority2 = 0,
      float jointPriorityDistance3 = 0.0f,
      int jointMaxPriority3 = 0) {
    builder.StartTable(15);
    CharacterCreationComponent.AddJointMaxPriority3(builder, jointMaxPriority3);
    CharacterCreationComponent.AddJointPriorityDistance3(builder, jointPriorityDistance3);
    CharacterCreationComponent.AddJointMaxPriority2(builder, jointMaxPriority2);
    CharacterCreationComponent.AddJointPriorityDistance2(builder, jointPriorityDistance2);
    CharacterCreationComponent.AddJointMaxPriority1(builder, jointMaxPriority1);
    CharacterCreationComponent.AddJointPriorityDistance1(builder, jointPriorityDistance1);
    CharacterCreationComponent.AddJointMaxPriority0(builder, jointMaxPriority0);
    CharacterCreationComponent.AddJointPriorityDistance0(builder, jointPriorityDistance0);
    CharacterCreationComponent.AddLodDistance2(builder, lodDistance2);
    CharacterCreationComponent.AddLodDistance1(builder, lodDistance1);
    CharacterCreationComponent.AddLodDistance0(builder, lodDistance0);
    CharacterCreationComponent.AddAnimationSlot(builder, animationSlot);
    CharacterCreationComponent.AddFilePath(builder, filePathOffset);
    CharacterCreationComponent.AddJointPriorityEnabled(builder, jointPriorityEnabled);
    CharacterCreationComponent.AddOverrideLodDistance(builder, overrideLodDistance);
    return CharacterCreationComponent.EndCharacterCreationComponent(builder);
  }

  public static void StartCharacterCreationComponent(FlatBufferBuilder builder) { builder.StartTable(15); }
  public static void AddFilePath(FlatBufferBuilder builder, StringOffset filePathOffset) { builder.AddOffset(0, filePathOffset.Value, 0); }
  public static void AddAnimationSlot(FlatBufferBuilder builder, int animationSlot) { builder.AddInt(1, animationSlot, 0); }
  public static void AddOverrideLodDistance(FlatBufferBuilder builder, bool overrideLodDistance) { builder.AddBool(2, overrideLodDistance, false); }
  public static void AddLodDistance0(FlatBufferBuilder builder, float lodDistance0) { builder.AddFloat(3, lodDistance0, 0.0f); }
  public static void AddLodDistance1(FlatBufferBuilder builder, float lodDistance1) { builder.AddFloat(4, lodDistance1, 0.0f); }
  public static void AddLodDistance2(FlatBufferBuilder builder, float lodDistance2) { builder.AddFloat(5, lodDistance2, 0.0f); }
  public static void AddJointPriorityEnabled(FlatBufferBuilder builder, bool jointPriorityEnabled) { builder.AddBool(6, jointPriorityEnabled, false); }
  public static void AddJointPriorityDistance0(FlatBufferBuilder builder, float jointPriorityDistance0) { builder.AddFloat(7, jointPriorityDistance0, 0.0f); }
  public static void AddJointMaxPriority0(FlatBufferBuilder builder, int jointMaxPriority0) { builder.AddInt(8, jointMaxPriority0, 0); }
  public static void AddJointPriorityDistance1(FlatBufferBuilder builder, float jointPriorityDistance1) { builder.AddFloat(9, jointPriorityDistance1, 0.0f); }
  public static void AddJointMaxPriority1(FlatBufferBuilder builder, int jointMaxPriority1) { builder.AddInt(10, jointMaxPriority1, 0); }
  public static void AddJointPriorityDistance2(FlatBufferBuilder builder, float jointPriorityDistance2) { builder.AddFloat(11, jointPriorityDistance2, 0.0f); }
  public static void AddJointMaxPriority2(FlatBufferBuilder builder, int jointMaxPriority2) { builder.AddInt(12, jointMaxPriority2, 0); }
  public static void AddJointPriorityDistance3(FlatBufferBuilder builder, float jointPriorityDistance3) { builder.AddFloat(13, jointPriorityDistance3, 0.0f); }
  public static void AddJointMaxPriority3(FlatBufferBuilder builder, int jointMaxPriority3) { builder.AddInt(14, jointMaxPriority3, 0); }
  public static Offset<gfl.scene.fb.CharacterCreationComponent> EndCharacterCreationComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.scene.fb.CharacterCreationComponent>(o);
  }
  public static void FinishCharacterCreationComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.CharacterCreationComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedCharacterCreationComponentBuffer(FlatBufferBuilder builder, Offset<gfl.scene.fb.CharacterCreationComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public CharacterCreationComponentT UnPack() {
    var _o = new CharacterCreationComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CharacterCreationComponentT _o) {
    _o.FilePath = this.FilePath;
    _o.AnimationSlot = this.AnimationSlot;
    _o.OverrideLodDistance = this.OverrideLodDistance;
    _o.LodDistance0 = this.LodDistance0;
    _o.LodDistance1 = this.LodDistance1;
    _o.LodDistance2 = this.LodDistance2;
    _o.JointPriorityEnabled = this.JointPriorityEnabled;
    _o.JointPriorityDistance0 = this.JointPriorityDistance0;
    _o.JointMaxPriority0 = this.JointMaxPriority0;
    _o.JointPriorityDistance1 = this.JointPriorityDistance1;
    _o.JointMaxPriority1 = this.JointMaxPriority1;
    _o.JointPriorityDistance2 = this.JointPriorityDistance2;
    _o.JointMaxPriority2 = this.JointMaxPriority2;
    _o.JointPriorityDistance3 = this.JointPriorityDistance3;
    _o.JointMaxPriority3 = this.JointMaxPriority3;
  }
  public static Offset<gfl.scene.fb.CharacterCreationComponent> Pack(FlatBufferBuilder builder, CharacterCreationComponentT _o) {
    if (_o == null) return default(Offset<gfl.scene.fb.CharacterCreationComponent>);
    var _filePath = _o.FilePath == null ? default(StringOffset) : builder.CreateString(_o.FilePath);
    return CreateCharacterCreationComponent(
      builder,
      _filePath,
      _o.AnimationSlot,
      _o.OverrideLodDistance,
      _o.LodDistance0,
      _o.LodDistance1,
      _o.LodDistance2,
      _o.JointPriorityEnabled,
      _o.JointPriorityDistance0,
      _o.JointMaxPriority0,
      _o.JointPriorityDistance1,
      _o.JointMaxPriority1,
      _o.JointPriorityDistance2,
      _o.JointMaxPriority2,
      _o.JointPriorityDistance3,
      _o.JointMaxPriority3);
  }
};

public class CharacterCreationComponentT
{
  [Newtonsoft.Json.JsonProperty("filePath")]
  public string FilePath { get; set; }
  [Newtonsoft.Json.JsonProperty("animationSlot")]
  public int AnimationSlot { get; set; }
  [Newtonsoft.Json.JsonProperty("overrideLodDistance")]
  public bool OverrideLodDistance { get; set; }
  [Newtonsoft.Json.JsonProperty("lodDistance0")]
  public float LodDistance0 { get; set; }
  [Newtonsoft.Json.JsonProperty("lodDistance1")]
  public float LodDistance1 { get; set; }
  [Newtonsoft.Json.JsonProperty("lodDistance2")]
  public float LodDistance2 { get; set; }
  [Newtonsoft.Json.JsonProperty("jointPriorityEnabled")]
  public bool JointPriorityEnabled { get; set; }
  [Newtonsoft.Json.JsonProperty("jointPriorityDistance0")]
  public float JointPriorityDistance0 { get; set; }
  [Newtonsoft.Json.JsonProperty("jointMaxPriority0")]
  public int JointMaxPriority0 { get; set; }
  [Newtonsoft.Json.JsonProperty("jointPriorityDistance1")]
  public float JointPriorityDistance1 { get; set; }
  [Newtonsoft.Json.JsonProperty("jointMaxPriority1")]
  public int JointMaxPriority1 { get; set; }
  [Newtonsoft.Json.JsonProperty("jointPriorityDistance2")]
  public float JointPriorityDistance2 { get; set; }
  [Newtonsoft.Json.JsonProperty("jointMaxPriority2")]
  public int JointMaxPriority2 { get; set; }
  [Newtonsoft.Json.JsonProperty("jointPriorityDistance3")]
  public float JointPriorityDistance3 { get; set; }
  [Newtonsoft.Json.JsonProperty("jointMaxPriority3")]
  public int JointMaxPriority3 { get; set; }

  public CharacterCreationComponentT() {
    this.FilePath = null;
    this.AnimationSlot = 0;
    this.OverrideLodDistance = false;
    this.LodDistance0 = 0.0f;
    this.LodDistance1 = 0.0f;
    this.LodDistance2 = 0.0f;
    this.JointPriorityEnabled = false;
    this.JointPriorityDistance0 = 0.0f;
    this.JointMaxPriority0 = 0;
    this.JointPriorityDistance1 = 0.0f;
    this.JointMaxPriority1 = 0;
    this.JointPriorityDistance2 = 0.0f;
    this.JointMaxPriority2 = 0;
    this.JointPriorityDistance3 = 0.0f;
    this.JointMaxPriority3 = 0;
  }

  public static CharacterCreationComponentT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<CharacterCreationComponentT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static CharacterCreationComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return CharacterCreationComponent.GetRootAsCharacterCreationComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    CharacterCreationComponent.FinishCharacterCreationComponentBuffer(fbb, CharacterCreationComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
