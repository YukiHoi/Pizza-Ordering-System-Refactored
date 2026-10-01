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
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    public partial class frmYearlyRevenueAnalysisReport : Form
    {

        public frmYearlyRevenueAnalysisReport()
        {
            InitializeComponent();

        }


        private void btnGenReport_Click(object sender, EventArgs e)
        {

        }

        private void gbDailyOrderDelivery_Enter(object sender, EventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            String strSQL = "SELECT SUM(total_price), to_Char(order_date,'MM') " +
               "FROM CustomerOrders " +
               "WHERE to_Char(order_date,'YYYY') = '" + cmbYear.Text + "' " +
               "GROUP BY to_Char(order_date,'MM') ORDER BY TO_char(order_date, 'MM')";

            DataTable dt = new DataTable();

            OracleConnection myConn = new OracleConnection(DBConnect.oraDB);
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            myConn.Close();

            //Array size 12 since there are 12 months in a year 
            string[] Months = new string[12];
            decimal[] Amounts = new decimal[12];
            //pre-fill each array; Months[] with month name; Amounts[] with zero values 
            for (int i = 0; i < 12; i++)
            {
                Months[i] = getMonth(i + 1); // get month name from the month number
                Amounts[i] = 0; // set amount to zero
            }
            

            //Next, save the amounts returned in Query to the appropriate element in Amounts[] 

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int month = Convert.ToInt32(dt.Rows[i][1]); // get month number from the query
                Amounts[month - 1] = Convert.ToDecimal(dt.Rows[i][0]); // get the amount from the query

            }


            chtYearRevenue.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtYearRevenue.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtYearRevenue.Series[0].LegendText = "Income in €";
            chtYearRevenue.Series[0].Points.DataBindXY(Months, Amounts);
            chtYearRevenue.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            //chtSales.Series[0].Points[0] = "XXX"; 
            chtYearRevenue.Series[0].Label = "#VALY"; 
            chtYearRevenue.Titles.Clear();
            chtYearRevenue.Titles.Add("Yearly Revenue");       
            chtYearRevenue.Visible = true;
        }

        //include a case for every month….. 
        public String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "";
            }
        }

        private void btnSaveReport_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Yearly Revenue Report is saved succefully", "Successfuly", MessageBoxButtons.OK);
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaffMain StaffmainFrom = new frmStaffMain();
            StaffmainFrom.Show();
            this.Close();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void grpGenerateYearlyRevenue_Enter(object sender, EventArgs e)
        {

        }

        private void frmYearlyRevenueAnalysisReport_Load(object sender, EventArgs e)
        {
            cmbYear.Items.Clear();
            cmbYear.Items.Add("2025");
            cmbYear.Items.Add("2024"); 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           

        }
    }
}