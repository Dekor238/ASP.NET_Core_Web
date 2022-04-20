using System.Collections;
using System.Collections.Generic;
using TS.Data.Model;

namespace TS.Services
{
    public interface IPersonServices
    {
        public IEnumerator GetAll();
        public Person Get(int id);
        public Person Search(string term);
        public IEnumerable<Person> GetPag(int skip, int take);
        public void Post(Person person);
        public void Put (int id);
        public void Delete(int id);
    }
}