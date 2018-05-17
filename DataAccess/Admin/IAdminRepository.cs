using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccess.Admin
{
    public interface IAdminRepository
    {
        void CreateAdmin(admin objAdmin);

        admin GetAdminByUserId(int userid);
        admin GetAdminByPersonId(int personid);
    }
}
