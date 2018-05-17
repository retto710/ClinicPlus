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
    }
}
