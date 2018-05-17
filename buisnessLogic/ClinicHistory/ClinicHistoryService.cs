using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ClinicHistory;
using Entities;

namespace buisnessLogic.ClinicHistory
{
    public class ClinicHistoryService: IClinicHistoryService
    {
        public void CreateClinicHistory(clinicHistory objClinicHistory)
        {
            IClinicHistoryRepository repo = new ClinicHistoryRepository();
            repo.CreateClinicHistory(objClinicHistory);
        }

        public clinicHistory GetClinicHistoryByPatientId(int patientid)
        {
            IClinicHistoryRepository repo = new ClinicHistoryRepository();
            return repo.GetClinicHistoryByPatientId(patientid);
        }
    }
}
