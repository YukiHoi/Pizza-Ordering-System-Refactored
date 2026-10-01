namespace FoodDeliverySYS
{
    partial class frmYearlyRevenueAnalysis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpGenerateYearlyRevenue = new System.Windows.Forms.GroupBox();
            this.grpMonthlyBreakdown = new System.Windows.Forms.GroupBox();
            this.txtTotalOrders = new System.Windows.Forms.TextBox();
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.txtAvgMonthRev = new System.Windows.Forms.TextBox();
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMonthlySummary = new System.Windows.Forms.DataGridView();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.lbSelectYear = new System.Windows.Forms.Label();
            this.lbGDOR = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpGenerateYearlyRevenue.SuspendLayout();
            this.grpMonthlyBreakdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySummary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGenerateYearlyRevenue
            // 
            this.grpGenerateYearlyRevenue.Controls.Add(this.cmbYear);
            this.grpGenerateYearlyRevenue.Controls.Add(this.grpMonthlyBreakdown);
            this.grpGenerateYearlyRevenue.Controls.Add(this.lbTotalRevenue);
            this.grpGenerateYearlyRevenue.Controls.Add(this.btnGenReport);
            this.grpGenerateYearlyRevenue.Controls.Add(this.lbSelectYear);
            this.grpGenerateYearlyRevenue.Controls.Add(this.lbGDOR);
            this.grpGenerateYearlyRevenue.Location = new System.Drawing.Point(12, 20);
            this.grpGenerateYearlyRevenue.Name = "grpGenerateYearlyRevenue";
            this.grpGenerateYearlyRevenue.Size = new System.Drawing.Size(776, 410);
            this.grpGenerateYearlyRevenue.TabIndex = 1;
            this.grpGenerateYearlyRevenue.TabStop = false;
            this.grpGenerateYearlyRevenue.Text = "Yearly Revenue Report";
            // 
            // grpMonthlyBreakdown
            // 
            this.grpMonthlyBreakdown.Controls.Add(this.groupBox1);
            this.grpMonthlyBreakdown.Controls.Add(this.btnSaveReport);
            this.grpMonthlyBreakdown.Controls.Add(this.dgvMonthlySummary);
            this.grpMonthlyBreakdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMonthlyBreakdown.Location = new System.Drawing.Point(6, 100);
            this.grpMonthlyBreakdown.Name = "grpMonthlyBreakdown";
            this.grpMonthlyBreakdown.Size = new System.Drawing.Size(764, 304);
            this.grpMonthlyBreakdown.TabIndex = 9;
            this.grpMonthlyBreakdown.TabStop = false;
            this.grpMonthlyBreakdown.Text = "Monthly Breakdown";
            this.grpMonthlyBreakdown.Visible = false;
            // 
            // txtTotalOrders
            // 
            this.txtTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrders.Location = new System.Drawing.Point(179, 99);
            this.txtTotalOrders.Name = "txtTotalOrders";
            this.txtTotalOrders.Size = new System.Drawing.Size(67, 22);
            this.txtTotalOrders.TabIndex = 72;
            this.txtTotalOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click_1);
            // 
            // txtAvgMonthRev
            // 
            this.txtAvgMonthRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgMonthRev.Location = new System.Drawing.Point(179, 67);
            this.txtAvgMonthRev.Name = "txtAvgMonthRev";
            this.txtAvgMonthRev.Size = new System.Drawing.Size(67, 22);
            this.txtAvgMonthRev.TabIndex = 71;
            this.txtAvgMonthRev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Location = new System.Drawing.Point(179, 32);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.Size = new System.Drawing.Size(67, 26);
            this.txtTotalRevenue.TabIndex = 70;
            this.txtTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Total Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Avg Monthly Revenue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Total Revenue:";
            // 
            // dgvMonthlySummary
            // 
            this.dgvMonthlySummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlySummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvMonthlySummary.Location = new System.Drawing.Point(72, 25);
            this.dgvMonthlySummary.Name = "dgvMonthlySummary";
            this.dgvMonthlySummary.Size = new System.Drawing.Size(339, 69);
            this.dgvMonthlySummary.TabIndex = 65;
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.Location = new System.Drawing.Point(326, 306);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(0, 13);
            this.lbTotalRevenue.TabIndex = 7;
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
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click_1);
            // 
            // lbSelectYear
            // 
            this.lbSelectYear.AutoSize = true;
            this.lbSelectYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectYear.Location = new System.Drawing.Point(170, 68);
            this.lbSelectYear.Name = "lbSelectYear";
            this.lbSelectYear.Size = new System.Drawing.Size(96, 20);
            this.lbSelectYear.TabIndex = 1;
            this.lbSelectYear.Text = "Select Year:";
            // 
            // lbGDOR
            // 
            this.lbGDOR.AutoSize = true;
            this.lbGDOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGDOR.Location = new System.Drawing.Point(217, 14);
            this.lbGDOR.Name = "lbGDOR";
            this.lbGDOR.Size = new System.Drawing.Size(398, 29);
            this.lbGDOR.TabIndex = 0;
            this.lbGDOR.Text = "Generate Yearly Revenue Report";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2024",
            "2023",
            "2022"});
            this.cmbYear.Location = new System.Drawing.Point(272, 68);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(163, 21);
            this.cmbYear.TabIndex = 10;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // Column1
            // 
            dataGridViewCellStyle13.NullValue = "January";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column1.HeaderText = "Month";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle14.NullValue = "€ 40,000";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column2.HeaderText = "Revenue";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle15.NullValue = "800";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column3.HeaderText = "Orders";
            this.Column3.Name = "Column3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalRevenue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTotalOrders);
            this.groupBox1.Controls.Add(this.txtAvgMonthRev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(72, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 140);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summery";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bACKToolStripMenuItem
            // 
            this.bACKToolStripMenuItem.Name = "bACKToolStripMenuItem";
            this.bACKToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.bACKToolStripMenuItem.Text = "BACK ";
            this.bACKToolStripMenuItem.Click += new System.EventHandler(this.bACKToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpGenerateYearlyRevenue);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmYearlyRevenueAnalysis";
            this.Text = "Food Delivery -[Yearly Revenue Analysis]";
            this.grpGenerateYearlyRevenue.ResumeLayout(false);
            this.grpGenerateYearlyRevenue.PerformLayout();
            this.grpMonthlyBreakdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySummary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGenerateYearlyRevenue;
        private System.Windows.Forms.GroupBox grpMonthlyBreakdown;
        private System.Windows.Forms.TextBox txtTotalOrders;
        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.TextBox txtAvgMonthRev;
        private System.Windows.Forms.TextBox txtTotalRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMonthlySummary;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.Label lbSelectYear;
        private System.Windows.Forms.Label lbGDOR;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}