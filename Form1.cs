namespace ZahreefK
{
    public partial class Form1 : Form
    {
        private string logFile = "BnkTrans.txt";
        //private string cfgFile =

        private string transType;
        const string IC = "Interest Calculated";
        const string DEPOSIT = "Deposit";
        const string WITHDRAWL = "Withdrawl";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountName.Clear();
            txtDeposit.Clear();
            txtCurrentBalance.Clear();
            lstOut.Items.Clear();
            txtAccountName.Focus();
        }

        private void txtAccountName_Enter(object sender, EventArgs e)
        {
            txtAccountName.BackColor = Color.Beige;
        }



        private void txtDeposit_Enter(object sender, EventArgs e)
        {
            txtDeposit.BackColor = Color.Beige;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string accountName;
            double transAmount, currentBal, newBal;
            bool tValid, cValid;
            StreamWriter swLog;
            //read text boxes into variables 
            accountName = txtAccountName.Text;
            //Parse converts strings to ints or doubles
            /*
               deposit = double.Parse(txtDeposit.Text);
            */
            cValid = double.TryParse(txtCurrentBalance.Text, out currentBal);
            tValid = double.TryParse(txtDeposit.Text, out transAmount);
            if (tValid && cValid)
            {
                newBal = 0;
                switch (transType)
                {
                    case IC:
                        lstOut.Items.Add("Interest Rate: 5%");
                        transAmount = (currentBal * 0.05);
                        newBal = (currentBal + transAmount);    
                        break;
                    case DEPOSIT:
                        newBal = (transAmount + currentBal);
                        break;
                    case WITHDRAWL:
                        newBal = (currentBal - transAmount);
                        break;
                    default:

                        break;
                }

                lstOut.Items.Add("Account Name: " + accountName);
                lstOut.Items.Add("Current Balance: " + currentBal.ToString("C"));
                lstOut.Items.Add("Transaction Amount: " + transAmount.ToString("C"));
                lstOut.Items.Add("New Balance: " + newBal.ToString("C"));
                lstOut.Items.Add(newBal.ToString("C"));
                swLog = File.AppendText(logFile);
                swLog.WriteLine("*** Beginning of Transaction ***");
                swLog.WriteLine("Account Name: " + accountName);
                swLog.WriteLine("Current Balance: " + currentBal.ToString("C"));
                swLog.WriteLine("Transaction Amount: " + transAmount.ToString("C"));
                swLog.WriteLine("New Balance: " + newBal.ToString("C"));
                swLog.WriteLine(newBal.ToString("C"));
                swLog.Close();
            }
            else
            {
                if (!cValid)
                {
                    lstOut.Items.Add("Current Balance is not an appropriate value");
                }
                if (!tValid)
                {
                    lstOut.Items.Add(" is not an appropriate value");
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult buttonSel;
            buttonSel = MessageBox.Show("Do you really want to leave?", "Exiting...", MessageBoxButtons.YesNo);
            if (buttonSel == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtAccountName_Leave(object sender, EventArgs e)
        {
            txtAccountName.BackColor = SystemColors.Window;
        }

        private void txtDeposit_Leave(object sender, EventArgs e)
        {
            txtDeposit.BackColor = SystemColors.Window;
        }

        private void txtCurrentBalance_Enter(object sender, EventArgs e)
        {
            txtCurrentBalance.BackColor = Color.Beige;
        }

        private void txtCurrentBalance_Leave(object sender, EventArgs e)
        {
            txtCurrentBalance.BackColor = SystemColors.Window;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdoIC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoIC.Checked)
            {
                transType = "Interest Calculation";
                lblTransAmt.Visible = false;
                txtDeposit.Visible = false;

            }
        }

        private void rdoDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDeposit.Checked)
            {
                transType = "Deposit";
                lblTransAmt.Visible = true;
                txtDeposit.Visible = true;
            }
        }

        private void rdoWithdrawl_CheckedChanged(object sender, EventArgs e)
        {
            transType = "Withdrawl";
            lblTransAmt.Visible = true;
            txtDeposit.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoIC.Checked = true;
        }

        private void lstOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
