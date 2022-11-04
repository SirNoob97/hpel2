using hpel2_mx.Models;
using Microsoft.EntityFrameworkCore;

namespace hpel2_mx.Data
{
    public class HpelContext : DbContext
    {
        public HpelContext(DbContextOptions<HpelContext> opts) : base(opts) { }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Claim> Claims { get; set; }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().ToTable("Owners");
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
            modelBuilder.Entity<Claim>().ToTable("Claims");
        }
    }
}
