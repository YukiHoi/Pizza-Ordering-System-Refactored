namespace FoodDeliverySYS
{
    partial class frmPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.labOrderId = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.labOrderDate = new System.Windows.Forms.Label();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderDetailId = new System.Windows.Forms.TextBox();
            this.grpCVV = new System.Windows.Forms.GroupBox();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.grpExpirDate = new System.Windows.Forms.GroupBox();
            this.txtExpirDate = new System.Windows.Forms.TextBox();
            this.grpCardNo = new System.Windows.Forms.GroupBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.grpPersonName = new System.Windows.Forms.GroupBox();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.grpPaymentMethod = new System.Windows.Forms.GroupBox();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.labPaymentID = new System.Windows.Forms.Label();
            this.oracleDataAdapter1 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPayment.SuspendLayout();
            this.grpCVV.SuspendLayout();
            this.grpExpirDate.SuspendLayout();
            this.grpCardNo.SuspendLayout();
            this.grpPersonName.SuspendLayout();
            this.grpPaymentMethod.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            // 
            // labOrderId
            // 
            this.labOrderId.AutoSize = true;
            this.labOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderId.Location = new System.Drawing.Point(33, 53);
            this.labOrderId.Name = "labOrderId";
            this.labOrderId.Size = new System.Drawing.Size(74, 20);
            this.labOrderId.TabIndex = 1;
            this.labOrderId.Text = "Order ID:";
            this.labOrderId.Click += new System.EventHandler(this.labOrderId_Click);
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.Location = new System.Drawing.Point(15, 338);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(129, 20);
            this.labTotalPrice.TabIndex = 2;
            this.labTotalPrice.Text = "Payment amount";
            // 
            // labOrderDate
            // 
            this.labOrderDate.AutoSize = true;
            this.labOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderDate.Location = new System.Drawing.Point(217, 21);
            this.labOrderDate.Name = "labOrderDate";
            this.labOrderDate.Size = new System.Drawing.Size(92, 20);
            this.labOrderDate.TabIndex = 5;
            this.labOrderDate.Text = "Order Date:";
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPayment.Location = new System.Drawing.Point(179, 451);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(157, 32);
            this.btnConfirmPayment.TabIndex = 6;
            this.btnConfirmPayment.Text = "Confirm Payment ";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(315, 21);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(71, 20);
            this.txtOrderDate.TabIndex = 8;
            // 
            // grpPayment
            // 
            this.grpPayment.BackColor = System.Drawing.SystemColors.Control;
            this.grpPayment.Controls.Add(this.label2);
            this.grpPayment.Controls.Add(this.txtOrderDetailId);
            this.grpPayment.Controls.Add(this.grpCVV);
            this.grpPayment.Controls.Add(this.grpExpirDate);
            this.grpPayment.Controls.Add(this.grpCardNo);
            this.grpPayment.Controls.Add(this.grpPersonName);
            this.grpPayment.Controls.Add(this.grpPaymentMethod);
            this.grpPayment.Controls.Add(this.txtOrderId);
            this.grpPayment.Controls.Add(this.labOrderId);
            this.grpPayment.Controls.Add(this.txtPaymentAmount);
            this.grpPayment.Controls.Add(this.labTotalPrice);
            this.grpPayment.Controls.Add(this.txtPaymentId);
            this.grpPayment.Controls.Add(this.labPaymentID);
            this.grpPayment.Controls.Add(this.txtOrderDate);
            this.grpPayment.Controls.Add(this.labOrderDate);
            this.grpPayment.Location = new System.Drawing.Point(54, 53);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(398, 379);
            this.grpPayment.TabIndex = 9;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Card Number:";
            this.grpPayment.Enter += new System.EventHandler(this.grpPayment_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Order Detail ID:";
            // 
            // txtOrderDetailId
            // 
            this.txtOrderDetailId.Location = new System.Drawing.Point(315, 55);
            this.txtOrderDetailId.Name = "txtOrderDetailId";
            this.txtOrderDetailId.ReadOnly = true;
            this.txtOrderDetailId.Size = new System.Drawing.Size(71, 20);
            this.txtOrderDetailId.TabIndex = 26;
            this.txtOrderDetailId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpCVV
            // 
            this.grpCVV.Controls.Add(this.txtCvv);
            this.grpCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCVV.Location = new System.Drawing.Point(259, 276);
            this.grpCVV.Name = "grpCVV";
            this.grpCVV.Size = new System.Drawing.Size(127, 43);
            this.grpCVV.TabIndex = 25;
            this.grpCVV.TabStop = false;
            this.grpCVV.Text = "CVV";
            this.grpCVV.Visible = false;
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(49, 12);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(72, 26);
            this.txtCvv.TabIndex = 16;
            // 
            // grpExpirDate
            // 
            this.grpExpirDate.Controls.Add(this.txtExpirDate);
            this.grpExpirDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExpirDate.Location = new System.Drawing.Point(6, 263);
            this.grpExpirDate.Name = "grpExpirDate";
            this.grpExpirDate.Size = new System.Drawing.Size(209, 56);
            this.grpExpirDate.TabIndex = 24;
            this.grpExpirDate.TabStop = false;
            this.grpExpirDate.Text = "Expiration Date";
            this.grpExpirDate.Visible = false;
            // 
            // txtExpirDate
            // 
            this.txtExpirDate.Location = new System.Drawing.Point(119, 25);
            this.txtExpirDate.Name = "txtExpirDate";
            this.txtExpirDate.Size = new System.Drawing.Size(84, 26);
            this.txtExpirDate.TabIndex = 18;
            // 
            // grpCardNo
            // 
            this.grpCardNo.Controls.Add(this.txtCardNo);
            this.grpCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCardNo.Location = new System.Drawing.Point(6, 201);
            this.grpCardNo.Name = "grpCardNo";
            this.grpCardNo.Size = new System.Drawing.Size(380, 56);
            this.grpCardNo.TabIndex = 23;
            this.grpCardNo.TabStop = false;
            this.grpCardNo.Text = "Card Number";
            this.grpCardNo.Visible = false;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(125, 24);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(212, 26);
            this.txtCardNo.TabIndex = 14;
            this.txtCardNo.TextChanged += new System.EventHandler(this.txtCardNo_TextChanged);
            // 
            // grpPersonName
            // 
            this.grpPersonName.Controls.Add(this.txtPersonName);
            this.grpPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonName.Location = new System.Drawing.Point(6, 132);
            this.grpPersonName.Name = "grpPersonName";
            this.grpPersonName.Size = new System.Drawing.Size(380, 61);
            this.grpPersonName.TabIndex = 22;
            this.grpPersonName.TabStop = false;
            this.grpPersonName.Text = "Person Name";
            this.grpPersonName.Visible = false;
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(125, 25);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(212, 26);
            this.txtPersonName.TabIndex = 20;
            this.txtPersonName.TextChanged += new System.EventHandler(this.txtPersonName_TextChanged);
            // 
            // grpPaymentMethod
            // 
            this.grpPaymentMethod.Controls.Add(this.cboPaymentMethod);
            this.grpPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaymentMethod.Location = new System.Drawing.Point(6, 79);
            this.grpPaymentMethod.Name = "grpPaymentMethod";
            this.grpPaymentMethod.Size = new System.Drawing.Size(380, 56);
            this.grpPaymentMethod.TabIndex = 21;
            this.grpPaymentMethod.TabStop = false;
            this.grpPaymentMethod.Text = "Payment Method";
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentMethod.FormattingEnabled = true;
            this.cboPaymentMethod.Location = new System.Drawing.Point(125, 22);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(212, 28);
            this.cboPaymentMethod.TabIndex = 10;
            this.cboPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cboPaymentMethod_SelectedIndexChanged);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(113, 53);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(75, 20);
            this.txtOrderId.TabIndex = 13;
            this.txtOrderId.TextChanged += new System.EventHandler(this.txtOrderId_TextChanged);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtPaymentAmount.Location = new System.Drawing.Point(160, 338);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.ReadOnly = true;
            this.txtPaymentAmount.Size = new System.Drawing.Size(84, 20);
            this.txtPaymentAmount.TabIndex = 9;
            this.txtPaymentAmount.Text = "0.00";
            this.txtPaymentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.Location = new System.Drawing.Point(113, 19);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.ReadOnly = true;
            this.txtPaymentId.Size = new System.Drawing.Size(75, 20);
            this.txtPaymentId.TabIndex = 12;
            // 
            // labPaymentID
            // 
            this.labPaymentID.AutoSize = true;
            this.labPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPaymentID.Location = new System.Drawing.Point(15, 19);
            this.labPaymentID.Name = "labPaymentID";
            this.labPaymentID.Size = new System.Drawing.Size(96, 20);
            this.labPaymentID.TabIndex = 11;
            this.labPaymentID.Text = "Payment ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 10;
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
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(512, 504);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPayment";
            this.Text = "Pizza Delivery -[Payment]";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpCVV.ResumeLayout(false);
            this.grpCVV.PerformLayout();
            this.grpExpirDate.ResumeLayout(false);
            this.grpExpirDate.PerformLayout();
            this.grpCardNo.ResumeLayout(false);
            this.grpCardNo.PerformLayout();
            this.grpPersonName.ResumeLayout(false);
            this.grpPersonName.PerformLayout();
            this.grpPaymentMethod.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labOrderId;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label labOrderDate;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter1;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.Label labPaymentID;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.TextBox txtExpirDate;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.GroupBox grpCVV;
        private System.Windows.Forms.GroupBox grpExpirDate;
        private System.Windows.Forms.GroupBox grpCardNo;
        private System.Windows.Forms.GroupBox grpPersonName;
        private System.Windows.Forms.GroupBox grpPaymentMethod;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderDetailId;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}