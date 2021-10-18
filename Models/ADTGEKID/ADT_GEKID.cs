
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class ADT_GEKID
    {
        public List<Patient> Menge_Patient { get; set; }

        public List<Melder_Typ> Menge_Melder { get; set; }

        public Schema_Version Schema_Version { get; set; }
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

    public enum Strahlendosis_TypEinheit
    {
        Gy,
        GBq,
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

    public enum Datum_NU_TypNU
    {
        N,
        U
    }

    public enum JNU_Typ
    {
        J,
        N,
        U
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

    public enum Modul_Prostata_TypCaBefallStanzeU
    {
        U
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

    public enum PatientPatienten_StammdatenPatienten_Geschlecht
    {

        
        M,

        
        W,

        
        S,

        
        U,
    }

    public enum PatientMeldungMeldebegruendung
    {

        
        I,

        
        A,

        
        D,

        
        W,

        
        V,
    }

    public enum PatientMeldungMeldeanlass
    {

        
        diagnose,

        
        behandlungsbeginn,

        
        behandlungsende,

        
        statusaenderung,

        
        statusmeldung,

        
        tod,

        
        histologie_zytologie,
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

    public enum PatientMeldungDiagnosePrimaertumor_Topographie_ICD_O_Version
    {

        
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,
    }
    public enum PatientMeldungDiagnoseDiagnosesicherung
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

    public enum PatientMeldungOPOP_Intention
    {

        
        K,

        
        P,

        
        D,

        
        R,

        
        S,

        
        X,
    }

    public enum PatientMeldungOPOP_OPS_Version
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
    public enum PatientMeldungOPOP_Komplikation
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

    public enum PatientMeldungSTST_Intention
    {

        
        K,

        
        P,

        
        S,

        
        X,
    }

    public enum PatientMeldungSTST_Stellung_OP
    {

        
        O,

        
        A,

        
        N,

        
        I,

        
        S,
    }

    public enum PatientMeldungSTBestrahlungST_Zielgebiet
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

    public enum PatientMeldungSTBestrahlungST_Seite_Zielgebiet
    {

        
        L,

        
        R,

        
        B,

        
        M,

        
        U,
    }

    public enum PatientMeldungSTBestrahlungST_Applikationsart
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

    public enum PatientMeldungSTST_Ende_Grund
    {

        
        A,

        
        E,

        
        V,

        
        P,

        
        S,

        
        U,
    }

    public enum PatientMeldungSYSTSYST_Intention
    {
        
        K,

        
        P,

        
        S,

        
        X,
    }

    public enum PatientMeldungSYSTSYST_Stellung_OP
    {

        
        O,

        
        A,

        
        N,

        
        I,

        
        S,
    }

    public enum PatientMeldungSYSTSYST_Therapieart
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

    public enum PatientMeldungSYSTSYST_Ende_Grund
    {
        
        A,

        
        E,

        
        V,

        
        R,

        
        P,

        
        S,

        
        U,
    }

    
    public enum PatientMeldungVerlaufGesamtbeurteilung_Tumorstatus
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

    public enum PatientMeldungVerlaufVerlauf_Lokaler_Tumorstatus
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

    
    public enum PatientMeldungVerlaufVerlauf_Tumorstatus_Lymphknoten
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

    
    public enum PatientMeldungVerlaufVerlauf_Tumorstatus_Fernmetastasen
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

    
    public enum PatientMeldungTumorkonferenzTumorkonferenz_Typ
    {
       
        praeth,

        
        postop,

        
        postth,
    }

    public enum Schema_Version
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

        // TODO remove
        ItemLUL
    }
}