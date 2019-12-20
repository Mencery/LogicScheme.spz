namespace LogicScheme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signalBoxFalse1 = new LogicScheme.SignalBoxes.SignalBoxFalse();
            this.signalBoxTrue1 = new LogicScheme.SignalBox.SignalBoxTrue();
            this.xor2in1button = new System.Windows.Forms.Button();
            this.nor2in1button = new System.Windows.Forms.Button();
            this.notbutton = new System.Windows.Forms.Button();
            this.and2in1button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nand2in1button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signalBoxFalse1
            // 
            this.signalBoxFalse1.Location = new System.Drawing.Point(8, 116);
            this.signalBoxFalse1.Name = "signalBoxFalse1";
            this.signalBoxFalse1.Size = new System.Drawing.Size(56, 16);
            this.signalBoxFalse1.TabIndex = 2;
            this.signalBoxFalse1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.element_MouseDown);
            this.signalBoxFalse1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.element_MouseMove);
            this.signalBoxFalse1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.element_MouseUp);
            // 
            // signalBoxTrue1
            // 
            this.signalBoxTrue1.Location = new System.Drawing.Point(13, 92);
            this.signalBoxTrue1.Name = "signalBoxTrue1";
            this.signalBoxTrue1.Size = new System.Drawing.Size(51, 18);
            this.signalBoxTrue1.TabIndex = 1;
            this.signalBoxTrue1.Load += new System.EventHandler(this.signalBoxTrue1_Load);
            this.signalBoxTrue1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.element_MouseDown);
            this.signalBoxTrue1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.element_MouseMove);
            this.signalBoxTrue1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.element_MouseUp);
            // 
            // xor2in1button
            // 
            this.xor2in1button.Image = global::LogicScheme.Properties.Resources.EOR_SW;
            this.xor2in1button.Location = new System.Drawing.Point(247, 12);
            this.xor2in1button.Name = "xor2in1button";
            this.xor2in1button.Size = new System.Drawing.Size(29, 33);
            this.xor2in1button.TabIndex = 7;
            this.xor2in1button.UseVisualStyleBackColor = true;
            this.xor2in1button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.xor2in1button_MouseUp);
            // 
            // nor2in1button
            // 
            this.nor2in1button.Image = global::LogicScheme.Properties.Resources.NOR_SW;
            this.nor2in1button.Location = new System.Drawing.Point(212, 12);
            this.nor2in1button.Name = "nor2in1button";
            this.nor2in1button.Size = new System.Drawing.Size(29, 33);
            this.nor2in1button.TabIndex = 6;
            this.nor2in1button.UseVisualStyleBackColor = true;
            this.nor2in1button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nor2in1button_MouseUp);
            // 
            // notbutton
            // 
            this.notbutton.Image = global::LogicScheme.Properties.Resources.NOT_SW;
            this.notbutton.Location = new System.Drawing.Point(142, 12);
            this.notbutton.Name = "notbutton";
            this.notbutton.Size = new System.Drawing.Size(29, 33);
            this.notbutton.TabIndex = 4;
            this.notbutton.UseVisualStyleBackColor = true;
            this.notbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notbutton_MouseUp);
            // 
            // and2in1button
            // 
            this.and2in1button.Image = global::LogicScheme.Properties.Resources.AND_SW;
            this.and2in1button.Location = new System.Drawing.Point(107, 12);
            this.and2in1button.Name = "and2in1button";
            this.and2in1button.Size = new System.Drawing.Size(29, 33);
            this.and2in1button.TabIndex = 3;
            this.and2in1button.UseVisualStyleBackColor = true;
            this.and2in1button.Click += new System.EventHandler(this.button2_Click);
            this.and2in1button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.and2in1button_MouseUp);
            // 
            // button1
            // 
            this.button1.Image = global::LogicScheme.Properties.Resources.OR_SW;
            this.button1.Location = new System.Drawing.Point(72, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 33);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // nand2in1button
            // 
            this.nand2in1button.Image = global::LogicScheme.Properties.Resources.NAND_SW;
            this.nand2in1button.Location = new System.Drawing.Point(177, 12);
            this.nand2in1button.Name = "nand2in1button";
            this.nand2in1button.Size = new System.Drawing.Size(29, 33);
            this.nand2in1button.TabIndex = 5;
            this.nand2in1button.UseVisualStyleBackColor = true;
            this.nand2in1button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nand2in1button_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xor2in1button);
            this.Controls.Add(this.nor2in1button);
            this.Controls.Add(this.notbutton);
            this.Controls.Add(this.and2in1button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nand2in1button);
            this.Controls.Add(this.signalBoxFalse1);
            this.Controls.Add(this.signalBoxTrue1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private SignalBox.SignalBoxTrue signalBoxTrue1;
        private SignalBoxes.SignalBoxFalse signalBoxFalse1;
        private System.Windows.Forms.Button nand2in1button;
        private System.Windows.Forms.Button notbutton;
        private System.Windows.Forms.Button and2in1button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nor2in1button;
        private System.Windows.Forms.Button xor2in1button;
    }
}