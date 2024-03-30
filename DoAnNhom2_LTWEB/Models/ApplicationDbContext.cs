using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DoAnNhom2_LTWEB.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<NHATUYENDUNG> NHATUYENDUNGs { get; set; }
        public DbSet<PHIEUDANGTUYEN> PHIEUDANGTUYENs { get; set; }
        public DbSet<TINH> TINHs { get; set; }
        public DbSet<LOAINGANH> LOAINGANHs { get; set; }
        public DbSet<NGANHUNGTUYEN> NGANHUNGTUYENs { get; set; }
        public DbSet<BANGDANGTUYEN> BANGDANGTUYENs { get; set; }
        public DbSet<DONUNGTUYEN> DONUNGTUYENs { get; set; }
        public DbSet<MUCLUONG> MUCLUONGs { get; set; }
        public DbSet<KINHNGHIEM> KINHNGHIEMs { get; set; }    

    }
}
