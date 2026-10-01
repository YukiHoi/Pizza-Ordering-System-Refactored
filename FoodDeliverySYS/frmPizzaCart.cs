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
    public partial class frmPizzaCart : Form
    {
        frmMain parent;
        CustomerOrders theOrder = new CustomerOrders();
        Pizza thePizza = new Pizza();
        PizzaSize thePizzaSize = new PizzaSize();
        CrustType theCrustType = new CrustType();
        public frmPizzaCart()
        {
            InitializeComponent();
        }
        public frmPizzaCart(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        int itemOrdered;
        const int numOfPizzas = 10;
        Pizza[] pizzas = new Pizza[numOfPizzas];
        private void frmPizzaCart_Load(object sender, EventArgs e)
        {
    

        }
    }
}
