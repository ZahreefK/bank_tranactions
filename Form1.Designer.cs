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
            label4 = new Label();
            txtCurrentBalance = new TextBox();
            groupBox1 = new GroupBox();
            rdoWithdrawl = new RadioButton();
            rdoDeposit = new RadioButton();
            rdoIC = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 0;
            label1.Text = "ZBANK ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 99);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Account Name";
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(225, 91);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(182, 23);
            txtAccountName.TabIndex = 2;
            txtAccountName.Enter += txtAccountName_Enter;
            txtAccountName.Leave += txtAccountName_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 152);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Deposit";
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(225, 149);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(182, 23);
            txtDeposit.TabIndex = 6;
            txtDeposit.Enter += txtDeposit_Enter;
            txtDeposit.Leave += txtDeposit_Leave;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(84, 338);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 42);
            btnDisplay.TabIndex = 8;
            btnDisplay.Text = "&Display Answer";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(202, 338);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 42);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(332, 338);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 42);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(84, 178);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(323, 139);
            lstOut.TabIndex = 7;
            lstOut.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 123);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 3;
            label4.Text = "Current Balance";
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Location = new Point(225, 120);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.Size = new Size(182, 23);
            txtCurrentBalance.TabIndex = 4;
            txtCurrentBalance.Enter += txtCurrentBalance_Enter;
            txtCurrentBalance.Leave += txtCurrentBalance_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoWithdrawl);
            groupBox1.Controls.Add(rdoDeposit);
            groupBox1.Controls.Add(rdoIC);
            groupBox1.Location = new Point(87, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 47);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction Type";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdoWithdrawl
            // 
            rdoWithdrawl.AutoSize = true;
            rdoWithdrawl.Location = new Point(226, 22);
            rdoWithdrawl.Name = "rdoWithdrawl";
            rdoWithdrawl.Size = new Size(79, 19);
            rdoWithdrawl.TabIndex = 2;
            rdoWithdrawl.Text = "Withdrawl";
            rdoWithdrawl.UseVisualStyleBackColor = true;
            rdoWithdrawl.CheckedChanged += rdoWithdrawl_CheckedChanged;
            // 
            // rdoDeposit
            // 
            rdoDeposit.AutoSize = true;
            rdoDeposit.Location = new Point(130, 22);
            rdoDeposit.Name = "rdoDeposit";
            rdoDeposit.Size = new Size(65, 19);
            rdoDeposit.TabIndex = 1;
            rdoDeposit.Text = "Deposit";
            rdoDeposit.UseVisualStyleBackColor = true;
            rdoDeposit.CheckedChanged += rdoDeposit_CheckedChanged;
            // 
            // rdoIC
            // 
            rdoIC.AutoSize = true;
            rdoIC.Checked = true;
            rdoIC.Location = new Point(-3, 22);
            rdoIC.Name = "rdoIC";
            rdoIC.Size = new Size(127, 19);
            rdoIC.TabIndex = 0;
            rdoIC.TabStop = true;
            rdoIC.Text = "Interest Calculation";
            rdoIC.UseVisualStyleBackColor = true;
            rdoIC.CheckedChanged += rdoIC_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 392);
            Controls.Add(groupBox1);
            Controls.Add(txtCurrentBalance);
            Controls.Add(label4);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label label4;
        private TextBox txtCurrentBalance;
        private GroupBox groupBox1;
        private RadioButton rdoWithdrawl;
        private RadioButton rdoDeposit;
        private RadioButton rdoIC;
    }
}
