namespace LogicScheme.SignalBoxes
{
    partial class SignalBoxFalse
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.False = new System.Windows.Forms.Label();
            //this.Output = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // False
            // 
            this.False.AutoSize = true;
            this.False.Location = new System.Drawing.Point(3, 0);
            this.False.Name = "False";
            this.False.Size = new System.Drawing.Size(32, 13);
            this.False.TabIndex = 5;
            this.False.Text = "False";
            // 
            // FalseButton
            // 
            this.Output.AutoSize = true;
            this.Output.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Output.Location = new System.Drawing.Point(38, 0);
            this.Output.Name = "FalseButton";
            this.Output.Size = new System.Drawing.Size(14, 13);
            this.Output.TabIndex = 4;
            this.Output.TabStop = true;
            this.Output.UseMnemonic = false;
            this.Output.UseVisualStyleBackColor = true;
            this.Output.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RadioButton_MouseDown);
            this.Output.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RadioButton_MouseMove);
            this.Output.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RadioButton_MouseUp);
            // 
            // SignalBoxFalse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.False);
            this.Controls.Add(this.Output);
            this.Name = "SignalBoxFalse";
            this.Size = new System.Drawing.Size(51, 18);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label False;
       
    }
}
