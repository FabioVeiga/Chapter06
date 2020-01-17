using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter06Program02
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            bool flag;
            int myDay;
            string msg = "Today is";
            flag = int.TryParse(txtNumber.Text, out myDay);
            if(flag == false)
            {
                MessageBox.Show("Numery Only","Alert");
                txtNumber.Focus();
                return;
            }
            else if ((myDay < 1) || (myDay > 7))
            {
                MessageBox.Show("Number thru 1 and 7", "Alert");
                txtNumber.Focus();
                return;
            }
            
            switch (myDay)
            {
                case 1:
                    msg += " Moday!";
                    break;
                case 2:
                    msg += " Tuesday!";
                    break;
                case 3:
                    msg += " Wednesday!";
                    break;
                case 4:
                    msg += " Thursday!";
                    break;
                case 5:
                    msg += " Friday!";
                    break;
                case 6:
                    msg += " Saturday!";
                    break;
                case 7:
                    msg += " Sunday!";
                    break;
            }
            lblDayOfWeek.Text = msg;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
