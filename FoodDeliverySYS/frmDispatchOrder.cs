using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodDeliverySYS.Models;

namespace FoodDeliverySYS
{
    public partial class frmDispatchOrder : Form
    {

        Delivery theDelivery = new Delivery();
        Staff theStaff = new Staff();
        CustomerOrders theOrder = new CustomerOrders();
        OrderDetails OrderDetails = new OrderDetails();
        public frmDispatchOrder()
        {
            InitializeComponent();
            
        }


        private void btnDispatchOrder_Click(object sender, EventArgs e)
        {

            if (cboStaffId.SelectedIndex == -1 || cboOrderId.SelectedIndex == null)
            {
                MessageBox.Show("Please select a Driver ", "Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
      
            string driver = cboStaffId.SelectedItem.ToString();
            string[] parts = driver.Split('-');
            int staffId = int.Parse(parts[0]);

            DateTime deliveryDate = Convert.ToDateTime(txtDeliveryDate.Text); //https://stackoverflow.com/questions/39071415/convert-todatetimedatestring-to-required-dd-mm-yyyy-format-of-date

            Delivery theDelivery = new Delivery(Convert.ToInt32(txtDeliveryId.Text), deliveryDate, staffId, Convert.ToInt32(cboOrderId.Text));
            theDelivery.addDelivery();

            theOrder.updateOrderStatusToDispatched();
            DialogResult message = MessageBox.Show("Order has been updated as Dispatched.","Successfullly",MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpDispatchConfirmation.Visible = false;
            dgvDelivery.Visible = false;
            txtDeliveryId.Text = Delivery.getNextDeliveryID().ToString("00000");
            cboOrderId.Items.Clear();
            cboStaffId.SelectedIndex = -1; 
            cboStaffId.Items.Clear();
            DataSet ds = CustomerOrders.getOrdersReadyForDispatch();
            for (int i = 0; i < ds.Tables["CustomerOrders"].Rows.Count; i++)
            {
                cboOrderId.Items.Add(ds.Tables["CustomerOrders"].Rows[i][0].ToString());
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cboOrderId.SelectedIndex = -1;    
            grpDispatchConfirmation.Visible = false;
            dgvDelivery.Visible = false;
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {
            DataSet ds = Staff.getDriver();
            for (int i = 0; i < ds.Tables["Staff"].Rows.Count; i++)
            {
                cboStaffId.Items.Add(ds.Tables["Staff"].Rows[i][0].ToString() + " - " +
                    ds.Tables["Staff"].Rows[i][1] + " - " + ds.Tables["Staff"].Rows[i][2] +
                    " - " + ds.Tables["Staff"].Rows[i][3]);
            }
        }

        private void frmDispatchOrder_Load(object sender, EventArgs e)
        {
            txtDeliveryId.Text = Delivery.getNextDeliveryID().ToString("00000");
            txtDeliveryDate.Text = DateTime.Now.ToString("yyyy-MM-dd"); //https://stackoverflow.com/questions/6817266/how-to-get-the-current-date-without-the-time

            DataSet ds = CustomerOrders.getOrdersReadyForDispatch();
       
            for (int i = 0; i < ds.Tables["CustomerOrders"].Rows.Count; i++)
            {
                cboOrderId.Items.Add(ds.Tables["CustomerOrders"].Rows[i][0].ToString());
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cboOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboOrderId.SelectedIndex == -1 || cboOrderId.SelectedIndex == null)
            {
                return;
            }
            int orderId = Convert.ToInt32(cboOrderId.SelectedItem.ToString());
            dgvDelivery.DataSource = CustomerOrders.findOrderId(orderId).Tables["CustomerOrders"];

            dgvDelivery.Visible = true;
        }
        private void dgvDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int order_id = Convert.ToInt32(dgvDelivery.Rows[dgvDelivery.CurrentCell.RowIndex].Cells[0].Value.ToString());

            theOrder.getCustomerOrder(order_id);

            txtOrderId.Text = order_id.ToString();
            txtDeliveryDate.Text = theOrder.getOrder_date().ToString("yyyy-MM-dd");

            grpDispatchConfirmation.Visible = true;
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
    }
    }

