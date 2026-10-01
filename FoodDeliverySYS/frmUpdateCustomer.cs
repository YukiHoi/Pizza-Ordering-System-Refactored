using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FoodDeliverySYS
{
    public partial class frmUpdateCustomer : Form
    {
        Customer theCustomer = new Customer();
        private int currentCustomerId;

        public frmUpdateCustomer(int currentCustomerId)
        {
            InitializeComponent();
            this.currentCustomerId = currentCustomerId;
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            theCustomer.getCustomer(currentCustomerId);

            txtCustomerID.Text = theCustomer.getCustomer_id().ToString();
            txtFirstName.Text = theCustomer.getFirst_name();
            txtLastName.Text = theCustomer.getLast_name();
            txtEmailAddress.Text = theCustomer.getEmail();
            txtPhoneNumber.Text = theCustomer.getPhone_no().ToString();
            txtAddress.Text = theCustomer.getAddress();
            cboCounty.Text = theCustomer.getCounty();
            cboTown.Text = theCustomer.getTown();
            txtEircode.Text = theCustomer.getEircode();
            cboCounty.Text = theCustomer.getCounty();
            cboTown.Text = theCustomer.getTown();

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
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text.Equals("") || txtAddress.Text.Equals("") ||
          txtEircode.Text.Equals("") || !int.TryParse(txtPhoneNumber.Text, out _)) //https://tutorials.eu/tryparse-converting-datatypes-in-csharp-net-7/
            {
                MessageBox.Show("All fields must be completed.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();

                return;
            }
            theCustomer.setCustomer_id(Convert.ToInt32(txtCustomerID.Text));
            theCustomer.setLast_name(txtLastName.Text);
            theCustomer.setFirst_name(txtFirstName.Text);
            theCustomer.setEmail(txtEmailAddress.Text);
            theCustomer.setPhone_no(Convert.ToInt32(txtPhoneNumber.Text));
            theCustomer.setAddress(txtAddress.Text);
            theCustomer.setCounty(cboCounty.Text);
            theCustomer.setTown(cboTown.Text);
            theCustomer.setEircode(txtEircode.Text);

            theCustomer.updateCustomer();

            MessageBox.Show("Customer Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpCustomer.Visible = false;
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void txtbox_Click(object sender, EventArgs e)
        {

        }
    }
}
