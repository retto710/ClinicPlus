using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.ClinicHistory
{
    public class ClinicHistoryRepository : IClinicHistoryRepository
    {
        public void CreateClinicHistory(clinicHistory objClinicHistory)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                dataContext.clinicHistories.Add(objClinicHistory);
                dataContext.SaveChanges();
            }
        }
        public clinicHistory GetClinicHistoryByPatientId(int patientid)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var custs = from c in dataContext.clinicHistories
                            where c.patientId == patientid
                            select c;
                clinicHistory objCH = custs.FirstOrDefault();
                return objCH;
            }
        }

        public void UpdateClinicHistory(clinicHistory objClinicHistory)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var trs = from t in dataContext.clinicHistories
                          where t.id == objClinicHistory.id
                          select t;
                clinicHistory transaction = trs.FirstOrDefault();
                //Update field by field
                transaction.date = objClinicHistory.date;
                transaction.weight = objClinicHistory.weight;
                transaction.height = objClinicHistory.height;
                transaction.description = objClinicHistory.description;
                dataContext.SaveChanges();
            }
        }
    }
}
