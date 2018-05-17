﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessLogic.DoctorSpeciality
{
    public interface IDoctorSpecialityService
    {
        void CreateDoctorSpeciality(doctor_speciality objDoctor_Speciality);
        doctor_speciality GetDoctor_Speciality(int id);
        List<doctor_speciality> GetDoctor_Specialities(int doctorid);
    }
}
