using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Service
{
    public interface IServicesRepository
    {
        void createService(service objService);

        List<service> getServices();

        void deleteService(service objService);

        void updateService(service objService);
    }
}
