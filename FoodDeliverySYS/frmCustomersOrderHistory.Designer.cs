namespace FoodDeliverySYS
{
    partial class fmCustomersOrderHistory
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
            this.orderHistoryGroupBox = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.OrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.MonthCalendar();
            this.txtEndDate = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderHistoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderHistoryGroupBox
            // 
            this.orderHistoryGroupBox.Controls.Add(this.label3);
            this.orderHistoryGroupBox.Controls.Add(this.label2);
            this.orderHistoryGroupBox.Controls.Add(this.txtEndDate);
            this.orderHistoryGroupBox.Controls.Add(this.txtStartDate);
            this.orderHistoryGroupBox.Controls.Add(this.label1);
            this.orderHistoryGroupBox.Controls.Add(this.btnView);
            this.orderHistoryGroupBox.Controls.Add(this.btnCancel);
            this.orderHistoryGroupBox.Controls.Add(this.OrderID);
            this.orderHistoryGroupBox.Controls.Add(this.txtOrderID);
            this.orderHistoryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHistoryGroupBox.Location = new System.Drawing.Point(73, 23);
            this.orderHistoryGroupBox.Name = "orderHistoryGroupBox";
            this.orderHistoryGroupBox.Size = new System.Drawing.Size(612, 548);
            this.orderHistoryGroupBox.TabIndex = 0;
            this.orderHistoryGroupBox.TabStop = false;
            this.orderHistoryGroupBox.Text = "Order History";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(94, 476);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(172, 53);
            this.btnView.TabIndex = 27;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(360, 476);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 53);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // OrderID
            // 
            this.OrderID.AutoSize = true;
            this.OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderID.Location = new System.Drawing.Point(60, 75);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(100, 25);
            this.OrderID.TabIndex = 24;
            this.OrderID.Text = "Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(205, 74);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(315, 26);
            this.txtOrderID.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Date Range";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(65, 283);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.TabIndex = 30;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(334, 283);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "End Date";
            // 
            // fmCustomersOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.orderHistoryGroupBox);
            this.Name = "fmCustomersOrderHistory";
            this.Text = "fmCustomersOrderHistory";
            this.orderHistoryGroupBox.ResumeLayout(false);
            this.orderHistoryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox orderHistoryGroupBox;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label OrderID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.MonthCalendar txtStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar txtEndDate;
    }
}