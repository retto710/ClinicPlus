using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Service
{
    public class ServicesRepository : IServicesRepository
    {
        public void createService(service objService)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                dataContext.services.Add(objService);
                dataContext.SaveChanges();
            }
        }

        public void deleteService(service objService)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var cust = from c in dataContext.services
                           where c.ID == objService.ID
                           select c;
                service objCustomer = cust.FirstOrDefault();
                dataContext.services.Remove(objCustomer);
                dataContext.SaveChanges();
            }
        }

        public List<service> getServices()
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var tnts = from t in dataContext.services
                           select t;
                return tnts.ToList();
            }
        }
    }
}
