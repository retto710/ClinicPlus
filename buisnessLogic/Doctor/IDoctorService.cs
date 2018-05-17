using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessLogic.Doctor
{
    public interface IDoctorService
    {
        void CreateDoctor(doctor objDoctor);
        doctor GetDoctorByUserId(int userid);
        doctor GetDoctorByPersonId(int personid);
        List<doctor> GetDoctors();
    }
}
