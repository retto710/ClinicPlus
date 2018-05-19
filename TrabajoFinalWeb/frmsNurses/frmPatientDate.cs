using buisnessLogic.ClinicHistory;
using buisnessLogic.DoctorSpeciality;
using buisnessLogic.PacientAllergy;
using buisnessLogic.Patient;
using buisnessLogic.Person;
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
using buisnessLogic.Speciality;

namespace TrabajoFinalWeb.frmsNurses
{
    public partial class frmPatientDate : Form
    {
        IPersonService personServ = new PersonService();
        IPacientAllergyService clinic_allergyService = new PacientAllergyService();
        IPatientService patientServ = new PatientService();
        IDoctorSpecialityService docSpecialityService = new DoctorSpecialityService();
        IClinicHistoryService clinicHistoryService = new ClinicHistoryService();
        IClinicDateService clinicDateService = new ClinicDateService();
        ISpecialityService SpecialityService = new SpecialityService();

        int IDclinicHistoy;
        String allergy;
        int IDnurseLogOn;

        public frmPatientDate(int idNurse)
        {
            InitializeComponent();
            IDnurseLogOn = idNurse;
        }


        private void load() {
            List<clinicDate> citas = clinicDateService.GetClinicDatesByClinicHistory(IDclinicHistoy);
            dataGridView1.DataSource = citas;
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

            List<speciality> specialities = SpecialityService.GetSpecialities();
            cbSpeciality.DataSource = specialities;
            cbSpeciality.SelectedIndex = 0;
        }

        //BUSCA DNI 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //BUscar persona por DNI
            int dni = Convert.ToInt32(txtDNI.Text);
            person person =  personServ.GetPersonByDni(dni);

            //Validaicon de existencia de persona
            if (person == null)
            {
                MessageBox.Show("La persona " + dni + " no se encutra registrada en el sistema");
            }
            else
            {
                patient patient = patientServ.GetPatientByPersonId(person.ID);
                //validaicon es un paciente
                if (patient == null)
                {
                    MessageBox.Show("EL usuairo no es un paciente");
                }
                else {
                    clinicHistory clinicHistory = clinicHistoryService.GetClinicHistoryByPatientId(patient.id);
                    //validaicon es un paciente
                    if (clinicHistory == null)
                    {
                        MessageBox.Show("EL paciente no tienie un historial clinico ");
                    }
                    else {
                        allergy = clinicHistory.alergies;
                        IDclinicHistoy = clinicHistory.id;
                        cbSpeciality.Enabled = true;
                        txtHeigth.Text = clinicHistory.height.ToString();
                        txtWiegth.Text = clinicHistory.weight.ToString();
                        this.load();
                    }
                }

            }
        }

        private void btnCreateDeate_Click(object sender, EventArgs e)
        {
            clinicDate clinicDate = new clinicDate();
            clinicDate.clinicHistorytId = IDclinicHistoy;
            clinicDate.doctorId = Convert.ToInt32(cbDoctor.SelectedValue); 
            clinicDate.nurseId = IDnurseLogOn; 
            clinicDate.dateOfRequest = DateTime.Today.Date;
            clinicDate.dateOfAppointment = dtDate4Date.Value;
            clinicDate.description = txtDescription.Text;
            clinicDate.status = false;
            clinicDate.weight = Convert.ToDecimal(txtWiegth.Text);
            clinicDate.height = Convert.ToDecimal(txtHeigth.Text);
            clinicDate.alergies = allergy;

            clinicDateService.CreateClinicDate(clinicDate);
        }

        private void btnLook4Doctors_Click(object sender, EventArgs e)
        {
            int idSpeciality = Convert.ToInt32(cbSpeciality.SelectedValue);

            List<doctor_speciality> doctors = docSpecialityService.GetDoctorsBySpeciality(idSpeciality);
            cbDoctor.DataSource = doctors;
            cbDoctor.SelectedIndex = 0;
            enableItemsForCreation(true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.
                Columns[e.ColumnIndex].
                HeaderText.
                ToLower() == "delete")
            {
                if (MessageBox.Show
                    ("Are you sure you want to delete this date?",
                    "Confirm",
                    MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    clinicDate objCustomer =
                        (clinicDate)dataGridView1.
                        Rows[e.RowIndex].
                        DataBoundItem;
                    this.clinicDateService.deleteCLnicDate(objCustomer);
                    this.load();
                }
            }

        }
    }
}
