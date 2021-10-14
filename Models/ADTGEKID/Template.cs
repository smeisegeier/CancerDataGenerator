
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class ADT_GEKID
    {
        public ADT_GEKIDPatient[] Menge_Patient { get; set; }

        public Melder_Typ[] Menge_Melder { get; set; }

        public ADT_GEKIDSchema_Version Schema_Version { get; set; }
    }

    public partial class ADT_GEKIDAbsender
    {
       
        public string Absender_Bezeichnung { get; set; }

        
        public string Absender_Ansprechpartner { get; set; }


        public string Absender_Anschrift { get; set; }


        public string Absender_Telefon { get; set; }


        public string Absender_EMail { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Absender_ID { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Software_ID { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Installations_ID { get; set; }
    }

    public partial class Melder_Typ
    {
        public string Melder_IKNR { get; set; }

        
        public string Melder_LANR { get; set; }


        public string Melder_BSNR { get; set; }

        
        public string Meldende_Stelle { get; set; }


        
        public string Melder_KH_Abt_Station_Praxis { get; set; }

        
        public string Melder_Arztname { get; set; }

        
        public string Melder_Anschrift { get; set; }

        
        public string Melder_PLZ { get; set; }

        
        public string Melder_Ort { get; set; }

        
        public string Melder_Bankname { get; set; }

        
        public string Melder_Kontoinhaber { get; set; }

        
        public string Melder_BIC { get; set; }

        
        public string Melder_IBAN { get; set; }

        public string Melder_ID { get; set; }
    }

    public partial class Nebenwirkung_Typ
    {
       
        public Nebenwirkung_TypNebenwirkung_Grad Nebenwirkung_Grad { get; set; }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Nebenwirkung_GradSpecified { get; set; }

        public string Nebenwirkung_Art { get; set; }


        public Nebenwirkung_TypNebenwirkung_Version Nebenwirkung_Version { get; set; }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Nebenwirkung_VersionSpecified { get; set; }
    }

    public enum Nebenwirkung_TypNebenwirkung_Grad
    {
        
        K,
        
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        U,
    }

    public enum Nebenwirkung_TypNebenwirkung_Version
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.03")]
        Item403,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.0")]
        Item50,

        
        Sonstige,
    }

    public partial class Strahlendosis_Typ
    {
        
        public decimal Dosis { get; set; }
        
        public Strahlendosis_TypEinheit Einheit { get; set; }
    }

    public enum Strahlendosis_TypEinheit
    {
        Gy,
        GBq,
    }

    public partial class Residualstatus_Typ
    {
        public R_Typ Lokale_Beurteilung_Residualstatus { get; set; }
        public bool Lokale_Beurteilung_ResidualstatusSpecified { get; set; }
        public R_Typ Gesamtbeurteilung_Residualstatus { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Gesamtbeurteilung_ResidualstatusSpecified { get; set; }
    }

    public enum R_Typ
    {
        R0,
        R1,
        [System.Xml.Serialization.XmlEnumAttribute("R1(is)")]
        R1is,
        [System.Xml.Serialization.XmlEnumAttribute("R1(cy+)")]
        R1cy,
        R2,
        RX,
    }

    public partial class Datum_NU_Typ
    {
        [System.Xml.Serialization.XmlElementAttribute("Datum", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("NU", typeof(Datum_NU_TypNU))]
        public object Item { get; set; }
    }

    public enum Datum_NU_TypNU
    {
        N,
        U,
    }

    public partial class Modul_Allgemein_Typ
    {
        public Datum_NU_Typ DatumSozialdienstkontakt { get; set; }
        public Datum_NU_Typ DatumStudienrekrutierung { get; set; }
    }

    public partial class Modul_Malignes_Melanom_Typ
    {
        
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Sicherheitsabstand_Primaertumor { get; set; }

        public decimal Tumordicke { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TumordickeSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string LDH { get; set; }

        public JNU_Typ Ulzeration { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UlzerationSpecified { get; set; }
    }

    public enum JNU_Typ
    {
        J,
        N,
        U
    }

    public partial class Modul_Prostata_Typ
    {
        public Modul_Prostata_TypGleasonScore GleasonScore { get; set; }
        public Modul_Prostata_TypAnlassGleasonScore AnlassGleasonScore { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnlassGleasonScoreSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DatumStanzen { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatumStanzenSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string AnzahlStanzen { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string AnzahlPosStanzen { get; set; }

        public Modul_Prostata_TypCaBefallStanze CaBefallStanze { get; set; }

        public decimal PSA { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PSASpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DatumPSA { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatumPSASpecified { get; set; }

        public JNU_Typ KomplPostOP_ClavienDindo { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KomplPostOP_ClavienDindoSpecified { get; set; }
    }

    public partial class Modul_Prostata_TypGleasonScore
    {
        public Modul_Prostata_TypGleasonScoreGleasonGradPrimaer GleasonGradPrimaer { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GleasonGradPrimaerSpecified { get; set; }

        public Modul_Prostata_TypGleasonScoreGleasonGradSekundaer GleasonGradSekundaer { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GleasonGradSekundaerSpecified { get; set; }

        public Modul_Prostata_TypGleasonScoreGleasonScoreErgebnis GleasonScoreErgebnis { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GleasonScoreErgebnisSpecified { get; set; }
    }

    public enum Modul_Prostata_TypGleasonScoreGleasonGradPrimaer
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }
    public enum Modul_Prostata_TypGleasonScoreGleasonGradSekundaer
    {
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    public enum Modul_Prostata_TypGleasonScoreGleasonScoreErgebnis
    {

        
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        
        [System.Xml.Serialization.XmlEnumAttribute("7a")]
        Item7a,

        
        [System.Xml.Serialization.XmlEnumAttribute("7b")]
        Item7b,

        
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
    }

    public enum Modul_Prostata_TypAnlassGleasonScore
    {
        O,
        S,
        U,
    }

    // TODO item vs enum
    public partial class Modul_Prostata_TypCaBefallStanze
    {
        [System.Xml.Serialization.XmlElementAttribute("Prozentzahl", typeof(string), DataType = "positiveInteger")]
        [System.Xml.Serialization.XmlElementAttribute("U", typeof(Modul_Prostata_TypCaBefallStanzeU))]
        public object Item { get; set; }
    }

    public enum Modul_Prostata_TypCaBefallStanzeU
    {
        U
    }

    public partial class Modul_Darm_Typ
    {
        public string RektumAbstandAnokutanlinie { get; set; }

        public string RektumAbstandAboralerResektionsrand { get; set; }

        public string RektumAbstandCircResektionsebene { get; set; }

        public Modul_Darm_TypRektumQualitaetTME RektumQualitaetTME { get; set; }

        public bool RektumQualitaetTMESpecified { get; set; }

        public string RektumMRTDuennschichtAngabemesorektaleFaszie { get; set; }

        public Modul_Darm_TypArtEingriff ArtEingriff { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArtEingriffSpecified { get; set; }

        public Modul_Darm_TypRektumAnzeichnungStomaposition RektumAnzeichnungStomaposition { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RektumAnzeichnungStomapositionSpecified { get; set; }

        public Modul_Darm_TypGradRektumAnastomoseninsuffizienz GradRektumAnastomoseninsuffizienz { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GradRektumAnastomoseninsuffizienzSpecified { get; set; }

        public Modul_Darm_TypASA ASA { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ASASpecified { get; set; }

        public Modul_Darm_TypRASMutation RASMutation { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RASMutationSpecified { get; set; }
    }

    public enum Modul_Darm_TypRektumQualitaetTME
    {
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        
        P,

        
        L,

        
        A,

        
        U,
    }

    public enum Modul_Darm_TypArtEingriff
    {
        E,
        N,

        
        U,
    }

    public enum Modul_Darm_TypRektumAnzeichnungStomaposition
    {

        
        D,

        
        N,

        
        K,

        
        S,

        
        U,
    }

    public enum Modul_Darm_TypGradRektumAnastomoseninsuffizienz
    {

        
        B,

        
        C,

        
        K,

        
        U,
    }
    public enum Modul_Darm_TypASA
    {

        
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    public enum Modul_Darm_TypRASMutation
    {

        
        W,

        
        M,

        
        U,

        
        N,
    }

    public partial class Modul_Mamma_Typ
    {

        
        public Modul_Mamma_TypPraetherapeutischer_Menopausenstatus Praetherapeutischer_Menopausenstatus { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Praetherapeutischer_MenopausenstatusSpecified { get; set; }

        
        public Hormonrezeptor_Typ HormonrezeptorStatus_Oestrogen { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HormonrezeptorStatus_OestrogenSpecified { get; set; }

        
        public Hormonrezeptor_Typ HormonrezeptorStatus_Progesteron { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HormonrezeptorStatus_ProgesteronSpecified { get; set; }

        
        public Hormonrezeptor_Typ Her2neuStatus { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Her2neuStatusSpecified { get; set; }

        
        public Modul_Mamma_TypPraeopDrahtmarkierung PraeopDrahtmarkierung { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PraeopDrahtmarkierungSpecified { get; set; }

        
        public Modul_Mamma_TypIntraopPraeparatkontrolle IntraopPraeparatkontrolle { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntraopPraeparatkontrolleSpecified { get; set; }

        
        public string TumorgroesseInvasiv { get; set; }

        
        public string TumorgroesseDCIS { get; set; }
    }

    public enum Modul_Mamma_TypPraetherapeutischer_Menopausenstatus
    {

        
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        
        U,
    }

    public enum Hormonrezeptor_Typ
    {
        
        P,

        
        N,

        
        U,
    }

    public enum Modul_Mamma_TypPraeopDrahtmarkierung
    {

        
        M,

        
        S,

        
        T,

        
        N,

        
        U,
    }

    public enum Modul_Mamma_TypIntraopPraeparatkontrolle
    {

        
        M,

        
        S,

        
        N,

        
        U,
    }

    public partial class TNM_Typ
    {
        
        public string TNM_Datum { get; set; }

        
        public TNM_TypTNM_Version TNM_Version { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TNM_VersionSpecified { get; set; }

        
        public TNM_TypTNM_y_Symbol TNM_y_Symbol { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TNM_y_SymbolSpecified { get; set; }

        
        public TNM_TypTNM_r_Symbol TNM_r_Symbol { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TNM_r_SymbolSpecified { get; set; }

        
        public TNM_TypTNM_a_Symbol TNM_a_Symbol { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TNM_a_SymbolSpecified { get; set; }

        
        public TNM_TypTNM_c_p_u_Praefix_T TNM_c_p_u_Praefix_T { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TNM_c_p_u_Praefix_TSpecified { get; set; }

        
        public string TNM_T { get; set; }

        
        public string TNM_m_Symbol { get; set; }

        
        public TNM_TypTNM_c_p_u_Praefix_N TNM_c_p_u_Praefix_N { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TNM_c_p_u_Praefix_NSpecified { get; set; }

        
        public string TNM_N { get; set; }

        
        public TNM_TypTNM_c_p_u_Praefix_M TNM_c_p_u_Praefix_M { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TNM_c_p_u_Praefix_MSpecified { get; set; }

        
        public string TNM_M { get; set; }

        
        public TNM_TypTNM_L TNM_L { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TNM_LSpecified { get; set; }

        
        public TNM_TypTNM_V TNM_V { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TNM_VSpecified { get; set; }

        
        public TNM_TypTNM_Pn TNM_Pn { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TNM_PnSpecified { get; set; }

        
        public TNM_TypTNM_S TNM_S { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TNM_SSpecified { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TNM_ID { get; set; }
    }

    public enum TNM_TypTNM_Version
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
    }

    public enum TNM_TypTNM_y_Symbol
    {
        
        y,
    }

    public enum TNM_TypTNM_r_Symbol
    {
        
        r,
    }

    public enum TNM_TypTNM_a_Symbol
    {

        
        a,
    }

    public enum TNM_TypTNM_c_p_u_Praefix_T
    {
        
        c,

        
        p,

        
        u,
    }

    public enum TNM_TypTNM_c_p_u_Praefix_N
    {

        
        c,

        
        p,

        
        u,
    }

    public enum TNM_TypTNM_c_p_u_Praefix_M
    {

        
        c,

        
        p,

        
        u,
    }

    public enum TNM_TypTNM_L
    {

        
        LX,

        
        L0,

        
        L1,
    }

    public enum TNM_TypTNM_V
    {

        
        VX,

        
        V0,

        
        V1,

        
        V2,
    }

    public enum TNM_TypTNM_Pn
    {

        
        PnX,

        
        Pn0,

        
        Pn1,
    }

    public enum TNM_TypTNM_S
    {

        
        SX,

        
        S0,

        
        S1,

        
        S2,

        
        S3,
    }

    public partial class Histologie_Typ
    {
        public string Tumor_Histologiedatum { get; set; }

        
        public string Histologie_EinsendeNr { get; set; }

        
        public string Morphologie_Code { get; set; }

        
        public Histologie_TypMorphologie_ICD_O_Version Morphologie_ICD_O_Version { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Morphologie_ICD_O_VersionSpecified { get; set; }

        
        public string Morphologie_Freitext { get; set; }

        
        public Histologie_TypGrading Grading { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GradingSpecified { get; set; }

        
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string LK_untersucht { get; set; }

        
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string LK_befallen { get; set; }

        
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string Sentinel_LK_untersucht { get; set; }

        
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string Sentinel_LK_befallen { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Histologie_ID { get; set; }
    }

    public enum Histologie_TypMorphologie_ICD_O_Version
    {

        
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,

        
        bb,
    }

    public enum Histologie_TypGrading
    {

        
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        
        X,

        
        L,

        
        M,

        
        H,

        
        B,

        
        U,

        
        T,
    }

    public partial class ADT_GEKIDPatient
    {
        
        public ADT_GEKIDPatientPatienten_Stammdaten Patienten_Stammdaten { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Meldung", IsNullable = false)]
        public ADT_GEKIDPatientMeldung[] Menge_Meldung { get; set; }

        
        public string Anmerkung { get; set; }
    }

    public partial class ADT_GEKIDPatientPatienten_Stammdaten
    {
        public string KrankenversichertenNr { get; set; }

        
        public string FamilienangehoerigenNr { get; set; }

        
        public string KrankenkassenNr { get; set; }

        
        public string Patienten_Nachname { get; set; }

        
        public string Patienten_Titel { get; set; }

        
        public string Patienten_Namenszusatz { get; set; }

        
        public string Patienten_Vornamen { get; set; }

        
        public string Patienten_Geburtsname { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Patienten_Frueherer_Name", IsNullable = false)]
        public string[] Menge_Frueherer_Name { get; set; }

        
        public ADT_GEKIDPatientPatienten_StammdatenPatienten_Geschlecht Patienten_Geschlecht { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Patienten_GeschlechtSpecified { get; set; }

        
        public string Patienten_Geburtsdatum { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Adresse", IsNullable = false)]
        public ADT_GEKIDPatientPatienten_StammdatenAdresse[] Menge_Adresse { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Patient_ID { get; set; }
    }

    public enum ADT_GEKIDPatientPatienten_StammdatenPatienten_Geschlecht
    {

        
        M,

        
        W,

        
        S,

        
        U,
    }

    public partial class ADT_GEKIDPatientPatienten_StammdatenAdresse
    {

        
        public string Patienten_Strasse { get; set; }

        
        public string Patienten_Hausnummer { get; set; }

        
        public string Patienten_Land { get; set; }

        
        public string Patienten_PLZ { get; set; }

        
        public string Patienten_Ort { get; set; }

        
        public string Gueltig_von { get; set; }

        
        public string Gueltig_bis { get; set; }
    }

    public partial class ADT_GEKIDPatientMeldung
    {
        public string Meldedatum { get; set; }

        
        public ADT_GEKIDPatientMeldungMeldebegruendung Meldebegruendung { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MeldebegruendungSpecified { get; set; }

        
        public ADT_GEKIDPatientMeldungMeldeanlass Meldeanlass { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MeldeanlassSpecified { get; set; }

        
        public ADT_GEKIDPatientMeldungTumorzuordnung Tumorzuordnung { get; set; }

        
        public ADT_GEKIDPatientMeldungDiagnose Diagnose { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("OP", IsNullable = false)]
        public ADT_GEKIDPatientMeldungOP[] Menge_OP { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("ST", IsNullable = false)]
        public ADT_GEKIDPatientMeldungST[] Menge_ST { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("SYST", IsNullable = false)]
        public ADT_GEKIDPatientMeldungSYST[] Menge_SYST { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Verlauf", IsNullable = false)]
        public ADT_GEKIDPatientMeldungVerlauf[] Menge_Verlauf { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Tumorkonferenz", IsNullable = false)]
        public ADT_GEKIDPatientMeldungTumorkonferenz[] Menge_Tumorkonferenz { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Zusatzitem", IsNullable = false)]
        public ADT_GEKIDPatientMeldungZusatzitem[] Menge_Zusatzitem { get; set; }

        
        public string Anmerkung { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Meldung_ID { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Melder_ID { get; set; }
    }

    public enum ADT_GEKIDPatientMeldungMeldebegruendung
    {

        
        I,

        
        A,

        
        D,

        
        W,

        
        V,
    }

    public enum ADT_GEKIDPatientMeldungMeldeanlass
    {

        
        diagnose,

        
        behandlungsbeginn,

        
        behandlungsende,

        
        statusaenderung,

        
        statusmeldung,

        
        tod,

        
        histologie_zytologie,
    }

    public partial class ADT_GEKIDPatientMeldungTumorzuordnung
    {
        
        public string Primaertumor_ICD_Code { get; set; }

        
        public ICD_Version_Typ Primaertumor_ICD_Version { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Primaertumor_ICD_VersionSpecified { get; set; }

        
        public string Diagnosedatum { get; set; }

        
        public Seitenlokalisation_Typ Seitenlokalisation { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeitenlokalisationSpecified { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tumor_ID { get; set; }
    }

    public enum ICD_Version_Typ
    {

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2004 GM")]
        Item102004GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2005 GM")]
        Item102005GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2006 GM")]
        Item102006GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2007 GM")]
        Item102007GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2008 GM")]
        Item102008GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2009 GM")]
        Item102009GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2010 GM")]
        Item102010GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2011 GM")]
        Item102011GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2012 GM")]
        Item102012GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2013 GM")]
        Item102013GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2014 GM")]
        Item102014GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2015 GM")]
        Item102015GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2016 GM")]
        Item102016GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2016 WHO")]
        Item102016WHO,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2017 GM")]
        Item102017GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2018 GM")]
        Item102018GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2019 GM")]
        Item102019GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2020 GM")]
        Item102020GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2021 GM")]
        Item102021GM,

        
        [System.Xml.Serialization.XmlEnumAttribute("10 2022 GM")]
        Item102022GM,

        
        Sonstige,
    }

    public enum Seitenlokalisation_Typ
    {

        
        L,

        
        R,

        
        B,

        
        M,

        
        U,

        
        T,
    }

    public partial class ADT_GEKIDPatientMeldungDiagnose
    {

        
        public string Primaertumor_ICD_Code { get; set; }
        
        public ICD_Version_Typ Primaertumor_ICD_Version { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Primaertumor_ICD_VersionSpecified { get; set; }

        
        public string Primaertumor_Diagnosetext { get; set; }

        
        public string Primaertumor_Topographie_ICD_O { get; set; }

        
        public ADT_GEKIDPatientMeldungDiagnosePrimaertumor_Topographie_ICD_O_Version Primaertumor_Topographie_ICD_O_Version { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Primaertumor_Topographie_ICD_O_VersionSpecified { get; set; }

        
        public string Primaertumor_Topographie_ICD_O_Freitext { get; set; }

        
        public string Diagnosedatum { get; set; }

        
        public ADT_GEKIDPatientMeldungDiagnoseDiagnosesicherung Diagnosesicherung { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiagnosesicherungSpecified { get; set; }

        
        public Seitenlokalisation_Typ Seitenlokalisation { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeitenlokalisationSpecified { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Fruehere_Tumorerkrankung", IsNullable = false)]
        public ADT_GEKIDPatientMeldungDiagnoseFruehere_Tumorerkrankung[] Menge_Fruehere_Tumorerkrankung { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Histologie", IsNullable = false)]
        public Histologie_Typ[] Menge_Histologie { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Fernmetastase", IsNullable = false)]
        public Menge_FM_TypFernmetastase[] Menge_FM { get; set; }

        
        public TNM_Typ cTNM { get; set; }

        
        public TNM_Typ pTNM { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Weitere_Klassifikation", IsNullable = false)]
        public Menge_Weitere_Klassifikation_TypWeitere_Klassifikation[] Menge_Weitere_Klassifikation { get; set; }

        
        public Modul_Mamma_Typ Modul_Mamma { get; set; }

        
        public Modul_Darm_Typ Modul_Darm { get; set; }

        
        public Modul_Prostata_Typ Modul_Prostata { get; set; }

        
        public Modul_Malignes_Melanom_Typ Modul_Malignes_Melanom { get; set; }

        
        public Modul_Allgemein_Typ Modul_Allgemein { get; set; }

        
        public Allgemeiner_Leistungszustand_Typ Allgemeiner_Leistungszustand { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Allgemeiner_LeistungszustandSpecified { get; set; }
        
        public string Anmerkung { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tumor_ID { get; set; }
    }

    public enum ADT_GEKIDPatientMeldungDiagnosePrimaertumor_Topographie_ICD_O_Version
    {

        
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,
    }
    public enum ADT_GEKIDPatientMeldungDiagnoseDiagnosesicherung
    {

        
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    public partial class ADT_GEKIDPatientMeldungDiagnoseFruehere_Tumorerkrankung
    {
        
        public string Freitext { get; set; }

        
        public string ICD_Code { get; set; }

        
        public ICD_Version_Typ ICD_Version { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ICD_VersionSpecified { get; set; }

        
        public string Diagnosedatum { get; set; }
    }

    public partial class Menge_FM_TypFernmetastase
    {
        
        public string FM_Diagnosedatum { get; set; }

        
        public Menge_FM_TypFernmetastaseFM_Lokalisation FM_Lokalisation { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FM_LokalisationSpecified { get; set; }
    }

    public enum Menge_FM_TypFernmetastaseFM_Lokalisation
    {

        
        PUL,

        
        OSS,

        
        HEP,

        
        BRA,

        
        LYM,

        
        MAR,

        
        PLE,

        
        PER,

        
        ADR,

        
        SKI,

        
        OTH,

        
        GEN,
    }

    public partial class Menge_Weitere_Klassifikation_TypWeitere_Klassifikation
    {

        
        public string Datum { get; set; }

        
        public string Name { get; set; }

        
        public string Stadium { get; set; }
    }

    public enum Allgemeiner_Leistungszustand_Typ
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        
        U,

        
        [System.Xml.Serialization.XmlEnumAttribute("10%")]
        Item10,

        
        [System.Xml.Serialization.XmlEnumAttribute("20%")]
        Item20,

        
        [System.Xml.Serialization.XmlEnumAttribute("30%")]
        Item30,

        
        [System.Xml.Serialization.XmlEnumAttribute("40%")]
        Item40,

        
        [System.Xml.Serialization.XmlEnumAttribute("50%")]
        Item50,

        
        [System.Xml.Serialization.XmlEnumAttribute("60%")]
        Item60,

        
        [System.Xml.Serialization.XmlEnumAttribute("70%")]
        Item70,

        
        [System.Xml.Serialization.XmlEnumAttribute("80%")]
        Item80,

        
        [System.Xml.Serialization.XmlEnumAttribute("90%")]
        Item90,

        
        [System.Xml.Serialization.XmlEnumAttribute("100%")]
        Item100,
    }

    public partial class ADT_GEKIDPatientMeldungOP
    {

        
        public ADT_GEKIDPatientMeldungOPOP_Intention OP_Intention { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OP_IntentionSpecified { get; set; }

        
        public string OP_Datum { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("OP_OPS", IsNullable = false)]
        public string[] Menge_OPS { get; set; }

        
        public ADT_GEKIDPatientMeldungOPOP_OPS_Version OP_OPS_Version { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OP_OPS_VersionSpecified { get; set; }

        
        public Histologie_Typ Histologie { get; set; }

        
        public TNM_Typ TNM { get; set; }

        
        public Residualstatus_Typ Residualstatus { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("OP_Komplikation", IsNullable = false)]
        public ADT_GEKIDPatientMeldungOPOP_Komplikation[] Menge_Komplikation { get; set; }

        
        public Modul_Mamma_Typ Modul_Mamma { get; set; }
        
        public Modul_Darm_Typ Modul_Darm { get; set; }
        
        public Modul_Prostata_Typ Modul_Prostata { get; set; }

        
        public Modul_Malignes_Melanom_Typ Modul_Malignes_Melanom { get; set; }

        
        public Modul_Allgemein_Typ Modul_Allgemein { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Name_Operateur", IsNullable = false)]
        public string[] Menge_Operateur { get; set; }

        
        public string Anmerkung { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OP_ID { get; set; }
    }

    public enum ADT_GEKIDPatientMeldungOPOP_Intention
    {

        
        K,

        
        P,

        
        D,

        
        R,

        
        S,

        
        X,
    }

    public enum ADT_GEKIDPatientMeldungOPOP_OPS_Version
    {

        
        [System.Xml.Serialization.XmlEnumAttribute("2004")]
        Item2004,

        
        [System.Xml.Serialization.XmlEnumAttribute("2005")]
        Item2005,

        
        [System.Xml.Serialization.XmlEnumAttribute("2006")]
        Item2006,

        
        [System.Xml.Serialization.XmlEnumAttribute("2007")]
        Item2007,

        
        [System.Xml.Serialization.XmlEnumAttribute("2008")]
        Item2008,

        
        [System.Xml.Serialization.XmlEnumAttribute("2009")]
        Item2009,

        
        [System.Xml.Serialization.XmlEnumAttribute("2010")]
        Item2010,

        
        [System.Xml.Serialization.XmlEnumAttribute("2011")]
        Item2011,

        
        [System.Xml.Serialization.XmlEnumAttribute("2012")]
        Item2012,

        
        [System.Xml.Serialization.XmlEnumAttribute("2013")]
        Item2013,

        
        [System.Xml.Serialization.XmlEnumAttribute("2014")]
        Item2014,

        
        [System.Xml.Serialization.XmlEnumAttribute("2015")]
        Item2015,

        
        [System.Xml.Serialization.XmlEnumAttribute("2016")]
        Item2016,

        
        [System.Xml.Serialization.XmlEnumAttribute("2017")]
        Item2017,

        
        [System.Xml.Serialization.XmlEnumAttribute("2018")]
        Item2018,

        
        [System.Xml.Serialization.XmlEnumAttribute("2019")]
        Item2019,

        
        [System.Xml.Serialization.XmlEnumAttribute("2020")]
        Item2020,

        
        [System.Xml.Serialization.XmlEnumAttribute("2021")]
        Item2021,

        
        [System.Xml.Serialization.XmlEnumAttribute("2022")]
        Item2022,
    }
    public enum ADT_GEKIDPatientMeldungOPOP_Komplikation
    {

        
        N,

        
        U,

        
        ABD,

        
        ABS,

        
        ASF,

        
        ANI,

        
        AEP,

        
        ALR,

        
        ANS,

        
        AEE,

        
        API,

        
        BIF,

        
        BOG,

        
        BOE,

        
        BSI,

        
        CHI,

        
        DAI,

        
        DPS,

        
        DIC,

        
        DEP,

        
        DLU,

        
        DSI,

        
        ENF,

        
        GER,

        
        HEM,

        
        HUR,

        
        HAE,

        
        HFI,

        
        HNK,

        
        HZI,

        
        HRS,

        
        HNA,

        
        HOP,

        
        HYB,

        
        HYF,

        
        IFV,

        
        KAS,

        
        KES,

        
        KIM,

        
        KRA,

        
        KDS,

        
        LEV,

        
        LOE,

        
        LYF,

        
        LYE,

        
        MES,

        
        MIL,

        
        MED,

        
        MAT,

        
        MYI,

        
        RNB,

        
        NAB,

        
        NIN,

        
        OES,

        
        OSM,

        
        PAF,

        
        PIT,

        
        PAB,

        
        PPA,

        
        PAV,

        
        PER,

        
        PLB,

        
        PEY,

        
        PLE,

        
        PMN,

        
        PNT,

        
        PDA,

        
        PAE,

        
        RPA,

        
        RIN,

        
        SKI,

        
        SES,

        
        SFH,

        
        SON,

        
        STK,

        
        TZP,

        
        TIA,

        
        TRZ,

        
        WUH,

        
        WSS,
    }

    public partial class ADT_GEKIDPatientMeldungST
    {
        
        public ADT_GEKIDPatientMeldungSTST_Intention ST_Intention { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ST_IntentionSpecified { get; set; }

        
        public ADT_GEKIDPatientMeldungSTST_Stellung_OP ST_Stellung_OP { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ST_Stellung_OPSpecified { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Bestrahlung", IsNullable = false)]
        public ADT_GEKIDPatientMeldungSTBestrahlung[] Menge_Bestrahlung { get; set; }

        
        public ADT_GEKIDPatientMeldungSTST_Ende_Grund ST_Ende_Grund { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ST_Ende_GrundSpecified { get; set; }

        
        public Residualstatus_Typ Residualstatus { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("ST_Nebenwirkung", IsNullable = false)]
        public Nebenwirkung_Typ[] Menge_Nebenwirkung { get; set; }

        
        public Modul_Allgemein_Typ Modul_Allgemein { get; set; }

        
        public string Anmerkung { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ST_ID { get; set; }
    }

    public enum ADT_GEKIDPatientMeldungSTST_Intention
    {

        
        K,

        
        P,

        
        S,

        
        X,
    }

    public enum ADT_GEKIDPatientMeldungSTST_Stellung_OP
    {

        
        O,

        
        A,

        
        N,

        
        I,

        
        S,
    }

    public partial class ADT_GEKIDPatientMeldungSTBestrahlung
    {
        
        public ADT_GEKIDPatientMeldungSTBestrahlungST_Zielgebiet ST_Zielgebiet { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ST_ZielgebietSpecified { get; set; }
        
        public ADT_GEKIDPatientMeldungSTBestrahlungST_Seite_Zielgebiet ST_Seite_Zielgebiet { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ST_Seite_ZielgebietSpecified { get; set; }

        
        public string ST_Beginn_Datum { get; set; }

        
        public string ST_Ende_Datum { get; set; }

        
        public ADT_GEKIDPatientMeldungSTBestrahlungST_Applikationsart ST_Applikationsart { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ST_ApplikationsartSpecified { get; set; }

        
        public Strahlendosis_Typ ST_Gesamtdosis { get; set; }

        
        public Strahlendosis_Typ ST_Einzeldosis { get; set; }
    }

    public enum ADT_GEKIDPatientMeldungSTBestrahlungST_Zielgebiet
    {

        
        [System.Xml.Serialization.XmlEnumAttribute("1.")]
        Item1,

        
        [System.Xml.Serialization.XmlEnumAttribute("1.1.")]
        Item11,

        
        [System.Xml.Serialization.XmlEnumAttribute("1.2.")]
        Item12,

        
        [System.Xml.Serialization.XmlEnumAttribute("1.3.")]
        Item13,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.")]
        Item2,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.+")]
        Item21,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.-")]
        Item22,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.1.")]
        Item211,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.1.+")]
        Item212,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.1.-")]
        Item213,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.2.")]
        Item221,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.2.+")]
        Item222,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.2.-")]
        Item223,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.3.")]
        Item23,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.3.+")]
        Item231,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.3.-")]
        Item232,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.4.")]
        Item24,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.4.+")]
        Item241,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.4.-")]
        Item242,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.5.")]
        Item25,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.5.+")]
        Item251,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.5.-")]
        Item252,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.6.")]
        Item26,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.6.+")]
        Item261,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.6.-")]
        Item262,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.7.")]
        Item27,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.7.+")]
        Item271,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.7.-")]
        Item272,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.8.")]
        Item28,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.8.+")]
        Item281,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.8.-")]
        Item282,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.9.")]
        Item29,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.")]
        Item3,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.+")]
        Item31,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.-")]
        Item32,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.1.")]
        Item311,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.1.+")]
        Item312,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.1.-")]
        Item313,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.2.")]
        Item321,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.2.+")]
        Item322,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.2.-")]
        Item323,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.3.")]
        Item33,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.3.+")]
        Item331,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.3.-")]
        Item332,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.4.")]
        Item34,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.4.+")]
        Item341,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.4.-")]
        Item342,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.5.")]
        Item35,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.5.+")]
        Item351,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.5.-")]
        Item352,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.6.")]
        Item36,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.6.+")]
        Item361,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.6.-")]
        Item362,

        
        [System.Xml.Serialization.XmlEnumAttribute("3.7.")]
        Item37,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.")]
        Item4,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.+")]
        Item41,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.-")]
        Item42,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.1.")]
        Item411,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.1.+")]
        Item412,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.1.-")]
        Item413,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.2.")]
        Item421,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.2.+")]
        Item422,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.2.-")]
        Item423,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.3.")]
        Item43,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.3.+")]
        Item431,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.3.-")]
        Item432,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.4.")]
        Item44,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.4.+")]
        Item441,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.4.-")]
        Item442,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.5.")]
        Item45,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.5.+")]
        Item451,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.5.-")]
        Item452,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.6.")]
        Item46,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.6.+")]
        Item461,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.6.-")]
        Item462,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.7.")]
        Item47,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.8.")]
        Item48,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.8.+")]
        Item481,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.8.-")]
        Item482,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.9.")]
        Item49,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.9.+")]
        Item491,

        
        [System.Xml.Serialization.XmlEnumAttribute("4.9.-")]
        Item492,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.")]
        Item5,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.+")]
        Item51,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.-")]
        Item52,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.1.")]
        Item511,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.1.+")]
        Item512,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.1.-")]
        Item513,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.2.")]
        Item521,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.2.+")]
        Item522,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.2.-")]
        Item523,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.3.")]
        Item53,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.3.+")]
        Item531,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.3.-")]
        Item532,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.4.")]
        Item54,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.4.+")]
        Item541,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.4.-")]
        Item542,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.5.")]
        Item55,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.5.+")]
        Item551,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.5.-")]
        Item552,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.6.")]
        Item56,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.6.+")]
        Item561,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.6.-")]
        Item562,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.7.")]
        Item57,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.7.+")]
        Item571,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.7.-")]
        Item572,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.7.1.")]
        Item5711,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.7.1.+")]
        Item5712,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.7.1.-")]
        Item5713,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.7.2.")]
        Item5721,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.7.2.+")]
        Item5722,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.7.2.-")]
        Item5723,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.8.")]
        Item58,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.8.+")]
        Item581,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.8.-")]
        Item582,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.9.")]
        Item59,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.9.+")]
        Item591,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.9.-")]
        Item592,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.10.")]
        Item510,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.10.+")]
        Item5101,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.10.-")]
        Item5102,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.11.")]
        Item5111,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.11.+")]
        Item5112,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.11.-")]
        Item5113,

        
        [System.Xml.Serialization.XmlEnumAttribute("5.12.")]
        Item5121,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.")]
        Item6,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.1.")]
        Item61,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.2.")]
        Item62,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.3.")]
        Item63,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.4.")]
        Item64,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.5.")]
        Item65,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.6.")]
        Item66,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.7.")]
        Item67,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.8.")]
        Item68,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.9.")]
        Item69,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.10.")]
        Item610,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.11.")]
        Item611,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.12.")]
        Item612,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.13.")]
        Item613,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.14.")]
        Item614,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.15.")]
        Item615,

        
        [System.Xml.Serialization.XmlEnumAttribute("6.16.")]
        Item616,

        
        [System.Xml.Serialization.XmlEnumAttribute("7.")]
        Item7,

        
        [System.Xml.Serialization.XmlEnumAttribute("7.+")]
        Item71,

        
        [System.Xml.Serialization.XmlEnumAttribute("7.-")]
        Item72,

        
        [System.Xml.Serialization.XmlEnumAttribute("7.1.")]
        Item711,

        
        [System.Xml.Serialization.XmlEnumAttribute("7.2.")]
        Item721,

        
        [System.Xml.Serialization.XmlEnumAttribute("8.")]
        Item8,

        
        [System.Xml.Serialization.XmlEnumAttribute("8.1.")]
        Item81,

        
        [System.Xml.Serialization.XmlEnumAttribute("8.2.")]
        Item82,
    }

    public enum ADT_GEKIDPatientMeldungSTBestrahlungST_Seite_Zielgebiet
    {

        
        L,

        
        R,

        
        B,

        
        M,

        
        U,
    }

    public enum ADT_GEKIDPatientMeldungSTBestrahlungST_Applikationsart
    {

        
        P,

        
        PRCJ,

        
        PRCN,

        
        K,

        
        KHDR,

        
        KPDR,

        
        KLDR,

        
        I,

        
        IHDR,

        
        IPDR,

        
        ILDR,

        
        M,

        
        MSIRT,

        
        MPRRT,

        
        S,
    }

    public enum ADT_GEKIDPatientMeldungSTST_Ende_Grund
    {

        
        A,

        
        E,

        
        V,

        
        P,

        
        S,

        
        U,
    }

    public partial class ADT_GEKIDPatientMeldungSYST
    {
        public ADT_GEKIDPatientMeldungSYSTSYST_Intention SYST_Intention { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SYST_IntentionSpecified { get; set; }

        
        public ADT_GEKIDPatientMeldungSYSTSYST_Stellung_OP SYST_Stellung_OP { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SYST_Stellung_OPSpecified { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("SYST_Therapieart", IsNullable = false)]
        public ADT_GEKIDPatientMeldungSYSTSYST_Therapieart[] Menge_Therapieart { get; set; }

        
        public string SYST_Therapieart_Anmerkung { get; set; }

        
        public string SYST_Protokoll { get; set; }

        
        public string SYST_Beginn_Datum { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("SYST_Substanz", IsNullable = false)]
        public string[] Menge_Substanz { get; set; }

        
        public ADT_GEKIDPatientMeldungSYSTSYST_Ende_Grund SYST_Ende_Grund { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SYST_Ende_GrundSpecified { get; set; }

        
        public string SYST_Ende_Datum { get; set; }

        
        public Residualstatus_Typ Residualstatus { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("SYST_Nebenwirkung", IsNullable = false)]
        public Nebenwirkung_Typ[] Menge_Nebenwirkung { get; set; }

        
        public Modul_Allgemein_Typ Modul_Allgemein { get; set; }

        
        public string Anmerkung { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SYST_ID { get; set; }
    }

    public enum ADT_GEKIDPatientMeldungSYSTSYST_Intention
    {
        
        K,

        
        P,

        
        S,

        
        X,
    }

    public enum ADT_GEKIDPatientMeldungSYSTSYST_Stellung_OP
    {

        
        O,

        
        A,

        
        N,

        
        I,

        
        S,
    }

    public enum ADT_GEKIDPatientMeldungSYSTSYST_Therapieart
    {

        
        CH,

        
        HO,

        
        IM,

        
        KM,

        
        WS,

        
        AS,

        
        ZS,

        
        SO,
    }

    public enum ADT_GEKIDPatientMeldungSYSTSYST_Ende_Grund
    {
        
        A,

        
        E,

        
        V,

        
        R,

        
        P,

        
        S,

        
        U,
    }

    public partial class ADT_GEKIDPatientMeldungVerlauf
    {

        
        public Histologie_Typ Histologie { get; set; }

        
        public TNM_Typ TNM { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Weitere_Klassifikation", IsNullable = false)]
        public Menge_Weitere_Klassifikation_TypWeitere_Klassifikation[] Menge_Weitere_Klassifikation { get; set; }

        
        public string Untersuchungsdatum_Verlauf { get; set; }

        
        public ADT_GEKIDPatientMeldungVerlaufGesamtbeurteilung_Tumorstatus Gesamtbeurteilung_Tumorstatus { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Gesamtbeurteilung_TumorstatusSpecified { get; set; }

        
        public ADT_GEKIDPatientMeldungVerlaufVerlauf_Lokaler_Tumorstatus Verlauf_Lokaler_Tumorstatus { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Verlauf_Lokaler_TumorstatusSpecified { get; set; }

        
        public ADT_GEKIDPatientMeldungVerlaufVerlauf_Tumorstatus_Lymphknoten Verlauf_Tumorstatus_Lymphknoten { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Verlauf_Tumorstatus_LymphknotenSpecified { get; set; }

        
        public ADT_GEKIDPatientMeldungVerlaufVerlauf_Tumorstatus_Fernmetastasen Verlauf_Tumorstatus_Fernmetastasen { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Verlauf_Tumorstatus_FernmetastasenSpecified { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("Fernmetastase", IsNullable = false)]
        public Menge_FM_TypFernmetastase[] Menge_FM { get; set; }



        public Allgemeiner_Leistungszustand_Typ Allgemeiner_Leistungszustand { get; set; }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Allgemeiner_LeistungszustandSpecified { get; set; }


        public Modul_Prostata_Typ Modul_Prostata { get; set; }


        public Modul_Malignes_Melanom_Typ Modul_Malignes_Melanom { get; set; }


        public Modul_Allgemein_Typ Modul_Allgemein { get; set; }


        public ADT_GEKIDPatientMeldungVerlaufTod Tod { get; set; }


        public string Anmerkung { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Verlauf_ID { get; set; }
    }

    
    public enum ADT_GEKIDPatientMeldungVerlaufGesamtbeurteilung_Tumorstatus
    {
        
        V,

        
        T,

        
        K,

        
        P,

        
        D,

        
        B,

        
        R,

        
        U,

        
        X,
    }

    public enum ADT_GEKIDPatientMeldungVerlaufVerlauf_Lokaler_Tumorstatus
    {

        
        K,

        
        T,

        
        P,

        
        N,

        
        R,

        
        F,

        
        U,

        
        X,
    }

    
    public enum ADT_GEKIDPatientMeldungVerlaufVerlauf_Tumorstatus_Lymphknoten
    {

        
        K,

        
        T,

        
        P,

        
        N,

        
        R,

        
        F,

        
        U,

        
        X,
    }

    
    public enum ADT_GEKIDPatientMeldungVerlaufVerlauf_Tumorstatus_Fernmetastasen
    {

        
        K,

        
        M,

        
        T,

        
        P,

        
        N,

        
        R,

        
        F,

        
        U,

        
        X,
    }

    
    public partial class ADT_GEKIDPatientMeldungVerlaufTod
    {
        
        public string Sterbedatum { get; set; }


        public JNU_Typ Tod_tumorbedingt { get; set; }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Tod_tumorbedingtSpecified { get; set; }


        public ADT_GEKIDPatientMeldungVerlaufTodMenge_Todesursache Menge_Todesursache { get; set; }
    }

    
    public partial class ADT_GEKIDPatientMeldungVerlaufTodMenge_Todesursache
    {
        
        [System.Xml.Serialization.XmlElementAttribute("Todesursache_ICD")]
        public string[] Todesursache_ICD { get; set; }


        public ICD_Version_Typ Todesursache_ICD_Version { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Todesursache_ICD_VersionSpecified { get; set; }
    }

    
    public partial class ADT_GEKIDPatientMeldungTumorkonferenz
    {
     
        public string Tumorkonferenz_Datum { get; set; }

        public ADT_GEKIDPatientMeldungTumorkonferenzTumorkonferenz_Typ Tumorkonferenz_Typ { get; set; }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Tumorkonferenz_TypSpecified { get; set; }


        public string Anmerkung { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tumorkonferenz_ID { get; set; }
    }

    
    public enum ADT_GEKIDPatientMeldungTumorkonferenzTumorkonferenz_Typ
    {
       
        praeth,

        
        postop,

        
        postth,
    }

    
    public partial class ADT_GEKIDPatientMeldungZusatzitem
    {

        
        public string Datum { get; set; }


        public string Art { get; set; }


        public string Wert { get; set; }


        public string Bemerkung { get; set; }
    }

    public enum ADT_GEKIDSchema_Version
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("2.0.0")]
        Item200,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.0.1")]
        Item201,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.1.0")]
        Item210,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.1.1")]
        Item211,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.1.2")]
        Item212,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.1.3")]
        Item213,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.2.0")]
        Item220,

        
        [System.Xml.Serialization.XmlEnumAttribute("2.2.1")]
        Item221,
    }
}