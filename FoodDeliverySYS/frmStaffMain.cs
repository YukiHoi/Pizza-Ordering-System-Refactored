using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodDeliverySYS.Models;

namespace FoodDeliverySYS
{
    public partial class frmStaffMain : Form
    {
        public frmStaffMain()
        {
            InitializeComponent();
        }

        private void deRegisterCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeRegisterCustomer frmNext = new frmDeRegisterCustomer();
            frmNext.Show();
        }

        private void addPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddPizzz addPizza = new frmAddPizzz();
            addPizza.Show();
        }

        private void removePizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemovePizza removePizza = new frmRemovePizza();
            removePizza.Show();

        }

        private void dispatcheOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDispatchOrder dispatchOrder = new frmDispatchOrder();
            dispatchOrder.Show();
            
        }

        private void closeDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCloseDelivery closeDelivery = new frmCloseDelivery();
            closeDelivery.Show();
        }


        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevenueAnalysisReport yearlyRevenueAnalysis = new frmYearlyRevenueAnalysisReport();
            yearlyRevenueAnalysis.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain mainFrom = new frmMain();
            mainFrom.Show();
        }

        private void viewMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffViewMenu viewMenu = new frmStaffViewMenu();
            viewMenu.Show();

        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewAllOrders viewAllOrders = new frmViewAllOrders();
            viewAllOrders.Show();
        }

        private void frmStaffMain_Load(object sender, EventArgs e)
        {

        }
    }
}
