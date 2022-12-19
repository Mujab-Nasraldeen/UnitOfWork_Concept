using Microsoft.EntityFrameworkCore;
using UOW.Models;

namespace UOW.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        //The DbSet property will help to create the table which adds with it by using the EF Core
        public virtual DbSet<Employee> Employees { get; set; }

        //OnModelCreating method provides the ability for us to manage the table properties of the tables in the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
