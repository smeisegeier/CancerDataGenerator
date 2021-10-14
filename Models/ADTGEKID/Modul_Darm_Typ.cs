namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
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
}