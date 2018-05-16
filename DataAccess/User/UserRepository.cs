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
            using (var dataContext = new FinalAppWebEntities())
            {
                
                dataContext.users.Add(objUser);
                dataContext.SaveChanges();
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

        public List<user> GetUsers()
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.users
                            select c;
                List<user> objsUser = custs.ToList();
                return objsUser;
            }
        }

        public void UpadteUser(user objUser)
        {
            throw new NotImplementedException();
        }
    }
}
