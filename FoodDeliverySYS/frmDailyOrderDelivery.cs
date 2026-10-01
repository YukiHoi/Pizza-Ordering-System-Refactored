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
    public partial class frmDailyOrderDelivery : Form
    {
        public frmDailyOrderDelivery()
        {
            InitializeComponent();
        }

        private void btnGenReport_Click(object sender, EventArgs e)
        {
            grpDailyOrderReport.Visible = true;
            txtTotal.Text = "566.00";

            txtTotalOrder.Text = "100";
            txtPending.Text = "30";
            txtDispatched.Text = "50";
            txtDelivered.Text = "20";

        }
     


        private void btnSaveReportAsPDF_Click(object sender, EventArgs e)
        {
            
            
            MessageBox.Show("Report is saved.","Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpSelectDate_ValueChanged(object sender, EventArgs e)
        {

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
    }
}