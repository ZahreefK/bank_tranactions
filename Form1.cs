using System.Diagnostics.SymbolStore;
using System.Runtime.Versioning;
using System.Security.Cryptography;

namespace ZahreefK
{
    public partial class Form1 : Form
    {
        private string logFile = "BnkTrans.txt";
        //private string cfgFile =

        private string transType, fName, lName;
        const string IC = "Interest Calculated";
        const string DEPOSIT = "Deposit";
        const string WITHDRAWL = "Withdrawl";
        internal string interestcfgFile = "interestRate.txt";
        const double MINRATE = 0;
        const double MAXRATE = .07;
        private double interestRate = 0.05;

        internal double InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value > MINRATE && value < MAXRATE)
                {
                    interestRate = value;
                }
            }
        }
        private Form2 sf;
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
            rdoIC.Checked = true;
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
            double transAmount = 0, currentBal, newBal;
            bool tValid = true, cValid;
            StreamWriter swLog;
            //read text boxes into variables 
            accountName = txtAccountName.Text.Trim();
            int posSpace = accountName.IndexOf(' ');
            if (posSpace > 0)
            {
                fName = accountName.Substring(posSpace, 0);
                lName = accountName.Substring(++posSpace).Trim();

            }
            //Parse converts strings to ints or doubles
            /*
               deposit = double.Parse(txtDeposit.Text);
            */
            cValid = double.TryParse(txtCurrentBalance.Text, out currentBal);
            if (txtDeposit.Visible)
            {
                tValid = double.TryParse(txtDeposit.Text, out transAmount);
            }
            if (tValid && cValid)
            {
                newBal = 0;
                switch (transType)
                {
                    case IC:
                        lstOut.Items.Add("Interest Rate: " + interestRate.ToString("P0"));
                        transAmount = (currentBal * interestRate);
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
                lstOut.Items.Add(DateTime.Now.ToString("G"));
                swLog = File.AppendText(logFile);
                swLog.WriteLine("*** Beginning of Transaction *** " + DateTime.Now.ToString("G"));
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
                    lstOut.Items.Add("Tranaction amount is not an appropriate value");
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
                transType = IC;
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
            sf = new Form2(this);
            StreamReader srCFG;
            rdoIC.Checked = true;
            bool bad = true;
            do
            {
                try
                {
                    srCFG = File.OpenText(interestcfgFile);
                    bad = false;
                    try
                    {
                        interestRate = double.Parse(srCFG.ReadLine());
                        srCFG.Close();
                    }
                    catch (FormatException ex)
                    {

                        lstOut.Items.Add("Configuration file was corrupted defult values set");

                    }
                    srCFG.Close();
                }
                catch
                {
                    MessageBox.Show("Configuration File not found. Please enter a new configuration file",
                        "Configuration File Not FOund");
                }
            } while (bad);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sf.txtIC.Text = InterestRate.ToString();
            sf.ShowDialog();
        }
    }
}
