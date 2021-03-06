﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.User;
namespace buisnessLogic.User
{
    public class UserService : IUserService
    {
        public void CreateUser(user objUser)
        {
            IUserRepository repo = new UserRepository();
            repo.CreateUser(objUser);
        }

        public void DeleteUser(user objUser)
        {
            throw new NotImplementedException();
        }

        public user GetUserByUsername(string username)
        {
            IUserRepository repo = new UserRepository();
            return repo.GetUserByUsername(username);
        }

        public List<user> GetUsers()
        {
            IUserRepository repo = new UserRepository();
            return repo.GetUsers();
        }

        public void UpadteUser(user objUser)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var trs = from t in dataContext.users
                          where t.id == objUser.id
                          select t;
                user transaction = trs.FirstOrDefault();
                //Update field by field
                transaction.username = objUser.username;
                transaction.password = objUser.password;
                transaction.email = objUser.email;

                dataContext.SaveChanges();
            }
        }
    }
}
