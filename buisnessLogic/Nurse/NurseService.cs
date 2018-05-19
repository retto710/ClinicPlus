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

        public void DeleteNurse(int id)
        {
            INurseRepository repo = new NurseRepository();
            repo.DeleteNurse(id);
        }

        public nurse GetNurseByPersonId(int personid)
        {
            INurseRepository repo = new NurseRepository();
            return repo.GetNurseByPersonId(personid);
        }

        public nurse GetNurseByUserId(int userid)
        {
            INurseRepository repo = new NurseRepository();
            return repo.GetNurseByUserId(userid);
        }

        public List<nurse> GetNurses()
        {
            INurseRepository repo = new NurseRepository();
            return repo.GetNurses();
        }
    }
}
