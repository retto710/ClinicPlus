namespace TrabajoFinalWeb
{
    partial class frmAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtDNI2 = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.numericPhoneNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDNI, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnSearch, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar numero de DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(129, 3);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(704, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 338);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.lblType, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.txtNationality, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.txtAddress, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.txtEmail, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblEmail, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblNationality, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.txtDNI2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtLastName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDateOfBirth, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblPhoneNumber, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblAge, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblGender, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLastName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDNI, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbGender, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericAge, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.dateOfBirth, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblAddress, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.txtType, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.numericPhoneNumber, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00225F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00225F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00225F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00225F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00225F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00225F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00225F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.994749F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.994749F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.994749F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(396, 304);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 18);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 260);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "Type";
            // 
            // txtNationality
            // 
            this.txtNationality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNationality.Enabled = false;
            this.txtNationality.Location = new System.Drawing.Point(201, 237);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(192, 20);
            this.txtNationality.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(201, 211);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(192, 20);
            this.txtAddress.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(201, 185);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 182);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(3, 234);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(56, 13);
            this.lblNationality.TabIndex = 13;
            this.lblNationality.Text = "Nationality";
            // 
            // txtDNI2
            // 
            this.txtDNI2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDNI2.Enabled = false;
            this.txtDNI2.Location = new System.Drawing.Point(201, 55);
            this.txtDNI2.Name = "txtDNI2";
            this.txtDNI2.Size = new System.Drawing.Size(192, 20);
            this.txtDNI2.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(201, 29);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(192, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(3, 156);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(66, 13);
            this.lblDateOfBirth.TabIndex = 2;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 130);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(3, 104);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(3, 78);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(3, 26);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(3, 52);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI";
            // 
            // cmbGender
            // 
            this.cmbGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Enabled = false;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbGender.Location = new System.Drawing.Point(201, 81);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(192, 21);
            this.cmbGender.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(201, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 3;
            // 
            // numericAge
            // 
            this.numericAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericAge.Enabled = false;
            this.numericAge.Location = new System.Drawing.Point(201, 107);
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(192, 20);
            this.numericAge.TabIndex = 7;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Enabled = false;
            this.dateOfBirth.Location = new System.Drawing.Point(201, 159);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(192, 20);
            this.dateOfBirth.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 208);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address";
            // 
            // txtType
            // 
            this.txtType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.Enabled = false;
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Nurse",
            "Patient"});
            this.txtType.Location = new System.Drawing.Point(201, 263);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(192, 21);
            this.txtType.TabIndex = 13;
            // 
            // numericPhoneNumber
            // 
            this.numericPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericPhoneNumber.Enabled = false;
            this.numericPhoneNumber.Location = new System.Drawing.Point(200, 132);
            this.numericPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.numericPhoneNumber.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericPhoneNumber.Name = "numericPhoneNumber";
            this.numericPhoneNumber.Size = new System.Drawing.Size(194, 20);
            this.numericPhoneNumber.TabIndex = 8;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdd";
            this.Text = "frmAddDoctor";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPhoneNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.NumericUpDown numericPhoneNumber;
    }
}