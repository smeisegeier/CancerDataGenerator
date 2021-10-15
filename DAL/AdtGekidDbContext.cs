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
            modelBuilder.Entity<DiseaseProgression>().HasData(_DimensionBase.ReadListFromJson<DiseaseProgression>());
            modelBuilder.Entity<DistantMetastasis>().HasData(_DimensionBase.ReadListFromJson<DistantMetastasis>());
            modelBuilder.Entity<Ecog>().HasData(_DimensionBase.ReadListFromJson<Ecog>());
            modelBuilder.Entity<Gender>().HasData(_DimensionBase.ReadListFromJson<Gender>());
            modelBuilder.Entity<Grading>().HasData(_DimensionBase.ReadListFromJson<Grading>());
            modelBuilder.Entity<Histology>().HasData(_DimensionBase.ReadListFromJson<Histology>());
            modelBuilder.Entity<HormonReceptor>().HasData(_DimensionBase.ReadListFromJson<HormonReceptor>());
            modelBuilder.Entity<Icd>().HasData(_DimensionBase.ReadListFromJson<Icd>());
            modelBuilder.Entity<Location>().HasData(_DimensionBase.ReadListFromJson<Location>());
            modelBuilder.Entity<M>().HasData(_DimensionBase.ReadListFromJson<M>());
            modelBuilder.Entity<N>().HasData(_DimensionBase.ReadListFromJson<N>());
            modelBuilder.Entity<Op>().HasData(_DimensionBase.ReadListFromJson<Op>());
            modelBuilder.Entity<OpIntention>().HasData(_DimensionBase.ReadListFromJson<OpIntention>());
            modelBuilder.Entity<Protocol>().HasData(_DimensionBase.ReadListFromJson<Protocol>());
            modelBuilder.Entity<Radiotherapy>().HasData(_DimensionBase.ReadListFromJson<Radiotherapy>());
            modelBuilder.Entity<ReceptorStatus>().HasData(_DimensionBase.ReadListFromJson<ReceptorStatus>());
            modelBuilder.Entity<ReportType>().HasData(_DimensionBase.ReadListFromJson<ReportType>());
            modelBuilder.Entity<ResidualStatus>().HasData(_DimensionBase.ReadListFromJson<ResidualStatus>());
            modelBuilder.Entity<Side>().HasData(_DimensionBase.ReadListFromJson<Side>());
            modelBuilder.Entity<Substance>().HasData(_DimensionBase.ReadListFromJson<Substance>());
            modelBuilder.Entity<SystemicTherapy>().HasData(_DimensionBase.ReadListFromJson<SystemicTherapy>());
            modelBuilder.Entity<T>().HasData(_DimensionBase.ReadListFromJson<T>());
            modelBuilder.Entity<TherapyDuration>().HasData(_DimensionBase.ReadListFromJson<TherapyDuration>());
            modelBuilder.Entity<TherapyIntention>().HasData(_DimensionBase.ReadListFromJson<TherapyIntention>());
            modelBuilder.Entity<TherapyLine>().HasData(_DimensionBase.ReadListFromJson<TherapyLine>());
            modelBuilder.Entity<TherapyRelation>().HasData(_DimensionBase.ReadListFromJson<TherapyRelation>());
            modelBuilder.Entity<TherapyStop>().HasData(_DimensionBase.ReadListFromJson<TherapyStop>());
            modelBuilder.Entity<TherapyTime>().HasData(_DimensionBase.ReadListFromJson<TherapyTime>());
            modelBuilder.Entity<TumorConference>().HasData(_DimensionBase.ReadListFromJson<TumorConference>());
            modelBuilder.Entity<TumorStatus>().HasData(_DimensionBase.ReadListFromJson<TumorStatus>());
            modelBuilder.Entity<TumorStatusDistantMetastasis>().HasData(_DimensionBase.ReadListFromJson<TumorStatusDistantMetastasis>());
            modelBuilder.Entity<Uicc>().HasData(_DimensionBase.ReadListFromJson<Uicc>());

        }

        public DbSet<DiagnosisSafety> DiagnosisSafeties { get; set; }
        public DbSet<DiseaseProgression> DiseaseProgressions { get; set; }
        public DbSet<DistantMetastasis> DistantMetastases { get; set; }
        public DbSet<Ecog> Ecogs { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Grading> Gradings { get; set; }
        public DbSet<Histology> Histologies { get; set; }
        public DbSet<HormonReceptor> HormonReceptors { get; set; }
        public DbSet<Icd> Icds { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<M> Ms { get; set; }
        public DbSet<Op> Ops { get; set; }
        public DbSet<OpIntention> OpIntentions { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<Radiotherapy> Radiotherapies { get; set; }
        public DbSet<ReceptorStatus> ReceptorStatuses { get; set; }
        public DbSet<ReportType> ReportTypes { get; set; }
        public DbSet<Side> Sides { get; set; }
        public DbSet<T> Ts { get; set; }
        public DbSet<TherapyDuration> TherapyDurations { get; set; }
        public DbSet<TherapyIntention> TherapyIntentions { get; set; }
        public DbSet<TherapyLine> TherapyLines { get; set; }
        public DbSet<TherapyRelation> TherapyRelations { get; set; }
        public DbSet<TherapyStop> TherapyStops { get; set; }
        public DbSet<TherapyTime> TherapyTimes { get; set; }
        public DbSet<TumorConference> TumorConferences { get; set; }
        public DbSet<TumorStatus> TumorStatuses { get; set; }
        public DbSet<TumorStatusDistantMetastasis> TumorStatusDistantMetastases { get; set; }
        public DbSet<Uicc> Uiccs { get; set; }

    }
}
