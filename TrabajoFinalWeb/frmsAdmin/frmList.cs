﻿using buisnessLogic.Doctor;
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
        INurseService nurseService = new NurseService();
        IDoctorService doctorService = new DoctorService();
        IPatientService patientService = new PatientService();
        List<person> persons= new List<person>();
        String type;
        public frmList()
        {
            InitializeComponent();
        }

        public void loadPersons()
        {
            persons = servPerson.GetPersons();
            dataGridView1.DataSource = persons;
        }
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                if (MessageBox.Show("Do you want to delete this "+type+" ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int dni = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    int personId =servPerson.GetPersonByDni(dni).ID;
                    if (type=="Nurse")
                    {
                        nurse objNurse = new nurse();
                        objNurse=nurseService.GetNurseByPersonId(personId);
                        nurseService.DeleteNurse(objNurse.id);
                    }
                    else if (type == "Doctor")
                    {
                        doctor objDoctor = new doctor();
                        objDoctor = doctorService.GetDoctorByPersonId(personId);
                        doctorService.DeleteDoctor(objDoctor.id);
                    }
                    else if (type == "Patient")
                    {
                        patient objPatient = new patient();
                        objPatient = patientService.GetPatientByPersonId(personId);
                        patientService.DeletePatient(objPatient.id);
                    }

                    dataGridView1.DataBindings.Clear();
                    loadPersons();
                }
            }

        }

        private void frmList_Load(object sender, EventArgs e)
        {
           
            loadPersons();
            this.dataGridView1.Columns["Delete"].Visible = false;
        }

        private void btnNurses_Click(object sender, EventArgs e)
        {
            List<nurse> nurses = nurseService.GetNurses();
            List<person> filterlist = new List<person>();
            int contador = 0;
            type = "Nurse";
            while (contador<nurses.Count())
            {
                int personid=nurses.ElementAt(contador).personId;
                if (servPerson.GetPersonById(personid)!=null)
                {
                    filterlist.Add(servPerson.GetPersonById(personid));
                }
                contador++;
            }
            dataGridView1.DataSource = filterlist;
            this.dataGridView1.Columns["Delete"].Visible = true;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            
            loadPersons();
            this.dataGridView1.Columns["Delete"].Visible = false;
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            type = "Doctor";
            List<doctor> doctors = doctorService.GetDoctors();
            List<person> filterlist = new List<person>();
            int contador = 0;
            
            while (contador < doctors.Count())
            {
                int personid = doctors.ElementAt(contador).personId;
                if (servPerson.GetPersonById(personid) != null)
                {
                    filterlist.Add(servPerson.GetPersonById(personid));
                }
                contador++;
            }
            dataGridView1.DataSource = filterlist;
            this.dataGridView1.Columns["Delete"].Visible = true;
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            type = "Patient";
            List<patient> patients = patientService.GetPatients();
            List<person> filterlist = new List<person>();
            int contador = 0;
            
            while (contador < patients.Count())
            {
                int personid = patients.ElementAt(contador).personId;
                if (servPerson.GetPersonById(personid) != null)
                {
                    filterlist.Add(servPerson.GetPersonById(personid));
                }
                contador++;
            }
            dataGridView1.DataSource = filterlist;
            this.dataGridView1.Columns["Delete"].Visible = true;
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void btnExport_Click(object sender, EventArgs e)
        {

            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }
    }
}
