using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodDeliverySYS.Models;

namespace FoodDeliverySYS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerSignIn customerSignIn = new frmCustomerSignIn();
            customerSignIn.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffSignIn staffSignIn = new frmStaffSignIn();
            staffSignIn.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
