using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccess.Speciality
{
    public interface ISpecialityRepository
    {
        void CreateSpeciality(speciality objSpeciality);
        speciality GetSpecialityByDescription(string description);
        void DeleteSpeciality(int  specialityId);
        List<speciality> GetSpecialities();
    }
}
