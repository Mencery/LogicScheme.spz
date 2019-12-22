
using LogicScheme.Algorithm;
using LogicScheme.ElementForm;
using LogicScheme.SerializationContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LogicScheme.Serialization
{
    class SaveAsXML : ISave
    {
        public void execute( string path, List<UserControl> userControls, List<DrawLine> drawedLines)
        {


            XmlSerializer formatterForUserControls;
           
           
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                
              

                    formatterForUserControls = new XmlSerializer
                        (typeof(SerializableContext),
                        new Type[] { typeof(SerializableContext),typeof(DrawLine) });

                    formatterForUserControls.Serialize(fs,
                        FillSerializebleContext.fill(userControls,drawedLines));
                    
                    

                

                

                


            }

        }
    }
}
