using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccess.DoctorSpeciality
{
    public interface IDoctorSpecialityRepository
    {
        void CreateDoctorSpeciality(doctor_speciality objDoctor_Speciality);
        doctor_speciality GetDoctor_Speciality(int id);
        List<doctor_speciality> GetDoctor_Specialities(int doctorid);
        List<doctor_speciality> GetDoctorsBySpeciality(int id);
    }
}
