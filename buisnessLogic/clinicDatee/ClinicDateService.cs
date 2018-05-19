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

        public List<clinicDate> GetClinicDates()
        {
            IClinicDateRepository repo = new ClinicDateRepository();
            return repo.GetClinicDates();
        }

        public List<clinicDate> GetClinicDatesAprove()
        {
            IClinicDateRepository repo = new ClinicDateRepository();
            return repo.GetClinicDatesAprove();
        }

        public List<clinicDate> GetClinicDatesByClinicHistory(int id)
        {
            IClinicDateRepository repo = new ClinicDateRepository();
            return repo.GetClinicDatesByClinicHistory(id);
        }

        public List<clinicDate> GetClinicDatesByDoctor(int id)
        {
            IClinicDateRepository repo = new ClinicDateRepository();
            return repo.GetClinicDatesByDoctor(id);
        }

        public List<clinicDate> GetClinicDatesByDoctorAndStatus(int id, bool status)
        {
            IClinicDateRepository repo = new ClinicDateRepository();
            return repo.GetClinicDatesByDoctorAndStatus(id,status);
        }

        public List<clinicDate> GetClinicDatesNotAprove()
        {
            IClinicDateRepository repo = new ClinicDateRepository();
            return repo.GetClinicDatesNotAprove();
        }

        public void updateClinicDate(clinicDate obj)
        {
            IClinicDateRepository repo = new ClinicDateRepository();
            repo.updateClinicDate(obj);
        }
    }
}
