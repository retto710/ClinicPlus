using buisnessLogic.Allergy;
using buisnessLogic.ClinicHistory;
using buisnessLogic.PacientAllergy;
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
    public partial class frmAlergies : Form
    {
        int idPClinicHsitory; 
        IPacientAllergyService clinic_allergyService = new PacientAllergyService();
        public frmAlergies(int id)
        {
            InitializeComponent();
            idPClinicHsitory = id;
        }
        private void load()
        {
            List<clinicHistory_Alergie> alergies = clinic_allergyService.GetClinicHistory_Allergies(idPClinicHsitory);
            dataGridView1.DataSource = alergies;
        }

        private void frmAlergies_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalAppWebDataSet6.clinicHistory_Alergie' Puede moverla o quitarla según sea necesario.
            this.clinicHistory_AlergieTableAdapter.Fill(this.finalAppWebDataSet6.clinicHistory_Alergie);
            load();
        }
    }
}
