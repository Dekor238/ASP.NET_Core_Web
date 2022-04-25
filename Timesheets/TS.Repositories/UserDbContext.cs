using Microsoft.EntityFrameworkCore;
using TS.Data.Model;

namespace TS.Repositories
{
    public class UserDbContext :DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // тут укажем полный путь к файлу БД иначе не работает, т.к. используется Мак...
            optionsBuilder.UseSqlite(
                "Data Source=/Users/dekor238/RiderProjects/Timesheets/TS.Repositories/timesheets.db"
                );
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        
        
    }
}