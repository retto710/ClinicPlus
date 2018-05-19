using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using buisnessLogic.Doctor;
using buisnessLogic.Nurse;
using buisnessLogic.Person;
using buisnessLogic.User;
using buisnessLogic.Admin;
using buisnessLogic.Patient;
using buisnessLogic.Allergy;
using Entities;
using buisnessLogic.ClinicHistory;
using buisnessLogic.PacientAllergy;

namespace TrabajoFinalWeb.frmsNurses
{
      public partial class frmRandU : Form
    {
        IPersonService personServ = new PersonService();
        IPacientAllergyService clinic_allergyService = new PacientAllergyService();
        IPatientService patientServ = new PatientService();
        IUserService userService = new UserService();
        IDoctorService docService = new DoctorService();
        INurseService nurService = new NurseService();
        IAdminService adminService = new AdminService();
        IClinicHistoryService clinicHistoryService = new ClinicHistoryService();
        IAllergySerivce AllergyService = new AllergyService();
        bool isANewPerson;
        bool isANewHistory;
        string username;
        int idPatient;
        int idPClinicHsitory;
        int DNI;
        person objPerson = new person();
        user objUser= new user();
        private void enableTextbox(bool enable)
        {
            txtName.Enabled = enable;
            txtLastName.Enabled = enable;
            txtDNI2.Enabled = enable;
            txtDNI2.Text = txtDNI.Text;
            cmbGender.Enabled = enable;
            numericAge.Enabled = enable;
            numericPhoneNumber.Enabled = enable;
            dateOfBirth.Enabled = enable;
            txtEmail.Enabled = enable;
            txtAddress.Enabled = enable;
            txtNationality.Enabled = enable;

        }
        private void enableTextboxUpdate(bool enable)
        {
            txtName.Enabled = enable;
            txtLastName.Enabled = enable;
            txtDNI2.Enabled = enable;
            txtDNI2.Text = txtDNI.Text;
            cmbGender.Enabled = enable;
            numericAge.Enabled = enable;
            numericPhoneNumber.Enabled = enable;
            dateOfBirth.Enabled = enable;
            txtEmail.Enabled = enable;
            txtAddress.Enabled = enable;
            txtNationality.Enabled = enable;
        }
        private void enableTextboxCreateUpdateClinicHistory(bool enable) {
            btnCreateClinicHistory.Enabled = enable;
            btnAddAlergi.Enabled = enable;
            ckAlergias.Enabled = enable;
            txtDescription.Enabled = enable;
            txtHeigth.Enabled = enable;
            txtWeigth.Enabled = enable;
        }
        private void initialize()
        {
            txtName.Text = "";
            txtLastName.Text = "";
            txtDNI2.Text = txtDNI.Text;
            numericAge.Value = 0;
            numericPhoneNumber.Value = 0;
            dateOfBirth.Value = DateTime.Today;
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtNationality.Text = "";

            txtDateOfCreation.Enabled = false;
        }
        public frmRandU()
        {
            InitializeComponent();
            dateOfBirth.MaxDate = DateTime.Today;
        }

