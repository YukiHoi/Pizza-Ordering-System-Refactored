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
    public partial class frmStaffSignIn : Form
    {
        Staff theStaff = new Staff();
        public frmStaffSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your email address and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }
            if (!Staff.emailExists(txtEmailAddress.Text) || !Staff.checkPassword(txtPassword.Text))
            {
                MessageBox.Show("Invalid email address or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }
            MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            frmStaffMain frmStaffMain = new frmStaffMain();
            frmStaffMain.Show();

        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain mainFrom = new frmMain();
            mainFrom.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmStaffSignIn_Load(object sender, EventArgs e)
        {

        }
    }
    }

