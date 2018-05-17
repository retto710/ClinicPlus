using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Patient
{
    public class PatientRepository : IPatientRepository
    {
        public List<patient> GetPatients()
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.patients
                            select c;
                List<patient> objPerson = custs.ToList();
                return objPerson;
            }
        }
    }
}
