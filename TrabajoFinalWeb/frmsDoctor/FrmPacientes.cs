using buisnessLogic.clinicDatee;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalWeb.frmsDoctor
{
    public partial class FrmPacientes : Form
    {
        IClinicDateService clinicDateService = new ClinicDateService();
        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalAppWebDataSet5.clinicDate' Puede moverla o quitarla según sea necesario.
            this.clinicDateTableAdapter.Fill(this.finalAppWebDataSet5.clinicDate);
            load();
        }
        private void load()
        {
            frmDoc frm = (frmDoc) this.MdiParent;
            int doctorID = frm.doctorid;
            List<clinicDate> citas = clinicDateService.GetClinicDatesByDoctorAndStatus(doctorID,false);
            dataGridView1.DataSource = citas;
            List<clinicDate> citas2= clinicDateService.GetClinicDatesByDoctorAndStatus(doctorID, true);
            dataGridView2.DataSource = citas2;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.
               Columns[e.ColumnIndex].
               HeaderText.
               ToLower() == "confirm")
            {
                if (MessageBox.Show
                    ("Confirm?",
                    "Confirm",
                    MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    clinicDate objCustomer =
                        (clinicDate)dataGridView1.
                        Rows[e.RowIndex].
                        DataBoundItem;
                    this.SendToBack();
                }
            }
            else if(dataGridView1.
               Columns[e.ColumnIndex].
               HeaderText.
               ToLower() == "view alergies")
            {
                clinicDate objClinicdate =
                     (clinicDate)dataGridView1.
                     Rows[e.RowIndex].
                     DataBoundItem;
                frmAlergies frm = new frmAlergies(objClinicdate.clinicHistorytId);
                frm.Show();
            }
        }
    }
}
