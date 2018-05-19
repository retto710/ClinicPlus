using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Patient
{
    public interface IPatientRepository
    {
        void CreatePatient(patient objPatient);
        patient GetPatientByPersonId(int personid);
        List<patient> GetPatients();
        void DeletePatient(int id);
    }
}