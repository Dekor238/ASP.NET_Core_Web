using System.Collections.Generic;
using System.Linq;
using TS.Data.Model;
using TS.Repositories.Interfaces;

namespace TS.Repositories.Repositories
{
    public class UserRepository : IUser
    {
        public Users GetUser(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }
            using (var db = new UserDbContext())
            {
                try
                {
                    var result = db.Users.First(i => i.login == login && i.passwd == password);
                    return result;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}