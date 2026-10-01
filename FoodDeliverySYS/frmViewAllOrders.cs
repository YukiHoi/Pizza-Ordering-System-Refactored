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
    public partial class frmViewAllOrders : Form
    {
        public frmViewAllOrders()
        {
            InitializeComponent();
        }

        private void frmViewAllOrders_Load(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDate.Value > DateTime.Now)
            {
                MessageBox.Show("Please select a date that is not in the future");
                return;
            }

            dgvViewAllOrders.DataSource = CustomerOrders.getAllOrdersByDate(dtpDate.Value).Tables["CustomerOrders"];
            if (dgvViewAllOrders.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");
                return;
            }
            dgvViewAllOrders.Visible = true;
        }

        private void bAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffMain frmStaffMain = new frmStaffMain();
            frmStaffMain.ShowDialog();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
