using buisnessLogic.clinicDatee;
using buisnessLogic.Doctor;
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

namespace TrabajoFinalWeb.frmsNurses
{
    public partial class frmReporte : Form
    {
        IClinicDateService clinicDateService = new ClinicDateService();
        IDoctorService doctorService = new DoctorService();
        public frmReporte()
        {
            InitializeComponent();
        }

        private void load(List<clinicDate> dates) {
            dataGridView1.DataSource = dates;
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            List<doctor> doctors = doctorService.GetDoctors();
            cbDoctor.DataSource = doctors;
            cbDoctor.SelectedIndex = 0;
            List<clinicDate> dates = clinicDateService.GetClinicDates();
            load(dates);
        }

        private void btnDatesFalse_Click(object sender, EventArgs e)
        {
            List<clinicDate> dates = clinicDateService.GetClinicDatesNotAprove();
            load(dates);

        }

        private void btnDatesTrue_Click(object sender, EventArgs e)
        {
            List<clinicDate> dates = clinicDateService.GetClinicDatesAprove();
            load(dates);
        }

        private void btnDateByDoctor_Click(object sender, EventArgs e)
        {
            int idDoc = Convert.ToInt32(cbDoctor.SelectedValue);
            if (idDoc != 0)
            {
                List<clinicDate> dates = clinicDateService.GetClinicDatesByDoctor(idDoc);
                load(dates);
            }

        }
    }
}
