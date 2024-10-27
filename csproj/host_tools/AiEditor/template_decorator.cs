// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace AiEditor.Fb.Template
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct Decorator : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static Decorator GetRootAsDecorator(ByteBuffer _bb) { return GetRootAsDecorator(_bb, new Decorator()); }
  public static Decorator GetRootAsDecorator(ByteBuffer _bb, Decorator obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Decorator __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public AiEditor.Fb.Template.Parameter? Parameters(int j) { int o = __p.__offset(6); return o != 0 ? (AiEditor.Fb.Template.Parameter?)(new AiEditor.Fb.Template.Parameter()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ParametersLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<AiEditor.Fb.Template.Decorator> CreateDecorator(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      VectorOffset parametersOffset = default(VectorOffset)) {
    builder.StartTable(2);
    Decorator.AddParameters(builder, parametersOffset);
    Decorator.AddName(builder, nameOffset);
    return Decorator.EndDecorator(builder);
  }

  public static void StartDecorator(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddParameters(FlatBufferBuilder builder, VectorOffset parametersOffset) { builder.AddOffset(1, parametersOffset.Value, 0); }
  public static VectorOffset CreateParametersVector(FlatBufferBuilder builder, Offset<AiEditor.Fb.Template.Parameter>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateParametersVectorBlock(FlatBufferBuilder builder, Offset<AiEditor.Fb.Template.Parameter>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartParametersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<AiEditor.Fb.Template.Decorator> EndDecorator(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<AiEditor.Fb.Template.Decorator>(o);
  }
  public static void FinishDecoratorBuffer(FlatBufferBuilder builder, Offset<AiEditor.Fb.Template.Decorator> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedDecoratorBuffer(FlatBufferBuilder builder, Offset<AiEditor.Fb.Template.Decorator> offset) { builder.FinishSizePrefixed(offset.Value); }
  public DecoratorT UnPack() {
    var _o = new DecoratorT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(DecoratorT _o) {
    _o.Name = this.Name;
    _o.Parameters = new List<AiEditor.Fb.Template.ParameterT>();
    for (var _j = 0; _j < this.ParametersLength; ++_j) {_o.Parameters.Add(this.Parameters(_j).HasValue ? this.Parameters(_j).Value.UnPack() : null);}
  }
  public static Offset<AiEditor.Fb.Template.Decorator> Pack(FlatBufferBuilder builder, DecoratorT _o) {
    if (_o == null) return default(Offset<AiEditor.Fb.Template.Decorator>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _parameters = default(VectorOffset);
    if (_o.Parameters != null) {
      var __parameters = new Offset<AiEditor.Fb.Template.Parameter>[_o.Parameters.Count];
      for (var _j = 0; _j < __parameters.Length; ++_j) { __parameters[_j] = AiEditor.Fb.Template.Parameter.Pack(builder, _o.Parameters[_j]); }
      _parameters = CreateParametersVector(builder, __parameters);
    }
    return CreateDecorator(
      builder,
      _name,
      _parameters);
  }
};

public class DecoratorT
{
  [Newtonsoft.Json.JsonProperty("name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("parameters")]
  public List<AiEditor.Fb.Template.ParameterT> Parameters { get; set; }

  public DecoratorT() {
    this.Name = null;
    this.Parameters = null;
  }

  public static DecoratorT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<DecoratorT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static DecoratorT DeserializeFromBinary(byte[] fbBuffer) {
    return Decorator.GetRootAsDecorator(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    Decorator.FinishDecoratorBuffer(fbb, Decorator.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
