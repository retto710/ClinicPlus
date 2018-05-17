using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessLogic.Admin
{
    public interface IAdminService
    {
        void CreateAdmin(admin objAdmin);
        admin GetAdminByUserId(int userid);
    }
}
