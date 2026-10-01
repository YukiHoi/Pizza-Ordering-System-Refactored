using System;
using System.Collections;
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
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            grdList.DataSource = Customer.getAllCustomer().Tables["Customer"];
        }

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
