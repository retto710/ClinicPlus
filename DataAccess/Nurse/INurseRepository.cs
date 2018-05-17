﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Nurse
{
    public interface INurseRepository
    {
        void CreateNurse(nurse objNurse);
        nurse GetNurseByUserId(int userid);
        nurse GetNurseByPersonId(int personid);
        void DeleteNurse(int id);
        List<nurse> GetNurses();
    }
}
