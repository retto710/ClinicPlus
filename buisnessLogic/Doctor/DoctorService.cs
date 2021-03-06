﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.Doctor;
namespace buisnessLogic.Doctor
{
    public class DoctorService : IDoctorService
    {
        public void CreateDoctor(doctor objDoctor)
        {
            IDoctorRepository repo = new DoctorRepository();
            repo.CreateDoctor(objDoctor);
        }

        public void DeleteDoctor(int id)
        {
            IDoctorRepository repo = new DoctorRepository();
            repo.DeleteDoctor(id);
        }

        public doctor GetDoctorByPersonId(int personid)
        {
            IDoctorRepository repo = new DoctorRepository();
            return repo.GetDoctorByPersonId(personid);
        }

        public doctor GetDoctorByUserId(int userid)
        {
            IDoctorRepository repo = new DoctorRepository();
            return repo.GetDoctorByUserId(userid);
        }

        public List<doctor> GetDoctors()
        {
            IDoctorRepository repo = new DoctorRepository();
            return repo.GetDoctors();
        }
    }
}
