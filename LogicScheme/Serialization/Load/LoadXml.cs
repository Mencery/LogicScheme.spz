using LogicScheme.SerializationContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LogicScheme.Serialization.Load
{
    class LoadXml:ILoad
    {
        XmlSerializer formatterForContext;
        SerializableContext context;


        public SerializableContext execute(string path)
        {
          
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
