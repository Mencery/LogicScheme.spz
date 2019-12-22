using LogicScheme.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LogicScheme.SerializationContext
{
    
   
    public class SerializableContext
    {
        public List<SerializableUserControl> serializableUserControls { get; set; }
        public List<DrawLine> drawLines { get; set; }
        public SerializableContext()
        {
            serializableUserControls = new List<SerializableUserControl>();
            drawLines = new List<DrawLine>();
        }
    }
}