        private void load() {
            List<clinicHistory_Alergie> alergies = clinic_allergyService.GetClinicHistory_Allergies(idPClinicHsitory);
            dataGridView1.DataSource = alergies;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text.ToString().Length!=8)
            {
                MessageBox.Show("Invalid DNI. Try Again");
            }
            else
            {
                //DNI validos

                int dni = Int32.Parse(txtDNI.Text.ToString());
                DNI = dni;
                //Guradmos persona

                objPerson = personServ.GetPersonByDni(dni);
                
                //SI existe (Perosna ya registrasa)(Update)
                if (objPerson != null)
                {
                    MessageBox.Show("Person: "+objPerson.name + " "+ objPerson.lastName);

                    btnAdd.Text = "Update";
                    //Obtengo el usuario
                    String name = objPerson.name;

                    char firstletter = name[0];
                    int dniValue=Decimal.ToInt32(objPerson.DNI);
                    username = firstletter + dniValue.ToString();
                    //guardamos usuario
                    objUser = userService.GetUserByUsername(username);
                    enableTextboxUpdate(true);

                    isANewPerson = false;

                    //Coloco los datos en los textboxs
                    txtName.Text = objPerson.name;
                    txtLastName.Text = objPerson.lastName;
                    txtDNI2.Text = objPerson.DNI.ToString();
                    if (objPerson.gender.Equals("Male"))
                    {
                        cmbGender.SelectedIndex = 1;
                    }else{
                        cmbGender.SelectedIndex = 0;
                    }
                    numericAge.Value = objPerson.age;
                    numericPhoneNumber.Value = objPerson.phone;
                    dateOfBirth.Text = objPerson.dateOfBith.ToString();
                    txtEmail.Text = objPerson.email;
                    txtAddress.Text = objPerson.address;
                    txtNationality.Text = objPerson.nationality;

                    //Para ver si ya tinte i¿un clinic History

                    patient objPatient = patientServ.GetPatientByPersonId(objPerson.ID);
                    clinicHistory objClinicHistory = clinicHistoryService.GetClinicHistoryByPatientId(objPatient.id);
                    objClinicHistory = clinicHistoryService.GetClinicHistoryByPatientId(objPatient.id);
                    idPatient = objPatient.id;

                    if (objPatient == null )
                    {
                        MessageBox.Show("No es un paciente");

                        enableTextboxCreateUpdateClinicHistory(false);
                        btnAddAlergi.Enabled = false;
                    }
                    else
                    {

                        if (objClinicHistory == null)
                        {
                            enableTextboxCreateUpdateClinicHistory(true);
                            btnCreateClinicHistory.Text = "create clinic history";
                            MessageBox.Show("Person: " + objPerson.name + " " + objPerson.lastName + " no cuenta con una historia clinica");
                            isANewHistory = true;
                            txtDateOfCreation.Text = DateTime.Today.ToString();
                            btnAddAlergi.Enabled = true;
                        }
                        else
                        {
                            idPClinicHsitory = objClinicHistory.id;

                            this.load();
                            btnCreateClinicHistory.Text = "update clinic history";
                            MessageBox.Show("Person: " + objPerson.name + " " + objPerson.lastName + " cuenta con una historia clinica");
                            isANewHistory = false;
                            txtDateOfCreation.Text = objClinicHistory.date.ToString();
                            txtDescription.Text = objClinicHistory.description;
                            txtHeigth.Text = objClinicHistory.height.ToString();
                            txtWeigth.Text = objClinicHistory.weight.ToString();
                            enableTextboxCreateUpdateClinicHistory(true);
                            if (objClinicHistory.alergies.Equals("si"))
                            {
                                ckAlergias.Checked = true;
                                btnAddAlergi.Enabled = true;
                            }
                            else
                            {
                                ckAlergias.Checked = false;
                                btnAddAlergi.Enabled = false;
                            }

                        }
                    }
                }
                else
                {
                    isANewPerson = true;
                    MessageBox.Show("New Person");
                    enableTextbox(true);
                    initialize();
                }
            }
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String name = objPerson.name;
            char firstletter = name[0];
            int dniValue = Decimal.ToInt32(objPerson.DNI);
            username = firstletter + dniValue.ToString();
            if (isANewPerson)
            {
                objPerson = new person();
                objPerson.name = txtName.Text.ToString();
                objPerson.lastName = txtLastName.Text.ToString();
                objPerson.age = Decimal.ToInt32(numericAge.Value);
                objPerson.email = txtEmail.Text.ToString();
                objPerson.address = txtAddress.Text.ToString();
                objPerson.phone = Decimal.ToInt32(numericPhoneNumber.Value);
                objPerson.nationality = txtNationality.Text.ToString();
                objPerson.DNI = Decimal.Parse(txtDNI2.Text.ToString());
                objPerson.gender = cmbGender.SelectedItem.ToString();
                objPerson.dateOfBith = dateOfBirth.Value.Date;

                personServ.CreatePerson(objPerson);

                enableTextboxCreateUpdateClinicHistory(true);
            }
            else {
                //No es una perosna nueva esto es poara el UPDATE
                if (!isANewPerson)
                {
                    objPerson = personServ.GetPersonByDni(DNI);
                    
                    objPerson.name = txtName.Text.ToString();
                    objPerson.lastName = txtLastName.Text.ToString();
                    objPerson.age = Decimal.ToInt32(numericAge.Value);
                    objPerson.email = txtEmail.Text.ToString();
                    objPerson.address = txtAddress.Text.ToString();
                    objPerson.phone = Decimal.ToInt32(numericPhoneNumber.Value);
                    objPerson.nationality = txtNationality.Text.ToString();
                    objPerson.DNI = Decimal.Parse(txtDNI2.Text.ToString());
                    objPerson.gender = cmbGender.SelectedItem.ToString();
                    objPerson.dateOfBith = dateOfBirth.Value.Date;

                    personServ.UpdatePerson(objPerson);
                }
            }

