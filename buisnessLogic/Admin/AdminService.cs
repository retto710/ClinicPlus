using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Admin;
using Entities;

namespace buisnessLogic.Admin
{
    public class AdminService : IAdminService
    {
        public void CreateAdmin(admin objAdmin)
        {
            IAdminRepository repo = new AdminRepository();
            repo.CreateAdmin(objAdmin);
        }

        public admin GetAdminByUserId(int userid)
        {
            IAdminRepository repo = new AdminRepository();
            return repo.GetAdminByUserId(userid);
        }
    }
}
