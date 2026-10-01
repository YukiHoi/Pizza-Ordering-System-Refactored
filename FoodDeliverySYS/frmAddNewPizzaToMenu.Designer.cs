namespace FoodDeliverySYS.Models
{
    partial class frmAddPizzz
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
            this.grpAddNewPizza = new System.Windows.Forms.GroupBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtPizzaID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPizzaName = new System.Windows.Forms.TextBox();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpPizzaName = new System.Windows.Forms.GroupBox();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.grpBasePrice = new System.Windows.Forms.GroupBox();
            this.grpAddNewPizza.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpPizzaName.SuspendLayout();
            this.grpCategory.SuspendLayout();
            this.grpDescription.SuspendLayout();
            this.grpBasePrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddNewPizza
            // 
            this.grpAddNewPizza.Controls.Add(this.grpBasePrice);
            this.grpAddNewPizza.Controls.Add(this.grpDescription);
            this.grpAddNewPizza.Controls.Add(this.grpCategory);
            this.grpAddNewPizza.Controls.Add(this.grpPizzaName);
            this.grpAddNewPizza.Controls.Add(this.btnReset);
            this.grpAddNewPizza.Controls.Add(this.txtPizzaID);
            this.grpAddNewPizza.Controls.Add(this.label6);
            this.grpAddNewPizza.Location = new System.Drawing.Point(47, 102);
            this.grpAddNewPizza.Name = "grpAddNewPizza";
            this.grpAddNewPizza.Size = new System.Drawing.Size(693, 257);
            this.grpAddNewPizza.TabIndex = 0;
            this.grpAddNewPizza.TabStop = false;
            this.grpAddNewPizza.Text = "Pizza Detail";
            this.grpAddNewPizza.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(72, 21);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(152, 28);
            this.cboCategory.TabIndex = 29;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePrice.Location = new System.Drawing.Point(113, 24);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(111, 22);
            this.txtBasePrice.TabIndex = 27;
            this.txtBasePrice.Text = "0.00";
            this.txtBasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBasePrice.TextChanged += new System.EventHandler(this.txtBasePrice_TextChanged);
            // 
            // txtPizzaID
            // 
            this.txtPizzaID.Location = new System.Drawing.Point(173, 33);
            this.txtPizzaID.Name = "txtPizzaID";
            this.txtPizzaID.ReadOnly = true;
            this.txtPizzaID.Size = new System.Drawing.Size(152, 20);
            this.txtPizzaID.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Pizza ID";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(72, 23);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(152, 57);
            this.txtDescription.TabIndex = 16;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtPizzaName
            // 
            this.txtPizzaName.Location = new System.Drawing.Point(72, 19);
            this.txtPizzaName.Name = "txtPizzaName";
            this.txtPizzaName.Size = new System.Drawing.Size(152, 26);
            this.txtPizzaName.TabIndex = 14;
            this.txtPizzaName.TextChanged += new System.EventHandler(this.txtPizzaName_TextChanged);
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPizza.Location = new System.Drawing.Point(107, 75);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(105, 26);
            this.btnAddPizza.TabIndex = 13;
            this.btnAddPizza.Text = "Add Pizza";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(434, 213);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 26);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add New Pizza to Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 9;
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
            // grpPizzaName
            // 
            this.grpPizzaName.Controls.Add(this.txtPizzaName);
            this.grpPizzaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPizzaName.Location = new System.Drawing.Point(95, 74);
            this.grpPizzaName.Name = "grpPizzaName";
            this.grpPizzaName.Size = new System.Drawing.Size(230, 52);
            this.grpPizzaName.TabIndex = 30;
            this.grpPizzaName.TabStop = false;
            this.grpPizzaName.Text = "Pizza Name";
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.cboCategory);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.Location = new System.Drawing.Point(428, 111);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(230, 52);
            this.grpCategory.TabIndex = 31;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Category";
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.txtDescription);
            this.grpDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDescription.Location = new System.Drawing.Point(428, 19);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(230, 86);
            this.grpDescription.TabIndex = 32;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "Description";
            // 
            // grpBasePrice
            // 
            this.grpBasePrice.Controls.Add(this.txtBasePrice);
            this.grpBasePrice.Controls.Add(this.btnAddPizza);
            this.grpBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBasePrice.Location = new System.Drawing.Point(95, 132);
            this.grpBasePrice.Name = "grpBasePrice";
            this.grpBasePrice.Size = new System.Drawing.Size(273, 107);
            this.grpBasePrice.TabIndex = 33;
            this.grpBasePrice.TabStop = false;
            this.grpBasePrice.Text = "Base Price";
            this.grpBasePrice.Visible = false;
            // 
            // frmAddPizzz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 413);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpAddNewPizza);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddPizzz";
            this.Text = "Pizza Delivery -[Add Pizza]";
            this.Load += new System.EventHandler(this.frmAddPizzz_Load);
            this.grpAddNewPizza.ResumeLayout(false);
            this.grpAddNewPizza.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpPizzaName.ResumeLayout(false);
            this.grpPizzaName.PerformLayout();
            this.grpCategory.ResumeLayout(false);
            this.grpDescription.ResumeLayout(false);
            this.grpDescription.PerformLayout();
            this.grpBasePrice.ResumeLayout(false);
            this.grpBasePrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddNewPizza;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtPizzaName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPizzaID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpPizzaName;
        private System.Windows.Forms.GroupBox grpBasePrice;
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.GroupBox grpCategory;
    }
}