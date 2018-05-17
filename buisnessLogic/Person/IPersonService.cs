using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessLogic.Person
{
    public interface IPersonService
    {
        void CreatePerson(person objPerson);
        person GetPersonByDni(int dni);
        person GetPersonById(int id);
        void UpdatePerson(person objPerson);
        void DeletePerson(int id);
        List<person> GetPersons();
    }
}
