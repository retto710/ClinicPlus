using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DoctorSpeciality
{
    public class DoctorSpecialityRepository : IDoctorSpecialityRepository
    {
        public void CreateDoctorSpeciality(doctor_speciality objDoctor_Speciality)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                dataContext.doctor_speciality.Add(objDoctor_Speciality);
                dataContext.SaveChanges();
            }
        }

        public List<doctor_speciality> GetDoctor_Specialities(int doctorid)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.doctor_speciality
                            where c.doctorId==doctorid
                            select c;
                List<doctor_speciality> objDoctor_Speciality = custs.ToList();
                return objDoctor_Speciality;
            }
        }

        public doctor_speciality GetDoctor_Speciality(int id)
        {
            using(var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.doctor_speciality
                            where c.id == id
                            select c;
                doctor_speciality objDoctor_Speciality = custs.FirstOrDefault();
                return objDoctor_Speciality;
            }
        }
    }
}
