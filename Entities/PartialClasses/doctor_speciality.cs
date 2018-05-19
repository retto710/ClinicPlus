using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class doctor_speciality
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
                return this.doctor.id.ToString();
            }
        }


        public string specialityName
        {
            set
            {
                //Nothing at all
            }
            get
            {
                //return "alergia";
                return this.speciality.description;
            }
        }
    }
}
