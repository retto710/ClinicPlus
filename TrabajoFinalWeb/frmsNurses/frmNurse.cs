using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalWeb.frmsNurses
{
    public partial class frmNurse : Form
    {
        int IDnurseLogOn;

        frmRandU frmRandU;
        frmPatientDate frmPatientDate;
        frmReporte frmReporte;
        public frmReporte MyFrmReporte
        {
            get
            {
                if (frmReporte == null ||
                    frmReporte.IsDisposed)
                {
                    frmReporte =
                        new frmReporte();
                    frmReporte.MdiParent = this;
                    frmReporte.Dock = DockStyle.Fill;
                }
                return frmReporte;
            }
        }
        public frmRandU MyFrmRandU
        {
            get
            {
                if (frmRandU == null ||
                    frmRandU.IsDisposed)
                {
                    frmRandU =
                        new frmRandU();
                    frmRandU.MdiParent = this;
                    frmRandU.Dock = DockStyle.Fill;
                }
                return frmRandU;
            }
        }
        public frmPatientDate MyFrmPatientDate
        {
            get
            {
                if (frmPatientDate == null ||
                    frmPatientDate.IsDisposed)
                {
                    frmPatientDate =
                        new frmPatientDate(IDnurseLogOn);
                    frmPatientDate.MdiParent = this;
                    frmPatientDate.Dock = DockStyle.Fill;
                }
                return frmPatientDate;
            }
        }

        public frmNurse(int idNurse)
        {
            IDnurseLogOn = idNurse;
            InitializeComponent();
        }

        private void registroYCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MyFrmRandU.Show();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MyFrmPatientDate.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MyFrmReporte.Show();
        }
    }
}
