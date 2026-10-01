using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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

        private void labOrderId_Click(object sender, EventArgs e)
        {

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {          
            txtOrderId.Text = CustomerOrders.getNextOrderID().ToString("00000");
            txtOrderDetailId.Text = OrderDetails.getNextOrderDetailId().ToString("00000");
            txtPaymentId.Text = Payment.getNextPayment_id().ToString("00000");
            txtOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd"); //https://stackoverflow.com/questions/6817266/how-to-get-the-current-date-without-the-time
            txtPaymentAmount.Text = totalPrice.ToString("0.00");

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
            int orderId = Convert.ToInt32(txtOrderId.Text);
            int orderDetailId = Convert.ToInt32(txtOrderDetailId.Text);
            int paymentId = Convert.ToInt32(txtPaymentId.Text);
            int paymentMethodId = Convert.ToInt32(cboPaymentMethod.Text.Substring(0, 2));

            CustomerOrders theOrder = new CustomerOrders(orderId, DateTime.Now, totalPrice, currentCustomerId, 'Y', "Processing");
            theOrder.addCustomerOrder();

            OrderDetails orderDetails = new OrderDetails(paymentMethodId, orderId, pizza_id, crust_id,size_id, qty, totalPrice);
            orderDetails.addOrderDetails();

            Payment payment = new Payment(paymentId, orderId, Convert.ToDecimal(txtPaymentAmount.Text), paymentMethodId);

            payment.addPayment();

            MessageBox.Show("Payment Confirmed\n" +
                "Order Date: " +theOrder.getOrder_date() +"\n" +
                "Total Price: " +theOrder.getTotal_price() +"\n" +
                "Payment Status: " +theOrder.getPayment_status() +"\n" +
                "Order Status: " +theOrder.getOrder_status() +"\n",
                "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            frmCustomerMain customerMain = new frmCustomerMain(currentCustomerId);
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
    }
}
