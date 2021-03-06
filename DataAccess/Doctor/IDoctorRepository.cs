﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Doctor
{
    public interface IDoctorRepository
    {
        void CreateDoctor(doctor objDoctor);
        doctor GetDoctorByUserId(int userid);
        doctor GetDoctorByPersonId(int personid);
        List<doctor> GetDoctors();
        void DeleteDoctor(int id);
    }
}
