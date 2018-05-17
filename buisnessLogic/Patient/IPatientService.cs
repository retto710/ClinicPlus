using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessLogic.Patient
{
    public interface IPatientService
    {
        List<patient> GetPatients();
    }
}
