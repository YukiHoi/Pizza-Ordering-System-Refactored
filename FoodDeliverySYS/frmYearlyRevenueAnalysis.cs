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
    public partial class frmYearlyRevenueAnalysis : Form
    {
        
        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
            
        }
      
  
        private void btnGenReport_Click(object sender, EventArgs e)
        {
           
        }

        private void gbDailyOrderDelivery_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saving the report is not implemented in this version.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenReport_Click_1(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != -1)
            { 
                grpMonthlyBreakdown.Visible = true;
                txtTotalRevenue.Text = "328,000";
                txtAvgMonthRev.Text = "27,000";
                txtTotalOrders.Text = "21,900";
            }
            else
            {
                MessageBox.Show("Please select a year to Generate Yearly Report.","Error",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveReport_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Yearly Revenue Report is saved succefully","Successfuly",MessageBoxButtons.OK);
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
