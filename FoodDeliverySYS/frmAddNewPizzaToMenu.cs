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

namespace FoodDeliverySYS.Models
{
    public partial class frmAddPizzz : Form
    {

        Pizza thePizza = new Pizza();
        Category theCategory = new Category();
        public frmAddPizzz() //default constructor
        {
            InitializeComponent();

        }

        private void btnAddPizza_Click_1(object sender, EventArgs e)
        {

            if (txtPizzaName.Text.Equals("") || txtDescription.Text.Equals("") 
                || !decimal.TryParse(txtBasePrice.Text, out _)) //https://tutorials.eu/tryparse-converting-datatypes-in-csharp-net-7/
            {
                MessageBox.Show("Please enter all the requirted field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //exit
            }
            if(cboCategory.SelectedIndex == -1) //check if the category is selected
            {
                MessageBox.Show("Please select a category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCategory.Focus();
                return;
            }
            int cboCategorycategoryID = Convert.ToInt32(cboCategory.Text.Substring(0, 2)); //get the category id from the combobox

            Pizza Pizza = new Pizza(Convert.ToInt32(txtPizzaID.Text), txtPizzaName.Text, txtDescription.Text,
                cboCategorycategoryID, Convert.ToDecimal(txtBasePrice.Text));
            
            if (txtBasePrice.Text.Equals("0.00"))
            {
                MessageBox.Show("Base price cannot be 0.00. Please add a price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBasePrice.Focus();
                return;
            }

            if (Pizza.checkPizzaExists(txtPizzaName.Text))
            {
                MessageBox.Show("Pizza already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPizzaName.Focus();
                return;
            }
            
           
            Pizza.addPizza();
            MessageBox.Show("Pizza added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtPizzaName.Clear();
            txtDescription.Clear();
            cboCategory.SelectedIndex = -1;
            txtBasePrice.Text = "0.00";
            txtPizzaName.Focus();
            txtPizzaID.Text = Pizza.getNextPizza_id().ToString("00000"); //get the next pizza id from the database

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtPizzaName.Clear();
            txtDescription.Clear();
            txtBasePrice.Text = "0.00";
            cboCategory.SelectedIndex = -1;
            txtPizzaName.Focus();

        }


        private void txtPizzaName_TextChanged(object sender, EventArgs e)
        {
            txtPizzaName.Focus();
        
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

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddPizzz_Load(object sender, EventArgs e)
        {
            txtPizzaID.Text = Pizza.getNextPizza_id().ToString("00000"); 

            DataSet ds = Category.getAllCategory();
            cboCategory.Items.Clear();

            for(int i = 0; i < ds.Tables["Category"].Rows.Count; i++) //load the category details into cbo
            {
                cboCategory.Items.Add(ds.Tables["Category"].Rows[i][0] + " - " + ds.Tables["Category"].Rows[i][1]);//display the category id and category name in the combobox
            }

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpBasePrice.Visible = true; 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtBasePrice_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
