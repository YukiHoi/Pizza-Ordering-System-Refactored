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
    public partial class frmDeRegisterCustomer : Form
    {
        frmMain parent;
        Customer theCustomer = new Customer();
        public frmDeRegisterCustomer()
        {
            InitializeComponent();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        DialogResult result = MessageBox.Show( "Are you sure you want to exit?","Exit Application",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffMain staffMain = new frmStaffMain();
            staffMain.Show();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Please enter a Last Name OR Email to search for a Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            DataSet ds = Customer.findCustomer(txtSearch.Text); 
            
            if (dgvCustomer.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                labLastName.Focus();
                return;
            }
            dgvCustomer.DataSource = ds.Tables["Customer"];

            dgvCustomer.Visible = true; //If value is found, the datagridview will be visible.
      
        }

        private void txtLastName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CustomerId = Convert.ToInt32(dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[0].Value.ToString()); //Get the Customer ID from the Selected Row

            theCustomer.getCustomer(CustomerId); //get the customer id

            txtCustomerID.Text = theCustomer.getCustomer_id().ToString(); //when I click the data roll, the value of customer will be shown in the textbox.
            txtLastName.Text = theCustomer.getLast_name();
            txtFirstName.Text = theCustomer.getFirst_name();
            txtEmailAddress.Text = theCustomer.getEmail();
            txtPhoneNumber.Text = theCustomer.getPhone_no().ToString();
            txtAddress.Text = theCustomer.getAddress();
            cboCounty.Text = theCustomer.getCounty();
            cboTown.Text = theCustomer.getTown();
            txtEircode.Text = theCustomer.getEircode();

            grpCustomer.Visible = true;
        }

        private void btnDeRegister_Click_1(object sender, EventArgs e)
        {
       
            DialogResult deRegister = MessageBox.Show("Are you sure you want to De-Register? This can not be undone", "Deregistration", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(deRegister == DialogResult.Yes)
            {
                MessageBox.Show("Customer " + theCustomer.getLast_name() + theCustomer.getFirst_name() + " DeRegistered successfully", "Success",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);

                theCustomer.deRegisterCustomer(); //when I click this button,the value of customer will changed to Anonymous.
                dgvCustomer.ClearSelection();
                grpCustomer.Visible = false;
                txtLastName.Text = "";
                txtLastName.Focus();
                dgvCustomer.DataSource = null;
            }
            else
            {
                labLastName.Focus();
            }
          
            
        }

 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpCustomer.Visible = false;
            dgvCustomer.Visible = false;
            txtLastName.Text = "";
            txtLastName.Focus();
            dgvCustomer.DataSource = null;
        }

        private void frmDeRegisterCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
