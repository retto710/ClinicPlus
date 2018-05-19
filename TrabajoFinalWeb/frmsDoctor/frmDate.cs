using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalWeb.frmsDoctor
{
    public partial class frmDate : Form
    {
        public frmDate()
        {
            InitializeComponent();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            frmRequestService services = new frmRequestService(0);
            services.Show();
        }
    }
}
