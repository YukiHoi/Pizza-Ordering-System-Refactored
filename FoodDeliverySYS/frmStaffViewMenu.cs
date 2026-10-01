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
    public partial class frmStaffViewMenu : Form
    {
        public frmStaffViewMenu()
        {
            InitializeComponent();
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffMain frmStaffMain = new frmStaffMain();
            frmStaffMain.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmStaffViewMenu_Load(object sender, EventArgs e)
        {
            dgvPizza.DataSource = Pizza.getAllPizza().Tables["Pizza"];
        }
    }
}
