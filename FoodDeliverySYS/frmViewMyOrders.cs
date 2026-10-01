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
    public partial class frmViewMyOrders : Form
    {
        private int currentCustomerId;

        public frmViewMyOrders(int currentCustomerId)
        {
            InitializeComponent();
            this.currentCustomerId = currentCustomerId;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerMain customerMain= new frmCustomerMain(currentCustomerId);
            customerMain.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmViewOrderHistory_Load(object sender, EventArgs e)
        {
            
            txtCustomerID.Text = currentCustomerId.ToString(); //get the current customer id from the login form
            dgvOrderDetails.DataSource = CustomerOrders.getAllOrdersPerOneCustomer(currentCustomerId).Tables["CustomerOrders"];

            if(dgvOrderDetails.Rows.Count == 0)
            {
                MessageBox.Show("No Order Place Yet");
                txtCustomerID.Focus();
                return;
            }
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
