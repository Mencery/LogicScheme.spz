using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using LogicScheme.SerializationContext;

namespace LogicScheme.Serialization.Load
{
    class LoadBmp : ILoad
    {
        XmlSerializer formatterForContext;
        SerializableContext context;


        public SerializableContext execute(string path)
        {
            path = path.Remove(path.Length - 4);
            path = String.Concat(path, ".xml");
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {

                formatterForContext = new XmlSerializer
                      (typeof(SerializableContext));

                context =
                    formatterForContext.Deserialize(fs) as SerializableContext;


            }
            return context;
        }
    }
}
