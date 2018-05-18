using buisnessLogic.ClinicHistory;
using buisnessLogic.Doctor;
using buisnessLogic.PacientAllergy;
using buisnessLogic.Patient;
using buisnessLogic.Person;
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

namespace TrabajoFinalWeb.frmsNurses
{
    public partial class frmPatientDate : Form
    {
        IPersonService personServ = new PersonService();
        IPacientAllergyService clinic_allergyService = new PacientAllergyService();
        IPatientService patientServ = new PatientService();
        IDoctorService docService = new DoctorService();
        IClinicHistoryService clinicHistoryService = new ClinicHistoryService();

        public frmPatientDate()
        {
            InitializeComponent();
        }


        private void enableItemsForCreation(bool enable)
        {
            btnCreateDeate.Enabled = enable;
            txtHeigth.Enabled = enable;
            txtWiegth.Enabled = enable;
            txtDescription.Enabled = enable;
            dtDate4Date.Enabled = enable;
            cbDoctor.Enabled = enable;
            cbSpeciality.Enabled = enable;
        }

        private void frmPatientDate_Load(object sender, EventArgs e)
        {
            enableItemsForCreation(false);
        }

        //BUSCA DNI 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //BUscar persona por DNI
            int dni = Convert.ToInt32(txtDNI.Text);
            person person =  personServ.GetPersonByDni(dni);




        }
    }
}
