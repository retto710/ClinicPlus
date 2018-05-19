using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace buisnessLogic.clinicDatee
{
    public interface IClinicDateService
    {
        void CreateClinicDate(clinicDate obj);
        List<clinicDate> GetClinicDatesByClinicHistory(int id);

        void deleteCLnicDate(clinicDate obj);
    }
}
