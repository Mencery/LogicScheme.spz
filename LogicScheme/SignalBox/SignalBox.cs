
using System.Windows.Forms;
using LogicScheme.Elements;
using LogicScheme.Algorithm;
namespace LogicScheme.SignalBox
{
    class SignalBox : UserControl, IElementForm
    {
        private SignalTrue signalTrue;
        private SignalFalse signalFalse;
        private RadioButton TrueButton;
        private RadioButton[] ports;
        private int indexOfConnectPort = -1;
        private Label True;
        private Label False;
        private BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;
        private RadioButton FalseButton;


        public SignalBox(){
            signalTrue = new SignalTrue();
            signalFalse = new SignalFalse();
            ports = new RadioButton[2];
            InitializeComponent();
            ports[0] = TrueButton;
            ports[1] = FalseButton;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TrueButton = new System.Windows.Forms.RadioButton();
            this.True = new System.Windows.Forms.Label();
            this.False = new System.Windows.Forms.Label();
            this.FalseButton = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            // False
            // 
            this.False.AutoSize = true;
            this.False.Location = new System.Drawing.Point(-1, 36);
            this.False.Name = "False";
            this.False.Size = new System.Drawing.Size(32, 13);
            this.False.TabIndex = 3;
            this.False.Text = "False";
            // 
            // FalseButton
            // 
            this.FalseButton.AutoSize = true;
            this.FalseButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FalseButton.Location = new System.Drawing.Point(34, 36);
            this.FalseButton.Name = "FalseButton";
            this.FalseButton.Size = new System.Drawing.Size(14, 13);
            this.FalseButton.TabIndex = 2;
            this.FalseButton.TabStop = true;
            this.FalseButton.UseMnemonic = false;
            this.FalseButton.UseVisualStyleBackColor = true;
            this.FalseButton.CheckedChanged += new System.EventHandler(this.FalseButton_CheckedChanged);
            this.FalseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RadioButton_MouseDown);
            this.FalseButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RadioButton_MouseMove);
            this.FalseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RadioButton_MouseUp);
            // 
            // SignalBox
            // 
            this.Controls.Add(this.False);
            this.Controls.Add(this.FalseButton);
            this.Controls.Add(this.True);
            this.Controls.Add(this.TrueButton);
            this.Name = "SignalBox";
            this.Size = new System.Drawing.Size(51, 53);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FalseButton_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void RadioButton_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < ports.Length; i++)
            {
                if (ports[i] == sender)
                {
                    indexOfConnectPort = i;
                    break;
                }
            }
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
            return indexOfConnectPort;
        }
        public Element getElement()
        {
            
            return indexOfConnectPort== 0 ? signalTrue as Element: signalFalse;
        }
        public void connectPortChecked()
        {
            ports[indexOfConnectPort].Checked = true;
        }
    }
}
