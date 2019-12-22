
using System.Windows.Forms;
using LogicScheme.Elements;
using LogicScheme.Algorithm;
using System;
using LogicScheme.ElementForm;

namespace LogicScheme.SignalBoxes
{
    [Serializable]
   public class SignalBoxTrue : MyUserControl, IElementForm
    {
        
        private Label True;
    
        private System.ComponentModel.IContainer components;


        public SignalBoxTrue(){
         
          
            ports = new RadioButton[1];
            element = new SignalTrue();
            InitializeComponent();
            ports[0] = Output;
           
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
          
            this.True = new System.Windows.Forms.Label();
            
            this.SuspendLayout();
            // 
            // TrueButton
            // 
            this.Output.AutoCheck = false;
            this.Output.AutoSize = true;
            this.Output.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Output.Location = new System.Drawing.Point(34, 3);
            this.Output.Name = "TrueButton";
            this.Output.Size = new System.Drawing.Size(14, 13);
            this.Output.TabIndex = 0;
            this.Output.TabStop = true;
            this.Output.UseMnemonic = false;
            this.Output.UseVisualStyleBackColor = true;
            this.Output.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RadioButton_MouseDown);
            this.Output.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RadioButton_MouseMove);
            this.Output.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RadioButton_MouseUp);
            // 
            // True
            // 
            this.True.AutoSize = true;
            this.True.Location = new System.Drawing.Point(-1, 0);
            this.True.Name = "True";
            this.True.Size = new System.Drawing.Size(29, 13);
            this.True.TabIndex = 1;
            this.True.Text = "True";
            // 
            // SignalBoxTrue
            // 
            this.Controls.Add(this.True);
            this.Controls.Add(this.Output);
            this.Name = "SignalBoxTrue";
            this.Size = new System.Drawing.Size(51, 18);
            this.Load += new System.EventHandler(this.SignalBox_Load);
            
            this.ResumeLayout(false);
            this.PerformLayout();

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

        public bool getElementByPosition(MouseEventArgs e, UserControl input)
        {
            return GetElementByPosition.execute(e,input,this,ports);
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

        private void SignalBox_Load(object sender, System.EventArgs e)
        {

        }
    }
}
