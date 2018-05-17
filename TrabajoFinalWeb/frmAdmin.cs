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
        frmList frmListPerson;
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
            this.FrmAdd.BringToFront();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FrmList.BringToFront();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.FrmAdd.Show();
            this.FrmList.Show();
            this.FrmAdd.BringToFront();
            
        }
    }
}
