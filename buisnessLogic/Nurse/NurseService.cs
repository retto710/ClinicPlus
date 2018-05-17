using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.Nurse;
namespace buisnessLogic.Nurse
{
    public class NurseService : INurseService
    {
        public void CreateNurse(nurse objNurse)
        {
            INurseRepository repo = new NurseRepository();
            repo.CreateNurse(objNurse);
        }

        public nurse GetNurseByUserId(int userid)
        {
            INurseRepository repo = new NurseRepository();
            return repo.GetNurseByUserId(userid);
        }
    }
}
