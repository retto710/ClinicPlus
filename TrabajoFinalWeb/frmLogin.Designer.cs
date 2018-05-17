namespace TrabajoFinalWeb
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.checkBoxContraseña = new System.Windows.Forms.CheckBox();
            this.lblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.cmbTypeOfUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUsername.Location = new System.Drawing.Point(199, 117);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(199, 166);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(150, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 50);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ClinicPLus";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(196, 92);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(196, 145);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(199, 304);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(107, 32);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Log in";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkBoxContraseña
            // 
            this.checkBoxContraseña.AutoSize = true;
            this.checkBoxContraseña.Location = new System.Drawing.Point(199, 192);
            this.checkBoxContraseña.Name = "checkBoxContraseña";
            this.checkBoxContraseña.Size = new System.Drawing.Size(102, 17);
            this.checkBoxContraseña.TabIndex = 6;
            this.checkBoxContraseña.Text = "Show Password";
            this.checkBoxContraseña.UseVisualStyleBackColor = true;
            this.checkBoxContraseña.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Location = new System.Drawing.Point(199, 222);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(91, 13);
            this.lblForgotPassword.TabIndex = 7;
            this.lblForgotPassword.TabStop = true;
            this.lblForgotPassword.Text = "Forgot password?";
            this.lblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgotPassword_LinkClicked);
            // 
            // cmbTypeOfUser
            // 
            this.cmbTypeOfUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeOfUser.FormattingEnabled = true;
            this.cmbTypeOfUser.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Nurse"});
            this.cmbTypeOfUser.Location = new System.Drawing.Point(202, 277);
            this.cmbTypeOfUser.Name = "cmbTypeOfUser";
            this.cmbTypeOfUser.Size = new System.Drawing.Size(97, 21);
            this.cmbTypeOfUser.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type Of User";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTypeOfUser);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.checkBoxContraseña);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.CheckBox checkBoxContraseña;
        private System.Windows.Forms.LinkLabel lblForgotPassword;
        private System.Windows.Forms.ComboBox cmbTypeOfUser;
        private System.Windows.Forms.Label label1;
    }
}

