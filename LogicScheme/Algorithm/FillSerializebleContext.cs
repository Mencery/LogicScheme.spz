using LogicScheme.ElementForm;
using LogicScheme.SerializationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicScheme.Algorithm
{
    class FillSerializebleContext
    {
        public static SerializableContext fill(List<UserControl> userControls, List<DrawLine> drawLines)
        {
            SerializableContext serializableContext = new SerializableContext();
           
            SerializableUserControl temp;
            foreach (var element in userControls)
            {
                temp = new SerializableUserControl();
                temp.setControlObject(element as MyUserControl);
                serializableContext.serializableUserControls.Add(temp);
            }
            
            foreach (var line in drawLines)
            {
                serializableContext.drawLines.Add(line);
            }


                return serializableContext;
        }
    }
}
