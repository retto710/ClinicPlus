using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.clinicDatee
{
    public class ClinicDateRepository: IClinicDateRepository
    {
        public void CreateClinicDate(clinicDate obj)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                dataContext.clinicDates.Add(obj);
                dataContext.SaveChanges();
            }
        }

        public void deleteCLnicDate(clinicDate obj)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //Load customer object
                var cust = from c in dataContext.clinicDates
                           where c.id == obj.id
                           select c;
                clinicDate objCustomer = cust.FirstOrDefault();
                //Remove
                dataContext.clinicDates.Remove(objCustomer);
                //Save
                dataContext.SaveChanges();
            }
        }

        public List<clinicDate> GetClinicDates()
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var tnts = from t in dataContext.clinicDates
                           select t;
                return tnts.ToList();
            }
        }

        public List<clinicDate> GetClinicDatesAprove()
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var tnts = from t in dataContext.clinicDates
                           where t.status == true
                           select t;
                return tnts.ToList();
            }
        }
        public List<clinicDate> GetClinicDatesByClinicHistory(int id)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var tnts = from t in dataContext.clinicDates
                           where t.clinicHistorytId == id
                           select t;
                return tnts.ToList();
            }
        }

        public List<clinicDate> GetClinicDatesByDoctor(int id)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var tnts = from t in dataContext.clinicDates
                           where t.doctorId == id
                           select t;
                return tnts.ToList();
            }
        }

        public List<clinicDate> GetClinicDatesByDoctorAndStatus(int id, bool status)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var tnts = from t in dataContext.clinicDates
                           where t.status == status && t.doctorId == id
                           select t;
                return tnts.ToList();
            }
        }

        public List<clinicDate> GetClinicDatesNotAprove()
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var tnts = from t in dataContext.clinicDates
                           where t.status == false
                           select t;
                return tnts.ToList();
            }
        }
    }
}
