namespace ZahreefK
{
    public partial class Form1 : Form
    {
        String transType;
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
            double deposit, currentBal, newBal;
            bool dvalid, cValid;
            //read text boxes into variables 
            accountName = txtAccountName.Text;
            //Parse converts strings to ints or doubles
            /*
               deposit = double.Parse(txtDeposit.Text);
            */
            cValid = double.TryParse(txtCurrentBalance.Text, out currentBal);
            dvalid = double.TryParse(txtDeposit.Text, out deposit);
            if (dvalid && cValid)
            {
                newBal = (deposit + currentBal);
                lstOut.Items.Add("Account Name: " + accountName);
                lstOut.Items.Add("Current Balance: " + currentBal.ToString("C"));
                lstOut.Items.Add("Deposit: " + deposit.ToString("C"));
                lstOut.Items.Add("New Balance: " + newBal.ToString("C"));
                lstOut.Items.Add(newBal.ToString("C"));
            }
            else
            {
                if (!cValid)
                {
                    lstOut.Items.Add("Current Balance is not an appropriate value");
                }
                if (!dvalid)
                {
                    lstOut.Items.Add("Deposit is not an appropriate value");
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
            }
        }

        private void rdoDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDeposit.Checked)
            {
                transType = "Deposit";
            }
        }

        private void rdoWithdrawl_CheckedChanged(object sender, EventArgs e)
        {
            transType = "Deposit";
        }
    }
}
