﻿namespace TrabajoFinalWeb.frmsNurses
{
    partial class frmPatientDate
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfAppointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lblDateForDate = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.txtHeigth = new System.Windows.Forms.TextBox();
            this.txtWiegth = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCreateDeate = new System.Windows.Forms.Button();
            this.cbSpeciality = new System.Windows.Forms.ComboBox();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.dtDate4Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDateBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 494);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista pacientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateOfRequest,
            this.dateOfAppointment,
            this.nurseId,
            this.doctorId,
            this.description,
            this.status,
            this.weight,
            this.height,
            this.alergies,
            this.service});
            this.dataGridView1.DataSource = this.clinicDateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1091, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(Entities.patient);
            // 
            // clinicDateBindingSource
            // 
            this.clinicDateBindingSource.DataSource = typeof(Entities.clinicDate);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dateOfRequest
            // 
            this.dateOfRequest.DataPropertyName = "dateOfRequest";
            this.dateOfRequest.HeaderText = "dateOfRequest";
            this.dateOfRequest.Name = "dateOfRequest";
            // 
            // dateOfAppointment
            // 
            this.dateOfAppointment.DataPropertyName = "dateOfAppointment";
            this.dateOfAppointment.HeaderText = "dateOfAppointment";
            this.dateOfAppointment.Name = "dateOfAppointment";
            // 
            // nurseId
            // 
            this.nurseId.DataPropertyName = "nurseId";
            this.nurseId.HeaderText = "nurseId";
            this.nurseId.Name = "nurseId";
            // 
            // doctorId
            // 
            this.doctorId.DataPropertyName = "doctorId";
            this.doctorId.HeaderText = "doctorId";
            this.doctorId.Name = "doctorId";
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.Name = "description";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "weight";
            this.weight.Name = "weight";
            // 
            // height
            // 
            this.height.DataPropertyName = "height";
            this.height.HeaderText = "height";
            this.height.Name = "height";
            // 
            // alergies
            // 
            this.alergies.DataPropertyName = "alergies";
            this.alergies.HeaderText = "alergies";
            this.alergies.Name = "alergies";
            // 
            // service
            // 
            this.service.DataPropertyName = "service";
            this.service.HeaderText = "service";
            this.service.Name = "service";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtDNI);
            this.groupBox3.Controls.Add(this.lblDNI);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1098, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DNI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtDate4Date);
            this.groupBox2.Controls.Add(this.cbDoctor);
            this.groupBox2.Controls.Add(this.cbSpeciality);
            this.groupBox2.Controls.Add(this.btnCreateDeate);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtWiegth);
            this.groupBox2.Controls.Add(this.txtHeigth);
            this.groupBox2.Controls.Add(this.Descripcion);
            this.groupBox2.Controls.Add(this.lblAltura);
            this.groupBox2.Controls.Add(this.lblPeso);
            this.groupBox2.Controls.Add(this.lblDateForDate);
            this.groupBox2.Controls.Add(this.lbldoctor);
            this.groupBox2.Controls.Add(this.lblEspecialidad);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1098, 384);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos nueva cita";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(56, 44);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(38, 63);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(66, 13);
            this.lblEspecialidad.TabIndex = 1;
            this.lblEspecialidad.Text = "especialidad";
            // 
            // lbldoctor
            // 
            this.lbldoctor.AutoSize = true;
            this.lbldoctor.Location = new System.Drawing.Point(38, 108);
            this.lbldoctor.Name = "lbldoctor";
            this.lbldoctor.Size = new System.Drawing.Size(37, 13);
            this.lbldoctor.TabIndex = 2;
            this.lbldoctor.Text = "doctor";
            // 
            // lblDateForDate
            // 
            this.lblDateForDate.AutoSize = true;
            this.lblDateForDate.Location = new System.Drawing.Point(38, 165);
            this.lblDateForDate.Name = "lblDateForDate";
            this.lblDateForDate.Size = new System.Drawing.Size(65, 13);
            this.lblDateForDate.TabIndex = 3;
            this.lblDateForDate.Text = "dia para cita";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(38, 221);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(38, 291);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(362, 63);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 6;
            this.Descripcion.Text = "Descripcion";
            // 
            // txtHeigth
            // 
            this.txtHeigth.Location = new System.Drawing.Point(136, 291);
            this.txtHeigth.Name = "txtHeigth";
            this.txtHeigth.Size = new System.Drawing.Size(100, 20);
            this.txtHeigth.TabIndex = 7;
            // 
            // txtWiegth
            // 
            this.txtWiegth.Location = new System.Drawing.Point(136, 221);
            this.txtWiegth.Name = "txtWiegth";
            this.txtWiegth.Size = new System.Drawing.Size(100, 20);
            this.txtWiegth.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(490, 63);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 9;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(136, 37);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(920, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCreateDeate
            // 
            this.btnCreateDeate.Location = new System.Drawing.Point(503, 257);
            this.btnCreateDeate.Name = "btnCreateDeate";
            this.btnCreateDeate.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDeate.TabIndex = 12;
            this.btnCreateDeate.Text = "Crear cita";
            this.btnCreateDeate.UseVisualStyleBackColor = true;
            // 
            // cbSpeciality
            // 
            this.cbSpeciality.FormattingEnabled = true;
            this.cbSpeciality.Location = new System.Drawing.Point(136, 61);
            this.cbSpeciality.Name = "cbSpeciality";
            this.cbSpeciality.Size = new System.Drawing.Size(121, 21);
            this.cbSpeciality.TabIndex = 13;
            // 
            // cbDoctor
            // 
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(136, 105);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(121, 21);
            this.cbDoctor.TabIndex = 14;
            // 
            // dtDate4Date
            // 
            this.dtDate4Date.Location = new System.Drawing.Point(136, 165);
            this.dtDate4Date.Name = "dtDate4Date";
            this.dtDate4Date.Size = new System.Drawing.Size(200, 20);
            this.dtDate4Date.TabIndex = 15;
            // 
            // frmPatientDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 756);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPatientDate";
            this.Text = "frmPatientDate";
            this.Load += new System.EventHandler(this.frmPatientDate_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDateBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergies;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.BindingSource clinicDateBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtDate4Date;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.ComboBox cbSpeciality;
        private System.Windows.Forms.Button btnCreateDeate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtWiegth;
        private System.Windows.Forms.TextBox txtHeigth;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblDateForDate;
        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lblEspecialidad;
    }
}