using System.Collections.Generic;
using TS.Data.Model;

namespace TS.Services
{
    public interface IPersonServices
    {
        public Person Get(int id);
        public Person Search(string term);
        public IEnumerable<Person> GetPag(int skip, int take);
        public void Post();
        public void Put (int id);
        public void Delete(int id);
    }
}