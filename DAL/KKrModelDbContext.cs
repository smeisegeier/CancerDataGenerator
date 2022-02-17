using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rki.CancerDataGenerator.Models.KKrModel_DEPR;

#nullable disable

namespace Rki.CancerDataGenerator.DAL
{
    public partial class KKrModelDbContext : DbContext
    {
        public KKrModelDbContext()
        {
        }

        public KKrModelDbContext(DbContextOptions<KKrModelDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FactCase> FactCases { get; set; }
        public virtual DbSet<FactCaseDistantMetastase> FactCaseDistantMetastases { get; set; }
        public virtual DbSet<FactCaseOperation> FactCaseOperations { get; set; }
        public virtual DbSet<FactCaseRadiotherapy> FactCaseRadiotherapies { get; set; }
        public virtual DbSet<FactCaseReportType> FactCaseReportTypes { get; set; }
        public virtual DbSet<FactCaseSystemicTherapy> FactCaseSystemicTherapies { get; set; }
        public virtual DbSet<FactCaseTumorConference> FactCaseTumorConferences { get; set; }
        public virtual DbSet<FactModuleBreastCancer> FactModuleBreastCancers { get; set; }
        public virtual DbSet<FactOperationAdditionalOp> FactOperationAdditionalOps { get; set; }
        public virtual DbSet<FactProtocolSubstance> FactProtocolSubstances { get; set; }
        public virtual DbSet<FactSurvivalAnalysis> FactSurvivalAnalyses { get; set; }
        public virtual DbSet<FactSystemicTherapySubstance> FactSystemicTherapySubstances { get; set; }
        public virtual DbSet<SfAge> SfAges { get; set; }
        public virtual DbSet<SfCareProvider> SfCareProviders { get; set; }
        public virtual DbSet<SfCondensedHormoneReceptorStatus> SfCondensedHormoneReceptorStatuses { get; set; }
        public virtual DbSet<SfDate> SfDates { get; set; }
        public virtual DbSet<SfDiagnosisSafety> SfDiagnosisSafeties { get; set; }
        public virtual DbSet<SfDiseaseProgression> SfDiseaseProgressions { get; set; }
        public virtual DbSet<SfDistantMetastase> SfDistantMetastases { get; set; }
        public virtual DbSet<SfEcog> SfEcogs { get; set; }
        public virtual DbSet<SfGender> SfGenders { get; set; }
        public virtual DbSet<SfGrading> SfGradings { get; set; }
        public virtual DbSet<SfHistology> SfHistologies { get; set; }
        public virtual DbSet<SfHormoneReceptorStatus> SfHormoneReceptorStatuses { get; set; }
        public virtual DbSet<SfIcd> SfIcds { get; set; }
        public virtual DbSet<SfLocation> SfLocations { get; set; }
        public virtual DbSet<SfOp> SfOps { get; set; }
        public virtual DbSet<SfOpIntention> SfOpIntentions { get; set; }
        public virtual DbSet<SfProtocol> SfProtocols { get; set; }
        public virtual DbSet<SfRadiotherapy> SfRadiotherapies { get; set; }
        public virtual DbSet<SfReferencePopulation> SfReferencePopulations { get; set; }
        public virtual DbSet<SfReportType> SfReportTypes { get; set; }
        public virtual DbSet<SfResidualStatus> SfResidualStatuses { get; set; }
        public virtual DbSet<SfSide> SfSides { get; set; }
        public virtual DbSet<SfSubstance> SfSubstances { get; set; }
        public virtual DbSet<SfSurvivalAnalysisType> SfSurvivalAnalysisTypes { get; set; }
        public virtual DbSet<SfSystemicTherapy> SfSystemicTherapies { get; set; }
        public virtual DbSet<SfTherapyDuration> SfTherapyDurations { get; set; }
        public virtual DbSet<SfTherapyIntention> SfTherapyIntentions { get; set; }
        public virtual DbSet<SfTherapyLine> SfTherapyLines { get; set; }
        public virtual DbSet<SfTherapyRelation> SfTherapyRelations { get; set; }
        public virtual DbSet<SfTherapyStop> SfTherapyStops { get; set; }
        public virtual DbSet<SfTherapyTimeRelation> SfTherapyTimeRelations { get; set; }
        public virtual DbSet<SfTnmM> SfTnmMs { get; set; }
        public virtual DbSet<SfTnmN> SfTnmNs { get; set; }
        public virtual DbSet<SfTnmT> SfTnmTs { get; set; }
        public virtual DbSet<SfTumorConference> SfTumorConferences { get; set; }
        public virtual DbSet<SfTumorStatus> SfTumorStatuses { get; set; }
        public virtual DbSet<SfTumorStatusDistantMetastase> SfTumorStatusDistantMetastases { get; set; }
        public virtual DbSet<SfUicc> SfUiccs { get; set; }

        // TODO machinename -> config -> managing conn strings
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=XXX;Database=KKrModel;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<FactCase>(entity =>
            {
                entity.HasKey(e => e.CaseId)
                    .HasName("fact_case_pk");

                entity.ToTable("fact_case", "dbo");

                entity.Property(e => e.CaseId)
                    .ValueGeneratedNever()
                    .HasColumnName("case_id");

                entity.Property(e => e.CareProvider).HasColumnName("care_provider");

                entity.Property(e => e.DeathAge).HasColumnName("death_age");

                entity.Property(e => e.DiagnosisAge).HasColumnName("diagnosis_age");

                entity.Property(e => e.DiagnosisDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("diagnosis_date");

                entity.Property(e => e.DiagnosisSafety).HasColumnName("diagnosis_safety");

                entity.Property(e => e.DiseaseProgression)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("disease_progression");

                entity.Property(e => e.Ecog)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ecog");

                entity.Property(e => e.Grading)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grading");

                entity.Property(e => e.Histology)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("histology");

                entity.Property(e => e.IcdMainPrimary)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("icd_main_primary");

                entity.Property(e => e.NumberOfAffectedLymphNodes).HasColumnName("number_of_affected_lymph_nodes");

                entity.Property(e => e.NumberOfExaminedLymphNodes).HasColumnName("number_of_examined_lymph_nodes");

                entity.Property(e => e.NumberOfExaminedSentinelLymphNodes).HasColumnName("number_of_examined_sentinel_lymph_nodes");

                entity.Property(e => e.NumberOfLymphNodesRemoved).HasColumnName("number_of_lymph_nodes_removed");

                entity.Property(e => e.Patient).HasColumnName("patient");

                entity.Property(e => e.PatientGender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("patient_gender");

                entity.Property(e => e.PatientResidence)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("patient_residence");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("side");

                entity.Property(e => e.TnmM)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("tnm_m");

                entity.Property(e => e.TnmN)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("tnm_n");

                entity.Property(e => e.TnmT)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("tnm_t");

                entity.Property(e => e.TumorStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tumor_status");

                entity.Property(e => e.TumorStatusDistantMetastases)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tumor_status_distant_metastases");

                entity.Property(e => e.Uicc)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("uicc");

                entity.HasOne(d => d.CareProviderNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.CareProvider)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_fk_care_provider");

                entity.HasOne(d => d.DeathAgeNavigation)
                    .WithMany(p => p.FactCaseDeathAgeNavigations)
                    .HasForeignKey(d => d.DeathAge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_fk_death_age");

                entity.HasOne(d => d.DiagnosisAgeNavigation)
                    .WithMany(p => p.FactCaseDiagnosisAgeNavigations)
                    .HasForeignKey(d => d.DiagnosisAge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_fk_diagnosis_age");

                entity.HasOne(d => d.DiagnosisDateNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.DiagnosisDate)
                    .HasConstraintName("fact_case_fk_diagnosis_date");

                entity.HasOne(d => d.DiagnosisSafetyNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.DiagnosisSafety)
                    .HasConstraintName("fact_case_fk_diagnosis_safety");

                entity.HasOne(d => d.DiseaseProgressionNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.DiseaseProgression)
                    .HasConstraintName("fact_case_fk_disease_progression");

                entity.HasOne(d => d.EcogNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.Ecog)
                    .HasConstraintName("fact_case_fk_ecog");

                entity.HasOne(d => d.GradingNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.Grading)
                    .HasConstraintName("fact_case_fk_grading");

                entity.HasOne(d => d.HistologyNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.Histology)
                    .HasConstraintName("fact_case_fk_histology");

                entity.HasOne(d => d.IcdMainPrimaryNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.IcdMainPrimary)
                    .HasConstraintName("fact_case_fk_icd_main_primary");

                entity.HasOne(d => d.PatientGenderNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.PatientGender)
                    .HasConstraintName("fact_case_fk_patient_gender");

                entity.HasOne(d => d.PatientResidenceNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.PatientResidence)
                    .HasConstraintName("fact_case_fk_patient_residence");

                entity.HasOne(d => d.SideNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.Side)
                    .HasConstraintName("fact_case_fk_side");

                entity.HasOne(d => d.TnmMNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.TnmM)
                    .HasConstraintName("fact_case_fk_tnm_m");

                entity.HasOne(d => d.TnmNNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.TnmN)
                    .HasConstraintName("fact_case_fk_tnm_n");

                entity.HasOne(d => d.TnmTNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.TnmT)
                    .HasConstraintName("fact_case_fk_tnm_t");

                entity.HasOne(d => d.TumorStatusNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.TumorStatus)
                    .HasConstraintName("fact_case_fk_tumor_status");

                entity.HasOne(d => d.TumorStatusDistantMetastasesNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.TumorStatusDistantMetastases)
                    .HasConstraintName("fact_case_fk_tumor_status_distant_metastases");

                entity.HasOne(d => d.UiccNavigation)
                    .WithMany(p => p.FactCases)
                    .HasForeignKey(d => d.Uicc)
                    .HasConstraintName("fact_case_fk_uicc");
            });

            modelBuilder.Entity<FactCaseDistantMetastase>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.DistantMetastasesId })
                    .HasName("fact_case_distant_metastases_pk");

                entity.ToTable("fact_case_distant_metastases", "dbo");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.DistantMetastasesId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("distant_metastases_id");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.FactCaseDistantMetastases)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_distant_metastases_fk_case_id");

                entity.HasOne(d => d.DistantMetastases)
                    .WithMany(p => p.FactCaseDistantMetastases)
                    .HasForeignKey(d => d.DistantMetastasesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_distant_metastases_fk_distant_metastases_id");
            });

            modelBuilder.Entity<FactCaseOperation>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("fact_case_operation_pk");

                entity.ToTable("fact_case_operation", "dbo");

                entity.Property(e => e.OperationId)
                    .ValueGeneratedNever()
                    .HasColumnName("operation_id");

                entity.Property(e => e.CareProvider).HasColumnName("care_provider");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.OpDate)
                    .HasColumnType("date")
                    .HasColumnName("op_date");

                entity.Property(e => e.OpIntention)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("op_intention");

                entity.Property(e => e.Ops)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ops");

                entity.Property(e => e.ResidualStatus)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("residual_status");

                entity.Property(e => e.TherapyLine).HasColumnName("therapy_line");

                entity.HasOne(d => d.CareProviderNavigation)
                    .WithMany(p => p.FactCaseOperations)
                    .HasForeignKey(d => d.CareProvider)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_operation_fk_care_provider");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.FactCaseOperations)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("fact_case_operation_fk_case_id");

                entity.HasOne(d => d.OpIntentionNavigation)
                    .WithMany(p => p.FactCaseOperations)
                    .HasForeignKey(d => d.OpIntention)
                    .HasConstraintName("fact_case_operation_fk_op_intention");

                entity.HasOne(d => d.OpsNavigation)
                    .WithMany(p => p.FactCaseOperations)
                    .HasForeignKey(d => d.Ops)
                    .HasConstraintName("fact_case_operation_fk_ops");

                entity.HasOne(d => d.ResidualStatusNavigation)
                    .WithMany(p => p.FactCaseOperations)
                    .HasForeignKey(d => d.ResidualStatus)
                    .HasConstraintName("fact_case_operation_fk_residual_status");

                entity.HasOne(d => d.TherapyLineNavigation)
                    .WithMany(p => p.FactCaseOperations)
                    .HasForeignKey(d => d.TherapyLine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_operation_fk_therapy_line");
            });

