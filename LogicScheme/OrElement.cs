using System;
using System.Windows.Forms;

namespace LogicScheme
{

    public partial class OrElement : UserControl, IElementForm
    {
        //TODO private 
        public RadioButton Input2;
        public RadioButton Input1;
        private RadioButton[] ports;
        private int indexOfConnectPort = -1;
        public RadioButton Output;
        Panel[] groupButtons;
        Or2in1 or2In1;

        public OrElement()
        {

            or2In1 = new Or2in1();

            InitializeComponent();
            ports = new RadioButton[3];
            ports[0] = Output;
            ports[1] = Input1;
            ports[2] = Input2;
            groupButtons = new Panel[ports.Length];


        }

        private void InitializeComponent()
        {
            this.Input2 = new System.Windows.Forms.RadioButton();
            this.Input1 = new System.Windows.Forms.RadioButton();
            this.Output = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Input2
            // 
            this.Input2.AutoCheck = false;
            this.Input2.AutoSize = true;
            this.Input2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Input2.Location = new System.Drawing.Point(12, 25);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(14, 13);
            this.Input2.TabIndex = 0;
            this.Input2.TabStop = true;
            this.Input2.UseMnemonic = false;
            this.Input2.UseVisualStyleBackColor = true;
            this.Input2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Output_MouseDown);
            this.Input2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Output_MouseMove);
            this.Input2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Output_MouseUp);
            // 
            // Input1
            // 
            this.Input1.AutoCheck = false;
            this.Input1.AutoSize = true;
            this.Input1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Input1.Location = new System.Drawing.Point(12, 6);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(14, 13);
            this.Input1.TabIndex = 1;
            this.Input1.TabStop = true;
            this.Input1.UseMnemonic = false;
            this.Input1.UseVisualStyleBackColor = true;
            this.Input1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Output_MouseDown);
            this.Input1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Output_MouseMove);
            this.Input1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Output_MouseUp);
            // 
            // Output
            // 
            this.Output.AutoCheck = false;
            this.Output.AutoSize = true;
            this.Output.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Output.Location = new System.Drawing.Point(94, 16);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(14, 13);
            this.Output.TabIndex = 2;
            this.Output.TabStop = true;
            this.Output.UseMnemonic = false;
            this.Output.UseVisualStyleBackColor = true;
            this.Output.CheckedChanged += new System.EventHandler(this.Output_CheckedChanged);
            this.Output.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Output_MouseClick);
            this.Output.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Output_MouseDown);
            this.Output.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Output_MouseMove);
            this.Output.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Output_MouseUp);
            // 
            // OrElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::LogicScheme.Properties.Resources._120px1;
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.Input2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "OrElement";
            this.Size = new System.Drawing.Size(108, 48);
            this.Load += new System.EventHandler(this.OrElement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OrElement_Load(object sender, EventArgs e)
        {

        }



        private void Output_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Output_CheckedChanged(object sender, EventArgs e)
        {

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
            int input_x = e.X + input.Location.X;
            int input_y = e.Y + input.Location.Y;
            int x, y;

            for (int i = 0; i < ports.Length; i++)
            {

                x = ports[i].Location.X + Location.X;
                y = ports[i].Location.Y + Location.Y;

                if (x <= input_x && x + ports[i].Width >= input_x && y <= input_y && y + ports[i].Height >= input_y)
                {
                    if ((input as IElementForm).getIndexOfPortThatConnect() == 0)
                    {
                        (input as IElementForm).getElement().connect(getElement(), true, i - 1);
                    }
                    else if ((input as IElementForm).getIndexOfPortThatConnect() > 0)
                    {
                        getElement().connect((input as IElementForm).getElement(), false,
                            (input as IElementForm).getIndexOfPortThatConnect() - 1);
                    }
                    else
                    {
                        throw new NullReferenceException();
                    }
                    (input as IElementForm).connectPortChecked();
                    ports[i].Checked = true;
                    return true;
                }

            }
            return false;
        }

        public int getIndexOfPortThatConnect()
        {
            return indexOfConnectPort;
        }
        public Element getElement()
        {
            return or2In1;
        }
        public void connectPortChecked()
        {
            ports[indexOfConnectPort].Checked = true;
        }


    }
}
