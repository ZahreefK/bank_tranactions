namespace ZahreefK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtAccountName = new TextBox();
            label3 = new Label();
            txtDeposit = new TextBox();
            btnDisplay = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            lstOut = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(202, -1);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 0;
            label1.Text = "ZBANK ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 64);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Account Name";
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(153, 61);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(182, 23);
            txtAccountName.TabIndex = 2;
            txtAccountName.Enter += txtAccountName_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 101);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Deposit";
            label3.Click += label3_Click;
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(153, 98);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(182, 23);
            txtDeposit.TabIndex = 4;
            txtDeposit.TextChanged += txtDeposit_TextChanged;
            txtDeposit.Enter += txtDeposit_Enter;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(67, 301);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 42);
            btnDisplay.TabIndex = 8;
            btnDisplay.Text = "&Display Answer";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(202, 301);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 42);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(334, 301);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 42);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += button3_Click;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(86, 143);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(323, 139);
            lstOut.TabIndex = 7;
            lstOut.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 392);
            Controls.Add(lstOut);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(txtDeposit);
            Controls.Add(label3);
            Controls.Add(txtAccountName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Zahreef Kabir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAccountName;
        private Label label3;
        private TextBox txtDeposit;
        private Button btnDisplay;
        private Button btnClear;
        private Button btnQuit;
        private ListBox lstOut;
    }
}
