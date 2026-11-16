using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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

            string[] parts = cboPaymentMethod.SelectedItem.ToString()
                .Split(new[] { " - " }, StringSplitOptions.None);

            int paymentMethodId = int.Parse(parts[0]);
            IPaymentStrategy strategy;

            // Choose the strategy for the selected payment method.
            switch (paymentMethodId)
            {
                case 2: // Credit Card
                    strategy = new CardPaymentStrategy(
                        txtPersonName.Text.Trim(),
                        txtCardNo.Text.Trim(),
                        txtExpirDate.Text.Trim(),
                        txtCvv.Text.Trim());
                    break;

                case 1: // Apple Pay
                case 3: // PayPal
                    string methodName =
                        paymentMethodId == 1 ? "Apple Pay" : "PayPal";

                    bool approved = MessageBox.Show(
                        "Approve this simulated " + methodName + " payment?",
                        "Simulated payment",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes;

                    if (paymentMethodId == 1)
                        strategy = new ApplePayPaymentStrategy(approved);
                    else
                        strategy = new PayPalPaymentStrategy(approved);
                    break;

                default:
                    MessageBox.Show(
                        "This payment method is not supported in this prototype.");
                    return;
            }

            int savedOrderId;
            btnConfirmPayment.Enabled = false;

            try
            {
                var facade = new OrderFacade(new OracleOrderStore());

                // The Façade processes payment and then saves the order.
                savedOrderId = facade.PlaceOrder(
                    currentCustomerId,
                    cartItems,
                    paymentMethodId,
                    strategy);
            }
            catch (Exception ex)
            {
                btnConfirmPayment.Enabled = true;

                MessageBox.Show(ex.Message, "Checkout unsuccessful",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtOrderId.Text = savedOrderId.ToString("00000");

            MessageBox.Show(
                "Simulated Payment Confirmed\n" +
                "Order ID: " + savedOrderId.ToString("00000") + "\n" +
                "Total Price: " + totalPrice.ToString("0.00") + "\n" +
                "Order Status: Processing",
                "Payment Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Hide();
            new frmCustomerMain(currentCustomerId).Show();
        }

        private void cboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCard = false;

            if (cboPaymentMethod.SelectedIndex != -1)
            {
                string[] parts = cboPaymentMethod.SelectedItem
                    .ToString()
                    .Split(new[] { " - " }, StringSplitOptions.None);

                // Credit Card has payment method ID 2.
                isCard = int.Parse(parts[0]) == 2;
            }

            // Card details are needed only for Credit Card.
            grpPersonName.Visible = isCard;
            grpCardNo.Visible = isCard;
            grpExpirDate.Visible = isCard;
            grpCVV.Visible = isCard;
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
