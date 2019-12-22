using LogicScheme.Elements;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xor2in1button = new System.Windows.Forms.Button();
            this.nor2in1button = new System.Windows.Forms.Button();
            this.notbutton = new System.Windows.Forms.Button();
            this.and2in1button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nand2in1button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signalBoxFalse1 = new LogicScheme.SignalBoxes.SignalBoxFalse();
            this.signalBoxTrue1 = new LogicScheme.SignalBoxes.SignalBoxTrue();
            this.screenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xor2in1button
            // 
            this.xor2in1button.Image = global::LogicScheme.Properties.Resources.EOR_SW;
            this.xor2in1button.Location = new System.Drawing.Point(247, 27);
            this.xor2in1button.Name = "xor2in1button";
            this.xor2in1button.Size = new System.Drawing.Size(29, 33);
            this.xor2in1button.TabIndex = 7;
            this.xor2in1button.UseVisualStyleBackColor = true;
            this.xor2in1button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.xor2in1button_MouseUp);
            // 
            // nor2in1button
            // 
            this.nor2in1button.Image = global::LogicScheme.Properties.Resources.NOR_SW;
            this.nor2in1button.Location = new System.Drawing.Point(212, 27);
            this.nor2in1button.Name = "nor2in1button";
            this.nor2in1button.Size = new System.Drawing.Size(29, 33);
            this.nor2in1button.TabIndex = 6;
            this.nor2in1button.UseVisualStyleBackColor = true;
            this.nor2in1button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nor2in1button_MouseUp);
            // 
            // notbutton
            // 
            this.notbutton.Image = global::LogicScheme.Properties.Resources.NOT_SW;
            this.notbutton.Location = new System.Drawing.Point(142, 27);
            this.notbutton.Name = "notbutton";
            this.notbutton.Size = new System.Drawing.Size(29, 33);
            this.notbutton.TabIndex = 4;
            this.notbutton.UseVisualStyleBackColor = true;
            this.notbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notbutton_MouseUp);
            // 
            // and2in1button
            // 
            this.and2in1button.Image = global::LogicScheme.Properties.Resources.AND_SW;
            this.and2in1button.Location = new System.Drawing.Point(107, 27);
            this.and2in1button.Name = "and2in1button";
            this.and2in1button.Size = new System.Drawing.Size(29, 33);
            this.and2in1button.TabIndex = 3;
            this.and2in1button.UseVisualStyleBackColor = true;
            this.and2in1button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.and2in1button_MouseUp);
            // 
            // button1
            // 
            this.button1.Image = global::LogicScheme.Properties.Resources.OR_SW;
            this.button1.Location = new System.Drawing.Point(72, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 33);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // nand2in1button
            // 
            this.nand2in1button.Image = global::LogicScheme.Properties.Resources.NAND_SW;
            this.nand2in1button.Location = new System.Drawing.Point(177, 27);
            this.nand2in1button.Name = "nand2in1button";
            this.nand2in1button.Size = new System.Drawing.Size(29, 33);
            this.nand2in1button.TabIndex = 5;
            this.nand2in1button.UseVisualStyleBackColor = true;
            this.nand2in1button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nand2in1button_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.screenshotToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // signalBoxFalse1
            // 
            this.signalBoxFalse1.element = new SignalFalse();
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
            this.signalBoxTrue1.element = new SignalTrue();
            this.signalBoxTrue1.Location = new System.Drawing.Point(13, 92);
            this.signalBoxTrue1.Name = "signalBoxTrue1";
            this.signalBoxTrue1.Size = new System.Drawing.Size(51, 18);
            this.signalBoxTrue1.TabIndex = 1;
            this.signalBoxTrue1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.element_MouseDown);
            this.signalBoxTrue1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.element_MouseMove);
            this.signalBoxTrue1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.element_MouseUp);
            // 
            // screenshotToolStripMenuItem
            // 
            this.screenshotToolStripMenuItem.Name = "screenshotToolStripMenuItem";
            this.screenshotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.screenshotToolStripMenuItem.Text = "screenshot";
            this.screenshotToolStripMenuItem.Click += new System.EventHandler(this.screenshotToolStripMenuItem_Click);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SignalBoxes.SignalBoxTrue signalBoxTrue1;
        private SignalBoxes.SignalBoxFalse signalBoxFalse1;
        private System.Windows.Forms.Button nand2in1button;
        private System.Windows.Forms.Button notbutton;
        private System.Windows.Forms.Button and2in1button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nor2in1button;
        private System.Windows.Forms.Button xor2in1button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenshotToolStripMenuItem;
    }
}