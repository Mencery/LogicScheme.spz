using LogicScheme.ElementForm;
using LogicScheme.SerializationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme.Algorithm
{
    class RecoverContext
    {
        public static void recovery(Form1 form1,SerializableContext context)
        {
            foreach(var usercontrol in context.serializableUserControls)
            {
                setUserControl(usercontrol, form1);
            }
            form1.drawedLines = context.drawLines;
           form1.Invalidate();
        }
        
        private static void setUserControl(SerializableUserControl control, Form1 form1)
        {
           
       


            switch (control.type)
            {
                case "LogicScheme.SignalBox.SignalBoxTrue":
                    ((MyUserControl)form1.userControls[0]).Output.Checked = control.Output;
                    break;
                case "LogicScheme.SignalBoxes.SignalBoxFalse":
                    ((MyUserControl)form1.userControls[1]).Output.Checked = control.Output;
                    break;
                case "LogicScheme.AndElement":
                    var and = new AndElement();
                    and.label1.Text = control.label1;
                    and.element = control.element;
                    and.Output.Checked = control.Output;
                    and.Input1.Checked = control.Input1;
                    and.Input2.Checked = control.Input2;
                    СreateElement.create
                        (form1, and, form1.userControls, control.Location.X, control.Location.Y);
                    break;
            }
        }
    }

}
