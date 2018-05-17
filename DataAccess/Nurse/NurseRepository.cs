﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Nurse
{
    public class NurseRepository : INurseRepository
    {
        public void CreateNurse(nurse objNurse)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                dataContext.nurses.Add(objNurse);
                dataContext.SaveChanges();
            }
        }

        public nurse GetNurseByUserId(int userid)
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.nurses
                            where c.userid == userid
                            select c;
                nurse objNurse = custs.FirstOrDefault();
                return objNurse;
            }
        }
        
        public List<nurse> GetNurses()
        {
            using (var dataContext = new FinalAppWebEntities())
            {
                //LINQ
                //return dataContext.Customers.ToList();
                var custs = from c in dataContext.nurses
                            select c;
                List<nurse> objPerson = custs.ToList();
                return objPerson;
            }
        }
    }
}
