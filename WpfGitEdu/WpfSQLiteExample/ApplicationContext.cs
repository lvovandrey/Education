using System.Data.Entity;

namespace WpfSQLiteExample
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {
        }

        public DbSet<Level> Levels { get; set; }
    }
}