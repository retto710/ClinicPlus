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
        public List<patient> GetPatients()
        {
            IPatientRepository repo = new PatientRepository();
            return repo.GetPatients();
        }
    }
}
