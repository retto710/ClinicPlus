using buisnessLogic.Person;
using buisnessLogic.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
namespace TrabajoFinalWeb
{
    public partial class frmForgotPassword : Form
    {
        IUserService userService = new UserService();
        IPersonService personService = new PersonService();
        private static Random random = new Random();
        user objUser = new user();
        public frmForgotPassword()
        {
            InitializeComponent();
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToString();
            string dni = txtDNI.Text.ToString().Trim();
            int dnivalue = Convert.ToInt32(dni.ToString());
            string email = txtEmail.Text.ToString();
            DateTime dateTime = dtpDOB.Value.Date;
            objUser = new user();
            person objPerson = new person();
            objUser = userService.GetUserByUsername(name[0] + dni);
            if (objUser == null)
            {
                MessageBox.Show("User not found");
            }
            else
            {
                objPerson = personService.GetPersonByDni(dnivalue);
                if (objPerson.name != name || objPerson.email != email || objPerson.dateOfBith.Date != dateTime)
                {
                    MessageBox.Show("Incorrect Data");
                }
                else
                {
                    string newPassword = RandomString(8);
                    objUser.password=newPassword;
                    userService.UpadteUser(objUser);
                    txtPassword.Text = newPassword;

                }
            }
        }
    }
}
