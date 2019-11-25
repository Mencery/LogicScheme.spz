using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicScheme
{

    public partial class OrElement : UserControl
    {
        Or2in1 or2In1;
        
        public OrElement()
        {
            or2In1 = new Or2in1();
          
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // OrElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::LogicScheme.Properties.Resources._120px1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "OrElement";
            this.Size = new System.Drawing.Size(108, 48);
            this.ResumeLayout(false);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
