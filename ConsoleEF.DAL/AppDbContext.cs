
using Microsoft.EntityFrameworkCore;

namespace ConsoleEF.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> students { get; set; }

        private string ConectionString => "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConectionString);
        }
    }
}
