using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TS.Data.Model;
using TS.Repositories.Interfaces;

namespace TS.Repositories.Repositories
{
    public class PersonRepository : IPerson
    {
        public IList<Person> GetAll()
        {
            using (var db = new UserDbContext())
            {
                var result = db.Persons.ToList();
                return result;
            }
        }

        public Person? Get(int id)
        {
            using (var db = new UserDbContext())
            {
                var result = db.Persons.First(i => i.Id == id);
                return result;
            }
        }

        public Person? Search(string term)
        {
            using (var db = new UserDbContext())
            {
                var result = db.Persons.First(i => i.FirstName == term);
                return result;
            }
        }

        public IEnumerable<Person> GetPag(int skip, int take)
        {
            //var result =  dataPerson.Skip(skip * take).Take(take).ToList();
            return null;
        }

        public void Post(Person person) // добавляем нового Person в базу
        {
            using (var db = new UserDbContext())
            {
                db.Persons.Add(person);
                db.SaveChanges();
            }
        }

        public void Put(int id)
        {
            using (var db = new UserDbContext())
            {
                var persToUpdate = db.Persons.Find(id);
            }
        }

        public void Delete(int id)
        {
            var searchresult = Get(id);
            using (var db = new UserDbContext())
            {
                if (searchresult != null) db.Persons.Remove(searchresult);
                db.SaveChanges();
            }
        }
    }
}