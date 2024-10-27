// <auto-generated />


namespace GenericEditor.Plugin.Model
{
    public class ModelLatticeUpdateData
    {
        [Newtonsoft.Json.JsonProperty("instanceName")]
        public string InstanceName { get; set; }

        [Newtonsoft.Json.JsonProperty("latticeName")]
        public string LatticeName { get; set; }

        [Newtonsoft.Json.JsonProperty("weight")]
        public float Weight { get; set; } = 0.0f;

        [Newtonsoft.Json.JsonProperty("dataType")]
        public GenericEditor.Plugin.Model.DataType DataType { get; set; } = (GenericEditor.Plugin.Model.DataType)14;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static GenericEditor.Plugin.Model.ModelLatticeUpdateData FromJson(string jsonText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericEditor.Plugin.Model.ModelLatticeUpdateData>(jsonText);
        }

        public byte[] ToFlatBuffers()
        {
            var jsonText = this.ToJson();
            return GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonToFlatBuffers(jsonText, BFBS);
        }

        public static GenericEditor.Plugin.Model.ModelLatticeUpdateData FromFlatBuffers(byte[] fb)
        {
            var jsonText = GameFreak.FlatBuffersHelper.FlatBuffersConvert.JsonFromFlatBuffers(fb, BFBS);
            return FromJson(jsonText);
        }

        public static readonly string FileIdentifier = "";

        public static readonly string FileExtension = "";

        public static readonly string BFBS_BASE64 = "GAAAAEJGQlMQABwABAAIAAwAEAAUABgAEAAAADQAAAAoAAAAHAAAABAAAAAkBAAABAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAQAAAAwAAAABAAAA/AMAABT8//9gAAAAFAAAAAQAAACW+///AAAACAAAAAARAAAAqAMAAHADAAA0AwAA+AIAAMQCAACQAgAAXAIAACgCAAD0AQAAwAEAAIwBAABQAQAAFAEAAOAAAACkAAAAaAAAACwAAAAjAAAAR2VuZXJpY0VkaXRvci5QbHVnaW4uTW9kZWwuRGF0YVR5cGUAPP3//xgAAAAQAAAAEAAAAAAAAAAAAAAA0Pz//xUAAABNb2RlbFByZXZpZXdXaXJlRnJhbWUAAAA8/f//FAAAAAwAAAAPAAAAAAAAAAT9//8bAAAATW9kZWxMYXR0aWNlRGVidWdEcmF3RW5hYmxlAKz9//8YAAAAEAAAAA4AAAAAAAAAAAAAAED9//8WAAAATW9kZWxMYXR0aWNlVXBkYXRlRGF0YQAArP3//xQAAAAMAAAADQAAAAAAAAB0/f//EAAAAE1vZGVsU2V0TE9ETGV2ZWwAAAAA3P3//xQAAAAMAAAADAAAAAAAAACk/f//GQAAAE1vZGVsUHJldmlld1NldFZpc2liaWxpdHkAAAAU/v//FAAAAAwAAAALAAAAAAAAANz9//8ZAAAATW9kZWxCbGVuZFNoYXBlVXBkYXRlRGF0YQAAAIT+//8YAAAAEAAAAAoAAAAAAAAAAAAAABj+//8OAAAAUmVtb3ZlTW9kZWxBbGwAAHz+//8UAAAADAAAAAkAAAAAAAAARP7//xAAAABBbGlnbk1vZGVsU1JUQWxsAAAAAKz+//8UAAAADAAAAAgAAAAAAAAAdP7//xAAAABSZXNldE1vZGVsU1JUQWxsAAAAABT///8YAAAAEAAAAAcAAAAAAAAAAAAAAKj+//8OAAAATW9kZWxSZXNldFBvc2UAAET///8YAAAAEAAAAAYAAAAAAAAAAAAAANj+//8OAAAATW9kZWxJbnZpc2libGUAAHT///8YAAAAEAAAAAUAAAAAAAAAAAAAAAj///8MAAAATW9kZWxWaXNpYmxlAAAAAKT///8YAAAAEAAAAAQAAAAAAAAAAAAAADj///8OAAAATW9kZWxTUlRVcGRhdGUAAJz///8UAAAADAAAAAMAAAAAAAAAZP///w0AAABNb2RlbERlc2VsZWN0AAAADAAYAAQADAAAAAgADAAAABgAAAAQAAAAAgAAAAAAAAAAAAAAoP///wsAAABNb2RlbFNlbGVjdAAMABQABAAMAAAACAAMAAAAFAAAAAwAAAABAAAAAAAAANT///8LAAAATW9kZWxSZW1vdmUADAAMAAQAAAAAAAgADAAAABAAAAAIAAAABAAEAAQAAAAJAAAATW9kZWxMb2FkAAAADAAQAAQACAAAAAwADAAAACAAAAAIAAAAAQAAAAQAAABUAAAA9AAAALwAAACIAAAAMQAAAEdlbmVyaWNFZGl0b3IuUGx1Z2luLk1vZGVsLk1vZGVsTGF0dGljZVVwZGF0ZURhdGEADgAaAAgADAAEAAYAEAAOAAAAAwAKACgAAAAYAAAADgAAAAAAAAAAAAoADAAHAAAACAAKAAAAAAAACAAAAAAIAAAAZGF0YVR5cGUAAAAA3P///wIACAAQAAAABAAAAJr///8AAAALBgAAAHdlaWdodAAADAAQAAgADAAEAAYADAAAAAEABgAQAAAABAAAAMr///8AAAANCwAAAGxhdHRpY2VOYW1lAAwAEgAIAAwAAAAGAAwAAAAAAAQAGAAAAAwAAAAAAAYACAAHAAYAAAAAAAANDAAAAGluc3RhbmNlTmFtZQAAAAA=";

        public static byte[] BFBS => System.Convert.FromBase64String(BFBS_BASE64);
    }
}