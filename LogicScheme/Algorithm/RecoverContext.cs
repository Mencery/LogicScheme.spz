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
            foreach ( var element in form1.userControls)
            {
                form1.Controls.Remove(element);
            }
            
            form1.userControls.Clear();
            form1.userControls.Add(form1.signalBoxTrue1);
            form1.Controls.Add(form1.signalBoxTrue1);
           form1.userControls.Add(form1.signalBoxFalse1);
            form1.Controls.Add(form1.signalBoxFalse1);
            form1.drawedLines.Clear();
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
                case "LogicScheme.SignalBoxes.SignalBoxTrue":
                    ((MyUserControl)form1.userControls[0]).Output.Checked = control.Output;
                    break;
                case "LogicScheme.SignalBoxes.SignalBoxFalse":
                    ((MyUserControl)form1.userControls[1]).Output.Checked = control.Output;
                    break;
                case "LogicScheme.AndElement":
                    var and = new AndElement();
                    recoverFields(form1, and, control);
                    break;
                case "LogicScheme.NandElement":
                    var nand = new NandElement();
                    recoverFields(form1, nand, control);
                    break;
                case "LogicScheme.OrElement":
                    var or = new OrElement();
                    recoverFields(form1, or, control);
                    break;
                case "LogicScheme.NorElement":
                    var nor = new NorElement();
                    recoverFields(form1, nor, control);
                    break;
                case "LogicScheme.XorElement":
                    var xor = new XorElement();
                    recoverFields(form1, xor, control);
                    break;
                case "LogicScheme.NotElement":
                    var not = new NotElement();
                    recoverFields(form1, not, control);
                    break;
            }
        }
        private static void recoverFields(Form1 form1, MyUserControl ControlElement, 
            SerializableUserControl control) {
            ControlElement.label1.Text = control.label1;
            ControlElement.element = control.element;
            ControlElement.Output.Checked = control.Output;
            ControlElement.Input1.Checked = control.Input1;
            ControlElement.Input2.Checked = control.Input2;
            СreateElement.create
                (form1, ControlElement, form1.userControls, control.Location.X, control.Location.Y);
        }
    }
  
}
