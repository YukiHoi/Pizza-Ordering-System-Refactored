namespace FoodDeliverySYS
{
    partial class frmDailyOrderDelivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDailyOrderDelivery = new System.Windows.Forms.GroupBox();
            this.lbTotalRevenues = new System.Windows.Forms.Label();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.dtpSelectDate = new System.Windows.Forms.DateTimePicker();
            this.lbSelectYear = new System.Windows.Forms.Label();
            this.lbGDOR = new System.Windows.Forms.Label();
            this.grpDailyOrderReport = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvOrderSummary = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalOrder = new System.Windows.Forms.TextBox();
            this.txtPending = new System.Windows.Forms.TextBox();
            this.txtDispatched = new System.Windows.Forms.TextBox();
            this.txtDelivered = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDailyOrderDelivery.SuspendLayout();
            this.grpDailyOrderReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDailyOrderDelivery
            // 
            this.gbDailyOrderDelivery.Controls.Add(this.grpDailyOrderReport);
            this.gbDailyOrderDelivery.Controls.Add(this.lbTotalRevenue);
            this.gbDailyOrderDelivery.Controls.Add(this.btnGenReport);
            this.gbDailyOrderDelivery.Controls.Add(this.dtpSelectDate);
            this.gbDailyOrderDelivery.Controls.Add(this.lbSelectYear);
            this.gbDailyOrderDelivery.Controls.Add(this.lbGDOR);
            this.gbDailyOrderDelivery.Location = new System.Drawing.Point(12, 28);
            this.gbDailyOrderDelivery.Name = "gbDailyOrderDelivery";
            this.gbDailyOrderDelivery.Size = new System.Drawing.Size(776, 410);
            this.gbDailyOrderDelivery.TabIndex = 0;
            this.gbDailyOrderDelivery.TabStop = false;
            this.gbDailyOrderDelivery.Text = "Daily Order Delivery";
            // 
            // lbTotalRevenues
            // 
            this.lbTotalRevenues.AutoSize = true;
            this.lbTotalRevenues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRevenues.Location = new System.Drawing.Point(328, 199);
            this.lbTotalRevenues.Name = "lbTotalRevenues";
            this.lbTotalRevenues.Size = new System.Drawing.Size(101, 24);
            this.lbTotalRevenues.TabIndex = 8;
            this.lbTotalRevenues.Text = "Daily Total:";
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.Location = new System.Drawing.Point(326, 306);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(0, 13);
            this.lbTotalRevenue.TabIndex = 7;
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReport.Location = new System.Drawing.Point(323, 272);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(146, 32);
            this.btnSaveReport.TabIndex = 6;
            this.btnSaveReport.Text = "Save Report ";
            this.btnSaveReport.UseVisualStyleBackColor = true;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReportAsPDF_Click);
            // 
            // btnGenReport
            // 
            this.btnGenReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenReport.Location = new System.Drawing.Point(468, 63);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(139, 26);
            this.btnGenReport.TabIndex = 3;
            this.btnGenReport.Text = "Generate Report";
            this.btnGenReport.UseVisualStyleBackColor = true;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // dtpSelectDate
            // 
            this.dtpSelectDate.Location = new System.Drawing.Point(222, 69);
            this.dtpSelectDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtpSelectDate.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpSelectDate.Name = "dtpSelectDate";
            this.dtpSelectDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSelectDate.TabIndex = 2;
            this.dtpSelectDate.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpSelectDate.ValueChanged += new System.EventHandler(this.dtpSelectDate_ValueChanged);
            // 
            // lbSelectYear
            // 
            this.lbSelectYear.AutoSize = true;
            this.lbSelectYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectYear.Location = new System.Drawing.Point(119, 70);
            this.lbSelectYear.Name = "lbSelectYear";
            this.lbSelectYear.Size = new System.Drawing.Size(97, 20);
            this.lbSelectYear.TabIndex = 1;
            this.lbSelectYear.Text = "Select Date:";
            // 
            // lbGDOR
            // 
            this.lbGDOR.AutoSize = true;
            this.lbGDOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGDOR.Location = new System.Drawing.Point(217, 14);
            this.lbGDOR.Name = "lbGDOR";
            this.lbGDOR.Size = new System.Drawing.Size(347, 29);
            this.lbGDOR.TabIndex = 0;
            this.lbGDOR.Text = "Generate Daily Order Report";
            // 
            // grpDailyOrderReport
            // 
            this.grpDailyOrderReport.Controls.Add(this.txtDelivered);
            this.grpDailyOrderReport.Controls.Add(this.txtDispatched);
            this.grpDailyOrderReport.Controls.Add(this.btnSaveReport);
            this.grpDailyOrderReport.Controls.Add(this.txtPending);
            this.grpDailyOrderReport.Controls.Add(this.txtTotalOrder);
            this.grpDailyOrderReport.Controls.Add(this.label4);
            this.grpDailyOrderReport.Controls.Add(this.label3);
            this.grpDailyOrderReport.Controls.Add(this.label2);
            this.grpDailyOrderReport.Controls.Add(this.label1);
            this.grpDailyOrderReport.Controls.Add(this.txtTotal);
            this.grpDailyOrderReport.Controls.Add(this.lbTotalRevenues);
            this.grpDailyOrderReport.Controls.Add(this.dgvOrderSummary);
            this.grpDailyOrderReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDailyOrderReport.Location = new System.Drawing.Point(6, 100);
            this.grpDailyOrderReport.Name = "grpDailyOrderReport";
            this.grpDailyOrderReport.Size = new System.Drawing.Size(764, 304);
            this.grpDailyOrderReport.TabIndex = 9;
            this.grpDailyOrderReport.TabStop = false;
            this.grpDailyOrderReport.Text = "Daily Order Report";
            this.grpDailyOrderReport.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(435, 198);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(70, 26);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvOrderSummary
            // 
            this.dgvOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dgvOrderSummary.Location = new System.Drawing.Point(72, 25);
            this.dgvOrderSummary.Name = "dgvOrderSummary";
            this.dgvOrderSummary.Size = new System.Drawing.Size(642, 89);
            this.dgvOrderSummary.TabIndex = 65;
            // 
            // Column1
            // 
            dataGridViewCellStyle61.NullValue = "00098";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle61;
            this.Column1.HeaderText = "Order ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle62.NullValue = "00232";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle62;
            this.Column2.HeaderText = "Customer ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle63.NullValue = "456 Maple Ave, Springfield";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle63;
            this.Column3.HeaderText = "Delivery Address";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            dataGridViewCellStyle64.NullValue = "Completed";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle64;
            this.Column6.HeaderText = "Order State";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            dataGridViewCellStyle65.NullValue = "Garry";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle65;
            this.Column4.HeaderText = "Assigned Driver";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            dataGridViewCellStyle66.Format = "t";
            dataGridViewCellStyle66.NullValue = "30mins";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle66;
            this.Column5.HeaderText = "ETA";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Total Order:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Pending: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Dispatched:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Delivered:";
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.Location = new System.Drawing.Point(166, 129);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.Size = new System.Drawing.Size(67, 26);
            this.txtTotalOrder.TabIndex = 70;
            // 
            // txtPending
            // 
            this.txtPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPending.Location = new System.Drawing.Point(166, 164);
            this.txtPending.Name = "txtPending";
            this.txtPending.Size = new System.Drawing.Size(67, 22);
            this.txtPending.TabIndex = 71;
            // 
            // txtDispatched
            // 
            this.txtDispatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDispatched.Location = new System.Drawing.Point(166, 196);
            this.txtDispatched.Name = "txtDispatched";
            this.txtDispatched.Size = new System.Drawing.Size(67, 22);
            this.txtDispatched.TabIndex = 72;
            // 
            // txtDelivered
            // 
            this.txtDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelivered.Location = new System.Drawing.Point(166, 228);
            this.txtDelivered.Name = "txtDelivered";
            this.txtDelivered.Size = new System.Drawing.Size(67, 22);
            this.txtDelivered.TabIndex = 73;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bACKToolStripMenuItem
            // 
            this.bACKToolStripMenuItem.Name = "bACKToolStripMenuItem";
            this.bACKToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.bACKToolStripMenuItem.Text = "BACK";
            this.bACKToolStripMenuItem.Click += new System.EventHandler(this.bACKToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // frmDailyOrderDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDailyOrderDelivery);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDailyOrderDelivery";
            this.Text = " ";
            this.gbDailyOrderDelivery.ResumeLayout(false);
            this.gbDailyOrderDelivery.PerformLayout();
            this.grpDailyOrderReport.ResumeLayout(false);
            this.grpDailyOrderReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDailyOrderDelivery;
        private System.Windows.Forms.Label lbGDOR;
        private System.Windows.Forms.DateTimePicker dtpSelectDate;
        private System.Windows.Forms.Label lbSelectYear;
        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Label lbTotalRevenues;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox grpDailyOrderReport;
        private System.Windows.Forms.DataGridView dgvOrderSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDelivered;
        private System.Windows.Forms.TextBox txtDispatched;
        private System.Windows.Forms.TextBox txtPending;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}