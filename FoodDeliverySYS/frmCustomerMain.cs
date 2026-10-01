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
    public partial class frmCustomerMain : Form
    {
        private int currentCustomerId;

        public frmCustomerMain(int currentCustomerId)
        {
            InitializeComponent();
            this.currentCustomerId = currentCustomerId;
     
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateCustomer updateCustomer = new frmUpdateCustomer(currentCustomerId);
            updateCustomer.Show();
        }

        private void viewOrderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewMyOrders orderHistory = new frmViewMyOrders(currentCustomerId);
            orderHistory.Show();
        }

        private void viewMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewMenu viewMenu = new frmViewMenu(currentCustomerId);
            viewMenu.Show();
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlaceOrder placeOrder = new frmPlaceOrder(currentCustomerId);
            placeOrder.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmCustomerMain_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain customerMain = new frmMain();
            customerMain.Show();

        }
    }
}
