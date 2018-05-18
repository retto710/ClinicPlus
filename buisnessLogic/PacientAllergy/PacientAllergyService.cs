using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.PacientAlleregy;
using Entities;

namespace buisnessLogic.PacientAllergy
{
    public class PacientAllergyService: IPacientAllergyService
    {
        public void CreateClinicHistory_Allergy(clinicHistory_Alergie objDoctor_Speciality)
        {
            IClinicHistory_AlergieRepository repo = new ClinicHistory_AlergieRepository();
            repo.CreateClinicHistory_Allergy(objDoctor_Speciality);
        }

        public List<clinicHistory_Alergie> GetClinicHistory_Allergies(int doctorid)
        {
            IClinicHistory_AlergieRepository repo = new ClinicHistory_AlergieRepository();
            return repo.GetClinicHistory_Allergies(doctorid);
        }

        public clinicHistory_Alergie GetClinicHistory_Allergy(int id)
        {
            IClinicHistory_AlergieRepository repo = new ClinicHistory_AlergieRepository();
            return repo.GetClinicHistory_Allergy(id);
        }
    }
}
