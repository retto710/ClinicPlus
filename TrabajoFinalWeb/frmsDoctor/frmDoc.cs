using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoFinalWeb.frmsDoctor;
using buisnessLogic.Doctor;
using buisnessLogic.User;
using Entities;
namespace TrabajoFinalWeb
{
    public partial class frmDoc : Form
    {
        FrmPacientes frmPacientes;
        IDoctorService doctorService = new DoctorService();
        IUserService userService = new UserService();
        frmDate frmDate;
        public int doctorid;
        public frmDate MyfrmDate {
            get
            {
                if (frmDate == null ||
                    frmDate.IsDisposed)
                {
                    frmDate =
                        new frmDate();
                    frmDate.MdiParent = this;
                    frmDate.Dock = DockStyle.Fill;
                }
                return frmDate;
            }
        }
        public FrmPacientes MyFrmPacientes
        {
            get
            {
                if (frmPacientes == null ||
                    frmPacientes.IsDisposed)
                {
                    frmPacientes =
                        new FrmPacientes();
                    frmPacientes.MdiParent = this;
                    frmPacientes.Dock = DockStyle.Fill;
                }
                return frmPacientes;
            }
        }

       
        public frmDoc(string username)
        {
            InitializeComponent();
            user objUser = new user();
            objUser = userService.GetUserByUsername(username);
            doctorid=doctorService.GetDoctorByUserId(objUser.id).id;
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MyFrmPacientes.BringToFront();  
        }

        private void frmDoc_Load(object sender, EventArgs e)
        {
            this.MyfrmDate.Show();
            this.MyFrmPacientes.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Close();
            frm.Show();
        }
    }
}
