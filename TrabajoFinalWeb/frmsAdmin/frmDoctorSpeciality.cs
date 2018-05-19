using buisnessLogic.Person;
using buisnessLogic.Doctor;
using buisnessLogic.User;
using buisnessLogic.Speciality;

using buisnessLogic.DoctorSpeciality;
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
namespace TrabajoFinalWeb
{
    public partial class frmDoctorSpeciality : Form
    {
        IPersonService personService = new PersonService();
        IDoctorService doctorService = new DoctorService();
        IUserService userService = new UserService();
        ISpecialityService specialityService = new SpecialityService();
        IDoctorSpecialityService doctorSpecialityService = new DoctorSpecialityService();
        int doctorid;
        public frmDoctorSpeciality()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int dni = Decimal.ToInt32(numericDNI.Value);
            person objPerson = new person();
            doctor objDoctor = new doctor();
            user objUser = new user();
            objPerson = personService.GetPersonByDni(dni);
            if (objPerson!=null)
            {
               
                objUser = userService.GetUserByUsername(objPerson.name[0] + dni.ToString());
                
                if (doctorService.GetDoctorByUserId(objUser.id)==null)
                {
                    btnAdd.Enabled = false;
                    DataTable dataTable = this.finalAppWebDataSet4.doctor_speciality;
                    String datafilter = "doctorid <1000000 ";
                    dataTable.DefaultView.RowFilter = datafilter;
                    dataGridView1.DataSource = dataTable;
                    MessageBox.Show("Doctor not found");
                    
                }
                else
                {
                    doctorid = doctorService.GetDoctorByUserId(objUser.id).id;
                    txtName.Text = objPerson.name;
                    txtLastName.Text = objPerson.lastName;
                    btnAdd.Enabled = true;
                    String datafilter = "doctorid = " + doctorid.ToString();



                    //DataTable dataTable = this.finalAppWebDataSet4.doctor_speciality;
                    //dataTable.DefaultView.RowFilter=datafilter;
                    List<doctor_speciality> dataTable = doctorSpecialityService.GetDoctor_Specialities(doctorid);
                    dataGridView1.DataSource = dataTable;

                }
               
            }
            else
            {
                btnAdd.Enabled = false;
                DataTable dataTable = this.finalAppWebDataSet4.doctor_speciality;
                String datafilter = "doctorid <10000 ";
                dataTable.DefaultView.RowFilter = datafilter;
                dataGridView1.DataSource = dataTable;
                MessageBox.Show("Doctor not found");
            }
            


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            doctor_speciality obj = new doctor_speciality();
            obj.doctorId = doctorid;
            obj.specialityId= Convert.ToInt32(cmbSpeciality.SelectedValue);
            doctorSpecialityService.CreateDoctorSpeciality(obj);
            List<doctor_speciality> dataTable = doctorSpecialityService.GetDoctor_Specialities(doctorid);
            dataGridView1.DataSource = dataTable;
          
           


        }

        private void load() {
            List<speciality> listSpecialities = specialityService.GetSpecialities();

            //Assign list to drop down list
            cmbSpeciality.DataSource = listSpecialities;
            cmbSpeciality.SelectedIndex = 0;
        }
    
        private void frmDoctorSpeciality_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalAppWebDataSet4.doctor_speciality' table. You can move, or remove it, as needed.
            this.doctor_specialityTableAdapter.Fill(this.finalAppWebDataSet4.doctor_speciality);

            //Get customer types
            load();
        }
    }
}
