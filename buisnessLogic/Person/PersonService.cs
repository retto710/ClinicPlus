using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.Person;
namespace buisnessLogic.Person
{
    public class PersonService : IPersonService
    {
        public void CreatePerson(person objPerson)
        {
            IPersonRepository repo = new PersonRepository();
            repo.CreatePerson(objPerson);
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public person GetPersonByDni(int dni)
        {
            IPersonRepository repo = new PersonRepository();
            return repo.GetPersonByDni(dni);
        }

        public void UpdatePerson(person objPerson)
        {
            throw new NotImplementedException();
        }
    }
}
