using buisnessLogic.Doctor;
using buisnessLogic.Nurse;
using buisnessLogic.Patient;
using buisnessLogic.Person;
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

namespace TrabajoFinalWeb
{
    public partial class frmList : Form
    {
        IPersonService servPerson = new PersonService();


        public frmList()
        {
            InitializeComponent();
        }

        public void loadPersons()
        {
            List<person> persons = servPerson.GetPersons();
            dataGridView1.DataSource = persons;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                if (MessageBox.Show("Deseas borrar a esta persona?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    person ojUser = (person)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    this.servPerson.DeletePerson(ojUser.ID);

                    dataGridView1.DataBindings.Clear();
                    loadPersons();
                }
            }

        }

        private void frmList_Load(object sender, EventArgs e)
        {
            loadPersons();
        }

        private void btnNurses_Click(object sender, EventArgs e)
        {

        }
    }
}
