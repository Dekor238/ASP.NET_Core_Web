using System.Collections.Generic;
using TS.Data.Model;

namespace TS.Repositories.Interfaces
{
    public interface IUser
    {
        public Users GetUser(string login, string password);
    }
}