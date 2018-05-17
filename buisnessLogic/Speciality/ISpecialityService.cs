using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessLogic.Speciality
{
    public interface ISpecialityService
    {
        void CreateSpeciality(speciality objSpeciality);
        speciality GetSpecialityByDescription(string description);
        void DeleteSpeciality(int specialityId);
        List<speciality> GetSpecialities();
    }
}
