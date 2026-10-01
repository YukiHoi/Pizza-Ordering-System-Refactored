namespace FoodDeliverySYS
{
    partial class frmRemoveFood
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemovePizza = new System.Windows.Forms.Label();
            this.lblSelectedPizza = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemovePizza = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemovePizza);
            this.groupBox1.Controls.Add(this.lblSelectedPizza);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnRemovePizza);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove Pizza";
            // 
            // RemovePizza
            // 
            this.RemovePizza.AutoSize = true;
            this.RemovePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovePizza.Location = new System.Drawing.Point(283, 63);
            this.RemovePizza.Name = "RemovePizza";
            this.RemovePizza.Size = new System.Drawing.Size(162, 25);
            this.RemovePizza.TabIndex = 45;
            this.RemovePizza.Text = "Remove Pizza";
            // 
            // lblSelectedPizza
            // 
            this.lblSelectedPizza.FormattingEnabled = true;
            this.lblSelectedPizza.ItemHeight = 20;
            this.lblSelectedPizza.Items.AddRange(new object[] {
            "Pepperoni",
            "Anchovy",
            "Mozzarella",
            "Pesto",
            "New York Style Pizza",
            "BBQ chicken pizza."});
            this.lblSelectedPizza.Location = new System.Drawing.Point(229, 104);
            this.lblSelectedPizza.Name = "lblSelectedPizza";
            this.lblSelectedPizza.Size = new System.Drawing.Size(247, 124);
            this.lblSelectedPizza.TabIndex = 44;
            this.lblSelectedPizza.SelectedIndexChanged += new System.EventHandler(this.lstPizzaList_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(415, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 53);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemovePizza
            // 
            this.btnRemovePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePizza.Location = new System.Drawing.Point(175, 294);
            this.btnRemovePizza.Name = "btnRemovePizza";
            this.btnRemovePizza.Size = new System.Drawing.Size(172, 53);
            this.btnRemovePizza.TabIndex = 41;
            this.btnRemovePizza.Text = "Remove Pizza";
            this.btnRemovePizza.UseVisualStyleBackColor = true;
            this.btnRemovePizza.Click += new System.EventHandler(this.btnRemovePizza_Click);
            // 
            // frmRemoveFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRemoveFood";
            this.Text = "Food Delivery -[Remove Food]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label RemovePizza;
        private System.Windows.Forms.ListBox lblSelectedPizza;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemovePizza;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}