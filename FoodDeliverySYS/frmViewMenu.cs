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
    public partial class frmViewMenu : Form
    {
        frmMain parent;
        private int currentCustomerId;

        public frmViewMenu(int currentCustomerId)
        {
            InitializeComponent();
            this.currentCustomerId = currentCustomerId;     
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerMain frmCustomerMain = new frmCustomerMain(currentCustomerId);
            frmCustomerMain.Show();

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


        private void frmViewMenu_Load(object sender, EventArgs e)
        {
            dgvPizza.DataSource = Pizza.getAllPizza().Tables["Pizza"]; //get all pizza data on datagrid

            if (dgvPizza.Rows.Count == 0)
            {
                MessageBox.Show("No Pizza Available");
                return;
            }
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvPizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGoOrder_Click(object sender, EventArgs e)
        {
            frmPlaceOrder placeOrderForm = new frmPlaceOrder(currentCustomerId);
            placeOrderForm.Show();

            this.Hide();
        }
    }
}
