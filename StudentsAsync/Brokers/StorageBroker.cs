using StudentsAsync.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentsAsync.Brokers
{
    public class StorageBroker : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder
                .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StudentsDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
