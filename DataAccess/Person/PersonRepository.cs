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
            string connectionString =
                  ConfigurationManager.ConnectionStrings["FinalAppWeb"].ConnectionString;
            string queryString = "usp_CreatePerson";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", objPerson.name);
                command.Parameters.AddWithValue("@lastName", objPerson.lastName);
                command.Parameters.AddWithValue("@DNI", objPerson.DNI);
                command.Parameters.AddWithValue("@gender", objPerson.gender);
                command.Parameters.AddWithValue("@age", objPerson.age);
                command.Parameters.AddWithValue("@phone", objPerson.phone);
                command.Parameters.AddWithValue("@dateOfBith", objPerson.dateOfBith);
                command.Parameters.AddWithValue("@email", objPerson.email);
                command.Parameters.AddWithValue("@address", objPerson.address);
                command.Parameters.AddWithValue("@nationality", objPerson.nationality);

                // set to the console window.
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
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
