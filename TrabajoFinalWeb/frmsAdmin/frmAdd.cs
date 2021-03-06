﻿
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
namespace TrabajoFinalWeb
{
      public partial class frmAdd : Form
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
            txtType.Enabled = enable;

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
            txtType.Text = "";
        }
        public frmAdd()
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
                    txtType.Enabled = true;
                   
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
            String type = txtType.SelectedItem.ToString();
          
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
            String name = objPerson.name;
            char firstletter = name[0];
            int dniValue = Decimal.ToInt32(objPerson.DNI);
            username = firstletter + dniValue.ToString();
            //Verifico si tiene usuario y si no es estoy creando paciente
            if (userService.GetUserByUsername(username) == null&&type!="Patient")
            {
                objUser = new user();
                objUser.username = username;
                objUser.email = txtEmail.Text.ToString();
                objUser.password = "default1";
                userService.CreateUser(objUser);
            }
            //VERIFICAR TIPO DE USUARIO 
            if (type.Equals("Admin"))
            {
                admin objAdmin = new admin();
                //Buscamos el usuario
                objUser = userService.GetUserByUsername(username);
                //Buscamos la persona
                objPerson = personServ.GetPersonByDni(dniValue);
                //Lo asignamos al admin
                objAdmin = new admin();
                objAdmin.userId = objUser.id;
                objAdmin.personId = objPerson.ID;
                //lo creamos
                if (adminService.GetAdminByUserId(objAdmin.userId) != null)
                {
                    MessageBox.Show("This user is already an Admin");
                }
                else
                {
                    adminService.CreateAdmin(objAdmin);
                    MessageBox.Show("New Admin Saved");
                    enableTextbox(false);
                    initialize();
                }
               
            }

            else if (type.Equals("Doctor"))
            {
                doctor objDoctor = new doctor();
                //Buscamos el usuario
                objUser = userService.GetUserByUsername(username);
                //Buscamos la persona
                objPerson = personServ.GetPersonByDni(dniValue);
                //Lo asignamos al admin
                objDoctor = new doctor();
                objDoctor.userId = objUser.id;
                objDoctor.personId = objPerson.ID;
                objDoctor.dateOfEnrollment = DateTime.Today;
                objDoctor.status = true;
                //lo creamos
                if (docService.GetDoctorByUserId(objDoctor.userId) != null)
                {
                    MessageBox.Show("This user is already a Doctor");
                }
                else
                {
                    docService.CreateDoctor(objDoctor);
                    MessageBox.Show("New Doctor Saved");
                    enableTextbox(false);
                    initialize();
                }

            }

            else if (type.Equals("Nurse"))
            {
                nurse objNurse = new nurse();
                //Buscamos el usuario
                objUser = userService.GetUserByUsername(username);
                //Buscamos la persona
                objPerson = personServ.GetPersonByDni(dniValue);
                //Lo asignamos al admin
                objNurse = new nurse();
                objNurse.userid = objUser.id;
                objNurse.personId = objPerson.ID;
                //lo creamos
                if (nurService.GetNurseByUserId(objNurse.userid) != null)
                {
                    MessageBox.Show("This user is already a Nurse");
                }
                else
                {
                    nurService.CreateNurse(objNurse);
                    MessageBox.Show("New Nurse Saved");
                    enableTextbox(false);
                    initialize();
                }

            }
            else if (type.Equals("Patient"))
            {
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
}