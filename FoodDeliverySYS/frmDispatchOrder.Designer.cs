namespace FoodDeliverySYS
{
    partial class frmDispatchOrder
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
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.dgvDelivery = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dispatchOrder = new System.Windows.Forms.Label();
            this.btnDispatchOrder = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDispatchConfirmation = new System.Windows.Forms.GroupBox();
            this.labOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.labDeliveryDate = new System.Windows.Forms.Label();
            this.cboStaffId = new System.Windows.Forms.ComboBox();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.labDelivery = new System.Windows.Forms.Label();
            this.labAssignedDriver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpDispatchConfirmation.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboOrderId
            // 
            this.cboOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderId.FormattingEnabled = true;
            this.cboOrderId.Location = new System.Drawing.Point(291, 65);
            this.cboOrderId.Name = "cboOrderId";
            this.cboOrderId.Size = new System.Drawing.Size(178, 21);
            this.cboOrderId.TabIndex = 67;
            this.cboOrderId.SelectedIndexChanged += new System.EventHandler(this.cboOrderId_SelectedIndexChanged);
            // 
            // dgvDelivery
            // 
            this.dgvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelivery.Location = new System.Drawing.Point(79, 111);
            this.dgvDelivery.Name = "dgvDelivery";
            this.dgvDelivery.Size = new System.Drawing.Size(641, 120);
            this.dgvDelivery.TabIndex = 66;
            this.dgvDelivery.Visible = false;
            this.dgvDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelivery_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order ID:";
            // 
            // dispatchOrder
            // 
            this.dispatchOrder.AutoSize = true;
            this.dispatchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispatchOrder.Location = new System.Drawing.Point(254, 24);
            this.dispatchOrder.Name = "dispatchOrder";
            this.dispatchOrder.Size = new System.Drawing.Size(251, 24);
            this.dispatchOrder.TabIndex = 0;
            this.dispatchOrder.Text = "Order Ready for Dispatch ";
            // 
            // btnDispatchOrder
            // 
            this.btnDispatchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispatchOrder.Location = new System.Drawing.Point(66, 202);
            this.btnDispatchOrder.Name = "btnDispatchOrder";
            this.btnDispatchOrder.Size = new System.Drawing.Size(160, 26);
            this.btnDispatchOrder.TabIndex = 1;
            this.btnDispatchOrder.Text = "Dispatch Order";
            this.btnDispatchOrder.UseVisualStyleBackColor = true;
            this.btnDispatchOrder.Click += new System.EventHandler(this.btnDispatchOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(321, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 26);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
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
            // grpDispatchConfirmation
            // 
            this.grpDispatchConfirmation.Controls.Add(this.labOrderId);
            this.grpDispatchConfirmation.Controls.Add(this.txtOrderId);
            this.grpDispatchConfirmation.Controls.Add(this.txtDeliveryDate);
            this.grpDispatchConfirmation.Controls.Add(this.labDeliveryDate);
            this.grpDispatchConfirmation.Controls.Add(this.cboStaffId);
            this.grpDispatchConfirmation.Controls.Add(this.txtDeliveryId);
            this.grpDispatchConfirmation.Controls.Add(this.labDelivery);
            this.grpDispatchConfirmation.Controls.Add(this.labAssignedDriver);
            this.grpDispatchConfirmation.Controls.Add(this.btnDispatchOrder);
            this.grpDispatchConfirmation.Controls.Add(this.btnCancel);
            this.grpDispatchConfirmation.Location = new System.Drawing.Point(145, 237);
            this.grpDispatchConfirmation.Name = "grpDispatchConfirmation";
            this.grpDispatchConfirmation.Size = new System.Drawing.Size(482, 245);
            this.grpDispatchConfirmation.TabIndex = 69;
            this.grpDispatchConfirmation.TabStop = false;
            this.grpDispatchConfirmation.Text = "Dispatch Confirmation";
            this.grpDispatchConfirmation.Visible = false;
            this.grpDispatchConfirmation.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labOrderId
            // 
            this.labOrderId.AutoSize = true;
            this.labOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderId.Location = new System.Drawing.Point(117, 81);
            this.labOrderId.Name = "labOrderId";
            this.labOrderId.Size = new System.Drawing.Size(77, 18);
            this.labOrderId.TabIndex = 19;
            this.labOrderId.Text = "Order ID:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(200, 81);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(177, 20);
            this.txtOrderId.TabIndex = 18;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(200, 117);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.ReadOnly = true;
            this.txtDeliveryDate.Size = new System.Drawing.Size(177, 20);
            this.txtDeliveryDate.TabIndex = 17;
            // 
            // labDeliveryDate
            // 
            this.labDeliveryDate.AutoSize = true;
            this.labDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDeliveryDate.Location = new System.Drawing.Point(81, 118);
            this.labDeliveryDate.Name = "labDeliveryDate";
            this.labDeliveryDate.Size = new System.Drawing.Size(113, 18);
            this.labDeliveryDate.TabIndex = 16;
            this.labDeliveryDate.Text = "Delivery Date:";
            // 
            // cboStaffId
            // 
            this.cboStaffId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaffId.FormattingEnabled = true;
            this.cboStaffId.Location = new System.Drawing.Point(200, 156);
            this.cboStaffId.Name = "cboStaffId";
            this.cboStaffId.Size = new System.Drawing.Size(177, 21);
            this.cboStaffId.TabIndex = 15;
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Location = new System.Drawing.Point(200, 38);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.ReadOnly = true;
            this.txtDeliveryId.Size = new System.Drawing.Size(177, 20);
            this.txtDeliveryId.TabIndex = 14;
            // 
            // labDelivery
            // 
            this.labDelivery.AutoSize = true;
            this.labDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDelivery.Location = new System.Drawing.Point(100, 38);
            this.labDelivery.Name = "labDelivery";
            this.labDelivery.Size = new System.Drawing.Size(94, 18);
            this.labDelivery.TabIndex = 13;
            this.labDelivery.Text = "Delivery ID:";
            // 
            // labAssignedDriver
            // 
            this.labAssignedDriver.AutoSize = true;
            this.labAssignedDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAssignedDriver.Location = new System.Drawing.Point(63, 157);
            this.labAssignedDriver.Name = "labAssignedDriver";
            this.labAssignedDriver.Size = new System.Drawing.Size(131, 18);
            this.labAssignedDriver.TabIndex = 5;
            this.labAssignedDriver.Text = "Assigned Driver:";
            // 
            // frmDispatchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.dgvDelivery);
            this.Controls.Add(this.cboOrderId);
            this.Controls.Add(this.grpDispatchConfirmation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dispatchOrder);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDispatchOrder";
            this.Text = "Pizza Delivery -[Dispatch Order]";
            this.Load += new System.EventHandler(this.frmDispatchOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDispatchConfirmation.ResumeLayout(false);
            this.grpDispatchConfirmation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label dispatchOrder;
        private System.Windows.Forms.Button btnDispatchOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDelivery;
        private System.Windows.Forms.GroupBox grpDispatchConfirmation;
        private System.Windows.Forms.Label labAssignedDriver;
        private System.Windows.Forms.ComboBox cboOrderId;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Label labDelivery;
        private System.Windows.Forms.ComboBox cboStaffId;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.Label labDeliveryDate;
        private System.Windows.Forms.Label labOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
    }
}