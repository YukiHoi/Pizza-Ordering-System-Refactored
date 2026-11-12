using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using FoodDeliverySYS.Business;
using FoodDeliverySYS.DataAccess;

namespace FoodDeliverySYS
{
    public partial class frmPayment : Form
    {
        private int pizza_id;
        private int crust_id;
        private int size_id;
        private int qty;
        private int currentCustomerId;       
        private decimal totalPrice;
        private List<PizzaCart> cartItems;

        Payment thePayment = new Payment();
        OrderDetails theOrderDetails = new OrderDetails();
        CustomerOrders theOrder = new CustomerOrders();    

        public frmPayment(int pizza_id,int crust_id, int size_id,int qty, decimal totalPrice, int currentCustomerId)
        {
            InitializeComponent();
            this.pizza_id = pizza_id;
            this.crust_id = crust_id;
            this.size_id = size_id;
            this.qty = qty;
            this.totalPrice = totalPrice;
            this.currentCustomerId = currentCustomerId;
        }
        public frmPayment(List<PizzaCart> items, int customerId)
        {
            InitializeComponent();
            // Copy each cart item for checkout.
            cartItems = items.Select(item => new PizzaCart
            {
                PizzaId = item.PizzaId,
                CrustId = item.CrustId,
                SizeId = item.SizeId,
                Quantity = item.Quantity,
                Price = item.Price
            }).ToList();

            currentCustomerId = customerId;
            totalPrice = cartItems.Sum(item => item.Price);
        }
        private void labOrderId_Click(object sender, EventArgs e)
        {

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            // Oracle creates the IDs when the order is saved.
            txtOrderId.Text = "";
            txtOrderDetailId.Text = "";
            txtPaymentId.Text = "";
            txtOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd"); //https://stackoverflow.com/questions/6817266/how-to-get-the-current-date-without-the-time
            txtPaymentAmount.Text = totalPrice.ToString("0.00");

            txtOrderId.ReadOnly = true;
            txtOrderDetailId.ReadOnly = true;
            txtPaymentId.ReadOnly = true;
            txtPaymentAmount.ReadOnly = true;         

            DataSet dsM = PaymentMethod.getAllPaymentMethod();
            cboPaymentMethod.Items.Clear();

            for (int i = 0; i < dsM.Tables["PaymentMethod"].Rows.Count; i++)
            {
                cboPaymentMethod.Items.Add(dsM.Tables["PaymentMethod"].Rows[i][0].ToString() + " - " + 
                    dsM.Tables["PaymentMethod"].Rows[i][1].ToString());
            }
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if(txtPersonName.Text == "" || txtCardNo.Text == "" || txtExpirDate.Text == "" || txtCvv.Text == "")
            {
                MessageBox.Show("Please enter all payment details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtPersonName.Text.Length <3 || txtPersonName.Text.Any(char.IsDigit) || txtPersonName.Text.Any(char.IsSymbol) || txtPersonName.Text.Any(char.IsNumber)) // https://stackoverflow.com/questions/4503542/check-for-special-characters-in-a-string
            {
                MessageBox.Show("Please enter a valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCardNo.Text.Length != 16 || txtCardNo.Text.Any(char.IsLetter) || txtCardNo.Text.Any(char.IsSymbol) || txtCardNo.Text.Any(char.IsWhiteSpace)) //https://stackoverflow.com/questions/4503542/check-for-special-characters-in-a-string
            {
                MessageBox.Show("Please enter a valid card number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string expirDate = txtExpirDate.Text;
            string[] parts = expirDate.Split('/');
            if (parts.Length != 2) 
            {
                MessageBox.Show("Please enter a valid expiry date with '/ '", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int month, year;
            if (!int.TryParse(parts[0], out month) || !int.TryParse(parts[1], out year)) //!mean cant convert to int, out'expect TryParse to set this variable to month and year https://stackoverflow.com/questions/19830079/tryparse-for-numbers-in-c
            {
                MessageBox.Show("Please enter a valid expiry date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (month < 1 || month > 12)
            {
                MessageBox.Show("Please enter a valid month (01–12)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(year < 25)
            {
                MessageBox.Show("Card is expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtExpirDate.Text.Length != 5 || txtExpirDate.Text.Any(char.IsLetter) || txtExpirDate.Text.Any(char.IsSymbol))
            {
                MessageBox.Show("Please enter a valid expiry date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCvv.Text.Length != 3 || txtCvv.Text.Any(char.IsLetter) || txtCvv.Text.Any(char.IsSymbol))
            {
                MessageBox.Show("Please enter a valid CVV", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cartItems == null || cartItems.Count == 0)
            {
                MessageBox.Show("The cart is empty.");
                return;
            }

            if (cboPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            // Read the ID from the selected payment method.
            string[] methodParts = cboPaymentMethod.SelectedItem
                .ToString()
                .Split(new[] { " - " }, StringSplitOptions.None);

            int paymentMethodId = int.Parse(methodParts[0]);

            int savedOrderId;
            btnConfirmPayment.Enabled = false;

            try
            {
                // Supply the Oracle implementation to the business layer.
                var orderFacade = new OrderFacade(new OracleOrderStore());

                // Save the complete cart through one business operation.
                savedOrderId = orderFacade.PlaceOrder(
                    currentCustomerId,
                    cartItems,
                    paymentMethodId);
            }
            catch (Exception ex)
            {
                btnConfirmPayment.Enabled = true;

                MessageBox.Show(
                    "The order could not be saved.\n" + ex.Message,
                    "Order error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Show confirmation after saving succeeds.
            txtOrderId.Text = savedOrderId.ToString("00000");

            MessageBox.Show(
                "Payment Confirmed\n" +
                "Order ID: " + savedOrderId.ToString("00000") + "\n" +
                "Total Price: " + totalPrice.ToString("0.00") + "\n" +
                "Order Status: Processing",
                "Payment Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Hide();
            frmCustomerMain customerMain =
                new frmCustomerMain(currentCustomerId);
            customerMain.Show();

        }

        private void cboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpPersonName.Visible = true;
            grpCardNo.Visible = true;
            grpExpirDate.Visible = true;
            grpCVV.Visible = true;
        }

        private void grpPayment_Enter(object sender, EventArgs e)
        {

        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCardNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlaceOrder placeOrder = new frmPlaceOrder(currentCustomerId);
            placeOrder.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
