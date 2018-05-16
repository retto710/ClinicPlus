﻿using System;
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

        public void UpdatePerson(person objPerson)
        {
            throw new NotImplementedException();
        }
    }
}
