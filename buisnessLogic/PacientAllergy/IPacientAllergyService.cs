using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessLogic.PacientAllergy
{
    public interface IPacientAllergyService
    {
        void CreateClinicHistory_Allergy(clinicHistory_Alergie objDoctor_Speciality);
        clinicHistory_Alergie GetClinicHistory_Allergy(int id);
        List<clinicHistory_Alergie> GetClinicHistory_Allergies(int doctorid);
    }
}
