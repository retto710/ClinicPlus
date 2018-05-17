using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using buisnessLogic.Speciality;
using Entities;
namespace TrabajoFinalWeb
{
    public partial class frmAddSpeciality : Form
    {
        public frmAddSpeciality()
        {
            InitializeComponent();
        }

        private void FrmAddSpeciality_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalAppWebDataSet3.doctor_speciality' table. You can move, or remove it, as needed.
            this.doctor_specialityTableAdapter.Fill(this.finalAppWebDataSet3.doctor_speciality);
            // TODO: This line of code loads data into the 'finalAppWebDataSet.speciality' table. You can move, or remove it, as needed.
            this.specialityTableAdapter.Fill(this.finalAppWebDataSet.speciality);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ISpecialityService specialityService = new SpecialityService();
            String description= txtSpeciality.Text.ToString().Trim();
            speciality objSpeciality = new speciality();
            objSpeciality.description = description;
            if(description.Length==0)
            {
                MessageBox.Show("Type an speciality");
            }
            else if (specialityService.GetSpecialityByDescription(description)!=null)
            {
                MessageBox.Show("This speciality is already saved. Try another");
            }
            else
            {
                specialityService.CreateSpeciality(objSpeciality);
                MessageBox.Show("Speciality saved");
            }

            this.specialityTableAdapter.Fill(this.finalAppWebDataSet.speciality);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.
               Columns[e.ColumnIndex].
               HeaderText.
               ToLower() == "delete")
            {
                if (MessageBox.Show
                    ("Are you sure you want to delete this record?",
                    "Confirm",
                    MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    int specialityId =Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    
                    ISpecialityService specialityService = new SpecialityService();
                    specialityService.DeleteSpeciality(specialityId);
                    this.specialityTableAdapter.Fill(this.finalAppWebDataSet.speciality);
                }
            }
        }
    }
}
