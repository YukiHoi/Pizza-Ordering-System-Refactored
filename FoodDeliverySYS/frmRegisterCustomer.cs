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
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    public partial class frmRegisterCustomer : Form
    {
        frmMain parent;
        Customer theCustomer = new Customer();
        public frmRegisterCustomer()
        {
            InitializeComponent();
           
        }
        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEircode_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {          
           
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmMain mainFrom = new frmMain();
            mainFrom.Show();
            this.Close();

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void registerCustomersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void frmRegisterCustomer_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = Customer.getNextCustomer_id().ToString("00000"); //get the next customer id and display it in the textbox

        }
   

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (txtFirstName.Text.Equals("") || txtLastName.Text.Equals("") ||
          txtEmailAddress.Text.Equals("") || txtAddress.Text.Equals("") ||
          cboCounty.SelectedIndex == -1 || cboTown.SelectedIndex == -1 ||
          txtPassword.Text.Equals("") || txtConfirmPassword.Text.Equals("") ||
          txtEircode.Text.Equals("") || !int.TryParse(txtPhoneNumber.Text, out _)) //https://tutorials.eu/tryparse-converting-datatypes-in-csharp-net-7/
            {
                MessageBox.Show("All fields must be completed.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();

                return;
            }
            if(txtFirstName.Text.Length < 2 || txtLastName.Text.Length < 2)
            {
                MessageBox.Show("First name and last name must be at least 2 characters long.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtFirstName.Text.Length > 20 || txtLastName.Text.Length > 20)
            {
                MessageBox.Show("First name and last name must be less than 20 characters long.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if(txtFirstName.Text.Any(char.IsDigit) || txtLastName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("First name and last name cannot contain numbers.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtFirstName.Text.Any(char.IsSymbol) || txtLastName.Text.Any(char.IsSymbol))
            {
                MessageBox.Show("First name and last name cannot contain symbols.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtFirstName.Text.Any(char.IsPunctuation) || txtLastName.Text.Any(char.IsPunctuation))
            {
                MessageBox.Show("First name and last name cannot contain punctuation.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtFirstName.Text.Any(char.IsWhiteSpace) || txtLastName.Text.Any(char.IsWhiteSpace))
            {
                MessageBox.Show("First name and last name cannot contain spaces.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtAddress.Text.Any(char.IsDigit) || txtAddress.Text.Any(char.IsSymbol) || txtAddress.Text.Any(char.IsPunctuation) || txtAddress.Text.Any(char.IsWhiteSpace))
            {
                MessageBox.Show("Address cannot contain numbers, symbols, punctuation or spaces.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }

            if (txtAddress.Text.Length < 5)
            {
                MessageBox.Show("Address must be at least 5 characters long.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
    
            if (txtEmailAddress.Text.Contains("@") == false) 
            {
                 MessageBox.Show("Email address must contain '@'.", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtEmailAddress.Focus();
                 return;
            }
                if(txtEmailAddress.Text.Contains(".") == false)
            {
                MessageBox.Show("Email address must contain '.'", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }
            if (Customer.emailExists(txtEmailAddress.Text)) // check if email address already exists
            {
                    MessageBox.Show("Email address already exists.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailAddress.Focus();
                    return;
                }
            if(txtEircode.Text.Length != 7)
            {
                MessageBox.Show("Eircode must be 7 characters long.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }
            if(txtPhoneNumber.Text.Length != 10)
            {
                MessageBox.Show("Phone number must be 10 digits long.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            Customer theCustomer = new Customer(Convert.ToInt32(txtCustomerID.Text),txtFirstName.Text,txtLastName.Text,txtEmailAddress.Text,
                Convert.ToInt32(txtPhoneNumber.Text),txtAddress.Text,cboCounty.Text, cboTown.Text,txtEircode.Text,txtPassword.Text);
            
            theCustomer.addCustomer();

            MessageBox.Show("Customer  registered successfully!", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFirstName.Focus();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmailAddress.Clear();
            txtAddress.Clear();
            cboCounty.SelectedIndex = -1;
            cboTown.SelectedIndex = -1;
            txtEircode.Clear();
            txtPhoneNumber.Clear();

            frmCustomerSignIn customerSignIn = new frmCustomerSignIn();
            customerSignIn.Show();
            this.Close();

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmailAddress.Clear();
            txtAddress.Clear();
            cboCounty.SelectedIndex = -1;
            cboTown.SelectedIndex = -1;
            txtEircode.Clear();
            txtPhoneNumber.Clear();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
