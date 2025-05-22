using System.Diagnostics.SymbolStore;
using System.Runtime.Versioning;
using System.Security.Cryptography;

namespace ZahreefK
{
    public partial class Form1 : Form
    {
        private string logFile = "BnkTrans.txt";

        const string IC = "Interest Calculation";
        const string DEPOSIT = "Deposit";
        const string WITHDRAWL = "Withdrawl";
        const int LISTBOX = 1;
        const int LOGFILE = 2;
        const int BOTH = 3;
        private string transType = IC;
        internal string interestcfgFile = "interestRate.txt";
        const double MINRATE = 0;
        const double MAXRATE = .07;
        private double interestRate;

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
            txtTransAct.Clear();
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
            txtTransAct.BackColor = Color.Beige;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string accountName;
            double transAmount = 0, currentBal, newBal;
            bool tValid = true, cValid;
            StreamWriter swLog;
            //read text boxes into variables 
            accountName = txtAccountName.Text.Trim();
            
            cValid = double.TryParse(txtCurrentBalance.Text, out currentBal);
            if (txtTransAct.Visible)
            {
                tValid = double.TryParse(txtTransAct.Text, out transAmount);
            }
            if (tValid && cValid)
            {
                newBal = 0;
                switch (transType)
                {
                    case IC:
                        outputTransaction("*** Beginning of Transaction *** " + DateTime.Now.ToString("G"), LOGFILE);
                        outputTransaction("Interest Rate: " + interestRate.ToString("P0"), BOTH);
                        transAmount = (currentBal * interestRate);
                        newBal = (currentBal + transAmount);
                        break;
                    case DEPOSIT:
                        outputTransaction("*** Beginning of Transaction *** " + DateTime.Now.ToString("G"), LOGFILE);
                        newBal = (transAmount + currentBal);
                        break;
                    case WITHDRAWL:
                        if (transAmount > currentBal)
                        {
                            lstOut.Items.Add("Insufficient Funds");
                            return;
                        }
                        else
                        {
                            outputTransaction("*** Beginning of Transaction *** " + DateTime.Now.ToString("G"), LOGFILE);
                            newBal = (currentBal - transAmount);
                        }
                        break;
                    default:

                        break;
                }

                
                outputTransaction("Account Name: " + accountName, BOTH);
                outputTransaction("Transaction Type: " + transType, BOTH);
                outputTransaction("Current Balance: " + currentBal.ToString("C"), BOTH);
                outputTransaction("Transaction Amount: " + transAmount.ToString("C"), BOTH);
                outputTransaction("New Balance: " + newBal.ToString("C"), BOTH);

            }
            else
            {
                if (!cValid)
                {
                    lstOut.Items.Add("Current Balance is not an appropriate value");
                }
                if (!tValid)
                {
                    lstOut.Items.Add("Transaction amount is not an appropriate value");
                }
            }
        }

        private void outputTransaction(string msg, int outputType)
        {
            if (outputType == LISTBOX || outputType == BOTH)
            {
                lstOut.Items.Add(msg);
            }
            if (outputType == LOGFILE || outputType == BOTH)
            {
                StreamWriter swLog;
                swLog = File.AppendText(logFile);
                swLog.WriteLine(msg);
                swLog.Close();
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
            txtTransAct.BackColor = SystemColors.Window;
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
                txtTransAct.Visible = false;

            }
        }

        private void rdoDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDeposit.Checked)
            {
                transType = "Deposit";
                lblTransAmt.Visible = true;
                txtTransAct.Visible = true;
            }
        }

        private void rdoWithdrawl_CheckedChanged(object sender, EventArgs e)
        {
            transType = "Withdrawl";
            lblTransAmt.Visible = true;
            txtTransAct.Visible = true;
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
                catch(FileNotFoundException ex)
                {
                    MessageBox.Show("Configuration File not found. Please enter a new configuration file",
                        "Configuration File Not FOund");
                    openFileDialog1.ShowDialog();
                    interestcfgFile = openFileDialog1.FileName;
                }
            } while (bad);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sf.txtIC.Text = InterestRate.ToString();
            sf.ShowDialog();
        }

        private void showLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const int MAX_LINES = 2000;
            string[] logLines = new string[MAX_LINES];
            StreamReader sr = File.OpenText(logFile);
            int numLines = 0;
            while (!sr.EndOfStream)
            {
                logLines[numLines] = sr.ReadLine();
                numLines++;
            }
            sr.Close();
            int beg = -3;
            int end = 3;
            for (int i = 0; i < numLines; i++)
            {
                if (logLines[i] == "Transaction Type: " + transType)
                {
                    for (int j = i + beg; j <= i + end; j++)
                    {
                        lstOut.Items.Add(logLines[j]);
                    }
                }
            }
        }
    }
}
