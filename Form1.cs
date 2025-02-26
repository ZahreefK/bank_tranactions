namespace ZahreefK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountName.Text = "";
            txtDeposit.Text = "";

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
            double deposit, balance; 
            //read text boxes into variables 
            accountName = txtAccountName.Text;
            //Parse converts strings to ints or doubles
            deposit = double.Parse(txtDeposit.Text);

            balance = deposit;
            lstOut.Items.Add("The account name is " + accountName);
            lstOut.Items.Add("The deposit is " + deposit.ToString("C"));
            lstOut.Items.Add(balance.ToString("C"));
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAccountName_Leave(object sender, EventArgs e)
        {
            txtAccountName.BackColor = SystemColors.Window;
        }

        private void txtDeposit_Leave(object sender, EventArgs e)
        {
            txtDeposit.BackColor = SystemColors.Window;
        }
    }
}
