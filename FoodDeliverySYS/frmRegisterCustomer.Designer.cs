namespace FoodDeliverySYS
{
    partial class frmRegisterCustomer
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
            this.registerCustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labConfirmPassword = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtbox = new System.Windows.Forms.Label();
            this.cboTown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.labelEircode = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCounty = new System.Windows.Forms.Label();
            this.labelTown = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCustomersGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerCustomersGroupBox
            // 
            this.registerCustomersGroupBox.BackColor = System.Drawing.Color.Gold;
            this.registerCustomersGroupBox.Controls.Add(this.btnConfirm);
            this.registerCustomersGroupBox.Controls.Add(this.btnReset);
            this.registerCustomersGroupBox.Controls.Add(this.txtConfirmPassword);
            this.registerCustomersGroupBox.Controls.Add(this.txtPassword);
            this.registerCustomersGroupBox.Controls.Add(this.labConfirmPassword);
            this.registerCustomersGroupBox.Controls.Add(this.labPassword);
            this.registerCustomersGroupBox.Controls.Add(this.txtCustomerID);
            this.registerCustomersGroupBox.Controls.Add(this.txtbox);
            this.registerCustomersGroupBox.Controls.Add(this.cboTown);
            this.registerCustomersGroupBox.Controls.Add(this.label1);
            this.registerCustomersGroupBox.Controls.Add(this.cboCounty);
            this.registerCustomersGroupBox.Controls.Add(this.txtPhoneNumber);
            this.registerCustomersGroupBox.Controls.Add(this.txtAddress);
            this.registerCustomersGroupBox.Controls.Add(this.txtEircode);
            this.registerCustomersGroupBox.Controls.Add(this.txtEmailAddress);
            this.registerCustomersGroupBox.Controls.Add(this.labelPhoneNo);
            this.registerCustomersGroupBox.Controls.Add(this.labelEircode);
            this.registerCustomersGroupBox.Controls.Add(this.labelEmailAddress);
            this.registerCustomersGroupBox.Controls.Add(this.labelAddress);
            this.registerCustomersGroupBox.Controls.Add(this.labelCounty);
            this.registerCustomersGroupBox.Controls.Add(this.labelTown);
            this.registerCustomersGroupBox.Controls.Add(this.txtLastName);
            this.registerCustomersGroupBox.Controls.Add(this.txtFirstName);
            this.registerCustomersGroupBox.Controls.Add(this.button2);
            this.registerCustomersGroupBox.Controls.Add(this.btnUpdate);
            this.registerCustomersGroupBox.Controls.Add(this.phoneNumber_label);
            this.registerCustomersGroupBox.Controls.Add(this.lastNamelabel);
            this.registerCustomersGroupBox.Controls.Add(this.firstNamelabel);
            this.registerCustomersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerCustomersGroupBox.Location = new System.Drawing.Point(12, 27);
            this.registerCustomersGroupBox.Name = "registerCustomersGroupBox";
            this.registerCustomersGroupBox.Size = new System.Drawing.Size(776, 446);
            this.registerCustomersGroupBox.TabIndex = 2;
            this.registerCustomersGroupBox.TabStop = false;
            this.registerCustomersGroupBox.Tag = "";
            this.registerCustomersGroupBox.Text = "Register Customer";
            this.registerCustomersGroupBox.Enter += new System.EventHandler(this.registerCustomersGroupBox_Enter);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Red;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(208, 374);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(124, 37);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(457, 374);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 37);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(554, 301);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(136, 22);
            this.txtConfirmPassword.TabIndex = 53;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(196, 301);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(136, 22);
            this.txtPassword.TabIndex = 52;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // labConfirmPassword
            // 
            this.labConfirmPassword.AutoSize = true;
            this.labConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConfirmPassword.Location = new System.Drawing.Point(390, 301);
            this.labConfirmPassword.Name = "labConfirmPassword";
            this.labConfirmPassword.Size = new System.Drawing.Size(158, 20);
            this.labConfirmPassword.TabIndex = 51;
            this.labConfirmPassword.Text = " Confirm Password";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.Location = new System.Drawing.Point(94, 301);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(86, 20);
            this.labPassword.TabIndex = 50;
            this.labPassword.Text = "Password";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(196, 81);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(136, 22);
            this.txtCustomerID.TabIndex = 49;
            // 
            // txtbox
            // 
            this.txtbox.AutoSize = true;
            this.txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox.Location = new System.Drawing.Point(70, 81);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(110, 20);
            this.txtbox.TabIndex = 48;
            this.txtbox.Text = "Customer ID";
            // 
            // cboTown
            // 
            this.cboTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTown.FormattingEnabled = true;
            this.cboTown.Items.AddRange(new object[] {
            "Brandon",
            "Cahersiveen",
            "Dingle",
            "Finuge",
            "Farranfore",
            "Killarney",
            "Listowel",
            "Milltown",
            "Tralee",
            "Waterville",
            "",
            ""});
            this.cboTown.Location = new System.Drawing.Point(554, 216);
            this.cboTown.Name = "cboTown";
            this.cboTown.Size = new System.Drawing.Size(136, 24);
            this.cboTown.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(297, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Register Customer";
            // 
            // cboCounty
            // 
            this.cboCounty.BackColor = System.Drawing.Color.PapayaWhip;
            this.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
            "KERRY"});
            this.cboCounty.Location = new System.Drawing.Point(196, 216);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(136, 24);
            this.cboCounty.TabIndex = 45;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(554, 261);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(136, 22);
            this.txtPhoneNumber.TabIndex = 44;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(554, 174);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(136, 22);
            this.txtAddress.TabIndex = 42;
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(196, 261);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(136, 22);
            this.txtEircode.TabIndex = 41;
            this.txtEircode.TextChanged += new System.EventHandler(this.txtEircode_TextChanged);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(196, 171);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(136, 22);
            this.txtEmailAddress.TabIndex = 39;
            this.txtEmailAddress.TextChanged += new System.EventHandler(this.txtEmailAddress_TextChanged);
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNo.Location = new System.Drawing.Point(421, 261);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(127, 20);
            this.labelPhoneNo.TabIndex = 38;
            this.labelPhoneNo.Text = "Phone Number";
            // 
            // labelEircode
            // 
            this.labelEircode.AutoSize = true;
            this.labelEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEircode.Location = new System.Drawing.Point(110, 261);
            this.labelEircode.Name = "labelEircode";
            this.labelEircode.Size = new System.Drawing.Size(70, 20);
            this.labelEircode.TabIndex = 37;
            this.labelEircode.Text = "Eircode";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailAddress.Location = new System.Drawing.Point(56, 174);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(124, 20);
            this.labelEmailAddress.TabIndex = 36;
            this.labelEmailAddress.Text = "Email Address";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(473, 176);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(75, 20);
            this.labelAddress.TabIndex = 35;
            this.labelAddress.Text = "Address";
            // 
            // labelCounty
            // 
            this.labelCounty.AutoSize = true;
            this.labelCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounty.Location = new System.Drawing.Point(115, 220);
            this.labelCounty.Name = "labelCounty";
            this.labelCounty.Size = new System.Drawing.Size(65, 20);
            this.labelCounty.TabIndex = 34;
            this.labelCounty.Text = "County";
            // 
            // labelTown
            // 
            this.labelTown.AutoSize = true;
            this.labelTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTown.Location = new System.Drawing.Point(497, 220);
            this.labelTown.Name = "labelTown";
            this.labelTown.Size = new System.Drawing.Size(51, 20);
            this.labelTown.TabIndex = 33;
            this.labelTown.Text = "Town";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(554, 130);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(136, 22);
            this.txtLastName.TabIndex = 32;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(196, 129);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(136, 22);
            this.txtFirstName.TabIndex = 31;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(380, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 39);
            this.button2.TabIndex = 30;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(159, 527);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 39);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber_label.Location = new System.Drawing.Point(55, 349);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(0, 25);
            this.phoneNumber_label.TabIndex = 3;
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelabel.Location = new System.Drawing.Point(453, 130);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(95, 20);
            this.lastNamelabel.TabIndex = 2;
            this.lastNamelabel.Text = "Last Name";
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNamelabel.Location = new System.Drawing.Point(84, 132);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(96, 20);
            this.firstNamelabel.TabIndex = 0;
            this.firstNamelabel.Text = "First Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.backToolStripMenuItem.Text = "BACK";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // frmRegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.registerCustomersGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRegisterCustomer";
            this.Text = "Pizza Delivery -[Register Customer]";
            this.Load += new System.EventHandler(this.frmRegisterCustomer_Load);
            this.registerCustomersGroupBox.ResumeLayout(false);
            this.registerCustomersGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox registerCustomersGroupBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.Label firstNamelabel;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.Label labelEircode;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCounty;
        private System.Windows.Forms.Label labelTown;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboTown;
        private System.Windows.Forms.Label txtbox;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labConfirmPassword;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}