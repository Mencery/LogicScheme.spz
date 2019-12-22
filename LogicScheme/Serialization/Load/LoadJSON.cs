using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using LogicScheme.SerializationContext;

namespace LogicScheme.Serialization.Load
{
    class LoadJSON : ILoad
    {
        DataContractJsonSerializer dataContractSerializer;
        SerializableContext context;
        public SerializableContext execute(string path)
        {

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                dataContractSerializer = new DataContractJsonSerializer(typeof(SerializableContext),
                   new Type[] { typeof(SerializableContext), typeof(DrawLine) });
                context = dataContractSerializer.ReadObject(fs) as SerializableContext;
            }
            return context;
        }
    }
}
