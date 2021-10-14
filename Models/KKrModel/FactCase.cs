using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class FactCase
    {
        public FactCase()
        {
            FactCaseDistantMetastases = new HashSet<FactCaseDistantMetastase>();
            FactCaseOperations = new HashSet<FactCaseOperation>();
            FactCaseRadiotherapies = new HashSet<FactCaseRadiotherapy>();
            FactCaseReportTypes = new HashSet<FactCaseReportType>();
            FactCaseSystemicTherapies = new HashSet<FactCaseSystemicTherapy>();
            FactCaseTumorConferences = new HashSet<FactCaseTumorConference>();
            FactSurvivalAnalyses = new HashSet<FactSurvivalAnalysis>();
        }

        public int CaseId { get; set; }
        public int Patient { get; set; }
        public string PatientGender { get; set; }
        public string PatientResidence { get; set; }
        public int DiagnosisAge { get; set; }
        public int DeathAge { get; set; }
        public int? NumberOfExaminedLymphNodes { get; set; }
        public int? NumberOfExaminedSentinelLymphNodes { get; set; }
        public int? NumberOfAffectedLymphNodes { get; set; }
        public int? NumberOfLymphNodesRemoved { get; set; }
        public string IcdMainPrimary { get; set; }
        public string DiagnosisDate { get; set; }
        public string TumorStatus { get; set; }
        public string DiseaseProgression { get; set; }
        public string Grading { get; set; }
        public string Side { get; set; }
        public int? DiagnosisSafety { get; set; }
        public string TnmT { get; set; }
        public string TnmN { get; set; }
        public string TnmM { get; set; }
        public string Uicc { get; set; }
        public string Histology { get; set; }
        public string Ecog { get; set; }
        public int CareProvider { get; set; }
        public string TumorStatusDistantMetastases { get; set; }

        public virtual SfCareProvider CareProviderNavigation { get; set; }
        public virtual SfAge DeathAgeNavigation { get; set; }
        public virtual SfAge DiagnosisAgeNavigation { get; set; }
        public virtual SfDate DiagnosisDateNavigation { get; set; }
        public virtual SfDiagnosisSafety DiagnosisSafetyNavigation { get; set; }
        public virtual SfDiseaseProgression DiseaseProgressionNavigation { get; set; }
        public virtual SfEcog EcogNavigation { get; set; }
        public virtual SfGrading GradingNavigation { get; set; }
        public virtual SfHistology HistologyNavigation { get; set; }
        public virtual SfIcd IcdMainPrimaryNavigation { get; set; }
        public virtual SfGender PatientGenderNavigation { get; set; }
        public virtual SfLocation PatientResidenceNavigation { get; set; }
        public virtual SfSide SideNavigation { get; set; }
        public virtual SfTnmM TnmMNavigation { get; set; }
        public virtual SfTnmN TnmNNavigation { get; set; }
        public virtual SfTnmT TnmTNavigation { get; set; }
        public virtual SfTumorStatusDistantMetastase TumorStatusDistantMetastasesNavigation { get; set; }
        public virtual SfTumorStatus TumorStatusNavigation { get; set; }
        public virtual SfUicc UiccNavigation { get; set; }
        public virtual FactModuleBreastCancer FactModuleBreastCancer { get; set; }
        public virtual ICollection<FactCaseDistantMetastase> FactCaseDistantMetastases { get; set; }
        public virtual ICollection<FactCaseOperation> FactCaseOperations { get; set; }
        public virtual ICollection<FactCaseRadiotherapy> FactCaseRadiotherapies { get; set; }
        public virtual ICollection<FactCaseReportType> FactCaseReportTypes { get; set; }
        public virtual ICollection<FactCaseSystemicTherapy> FactCaseSystemicTherapies { get; set; }
        public virtual ICollection<FactCaseTumorConference> FactCaseTumorConferences { get; set; }
        public virtual ICollection<FactSurvivalAnalysis> FactSurvivalAnalyses { get; set; }
    }
}
