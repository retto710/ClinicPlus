using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.User
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(user objUser)
        {
            string connectionString =
                  ConfigurationManager.ConnectionStrings["FinalAppWeb"].ConnectionString;
            string queryString = "usp_CreateUser";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", objUser.username);
                command.Parameters.AddWithValue("@password", objUser.password);
                command.Parameters.AddWithValue("@email", objUser.email);
                    
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

        public void DeleteUser(user objUser)
        {
            throw new NotImplementedException();
        }

        public user GetUserByUsername(string username)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.users
                            where c.username == username
                            select c;
                user objUser= custs.FirstOrDefault();
                return objUser;
            }
        }

        public void UpadteUser(user objUser)
        {
            throw new NotImplementedException();
        }
    }
}
