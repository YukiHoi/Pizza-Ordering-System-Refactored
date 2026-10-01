namespace FoodDeliverySYS
{
    partial class frmPlaceOrder
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
            this.grpPlaceOrder = new System.Windows.Forms.GroupBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.labCustomerID = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpPizzaName = new System.Windows.Forms.GroupBox();
            this.cboPizzas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpQty = new System.Windows.Forms.GroupBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.cboPizzaSize = new System.Windows.Forms.ComboBox();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.cboCrustType = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dgvCartList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.grpPlaceOrder.SuspendLayout();
            this.grpPizzaName.SuspendLayout();
            this.grpQty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.grpSize.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPlaceOrder
            // 
            this.grpPlaceOrder.Controls.Add(this.txtCustomerID);
            this.grpPlaceOrder.Controls.Add(this.labCustomerID);
            this.grpPlaceOrder.Controls.Add(this.txtOrderDate);
            this.grpPlaceOrder.Controls.Add(this.label3);
            this.grpPlaceOrder.Controls.Add(this.grpPizzaName);
            this.grpPlaceOrder.Controls.Add(this.label4);
            this.grpPlaceOrder.Controls.Add(this.txtTotal);
            this.grpPlaceOrder.Controls.Add(this.grpQty);
            this.grpPlaceOrder.Controls.Add(this.grpSize);
            this.grpPlaceOrder.Controls.Add(this.grpCrust);
            this.grpPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlaceOrder.Location = new System.Drawing.Point(12, 51);
            this.grpPlaceOrder.Name = "grpPlaceOrder";
            this.grpPlaceOrder.Size = new System.Drawing.Size(776, 276);
            this.grpPlaceOrder.TabIndex = 0;
            this.grpPlaceOrder.TabStop = false;
            this.grpPlaceOrder.Text = " ";
            this.grpPlaceOrder.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(231, 44);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(126, 26);
            this.txtCustomerID.TabIndex = 77;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // labCustomerID
            // 
            this.labCustomerID.AutoSize = true;
            this.labCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCustomerID.Location = new System.Drawing.Point(122, 48);
            this.labCustomerID.Name = "labCustomerID";
            this.labCustomerID.Size = new System.Drawing.Size(103, 18);
            this.labCustomerID.TabIndex = 76;
            this.labCustomerID.Text = "Customer ID";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Location = new System.Drawing.Point(231, 108);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(126, 24);
            this.txtOrderDate.TabIndex = 75;
            this.txtOrderDate.TextChanged += new System.EventHandler(this.txtOrderDate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 74;
            this.label3.Text = "Order Date";
            // 
            // grpPizzaName
            // 
            this.grpPizzaName.Controls.Add(this.cboPizzas);
            this.grpPizzaName.Location = new System.Drawing.Point(408, 19);
            this.grpPizzaName.Name = "grpPizzaName";
            this.grpPizzaName.Size = new System.Drawing.Size(342, 56);
            this.grpPizzaName.TabIndex = 73;
            this.grpPizzaName.TabStop = false;
            this.grpPizzaName.Text = "Pizza Name";
            this.grpPizzaName.Enter += new System.EventHandler(this.grpPizzaName_Enter);
            // 
            // cboPizzas
            // 
            this.cboPizzas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPizzas.FormattingEnabled = true;
            this.cboPizzas.Location = new System.Drawing.Point(6, 25);
            this.cboPizzas.Name = "cboPizzas";
            this.cboPizzas.Size = new System.Drawing.Size(330, 26);
            this.cboPizzas.TabIndex = 59;
            this.cboPizzas.SelectedIndexChanged += new System.EventHandler(this.cboPizzas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Total Priceis:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(185, 242);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(154, 24);
            this.txtTotal.TabIndex = 77;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.WordWrap = false;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // grpQty
            // 
            this.grpQty.Controls.Add(this.numQty);
            this.grpQty.Controls.Add(this.btnAdd);
            this.grpQty.Location = new System.Drawing.Point(64, 148);
            this.grpQty.Name = "grpQty";
            this.grpQty.Size = new System.Drawing.Size(293, 61);
            this.grpQty.TabIndex = 63;
            this.grpQty.TabStop = false;
            this.grpQty.Text = "Select Quantity";
            this.grpQty.Visible = false;
            this.grpQty.Enter += new System.EventHandler(this.grpQty_Enter);
            // 
            // numQty
            // 
            this.numQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQty.Location = new System.Drawing.Point(7, 29);
            this.numQty.Name = "numQty";
            this.numQty.ReadOnly = true;
            this.numQty.Size = new System.Drawing.Size(120, 24);
            this.numQty.TabIndex = 74;
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(151, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 26);
            this.btnAdd.TabIndex = 63;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.cboPizzaSize);
            this.grpSize.Location = new System.Drawing.Point(408, 148);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(310, 62);
            this.grpSize.TabIndex = 61;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Select Size";
            this.grpSize.Visible = false;
            this.grpSize.Enter += new System.EventHandler(this.grpSize_Enter);
            // 
            // cboPizzaSize
            // 
            this.cboPizzaSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPizzaSize.FormattingEnabled = true;
            this.cboPizzaSize.Location = new System.Drawing.Point(6, 25);
            this.cboPizzaSize.Name = "cboPizzaSize";
            this.cboPizzaSize.Size = new System.Drawing.Size(194, 26);
            this.cboPizzaSize.TabIndex = 57;
            this.cboPizzaSize.SelectedIndexChanged += new System.EventHandler(this.cmbPizzaSize_SelectedIndexChanged);
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.cboCrustType);
            this.grpCrust.Location = new System.Drawing.Point(408, 81);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(310, 61);
            this.grpCrust.TabIndex = 60;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Select Crust";
            this.grpCrust.Visible = false;
            this.grpCrust.Enter += new System.EventHandler(this.grpCrust_Enter);
            // 
            // cboCrustType
            // 
            this.cboCrustType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCrustType.FormattingEnabled = true;
            this.cboCrustType.Location = new System.Drawing.Point(6, 27);
            this.cboCrustType.Name = "cboCrustType";
            this.cboCrustType.Size = new System.Drawing.Size(194, 26);
            this.cboCrustType.TabIndex = 55;
            this.cboCrustType.SelectedIndexChanged += new System.EventHandler(this.cmbCrustType_SelectedIndexChanged);
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Place Order";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(395, 516);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(114, 33);
            this.btnCheckOut.TabIndex = 79;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Visible = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // dgvCartList
            // 
            this.dgvCartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartList.Location = new System.Drawing.Point(69, 333);
            this.dgvCartList.Name = "dgvCartList";
            this.dgvCartList.Size = new System.Drawing.Size(687, 150);
            this.dgvCartList.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Grand Total";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.txtGrandTotal.Location = new System.Drawing.Point(182, 525);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(154, 24);
            this.txtGrandTotal.TabIndex = 82;
            this.txtGrandTotal.Text = "0.00";
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGrandTotal.WordWrap = false;
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCartList);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpPlaceOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPlaceOrder";
            this.Text = "Pizza Delivery -[Place Order]";
            this.Load += new System.EventHandler(this.frmPlaceOrder_Load);
            this.grpPlaceOrder.ResumeLayout(false);
            this.grpPlaceOrder.PerformLayout();
            this.grpPizzaName.ResumeLayout(false);
            this.grpQty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.grpSize.ResumeLayout(false);
            this.grpCrust.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlaceOrder;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.ComboBox cboCrustType;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.ComboBox cboPizzaSize;
        private System.Windows.Forms.GroupBox grpQty;
        private System.Windows.Forms.Button btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPizzas;
        private System.Windows.Forms.GroupBox grpPizzaName;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridView dgvCartList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrandTotal;
    }
}