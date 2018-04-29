using buisnessLogic.User;
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

namespace TrabajoFinalWeb
{
    public partial class frmLogin : Form
    {
        frmAdmin frmAdministrador;
        IUserService userService = new UserService();
        public frmAdmin FrmAdministrador {
            get {
                if (frmAdministrador == null || frmAdministrador.IsDisposed)
                {
                    frmAdministrador = new frmAdmin();
                    
                }
                return frmAdministrador;
            }

        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            objUser=userService.GetUserByUsername(txtUsername.Text.ToLower());
            //Validar si existe
            if (objUser==null)
            {
                MessageBox.Show("Username incorrecto");
            }

            //Validar Contraseña
            else if (objUser.password == txtPassword.Text)
            {
                MessageBox.Show("Bienvenido "+objUser.username);
                this.Hide();
                FrmAdministrador.Show();
            }
            else {
                MessageBox.Show("Contraseña y/o nombre de usuario incorrecto");
            }
           
      
        }
    }
}
