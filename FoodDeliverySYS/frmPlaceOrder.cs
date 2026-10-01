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
            if (numQty.Value > 10)
            {
                MessageBox.Show("Sorry, you can only order up to 10 of the same pizza.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string pizzaString = cboPizzas.SelectedItem.ToString(); //get the selected pizza from the combobox //https://stackoverflow.com/questions/6844724/how-can-i-convert-an-object-from-a-combobox-selected-item-to-a-string 
            string[] parts = pizzaString.Split('-'); //split the string by '-' //https://www.bytehide.com/blog/split-string-csharp
            decimal pizzaPrice = decimal.Parse(parts[2]); //get the price of the pizza

            string crustString = cboCrustType.SelectedItem.ToString(); //get the selected crust from the combobox
            string[] parts1 = crustString.Split('-'); //split the string by '-'
            decimal crustPrice = decimal.Parse(parts1[2]); //get the price of the crust

            string sizeString = cboPizzaSize.SelectedItem.ToString(); //get the selected size from the combobox
            string[] parts2 = sizeString.Split('-'); //split the string by '-'
            decimal sizePrice = decimal.Parse(parts2[2]); //get the price of the size

            this.totalPrice = (pizzaPrice + crustPrice + sizePrice) * numQty.Value; //calculate the total price
            this.crust_id = Convert.ToInt32(cboCrustType.Text.Substring(0,2)); //get the crust id from the combobox
            this.size_id = Convert.ToInt32(cboPizzaSize.Text.Substring(0,2)); //get the pizza size id from the combobox
            this.pizza_id = Convert.ToInt32(cboPizzas.Text.Substring(0,2)); //get the pizza id from the combobox         
            this.qty = Convert.ToInt32(numQty.Value); //get the quantity from the numeric updown control
         
            /*for(int i = 0; i < cart.Count; i++) //check the item already exist in the cart
            {
                PizzaCart item = cart[i];//get the item from the cart
                if (item.PizzaId == pizza_id && item.CrustId == crust_id && item.SizeId == size_id)
                {
                    if (item.Quantity == 0)
                    {
                        MessageBox.Show("Please select a quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (item.Quantity + qty > 10)
                    {
                        MessageBox.Show("Sorry, you can only order up to 10 of the same pizza.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                 
                    item.Quantity += qty; //if the item already exists in the cart, increase the quantity
                    item.Price += totalPrice; //increase the price
                    MessageBox.Show("Item added to the cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                item.Quantity = qty; //if the item does not exist in the cart, add it to the cart
                item.Price = totalPrice; //set the price
            }*/
            txtTotal.Visible = true;
            btnCheckOut.Visible = true;
            txtTotal.Text = totalPrice.ToString("0.00"); //display the total price in the textbox

            //MessageBox.Show("Item added to the cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            decimal totalPrice1 = decimal.Parse(txtTotal.Text); //get the total price from the textbox

            cboPizzas.SelectedIndex = -1; 
            cboCrustType.SelectedIndex = -1; 
            cboPizzaSize.SelectedIndex = -1; 
            numQty.Value = 0; 
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
            this.currentOrderID = CustomerOrders.getOrderIdByCustomerId(currentCustomerId.ToString()); //get the order id by customer id 
            this.currentOrderDetailId = OrderDetails.getOrderDetailIdByCustomerId(currentOrderDetailId.ToString());
            this.Hide();
            frmPayment frmPayment = new frmPayment(pizza_id,crust_id, size_id, qty, totalPrice, currentCustomerId);
            frmPayment.Show();
        }
    }
}
