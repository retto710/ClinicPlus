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
            this.dateOfRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfAppointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicHistorytIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfAppointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLook4Doctors = new System.Windows.Forms.Button();
            this.dtDate4Date = new System.Windows.Forms.DateTimePicker();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.cbSpeciality = new System.Windows.Forms.ComboBox();
            this.btnCreateDeate = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtWiegth = new System.Windows.Forms.TextBox();
            this.txtHeigth = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblDateForDate = new System.Windows.Forms.Label();
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDateBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 676);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1647, 487);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista pacientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOfRequest,
            this.dateOfAppointment,
            this.description,
            this.status,
            this.weight,
            this.height,
            this.alergies,
            this.delete,
            this.idDataGridViewTextBoxColumn,
            this.clinicHistorytIdDataGridViewTextBoxColumn,
            this.doctorIdDataGridViewTextBoxColumn,
            this.nurseIdDataGridViewTextBoxColumn,
            this.dateOfRequestDataGridViewTextBoxColumn,
            this.dateOfAppointmentDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.alergiesDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.nurseDataGridViewTextBoxColumn,
            this.clinicHistoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clinicDateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1264, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // delete
            // 
            this.delete.HeaderText = "delete";
            this.delete.Name = "delete";
            this.delete.Text = "delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // clinicHistorytIdDataGridViewTextBoxColumn
            // 
            this.clinicHistorytIdDataGridViewTextBoxColumn.DataPropertyName = "clinicHistorytId";
            this.clinicHistorytIdDataGridViewTextBoxColumn.HeaderText = "clinicHistorytId";
            this.clinicHistorytIdDataGridViewTextBoxColumn.Name = "clinicHistorytIdDataGridViewTextBoxColumn";
            this.clinicHistorytIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // doctorIdDataGridViewTextBoxColumn
            // 
            this.doctorIdDataGridViewTextBoxColumn.DataPropertyName = "doctorId";
            this.doctorIdDataGridViewTextBoxColumn.HeaderText = "doctorId";
            this.doctorIdDataGridViewTextBoxColumn.Name = "doctorIdDataGridViewTextBoxColumn";
            this.doctorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nurseIdDataGridViewTextBoxColumn
            // 
            this.nurseIdDataGridViewTextBoxColumn.DataPropertyName = "nurseId";
            this.nurseIdDataGridViewTextBoxColumn.HeaderText = "nurseId";
            this.nurseIdDataGridViewTextBoxColumn.Name = "nurseIdDataGridViewTextBoxColumn";
            this.nurseIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateOfRequestDataGridViewTextBoxColumn
            // 
            this.dateOfRequestDataGridViewTextBoxColumn.DataPropertyName = "dateOfRequest";
            this.dateOfRequestDataGridViewTextBoxColumn.HeaderText = "dateOfRequest";
            this.dateOfRequestDataGridViewTextBoxColumn.Name = "dateOfRequestDataGridViewTextBoxColumn";
            this.dateOfRequestDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateOfAppointmentDataGridViewTextBoxColumn
            // 
            this.dateOfAppointmentDataGridViewTextBoxColumn.DataPropertyName = "dateOfAppointment";
            this.dateOfAppointmentDataGridViewTextBoxColumn.HeaderText = "dateOfAppointment";
            this.dateOfAppointmentDataGridViewTextBoxColumn.Name = "dateOfAppointmentDataGridViewTextBoxColumn";
            this.dateOfAppointmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Visible = false;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Visible = false;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.Visible = false;
            // 
            // alergiesDataGridViewTextBoxColumn
            // 
            this.alergiesDataGridViewTextBoxColumn.DataPropertyName = "alergies";
            this.alergiesDataGridViewTextBoxColumn.HeaderText = "alergies";
            this.alergiesDataGridViewTextBoxColumn.Name = "alergiesDataGridViewTextBoxColumn";
            this.alergiesDataGridViewTextBoxColumn.Visible = false;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nurseDataGridViewTextBoxColumn
            // 
            this.nurseDataGridViewTextBoxColumn.DataPropertyName = "nurse";
            this.nurseDataGridViewTextBoxColumn.HeaderText = "nurse";
            this.nurseDataGridViewTextBoxColumn.Name = "nurseDataGridViewTextBoxColumn";
            this.nurseDataGridViewTextBoxColumn.Visible = false;
            // 
            // clinicHistoryDataGridViewTextBoxColumn
            // 
            this.clinicHistoryDataGridViewTextBoxColumn.DataPropertyName = "clinicHistory";
            this.clinicHistoryDataGridViewTextBoxColumn.HeaderText = "clinicHistory";
            this.clinicHistoryDataGridViewTextBoxColumn.Name = "clinicHistoryDataGridViewTextBoxColumn";
            this.clinicHistoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // clinicDateBindingSource
            // 
            this.clinicDateBindingSource.DataSource = typeof(Entities.clinicDate);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtDNI);
            this.groupBox3.Controls.Add(this.lblDNI);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1647, 169);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DNI";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1380, 68);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(204, 68);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(148, 26);
            this.txtDNI.TabIndex = 10;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(84, 66);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(41, 20);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLook4Doctors);
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
            this.groupBox2.Location = new System.Drawing.Point(0, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1647, 497);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos nueva cita";
            // 
            // btnLook4Doctors
            // 
            this.btnLook4Doctors.Location = new System.Drawing.Point(456, 86);
            this.btnLook4Doctors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLook4Doctors.Name = "btnLook4Doctors";
            this.btnLook4Doctors.Size = new System.Drawing.Size(184, 35);
            this.btnLook4Doctors.TabIndex = 16;
            this.btnLook4Doctors.Text = "buscar doctores";
            this.btnLook4Doctors.UseVisualStyleBackColor = true;
            this.btnLook4Doctors.Click += new System.EventHandler(this.btnLook4Doctors_Click);
            // 
            // dtDate4Date
            // 
            this.dtDate4Date.Location = new System.Drawing.Point(204, 254);
            this.dtDate4Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtDate4Date.Name = "dtDate4Date";
            this.dtDate4Date.Size = new System.Drawing.Size(298, 26);
            this.dtDate4Date.TabIndex = 15;
            // 
            // cbDoctor
            // 
            this.cbDoctor.DisplayMember = "doctorNames";
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(204, 162);
            this.cbDoctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(180, 28);
            this.cbDoctor.TabIndex = 14;
            this.cbDoctor.ValueMember = "doctorId";
            // 
            // cbSpeciality
            // 
            this.cbSpeciality.DisplayMember = "description";
            this.cbSpeciality.FormattingEnabled = true;
            this.cbSpeciality.Location = new System.Drawing.Point(204, 94);
            this.cbSpeciality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSpeciality.Name = "cbSpeciality";
            this.cbSpeciality.Size = new System.Drawing.Size(180, 28);
            this.cbSpeciality.TabIndex = 13;
            this.cbSpeciality.ValueMember = "ID";
            // 
            // btnCreateDeate
            // 
            this.btnCreateDeate.Location = new System.Drawing.Point(528, 397);
            this.btnCreateDeate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateDeate.Name = "btnCreateDeate";
            this.btnCreateDeate.Size = new System.Drawing.Size(112, 35);
            this.btnCreateDeate.TabIndex = 12;
            this.btnCreateDeate.Text = "Crear cita";
            this.btnCreateDeate.UseVisualStyleBackColor = true;
            this.btnCreateDeate.Click += new System.EventHandler(this.btnCreateDeate_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(916, 86);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(148, 26);
            this.txtDescription.TabIndex = 9;
            // 
            // txtWiegth
            // 
            this.txtWiegth.Location = new System.Drawing.Point(204, 340);
            this.txtWiegth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWiegth.Name = "txtWiegth";
            this.txtWiegth.Size = new System.Drawing.Size(148, 26);
            this.txtWiegth.TabIndex = 8;
            // 
            // txtHeigth
            // 
            this.txtHeigth.Location = new System.Drawing.Point(204, 448);
            this.txtHeigth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHeigth.Name = "txtHeigth";
            this.txtHeigth.Size = new System.Drawing.Size(148, 26);
            this.txtHeigth.TabIndex = 7;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(711, 86);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(92, 20);
            this.Descripcion.TabIndex = 6;
            this.Descripcion.Text = "Descripcion";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(57, 448);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(57, 340);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(45, 20);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso";
            // 
            // lblDateForDate
            // 
            this.lblDateForDate.AutoSize = true;
            this.lblDateForDate.Location = new System.Drawing.Point(57, 254);
            this.lblDateForDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateForDate.Name = "lblDateForDate";
            this.lblDateForDate.Size = new System.Drawing.Size(95, 20);
            this.lblDateForDate.TabIndex = 3;
            this.lblDateForDate.Text = "dia para cita";
            // 
            // lbldoctor
            // 
            this.lbldoctor.AutoSize = true;
            this.lbldoctor.Location = new System.Drawing.Point(57, 166);
            this.lbldoctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldoctor.Name = "lbldoctor";
            this.lbldoctor.Size = new System.Drawing.Size(54, 20);
            this.lbldoctor.TabIndex = 2;
            this.lbldoctor.Text = "doctor";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(57, 97);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(97, 20);
            this.lblEspecialidad.TabIndex = 1;
            this.lblEspecialidad.Text = "especialidad";
            this.lblEspecialidad.Click += new System.EventHandler(this.lblEspecialidad_Click);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(Entities.patient);
            // 
            // frmPatientDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 1050);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPatientDate";
            this.Text = "frmPatientDate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPatientDate_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDateBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource patientBindingSource;
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
        private System.Windows.Forms.Button btnLook4Doctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergies;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicHistorytIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfAppointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
    }
}