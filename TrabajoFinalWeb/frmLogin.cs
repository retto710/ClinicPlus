using buisnessLogic.User;
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
using buisnessLogic.Doctor;
using buisnessLogic.Nurse;
using buisnessLogic.Admin;
using TrabajoFinalWeb.frmsNurses;

namespace TrabajoFinalWeb
{
    public partial class frmLogin : Form
    {
        frmAdmin frmAdministrador;
        frmDoc frmDoctor;
        frmNurse frmNurses;
        int contador = 0;
        IUserService userService = new UserService();
        IPersonService personService = new PersonService();
        public frmAdmin FrmAdministrador {
            get {
                if (frmAdministrador == null || frmAdministrador.IsDisposed)
                {
                    frmAdministrador = new frmAdmin();
                    
                }
                return frmAdministrador;
            }

        }
        public frmDoc FrmDoctor
        {
            get
            {
                if (frmDoctor == null || frmDoctor.IsDisposed)
                {
                    frmDoctor = new frmDoc();

                }
                return frmDoctor;
            }
        }
        public frmNurse FrmNurses
        {
            get
            {
                if (frmNurses == null || frmNurses.IsDisposed)
                {
                    frmNurses = new frmNurse();

                }
                return frmNurses;
            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            List<user> suggestions = userService.GetUsers();
            while (contador<suggestions.Count)
            {
                source.Add(suggestions[contador].username);
                contador++;
            }
            txtUsername.AutoCompleteCustomSource = source;
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContraseña.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            user objUser;
            
            objUser = userService.GetUserByUsername(txtUsername.Text.ToLower());
            //validar tipo
            if (cmbTypeOfUser.SelectedIndex==-1)
            {
                MessageBox.Show("Select a type of user");
            }
            //Validar si existe
            else if (objUser == null)
            {
                MessageBox.Show("Username incorrect");
            }

            //Validar Contraseña
            else if (objUser.password == txtPassword.Text)
            {
                String userString = txtUsername.Text.ToString();
                int dni = Int32.Parse(userString.Substring(1));
                String name = personService.GetPersonByDni(dni).name;
                MessageBox.Show("Welcome " + name);
               
                int userid = objUser.id;
                String type = cmbTypeOfUser.SelectedItem.ToString();
                if (type.Equals("Admin"))
                {
                    IAdminService adminService = new AdminService();
                    if (adminService.GetAdminByUserId(userid)==null)
                    {
                        MessageBox.Show("Access Denied");
                    }
                    else
                    {
                        this.Hide();
                        FrmAdministrador.Show();
                    }
                    
                }
                else if (type.Equals("Nurse"))
                {
                    INurseService nurService = new NurseService();
                    if (nurService.GetNurseByUserId(userid) == null)
                    {
                        MessageBox.Show("Access Denied");
                    }
                    else
                    {
                        this.Hide();
                        FrmNurses.Show();
                    }
 
                }
                else if (type.Equals("Doctor"))
                {
                    IDoctorService docService = new DoctorService();
                    if (docService.GetDoctorByUserId(userid) == null)
                    {
                        MessageBox.Show("Access Denied");
                    }
                    else
                    {
                        this.Hide();
                        FrmDoctor.Show();
                    }

                }
            }
            else
            {
                MessageBox.Show("Password or username incorrect");
            }


        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