            modelBuilder.Entity<FactCaseRadiotherapy>(entity =>
            {
                entity.HasKey(e => e.RadiotherapyId)
                    .HasName("fact_case_radiotherapy_pk");

                entity.ToTable("fact_case_radiotherapy", "dbo");

                entity.Property(e => e.RadiotherapyId)
                    .ValueGeneratedNever()
                    .HasColumnName("radiotherapy_id");

                entity.Property(e => e.CareProvider).HasColumnName("care_provider");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.Ops)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ops");

                entity.Property(e => e.Radiotherapy)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("radiotherapy");

                entity.Property(e => e.TherapyBegin)
                    .HasColumnType("date")
                    .HasColumnName("therapy_begin");

                entity.Property(e => e.TherapyDuration).HasColumnName("therapy_duration");

                entity.Property(e => e.TherapyEnd)
                    .HasColumnType("date")
                    .HasColumnName("therapy_end");

                entity.Property(e => e.TherapyIntention)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("therapy_intention");

                entity.Property(e => e.TherapyLine).HasColumnName("therapy_line");

                entity.Property(e => e.TherapyRelation)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("therapy_relation");

                entity.Property(e => e.TherapyTimeRelation)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("therapy_time_relation");

                entity.HasOne(d => d.CareProviderNavigation)
                    .WithMany(p => p.FactCaseRadiotherapies)
                    .HasForeignKey(d => d.CareProvider)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_radiotherapy_fk_care_provider");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.FactCaseRadiotherapies)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("fact_case_radiotherapy_fk_case_id");

                entity.HasOne(d => d.OpsNavigation)
                    .WithMany(p => p.FactCaseRadiotherapies)
                    .HasForeignKey(d => d.Ops)
                    .HasConstraintName("fact_case_radiotherapy_fk_ops");

                entity.HasOne(d => d.RadiotherapyNavigation)
                    .WithMany(p => p.FactCaseRadiotherapies)
                    .HasForeignKey(d => d.Radiotherapy)
                    .HasConstraintName("fact_case_radiotherapy_fk_radiotherapy");

                entity.HasOne(d => d.TherapyDurationNavigation)
                    .WithMany(p => p.FactCaseRadiotherapies)
                    .HasForeignKey(d => d.TherapyDuration)
                    .HasConstraintName("fact_case_radiotherapy_fk_therapy_duration");

                entity.HasOne(d => d.TherapyIntentionNavigation)
                    .WithMany(p => p.FactCaseRadiotherapies)
                    .HasForeignKey(d => d.TherapyIntention)
                    .HasConstraintName("fact_case_radiotherapy_fk_therapy_intention");

                entity.HasOne(d => d.TherapyLineNavigation)
                    .WithMany(p => p.FactCaseRadiotherapies)
                    .HasForeignKey(d => d.TherapyLine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_radiotherapy_fk_therapy_line");

                entity.HasOne(d => d.TherapyRelationNavigation)
                    .WithMany(p => p.FactCaseRadiotherapies)
                    .HasForeignKey(d => d.TherapyRelation)
                    .HasConstraintName("fact_case_radiotherapy_fk_therapy_relation");

                entity.HasOne(d => d.TherapyTimeRelationNavigation)
                    .WithMany(p => p.FactCaseRadiotherapies)
                    .HasForeignKey(d => d.TherapyTimeRelation)
                    .HasConstraintName("fact_case_radiotherapy_fk_therapy_time_relation");
            });

