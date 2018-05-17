using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Patient;
using Entities;

namespace buisnessLogic.Patient
{
    public class PatientService : IPatientService
    {
        public void CreatePatient(patient objPatient)
        {
            IPatientRepository repo = new PatientRepository();
            repo.CreatePatient(objPatient);
        }

        public patient GetPatientByPersonId(int personid)
        {
            IPatientRepository repo = new PatientRepository();
            return repo.GetPatientByPersonId(personid);
        }

        public List<patient> GetPatients()
        {
            IPatientRepository repo = new PatientRepository();
            return repo.GetPatients();
        }
    }
}
