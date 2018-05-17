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
            IPersonRepository repo = new PersonRepository();
            repo.DeletePerson(id);
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

        public List<person> GetPersons()
        {
            IPersonRepository repo = new PersonRepository();
            return repo.GetPersons();
        }

        public person GetPersonById(int id)
        {
            IPersonRepository repo = new PersonRepository();
            return repo.GetPersonById(id);
        }
    }
}
