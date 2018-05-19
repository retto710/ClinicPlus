using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.clinicDatee
{
    public interface IClinicDateRepository
    {
        void CreateClinicDate(clinicDate obj);
        List<clinicDate> GetClinicDatesByClinicHistory(int id);

        void deleteCLnicDate(clinicDate obj);


        List<clinicDate> GetClinicDates();

        List<clinicDate> GetClinicDatesNotAprove();

        List<clinicDate> GetClinicDatesAprove();

        List<clinicDate> GetClinicDatesByDoctor(int id);

        List<clinicDate> GetClinicDatesByDoctorAndStatus(int id, bool status);
        void updateClinicDate(clinicDate obj);
    }
}
