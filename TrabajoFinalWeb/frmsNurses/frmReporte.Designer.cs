namespace TrabajoFinalWeb.frmsNurses
{
    partial class frmReporte
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
            this.lblInfoBtn = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.btnDateByDoctor = new System.Windows.Forms.Button();
            this.btnDatesTrue = new System.Windows.Forms.Button();
            this.btnDatesFalse = new System.Windows.Forms.Button();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clinicDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfAppointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInfoBtn);
            this.groupBox1.Controls.Add(this.cbDoctor);
            this.groupBox1.Controls.Add(this.btnDateByDoctor);
            this.groupBox1.Controls.Add(this.btnDatesTrue);
            this.groupBox1.Controls.Add(this.btnDatesFalse);
            this.groupBox1.Controls.Add(this.lblOpciones);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes";
            // 
            // lblInfoBtn
            // 
            this.lblInfoBtn.AutoSize = true;
            this.lblInfoBtn.Location = new System.Drawing.Point(569, 13);
            this.lblInfoBtn.Name = "lblInfoBtn";
            this.lblInfoBtn.Size = new System.Drawing.Size(81, 13);
            this.lblInfoBtn.TabIndex = 6;
            this.lblInfoBtn.Text = "Citas por doctor";
            // 
            // cbDoctor
            // 
            this.cbDoctor.DisplayMember = "id";
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(569, 35);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(121, 21);
            this.cbDoctor.TabIndex = 5;
            this.cbDoctor.ValueMember = "id";
            // 
            // btnDateByDoctor
            // 
            this.btnDateByDoctor.Location = new System.Drawing.Point(705, 33);
            this.btnDateByDoctor.Name = "btnDateByDoctor";
            this.btnDateByDoctor.Size = new System.Drawing.Size(123, 23);
            this.btnDateByDoctor.TabIndex = 4;
            this.btnDateByDoctor.Text = "citas de doctor";
            this.btnDateByDoctor.UseVisualStyleBackColor = true;
            this.btnDateByDoctor.Click += new System.EventHandler(this.btnDateByDoctor_Click);
            // 
            // btnDatesTrue
            // 
            this.btnDatesTrue.Location = new System.Drawing.Point(358, 33);
            this.btnDatesTrue.Name = "btnDatesTrue";
            this.btnDatesTrue.Size = new System.Drawing.Size(123, 23);
            this.btnDatesTrue.TabIndex = 3;
            this.btnDatesTrue.Text = "citas apobadas";
            this.btnDatesTrue.UseVisualStyleBackColor = true;
            this.btnDatesTrue.Click += new System.EventHandler(this.btnDatesTrue_Click);
            // 
            // btnDatesFalse
            // 
            this.btnDatesFalse.Location = new System.Drawing.Point(168, 33);
            this.btnDatesFalse.Name = "btnDatesFalse";
            this.btnDatesFalse.Size = new System.Drawing.Size(123, 23);
            this.btnDatesFalse.TabIndex = 2;
            this.btnDatesFalse.Text = "citas sin aprobar";
            this.btnDatesFalse.UseVisualStyleBackColor = true;
            this.btnDatesFalse.Click += new System.EventHandler(this.btnDatesFalse_Click);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(13, 33);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(124, 13);
            this.lblOpciones.TabIndex = 0;
            this.lblOpciones.Text = "Especialidad de doctor : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 282);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de citas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOfRequestDataGridViewTextBoxColumn,
            this.dateOfAppointmentDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.alergiesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clinicDateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 252);
            this.dataGridView1.TabIndex = 1;
            // 
            // clinicDateBindingSource
            // 
            this.clinicDateBindingSource.DataSource = typeof(Entities.clinicDate);
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
            // alergiesDataGridViewTextBoxColumn
            // 
            this.alergiesDataGridViewTextBoxColumn.DataPropertyName = "alergies";
            this.alergiesDataGridViewTextBoxColumn.HeaderText = "alergies";
            this.alergiesDataGridViewTextBoxColumn.Name = "alergiesDataGridViewTextBoxColumn";
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 382);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReporte";
            this.Text = "frmCita";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDatesFalse;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnDatesTrue;
        private System.Windows.Forms.BindingSource clinicDateBindingSource;
        private System.Windows.Forms.Label lblInfoBtn;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.Button btnDateByDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfAppointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergiesDataGridViewTextBoxColumn;
    }
}