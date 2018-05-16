using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using buisnessLogic.Person;
using buisnessLogic.User;
using Entities;
namespace TrabajoFinalWeb
{

    public partial class frmAdd : Form
    {
        IPersonService personServ = new PersonService();
        IUserService userService = new UserService();
        bool exist;
        public frmAdd()
        {
            InitializeComponent();
            dateOfBirth.MaxDate = DateTime.Today;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            person objPerson;
            
            if (txtDNI.Text.ToString().Length!=8)
            {
                MessageBox.Show("Invalid DNI. Try Again");
            }
            else
            {
                int dni = Int32.Parse(txtDNI.Text.ToString());
                objPerson = personServ.GetPersonByDni(dni);
                if (objPerson != null)
                {
                    txtName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtDNI2.Enabled = false;
                    txtDNI2.Text = txtDNI.Text;
                    cmbGender.Enabled = false;
                    numericAge.Enabled = false;
                    numericPhoneNumber.Enabled = false;
                    dateOfBirth.Enabled = false;
                    txtEmail.Enabled = false;
                    txtAddress.Enabled = false;
                    txtNationality.Enabled = false;
                    txtType.Enabled = false;
                    //10
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
                    exist = true;
                }
                else
                {
                    MessageBox.Show("New Person");
                    txtName.Enabled = true; txtName.Text = "";
                    txtLastName.Enabled = true; txtLastName.Text ="";
                    txtDNI2.Enabled = true;
                    txtDNI2.Text = txtDNI.Text;
                    cmbGender.Enabled = true; 
                    numericAge.Enabled = true; numericAge.Value = 0;
                    numericPhoneNumber.Enabled = true; numericPhoneNumber.Value = 0;
                    dateOfBirth.Enabled = true; dateOfBirth.Value=DateTime.Today;
                    txtEmail.Enabled = true; txtEmail.Text = "";
                    txtAddress.Enabled = true; txtAddress.Text = "";
                    txtNationality.Enabled = true; txtNationality.Text = "";
                    txtType.Enabled = true; txtType.Text = "";
                    exist = false;

                }
            }
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            person objPerson = new person();
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
            String type= txtType.SelectedItem.ToString();
            char firstLetter = char.ToLower(type[0]);
            user ObjUser = new user();
            if (exist==false)
            {
                ObjUser.username = firstLetter + txtDNI2.Text.ToString();
                ObjUser.password = "default";
                ObjUser.email = txtEmail.Text.ToString();
                userService.CreateUser(ObjUser);
            }
            if (firstLetter=='a')
            {
                //Crear administrador

            }
            else if (firstLetter=='n')
            {
                //Crear enferma
            }
            else 
            {
                //Crear doctor
            }

        }
    }
}
