﻿namespace TrabajoFinalWeb
{
    partial class frmDoctorSpeciality
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericDNI = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSpeciality = new System.Windows.Forms.Label();
            this.cmbSpeciality = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorspecialityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalAppWebDataSet4 = new TrabajoFinalWeb.FinalAppWebDataSet4();
            this.finalAppWebDataSet1 = new TrabajoFinalWeb.FinalAppWebDataSet1();
            this.specialityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialityTableAdapter = new TrabajoFinalWeb.FinalAppWebDataSet1TableAdapters.specialityTableAdapter();
            this.doctor_specialityTableAdapter = new TrabajoFinalWeb.FinalAppWebDataSet4TableAdapters.doctor_specialityTableAdapter();
            this.specialityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorspecialityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAppWebDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAppWebDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericDNI, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSpeciality, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbSpeciality, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 205);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type doctor dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // numericDNI
            // 
            this.numericDNI.Location = new System.Drawing.Point(268, 27);
            this.numericDNI.Margin = new System.Windows.Forms.Padding(2);
            this.numericDNI.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericDNI.Name = "numericDNI";
            this.numericDNI.Size = new System.Drawing.Size(247, 20);
            this.numericDNI.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(2, 52);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 19);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(268, 77);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(268, 102);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(248, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // lblSpeciality
            // 
            this.lblSpeciality.AutoSize = true;
            this.lblSpeciality.Location = new System.Drawing.Point(2, 150);
            this.lblSpeciality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeciality.Name = "lblSpeciality";
            this.lblSpeciality.Size = new System.Drawing.Size(52, 13);
            this.lblSpeciality.TabIndex = 8;
            this.lblSpeciality.Text = "Speciality";
            // 
            // cmbSpeciality
            // 
            this.cmbSpeciality.DisplayMember = "description";
            this.cmbSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpeciality.FormattingEnabled = true;
            this.cmbSpeciality.Location = new System.Drawing.Point(268, 152);
            this.cmbSpeciality.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSpeciality.Name = "cmbSpeciality";
            this.cmbSpeciality.Size = new System.Drawing.Size(248, 21);
            this.cmbSpeciality.TabIndex = 9;
            this.cmbSpeciality.ValueMember = "id";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(2, 177);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specialityIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorspecialityBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 205);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(533, 162);
            this.dataGridView1.TabIndex = 1;
            // 
            // doctorspecialityBindingSource
            // 
            this.doctorspecialityBindingSource.DataMember = "doctor_speciality";
            this.doctorspecialityBindingSource.DataSource = this.finalAppWebDataSet4;
            // 
            // finalAppWebDataSet4
            // 
            this.finalAppWebDataSet4.DataSetName = "FinalAppWebDataSet4";
            this.finalAppWebDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finalAppWebDataSet1
            // 
            this.finalAppWebDataSet1.DataSetName = "FinalAppWebDataSet1";
            this.finalAppWebDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialityBindingSource
            // 
            this.specialityBindingSource.DataMember = "speciality";
            this.specialityBindingSource.DataSource = this.finalAppWebDataSet1;
            // 
            // specialityTableAdapter
            // 
            this.specialityTableAdapter.ClearBeforeFill = true;
            // 
            // doctor_specialityTableAdapter
            // 
            this.doctor_specialityTableAdapter.ClearBeforeFill = true;
            // 
            // specialityIdDataGridViewTextBoxColumn
            // 
            this.specialityIdDataGridViewTextBoxColumn.DataPropertyName = "specialityName";
            this.specialityIdDataGridViewTextBoxColumn.HeaderText = "specialityId";
            this.specialityIdDataGridViewTextBoxColumn.Name = "specialityIdDataGridViewTextBoxColumn";
            // 
            // frmDoctorSpeciality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 367);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDoctorSpeciality";
            this.Text = "frmDoctorSpeciality";
            this.Load += new System.EventHandler(this.frmDoctorSpeciality_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorspecialityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAppWebDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAppWebDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericDNI;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSpeciality;
        private System.Windows.Forms.ComboBox cmbSpeciality;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FinalAppWebDataSet1 finalAppWebDataSet1;
        private System.Windows.Forms.BindingSource specialityBindingSource;
        private FinalAppWebDataSet1TableAdapters.specialityTableAdapter specialityTableAdapter;
        private FinalAppWebDataSet4 finalAppWebDataSet4;
        private System.Windows.Forms.BindingSource doctorspecialityBindingSource;
        private FinalAppWebDataSet4TableAdapters.doctor_specialityTableAdapter doctor_specialityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityIdDataGridViewTextBoxColumn;
    }
}