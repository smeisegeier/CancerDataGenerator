using Rki.CancerDataGenerator.Models;
using Rki.CancerDataGenerator.Models.ADTGEKID;
using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rki.CancerDataGenerator.BLL
{
    public class Modelbuilder
    {
        private Generator _generator { get; }

        private Configuration _config => _generator.Configuration;

        public ADT_GEKID ADT_GEKID { get; set; }

        public Modelbuilder(Generator generator)
        {
            _generator = generator;
            ADT_GEKID = Create_AdtGekid();
        }

        private ADT_GEKID Create_AdtGekid()
        {
            var obj = new ADT_GEKID();
            obj.Menge_Patient = Enumerable
                .Range(1, _config.Patient_Count)
                .Select(index => Create_Patient())
                .ToList();
            obj.Lieferregister = Create_Lieferregister();
            obj.Lieferdatum = new Datum(_generator.CreateRandomDate_Meldedatum(), Datumsgenauigkeit_Typ.E);
            return obj;
        }

        public Lieferregister Create_Lieferregister()
        {
            var obj = new Lieferregister();
            obj.Register_ID = _generator.FetchRandomEnumItem<ISO3199_2_Typ>();
            return obj;
        }

        private Patient Create_Patient()
        {
            var obj = new Patient();
            //obj.Anmerkung = _generator.FetchRandomDimensionItem<Quote>(null, _config.Text_ProbMissing)?.quote;
            obj.Patienten_Stammdaten = Create_Patienten_Stammdaten();
            int _meldungCount = 1; //_generator.GetMeldungCountPerAge(_config.GetTimeToPublishDateInYears(obj.Patienten_Stammdaten.Patienten_Geburtsdatum));

            obj.Menge_Tumor = Enumerable
                .Range(1, _meldungCount)
                .Select(index => Create_Tumor())
                .ToList();
            return obj;
        }

        public Patienten_Stammdaten Create_Patienten_Stammdaten()
        {
            var obj = new Patienten_Stammdaten();
            obj.Geburtsdatum  = new Datum(_generator.CreateRandomDate_Geburtsdatum(), Datumsgenauigkeit_Typ.T);
            obj.Patient_ID = Guid.NewGuid().ToString();
            // TODO create Random GKZ
            obj.Inzidenzort = "00114";
            if (_generator.CreateRandomBool())
                obj.Tod = Create_Tod();
            return obj;
        }

        private Tod Create_Tod()
        {
            var obj = new Tod();
            obj.Sterbedatum = new Datum(_generator.CreateRandomDate_Meldedatum(), Datumsgenauigkeit_Typ.T);
            obj.Anzahl_Tage_Diagnose_Tod = _generator.CreateRandomValue(1, Globals.MAXANZTAGEZWISCHENEREIGNISSE);
            obj.Todesursache = Create_Todesursache();
            return obj;
        }

        private Todesursache Create_Todesursache()
        {
            var obj = new Todesursache();
            obj.Todesursache_ICD = _generator.FetchNormalDimensionItem<Icd>().icd_three_digits;
            obj.Todesursache_ICD_Version = ICD_Version_Typ.Item102018GM;
            return obj;
        }

        private Tumor Create_Tumor()
        {
            var obj = new Tumor();
            obj.Primärdiagnose = Create_Diagnose();

            /*  Verlauf */
            obj.Menge_Folgeereignis = Enumerable
                .Range(1, 3)
                .Select(index => Create_PatientMeldungVerlauf())
                .ToList();

            obj.Tumor_ID = Guid.NewGuid().ToString();
            return obj;
        }

        private Verlauf Create_PatientMeldungVerlauf()
        {
            var obj = new Verlauf();
            return obj;
        }

        private Diagnose Create_Diagnose()
        {
            var obj = new Diagnose();
            obj.Diagnosedatum = new Datum(_generator.CreateRandomDate_Meldedatum(), Datumsgenauigkeit_Typ.T);
            obj.Primaertumor_ICD_Code = _generator.FetchNormalDimensionItem_Icd("02")?.icd_three_digits;
            obj.Primaertumor_ICD_Version = _generator.FetchRandomEnumItem<ICD_Version_Typ>(_config.IcdVersion_ProbMissing);
            obj.Primaertumor_Topographie_ICD_O_Version = _generator.FetchRandomEnumItem<PatientMeldungDiagnosePrimaertumor_Topographie_ICD_O_Version>();
            obj.Seitenlokalisation = _generator.FetchRandomEnumItem<Seitenlokalisation_Typ>();
            obj.Histologie = Create_Histologie();
            /* TNM */
            obj.cTNM = Create_TNM_Typ();
            obj.pTNM = Create_TNM_Typ();

            /* Module */
            obj.Modul_Mamma = Create_Modul_Mamma_Typ();
            obj.Modul_Darm = Create_Modul_Darm_Typ();
            obj.Modul_Prostata = Create_Modul_Prostata_Typ();

            obj.Diagnosesicherung = _generator.FetchRandomEnumItem<PatientMeldungDiagnoseDiagnosesicherung>(_config.Dsich_ProbMissing);
            obj.Seitenlokalisation = _generator.FetchRandomEnumItem<Seitenlokalisation_Typ>(0.2);
            return obj;
        }

        private Histologie Create_Histologie()
        {
            var obj = new Histologie();
            obj.Grading = _generator.FetchRandomEnumItem<Grading_Typ>(0.1);
            obj.Morphologie_Code = _generator.FetchNormalDimensionItem<Histology>().histology_shortname;
            obj.Morphologie_ICD_O_Version = _generator.FetchRandomEnumItem<Morphologie_ICD_O_Version_Typ>();
            return obj;
        }

        private Modul_Prostata Create_Modul_Prostata_Typ()
        {
            var obj = new Modul_Prostata();
            obj.PSA = _generator.CreateRandomValue(1, 100);
            obj.DatumStanzen = new Datum(_generator.CreateRandomDate_Meldedatum(),Datumsgenauigkeit_Typ.T);
            obj.GleasonScore = new GleasonScore();
            obj.GleasonScore.GleasonGradPrimaer = _generator.FetchRandomEnumItem<GleasonScore_Typ>();
            obj.GleasonScore.GleasonGradSekundaer = _generator.FetchRandomEnumItem<GleasonScore_Typ>();
            obj.GleasonScore.GleasonScoreErgebnis = _generator.FetchRandomEnumItem<GleasonScoreErgebnis_Typ>();
            return obj;
        }

        private Modul_Darm Create_Modul_Darm_Typ()
        {
            var obj = new Modul_Darm();
            obj.RASMutation = _generator.FetchRandomEnumItem<Modul_Darm_TypRASMutation>();
            return obj;
        }

        private Modul_Mamma Create_Modul_Mamma_Typ()
        {
            var obj = new Modul_Mamma();
            obj.Praetherapeutischer_Menopausenstatus = _generator.FetchRandomEnumItem<Modul_Mamma_TypPraetherapeutischer_Menopausenstatus>();
            obj.HormonrezeptorStatus_Oestrogen = _generator.FetchRandomEnumItem<Hormonrezeptor_Typ>();
            obj.HormonrezeptorStatus_Progesteron = _generator.FetchRandomEnumItem<Hormonrezeptor_Typ>();
            obj.Her2neuStatus = _generator.FetchRandomEnumItem<Hormonrezeptor_Typ>();
            obj.TumorgroesseInvasiv = ((int)_generator.CreateNormalValueUponMean(230, 10)).ToString();
            obj.TumorgroesseDCIS = ((int)_generator.CreateNormalValueUponMean(120, 10)).ToString();
            return obj;
        }

        private TNM Create_TNM_Typ()
        {
            var obj = new TNM();
            obj.TNM_Version = TNM_TypTNM_Version.Item7;
            obj.TNM_y_Symbol = TNM_TypTNM_y_Symbol.y;
            obj.TNM_a_Symbol = TNM_TypTNM_a_Symbol.a;
            obj.TNM_T = _generator.FetchRandomDimensionItem<T>()?.tnm_t_id;
            obj.TNM_N = _generator.FetchRandomDimensionItem<N>()?.tnm_n_id;
            obj.TNM_M = _generator.FetchRandomDimensionItem<M>()?.tnm_m_id;
            obj.TNM_c_p_u_Praefix_T = _generator.FetchRandomEnumItem<TNM_TypTNM_c_p_u_Praefix_T>();
            obj.TNM_c_p_u_Praefix_N = _generator.FetchRandomEnumItem<TNM_TypTNM_c_p_u_Praefix_N>();
            obj.TNM_c_p_u_Praefix_M = _generator.FetchRandomEnumItem<TNM_TypTNM_c_p_u_Praefix_M>();
            obj.TNM_L = _generator.FetchRandomEnumItem<TNM_TypTNM_L>();
            obj.TNM_V = _generator.FetchRandomEnumItem<TNM_TypTNM_V>();
            obj.TNM_Pn = _generator.FetchRandomEnumItem<TNM_TypTNM_Pn>();
            obj.TNM_S = _generator.FetchRandomEnumItem<TNM_TypTNM_S>();
            return obj;
        }
    }
}
