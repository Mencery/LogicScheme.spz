using LogicScheme.ElementForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme.Algorithm
{
    class Disconect
    {
        public static void disconnect(MyUserControl control)
        {
            control.element.disconnect();
            control.Input1.Checked = false;
            control.Input2.Checked = false;
            control.Output.Checked = false;
            control.label1.Text = "X";
        }
    }
}
