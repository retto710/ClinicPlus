using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Admin
{
    public class AdminRepository : IAdminRepository
    {
        public void CreateAdmin(admin objAdmin)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                dataContext.admins.Add(objAdmin);
                dataContext.SaveChanges();
            }
        }

        public admin GetAdminByPersonId(int personid)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.admins
                            where c.personId == personid
                            select c;
                admin objAdmin = custs.FirstOrDefault();
                return objAdmin;
            }
        }

        public admin GetAdminByUserId(int userid)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.admins
                            where c.userId == userid
                            select c;
                admin objAdmin = custs.FirstOrDefault();
                return objAdmin;
            }
        }
    }
}
