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
    public partial class frmCancelOrder : Form
    {
       
        public frmCancelOrder()
        {
            InitializeComponent();
          
        }
        


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            /*if (cmbOrderStatus.SelectedIndex == cmbOrderStatus.Items.IndexOf("Pending")) // https://stackoverflow.com/questions/450059/how-do-i-set-the-selected-item-in-a-combobox-to-match-my-string-using-c
            {
               
              

            }
            else
            {
                MessageBox.Show("The Order Status you selected is already completed / Dispatched and cannot be Cancel.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            
           
        }
      
  
        private void dgvOrderSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grpCancelConfirm.Visible = true;
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpCancelConfirm.Visible=false;



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
       private bool confirm;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            confirm = true;

            if (confirm)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel your order?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Order successfully canceled", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
