namespace ZahreefK
{
    partial class Form2
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
            label1 = new Label();
            txtIC = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 68);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Interest Calculation";
            // 
            // txtIC
            // 
            txtIC.Location = new Point(206, 65);
            txtIC.Name = "txtIC";
            txtIC.Size = new Size(100, 23);
            txtIC.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(153, 198);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Return && Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 357);
            Controls.Add(btnSave);
            Controls.Add(txtIC);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Settings Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        internal TextBox txtIC;
    }
}