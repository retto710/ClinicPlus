namespace TrabajoFinalWeb.frmsNurses
{
    partial class frmCita
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEspecialidadDoctor = new System.Windows.Forms.Label();
            this.cbEspecialityDoctor = new System.Windows.Forms.ComboBox();
            this.btnSearchDoctors = new System.Windows.Forms.Button();
            this.btnGenerateDate = new System.Windows.Forms.Button();
            this.dtDateAppoinment = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfApoinment = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchDoctors);
            this.groupBox1.Controls.Add(this.cbEspecialityDoctor);
            this.groupBox1.Controls.Add(this.lblEspecialidadDoctor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar doctor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de doctores";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.lblDescription);
            this.groupBox3.Controls.Add(this.lblDateOfApoinment);
            this.groupBox3.Controls.Add(this.dtDateAppoinment);
            this.groupBox3.Controls.Add(this.btnGenerateDate);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(795, 145);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cita";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 252);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblEspecialidadDoctor
            // 
            this.lblEspecialidadDoctor.AutoSize = true;
            this.lblEspecialidadDoctor.Location = new System.Drawing.Point(13, 33);
            this.lblEspecialidadDoctor.Name = "lblEspecialidadDoctor";
            this.lblEspecialidadDoctor.Size = new System.Drawing.Size(124, 13);
            this.lblEspecialidadDoctor.TabIndex = 0;
            this.lblEspecialidadDoctor.Text = "Especialidad de doctor : ";
            // 
            // cbEspecialityDoctor
            // 
            this.cbEspecialityDoctor.FormattingEnabled = true;
            this.cbEspecialityDoctor.Location = new System.Drawing.Point(179, 33);
            this.cbEspecialityDoctor.Name = "cbEspecialityDoctor";
            this.cbEspecialityDoctor.Size = new System.Drawing.Size(121, 21);
            this.cbEspecialityDoctor.TabIndex = 1;
            // 
            // btnSearchDoctors
            // 
            this.btnSearchDoctors.Location = new System.Drawing.Point(387, 33);
            this.btnSearchDoctors.Name = "btnSearchDoctors";
            this.btnSearchDoctors.Size = new System.Drawing.Size(123, 23);
            this.btnSearchDoctors.TabIndex = 2;
            this.btnSearchDoctors.Text = "Buscar doctores";
            this.btnSearchDoctors.UseVisualStyleBackColor = true;
            // 
            // btnGenerateDate
            // 
            this.btnGenerateDate.Location = new System.Drawing.Point(439, 94);
            this.btnGenerateDate.Name = "btnGenerateDate";
            this.btnGenerateDate.Size = new System.Drawing.Size(166, 23);
            this.btnGenerateDate.TabIndex = 0;
            this.btnGenerateDate.Text = "Generar Cita";
            this.btnGenerateDate.UseVisualStyleBackColor = true;
            // 
            // dtDateAppoinment
            // 
            this.dtDateAppoinment.Location = new System.Drawing.Point(153, 20);
            this.dtDateAppoinment.Name = "dtDateAppoinment";
            this.dtDateAppoinment.Size = new System.Drawing.Size(200, 20);
            this.dtDateAppoinment.TabIndex = 1;
            // 
            // lblDateOfApoinment
            // 
            this.lblDateOfApoinment.AutoSize = true;
            this.lblDateOfApoinment.Location = new System.Drawing.Point(13, 26);
            this.lblDateOfApoinment.Name = "lblDateOfApoinment";
            this.lblDateOfApoinment.Size = new System.Drawing.Size(67, 13);
            this.lblDateOfApoinment.TabIndex = 2;
            this.lblDateOfApoinment.Text = "Dia de cita : ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "descripcion : ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(153, 48);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // frmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCita";
            this.Text = "frmCita";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearchDoctors;
        private System.Windows.Forms.ComboBox cbEspecialityDoctor;
        private System.Windows.Forms.Label lblEspecialidadDoctor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDateOfApoinment;
        private System.Windows.Forms.DateTimePicker dtDateAppoinment;
        private System.Windows.Forms.Button btnGenerateDate;
    }
}