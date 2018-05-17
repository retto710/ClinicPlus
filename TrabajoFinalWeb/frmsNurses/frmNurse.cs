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
        frmRandU frmRandU;
        frmPatientDate frmPatientDate;
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
                        new frmPatientDate();
                    frmPatientDate.MdiParent = this;
                }
                return frmPatientDate;
            }
        }

        public frmNurse()
        {
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
    }
}
