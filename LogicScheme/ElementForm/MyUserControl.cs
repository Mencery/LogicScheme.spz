using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


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
        [XmlIgnore] bool IsDragMode = true;
        [XmlIgnore]  Point DownPoint;
        public MyUserControl()
        {
            Input2 = new System.Windows.Forms.RadioButton();
            Input1 = new System.Windows.Forms.RadioButton();
            Output = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DownPoint = e.Location;
                IsDragMode = true;
                
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                IsDragMode = false;
               
            }
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //если кнопка мыши нажата
                if (IsDragMode)
                {
                    Point p = e.Location;
                    //вычисляем разницу в координатах между положением курсора и "нулевой" точкой кнопки
                    Point dp = new Point(p.X - DownPoint.X, p.Y - DownPoint.Y);
                    Location = new Point(Location.X + dp.X, Location.Y + dp.Y);
                }
                
            }
            base.OnMouseMove(e);
        }
    

}
}
