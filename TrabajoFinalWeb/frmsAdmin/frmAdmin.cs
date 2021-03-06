﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoFinalWeb.frmsAdmin;

namespace TrabajoFinalWeb
{
    public partial class frmAdmin : Form
    {
        frmAdd frmAddPerson;
        frmList frmListPerson;
        frmServiceStatus frmServiceStatus;
        frmAddSpeciality frmSpeciality;
        frmDoctorSpeciality frmAddDoctorSpeciality;
        public frmServiceStatus FrmServiceStatus
        {
            get
            {
                if (frmServiceStatus == null ||
                    frmServiceStatus.IsDisposed)
                {
                    frmServiceStatus =
                        new frmServiceStatus();
                    frmServiceStatus.MdiParent = this;
                    frmServiceStatus.Dock = DockStyle.Fill;
                }
                return frmServiceStatus;
            }
        }
        public frmDoctorSpeciality FrmDoctorSpeciality
        {
            get
            {
                if (frmAddDoctorSpeciality == null ||
                    frmAddDoctorSpeciality.IsDisposed)
                {
                    frmAddDoctorSpeciality =
                        new frmDoctorSpeciality();
                    frmAddDoctorSpeciality.MdiParent = this;
                    frmAddDoctorSpeciality.Dock = DockStyle.Fill;
                }
                return frmAddDoctorSpeciality;
            }
        }
        public frmAddSpeciality FrmAddSpeciality
        {
            get
            {
                if (frmSpeciality == null ||
                    frmSpeciality.IsDisposed)
                {
                    frmSpeciality =
                        new frmAddSpeciality();
                    frmSpeciality.MdiParent = this;
                    frmSpeciality.Dock = DockStyle.Fill;
                }
                return frmSpeciality;
            }

        }

        public frmAdd FrmAdd
        {
            get
            {
                if (frmAddPerson == null ||
                    frmAddPerson.IsDisposed)
                {
                    frmAddPerson =
                        new frmAdd();
                    frmAddPerson.MdiParent = this;
                    frmAddPerson.Dock = DockStyle.Fill;
                }
                return frmAddPerson;
            }

        }

        public frmList FrmList
        {
            get
            {
                if (frmListPerson == null ||
                    frmListPerson.IsDisposed)
                {
                    frmListPerson =
                        new frmList();
                    frmListPerson.MdiParent = this;
                    frmListPerson.Dock = DockStyle.Fill;
                }
                return frmListPerson;
            }

        }


        public frmAdmin()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FrmList.BringToFront();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.FrmAdd.Show();
            this.FrmList.Show();
            this.FrmDoctorSpeciality.Show();
            this.FrmAddSpeciality.Show();
            this.FrmServiceStatus.Show();
            this.FrmAdd.BringToFront();
        }

        private void typeOfUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FrmAdd.BringToFront();
        }

        private void specialityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FrmAddSpeciality.BringToFront();
        }

        private void doctorSpecialitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FrmDoctorSpeciality.BringToFront();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FrmServiceStatus.BringToFront();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmLogin frm = new frmLogin();
            this.Close();
            frm.Show();
        }
    }
}
