using buisnessLogic.Service;
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

namespace TrabajoFinalWeb.frmsAdmin
{
    public partial class frmServiceStatus : Form
    {
        IServicesService servicesService = new ServicesService();
        public frmServiceStatus()
        {
            InitializeComponent();
        }

        private void load() {
            List<service> services = servicesService.getServices();
        }

        private void frmServiceStatus_Load(object sender, EventArgs e)
        {
            this.load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.
                Columns[e.ColumnIndex].
                HeaderText.
                ToLower() == "delete")
            {
                if (MessageBox.Show
                    ("Are you sure you want to delete this date?",
                    "Confirm",
                    MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    service objCustomer =
                        (service)dataGridView1.
                        Rows[e.RowIndex].
                        DataBoundItem;
                    this.servicesService.deleteService(objCustomer);
                    this.load();
                }
            }


            if (dataGridView1.
                Columns[e.ColumnIndex].
                HeaderText.
                ToLower() == "approve")
            {
                if (MessageBox.Show
                    ("Are you sure you want to approve this service?",
                    "Confirm",
                    MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    service objCustomer =
                        (service)dataGridView1.
                        Rows[e.RowIndex].
                        DataBoundItem;
                    objCustomer.status = true;    

                    this.servicesService.updateService(objCustomer);
                    this.load();
                }
            }

        }
    }
}
