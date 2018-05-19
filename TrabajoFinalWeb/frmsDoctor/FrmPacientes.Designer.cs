namespace TrabajoFinalWeb.frmsDoctor
{
    partial class FrmPacientes
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
            this.finalAppWebDataSet5 = new TrabajoFinalWeb.FinalAppWebDataSet5();
            this.clinicDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDateTableAdapter = new TrabajoFinalWeb.FinalAppWebDataSet5TableAdapters.clinicDateTableAdapter();
            this.clinicHistorytIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfAppointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alergies = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAppWebDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Citas planificadas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clinicHistorytIdDataGridViewTextBoxColumn,
            this.doctorIdDataGridViewTextBoxColumn,
            this.nurseIdDataGridViewTextBoxColumn,
            this.dateOfRequestDataGridViewTextBoxColumn,
            this.dateOfAppointmentDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.Alergies});
            this.dataGridView1.DataSource = this.clinicDateBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(959, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // finalAppWebDataSet5
            // 
            this.finalAppWebDataSet5.DataSetName = "FinalAppWebDataSet5";
            this.finalAppWebDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicDateBindingSource
            // 
            this.clinicDateBindingSource.DataMember = "clinicDate";
            this.clinicDateBindingSource.DataSource = this.finalAppWebDataSet5;
            // 
            // clinicDateTableAdapter
            // 
            this.clinicDateTableAdapter.ClearBeforeFill = true;
            // 
            // clinicHistorytIdDataGridViewTextBoxColumn
            // 
            this.clinicHistorytIdDataGridViewTextBoxColumn.DataPropertyName = "clinicHistorytId";
            this.clinicHistorytIdDataGridViewTextBoxColumn.HeaderText = "clinicHistorytId";
            this.clinicHistorytIdDataGridViewTextBoxColumn.Name = "clinicHistorytIdDataGridViewTextBoxColumn";
            // 
            // doctorIdDataGridViewTextBoxColumn
            // 
            this.doctorIdDataGridViewTextBoxColumn.DataPropertyName = "doctorId";
            this.doctorIdDataGridViewTextBoxColumn.HeaderText = "doctorId";
            this.doctorIdDataGridViewTextBoxColumn.Name = "doctorIdDataGridViewTextBoxColumn";
            // 
            // nurseIdDataGridViewTextBoxColumn
            // 
            this.nurseIdDataGridViewTextBoxColumn.DataPropertyName = "nurseId";
            this.nurseIdDataGridViewTextBoxColumn.HeaderText = "nurseId";
            this.nurseIdDataGridViewTextBoxColumn.Name = "nurseIdDataGridViewTextBoxColumn";
            // 
            // dateOfRequestDataGridViewTextBoxColumn
            // 
            this.dateOfRequestDataGridViewTextBoxColumn.DataPropertyName = "dateOfRequest";
            this.dateOfRequestDataGridViewTextBoxColumn.HeaderText = "dateOfRequest";
            this.dateOfRequestDataGridViewTextBoxColumn.Name = "dateOfRequestDataGridViewTextBoxColumn";
            // 
            // dateOfAppointmentDataGridViewTextBoxColumn
            // 
            this.dateOfAppointmentDataGridViewTextBoxColumn.DataPropertyName = "dateOfAppointment";
            this.dateOfAppointmentDataGridViewTextBoxColumn.HeaderText = "dateOfAppointment";
            this.dateOfAppointmentDataGridViewTextBoxColumn.Name = "dateOfAppointmentDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // Alergies
            // 
            this.Alergies.HeaderText = "View Alergies";
            this.Alergies.Name = "Alergies";
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 588);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.FrmPacientes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAppWebDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FinalAppWebDataSet5 finalAppWebDataSet5;
        private System.Windows.Forms.BindingSource clinicDateBindingSource;
        private FinalAppWebDataSet5TableAdapters.clinicDateTableAdapter clinicDateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicHistorytIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfAppointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Alergies;
    }
}