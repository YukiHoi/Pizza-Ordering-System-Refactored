namespace FoodDeliverySYS
{
    partial class frmViewAllOrders
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
            this.labViewAllOrders = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.labAllOrders = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvViewAllOrders = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // labViewAllOrders
            // 
            this.labViewAllOrders.AutoSize = true;
            this.labViewAllOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labViewAllOrders.Location = new System.Drawing.Point(216, 42);
            this.labViewAllOrders.Name = "labViewAllOrders";
            this.labViewAllOrders.Size = new System.Drawing.Size(153, 24);
            this.labViewAllOrders.TabIndex = 7;
            this.labViewAllOrders.Text = "View all Orders";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(197, 131);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 24);
            this.dtpDate.TabIndex = 6;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // labAllOrders
            // 
            this.labAllOrders.AutoSize = true;
            this.labAllOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAllOrders.Location = new System.Drawing.Point(196, 98);
            this.labAllOrders.Name = "labAllOrders";
            this.labAllOrders.Size = new System.Drawing.Size(201, 20);
            this.labAllOrders.TabIndex = 5;
            this.labAllOrders.Text = "Select Date To view Orders";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bAToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bAToolStripMenuItem
            // 
            this.bAToolStripMenuItem.Name = "bAToolStripMenuItem";
            this.bAToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.bAToolStripMenuItem.Text = "BACK";
            this.bAToolStripMenuItem.Click += new System.EventHandler(this.bAToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // dgvViewAllOrders
            // 
            this.dgvViewAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAllOrders.Location = new System.Drawing.Point(72, 177);
            this.dgvViewAllOrders.Name = "dgvViewAllOrders";
            this.dgvViewAllOrders.Size = new System.Drawing.Size(468, 254);
            this.dgvViewAllOrders.TabIndex = 9;
            this.dgvViewAllOrders.Visible = false;
            // 
            // frmViewAllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.labViewAllOrders);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.labAllOrders);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvViewAllOrders);
            this.Name = "frmViewAllOrders";
            this.Text = "Pizza Delivery -[View All Order]";
            this.Load += new System.EventHandler(this.frmViewAllOrders_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labViewAllOrders;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label labAllOrders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvViewAllOrders;
    }
}