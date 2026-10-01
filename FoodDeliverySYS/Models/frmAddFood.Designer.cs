namespace FoodDeliverySYS.Models
{
    partial class frmAddFood
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clbToppings = new System.Windows.Forms.CheckedListBox();
            this.cmbPizzaSize = new System.Windows.Forms.ComboBox();
            this.cmbCrustType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dvgPizzaList = new System.Windows.Forms.DataGridView();
            this.dvgToppingList = new System.Windows.Forms.DataGridView();
            this.txtPizzaName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPizzaList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgToppingList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPizzaName);
            this.groupBox1.Controls.Add(this.btnAddPizza);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.clbToppings);
            this.groupBox1.Controls.Add(this.cmbPizzaSize);
            this.groupBox1.Controls.Add(this.cmbCrustType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza Detail";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPizza.Location = new System.Drawing.Point(109, 263);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(105, 36);
            this.btnAddPizza.TabIndex = 13;
            this.btnAddPizza.Text = "Add Pizza";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(247, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 36);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // clbToppings
            // 
            this.clbToppings.FormattingEnabled = true;
            this.clbToppings.Items.AddRange(new object[] {
            "Pepperoni slices - Pork",
            "Pepperoni slices - Beef",
            "Anchovy",
            "Mozzarella",
            "Sausage",
            "Mushrooms",
            "Grilled chicken",
            "Red onion",
            "Cheddar cheese",
            "Pine nuts ",
            "Fresh basil leaves",
            "Green peppers ",
            "Black olives",
            "Ham",
            "Pineapple chunks",
            "Bacon",
            "Ground beef",
            "Prawns"});
            this.clbToppings.Location = new System.Drawing.Point(200, 149);
            this.clbToppings.Name = "clbToppings";
            this.clbToppings.Size = new System.Drawing.Size(152, 94);
            this.clbToppings.TabIndex = 11;
            this.clbToppings.SelectedIndexChanged += new System.EventHandler(this.clbToppings_SelectedIndexChanged);
            // 
            // cmbPizzaSize
            // 
            this.cmbPizzaSize.FormattingEnabled = true;
            this.cmbPizzaSize.Items.AddRange(new object[] {
            "Thin (€1.00)",
            "Regular (€2.00)",
            "Cheese Stuffed (€3.00)"});
            this.cmbPizzaSize.Location = new System.Drawing.Point(200, 66);
            this.cmbPizzaSize.Name = "cmbPizzaSize";
            this.cmbPizzaSize.Size = new System.Drawing.Size(152, 21);
            this.cmbPizzaSize.TabIndex = 10;
            // 
            // cmbCrustType
            // 
            this.cmbCrustType.FormattingEnabled = true;
            this.cmbCrustType.Items.AddRange(new object[] {
            "Small  (€0.00)",
            "Medium (€2.00)",
            "Large  (€4.00)",
            "Extra Large  (€6.00)"});
            this.cmbCrustType.Location = new System.Drawing.Point(200, 108);
            this.cmbCrustType.Name = "cmbCrustType";
            this.cmbCrustType.Size = new System.Drawing.Size(152, 21);
            this.cmbCrustType.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Crust Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pizza Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Topping";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pizza List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(521, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Topping For Selected Pizza ";
            // 
            // dvgPizzaList
            // 
            this.dvgPizzaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPizzaList.Location = new System.Drawing.Point(67, 409);
            this.dvgPizzaList.Name = "dvgPizzaList";
            this.dvgPizzaList.Size = new System.Drawing.Size(422, 88);
            this.dvgPizzaList.TabIndex = 6;
            // 
            // dvgToppingList
            // 
            this.dvgToppingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgToppingList.Location = new System.Drawing.Point(525, 121);
            this.dvgToppingList.Name = "dvgToppingList";
            this.dvgToppingList.Size = new System.Drawing.Size(230, 134);
            this.dvgToppingList.TabIndex = 7;
            this.dvgToppingList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgToppingList_CellContentClick);
            // 
            // txtPizzaName
            // 
            this.txtPizzaName.Location = new System.Drawing.Point(200, 28);
            this.txtPizzaName.Name = "txtPizzaName";
            this.txtPizzaName.Size = new System.Drawing.Size(152, 20);
            this.txtPizzaName.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.dvgToppingList);
            this.Controls.Add(this.dvgPizzaList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Name = "frmAddFood";
            this.Text = "Food Delivery -[Add Food]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPizzaList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgToppingList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPizzaSize;
        private System.Windows.Forms.ComboBox cmbCrustType;
        private System.Windows.Forms.CheckedListBox clbToppings;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dvgPizzaList;
        private System.Windows.Forms.DataGridView dvgToppingList;
        private System.Windows.Forms.TextBox txtPizzaName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}