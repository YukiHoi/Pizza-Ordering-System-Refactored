namespace FoodDeliverySYS
{
    partial class frmPizzaCart
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
            this.lstPizza = new System.Windows.Forms.ListBox();
            this.labTotalCost = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstPizza
            // 
            this.lstPizza.FormattingEnabled = true;
            this.lstPizza.Location = new System.Drawing.Point(171, 54);
            this.lstPizza.Name = "lstPizza";
            this.lstPizza.Size = new System.Drawing.Size(456, 212);
            this.lstPizza.TabIndex = 80;
            // 
            // labTotalCost
            // 
            this.labTotalCost.AutoSize = true;
            this.labTotalCost.BackColor = System.Drawing.Color.Yellow;
            this.labTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalCost.Location = new System.Drawing.Point(248, 305);
            this.labTotalCost.Name = "labTotalCost";
            this.labTotalCost.Size = new System.Drawing.Size(92, 18);
            this.labTotalCost.TabIndex = 81;
            this.labTotalCost.Text = "Total Cost:";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(346, 305);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(154, 24);
            this.txtTotalCost.TabIndex = 82;
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmPizzaCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.labTotalCost);
            this.Controls.Add(this.lstPizza);
            this.Name = "frmPizzaCart";
            this.Text = "frmPizzaCart";
            this.Load += new System.EventHandler(this.frmPizzaCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPizza;
        private System.Windows.Forms.Label labTotalCost;
        private System.Windows.Forms.TextBox txtTotalCost;
    }
}