using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicScheme.ElementForm
{
   
     public  class MyUserControl : UserControl
    {
        public RadioButton Output { get; set; }
        public RadioButton[] ports { get; set; }
        public RadioButton Input2 { get; set; }
        public RadioButton Input1 { get; set; }
        public Label label1 { get; set; }
        public Element element { get; set; }

       public MyUserControl()
        {
            Input2 = new System.Windows.Forms.RadioButton();
            Input1 = new System.Windows.Forms.RadioButton();
            Output = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
        }


    }
}
