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

        public frmAddPizzz()
        {
            InitializeComponent();
            
        }
       
       
      
        
        private void btnAddPizza_Click(object sender, EventArgs e)
        {
           

           
   
          
        }
        private void dvgPizzaList_SelectionChanged(object sender, EventArgs e)
        {
           
        }
   

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void dvgToppingList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddPizza_Click_1(object sender, EventArgs e)
        {
            if(txtPizzaName.Text.Equals("") || txtDescription.Text.Equals("") || cmbCategory.Items.Equals(-1)
                || cmbCrustType.Items.Equals(-1) || cmbPizzaSize.Items.Equals(-1))
            {
                MessageBox.Show("Please enter all the requirted field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Pizza added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                grpPizzaList.Visible = true;
                
            }

            


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clbToppings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtPizzaName.Clear();
            txtDescription.Clear();
            cmbCategory.Items.Clear();
            cmbCrustType.Items.Clear();
            cmbPizzaSize.Items.Clear();
            txtTotal.Clear();

        }

        private void dvgPizzaList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPizzaName_TextChanged(object sender, EventArgs e)
        {
            txtPizzaName.Focus();
        }

        private void cmbCrustType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "16.99";
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain mainFrom = new frmMain();
            mainFrom.Show();

            this.Hide();
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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddPizzz_Load(object sender, EventArgs e)
        {
            dvgPizzaList.DataSource = Pizza.getAllPizza().Tables["Pizza"];
        }
    }
}