            //Verifico si tiene usuario y si no es estoy creando paciente
            if (userService.GetUserByUsername(username) == null)
            {
                objUser = new user();
                objUser.username = username;
                objUser.email = txtEmail.Text.ToString();
                objUser.password = "default1";
                userService.CreateUser(objUser);
            }
                patient objPatient = new patient();
                //Buscamos el usuario
                objUser = userService.GetUserByUsername(username);
                //Buscamos la persona
                objPerson = personServ.GetPersonByDni(dniValue);
                //Lo asignamos al admin
                objPatient = new patient();
                objPatient.personId = objPerson.ID;
                //lo creamos
                if (patientServ.GetPatientByPersonId(objPatient.personId) != null)
                {
                    MessageBox.Show("Cambios registrados");
                }
                else
                {
                    patientServ.CreatePatient(objPatient);
                    idPatient = objPatient.id;
                    MessageBox.Show("New Patient Saved");
                    enableTextbox(false);
                    initialize();
                }
                
        }

        private void btnCreateClinicHistory_Click(object sender, EventArgs e)
        {
            if (isANewHistory)
            {
                clinicHistory objClinicHistory = new clinicHistory();
                objClinicHistory.patientId = idPatient;
                objClinicHistory.weight = Convert.ToDecimal(txtWeigth.Text);
                objClinicHistory.height = Convert.ToDecimal(txtHeigth.Text);
                objClinicHistory.date = DateTime.Today.Date;
                objClinicHistory.description = txtDescription.Text.ToString();
                if (ckAlergias.Checked) { objClinicHistory.alergies = "si"; } else { objClinicHistory.alergies = "no"; }

                clinicHistoryService.CreateClinicHistory(objClinicHistory);
                idPClinicHsitory = objClinicHistory.id;

                this.load();
                MessageBox.Show("Clinic History created");
                enableTextboxCreateUpdateClinicHistory(true);
            }
            else {
                if (!isANewHistory)
                {
                    //falta
                    clinicHistory objClinicHistory = clinicHistoryService.GetClinicHistoryByPatientId(idPatient);
                    idPClinicHsitory = objClinicHistory.id;
                    objClinicHistory.date = DateTime.Today;
                    objClinicHistory.weight = Convert.ToDecimal(txtWeigth.Text);
                    objClinicHistory.height = Convert.ToDecimal(txtHeigth.Text);
                    objClinicHistory.description = txtDateOfCreation.Text.ToString();
                    if (ckAlergias.Checked) { objClinicHistory.alergies = "si"; } else { objClinicHistory.alergies = "no"; }

                    clinicHistoryService.UpdateClinicHistory(objClinicHistory);
                    MessageBox.Show("Clinic History updated");
                }
            }
            
        }

        private void btnAddAlergi_Click(object sender, EventArgs e)
        {
            //creaicon historia clincia - alergia
            clinicHistory_Alergie clinicHsitoryAlergy = new clinicHistory_Alergie();
            clinicHsitoryAlergy.AlergieId = Convert.ToInt32(cbAllergies.SelectedValue);
            clinicHsitoryAlergy.clinicHistoryId = idPClinicHsitory;
            clinic_allergyService.CreateClinicHistory_Allergy(clinicHsitoryAlergy);
            this.load();
        }


        private void frmRandU_Load(object sender, EventArgs e)
        {
            List<alergy> alergiasDisponibles = AllergyService.getAlergies();
            
            cbAllergies.DataSource = alergiasDisponibles;
            cbAllergies.SelectedIndex = 0;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.
                Columns[e.ColumnIndex].
                HeaderText.
                ToLower() == "delete")
            {
                if (MessageBox.Show
                    ("Are you sure you want to delete this allergy?",
                    "Confirm",
                    MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    //int customerId =
                    //    Convert.ToInt32(dgvCustomers.
                    //    Rows[e.RowIndex].
                    //    Cells[0].
                    //    Value);
                    clinicHistory_Alergie objCustomer =
                        (clinicHistory_Alergie)dataGridView1.
                        Rows[e.RowIndex].
                        DataBoundItem;
                    this.clinic_allergyService.deleteClinicHistoryAllergy(objCustomer.id);
                    this.load();
                }
            }
        }
    }
}
