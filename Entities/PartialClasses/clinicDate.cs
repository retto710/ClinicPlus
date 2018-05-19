using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class clinicDate
    {
        public string pacienteName
        {
            set
            {
                //Nothing at all
            }
            get
            {
                //return "alergia";
                return this.clinicHistory;
            }
        }
    }
}
