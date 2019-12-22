using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using LogicScheme.SerializationContext;
using System.IO;
using LogicScheme.Algorithm;
using System.Runtime.Serialization.Json;

namespace LogicScheme.Serialization.Save
{
    class SaveAsJSON : ISave
    {
        public void execute(string path, List<UserControl> userControls, List<DrawLine> drawedLines)
        {
            DataContractJsonSerializer dataContractSerializer;
               
            using (MemoryStream memoryStream = new MemoryStream())
            {



                dataContractSerializer = new DataContractJsonSerializer(typeof(SerializableContext),
                    new Type[] { typeof(SerializableContext), typeof(DrawLine) });
                dataContractSerializer.WriteObject(memoryStream, FillSerializebleContext.fill(userControls, drawedLines));
                string temp = Encoding.UTF8.GetString(memoryStream.ToArray());
                File.WriteAllText(path, temp);



            }
        }
    }
}
