using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Service;
using Entities;

namespace buisnessLogic.Service
{
    public class ServicesService : IServicesService
    {
        public void createService(service objService)
        {
            IServicesRepository repository = new ServicesRepository();
            repository.createService(objService);
        }

        public void deleteService(service objService)
        {
            IServicesRepository repository = new ServicesRepository();
            repository.deleteService(objService);
        }

        public List<service> getServices()
        {
            IServicesRepository repository = new ServicesRepository();
            return repository.getServices();
        }

        public void updateService(service objService)
        {
            IServicesRepository repository = new ServicesRepository();
            repository.updateService(objService);
        }
    }
}
