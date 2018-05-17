using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DoctorSpeciality;
namespace buisnessLogic.DoctorSpeciality
{
    public class DoctorSpecialityService : IDoctorSpecialityService
    {
        public void CreateDoctorSpeciality(doctor_speciality objDoctor_Speciality)
        {
            IDoctorSpecialityRepository repo = new DoctorSpecialityRepository();
            repo.CreateDoctorSpeciality(objDoctor_Speciality);
        }

        public List<doctor_speciality> GetDoctor_Specialities(int doctorid)
        {
            IDoctorSpecialityRepository repo = new DoctorSpecialityRepository();
            return repo.GetDoctor_Specialities(doctorid);
        }

        public doctor_speciality GetDoctor_Speciality(int id)
        {
            IDoctorSpecialityRepository repo = new DoctorSpecialityRepository();
            return repo.GetDoctor_Speciality(id);
        }
    }
}
