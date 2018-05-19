using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Doctor
{
    public class DoctorRepository : IDoctorRepository
    {
        public void CreateDoctor(doctor objDoctor)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                dataContext.doctors.Add(objDoctor);
                dataContext.SaveChanges();
            }
        }

        public void DeleteDoctor(int id)
        {
            using (var dataContext =
                new FinalAppWebEntities())
            {
                var cust = from c in dataContext.doctors
                           where c.id == id
                           select c;
                doctor objDoctor = cust.FirstOrDefault();
                dataContext.doctors.Remove(objDoctor);
                dataContext.SaveChanges();
            }
        }

        public doctor GetDoctorByPersonId(int personid)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.doctors
                            where c.personId == personid
                            select c;
                doctor objDoctor = custs.FirstOrDefault();
                return objDoctor;
            }
        }

        public doctor GetDoctorByUserId(int userid)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.doctors
                            where c.userId == userid
                            select c;
                doctor objDoctor = custs.FirstOrDefault();
                return objDoctor;
            }
        }

        public List<doctor> GetDoctors()
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.doctors
                            select c;
                List<doctor> objDoctor = custs.ToList();
                return objDoctor;
            }
        }
    }
}
