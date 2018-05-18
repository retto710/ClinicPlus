using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class clinicHistory_Alergie
    {
        public string alergyName
        {
            set
            {
                //Nothing at all
            }
            get
            {
                //return "alergia";
                return this.alergy.descripcion;
            }
        }
    }
}
