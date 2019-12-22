using System.Windows.Forms;
using LogicScheme.Elements;
using LogicScheme.Algorithm;
using System;
using LogicScheme.ElementForm;

namespace LogicScheme.SignalBoxes
{
    [Serializable]
    public partial class SignalBoxFalse : MyUserControl, IElementForm
    {
        
      
        public SignalBoxFalse()
        {
            ports = new RadioButton[1];
            element = new SignalFalse();
            InitializeComponent();
            ports[0] = Output;
        }

        public bool getElementByPosition(MouseEventArgs e, UserControl input)
        {
            return GetElementByPosition.execute(e, input, this, ports);
        }

        public int getIndexOfPortThatConnect()
        {
            return 0;
        }
        public Element getElement()
        {


            return element;



        }
        public void connectPortChecked()
        {
            ports[0].Checked = true;
        }
        private void RadioButton_MouseDown(object sender, MouseEventArgs e)
        {

            OnMouseDown(new MouseEventArgs(e.Button, e.Clicks, (sender as RadioButton).Location.X + (sender as RadioButton).Size.Width / 2, (sender as RadioButton).Location.Y + (sender as RadioButton).Size.Height / 2, e.Delta));
        }

        private void RadioButton_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMove(new MouseEventArgs(e.Button, e.Clicks, (sender as RadioButton).Location.X + e.X, (sender as RadioButton).Location.Y + e.Y, e.Delta));
        }

        private void RadioButton_MouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUp(new MouseEventArgs(e.Button, e.Clicks, (sender as RadioButton).Location.X + e.X, (sender as RadioButton).Location.Y + e.Y, e.Delta));
        }

    }
}
