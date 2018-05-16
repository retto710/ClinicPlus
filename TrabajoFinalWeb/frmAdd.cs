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
using Entities;
namespace TrabajoFinalWeb
{

    public partial class frmAdd : Form
    {
        IPersonService personServ = new PersonService();
        public frmAdd()
        {
            InitializeComponent();
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
                    txtPhoneNumber.Enabled = false;
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
                    txtPhoneNumber.Text = objPerson.phone.ToString();
                    dateOfBirth.Text = objPerson.dateOfBith.ToString();
                    txtEmail.Text = objPerson.email;
                    txtAddress.Text = objPerson.address;
                    txtNationality.Text = objPerson.nationality;
                    txtType.Enabled = true;
                }
                else
                {
                    MessageBox.Show("New Person");
                    txtName.Enabled = true;
                    txtLastName.Enabled = true;
                    txtDNI2.Enabled = true;
                    txtDNI2.Text = txtDNI.Text;
                    cmbGender.Enabled = true;
                    numericAge.Enabled = true;
                    txtPhoneNumber.Enabled = true;
                    dateOfBirth.Enabled = true;
                    txtEmail.Enabled = true;
                    txtAddress.Enabled = true;
                    txtNationality.Enabled = true;
                    txtType.Enabled = true;


                }
            }
            

        }
    }
}
