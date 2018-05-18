using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess.Person
{
    public class PersonRepository : IPersonRepository
    {
        public void CreatePerson(person objPerson)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                dataContext.people.Add(objPerson);
                dataContext.SaveChanges();
            }
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public person GetPersonByDni(int dni)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.people
                            where c.DNI == dni
                            select c;
                person objPerson = custs.FirstOrDefault();
                return objPerson;
            }
        }

        public person GetPersonById(int id)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.people
                            where c.ID == id
                            select c;
                person objPerson = custs.FirstOrDefault();
                return objPerson;
            }
        }

        public List<person> GetPersons()
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.people
                            select c;
                List<person> objPerson = custs.ToList();
                return objPerson;
            }
        }

        public void UpdatePerson(person objPerson)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //Get object from database
                var trs = from t in dataContext.people
                          where t.ID == objPerson.ID
                          select t;
                person transaction = trs.FirstOrDefault();
                //Update field by field
                transaction.name = objPerson.name;
                transaction.lastName = objPerson.lastName;
                transaction.gender = objPerson.gender;
                transaction.age = objPerson.age;
                transaction.phone = objPerson.phone;
                transaction.email = objPerson.email;
                transaction.dateOfBith = objPerson.dateOfBith;
                transaction.address = objPerson.address;
                transaction.nationality = objPerson.nationality;
                dataContext.SaveChanges();
            }
        }
    }
}
