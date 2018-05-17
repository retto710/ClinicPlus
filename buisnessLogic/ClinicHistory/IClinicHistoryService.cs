using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessLogic.ClinicHistory
{
    public interface IClinicHistoryService
    {
        void CreateClinicHistory(clinicHistory objClinicHistory);

        clinicHistory GetClinicHistoryByPatientId(int patientid);
    }
}
