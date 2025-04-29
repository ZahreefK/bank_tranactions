using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZahreefK
{
    public partial class Form2 : Form
    {
        private Form1 ff;
        public Form2(Form1 f)
        {
            InitializeComponent();
            ff = f;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ff.InterestRate = double.Parse(txtIC.Text);
            StreamWriter sw = File.CreateText(ff.interestcfgFile);
            sw.WriteLine(ff.InterestRate.ToString());
            sw.Close();
            this.Hide();

        }

        private void txtIC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
