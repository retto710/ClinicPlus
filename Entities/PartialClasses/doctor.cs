using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class doctor
    {
        public string doctorName
        {
            set
            {
                //Nothing at all
            }
            get
            {
                //return "alergia";
                return this.person.name;
            }
        }
    }
}
