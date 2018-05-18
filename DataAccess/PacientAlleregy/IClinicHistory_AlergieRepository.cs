using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.PacientAlleregy
{
    public interface IClinicHistory_AlergieRepository
    {
        void CreateClinicHistory_Allergy(clinicHistory_Alergie objDoctor_Speciality);
        clinicHistory_Alergie GetClinicHistory_Allergy(int id);
        List<clinicHistory_Alergie> GetClinicHistory_Allergies(int doctorid);

        void deleteClinicHistoryAllergy(int id);
    }
}
