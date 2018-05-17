using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessLogic.Nurse
{
    public interface INurseService
    {
        void CreateNurse(nurse objNurse);
        nurse GetNurseByUserId(int userid);
    }
}
