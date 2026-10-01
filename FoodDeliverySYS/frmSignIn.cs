using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliverySYS
{
    public partial class frmSignIn : Form
    {
        frmMain parent;
        public frmSignIn()
        {
            InitializeComponent();
        }
        public frmSignIn(frmMain Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void registerCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewOrderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain mainFrom = new frmMain();
            mainFrom.Show();
            this.Close();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPIN pine = new frmPIN();
            pine.Show();
            this.Close();
        }
    }
}
