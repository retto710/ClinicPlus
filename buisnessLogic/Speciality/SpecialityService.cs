using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Speciality;
using Entities;

namespace buisnessLogic.Speciality
{
    public class SpecialityService : ISpecialityService
    {
        public void CreateSpeciality(speciality objSpeciality)
        {
            ISpecialityRepository repository = new SpecialityRepository();
            repository.CreateSpeciality(objSpeciality);
        }

        public void DeleteSpeciality(int specialityId)
        {
            ISpecialityRepository repository = new SpecialityRepository();
            repository.DeleteSpeciality(specialityId);
        }

        public List<speciality> GetSpecialities()
        {
            ISpecialityRepository repository = new SpecialityRepository();
            return repository.GetSpecialities();
        }

        public speciality GetSpecialityByDescription(string description)
        {
            ISpecialityRepository repository = new SpecialityRepository();
            return repository.GetSpecialityByDescription(description);
        }
    }
}
