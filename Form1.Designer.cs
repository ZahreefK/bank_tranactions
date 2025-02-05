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
            txtWithdrawl = new TextBox();
            label4 = new Label();
            btnDisplay = new Button();
            btnClear = new Button();
            button3 = new Button();
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 98);
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
            // 
            // txtWithdrawl
            // 
            txtWithdrawl.Location = new Point(153, 127);
            txtWithdrawl.Name = "txtWithdrawl";
            txtWithdrawl.Size = new Size(182, 23);
            txtWithdrawl.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 130);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Withdrawl";
            label4.Click += label4_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(100, 301);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 42);
            btnDisplay.TabIndex = 8;
            btnDisplay.Text = "&Display Answer";
            btnDisplay.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(212, 301);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(334, 301);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "&Quit";
            button3.UseVisualStyleBackColor = true;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(86, 156);
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
            Controls.Add(button3);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(txtWithdrawl);
            Controls.Add(label4);
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
        private TextBox txtWithdrawl;
        private Label label4;
        private Button btnDisplay;
        private Button btnClear;
        private Button button3;
        private ListBox lstOut;
    }
}
