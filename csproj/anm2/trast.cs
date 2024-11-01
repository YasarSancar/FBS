// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace gfl.anm2.fbj
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct StateTemplate : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static StateTemplate GetRootAsStateTemplate(ByteBuffer _bb) { return GetRootAsStateTemplate(_bb, new StateTemplate()); }
  public static StateTemplate GetRootAsStateTemplate(ByteBuffer _bb, StateTemplate obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public StateTemplate __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public gfl.anm2.fbj.ParameterConfig? ParameterConfig { get { int o = __p.__offset(4); return o != 0 ? (gfl.anm2.fbj.ParameterConfig?)(new gfl.anm2.fbj.ParameterConfig()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public gfl.anm2.fbj.State? State { get { int o = __p.__offset(6); return o != 0 ? (gfl.anm2.fbj.State?)(new gfl.anm2.fbj.State()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<gfl.anm2.fbj.StateTemplate> CreateStateTemplate(FlatBufferBuilder builder,
      Offset<gfl.anm2.fbj.ParameterConfig> parameterConfigOffset = default(Offset<gfl.anm2.fbj.ParameterConfig>),
      Offset<gfl.anm2.fbj.State> stateOffset = default(Offset<gfl.anm2.fbj.State>)) {
    builder.StartTable(2);
    StateTemplate.AddState(builder, stateOffset);
    StateTemplate.AddParameterConfig(builder, parameterConfigOffset);
    return StateTemplate.EndStateTemplate(builder);
  }

  public static void StartStateTemplate(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddParameterConfig(FlatBufferBuilder builder, Offset<gfl.anm2.fbj.ParameterConfig> parameterConfigOffset) { builder.AddOffset(0, parameterConfigOffset.Value, 0); }
  public static void AddState(FlatBufferBuilder builder, Offset<gfl.anm2.fbj.State> stateOffset) { builder.AddOffset(1, stateOffset.Value, 0); }
  public static Offset<gfl.anm2.fbj.StateTemplate> EndStateTemplate(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<gfl.anm2.fbj.StateTemplate>(o);
  }
  public static void FinishStateTemplateBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fbj.StateTemplate> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedStateTemplateBuffer(FlatBufferBuilder builder, Offset<gfl.anm2.fbj.StateTemplate> offset) { builder.FinishSizePrefixed(offset.Value); }
  public StateTemplateT UnPack() {
    var _o = new StateTemplateT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(StateTemplateT _o) {
    _o.ParameterConfig = this.ParameterConfig.HasValue ? this.ParameterConfig.Value.UnPack() : null;
    _o.State = this.State.HasValue ? this.State.Value.UnPack() : null;
  }
  public static Offset<gfl.anm2.fbj.StateTemplate> Pack(FlatBufferBuilder builder, StateTemplateT _o) {
    if (_o == null) return default(Offset<gfl.anm2.fbj.StateTemplate>);
    var _parameterConfig = _o.ParameterConfig == null ? default(Offset<gfl.anm2.fbj.ParameterConfig>) : gfl.anm2.fbj.ParameterConfig.Pack(builder, _o.ParameterConfig);
    var _state = _o.State == null ? default(Offset<gfl.anm2.fbj.State>) : gfl.anm2.fbj.State.Pack(builder, _o.State);
    return CreateStateTemplate(
      builder,
      _parameterConfig,
      _state);
  }
};

public class StateTemplateT
{
  [Newtonsoft.Json.JsonProperty("parameterConfig")]
  public gfl.anm2.fbj.ParameterConfigT ParameterConfig { get; set; }
  [Newtonsoft.Json.JsonProperty("state")]
  public gfl.anm2.fbj.StateT State { get; set; }

  public StateTemplateT() {
    this.ParameterConfig = null;
    this.State = null;
  }

  public static StateTemplateT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<StateTemplateT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static StateTemplateT DeserializeFromBinary(byte[] fbBuffer) {
    return StateTemplate.GetRootAsStateTemplate(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    StateTemplate.FinishStateTemplateBuffer(fbb, StateTemplate.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
