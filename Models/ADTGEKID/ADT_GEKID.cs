﻿
using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    [XmlRoot(Namespace = Globals.XSDNAMESPACE, IsNullable = false)]
    public partial class ADT_GEKID : AdtgekidBase
    {
        public ADT_GEKID() { }
        public ADT_GEKID(Generator generator, AdtgekidBase parent) : base(generator, parent)
        {
            Menge_Patient = Enumerable
                .Range(1, _generator.CreateFixedValuePatientCount())
                .Select(index => new Patient(_generator, this))
                .ToList();
        }

        public List<Patient> Menge_Patient { get; set; }

        public List<Melder_Typ> Menge_Melder { get; set; }
        public Absender Absender { get; set; }

        /* Attribute */
        [XmlAttribute]
        public Schema_Version Schema_Version { get; init; } = Schema_Version.Item211;

        [XmlAttribute("schemaLocation", Namespace = Globals.XSINAMESPACE)]
        public string schemaLocation { get; init; } = $"{Globals.XSDNAMESPACE} {Globals.XSDFILENAME}";
    }

    public enum Nebenwirkung_TypNebenwirkung_Grad
    {

        K,

        [XmlEnum("3")]
        Item3,

        [XmlEnum("4")]
        Item4,

        [XmlEnum("5")]
        Item5,

        U,
    }

    public enum Nebenwirkung_TypNebenwirkung_Version
    {

        [XmlEnum("4")]
        Item4,


        [XmlEnum("4.03")]
        Item403,


        [XmlEnum("5.0")]
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
        [XmlEnum("R1(is)")]
        R1is,
        [XmlEnum("R1(cy+)")]
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

        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,
    }
    public enum Modul_Prostata_TypGleasonScoreGleasonGradSekundaer
    {
        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,

        [XmlEnum("4")]
        Item4,

        [XmlEnum("5")]
        Item5,
    }

    public enum Modul_Prostata_TypGleasonScoreGleasonScoreErgebnis
    {


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,


        [XmlEnum("6")]
        Item6,


        [XmlEnum("7")]
        Item7,


        [XmlEnum("7a")]
        Item7a,


        [XmlEnum("7b")]
        Item7b,


        [XmlEnum("8")]
        Item8,


        [XmlEnum("9")]
        Item9,


        [XmlEnum("10")]
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
        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
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


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
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


        [XmlEnum("1")]
        Item1,


        [XmlEnum("3")]
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

        [XmlEnum("6")]
        Item6,


        [XmlEnum("7")]
        Item7,


        [XmlEnum("8")]
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


        [XmlEnum("31")]
        Item31,


        [XmlEnum("32")]
        Item32,


        [XmlEnum("33")]
        Item33,


        bb,
    }

    public enum Histologie_TypGrading
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
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

        None
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
        None
    }

    public enum ICD_Version_Typ
    {


        [XmlEnum("10 2004 GM")]
        Item102004GM,


        [XmlEnum("10 2005 GM")]
        Item102005GM,


        [XmlEnum("10 2006 GM")]
        Item102006GM,


        [XmlEnum("10 2007 GM")]
        Item102007GM,


        [XmlEnum("10 2008 GM")]
        Item102008GM,


        [XmlEnum("10 2009 GM")]
        Item102009GM,


        [XmlEnum("10 2010 GM")]
        Item102010GM,


        [XmlEnum("10 2011 GM")]
        Item102011GM,


        [XmlEnum("10 2012 GM")]
        Item102012GM,


        [XmlEnum("10 2013 GM")]
        Item102013GM,


        [XmlEnum("10 2014 GM")]
        Item102014GM,


        [XmlEnum("10 2015 GM")]
        Item102015GM,


        [XmlEnum("10 2016 GM")]
        Item102016GM,


        [XmlEnum("10 2016 WHO")]
        Item102016WHO,


        [XmlEnum("10 2017 GM")]
        Item102017GM,


        [XmlEnum("10 2018 GM")]
        Item102018GM,


        [XmlEnum("10 2019 GM")]
        Item102019GM,


        [XmlEnum("10 2020 GM")]
        Item102020GM,


        [XmlEnum("10 2021 GM")]
        Item102021GM,


        [XmlEnum("10 2022 GM")]
        Item102022GM,

        [XmlEnum("Sonstige")]
        Sonstige,

        None
    }

    public enum Seitenlokalisation_Typ
    {
        L,
        R,
        B,
        M,
        U,
        T,
        None
    }

    public enum PatientMeldungDiagnosePrimaertumor_Topographie_ICD_O_Version
    {
        [XmlEnum("31")]
        Item31,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,
    }
    public enum PatientMeldungDiagnoseDiagnosesicherung
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("9")]
        Item9,
        None
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

        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        U,


        [XmlEnum("10%")]
        Item10,


        [XmlEnum("20%")]
        Item20,


        [XmlEnum("30%")]
        Item30,


        [XmlEnum("40%")]
        Item40,


        [XmlEnum("50%")]
        Item50,


        [XmlEnum("60%")]
        Item60,


        [XmlEnum("70%")]
        Item70,


        [XmlEnum("80%")]
        Item80,


        [XmlEnum("90%")]
        Item90,


        [XmlEnum("100%")]
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


        [XmlEnum("2004")]
        Item2004,


        [XmlEnum("2005")]
        Item2005,


        [XmlEnum("2006")]
        Item2006,


        [XmlEnum("2007")]
        Item2007,


        [XmlEnum("2008")]
        Item2008,


        [XmlEnum("2009")]
        Item2009,


        [XmlEnum("2010")]
        Item2010,


        [XmlEnum("2011")]
        Item2011,


        [XmlEnum("2012")]
        Item2012,


        [XmlEnum("2013")]
        Item2013,


        [XmlEnum("2014")]
        Item2014,


        [XmlEnum("2015")]
        Item2015,


        [XmlEnum("2016")]
        Item2016,


        [XmlEnum("2017")]
        Item2017,


        [XmlEnum("2018")]
        Item2018,


        [XmlEnum("2019")]
        Item2019,


        [XmlEnum("2020")]
        Item2020,


        [XmlEnum("2021")]
        Item2021,


        [XmlEnum("2022")]
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


        [XmlEnum("1.")]
        Item1,


        [XmlEnum("1.1.")]
        Item11,


        [XmlEnum("1.2.")]
        Item12,


        [XmlEnum("1.3.")]
        Item13,


        [XmlEnum("2.")]
        Item2,


        [XmlEnum("2.+")]
        Item21,


        [XmlEnum("2.-")]
        Item22,


        [XmlEnum("2.1.")]
        Item211,


        [XmlEnum("2.1.+")]
        Item212,


        [XmlEnum("2.1.-")]
        Item213,


        [XmlEnum("2.2.")]
        Item221,


        [XmlEnum("2.2.+")]
        Item222,


        [XmlEnum("2.2.-")]
        Item223,


        [XmlEnum("2.3.")]
        Item23,


        [XmlEnum("2.3.+")]
        Item231,


        [XmlEnum("2.3.-")]
        Item232,


        [XmlEnum("2.4.")]
        Item24,


        [XmlEnum("2.4.+")]
        Item241,


        [XmlEnum("2.4.-")]
        Item242,


        [XmlEnum("2.5.")]
        Item25,


        [XmlEnum("2.5.+")]
        Item251,


        [XmlEnum("2.5.-")]
        Item252,


        [XmlEnum("2.6.")]
        Item26,


        [XmlEnum("2.6.+")]
        Item261,


        [XmlEnum("2.6.-")]
        Item262,


        [XmlEnum("2.7.")]
        Item27,


        [XmlEnum("2.7.+")]
        Item271,


        [XmlEnum("2.7.-")]
        Item272,


        [XmlEnum("2.8.")]
        Item28,


        [XmlEnum("2.8.+")]
        Item281,


        [XmlEnum("2.8.-")]
        Item282,


        [XmlEnum("2.9.")]
        Item29,


        [XmlEnum("3.")]
        Item3,


        [XmlEnum("3.+")]
        Item31,


        [XmlEnum("3.-")]
        Item32,


        [XmlEnum("3.1.")]
        Item311,


        [XmlEnum("3.1.+")]
        Item312,


        [XmlEnum("3.1.-")]
        Item313,


        [XmlEnum("3.2.")]
        Item321,


        [XmlEnum("3.2.+")]
        Item322,


        [XmlEnum("3.2.-")]
        Item323,


        [XmlEnum("3.3.")]
        Item33,


        [XmlEnum("3.3.+")]
        Item331,


        [XmlEnum("3.3.-")]
        Item332,


        [XmlEnum("3.4.")]
        Item34,


        [XmlEnum("3.4.+")]
        Item341,


        [XmlEnum("3.4.-")]
        Item342,


        [XmlEnum("3.5.")]
        Item35,


        [XmlEnum("3.5.+")]
        Item351,


        [XmlEnum("3.5.-")]
        Item352,


        [XmlEnum("3.6.")]
        Item36,


        [XmlEnum("3.6.+")]
        Item361,


        [XmlEnum("3.6.-")]
        Item362,


        [XmlEnum("3.7.")]
        Item37,


        [XmlEnum("4.")]
        Item4,


        [XmlEnum("4.+")]
        Item41,


        [XmlEnum("4.-")]
        Item42,


        [XmlEnum("4.1.")]
        Item411,


        [XmlEnum("4.1.+")]
        Item412,


        [XmlEnum("4.1.-")]
        Item413,


        [XmlEnum("4.2.")]
        Item421,


        [XmlEnum("4.2.+")]
        Item422,


        [XmlEnum("4.2.-")]
        Item423,


        [XmlEnum("4.3.")]
        Item43,


        [XmlEnum("4.3.+")]
        Item431,


        [XmlEnum("4.3.-")]
        Item432,


        [XmlEnum("4.4.")]
        Item44,


        [XmlEnum("4.4.+")]
        Item441,


        [XmlEnum("4.4.-")]
        Item442,


        [XmlEnum("4.5.")]
        Item45,


        [XmlEnum("4.5.+")]
        Item451,


        [XmlEnum("4.5.-")]
        Item452,


        [XmlEnum("4.6.")]
        Item46,


        [XmlEnum("4.6.+")]
        Item461,


        [XmlEnum("4.6.-")]
        Item462,


        [XmlEnum("4.7.")]
        Item47,


        [XmlEnum("4.8.")]
        Item48,


        [XmlEnum("4.8.+")]
        Item481,


        [XmlEnum("4.8.-")]
        Item482,


        [XmlEnum("4.9.")]
        Item49,


        [XmlEnum("4.9.+")]
        Item491,


        [XmlEnum("4.9.-")]
        Item492,


        [XmlEnum("5.")]
        Item5,


        [XmlEnum("5.+")]
        Item51,


        [XmlEnum("5.-")]
        Item52,


        [XmlEnum("5.1.")]
        Item511,


        [XmlEnum("5.1.+")]
        Item512,


        [XmlEnum("5.1.-")]
        Item513,


        [XmlEnum("5.2.")]
        Item521,


        [XmlEnum("5.2.+")]
        Item522,


        [XmlEnum("5.2.-")]
        Item523,


        [XmlEnum("5.3.")]
        Item53,


        [XmlEnum("5.3.+")]
        Item531,


        [XmlEnum("5.3.-")]
        Item532,


        [XmlEnum("5.4.")]
        Item54,


        [XmlEnum("5.4.+")]
        Item541,


        [XmlEnum("5.4.-")]
        Item542,


        [XmlEnum("5.5.")]
        Item55,


        [XmlEnum("5.5.+")]
        Item551,


        [XmlEnum("5.5.-")]
        Item552,


        [XmlEnum("5.6.")]
        Item56,


        [XmlEnum("5.6.+")]
        Item561,


        [XmlEnum("5.6.-")]
        Item562,


        [XmlEnum("5.7.")]
        Item57,


        [XmlEnum("5.7.+")]
        Item571,


        [XmlEnum("5.7.-")]
        Item572,


        [XmlEnum("5.7.1.")]
        Item5711,


        [XmlEnum("5.7.1.+")]
        Item5712,


        [XmlEnum("5.7.1.-")]
        Item5713,


        [XmlEnum("5.7.2.")]
        Item5721,


        [XmlEnum("5.7.2.+")]
        Item5722,


        [XmlEnum("5.7.2.-")]
        Item5723,


        [XmlEnum("5.8.")]
        Item58,


        [XmlEnum("5.8.+")]
        Item581,


        [XmlEnum("5.8.-")]
        Item582,


        [XmlEnum("5.9.")]
        Item59,


        [XmlEnum("5.9.+")]
        Item591,


        [XmlEnum("5.9.-")]
        Item592,


        [XmlEnum("5.10.")]
        Item510,


        [XmlEnum("5.10.+")]
        Item5101,


        [XmlEnum("5.10.-")]
        Item5102,


        [XmlEnum("5.11.")]
        Item5111,


        [XmlEnum("5.11.+")]
        Item5112,


        [XmlEnum("5.11.-")]
        Item5113,


        [XmlEnum("5.12.")]
        Item5121,


        [XmlEnum("6.")]
        Item6,


        [XmlEnum("6.1.")]
        Item61,


        [XmlEnum("6.2.")]
        Item62,


        [XmlEnum("6.3.")]
        Item63,


        [XmlEnum("6.4.")]
        Item64,


        [XmlEnum("6.5.")]
        Item65,


        [XmlEnum("6.6.")]
        Item66,


        [XmlEnum("6.7.")]
        Item67,


        [XmlEnum("6.8.")]
        Item68,


        [XmlEnum("6.9.")]
        Item69,


        [XmlEnum("6.10.")]
        Item610,


        [XmlEnum("6.11.")]
        Item611,


        [XmlEnum("6.12.")]
        Item612,


        [XmlEnum("6.13.")]
        Item613,


        [XmlEnum("6.14.")]
        Item614,


        [XmlEnum("6.15.")]
        Item615,


        [XmlEnum("6.16.")]
        Item616,


        [XmlEnum("7.")]
        Item7,


        [XmlEnum("7.+")]
        Item71,


        [XmlEnum("7.-")]
        Item72,


        [XmlEnum("7.1.")]
        Item711,


        [XmlEnum("7.2.")]
        Item721,


        [XmlEnum("8.")]
        Item8,


        [XmlEnum("8.1.")]
        Item81,


        [XmlEnum("8.2.")]
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
        None
    }

    public enum Schema_Version
    {

        [XmlEnum("2.0.0")]
        Item200,


        [XmlEnum("2.0.1")]
        Item201,


        [XmlEnum("2.1.0")]
        Item210,


        [XmlEnum("2.1.1")]
        Item211,


        [XmlEnum("2.1.2")]
        Item212,


        [XmlEnum("2.1.3")]
        Item213,


        [XmlEnum("2.2.0")]
        Item220,


        [XmlEnum("2.2.1")]
        Item221
    }
}