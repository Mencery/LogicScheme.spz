using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LogicScheme.SerializationContext
{

    [DataContract]
    public class SerializableContext
    {
        [DataMember]
        public List<SerializableUserControl> serializableUserControls { get; set; }
        [DataMember]
        public List<DrawLine> drawLines { get; set; }
        public SerializableContext()
        {
            serializableUserControls = new List<SerializableUserControl>();
            drawLines = new List<DrawLine>();
        }
    }
}
