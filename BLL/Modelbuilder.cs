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
            obj.Bundesland_ID = _generator.FetchRandomEnumItem<ISO3199_2_Typ>();
            return obj;
        }

        private Patient Create_Patient()
        {
            var obj = new Patient();
            obj.Patienten_Stammdaten = Create_Patienten_Stammdaten();
            int _meldungCount = 1; //_generator.GetMeldungCountPerAge(_config.GetTimeToPublishDateInYears(obj.Patienten_Stammdaten.Patienten_Geburtsdatum));

            obj.Menge_Tumor = Enumerable
                .Range(1, _meldungCount)
                .Select(index => Create_Tumor())
                .ToList();
            obj.Patient_ID = Guid.NewGuid().ToString();
            return obj;
        }

        public Patienten_Stammdaten Create_Patienten_Stammdaten()
        {
            var obj = new Patienten_Stammdaten();
            obj.Geburtsdatum  = new Datum(_generator.CreateRandomDate_Geburtsdatum(), Datumsgenauigkeit_Typ.T);
            obj.Patient_ID = Guid.NewGuid().ToString();
            obj.Inzidenzort = _generator.CreateRandomValue_Inzidenzort();
            // HACK 
            if (true) //(_generator.CreateRandomBool())
                obj.Tod = Create_Tod();
            return obj;
        }

        private Tod Create_Tod()
        {
            var obj = new Tod();
            obj.Sterbedatum = new Datum(_generator.CreateRandomDate_Meldedatum(), Datumsgenauigkeit_Typ.T);
            obj.Grundleiden = create_Todesursache();
            obj.Menge_Weitere_Todesursachen = Enumerable
                .Range(1, 3)
                .Select(index => create_Todesursache())
                .ToList();
            return obj;
        }

        private Allgemein_ICD create_Todesursache()
        {
            var obj = new Allgemein_ICD();
            obj.Code = _generator.FetchNormalDimensionItem<Icd>().icd_four_digits;
            obj.Version = ICD_Version_Typ.Item102018GM;
            return obj;
        }

        private Tumor Create_Tumor()
        {
            var obj = new Tumor();
            obj.Primaerdiagnose = Create_Diagnose();

            /* OP */
            obj.Menge_OP = Enumerable
                .Range(1, _generator.CreateRandomValueInt(1,3))
                .Select(index => create_OP())
                .ToList();

            /* ST */
            obj.Menge_ST = Enumerable
                .Range(1, _generator.CreateRandomValueInt(1, 3))
                .Select(index => create_ST())
                .ToArray();

            /* SYST */
            obj.Menge_SYST = Enumerable
                .Range(1, _generator.CreateRandomValueInt(1, 3))
                .Select(index => create_SYST())
                .ToArray();


            /*  Verlauf */
            obj.Menge_Folgeereignis = Enumerable
                .Range(1, 3)
                .Select(index => Create_PatientMeldungVerlauf())
                .ToList();

            obj.Tumor_ID = Guid.NewGuid().ToString();
            return obj;
        }

        private SYST create_SYST()
        {
            var obj = new SYST();
            obj.Intention = _generator.FetchRandomEnumItem<SYST_Intention_Typ>();
            obj.Anzahl_Tage_Diagnose_SYST = _generator.CreateRandomValueInt(1, Globals.MAXANZTAGEZWISCHENEREIGNISSE);
            obj.Stellung_OP = _generator.FetchRandomEnumItem<SYST_Stellung_OP_Typ>();
            obj.Therapieart = _generator.FetchRandomEnumItem<SYST_Therapieart_Typ>();
            obj.Protokoll = create_Protokoll(); ;
            obj.Menge_Substanz = Enumerable
                .Range(1, _generator.CreateRandomValueInt(1, 3))
                .Select(index => create_Substanz())
                .ToArray();
            return obj;
        }

        private Protokoll create_Protokoll()
        {
            var obj = new Protokoll();
            if (_generator.CreateRandomBool())
            {
                obj.Bezeichnung = _generator.FetchNormalDimensionItem_QuoteString(30);
            }
            else
            {
                obj.Chemotherapie_Protokoll = new ();
                obj.Chemotherapie_Protokoll.Code = _generator.FetchNormalDimensionItem<Protocol>().protocol_shortname;
                obj.Chemotherapie_Protokoll.Version = _generator.CreateNormalValueUponRange(2008,2022).ToString();
            }
            return obj;
        }

        private Substanz create_Substanz()
        {
            var obj = new Substanz();
            if (_generator.CreateRandomBool())
            {
                obj.Bezeichnung = _generator.FetchNormalDimensionItem_QuoteString(30);
            }
            else
            {
                obj.ATC = new ATC();
                obj.ATC.Code = _generator.FetchNormalDimensionItem<Substance>().atc_level_5;
                obj.ATC.Version = "2019";
            }
            return obj;
        }

        private ST create_ST()
        {
            var obj = new ST();
            obj.Intention = _generator.FetchRandomEnumItem<ST_Intention_Typ>();
            obj.Stellung_OP = _generator.FetchRandomEnumItem<ST_Stellung_OP_Typ>();
            obj.Menge_Bestrahlung = Enumerable
                .Range(1, _generator.CreateRandomValueInt(1, 3))
                .Select(index => create_Bestrahlung())
                .ToArray();
            return obj;
        }

        private Bestrahlung create_Bestrahlung()
        {
            var obj = new Bestrahlung();
            obj.Anzahl_Tage_Diagnose_ST =  _generator.CreateRandomValueInt(1, Globals.MAXANZTAGEZWISCHENEREIGNISSE);
            obj.Anzahl_Tage_ST_Dauer = _generator.CreateRandomValueInt(1, Globals.MAXANZTAGEZWISCHENEREIGNISSE);
            obj.Applikationsart = create_Applikationsart();
            return obj;
        }

        private Applikationsart create_Applikationsart()
        {
            var obj = new Applikationsart();
            switch (_generator.CreateRandomValueInt(1,4))
            {
                case 1: obj.Perkutan = create_Perkutan(); break;
                case 2: obj.Kontakt = create_Kontakt(); break;
                case 3: obj.Metabolisch = create_Metabolisch(); break;
                case 4: obj.Sonstige = create_Sonstige(); break;
                default:
                    break;
            }
            return obj;            
        }

        private Sonstige create_Sonstige()
        {
            var obj = new Sonstige();
            obj.Zielgebiet = ceate_Zielgebiet();
            obj.Seite_Zielgebiet = _generator.FetchRandomEnumItem<Bestrahlung_Seite_Zielgebiet_Typ>();
            return obj;
        }

        private Zielgebiet ceate_Zielgebiet()
        {
            var obj = new Zielgebiet();
            if (_generator.CreateRandomBool())
            {
                obj.CodeVersion2021 = _generator.FetchRandomEnumItem<Bestrahlung_Zielgebiet_2021_Typ>();
                obj.CodeVersion2014 = Bestrahlung_Zielgebiet_2014_Typ.Default;
            } 
            else
            {
                obj.CodeVersion2021 = Bestrahlung_Zielgebiet_2021_Typ.Default;
                obj.CodeVersion2014 = _generator.FetchRandomEnumItem<Bestrahlung_Zielgebiet_2014_Typ>();
            }
            return obj;
        }

        private Metabolisch create_Metabolisch()
        {
            var obj = new Metabolisch ();
            obj.Zielgebiet = ceate_Zielgebiet();
            obj.Seite_Zielgebiet = _generator.FetchRandomEnumItem<Bestrahlung_Seite_Zielgebiet_Typ>();
            obj.Metabolisch_Typ = _generator.FetchRandomEnumItem<Bestrahlung_Applikationsart_Metabolisch_Typ>();
            return obj;
        }

        private Kontakt create_Kontakt()
        {
            var obj = new Kontakt();
            obj.Zielgebiet = ceate_Zielgebiet();
            obj.Seite_Zielgebiet = _generator.FetchRandomEnumItem<Bestrahlung_Seite_Zielgebiet_Typ>();
            obj.Interstitiell_endokavitaer = _generator.FetchRandomEnumItem<Bestrahlung_Applikationsart_Typ_Interstitiell_endokavitaer>();
            obj.Rate_Type = _generator.FetchRandomEnumItem<Bestrahlung_Applikationsart_Typ_Rate_Type>();
            return obj;
        }

        private Perkutan create_Perkutan()
        {
            var obj = new Perkutan();
            obj.Zielgebiet = ceate_Zielgebiet();
            obj.Seite_Zielgebiet = _generator.FetchRandomEnumItem<Bestrahlung_Seite_Zielgebiet_Typ>();
            obj.Radiochemo = _generator.FetchRandomEnumItem<Bestrahlung_Applikationsart_Typ_Radiochemo>();
            obj.Stereotaktisch = _generator.FetchRandomEnumItem<Bestrahlung_Applikationsart_Typ_Stereotaktisch>();
            obj.Atemgetriggert = _generator.FetchRandomEnumItem<Bestrahlung_Applikationsart_Typ_Atemgetriggert>();
            return obj;
        }

        private Residualstatus create_Residualstatus()
        {
            var obj = new Residualstatus();
            obj.Lokale_Beurteilung_Residualstatus = _generator.FetchRandomEnumItem<R_Typ>();
            obj.Gesamtbeurteilung_Residualstatus = _generator.FetchRandomEnumItem<R_Typ>();
            return obj;
        }

        private OP create_OP()
        {
            var obj = new OP();
            obj.Intention = _generator.FetchRandomEnumItem<OP_Intention_Typ>();
            obj.Datum = new Datum(_generator.CreateRandomDate_Meldedatum(), Datumsgenauigkeit_Typ.T);
            obj.Residualstatus = create_Residualstatus();
            obj.Menge_OPS = Enumerable
                .Range(1, _generator.CreateRandomValueInt(1, 5))
                .Select(index => create_OPS())
                .ToList();
            obj.Anzahl_Tage_Diagnose_OP =  _generator.CreateRandomValueInt(1, Globals.MAXANZTAGEZWISCHENEREIGNISSE);
            return obj;
        }

        private OPS create_OPS()
        {
            var obj = new OPS();
            obj.Code = _generator.FetchNormalDimensionItem<Ops>().ops_five_digits;
            return obj;
        }

        private Verlauf Create_PatientMeldungVerlauf()
        {
            var obj = new Verlauf();
            obj.Untersuchungsdatum_Verlauf = new Datum(_generator.CreateRandomDate_Meldedatum(), Datumsgenauigkeit_Typ.T);
            obj.Gesamtbeurteilung_Tumorstatus = _generator.FetchRandomEnumItem<Gesamtbeurteilung_Tumorstatus_Typ>();
            return obj;
        }

        private Diagnose Create_Diagnose()
        {
            var obj = new Diagnose();
            obj.Datum = new Datum(_generator.CreateRandomDate_Meldedatum(), Datumsgenauigkeit_Typ.T);
            obj.Primaertumor_ICD = new Tumor_ICD();
            obj.Primaertumor_ICD.Code = _generator.FetchNormalDimensionItem_Icd("02")?.icd_three_digits;
            obj.Primaertumor_ICD.Version = _generator.FetchRandomEnumItem<ICD_Version_Typ>(_config.IcdVersion_ProbMissing);
            obj.Primaertumor_Topographie_ICD_O = new Topographie_ICD();
            obj.Primaertumor_Topographie_ICD_O.Code = _generator.FetchNormalDimensionItem_Icd("02")?.icd_four_digits;
            obj.Primaertumor_Topographie_ICD_O.Version = _generator.FetchRandomEnumItem<Topographie_ICD_O_Version_Typ>();
            obj.Seitenlokalisation = _generator.FetchRandomEnumItem<Seitenlokalisation_Typ>();
            obj.Histologie = Create_Histologie();

            obj.Menge_FM = Enumerable
                .Range(1, 3)
                .Select(index => create_FM())
                .ToList();


            /* TNM */
            obj.cTNM = Create_TNM_Typ();
            obj.pTNM = Create_TNM_Typ();

            /* Module */
            obj.Modul_Mamma = Create_Modul_Mamma_Typ();
            obj.Modul_Darm = Create_Modul_Darm_Typ();
            obj.Modul_Prostata = Create_Modul_Prostata_Typ();
            obj.Modul_Malignes_Melanom = create_Malignes_Melanom();

            obj.Diagnosesicherung = _generator.FetchRandomEnumItem<Diagnosesicherung_Typ>(_config.Dsich_ProbMissing);
            obj.Seitenlokalisation = _generator.FetchRandomEnumItem<Seitenlokalisation_Typ>(0.2);

            obj.DCN = _generator.FetchRandomEnumItem<JNU_Typ>();
            obj.Anzahl_Tage_Diagnose_Tod = _generator.CreateRandomValueInt(1, Globals.MAXANZTAGEZWISCHENEREIGNISSE);
            return obj;
        }

        private Modul_Malignes_Melanom create_Malignes_Melanom()
        {
            var obj = new Modul_Malignes_Melanom();
            obj.LDH = _generator.CreateRandomValueInt(1, 10000);
            obj.Tumordicke = _generator.CreateRandomValueDouble(0.1, 99);
            return obj;
        }

        private Fernmetastase create_FM()
        {
            var obj = new Fernmetastase();
            obj.Lokalisation = _generator.FetchRandomEnumItem<FM_Lokalisation_Typ>();
            obj.Diagnosedatum = new Datum(_generator.CreateRandomDate_Meldedatum(), Datumsgenauigkeit_Typ.T);
            return obj;
        }

        private Histologie Create_Histologie()
        {
            var obj = new Histologie();
            obj.Menge_Morphologie = Enumerable
                .Range(1, 5)
                .Select(index => create_Morphologie())
                .ToList();

            obj.Grading = _generator.FetchRandomEnumItem<Grading_Typ>(0.1);
            obj.LK_untersucht = _generator.CreateRandomValueInt(0, 10);
            obj.LK_befallen = _generator.CreateRandomValueInt(0, 10);
            return obj;
        }

        private Morphologie_ICD_O create_Morphologie()
        {
            var obj = new Morphologie_ICD_O();
            obj.Code = _generator.FetchNormalDimensionItem_HistologySlashDignity();
            obj.Version = _generator.FetchRandomEnumItem<Morphologie_ICD_O_Version_Typ>();
            return obj;
        }

        private Modul_Prostata Create_Modul_Prostata_Typ()
        {
            var obj = new Modul_Prostata();
            obj.PSA = _generator.CreateRandomValueInt(1, 100);
            obj.DatumStanzen = new Datum(_generator.CreateRandomDate_Meldedatum(),Datumsgenauigkeit_Typ.T);
            obj.GleasonScore = new GleasonScore();
            obj.GleasonScore.GradPrimaer = _generator.FetchRandomEnumItem<GleasonScore_Typ>();
            obj.GleasonScore.GradSekundaer = _generator.FetchRandomEnumItem<GleasonScore_Typ>();
            obj.GleasonScore.ScoreErgebnis = _generator.FetchRandomEnumItem<GleasonScoreErgebnis_Typ>();
            return obj;
        }

        private Modul_Darm Create_Modul_Darm_Typ()
        {
            var obj = new Modul_Darm();
            obj.RASMutation = _generator.FetchRandomEnumItem<RASMutation_Typ>();
            return obj;
        }

        private Modul_Mamma Create_Modul_Mamma_Typ()
        {
            var obj = new Modul_Mamma();
            obj.Praetherapeutischer_Menopausenstatus = _generator.FetchRandomEnumItem<Praetherapeutischer_Menopausenstatus_Typ>();
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
            obj.Version = TNM_Version_Typ.Item7;
            obj.y_Symbol = TNM_TypTNM_y_Symbol.y;
            obj.a_Symbol = TNM_TypTNM_a_Symbol.a;
            obj.T = _generator.FetchRandomDimensionItem<T>()?.tnm_t_shortname;
            obj.N = _generator.FetchRandomDimensionItem<N>()?.tnm_n_shortname;
            obj.M = _generator.FetchRandomDimensionItem<M>()?.tnm_m_shortname;
            obj.c_p_u_Praefix_T = _generator.FetchRandomEnumItem<TNM_TypTNM_c_p_u_Praefix_T>();
            obj.c_p_u_Praefix_N = _generator.FetchRandomEnumItem<TNM_TypTNM_c_p_u_Praefix_N>();
            obj.c_p_u_Praefix_M = _generator.FetchRandomEnumItem<TNM_TypTNM_c_p_u_Praefix_M>();
            obj.L = _generator.FetchRandomEnumItem<TNM_TypTNM_L>();
            obj.V = _generator.FetchRandomEnumItem<TNM_TypTNM_V>();
            obj.Pn = _generator.FetchRandomEnumItem<TNM_TypTNM_Pn>();
            obj.S = _generator.FetchRandomEnumItem<TNM_TypTNM_S>();
            return obj;
        }
    }
}
