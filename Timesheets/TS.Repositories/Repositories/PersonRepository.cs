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
    public class PersonRepository<T> : IPerson<T> where T : class
    {
        
        // public static IServiceCollection AddSqlRepositories(IServiceCollection container)
        // {
        //     container.AddSingleton<UserDbContext>();
        //     return container;
        // }

        public IEnumerator GetAll()
        {
            IEnumerator result2 = null;
            using (var db = new UserDbContext())
            {
                var command = db.Database.GetDbConnection().CreateCommand();
                command.CommandText = "select * from Persons";
                db.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                       result2 =  result.GetEnumerator();
                    }
                }
                
            }
            return result2;
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
                db.Add(person);
                db.SaveChanges();
            }
        }

        public void Put(int id)
        {
            
        }

        public void Delete(int id)
        {
            var searchresult = Get(id);
            using (var db = new UserDbContext())
            {
                db.Remove(searchresult);
                db.SaveChanges();
            }
        }
    }
}