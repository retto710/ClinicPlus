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
    public partial class frmAdmin : Form
    {
        frmAdd frmAddPerson;
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
                }
                return frmAddPerson;
            }

        }
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FrmAdd.Show();
        }
    }
}
