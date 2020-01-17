using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter06Program01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            bool flag;
            int val;
            string output = "Number is ";
            flag = int.TryParse(txtNumber.Text, out val);
            if(flag == false)
            {
                MessageBox.Show("Not a number. Re-enter!");
                txtNumber.Focus();
                txtNumber.Clear();
                return;
            }
            //Odd or Even
            if(val % 2 == 1)
            {
                output += txtNumber.Text.ToString() + " odd!";
            }
            else
            {
                output += txtNumber.Text.ToString() + " even!";
            }
            lblResult.Text = output;
            txtNumber.Clear();
        }
    }
}
