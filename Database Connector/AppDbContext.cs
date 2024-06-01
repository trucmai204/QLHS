using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Database_Connector
{
    public class AppDbContext : DbContext
    {
        public DbSet<HocSinh> HocSinh { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<BangDiem> BangDiem { get; set; }
        public DbSet<LopHoc> LopHoc { get; set; }
        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<KhoiLop> KhoiLop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Trusted_Connection=true;TrustServerCertificate=True;Server=TRUCMAI\\SQLEXPRESS;Database=QLHS");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
