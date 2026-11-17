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
using FoodDeliverySYS.Business;
using FoodDeliverySYS.DataAccess;
namespace FoodDeliverySYS
{
    public partial class frmCloseDelivery : Form
    {
        private readonly IDeliveryStore deliveryStore = new OracleDeliveryStore();

        Delivery theDelivery = new Delivery();
        CustomerOrders theOrder = new CustomerOrders();

        public frmCloseDelivery()
        {
            InitializeComponent();
         
        }
       
        private void LoadOrders()
        {
           
        }
        private void orderManagment_Click(object sender, EventArgs e)
        {

        }
        private bool MarkAsDelivery;
        private void btnCloseDelivery_Click(object sender, EventArgs e)
        {
            if (cboOrderId.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order to close the delivery.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int orderId = Convert.ToInt32(cboOrderId.SelectedItem.ToString());

            try
            {
                // Ask the Business layer to complete the delivery.
                deliveryStore.CloseDelivery(orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The delivery could not be closed.\n" + ex.Message,
                    "Delivery error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            DialogResult message = MessageBox.Show("Order has been updated as Delivered. [ Order Closed ]", "Successfullly", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpDispatchedOrders.Visible = false;
            dgvDispatchedOrder.Visible = false;
            cboOrderId.SelectedIndex = -1;
            dgvDispatchedOrder.Refresh();
            cboOrderId.Items.Clear();
            DataSet ds = CustomerOrders.getOrdersReadyForCloseDelivery();
            for (int i = 0; i < ds.Tables["CustomerOrders"].Rows.Count; i++)
            {
                cboOrderId.Items.Add(ds.Tables["CustomerOrders"].Rows[i][0].ToString());
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cboOrderId.SelectedIndex = -1;
            dgvDispatchedOrder.Refresh();
            dgvDispatchedOrder.Visible = false;
            grpDispatchedOrders.Visible = false;
        }

        private void cLoseDelivery_Enter(object sender, EventArgs e)
        {

        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffMain staffMain = new frmStaffMain();
            staffMain.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void cboOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboOrderId.SelectedIndex == -1 || cboOrderId.SelectedIndex == null)
            {
                return;
            }
            int orderId = Convert.ToInt32(cboOrderId.SelectedItem.ToString());
            dgvDispatchedOrder.DataSource = CustomerOrders.findOrderId(orderId).Tables["CustomerOrders"];


            if (dgvDispatchedOrder.Rows.Count == 0)
            {
                MessageBox.Show("No Orders Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvDispatchedOrder.Visible=true;
            grpDispatchedOrders.Visible = true;

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmCloseDelivery_Load(object sender, EventArgs e)
        {
            
            DataSet ds = CustomerOrders.getOrdersReadyForCloseDelivery();

            for (int i = 0; i < ds.Tables["CustomerOrders"].Rows.Count; i++)
            {
                cboOrderId.Items.Add(ds.Tables["CustomerOrders"].Rows[i][0].ToString());
            }
        }


        private void dgvDispatchedOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the order id from the datagridview
            int order_id = Convert.ToInt32(dgvDispatchedOrder.Rows[dgvDispatchedOrder.CurrentCell.RowIndex].Cells[0].Value.ToString()); 

            theOrder.getCustomerOrder(order_id);// get the order details from the database by this customer ID

        }
    }
}
