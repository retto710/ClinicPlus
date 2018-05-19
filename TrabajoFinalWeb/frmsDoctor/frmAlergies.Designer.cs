namespace TrabajoFinalWeb.frmsDoctor
{
    partial class frmAlergies
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.finalAppWebDataSet6 = new TrabajoFinalWeb.FinalAppWebDataSet6();
            this.clinicHistoryAlergieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicHistory_AlergieTableAdapter = new TrabajoFinalWeb.FinalAppWebDataSet6TableAdapters.clinicHistory_AlergieTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicHistoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergieIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAppWebDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicHistoryAlergieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clinicHistoryIdDataGridViewTextBoxColumn,
            this.alergieIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clinicHistoryAlergieBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // finalAppWebDataSet6
            // 
            this.finalAppWebDataSet6.DataSetName = "FinalAppWebDataSet6";
            this.finalAppWebDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicHistoryAlergieBindingSource
            // 
            this.clinicHistoryAlergieBindingSource.DataMember = "clinicHistory_Alergie";
            this.clinicHistoryAlergieBindingSource.DataSource = this.finalAppWebDataSet6;
            // 
            // clinicHistory_AlergieTableAdapter
            // 
            this.clinicHistory_AlergieTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clinicHistoryIdDataGridViewTextBoxColumn
            // 
            this.clinicHistoryIdDataGridViewTextBoxColumn.DataPropertyName = "clinicHistoryId";
            this.clinicHistoryIdDataGridViewTextBoxColumn.HeaderText = "clinicHistoryId";
            this.clinicHistoryIdDataGridViewTextBoxColumn.Name = "clinicHistoryIdDataGridViewTextBoxColumn";
            // 
            // alergieIdDataGridViewTextBoxColumn
            // 
            this.alergieIdDataGridViewTextBoxColumn.DataPropertyName = "AlergieId";
            this.alergieIdDataGridViewTextBoxColumn.HeaderText = "AlergieId";
            this.alergieIdDataGridViewTextBoxColumn.Name = "alergieIdDataGridViewTextBoxColumn";
            // 
            // frmAlergies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 149);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAlergies";
            this.Text = "frmAlergies";
            this.Load += new System.EventHandler(this.frmAlergies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAppWebDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicHistoryAlergieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FinalAppWebDataSet6 finalAppWebDataSet6;
        private System.Windows.Forms.BindingSource clinicHistoryAlergieBindingSource;
        private FinalAppWebDataSet6TableAdapters.clinicHistory_AlergieTableAdapter clinicHistory_AlergieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicHistoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergieIdDataGridViewTextBoxColumn;
    }
}