using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Allergy
{
    public class AllergyRepository : IAllergyRepository
    {
        public List<alergy> getAlergies()
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                var tnts = from t in dataContext.alergies
                           select t;
                return tnts.ToList();
            }
        }
    }
}
