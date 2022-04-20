using System.Collections;
using System.Collections.Generic;
using TS.Data.Model;
using TS.Repositories.Interfaces;
using TS.Repositories.Repositories;

namespace TS.Services
{
    public class PersonServices : IPersonServices
    {
        private readonly IPerson<Person> _person;

        public PersonServices(IPerson<Person> person)
        {
            _person = person;
        }

        public IEnumerator GetAll()
        {
            return _person.GetAll();
        }

        public Person Get(int id)
        {
            return _person.Get(id);
        }

        public Person Search(string term)
        {
            return _person.Search(term);
        }

        public IEnumerable<Person> GetPag(int skip, int take)
        {
            return _person.GetPag(skip, take);
        }

        public void Post(Person person)
        {
            _person.Post(person);
        }

        public void Put(int id)
        {
            _person.Put(id);
        }

        public void Delete(int id)
        {
            _person.Delete(id);
        }
    }
}