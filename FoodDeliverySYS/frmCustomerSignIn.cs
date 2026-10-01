using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliverySYS
{
    public partial class frmCustomerSignIn : Form
    {
        Customer theCustomer = new Customer();
        private int currentCustomerId;

        public frmCustomerSignIn()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtEmailAddress.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your email address and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }
            if (!Customer.emailExists(txtEmailAddress.Text) || !Customer.checkPassword(txtPassword.Text))
            {
                MessageBox.Show("Invalid email address or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }
            this.currentCustomerId = Customer.getCustomerIdByEmail(txtEmailAddress.Text); //stored the current customer id in a variable

            MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            frmCustomerMain customerMain = new frmCustomerMain(currentCustomerId);
            customerMain.Show();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterCustomer registerCustomer = new frmRegisterCustomer();
            registerCustomer.Show();

        }

        private void frmCustomerSignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
