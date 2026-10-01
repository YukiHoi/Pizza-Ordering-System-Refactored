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
    public partial class frmRemovePizza : Form
    {
        Pizza thePizza = new Pizza();
        Category theCategory = new Category();
        public frmRemovePizza()
        {
            InitializeComponent();
           
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Please enter a Pizza Name to search for a Pizza", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            dgvPizza.DataSource = Pizza.findPizza(txtSearch.Text).Tables["Pizza"]; // Get the data from the database and bind it to the datagridview

            if (dgvPizza.Rows.Count == 1) //If no data found, display a message
            {
                MessageBox.Show("No Data Found");
                txtSearch.Focus();
                return;
            }
            dgvPizza.Visible = true; 
            grpPizza.Visible = false;
        }
        private void dgvPizza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pizza_id = Convert.ToInt32(dgvPizza.Rows[e.RowIndex].Cells[0].Value);


            thePizza.getPizza(pizza_id);

            txtPizzaID.Text = thePizza.getPizza_id().ToString();
            txtPizzaName.Text = thePizza.getPizza_name();
            txtDescription.Text = thePizza.getDescription();
            txtBasePrice.Text = thePizza.getBase_price().ToString();

            DataSet ds = Category.getAllCategory();
            int categoryIndex = 0;
            cboCategory.Items.Clear();
            for(int i = 0; i < ds.Tables["Category"].Rows.Count; i++)//Loop through all the categories
            {
                //Add the category to the combo box
                cboCategory.Items.Add(ds.Tables["Category"].Rows[i][0]+" - " + ds.Tables["Category"].Rows[i][1]);
                //If the category id is equal to the category id of the pizza, set the index of the combo box to the category id
                if (ds.Tables["Category"].Rows[i][0].Equals(thePizza.getCategory_id())) categoryIndex = i;           
            }
            cboCategory.SelectedIndex = categoryIndex;
            grpPizza.Visible = true;
        }

        private void bACKToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffMain frmStaffMain = new frmStaffMain();
            frmStaffMain.Show();
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRemovePizza_Click(object sender, EventArgs e)
        {
            DialogResult removePizza=MessageBox.Show("Are you sure want to remove "+thePizza.getPizza_name()+"  from the system", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (removePizza == DialogResult.Yes)
            {
                MessageBox.Show("Pizza "+ thePizza.getPizza_name() +" has been removed from the system", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                thePizza.removePizza();
                grpPizza.Visible = false;
                dgvPizza.Visible = false;
                txtSearch.Text = "";
            }
            txtSearch.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpPizza.Visible = false;
            dgvPizza.Visible = false;
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void frmRemovePizza_Load(object sender, EventArgs e)
        {

        }
    }
    }

