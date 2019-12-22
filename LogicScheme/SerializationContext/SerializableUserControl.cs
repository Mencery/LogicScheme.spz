using LogicScheme.ElementForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;
using System.Xml.Serialization;
using LogicScheme.Elements;

namespace LogicScheme
{
    [XmlInclude(typeof(SignalTrue))]
    [XmlInclude(typeof(SignalFalse))]
    [XmlInclude(typeof(And2in1))]
    // [XmlInclude(typeof(Nand2in1))]
    //  [XmlInclude(typeof(Or2in1))]
    //  [XmlInclude(typeof(Nor2in1))]
    //  [XmlInclude(typeof(Xor2in1))]
    //[XmlInclude(typeof(Not))]
    [Serializable]  
   public class SerializableUserControl
    {




        public void setControlObject(MyUserControl value)
        {
            Location = value.Location;

            element = value.element;

            try
            {
                Input1 = value.Input1.Checked;
                Input2 = value.Input2.Checked;
                Output = value.Output.Checked;


            }
            catch (NullReferenceException e)
            {

                Input1 = false;
                Input2 = false;
                Output = false;
            }
            try
            {
                label1 = value.label1.Text;

            }
            catch (NullReferenceException e)
            {
                label1 = "";
            }
            type = value.GetType().ToString();

        }

        public Point Location
        {
            get;
            set;

        }

        public Element element { get; set; }
        public bool Input1
        {
            get;set;
        }
        public bool Input2
        {
            get; set;
        }
        public bool Output
        {
            get; set;
        }
        public string label1 { get; set; }
       
        public SerializableUserControl()
        {
          
        }
        public string type { get; set; }



    }
}
