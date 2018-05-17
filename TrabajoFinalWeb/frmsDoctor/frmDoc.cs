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

namespace TrabajoFinalWeb
{
    public partial class frmDoc : Form
    {
        FrmPacientes frmPacientes;
        FrmMySpecialities frmMySpecialities;

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
                }
                return frmPacientes;
            }
        }

        public FrmMySpecialities MyFrmMySpecialities
        {
            get
            {
                if (frmMySpecialities == null ||
                    frmMySpecialities.IsDisposed)
                {
                    frmMySpecialities =
                        new FrmMySpecialities();
                    frmMySpecialities.MdiParent = this;
                }
                return frmMySpecialities;
            }
        }

        public frmDoc()
        {
            InitializeComponent();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MyFrmPacientes.Show();
        }

        private void misEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MyFrmMySpecialities.Show();
        }
    }
}