            modelBuilder.Entity<FactCaseReportType>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.ReportTypeId })
                    .HasName("fact_case_report_type_pk");

                entity.ToTable("fact_case_report_type", "dbo");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.ReportTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("report_type_id");

                entity.Property(e => e.NumberOfReports).HasColumnName("number_of_reports");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.FactCaseReportTypes)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_report_type_fk_case_id");

                entity.HasOne(d => d.ReportType)
                    .WithMany(p => p.FactCaseReportTypes)
                    .HasForeignKey(d => d.ReportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_report_type_fk_report_type_id");
            });

            modelBuilder.Entity<FactCaseSystemicTherapy>(entity =>
            {
                entity.HasKey(e => e.SystemicTherapyId)
                    .HasName("fact_case_systemic_therapy_pk");

                entity.ToTable("fact_case_systemic_therapy", "dbo");

                entity.Property(e => e.SystemicTherapyId)
                    .ValueGeneratedNever()
                    .HasColumnName("systemic_therapy_id");

                entity.Property(e => e.CareProvider).HasColumnName("care_provider");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.Ops)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ops");

                entity.Property(e => e.SystemicTherapy)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("systemic_therapy");

                entity.Property(e => e.TherapyBegin)
                    .HasColumnType("date")
                    .HasColumnName("therapy_begin");

                entity.Property(e => e.TherapyDuration).HasColumnName("therapy_duration");

                entity.Property(e => e.TherapyEnd)
                    .HasColumnType("date")
                    .HasColumnName("therapy_end");

                entity.Property(e => e.TherapyIntention)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("therapy_intention");

                entity.Property(e => e.TherapyLine).HasColumnName("therapy_line");

                entity.Property(e => e.TherapyProtocol)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("therapy_protocol");

                entity.Property(e => e.TherapyRelation)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("therapy_relation");

                entity.Property(e => e.TherapyStopReason)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("therapy_stop_reason");

                entity.Property(e => e.TherapyTimeRelation)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("therapy_time_relation");

                entity.HasOne(d => d.CareProviderNavigation)
                    .WithMany(p => p.FactCaseSystemicTherapies)
                    .HasForeignKey(d => d.CareProvider)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_systemic_therapy_fk_care_provider");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.FactCaseSystemicTherapies)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("fact_case_systemic_therapy_fk_case_id");

                entity.HasOne(d => d.OpsNavigation)
                    .WithMany(p => p.FactCaseSystemicTherapies)
                    .HasForeignKey(d => d.Ops)
                    .HasConstraintName("fact_case_systemic_therapy_fk_ops");

                entity.HasOne(d => d.SystemicTherapyNavigation)
                    .WithMany(p => p.FactCaseSystemicTherapies)
                    .HasForeignKey(d => d.SystemicTherapy)
                    .HasConstraintName("fact_case_systemic_therapy_fk_systemic_therapy");

                entity.HasOne(d => d.TherapyDurationNavigation)
                    .WithMany(p => p.FactCaseSystemicTherapies)
                    .HasForeignKey(d => d.TherapyDuration)
                    .HasConstraintName("fact_case_systemic_therapy_fk_therapy_duration");

                entity.HasOne(d => d.TherapyIntentionNavigation)
                    .WithMany(p => p.FactCaseSystemicTherapies)
                    .HasForeignKey(d => d.TherapyIntention)
                    .HasConstraintName("fact_case_systemic_therapy_fk_therapy_intention");

                entity.HasOne(d => d.TherapyLineNavigation)
                    .WithMany(p => p.FactCaseSystemicTherapies)
                    .HasForeignKey(d => d.TherapyLine)
                    .HasConstraintName("fact_case_systemic_therapy_fk_therapy_line");

                entity.HasOne(d => d.TherapyProtocolNavigation)
                    .WithMany(p => p.FactCaseSystemicTherapies)
                    .HasForeignKey(d => d.TherapyProtocol)
                    .HasConstraintName("fact_case_systemic_therapy_fk_therapy_protocol");

                entity.HasOne(d => d.TherapyRelationNavigation)
                    .WithMany(p => p.FactCaseSystemicTherapies)
                    .HasForeignKey(d => d.TherapyRelation)
                    .HasConstraintName("fact_case_systemic_therapy_fk_therapy_relation");

                entity.HasOne(d => d.TherapyStopReasonNavigation)
                    .WithMany(p => p.FactCaseSystemicTherapies)
                    .HasForeignKey(d => d.TherapyStopReason)
                    .HasConstraintName("fact_case_systemic_therapy_fk_therapy_stop_reason");

                entity.HasOne(d => d.TherapyTimeRelationNavigation)
                    .WithMany(p => p.FactCaseSystemicTherapies)
                    .HasForeignKey(d => d.TherapyTimeRelation)
                    .HasConstraintName("fact_case_systemic_therapy_fk_therapy_time_relation");
            });

            modelBuilder.Entity<FactCaseTumorConference>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.TumorConferenceId })
                    .HasName("fact_case_tumor_conference_pk");

                entity.ToTable("fact_case_tumor_conference", "dbo");

                entity.Property(e => e.CaseId).HasColumnName("case_id");

                entity.Property(e => e.TumorConferenceId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tumor_conference_id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.FactCaseTumorConferences)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_tumor_conference_fk_case_id");

                entity.HasOne(d => d.TumorConference)
                    .WithMany(p => p.FactCaseTumorConferences)
                    .HasForeignKey(d => d.TumorConferenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_case_tumor_conference_fk_tumor_conference_id");
            });

            modelBuilder.Entity<FactModuleBreastCancer>(entity =>
            {
                entity.HasKey(e => e.CaseId)
                    .HasName("fact_module_breast_cancer_pk");

                entity.ToTable("fact_module_breast_cancer", "dbo");

                entity.Property(e => e.CaseId)
                    .ValueGeneratedNever()
                    .HasColumnName("case_id");

                entity.Property(e => e.CondensedReceptorStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("condensed_receptor_status");

                entity.Property(e => e.EstrogenStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("estrogen_status");

                entity.Property(e => e.Her2neuStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("her2neu_status");

                entity.Property(e => e.ProgesteroneStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("progesterone_status");

                entity.HasOne(d => d.Case)
                    .WithOne(p => p.FactModuleBreastCancer)
                    .HasForeignKey<FactModuleBreastCancer>(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_module_breast_cancer_fk_case_id");

                entity.HasOne(d => d.CondensedReceptorStatusNavigation)
                    .WithMany(p => p.FactModuleBreastCancers)
                    .HasForeignKey(d => d.CondensedReceptorStatus)
                    .HasConstraintName("fact_module_breast_cancer_fk_condensed_receptor_status");

                entity.HasOne(d => d.EstrogenStatusNavigation)
                    .WithMany(p => p.FactModuleBreastCancerEstrogenStatusNavigations)
                    .HasForeignKey(d => d.EstrogenStatus)
                    .HasConstraintName("fact_module_breast_cancer_fk_estrogen_status");

                entity.HasOne(d => d.Her2neuStatusNavigation)
                    .WithMany(p => p.FactModuleBreastCancerHer2neuStatusNavigations)
                    .HasForeignKey(d => d.Her2neuStatus)
                    .HasConstraintName("fact_module_breast_cancer_fk_her2neu_status");

                entity.HasOne(d => d.ProgesteroneStatusNavigation)
                    .WithMany(p => p.FactModuleBreastCancerProgesteroneStatusNavigations)
                    .HasForeignKey(d => d.ProgesteroneStatus)
                    .HasConstraintName("fact_module_breast_cancer_fk_progesterone_status");
            });

            modelBuilder.Entity<FactOperationAdditionalOp>(entity =>
            {
                entity.HasKey(e => new { e.OperationId, e.Ops })
                    .HasName("fact_operation_additional_ops_pk");

                entity.ToTable("fact_operation_additional_ops", "dbo");

                entity.Property(e => e.OperationId).HasColumnName("operation_id");

                entity.Property(e => e.Ops)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ops");

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.FactOperationAdditionalOps)
                    .HasForeignKey(d => d.OperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_operation_additional_ops_fk_operation_id");

                entity.HasOne(d => d.OpsNavigation)
                    .WithMany(p => p.FactOperationAdditionalOps)
                    .HasForeignKey(d => d.Ops)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_operation_additional_ops_fk_ops");
            });

            modelBuilder.Entity<FactProtocolSubstance>(entity =>
            {
                entity.HasKey(e => new { e.ProtocolId, e.SubstanceId })
                    .HasName("fact_protocol_substance_pk");

                entity.ToTable("fact_protocol_substance", "dbo");

                entity.Property(e => e.ProtocolId)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("protocol_id");

                entity.Property(e => e.SubstanceId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("substance_id");

                entity.HasOne(d => d.Protocol)
                    .WithMany(p => p.FactProtocolSubstances)
                    .HasForeignKey(d => d.ProtocolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_protocol_substance_fk_protocol_id");

                entity.HasOne(d => d.Substance)
                    .WithMany(p => p.FactProtocolSubstances)
                    .HasForeignKey(d => d.SubstanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_protocol_substance_fk_substance_id");
            });

            modelBuilder.Entity<FactSurvivalAnalysis>(entity =>
            {
                entity.HasKey(e => new { e.SurvivalAnalysisCaseId, e.SurvivalAnalysisType })
                    .HasName("fact_survival_analysis_pk");

                entity.ToTable("fact_survival_analysis", "dbo");

                entity.Property(e => e.SurvivalAnalysisCaseId).HasColumnName("survival_analysis_case_id");

                entity.Property(e => e.SurvivalAnalysisType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("survival_analysis_type");

                entity.Property(e => e.SurvivalAnalysisEndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("survival_analysis_end_date");

                entity.Property(e => e.SurvivalAnalysisStartDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("survival_analysis_start_date");

                entity.HasOne(d => d.SurvivalAnalysisCase)
                    .WithMany(p => p.FactSurvivalAnalyses)
                    .HasForeignKey(d => d.SurvivalAnalysisCaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_survival_analysis_fk_survival_analysis_case_id");

                entity.HasOne(d => d.SurvivalAnalysisEndDateNavigation)
                    .WithMany(p => p.FactSurvivalAnalysisSurvivalAnalysisEndDateNavigations)
                    .HasForeignKey(d => d.SurvivalAnalysisEndDate)
                    .HasConstraintName("fact_survival_analysis_fk_survival_analysis_end_date");

                entity.HasOne(d => d.SurvivalAnalysisStartDateNavigation)
                    .WithMany(p => p.FactSurvivalAnalysisSurvivalAnalysisStartDateNavigations)
                    .HasForeignKey(d => d.SurvivalAnalysisStartDate)
                    .HasConstraintName("fact_survival_analysis_fk_survival_analysis_start_date");

                entity.HasOne(d => d.SurvivalAnalysisTypeNavigation)
                    .WithMany(p => p.FactSurvivalAnalyses)
                    .HasForeignKey(d => d.SurvivalAnalysisType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_survival_analysis_fk_survival_analysis_type");
            });

            modelBuilder.Entity<FactSystemicTherapySubstance>(entity =>
            {
                entity.HasKey(e => new { e.SystemicTherapyId, e.SubstanceId })
                    .HasName("fact_systemic_therapy_substance_pk");

                entity.ToTable("fact_systemic_therapy_substance", "dbo");

                entity.Property(e => e.SystemicTherapyId).HasColumnName("systemic_therapy_id");

                entity.Property(e => e.SubstanceId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("substance_id");

                entity.HasOne(d => d.Substance)
                    .WithMany(p => p.FactSystemicTherapySubstances)
                    .HasForeignKey(d => d.SubstanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_systemic_therapy_substance_fk_substance_id");

                entity.HasOne(d => d.SystemicTherapy)
                    .WithMany(p => p.FactSystemicTherapySubstances)
                    .HasForeignKey(d => d.SystemicTherapyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fact_systemic_therapy_substance_fk_systemic_therapy_id");
            });

            modelBuilder.Entity<SfAge>(entity =>
            {
                entity.HasKey(e => e.AgeId)
                    .HasName("sf_age_pk");

                entity.ToTable("sf_age", "dbo");

                entity.Property(e => e.AgeId)
                    .ValueGeneratedNever()
                    .HasColumnName("age_id");
            });

            modelBuilder.Entity<SfCareProvider>(entity =>
            {
                entity.HasKey(e => e.CareProviderId)
                    .HasName("sf_care_provider_pk");

                entity.ToTable("sf_care_provider", "dbo");

                entity.Property(e => e.CareProviderId)
                    .ValueGeneratedNever()
                    .HasColumnName("care_provider_id");

                entity.Property(e => e.CareProviderDepartment)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("care_provider_department");

                entity.Property(e => e.CareProviderInstitution)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("care_provider_institution");

                entity.Property(e => e.CareProviderName)
                    .HasMaxLength(42)
                    .IsUnicode(false)
                    .HasColumnName("care_provider_name");

                entity.Property(e => e.CareProviderProfession)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("care_provider_profession");
            });

            modelBuilder.Entity<SfCondensedHormoneReceptorStatus>(entity =>
            {
                entity.HasKey(e => e.CondensedReceptorStatusId)
                    .HasName("sf_condensed_hormone_receptor_status_pk");

                entity.ToTable("sf_condensed_hormone_receptor_status", "dbo");

                entity.Property(e => e.CondensedReceptorStatusId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("condensed_receptor_status_id");

                entity.Property(e => e.CondensedReceptorStatusLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("condensed_receptor_status_longname_english");

                entity.Property(e => e.CondensedReceptorStatusLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("condensed_receptor_status_longname_german");

                entity.Property(e => e.CondensedReceptorStatusShortname)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("condensed_receptor_status_shortname");

                entity.Property(e => e.EstrogenStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("estrogen_status");

                entity.Property(e => e.Her2Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("her_2_status");

                entity.Property(e => e.ProgesteroneStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("progesterone_status");
            });

            modelBuilder.Entity<SfDate>(entity =>
            {
                entity.HasKey(e => e.DateId)
                    .HasName("sf_date_pk");

                entity.ToTable("sf_date", "dbo");

                entity.Property(e => e.DateId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("date_id");

                entity.Property(e => e.DateDay).HasColumnName("date_day");

                entity.Property(e => e.DateDayName)
                    .HasMaxLength(91)
                    .IsUnicode(false)
                    .HasColumnName("date_day_name");

                entity.Property(e => e.DateMean)
                    .HasColumnType("date")
                    .HasColumnName("date_mean");

                entity.Property(e => e.DateMonth).HasColumnName("date_month");

                entity.Property(e => e.DateMonthName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("date_month_name");

                entity.Property(e => e.DateNameEnglish)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("date_name_english");

                entity.Property(e => e.DateNameGerman)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("date_name_german");

                entity.Property(e => e.DateQuarter).HasColumnName("date_quarter");

                entity.Property(e => e.DateQuarterName)
                    .HasMaxLength(57)
                    .IsUnicode(false)
                    .HasColumnName("date_quarter_name");

                entity.Property(e => e.DateSemester).HasColumnName("date_semester");

                entity.Property(e => e.DateSemesterName)
                    .HasMaxLength(37)
                    .IsUnicode(false)
                    .HasColumnName("date_semester_name");

                entity.Property(e => e.DateYear).HasColumnName("date_year");

                entity.Property(e => e.DateYearName)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("date_year_name");
            });

            modelBuilder.Entity<SfDiagnosisSafety>(entity =>
            {
                entity.HasKey(e => e.DiagnosisSafetyId)
                    .HasName("sf_diagnosis_safety_pk");

                entity.ToTable("sf_diagnosis_safety", "dbo");

                entity.Property(e => e.DiagnosisSafetyId)
                    .ValueGeneratedNever()
                    .HasColumnName("diagnosis_safety_id");

                entity.Property(e => e.DiagnosisSafetyLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("diagnosis_safety_longname_english");

                entity.Property(e => e.DiagnosisSafetyLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("diagnosis_safety_longname_german");
            });

            modelBuilder.Entity<SfDiseaseProgression>(entity =>
            {
                entity.HasKey(e => e.DiseaseProgressionId)
                    .HasName("sf_disease_progression_pk");

                entity.ToTable("sf_disease_progression", "dbo");

                entity.Property(e => e.DiseaseProgressionId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("disease_progression_id");

                entity.Property(e => e.DiseaseProgressionLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("disease_progression_longname_english");

                entity.Property(e => e.DiseaseProgressionLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("disease_progression_longname_german");

                entity.Property(e => e.DiseaseProgressionShortname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("disease_progression_shortname");
            });

            modelBuilder.Entity<SfDistantMetastase>(entity =>
            {
                entity.HasKey(e => e.DistantMetastasesId)
                    .HasName("sf_distant_metastases_pk");

                entity.ToTable("sf_distant_metastases", "dbo");

                entity.Property(e => e.DistantMetastasesId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("distant_metastases_id");

                entity.Property(e => e.DistantMetastasesLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("distant_metastases_longname_english");

                entity.Property(e => e.DistantMetastasesLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("distant_metastases_longname_german");

                entity.Property(e => e.DistantMetastasesShortname)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("distant_metastases_shortname");
            });

            modelBuilder.Entity<SfEcog>(entity =>
            {
                entity.HasKey(e => e.EcogId)
                    .HasName("sf_ecog_pk");

                entity.ToTable("sf_ecog", "dbo");

                entity.Property(e => e.EcogId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ecog_id");

                entity.Property(e => e.EcogLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("ecog_longname_english");

                entity.Property(e => e.EcogLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("ecog_longname_german");

                entity.Property(e => e.EcogShortname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ecog_shortname");
            });

            modelBuilder.Entity<SfGender>(entity =>
            {
                entity.HasKey(e => e.GenderId)
                    .HasName("sf_gender_pk");

                entity.ToTable("sf_gender", "dbo");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("gender_id");

                entity.Property(e => e.GenderLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("gender_longname_english");

                entity.Property(e => e.GenderLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("gender_longname_german");

                entity.Property(e => e.GenderShortname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("gender_shortname");
            });

            modelBuilder.Entity<SfGrading>(entity =>
            {
                entity.HasKey(e => e.GradingId)
                    .HasName("sf_grading_pk");

                entity.ToTable("sf_grading", "dbo");

                entity.Property(e => e.GradingId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grading_id");

                entity.Property(e => e.GradingLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("grading_longname_english");

                entity.Property(e => e.GradingLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("grading_longname_german");

                entity.Property(e => e.GradingShortname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grading_shortname");
            });

            modelBuilder.Entity<SfHistology>(entity =>
            {
                entity.HasKey(e => e.HistologyId)
                    .HasName("sf_histology_pk");

                entity.ToTable("sf_histology", "dbo");

                entity.Property(e => e.HistologyId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("histology_id");

                entity.Property(e => e.DignityLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("dignity_longname_german");

                entity.Property(e => e.DignityShortname)
                    .HasMaxLength(44)
                    .IsUnicode(false)
                    .HasColumnName("dignity_shortname");

                entity.Property(e => e.GroupLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("group_longname_german");

                entity.Property(e => e.GroupShortname)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("group_shortname");

                entity.Property(e => e.HistologyLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("histology_longname_german");

                entity.Property(e => e.HistologyShortname)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("histology_shortname");
            });

            modelBuilder.Entity<SfHormoneReceptorStatus>(entity =>
            {
                entity.HasKey(e => e.ReceptorStatusId)
                    .HasName("sf_hormone_receptor_status_pk");

                entity.ToTable("sf_hormone_receptor_status", "dbo");

                entity.Property(e => e.ReceptorStatusId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("receptor_status_id");

                entity.Property(e => e.ReceptorStatusLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("receptor_status_longname_english");

                entity.Property(e => e.ReceptorStatusLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("receptor_status_longname_german");

                entity.Property(e => e.ReceptorStatusShortname)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("receptor_status_shortname");
            });

            modelBuilder.Entity<SfIcd>(entity =>
            {
                entity.HasKey(e => e.IcdId)
                    .HasName("sf_icd_pk");

                entity.ToTable("sf_icd", "dbo");

                entity.Property(e => e.IcdId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("icd_id");

                entity.Property(e => e.IcdChapter)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("icd_chapter");

                entity.Property(e => e.IcdDescription)
                    .HasColumnType("text")
                    .HasColumnName("icd_description");

                entity.Property(e => e.IcdFiveDigits)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("icd_five_digits");

                entity.Property(e => e.IcdFourDigits)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("icd_four_digits");

                entity.Property(e => e.IcdGroup)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("icd_group");

                entity.Property(e => e.IcdThreeDigits)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("icd_three_digits");
            });

            modelBuilder.Entity<SfLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("sf_location_pk");

                entity.ToTable("sf_location", "dbo");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("location_id");

                entity.Property(e => e.LocationState)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("location_state");
            });

            modelBuilder.Entity<SfOp>(entity =>
            {
                entity.HasKey(e => e.OpsId)
                    .HasName("sf_ops_pk");

                entity.ToTable("sf_ops", "dbo");

                entity.Property(e => e.OpsId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ops_id");

                entity.Property(e => e.OpsAdditionalCode).HasColumnName("ops_additional_code");

                entity.Property(e => e.OpsChapter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ops_chapter");

                entity.Property(e => e.OpsDescription)
                    .HasColumnType("text")
                    .HasColumnName("ops_description");

                entity.Property(e => e.OpsFiveDigits)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ops_five_digits");

                entity.Property(e => e.OpsFourDigits)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ops_four_digits");

                entity.Property(e => e.OpsGroup)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("ops_group");

                entity.Property(e => e.OpsRequiresSide).HasColumnName("ops_requires_side");

                entity.Property(e => e.OpsSixDigits)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("ops_six_digits");

                entity.Property(e => e.OpsThreeDigits)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("ops_three_digits");

                entity.Property(e => e.OpsUseOnceCode).HasColumnName("ops_use_once_code");
            });

            modelBuilder.Entity<SfOpIntention>(entity =>
            {
                entity.HasKey(e => e.OpIntentionId)
                    .HasName("sf_op_intention_pk");

                entity.ToTable("sf_op_intention", "dbo");

                entity.Property(e => e.OpIntentionId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("op_intention_id");

                entity.Property(e => e.OpIntentionLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("op_intention_longname_english");

                entity.Property(e => e.OpIntentionLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("op_intention_longname_german");

                entity.Property(e => e.OpIntentionShortname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("op_intention_shortname");
            });

            modelBuilder.Entity<SfProtocol>(entity =>
            {
                entity.HasKey(e => e.ProtocolId)
                    .HasName("sf_protocol_pk");

                entity.ToTable("sf_protocol", "dbo");

                entity.Property(e => e.ProtocolId)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("protocol_id");

                entity.Property(e => e.ProtocolLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("protocol_longname_english");

                entity.Property(e => e.ProtocolLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("protocol_longname_german");

                entity.Property(e => e.ProtocolShortname)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("protocol_shortname");
            });

            modelBuilder.Entity<SfRadiotherapy>(entity =>
            {
                entity.HasKey(e => e.RadiotherapyId)
                    .HasName("sf_radiotherapy_pk");

                entity.ToTable("sf_radiotherapy", "dbo");

                entity.Property(e => e.RadiotherapyId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("radiotherapy_id");

                entity.Property(e => e.RadiotherapyDescriptionEnglish)
                    .HasColumnType("text")
                    .HasColumnName("radiotherapy_description_english");

                entity.Property(e => e.RadiotherapyDescriptionGerman)
                    .HasColumnType("text")
                    .HasColumnName("radiotherapy_description_german");

                entity.Property(e => e.RadiotherapyLymphNodes).HasColumnName("radiotherapy_lymph_nodes");

                entity.Property(e => e.RadiotherapyTargetAreaFine)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("radiotherapy_target_area_fine");

                entity.Property(e => e.RadiotherapyTargetAreaFinest)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("radiotherapy_target_area_finest");

                entity.Property(e => e.RadiotherapyTargetAreaRough)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("radiotherapy_target_area_rough");
            });

            modelBuilder.Entity<SfReferencePopulation>(entity =>
            {
                entity.HasKey(e => e.ReferencePopulationId)
                    .HasName("sf_reference_population_pk");

                entity.ToTable("sf_reference_population", "dbo");

                entity.Property(e => e.ReferencePopulationId)
                    .ValueGeneratedNever()
                    .HasColumnName("reference_population_id");

                entity.Property(e => e.Age0004M).HasColumnName("age_0004_m");

                entity.Property(e => e.Age0004W).HasColumnName("age_0004_w");

                entity.Property(e => e.Age0509M).HasColumnName("age_0509_m");

                entity.Property(e => e.Age0509W).HasColumnName("age_0509_w");

                entity.Property(e => e.Age1014M).HasColumnName("age_1014_m");

                entity.Property(e => e.Age1014W).HasColumnName("age_1014_w");

                entity.Property(e => e.Age1519M).HasColumnName("age_1519_m");

                entity.Property(e => e.Age1519W).HasColumnName("age_1519_w");

                entity.Property(e => e.Age2024M).HasColumnName("age_2024_m");

                entity.Property(e => e.Age2024W).HasColumnName("age_2024_w");

                entity.Property(e => e.Age2529M).HasColumnName("age_2529_m");

                entity.Property(e => e.Age2529W).HasColumnName("age_2529_w");

                entity.Property(e => e.Age3034M).HasColumnName("age_3034_m");

                entity.Property(e => e.Age3034W).HasColumnName("age_3034_w");

                entity.Property(e => e.Age3539M).HasColumnName("age_3539_m");

                entity.Property(e => e.Age3539W).HasColumnName("age_3539_w");

                entity.Property(e => e.Age4044M).HasColumnName("age_4044_m");

                entity.Property(e => e.Age4044W).HasColumnName("age_4044_w");

                entity.Property(e => e.Age4549M).HasColumnName("age_4549_m");

                entity.Property(e => e.Age4549W).HasColumnName("age_4549_w");

                entity.Property(e => e.Age5054M).HasColumnName("age_5054_m");

                entity.Property(e => e.Age5054W).HasColumnName("age_5054_w");

                entity.Property(e => e.Age5559M).HasColumnName("age_5559_m");

                entity.Property(e => e.Age5559W).HasColumnName("age_5559_w");

                entity.Property(e => e.Age6064M).HasColumnName("age_6064_m");

                entity.Property(e => e.Age6064W).HasColumnName("age_6064_w");

                entity.Property(e => e.Age6569M).HasColumnName("age_6569_m");

                entity.Property(e => e.Age6569W).HasColumnName("age_6569_w");

                entity.Property(e => e.Age7074M).HasColumnName("age_7074_m");

                entity.Property(e => e.Age7074W).HasColumnName("age_7074_w");

                entity.Property(e => e.Age7579M).HasColumnName("age_7579_m");

                entity.Property(e => e.Age7579W).HasColumnName("age_7579_w");

                entity.Property(e => e.Age8084M).HasColumnName("age_8084_m");

                entity.Property(e => e.Age8084W).HasColumnName("age_8084_w");

                entity.Property(e => e.Age85M).HasColumnName("age_85_m");

                entity.Property(e => e.Age85W).HasColumnName("age_85_w");

                entity.Property(e => e.LabelEnglish)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("label_english");

                entity.Property(e => e.LabelGerman)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("label_german");
            });

            modelBuilder.Entity<SfReportType>(entity =>
            {
                entity.HasKey(e => e.ReportTypeId)
                    .HasName("sf_report_type_pk");

                entity.ToTable("sf_report_type", "dbo");

                entity.Property(e => e.ReportTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("report_type_id");

                entity.Property(e => e.ReportTypeLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("report_type_longname_english");

                entity.Property(e => e.ReportTypeLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("report_type_longname_german");

                entity.Property(e => e.ReportTypeShortname)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("report_type_shortname");
            });

            modelBuilder.Entity<SfResidualStatus>(entity =>
            {
                entity.HasKey(e => e.ResidualStatusId)
                    .HasName("sf_residual_status_pk");

                entity.ToTable("sf_residual_status", "dbo");

                entity.Property(e => e.ResidualStatusId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("residual_status_id");

                entity.Property(e => e.ResidualStatusLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("residual_status_longname_english");

                entity.Property(e => e.ResidualStatusLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("residual_status_longname_german");

                entity.Property(e => e.ResidualStatusShortname)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("residual_status_shortname");
            });

            modelBuilder.Entity<SfSide>(entity =>
            {
                entity.HasKey(e => e.SideId)
                    .HasName("sf_side_pk");

                entity.ToTable("sf_side", "dbo");

                entity.Property(e => e.SideId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("side_id");

                entity.Property(e => e.SideLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("side_longname_english");

                entity.Property(e => e.SideLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("side_longname_german");

                entity.Property(e => e.SideShortname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("side_shortname");
            });

            modelBuilder.Entity<SfSubstance>(entity =>
            {
                entity.HasKey(e => e.SubstanceId)
                    .HasName("sf_substance_pk");

                entity.ToTable("sf_substance", "dbo");

                entity.Property(e => e.SubstanceId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("substance_id");

                entity.Property(e => e.AtcLevel1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("atc_level_1");

                entity.Property(e => e.AtcLevel1Label)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("atc_level_1_label");

                entity.Property(e => e.AtcLevel2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("atc_level_2");

                entity.Property(e => e.AtcLevel2Label)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("atc_level_2_label");

                entity.Property(e => e.AtcLevel3)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("atc_level_3");

                entity.Property(e => e.AtcLevel3Label)
                    .HasMaxLength(66)
                    .IsUnicode(false)
                    .HasColumnName("atc_level_3_label");

                entity.Property(e => e.AtcLevel4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("atc_level_4");

                entity.Property(e => e.AtcLevel4Label)
                    .HasMaxLength(73)
                    .IsUnicode(false)
                    .HasColumnName("atc_level_4_label");

                entity.Property(e => e.AtcLevel5)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("atc_level_5");

                entity.Property(e => e.AtcLevel5Label)
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("atc_level_5_label");
            });

            modelBuilder.Entity<SfSurvivalAnalysisType>(entity =>
            {
                entity.HasKey(e => e.SurvivalAnalysisTypeId)
                    .HasName("sf_survival_analysis_type_pk");

                entity.ToTable("sf_survival_analysis_type", "dbo");

                entity.Property(e => e.SurvivalAnalysisTypeId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("survival_analysis_type_id");

                entity.Property(e => e.SurvivalAnalysisTypeLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("survival_analysis_type_longname_english");

                entity.Property(e => e.SurvivalAnalysisTypeLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("survival_analysis_type_longname_german");

                entity.Property(e => e.SurvivalAnalysisTypeShortname)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("survival_analysis_type_shortname");
            });

            modelBuilder.Entity<SfSystemicTherapy>(entity =>
            {
                entity.HasKey(e => e.SystemicTherapyId)
                    .HasName("sf_systemic_therapy_pk");

                entity.ToTable("sf_systemic_therapy", "dbo");

                entity.Property(e => e.SystemicTherapyId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("systemic_therapy_id");

                entity.Property(e => e.SystemicTherapyLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("systemic_therapy_longname_english");

                entity.Property(e => e.SystemicTherapyLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("systemic_therapy_longname_german");

                entity.Property(e => e.SystemicTherapyShortname)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("systemic_therapy_shortname");
            });

            modelBuilder.Entity<SfTherapyDuration>(entity =>
            {
                entity.HasKey(e => e.TherapyDurationId)
                    .HasName("sf_therapy_duration_pk");

                entity.ToTable("sf_therapy_duration", "dbo");

                entity.Property(e => e.TherapyDurationId)
                    .ValueGeneratedNever()
                    .HasColumnName("therapy_duration_id");

                entity.Property(e => e.TherapyDurationLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("therapy_duration_longname_english");

                entity.Property(e => e.TherapyDurationLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("therapy_duration_longname_german");

                entity.Property(e => e.TherapyDurationShortname)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("therapy_duration_shortname");
            });

            modelBuilder.Entity<SfTherapyIntention>(entity =>
            {
                entity.HasKey(e => e.TherapyIntentionId)
                    .HasName("sf_therapy_intention_pk");

                entity.ToTable("sf_therapy_intention", "dbo");

                entity.Property(e => e.TherapyIntentionId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("therapy_intention_id");

                entity.Property(e => e.TherapyIntentionLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("therapy_intention_longname_english");

                entity.Property(e => e.TherapyIntentionLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("therapy_intention_longname_german");

                entity.Property(e => e.TherapyIntentionShortname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("therapy_intention_shortname");
            });

            modelBuilder.Entity<SfTherapyLine>(entity =>
            {
                entity.HasKey(e => e.TherapyLineId)
                    .HasName("sf_therapy_line_pk");

                entity.ToTable("sf_therapy_line", "dbo");

                entity.Property(e => e.TherapyLineId)
                    .ValueGeneratedNever()
                    .HasColumnName("therapy_line_id");

                entity.Property(e => e.TherapyLineLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("therapy_line_longname_english");

                entity.Property(e => e.TherapyLineLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("therapy_line_longname_german");

                entity.Property(e => e.TherapyLineShortname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("therapy_line_shortname");
            });

            modelBuilder.Entity<SfTherapyRelation>(entity =>
            {
                entity.HasKey(e => e.TherapyRelationId)
                    .HasName("sf_therapy_relation_pk");

                entity.ToTable("sf_therapy_relation", "dbo");

                entity.Property(e => e.TherapyRelationId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("therapy_relation_id");

                entity.Property(e => e.TherapyRelationLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("therapy_relation_longname_english");

                entity.Property(e => e.TherapyRelationLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("therapy_relation_longname_german");

                entity.Property(e => e.TherapyRelationOrdinal).HasColumnName("therapy_relation_ordinal");

                entity.Property(e => e.TherapyRelationShortname)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("therapy_relation_shortname");
            });

            modelBuilder.Entity<SfTherapyStop>(entity =>
            {
                entity.HasKey(e => e.TherapyStopId)
                    .HasName("sf_therapy_stop_pk");

                entity.ToTable("sf_therapy_stop", "dbo");

                entity.Property(e => e.TherapyStopId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("therapy_stop_id");

                entity.Property(e => e.TherapyStopLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("therapy_stop_longname_english");

                entity.Property(e => e.TherapyStopLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("therapy_stop_longname_german");

                entity.Property(e => e.TherapyStopShortname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("therapy_stop_shortname");
            });

            modelBuilder.Entity<SfTherapyTimeRelation>(entity =>
            {
                entity.HasKey(e => e.TherapyTimeRelationId)
                    .HasName("sf_therapy_time_relation_pk");

                entity.ToTable("sf_therapy_time_relation", "dbo");

                entity.Property(e => e.TherapyTimeRelationId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("therapy_time_relation_id");

                entity.Property(e => e.TherapyTimeRelationLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("therapy_time_relation_longname_english");

                entity.Property(e => e.TherapyTimeRelationLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("therapy_time_relation_longname_german");

                entity.Property(e => e.TherapyTimeRelationOrdinal).HasColumnName("therapy_time_relation_ordinal");

                entity.Property(e => e.TherapyTimeRelationShortname)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("therapy_time_relation_shortname");
            });

            modelBuilder.Entity<SfTnmM>(entity =>
            {
                entity.HasKey(e => e.TnmMId)
                    .HasName("sf_tnm_m_pk");

                entity.ToTable("sf_tnm_m", "dbo");

                entity.Property(e => e.TnmMId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("tnm_m_id");

                entity.Property(e => e.TnmMGroupShortname)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("tnm_m_group_shortname");

                entity.Property(e => e.TnmMPrefix)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tnm_m_prefix")
                    .IsFixedLength(true);

                entity.Property(e => e.TnmMShortname)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("tnm_m_shortname");
            });

            modelBuilder.Entity<SfTnmN>(entity =>
            {
                entity.HasKey(e => e.TnmNId)
                    .HasName("sf_tnm_n_pk");

                entity.ToTable("sf_tnm_n", "dbo");

                entity.Property(e => e.TnmNId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("tnm_n_id");

                entity.Property(e => e.TnmNGroupShortname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tnm_n_group_shortname");

                entity.Property(e => e.TnmNPrefix)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tnm_n_prefix")
                    .IsFixedLength(true);

                entity.Property(e => e.TnmNShortname)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("tnm_n_shortname");
            });

            modelBuilder.Entity<SfTnmT>(entity =>
            {
                entity.HasKey(e => e.TnmTId)
                    .HasName("sf_tnm_t_pk");

                entity.ToTable("sf_tnm_t", "dbo");

                entity.Property(e => e.TnmTId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("tnm_t_id");

                entity.Property(e => e.TnmTGroupShortname)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tnm_t_group_shortname");

                entity.Property(e => e.TnmTPrefix)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tnm_t_prefix")
                    .IsFixedLength(true);

                entity.Property(e => e.TnmTShortname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tnm_t_shortname");
            });

            modelBuilder.Entity<SfTumorConference>(entity =>
            {
                entity.HasKey(e => e.TumorConferenceId)
                    .HasName("sf_tumor_conference_pk");

                entity.ToTable("sf_tumor_conference", "dbo");

                entity.Property(e => e.TumorConferenceId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tumor_conference_id");

                entity.Property(e => e.TumorConferenceLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("tumor_conference_longname_english");

                entity.Property(e => e.TumorConferenceLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("tumor_conference_longname_german");

                entity.Property(e => e.TumorConferenceShortname)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tumor_conference_shortname");
            });

            modelBuilder.Entity<SfTumorStatus>(entity =>
            {
                entity.HasKey(e => e.TumorStatusId)
                    .HasName("sf_tumor_status_pk");

                entity.ToTable("sf_tumor_status", "dbo");

                entity.Property(e => e.TumorStatusId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tumor_status_id");

                entity.Property(e => e.TumorStatusLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("tumor_status_longname_english");

                entity.Property(e => e.TumorStatusLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("tumor_status_longname_german");

                entity.Property(e => e.TumorStatusShortname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tumor_status_shortname");
            });

            modelBuilder.Entity<SfTumorStatusDistantMetastase>(entity =>
            {
                entity.HasKey(e => e.TumorStatusDistantMetastasesId)
                    .HasName("sf_tumor_status_distant_metastases_pk");

                entity.ToTable("sf_tumor_status_distant_metastases", "dbo");

                entity.Property(e => e.TumorStatusDistantMetastasesId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tumor_status_distant_metastases_id");

                entity.Property(e => e.TumorStatusDistantMetastasesLongnameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("tumor_status_distant_metastases_longname_english");

                entity.Property(e => e.TumorStatusDistantMetastasesLongnameGerman)
                    .HasColumnType("text")
                    .HasColumnName("tumor_status_distant_metastases_longname_german");

                entity.Property(e => e.TumorStatusDistantMetastasesShortname)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tumor_status_distant_metastases_shortname");
            });

            modelBuilder.Entity<SfUicc>(entity =>
            {
                entity.HasKey(e => e.UiccId)
                    .HasName("sf_uicc_pk");

                entity.ToTable("sf_uicc", "dbo");

                entity.Property(e => e.UiccId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("uicc_id");

                entity.Property(e => e.UiccDescriptionEnglish)
                    .HasColumnType("text")
                    .HasColumnName("uicc_description_english");

                entity.Property(e => e.UiccDescriptionGerman)
                    .HasColumnType("text")
                    .HasColumnName("uicc_description_german");

                entity.Property(e => e.UiccGroup)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("uicc_group");

                entity.Property(e => e.UiccName)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("uicc_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
