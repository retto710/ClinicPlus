namespace TrabajoFinalWeb.frmsDoctor
{
    partial class frmRequestService
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
            this.lblDateOfService = new System.Windows.Forms.Label();
            this.dtServices = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.btnRequestService = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRequestService);
            this.groupBox1.Controls.Add(this.txtServiceDescription);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.dtServices);
            this.groupBox1.Controls.Add(this.lblDateOfService);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitar servicio";
            // 
            // lblDateOfService
            // 
            this.lblDateOfService.AutoSize = true;
            this.lblDateOfService.Location = new System.Drawing.Point(31, 35);
            this.lblDateOfService.Name = "lblDateOfService";
            this.lblDateOfService.Size = new System.Drawing.Size(121, 13);
            this.lblDateOfService.TabIndex = 0;
            this.lblDateOfService.Text = "Dia para uso de servicio";
            // 
            // dtServices
            // 
            this.dtServices.Location = new System.Drawing.Point(222, 35);
            this.dtServices.Name = "dtServices";
            this.dtServices.Size = new System.Drawing.Size(200, 20);
            this.dtServices.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(31, 71);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Descripcion";
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(222, 63);
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(200, 20);
            this.txtServiceDescription.TabIndex = 3;
            // 
            // btnRequestService
            // 
            this.btnRequestService.Location = new System.Drawing.Point(169, 110);
            this.btnRequestService.Name = "btnRequestService";
            this.btnRequestService.Size = new System.Drawing.Size(137, 23);
            this.btnRequestService.TabIndex = 4;
            this.btnRequestService.Text = "Solicitar servicio";
            this.btnRequestService.UseVisualStyleBackColor = true;
            // 
            // frmRequestService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 193);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRequestService";
            this.Text = "frmRequestService";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRequestService;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtServices;
        private System.Windows.Forms.Label lblDateOfService;
    }
}