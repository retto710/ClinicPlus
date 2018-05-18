using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Allergy;
using Entities;

namespace buisnessLogic.Allergy
{
    public class AllergyService : IAllergySerivce
    {
        public List<alergy> getAlergies()
        {
            IAllergyRepository repo = new AllergyRepository();
            return repo.getAlergies();
        }
    }
}
