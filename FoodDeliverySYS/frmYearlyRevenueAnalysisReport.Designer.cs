namespace FoodDeliverySYS
{
    partial class frmYearlyRevenueAnalysisReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpGenerateYearlyRevenue = new System.Windows.Forms.GroupBox();
            this.chtYearRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.lbSelectYear = new System.Windows.Forms.Label();
            this.lbGDOR = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpGenerateYearlyRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtYearRevenue)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGenerateYearlyRevenue
            // 
            this.grpGenerateYearlyRevenue.Controls.Add(this.chtYearRevenue);
            this.grpGenerateYearlyRevenue.Controls.Add(this.cmbYear);
            this.grpGenerateYearlyRevenue.Controls.Add(this.lbTotalRevenue);
            this.grpGenerateYearlyRevenue.Controls.Add(this.lbSelectYear);
            this.grpGenerateYearlyRevenue.Controls.Add(this.lbGDOR);
            this.grpGenerateYearlyRevenue.Location = new System.Drawing.Point(44, 20);
            this.grpGenerateYearlyRevenue.Name = "grpGenerateYearlyRevenue";
            this.grpGenerateYearlyRevenue.Size = new System.Drawing.Size(686, 430);
            this.grpGenerateYearlyRevenue.TabIndex = 1;
            this.grpGenerateYearlyRevenue.TabStop = false;
            this.grpGenerateYearlyRevenue.Text = "Yearly Revenue Report";
            this.grpGenerateYearlyRevenue.Enter += new System.EventHandler(this.grpGenerateYearlyRevenue_Enter);
            // 
            // chtYearRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chtYearRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtYearRevenue.Legends.Add(legend1);
            this.chtYearRevenue.Location = new System.Drawing.Point(47, 107);
            this.chtYearRevenue.Name = "chtYearRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtYearRevenue.Series.Add(series1);
            this.chtYearRevenue.Size = new System.Drawing.Size(595, 307);
            this.chtYearRevenue.TabIndex = 11;
            this.chtYearRevenue.Visible = false;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(301, 69);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(163, 21);
            this.cmbYear.TabIndex = 10;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.Location = new System.Drawing.Point(326, 306);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(0, 13);
            this.lbTotalRevenue.TabIndex = 7;
            // 
            // lbSelectYear
            // 
            this.lbSelectYear.AutoSize = true;
            this.lbSelectYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectYear.Location = new System.Drawing.Point(199, 67);
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
            this.lbGDOR.Size = new System.Drawing.Size(283, 29);
            this.lbGDOR.TabIndex = 0;
            this.lbGDOR.Text = "Yearly Revenue Report";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // frmYearlyRevenueAnalysisReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 462);
            this.Controls.Add(this.grpGenerateYearlyRevenue);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmYearlyRevenueAnalysisReport";
            this.Text = "Pizza Delivery -[Yearly Revenue Analysis]";
            this.Load += new System.EventHandler(this.frmYearlyRevenueAnalysisReport_Load);
            this.grpGenerateYearlyRevenue.ResumeLayout(false);
            this.grpGenerateYearlyRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtYearRevenue)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGenerateYearlyRevenue;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Label lbSelectYear;
        private System.Windows.Forms.Label lbGDOR;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtYearRevenue;
    }
}