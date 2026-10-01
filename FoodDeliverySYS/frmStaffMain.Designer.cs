namespace FoodDeliverySYS
{
    partial class frmStaffMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deRegisterCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatcheOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.foodToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deRegisterCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // deRegisterCustomerToolStripMenuItem
            // 
            this.deRegisterCustomerToolStripMenuItem.Name = "deRegisterCustomerToolStripMenuItem";
            this.deRegisterCustomerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.deRegisterCustomerToolStripMenuItem.Text = "De-Register Customer";
            this.deRegisterCustomerToolStripMenuItem.Click += new System.EventHandler(this.deRegisterCustomerToolStripMenuItem_Click);
            // 
            // foodToolStripMenuItem
            // 
            this.foodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPizzaToolStripMenuItem,
            this.removePizzaToolStripMenuItem,
            this.viewMenuToolStripMenuItem});
            this.foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            this.foodToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.foodToolStripMenuItem.Text = "Food";
            // 
            // addPizzaToolStripMenuItem
            // 
            this.addPizzaToolStripMenuItem.Name = "addPizzaToolStripMenuItem";
            this.addPizzaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addPizzaToolStripMenuItem.Text = "Add Pizza";
            this.addPizzaToolStripMenuItem.Click += new System.EventHandler(this.addPizzaToolStripMenuItem_Click);
            // 
            // removePizzaToolStripMenuItem
            // 
            this.removePizzaToolStripMenuItem.Name = "removePizzaToolStripMenuItem";
            this.removePizzaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.removePizzaToolStripMenuItem.Text = "Remove Pizza";
            this.removePizzaToolStripMenuItem.Click += new System.EventHandler(this.removePizzaToolStripMenuItem_Click);
            // 
            // viewMenuToolStripMenuItem
            // 
            this.viewMenuToolStripMenuItem.Name = "viewMenuToolStripMenuItem";
            this.viewMenuToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.viewMenuToolStripMenuItem.Text = "View Menu";
            this.viewMenuToolStripMenuItem.Click += new System.EventHandler(this.viewMenuToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dispatcheOrderToolStripMenuItem,
            this.closeDeliveryToolStripMenuItem,
            this.allOrdersToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // dispatcheOrderToolStripMenuItem
            // 
            this.dispatcheOrderToolStripMenuItem.Name = "dispatcheOrderToolStripMenuItem";
            this.dispatcheOrderToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dispatcheOrderToolStripMenuItem.Text = "Dispatche Order";
            this.dispatcheOrderToolStripMenuItem.Click += new System.EventHandler(this.dispatcheOrderToolStripMenuItem_Click);
            // 
            // closeDeliveryToolStripMenuItem
            // 
            this.closeDeliveryToolStripMenuItem.Name = "closeDeliveryToolStripMenuItem";
            this.closeDeliveryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.closeDeliveryToolStripMenuItem.Text = "Close Delivery";
            this.closeDeliveryToolStripMenuItem.Click += new System.EventHandler(this.closeDeliveryToolStripMenuItem_Click);
            // 
            // allOrdersToolStripMenuItem
            // 
            this.allOrdersToolStripMenuItem.Name = "allOrdersToolStripMenuItem";
            this.allOrdersToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.allOrdersToolStripMenuItem.Text = "All Orders";
            this.allOrdersToolStripMenuItem.Click += new System.EventHandler(this.allOrdersToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            this.yearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.yearlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logOutToolStripMenuItem.Text = "Logout";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(233, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Panel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodDeliverySYS.Properties.Resources.staffMain1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmStaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(679, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStaffMain";
            this.Text = "Pizza Delivery -[Staff Main]";
            this.Load += new System.EventHandler(this.frmStaffMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deRegisterCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispatcheOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allOrdersToolStripMenuItem;
    }
}