using LogicScheme.Algorithm;
using LogicScheme.SerializationContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LogicScheme.Serialization.Save
{
    class SaveScreenShot : ISave
    {
        public void execute(string path, List<UserControl> userControls, List<DrawLine> drawedLines)
        {


            XmlSerializer formatterForUserControls;


            path =path.Remove(path.Length - 4);
            path =  String.Concat(path,".xml");

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {



                formatterForUserControls = new XmlSerializer
                    (typeof(SerializableContext),
                    new Type[] { typeof(SerializableContext), typeof(DrawLine) });

                formatterForUserControls.Serialize(fs,
                    FillSerializebleContext.fill(userControls, drawedLines));


            }

        }
    }
}
