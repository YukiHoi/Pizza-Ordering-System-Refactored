using FoodDeliverySYS.Business;
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
using System.Management;

namespace FoodDeliverySYS
{
    public partial class frmPlaceOrder : Form
    {
        private List<PizzaCart> cart = new List<PizzaCart>(); //create a list of pizza cart
        private int currentCustomerId;
        private int currentOrderID;
        private int currentOrderDetailId;
        private decimal totalPrice;
        private int pizza_id;
        private int crust_id;
        private int size_id;
        private int qty;

        OrderDetails theOrderDetails = new OrderDetails();
        Pizza thePizza = new Pizza();
        PizzaSize thePizzaSize = new PizzaSize();
        CrustType theCrustType = new CrustType();
        

        public frmPlaceOrder(int currentCustomerId)
        {
            InitializeComponent();
            dgvCartList.AutoGenerateColumns = true;
            dgvCartList.ReadOnly = true;
            dgvCartList.AllowUserToAddRows = false;
            dgvCartList.AllowUserToDeleteRows = false;
            txtGrandTotal.ReadOnly = true;
            this.currentCustomerId = currentCustomerId;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpCrust.Visible = true;
        }

        private void cmbCrustType_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpSize.Visible = true;
        }

        private void cmbPizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            numQty.Visible = true;
            grpQty.Visible = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //// Read the ID and price from each displayed option.
            // Split on the full separator so names can contain hyphens.
            string[] pizzaParts = cboPizzas.SelectedItem.ToString()
                .Split(new[] { " - " }, StringSplitOptions.None); //get the selected pizza from the combobox //https://stackoverflow.com/questions/6844724/how-can-i-convert-an-object-from-a-combobox-selected-item-to-a-string 
            //split the string by '-' //https://www.bytehide.com/blog/split-string-csharp
            string[] crustParts = cboCrustType.SelectedItem.ToString()    
                .Split(new []{ " - " }, StringSplitOptions.None);
            string[] sizeParts = cboPizzaSize.SelectedItem.ToString()    
                .Split(new []{ " - " }, StringSplitOptions.None);

            try
            {
                // Builder creates and validates one pizza item.
                PizzaCart item = new PizzaCartBuilder()
                    .WithPizzaId(int.Parse(pizzaParts[0]))
                    .WithCrustId(int.Parse(crustParts[0]))
                    .WithSizeId(int.Parse(sizeParts[0]))
                    .WithQuantity(Convert.ToInt32(numQty.Value))
                    .Build();
                // Pricing remains separate from item creation.
                item.Price = PriceCalculator.CalculatePrice(
                    decimal.Parse(pizzaParts[pizzaParts.Length - 1]),
                    decimal.Parse(crustParts[crustParts.Length - 1]),
                    decimal.Parse(sizeParts[sizeParts.Length - 1]),
                    item.Quantity);
                
                // Keep the existing checkout parameters for this step.
                pizza_id = item.PizzaId;
                crust_id = item.CrustId;
                size_id = item.SizeId;
                qty = item.Quantity;
                totalPrice = item.Price;
                cart.Add(item);

                //Refresh the grid after adding an item and display pizza
                dgvCartList.DataSource = null;
                dgvCartList.DataSource = cart.Select(cartItem => new
                {
                    Pizza = GetOptionName(cboPizzas, cartItem.PizzaId),
                    Crust = GetOptionName(cboCrustType, cartItem.CrustId),
                    Size = GetOptionName(cboPizzaSize, cartItem.SizeId),
                    Quantity = cartItem.Quantity,
                    LineTotal = cartItem.Price
                }).ToList();

                dgvCartList.Columns["LineTotal"].HeaderText = "Line Total";
                dgvCartList.Columns["LineTotal"].DefaultCellStyle.Format = "C2";
                dgvCartList.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                //Add together the line totals for every cart item
                decimal grandTotal = cart.Sum(cartItem =>  cartItem.Price);
                txtGrandTotal.Text = grandTotal.ToString("0.00");

                txtTotal.Visible = true;
                btnCheckOut.Visible = true;
                txtTotal.Text = totalPrice.ToString("0.00");
                cboPizzas.SelectedIndex = -1;
                cboCrustType.SelectedIndex = -1;
                cboPizzaSize.SelectedIndex = -1;
                numQty.Value = 0;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid quantity");
            } 
        }
        private string GetOptionName(ComboBox comboBox, int id)
        {
            foreach (object option in comboBox.Items)
            {
                string[] parts = option.ToString()
                    .Split(new[] { " - " }, StringSplitOptions.None);

                int optionId;

                if (parts.Length >= 3 &&
                    int.TryParse(parts[0], out optionId) &&
                    optionId == id)
                {
                    // Preserve names that contain the separator.
                    return string.Join(" - ", parts, 1, parts.Length - 2);
                }
            }

            return "Unknown";
        }
        private void grpSize_Enter(object sender, EventArgs e)
        {

        }


        private void grpQty_Enter(object sender, EventArgs e)
        {

        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewMenu viewMenuFrom = new frmViewMenu(currentCustomerId);
            viewMenuFrom.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmPlaceOrder_Load(object sender, EventArgs e)
        {     
            txtOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd"); //https://stackoverflow.com/questions/6817266/how-to-get-the-current-date-without-the-time

            txtCustomerID.Text = currentCustomerId.ToString(); //get the current customer id from the login form
            DataSet ds = Pizza.getAllPizza();

            cboPizzas.Items.Clear();   

            for(int i = 0; i < ds.Tables["Pizza"].Rows.Count; i++)
            {
                cboPizzas.Items.Add(ds.Tables["Pizza"].Rows[i]["pizza_id"] + " - " + ds.Tables["Pizza"].Rows[i]["Pizza_name"] +
                    " - " + ds.Tables["Pizza"].Rows[i]["base_price"]);
            }

            DataSet ds1 = CrustType.getAllCrustType(); //get all crust type from the database
            cboCrustType.Items.Clear(); 
            for(int i = 0; i < ds1.Tables["CrustType"].Rows.Count; i++)
            {
                cboCrustType.Items.Add(ds1.Tables["CrustType"].Rows[i][0] + " - " + ds1.Tables["CrustType"].Rows[i][1] +
                    " - " + ds1.Tables["CrustType"].Rows[i][2]);
            }

            DataSet ds2 = PizzaSize.getAllPizzaSize(); //get all pizza size from the database
            cboPizzaSize.Items.Clear();
            for (int i = 0; i < ds2.Tables["PizzaSize"].Rows.Count; i++)
            {
                cboPizzaSize.Items.Add(ds2.Tables["PizzaSize"].Rows[i][0] + " - " + ds2.Tables["PizzaSize"].Rows[i][1] +
                    " - " + ds2.Tables["PizzaSize"].Rows[i][2]);
            }

        }
        private void txtOrderDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            txtTotal.Visible = true;
            btnAdd.Visible = true;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void grpPizzaName_Enter(object sender, EventArgs e)
        {

        }

        private void grpCrust_Enter(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Please add an item to the cart.");
                return;
            }
            // Pass the complete cart instead of the latest selection.
            frmPayment paymentForm = new frmPayment(
                cart, currentCustomerId);

            paymentForm.Show();
            this.Hide();
        }

        private void dgvCartList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

