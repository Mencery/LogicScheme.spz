
using System.Windows.Forms;

namespace LogicScheme.SignalBox
{
    class SignalBox : UserControl
    {
        private RadioButton TrueButton;
        private Label True;
        private Label False;
        private BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;
        private RadioButton FalseButton;

        public SignalBox(){
            InitializeComponent();
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
            this.TrueButton.AutoSize = true;
            this.TrueButton.Location = new System.Drawing.Point(34, 3);
            this.TrueButton.Name = "TrueButton";
            this.TrueButton.Size = new System.Drawing.Size(14, 13);
            this.TrueButton.TabIndex = 0;
            this.TrueButton.TabStop = true;
            this.TrueButton.UseVisualStyleBackColor = true;
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
            this.FalseButton.Location = new System.Drawing.Point(34, 36);
            this.FalseButton.Name = "FalseButton";
            this.FalseButton.Size = new System.Drawing.Size(14, 13);
            this.FalseButton.TabIndex = 2;
            this.FalseButton.TabStop = true;
            this.FalseButton.UseVisualStyleBackColor = true;
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
        }
}
