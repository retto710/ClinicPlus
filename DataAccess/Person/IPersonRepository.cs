using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccess.Person
{
    public interface IPersonRepository
    {
        void CreatePerson(person objPerson);
        person GetPersonByDni(int dni);
        person GetPersonById(int id);
        void UpdatePerson(person objPerson);
        void DeletePerson(int id);

        List<person> GetPersons();
    }
}
