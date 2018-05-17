using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Speciality
{
    public class SpecialityRepository : ISpecialityRepository
    {
        public void CreateSpeciality(speciality objSpeciality)
        {
            using (var dataContext = new FinalAppWebEntities())
            {

                dataContext.specialities.Add(objSpeciality);
                dataContext.SaveChanges();
            }
        }

        public void DeleteSpeciality(int specialityId)
        {
            using (var dataContext =
                new FinalAppWebEntities())
            {
                //Load customer object
                var cust = from c in dataContext.specialities
                           where c.ID == specialityId
                           select c;
                speciality objCustomer = cust.FirstOrDefault();
                //Remove
                dataContext.specialities.Remove(objCustomer);
                //Save
                dataContext.SaveChanges();
            }
        }

        public List<speciality> GetSpecialities()
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.specialities
                            select c;
                List<speciality> objPerson = custs.ToList();
                return objPerson;
            }
        }

        public speciality GetSpecialityByDescription(string description)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.specialities
                            where c.description == description
                            select c;
                speciality objSpeciality = custs.FirstOrDefault();
                return objSpeciality;
            }
        }
    }
}
