using System;
using System.Windows.Forms;
using LogicScheme.Algorithm;
using LogicScheme.ElementForm;
using LogicScheme.Elements;

namespace LogicScheme
{
    [Serializable]
    public partial class NotElement : MyUserControl, IElementForm
    {

     
       
        
        private int indexOfConnectPort = -1;
       
      
       

        public NotElement()
        {

            element = new Not();

            InitializeComponent();
            label1.Text = element.Output.ToString();
            ports = new RadioButton[2];
            ports[0] = Output;
            ports[1] = Input1;
         
           


        }

        private void InitializeComponent()
        {
            this.Input1 = new System.Windows.Forms.RadioButton();
            this.Output = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input1
            // 
            this.Input1.AutoCheck = false;
            this.Input1.AutoSize = true;
            this.Input1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Input1.Location = new System.Drawing.Point(4, 18);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(14, 13);
            this.Input1.TabIndex = 1;
            this.Input1.TabStop = true;
            this.Input1.UseMnemonic = false;
            this.Input1.UseVisualStyleBackColor = true;
            this.Input1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            this.Input1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Output_MouseDown);
            this.Input1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Output_MouseMove);
            this.Input1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Output_MouseUp);
            // 
            // Output
            // 
            this.Output.AutoCheck = false;
            this.Output.AutoSize = true;
            this.Output.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Output.Location = new System.Drawing.Point(95, 18);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(14, 13);
            this.Output.TabIndex = 2;
            this.Output.TabStop = true;
            this.Output.UseMnemonic = false;
            this.Output.UseVisualStyleBackColor = true;
            this.Output.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Output_MouseDown);
            this.Output.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Output_MouseMove);
            this.Output.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Output_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // NotElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::LogicScheme.Properties.Resources.Not;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "NotElement";
            this.Size = new System.Drawing.Size(110, 48);
            this.Click += new System.EventHandler(this.OrElement_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        public void Output_MouseDown(object sender, MouseEventArgs e)
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

        public void Output_MouseUp(object sender, MouseEventArgs e)
        {



            OnMouseUp(new MouseEventArgs(e.Button, e.Clicks, (sender as RadioButton).Location.X + e.X, (sender as RadioButton).Location.Y + e.Y, e.Delta));


        }



        private void Output_MouseMove(object sender, MouseEventArgs e)
        {


            OnMouseMove(new MouseEventArgs(e.Button, e.Clicks, (sender as RadioButton).Location.X + e.X, (sender as RadioButton).Location.Y + e.Y, e.Delta));

        }

        public bool getElementByPosition(MouseEventArgs e, UserControl input)
        {
            return GetElementByPosition.execute(e, input, this, ports);
        }

        public int getIndexOfPortThatConnect()
        {
            return indexOfConnectPort;
        }
        public Element getElement()
        {
            return element;
        }
        public void connectPortChecked()
        {

            ports[indexOfConnectPort].Checked = true;

        }

        private void OrElement_Click(object sender, EventArgs e)
        {
            label1.Text = element.Output.ToString();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = element.Output.ToString();
        }

    }
}

