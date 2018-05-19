using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using buisnessLogic.Service;
namespace TrabajoFinalWeb.frmsDoctor
{
    public partial class frmRequestService : Form
    {
        int dateID;
        public frmRequestService(int clincDateId)
        {
            InitializeComponent();
            dateID = clincDateId;
        }

        private void btnRequestService_Click(object sender, EventArgs e)
        {
            IServicesService servicesService = new ServicesService();
            service objService = new service();
            objService.clinicDateId = dateID;
            objService.description = txtServiceDescription.Text.ToString();
            objService.dateOfService = dtServices.Value;
            objService.doctorId = 1;
            objService.dateOfRequest = DateTime.Today;
            objService.status = false;
            servicesService.createService(objService);
            MessageBox.Show("Servicio created. Wait for confirmation.");
            this.Close();
        }
    }
}
