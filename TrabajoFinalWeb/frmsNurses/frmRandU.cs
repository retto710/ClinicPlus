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
using Entities;
namespace TrabajoFinalWeb.frmsNurses
{
      public partial class frmRandU : Form
    {
        IPersonService personServ = new PersonService();
        IPatientService patientServ = new PatientService();
        IUserService userService = new UserService();
        IDoctorService docService = new DoctorService();
        INurseService nurService = new NurseService();
        IAdminService adminService = new AdminService();
        bool isANewPerson;
        string username;
        person objPerson=new person();
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
        }
        public frmRandU()
        {
            InitializeComponent();
            dateOfBirth.MaxDate = DateTime.Today;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            
            if (txtDNI.Text.ToString().Length!=8)
            {
                MessageBox.Show("Invalid DNI. Try Again");
            }
            else
            {
                int dni = Int32.Parse(txtDNI.Text.ToString());
                //Guradmos persona
                objPerson = personServ.GetPersonByDni(dni);
                //SI existe
                if (objPerson != null)
                {
                    //Obtengo el usuario
                    String name = objPerson.name;
                    char firstletter = name[0];
                    int dniValue=Decimal.ToInt32(objPerson.DNI);
                    username = firstletter + dniValue.ToString();
                    //guardamos usuario
                    objUser = userService.GetUserByUsername(username);
                    enableTextbox(false);
                    isANewPerson = false;
                    //Coloco los datos en los textboxs
                    txtName.Text = objPerson.name;
                    txtLastName.Text = objPerson.lastName;
                    txtDNI2.Text = objPerson.DNI.ToString();
                    if (objPerson.gender.Equals("Male"))
                    {
                        cmbGender.SelectedIndex = 1;
                    }
                    else
                    {
                        cmbGender.SelectedIndex = 0;
                    }
                    numericAge.Value = objPerson.age;
                    numericPhoneNumber.Value = objPerson.phone;
                    dateOfBirth.Text = objPerson.dateOfBith.ToString();
                    txtEmail.Text = objPerson.email;
                    txtAddress.Text = objPerson.address;
                    txtNationality.Text = objPerson.nationality;
                   
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
                    MessageBox.Show("This user is already a Patient");
                }
                else
                {
                    patientServ.CreatePatient(objPatient);
                    MessageBox.Show("New Patient Saved");
                    enableTextbox(false);
                    initialize();
                }
                
        }
    }
}
