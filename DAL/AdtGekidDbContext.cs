using Microsoft.EntityFrameworkCore;
using Rki.CancerDataModel.Models;
using Rki.CancerDataModel.Models.Dimensions;
using System.Collections.Generic;
using System.Linq;
using Rki.CancerDataGenerator.StaticHelper;

namespace Rki.CancerDataGenerator.DAL
{
    public class AdtGekidDbContext : DbContext
    {
        public AdtGekidDbContext(DbContextOptions<AdtGekidDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("seroops");
            /* seed db*/
            modelBuilder.Entity<DiagnosisSafety>().HasData(Json.ReadListFromJson<DiagnosisSafety>());
            modelBuilder.Entity<DiseaseProgression>().HasData(Json.ReadListFromJson<DiseaseProgression>());
            modelBuilder.Entity<DistantMetastasis>().HasData(Json.ReadListFromJson<DistantMetastasis>());
            modelBuilder.Entity<Ecog>().HasData(Json.ReadListFromJson<Ecog>());
            modelBuilder.Entity<Gender>().HasData(Json.ReadListFromJson<Gender>());
            modelBuilder.Entity<Grading>().HasData(Json.ReadListFromJson<Grading>());
            modelBuilder.Entity<Histology>().HasData(Json.ReadListFromJson<Histology>());
            modelBuilder.Entity<HormonReceptor>().HasData(Json.ReadListFromJson<HormonReceptor>());
            modelBuilder.Entity<Icd>().HasData(Json.ReadListFromJson<Icd>());
            //modelBuilder.Entity<Icd>().HasData(Json.ReadListFromJson<Icd>().Where(x => x.icd_id.Substring(0, 1) == "C"));
            modelBuilder.Entity<Location>().HasData(Json.ReadListFromJson<Location>());
            modelBuilder.Entity<M>().HasData(Json.ReadListFromJson<M>());
            modelBuilder.Entity<N>().HasData(Json.ReadListFromJson<N>());
            modelBuilder.Entity<Ops>().HasData(Json.ReadListFromJson<Ops>());
            modelBuilder.Entity<OpIntention>().HasData(Json.ReadListFromJson<OpIntention>());
            modelBuilder.Entity<Protocol>().HasData(Json.ReadListFromJson<Protocol>());
            modelBuilder.Entity<Radiotherapy>().HasData(Json.ReadListFromJson<Radiotherapy>());
            modelBuilder.Entity<ReceptorStatus>().HasData(Json.ReadListFromJson<ReceptorStatus>());
            modelBuilder.Entity<ReportType>().HasData(Json.ReadListFromJson<ReportType>());
            modelBuilder.Entity<ResidualStatus>().HasData(Json.ReadListFromJson<ResidualStatus>());
            modelBuilder.Entity<Side>().HasData(Json.ReadListFromJson<Side>());
            modelBuilder.Entity<Substance>().HasData(Json.ReadListFromJson<Substance>());
            modelBuilder.Entity<SystemicTherapy>().HasData(Json.ReadListFromJson<SystemicTherapy>());
            modelBuilder.Entity<T>().HasData(Json.ReadListFromJson<T>());
            modelBuilder.Entity<TherapyDuration>().HasData(Json.ReadListFromJson<TherapyDuration>());
            modelBuilder.Entity<TherapyIntention>().HasData(Json.ReadListFromJson<TherapyIntention>());
            modelBuilder.Entity<TherapyLine>().HasData(Json.ReadListFromJson<TherapyLine>());
            modelBuilder.Entity<TherapyRelation>().HasData(Json.ReadListFromJson<TherapyRelation>());
            modelBuilder.Entity<TherapyStop>().HasData(Json.ReadListFromJson<TherapyStop>());
            modelBuilder.Entity<TherapyTime>().HasData(Json.ReadListFromJson<TherapyTime>());
            modelBuilder.Entity<TumorConference>().HasData(Json.ReadListFromJson<TumorConference>());
            modelBuilder.Entity<TumorStatus>().HasData(Json.ReadListFromJson<TumorStatus>());
            modelBuilder.Entity<TumorStatusDistantMetastasis>().HasData(Json.ReadListFromJson<TumorStatusDistantMetastasis>());
            modelBuilder.Entity<Uicc>().HasData(Json.ReadListFromJson<Uicc>());

            //modelBuilder.Entity<_Quote>().HasData(DimensionBase.AutoIncAllId<_Quote>(Json.ReadListFromJson<_Quote>().ToList()));
            modelBuilder.Entity<Quote>().HasData(Json.ReadListFromJson<Quote>().AutoIncAllId());
        }

 
        public IEnumerable<T> GetAll<T>() where T : DimensionBase => Set<T>();
        public IEnumerable<T> GetAllOrdered<T>() where T : DimensionBase => GetAll<T>().OrderBy(x => x.Id);
        public T GetById<T>(int id) where T : DimensionBase => Set<T>().FirstOrDefault(x => x.Id == id);
        public T GetByIndex<T>(int index) where T : DimensionBase => GetAll<T>().ToList()[index];
        public T GetByIndex<T>(int index, List<T> subset) where T : DimensionBase => subset[index];
        public List<T> GetByName<T>(string name) where T : DimensionBase => GetAll<T>()
            .Where(x => x.Name.ToLower().StartsWith(name.ToLower()))?
            .ToList();
        public int AddItem<T>(T item) where T : DimensionBase
        {
            Set<T>().Add(item);
            SaveChanges();
            return item.Id;
        }
        public int DeleteItem<T>(T item) where T : DimensionBase
        {
            var id = item.Id;
            Set<T>().Remove(item);
            SaveChanges();
            return id;
        }
        public int DeleteItem<T>(int id) where T : DimensionBase
        {
            if (!ExistsItemWithId<T>(id))
                return 0;
            return DeleteItem(GetById<T>(id));
        }

        public int UpdateItem<T>(T item) where T : DimensionBase
        {
            if (!ExistsItemWithId<T>(item.Id))
                return 0;

            Entry(item).State = EntityState.Modified;
            try
            {
                SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return item.Id;
        }

        public bool ExistsItemWithId<T>(int id) where T : DimensionBase => Set<T>().Any(x => x.Id == id);

        public List<Icd> GetIcdSubsetByChapter(string chapter) => 
            GetAll<Icd>().Where(x => x.icd_chapter == chapter && x.icd_chapter != x.icd_id).ToList();

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
        public DbSet<Ops> Ops { get; set; }
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
