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
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalAppWebDataSet5.clinicDate' Puede moverla o quitarla según sea necesario.
            this.clinicDateTableAdapter.Fill(this.finalAppWebDataSet5.clinicDate);

        }
    }
}
