using Entities;
using Microsoft.EntityFrameworkCore;

namespace Database_Connector
{
    public class AppDbContext : DbContext
    {
        public DbSet<Class> Class { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Transcript> Transcript { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Trusted_Connection=true;TrustServerCertificate=True;Server=PHANXUANQUANG\\SQLEXPRESS;Database=QLHS");
        }
    }
}
