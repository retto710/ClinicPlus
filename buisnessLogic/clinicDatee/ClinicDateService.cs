using DataAccess.clinicDatee;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessLogic.clinicDatee
{
    public class ClinicDateService : IClinicDateService
    {
        public void CreateClinicDate(clinicDate obj)
        {
            IClinicDateRepository repo = new ClinicDateRepository();
            repo.CreateClinicDate(obj);
        }

        public void deleteCLnicDate(clinicDate obj)
        {
            IClinicDateRepository repo = new ClinicDateRepository();
            repo.deleteCLnicDate(obj);
        }

        public List<clinicDate> GetClinicDatesByClinicHistory(int id)
        {
            IClinicDateRepository repo = new ClinicDateRepository();
            return repo.GetClinicDatesByClinicHistory(id);
        }
    }
}
