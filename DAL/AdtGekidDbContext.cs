using Microsoft.EntityFrameworkCore;
using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.DAL
{
    public class AdtGekidDbContext : DbContext
    {
        public AdtGekidDbContext(DbContextOptions<AdtGekidDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("seroops");
            /* seed db*/
            modelBuilder.Entity<DiagnosisSafety>().HasData(_DimensionBase.ReadListFromJson<DiagnosisSafety>());
        }


        public DbSet<DiagnosisSafety> DiagnosisSafeties { get; set; }
    }
}
