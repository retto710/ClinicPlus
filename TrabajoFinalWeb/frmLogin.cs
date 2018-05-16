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
        frmDoc frmDoctor;
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
            objUser = userService.GetUserByUsername(txtUsername.Text.ToLower());
            //Validar si existe
            if (objUser == null)
            {
                MessageBox.Show("Username incorrecto");
            }

            //Validar Contraseña
            else if (objUser.password == txtPassword.Text)
            {
                MessageBox.Show("Bienvenido " + objUser.username);
                this.Hide();
                String user = txtUsername.Text.ToString();
                char type = user[0];
                if (type == 'a')
                {
                    FrmAdministrador.Show();
                }
                else if (type == 'd')
                {
                    FrmDoctor.Show();
                }
            }
            else
            {
                MessageBox.Show("Contraseña y/o nombre de usuario incorrecto");
            }


        }
    }
}
