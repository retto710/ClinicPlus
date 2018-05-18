using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.PacientAlleregy
{
    public class ClinicHistory_AlergieRepository : IClinicHistory_AlergieRepository
    {
        public void CreateClinicHistory_Allergy(clinicHistory_Alergie objDoctor_Speciality)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                dataContext.clinicHistory_Alergie.Add(objDoctor_Speciality);
                dataContext.SaveChanges();
            }
        }

        List<clinicHistory_Alergie> IClinicHistory_AlergieRepository.GetClinicHistory_Allergies(int doctorid)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var custs = from c in dataContext.clinicHistory_Alergie
                            where c.clinicHistoryId == doctorid
                            select c;
                List<clinicHistory_Alergie> objDoctor_Speciality = custs.ToList();
                return objDoctor_Speciality;
            }
        }

        clinicHistory_Alergie IClinicHistory_AlergieRepository.GetClinicHistory_Allergy(int id)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var custs = from c in dataContext.clinicHistory_Alergie
                            where c.id == id
                            select c;
                clinicHistory_Alergie objDoctor_Speciality = custs.FirstOrDefault();
                return objDoctor_Speciality;
            }
        }
    }
}

