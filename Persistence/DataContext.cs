using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence {
    public class DataContext : DbContext {
        // public DataContext() { }
        public DataContext(DbContextOptions options) : base (options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBName;Integrated Security=True");
        // }

        public DbSet<Activity> Activities { get; set; }
    }
}