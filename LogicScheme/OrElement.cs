using System;
using System.Windows.Forms;

namespace LogicScheme
{

    public partial class OrElement : UserControl, IElementForm
    {
        //TODO private 
        public RadioButton Input2;
        public RadioButton Input1;
        public RadioButton Output;
        Or2in1 or2In1;

        public OrElement()
        {
            or2In1 = new Or2in1();

            InitializeComponent();
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
            this.Input2.AutoSize = true;
            this.Input2.Location = new System.Drawing.Point(12, 25);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(14, 13);
            this.Input2.TabIndex = 0;
            this.Input2.TabStop = true;
            this.Input2.UseVisualStyleBackColor = true;
            // 
            // Input1
            // 
            this.Input1.AutoSize = true;
            this.Input1.Location = new System.Drawing.Point(12, 6);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(14, 13);
            this.Input1.TabIndex = 1;
            this.Input1.TabStop = true;
            this.Input1.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(94, 16);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(14, 13);
            this.Output.TabIndex = 2;
            this.Output.TabStop = true;
            this.Output.UseVisualStyleBackColor = true;
            this.Output.CheckedChanged += new System.EventHandler(this.Output_CheckedChanged);
            this.Output.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Output_MouseClick);
            

            this.Output.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Output_MouseDown);
        
            this.Output.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Output_MouseMove);
            this.Output.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Output_MouseUp);
            // 
            // OrElement
            // 
         
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
        bool starsDrawingFlag = false;
       
        public bool startDrawLine()
        {
            return starsDrawingFlag;
        }

        public void Output_MouseDown(object sender, MouseEventArgs e)
        {
            
            starsDrawingFlag = true;
        
               
            OnMouseDown(new MouseEventArgs(e.Button, e.Clicks, Output.Location.X + Output.Size.Width / 2, Output.Location.Y + Output.Size.Height / 2, e.Delta));

            
           

        }

        public void Output_MouseUp(object sender, MouseEventArgs e)
        {
            starsDrawingFlag = false;
           
            
            OnMouseUp(new MouseEventArgs(e.Button, e.Clicks, Output.Location.X + e.X, Output.Location.Y + e.Y, e.Delta));

        }

        private void Output_MouseMove(object sender, MouseEventArgs e)
        {
            
          
            OnMouseMove(new MouseEventArgs(e.Button, e.Clicks, Output.Location.X + e.X, Output.Location.Y + e.Y, e.Delta));

        }
    }
}
