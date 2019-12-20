using System.Collections.Generic;

using System.Drawing;

using System.Windows.Forms;

namespace LogicScheme.Algorithm
{
    class СreateElement
    {
        public static void create(Form1 form, UserControl el, List<UserControl> userControls, MouseEventArgs e)
        {
            el.Size = new Size(108, 48);
            el.Location = new Point(e.X, e.Y);






            el.MouseDown += new MouseEventHandler(form.element_MouseDown);
            
            el.MouseUp += new MouseEventHandler(form.element_MouseUp);
            el.MouseMove += new MouseEventHandler(form.element_MouseMove);
           
            el.Visible = true;



            userControls.Add(el);
            form.Controls.Add(el);
        }
        public static void create(Form1 form, UserControl el, List<UserControl> userControls, int  positionX, int positionY)
        {
            el.Size = new Size(108, 48);
            el.Location = new Point(positionX, positionY);






            el.MouseDown += new MouseEventHandler(form.element_MouseDown);

            el.MouseUp += new MouseEventHandler(form.element_MouseUp);
            el.MouseMove += new MouseEventHandler(form.element_MouseMove);

            el.Visible = true;



            userControls.Add(el);
            form.Controls.Add(el);
        }
    }
}
