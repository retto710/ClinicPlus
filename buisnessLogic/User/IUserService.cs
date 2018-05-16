using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessLogic.User
{
    public interface IUserService
    {
        void CreateUser(user objUser);
        user GetUserByUsername(String username);
        void DeleteUser(user objUser);
        void UpadteUser(user objUser);
        List<user> GetUsers();
    }
}
