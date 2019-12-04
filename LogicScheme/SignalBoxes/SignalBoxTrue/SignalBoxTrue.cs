
using System.Windows.Forms;
using LogicScheme.Elements;
using LogicScheme.Algorithm;
namespace LogicScheme.SignalBox
{
    class SignalBoxTrue : UserControl, IElementForm
    {
        private SignalTrue signalTrue;
       
        private RadioButton TrueButton;
        private RadioButton[] ports;
       
        private Label True;
    
        private System.ComponentModel.IContainer components;


        public SignalBoxTrue(){
            signalTrue = new SignalTrue();
          
            ports = new RadioButton[1];
            InitializeComponent();
            ports[0] = TrueButton;
           
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TrueButton = new System.Windows.Forms.RadioButton();
            this.True = new System.Windows.Forms.Label();
            
            this.SuspendLayout();
            // 
            // TrueButton
            // 
            this.TrueButton.AutoCheck = false;
            this.TrueButton.AutoSize = true;
            this.TrueButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TrueButton.Location = new System.Drawing.Point(34, 3);
            this.TrueButton.Name = "TrueButton";
            this.TrueButton.Size = new System.Drawing.Size(14, 13);
            this.TrueButton.TabIndex = 0;
            this.TrueButton.TabStop = true;
            this.TrueButton.UseMnemonic = false;
            this.TrueButton.UseVisualStyleBackColor = true;
            this.TrueButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RadioButton_MouseDown);
            this.TrueButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RadioButton_MouseMove);
            this.TrueButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RadioButton_MouseUp);
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
            this.Controls.Add(this.TrueButton);
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

         
                return signalTrue;
           
           
             
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
