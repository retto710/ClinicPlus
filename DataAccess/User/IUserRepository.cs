using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccess.User
{
    public interface IUserRepository
    {
        void CreateUser(user objUser);
        user GetUserByUsername(String username);
        void DeleteUser(user objUser);
        void UpadteUser(user objUser);
    }
}
