﻿namespace LogicScheme
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
            this.button1 = new System.Windows.Forms.Button();
            this.signalBox1 = new LogicScheme.SignalBox.SignalBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::LogicScheme.Properties.Resources.OR_SW;
            this.button1.Location = new System.Drawing.Point(92, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 33);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // signalBox1
            // 
            this.signalBox1.Location = new System.Drawing.Point(3, 101);
            this.signalBox1.Name = "signalBox1";
            this.signalBox1.Size = new System.Drawing.Size(51, 53);
            this.signalBox1.TabIndex = 1;
            signalBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(element_MouseDown);
            this.signalBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(element_MouseMove);
            signalBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(element_MouseUp);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signalBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private SignalBox.SignalBox signalBox1;
    }
}