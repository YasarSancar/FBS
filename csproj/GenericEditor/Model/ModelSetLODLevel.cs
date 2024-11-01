// <auto-generated />


namespace GenericEditor.Plugin.Model
{
    public class ModelSetLODLevel
    {
        [Newtonsoft.Json.JsonProperty("instanceName")]
        public string InstanceName { get; set; }

        [Newtonsoft.Json.JsonProperty("level")]
        public int Level { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty("dataType")]
        public GenericEditor.Plugin.Model.DataType DataType { get; set; } = (GenericEditor.Plugin.Model.DataType)13;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static GenericEditor.Plugin.Model.ModelSetLODLevel FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericEditor.Plugin.Model.ModelSetLODLevel>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static GenericEditor.Plugin.Model.ModelSetLODLevel FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "";

        public static readonly string BFBS_BASE64 = "GAAAAEJGQlMQABwABAAIAAwAEAAUABgAEAAAADQAAAAoAAAAHAAAABAAAAAkBAAABAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAQAAAAwAAAABAAAA/AMAABT8//9gAAAAFAAAAAQAAACe+///AAAACAAAAAARAAAAqAMAAHADAAA0AwAA+AIAAMQCAACQAgAAXAIAACgCAAD0AQAAwAEAAIwBAABQAQAAFAEAAOAAAACkAAAAaAAAACwAAAAjAAAAR2VuZXJpY0VkaXRvci5QbHVnaW4uTW9kZWwuRGF0YVR5cGUAPP3//xgAAAAQAAAAEAAAAAAAAAAAAAAA0Pz//xUAAABNb2RlbFByZXZpZXdXaXJlRnJhbWUAAAA8/f//FAAAAAwAAAAPAAAAAAAAAAT9//8bAAAATW9kZWxMYXR0aWNlRGVidWdEcmF3RW5hYmxlAKz9//8YAAAAEAAAAA4AAAAAAAAAAAAAAED9//8WAAAATW9kZWxMYXR0aWNlVXBkYXRlRGF0YQAArP3//xQAAAAMAAAADQAAAAAAAAB0/f//EAAAAE1vZGVsU2V0TE9ETGV2ZWwAAAAA3P3//xQAAAAMAAAADAAAAAAAAACk/f//GQAAAE1vZGVsUHJldmlld1NldFZpc2liaWxpdHkAAAAU/v//FAAAAAwAAAALAAAAAAAAANz9//8ZAAAATW9kZWxCbGVuZFNoYXBlVXBkYXRlRGF0YQAAAIT+//8YAAAAEAAAAAoAAAAAAAAAAAAAABj+//8OAAAAUmVtb3ZlTW9kZWxBbGwAAHz+//8UAAAADAAAAAkAAAAAAAAARP7//xAAAABBbGlnbk1vZGVsU1JUQWxsAAAAAKz+//8UAAAADAAAAAgAAAAAAAAAdP7//xAAAABSZXNldE1vZGVsU1JUQWxsAAAAABT///8YAAAAEAAAAAcAAAAAAAAAAAAAAKj+//8OAAAATW9kZWxSZXNldFBvc2UAAET///8YAAAAEAAAAAYAAAAAAAAAAAAAANj+//8OAAAATW9kZWxJbnZpc2libGUAAHT///8YAAAAEAAAAAUAAAAAAAAAAAAAAAj///8MAAAATW9kZWxWaXNpYmxlAAAAAKT///8YAAAAEAAAAAQAAAAAAAAAAAAAADj///8OAAAATW9kZWxTUlRVcGRhdGUAAJz///8UAAAADAAAAAMAAAAAAAAAZP///w0AAABNb2RlbERlc2VsZWN0AAAADAAYAAQADAAAAAgADAAAABgAAAAQAAAAAgAAAAAAAAAAAAAAoP///wsAAABNb2RlbFNlbGVjdAAMABQABAAMAAAACAAMAAAAFAAAAAwAAAABAAAAAAAAANT///8LAAAATW9kZWxSZW1vdmUADAAMAAQAAAAAAAgADAAAABAAAAAIAAAABAAEAAQAAAAJAAAATW9kZWxMb2FkAAAADAAQAAQACAAAAAwADAAAABwAAAAIAAAAAQAAAAMAAABMAAAAxAAAAJAAAAArAAAAR2VuZXJpY0VkaXRvci5QbHVnaW4uTW9kZWwuTW9kZWxTZXRMT0RMZXZlbAAAAA4AGgAIAAwABAAGABAADgAAAAIACAAoAAAAGAAAAA0AAAAAAAAAAAAKAAwABwAAAAgACgAAAAAAAAgAAAAACAAAAGRhdGFUeXBlAAAAAAwAEAAIAAwABAAGAAwAAAABAAYAEAAAAAQAAADO////AAAABwUAAABsZXZlbAAAAAwAEgAIAAwAAAAGAAwAAAAAAAQAGAAAAAwAAAAAAAYACAAHAAYAAAAAAAANDAAAAGluc3RhbmNlTmFtZQAAAAA=";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }
}
