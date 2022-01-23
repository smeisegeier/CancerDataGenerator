using Microsoft.EntityFrameworkCore;
using Rki.CancerDataGenerator.Models;
using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;
using System.Linq;

namespace Rki.CancerDataGenerator.DAL
{
    public class AdtGekidDbContext : DbContext
    {
        public AdtGekidDbContext(DbContextOptions<AdtGekidDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("seroops");
            /* seed db*/
            modelBuilder.Entity<DiagnosisSafety>().HasData(DimensionBase.ReadListFromJson<DiagnosisSafety>());
            modelBuilder.Entity<DiseaseProgression>().HasData(DimensionBase.ReadListFromJson<DiseaseProgression>());
            modelBuilder.Entity<DistantMetastasis>().HasData(DimensionBase.ReadListFromJson<DistantMetastasis>());
            modelBuilder.Entity<Ecog>().HasData(DimensionBase.ReadListFromJson<Ecog>());
            modelBuilder.Entity<Gender>().HasData(DimensionBase.ReadListFromJson<Gender>());
            modelBuilder.Entity<Grading>().HasData(DimensionBase.ReadListFromJson<Grading>());
            modelBuilder.Entity<Histology>().HasData(DimensionBase.ReadListFromJson<Histology>());
            modelBuilder.Entity<HormonReceptor>().HasData(DimensionBase.ReadListFromJson<HormonReceptor>());
            modelBuilder.Entity<Icd>().HasData(DimensionBase.ReadListFromJson<Icd>());
            //modelBuilder.Entity<Icd>().HasData(DimensionBase.ReadListFromJson<Icd>().Where(x => x.icd_id.Substring(0, 1) == "C"));
            modelBuilder.Entity<Location>().HasData(DimensionBase.ReadListFromJson<Location>());
            modelBuilder.Entity<M>().HasData(DimensionBase.ReadListFromJson<M>());
            modelBuilder.Entity<N>().HasData(DimensionBase.ReadListFromJson<N>());
            modelBuilder.Entity<Op>().HasData(DimensionBase.ReadListFromJson<Op>());
            modelBuilder.Entity<OpIntention>().HasData(DimensionBase.ReadListFromJson<OpIntention>());
            modelBuilder.Entity<Protocol>().HasData(DimensionBase.ReadListFromJson<Protocol>());
            modelBuilder.Entity<Radiotherapy>().HasData(DimensionBase.ReadListFromJson<Radiotherapy>());
            modelBuilder.Entity<ReceptorStatus>().HasData(DimensionBase.ReadListFromJson<ReceptorStatus>());
            modelBuilder.Entity<ReportType>().HasData(DimensionBase.ReadListFromJson<ReportType>());
            modelBuilder.Entity<ResidualStatus>().HasData(DimensionBase.ReadListFromJson<ResidualStatus>());
            modelBuilder.Entity<Side>().HasData(DimensionBase.ReadListFromJson<Side>());
            modelBuilder.Entity<Substance>().HasData(DimensionBase.ReadListFromJson<Substance>());
            modelBuilder.Entity<SystemicTherapy>().HasData(DimensionBase.ReadListFromJson<SystemicTherapy>());
            modelBuilder.Entity<T>().HasData(DimensionBase.ReadListFromJson<T>());
            modelBuilder.Entity<TherapyDuration>().HasData(DimensionBase.ReadListFromJson<TherapyDuration>());
            modelBuilder.Entity<TherapyIntention>().HasData(DimensionBase.ReadListFromJson<TherapyIntention>());
            modelBuilder.Entity<TherapyLine>().HasData(DimensionBase.ReadListFromJson<TherapyLine>());
            modelBuilder.Entity<TherapyRelation>().HasData(DimensionBase.ReadListFromJson<TherapyRelation>());
            modelBuilder.Entity<TherapyStop>().HasData(DimensionBase.ReadListFromJson<TherapyStop>());
            modelBuilder.Entity<TherapyTime>().HasData(DimensionBase.ReadListFromJson<TherapyTime>());
            modelBuilder.Entity<TumorConference>().HasData(DimensionBase.ReadListFromJson<TumorConference>());
            modelBuilder.Entity<TumorStatus>().HasData(DimensionBase.ReadListFromJson<TumorStatus>());
            modelBuilder.Entity<TumorStatusDistantMetastasis>().HasData(DimensionBase.ReadListFromJson<TumorStatusDistantMetastasis>());
            modelBuilder.Entity<Uicc>().HasData(DimensionBase.ReadListFromJson<Uicc>());

            //modelBuilder.Entity<_Quote>().HasData(DimensionBase.AutoIncAllId<_Quote>(DimensionBase.ReadListFromJson<_Quote>().ToList()));
            modelBuilder.Entity<Quote>().HasData(DimensionBase.ReadListFromJson<Quote>().AutoIncAllId());
        }

        public void Init()
        {
            Icd.MaxId = GetAll<Icd>().Count();
            //Gender.MaxId = Genders.Count();
        }

        public IEnumerable<T> GetAll<T>() where T : DimensionBase => Set<T>();
        public IEnumerable<T> GetAllOrdered<T>() where T : DimensionBase => GetAll<T>().OrderBy(x => x.Id);
        public T GetById<T>(int? id) where T : DimensionBase => Set<T>().FirstOrDefault(x => x.Id == id);
        public T GetByIndex<T>(int index) where T : DimensionBase => GetAll<T>().ToList()[index];
        public T GetByIndex<T>(int index, List<T> subset) where T : DimensionBase => subset[index];

        public List<Icd> GetIcdSubsetByChapter(string chapter) => GetAll<Icd>().Where(x=>x.icd_chapter == chapter).ToList();

        public List<Location> GetLocations(string name) => GetAll<Location>().Where(x => x.location_state == name)?.ToList();


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
