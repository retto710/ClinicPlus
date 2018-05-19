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
        public void CreatePatient(patient objPatient)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                dataContext.patients.Add(objPatient);
                dataContext.SaveChanges();
            }
        }

        public void DeletePatient(int id)
        {
            using (var dataContext =
                new FinalAppWebEntities())
            {
                var cust = from c in dataContext.patients
                           where c.id == id
                           select c;
                patient objPatient = cust.FirstOrDefault();
                dataContext.patients.Remove(objPatient);
                dataContext.SaveChanges();
            }
        }

        public patient GetPatientByPersonId(int personid)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.patients
                            where c.personId==personid
                            select c;
                patient objPerson = custs.FirstOrDefault();
                return objPerson;
            }
        }

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
