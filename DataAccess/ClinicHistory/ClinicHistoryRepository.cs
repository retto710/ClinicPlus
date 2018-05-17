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
    }
}
