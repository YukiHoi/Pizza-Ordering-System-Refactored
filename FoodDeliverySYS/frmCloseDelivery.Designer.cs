namespace FoodDeliverySYS
{
    partial class frmCloseDelivery
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cLoseDelivery = new System.Windows.Forms.GroupBox();
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDispatchedOrders = new System.Windows.Forms.GroupBox();
            this.dgvDispatchedOrder = new System.Windows.Forms.DataGridView();
            this.btnMarkAsDelivery = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.orderManagment = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLoseDelivery.SuspendLayout();
            this.grpDispatchedOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispatchedOrder)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cLoseDelivery
            // 
            this.cLoseDelivery.Controls.Add(this.cboOrderId);
            this.cLoseDelivery.Controls.Add(this.label1);
            this.cLoseDelivery.Controls.Add(this.grpDispatchedOrders);
            this.cLoseDelivery.Controls.Add(this.orderManagment);
            this.cLoseDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLoseDelivery.Location = new System.Drawing.Point(12, 55);
            this.cLoseDelivery.Name = "cLoseDelivery";
            this.cLoseDelivery.Size = new System.Drawing.Size(776, 357);
            this.cLoseDelivery.TabIndex = 2;
            this.cLoseDelivery.TabStop = false;
            this.cLoseDelivery.Text = "Close Delivery";
            this.cLoseDelivery.Enter += new System.EventHandler(this.cLoseDelivery_Enter);
            // 
            // cboOrderId
            // 
            this.cboOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderId.FormattingEnabled = true;
            this.cboOrderId.Location = new System.Drawing.Point(294, 64);
            this.cboOrderId.Name = "cboOrderId";
            this.cboOrderId.Size = new System.Drawing.Size(178, 24);
            this.cboOrderId.TabIndex = 68;
            this.cboOrderId.SelectedIndexChanged += new System.EventHandler(this.cboOrderId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Order ID:";
            // 
            // grpDispatchedOrders
            // 
            this.grpDispatchedOrders.Controls.Add(this.dgvDispatchedOrder);
            this.grpDispatchedOrders.Controls.Add(this.btnMarkAsDelivery);
            this.grpDispatchedOrders.Controls.Add(this.btnCancel);
            this.grpDispatchedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDispatchedOrders.Location = new System.Drawing.Point(63, 117);
            this.grpDispatchedOrders.Name = "grpDispatchedOrders";
            this.grpDispatchedOrders.Size = new System.Drawing.Size(622, 219);
            this.grpDispatchedOrders.TabIndex = 59;
            this.grpDispatchedOrders.TabStop = false;
            this.grpDispatchedOrders.Text = "Dispatched Orders:";
            this.grpDispatchedOrders.Visible = false;
            // 
            // dgvDispatchedOrder
            // 
            this.dgvDispatchedOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispatchedOrder.Location = new System.Drawing.Point(16, 21);
            this.dgvDispatchedOrder.Name = "dgvDispatchedOrder";
            this.dgvDispatchedOrder.Size = new System.Drawing.Size(600, 116);
            this.dgvDispatchedOrder.TabIndex = 66;
            this.dgvDispatchedOrder.Visible = false;
            this.dgvDispatchedOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDispatchedOrder_CellClick);
            // 
            // btnMarkAsDelivery
            // 
            this.btnMarkAsDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAsDelivery.Location = new System.Drawing.Point(120, 176);
            this.btnMarkAsDelivery.Name = "btnMarkAsDelivery";
            this.btnMarkAsDelivery.Size = new System.Drawing.Size(149, 27);
            this.btnMarkAsDelivery.TabIndex = 57;
            this.btnMarkAsDelivery.Text = "Mark as  Delivered";
            this.btnMarkAsDelivery.UseVisualStyleBackColor = true;
            this.btnMarkAsDelivery.Click += new System.EventHandler(this.btnCloseDelivery_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(348, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 27);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // orderManagment
            // 
            this.orderManagment.AutoSize = true;
            this.orderManagment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderManagment.Location = new System.Drawing.Point(305, 17);
            this.orderManagment.Name = "orderManagment";
            this.orderManagment.Size = new System.Drawing.Size(151, 25);
            this.orderManagment.TabIndex = 0;
            this.orderManagment.Text = "Close Delivery";
            this.orderManagment.Click += new System.EventHandler(this.orderManagment_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
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
            // frmCloseDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.cLoseDelivery);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmCloseDelivery";
            this.Text = "Pizza Delivery -[Close Delivery]";
            this.Load += new System.EventHandler(this.frmCloseDelivery_Load);
            this.cLoseDelivery.ResumeLayout(false);
            this.cLoseDelivery.PerformLayout();
            this.grpDispatchedOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispatchedOrder)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox cLoseDelivery;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label orderManagment;
        private System.Windows.Forms.Button btnMarkAsDelivery;
        private System.Windows.Forms.GroupBox grpDispatchedOrders;
        private System.Windows.Forms.DataGridView dgvDispatchedOrder;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOrderId;
    }
}