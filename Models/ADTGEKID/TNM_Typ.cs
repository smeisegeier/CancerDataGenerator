using Rki.CancerDataGenerator.Models.Dimensions;
using System;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class TNM_Typ : AdtgekidBase
    {
        public TNM_Typ(){}
        public TNM_Typ(IGenerator generator, AdtgekidBase parent) : base(generator, parent)
        {
            // TODO idea: create compound variable like "tnm" that dictates sub values following real world rules
            TNM_Datum = _generator.CreateRandomDate_Meldedatum().ToShortDateString();
            TNM_Version = TNM_TypTNM_Version.Item7;
            // TODO what is this
            TNM_y_Symbol = TNM_TypTNM_y_Symbol.y;
            TNM_a_Symbol = TNM_TypTNM_a_Symbol.a;
            TNM_T = _generator.FetchRandomDimensionItem<T>()?.tnm_t_id;
            TNM_N = _generator.FetchRandomDimensionItem<N>()?.tnm_n_id;
            TNM_M = _generator.FetchRandomDimensionItem<M>()?.tnm_m_id;
            TNM_c_p_u_Praefix_T = _generator.FetchRandomEnumItem<TNM_TypTNM_c_p_u_Praefix_T>();
            TNM_c_p_u_Praefix_N = _generator.FetchRandomEnumItem<TNM_TypTNM_c_p_u_Praefix_N>();
            TNM_c_p_u_Praefix_M = _generator.FetchRandomEnumItem<TNM_TypTNM_c_p_u_Praefix_M>();
            TNM_L = _generator.FetchRandomEnumItem<TNM_TypTNM_L>();
            TNM_V = _generator.FetchRandomEnumItem<TNM_TypTNM_V>();
            TNM_Pn = _generator.FetchRandomEnumItem<TNM_TypTNM_Pn>();
            TNM_S = _generator.FetchRandomEnumItem<TNM_TypTNM_S>();
            TNM_ID = (_parent as PatientMeldungDiagnose).TNM_ID;
        }


        public string TNM_Datum { get; set; }
        
        public TNM_TypTNM_Version TNM_Version { get; set; }
        
        public TNM_TypTNM_y_Symbol TNM_y_Symbol { get; set; }
        
        public TNM_TypTNM_r_Symbol TNM_r_Symbol { get; set; }

        public TNM_TypTNM_a_Symbol TNM_a_Symbol { get; set; }
        
        public TNM_TypTNM_c_p_u_Praefix_T TNM_c_p_u_Praefix_T { get; set; }

        public string TNM_T { get; set; }
        
        public string TNM_m_Symbol { get; set; }
        
        public TNM_TypTNM_c_p_u_Praefix_N TNM_c_p_u_Praefix_N { get; set; }

        public string TNM_N { get; set; }

        public TNM_TypTNM_c_p_u_Praefix_M TNM_c_p_u_Praefix_M { get; set; }
        
        public string TNM_M { get; set; }

        public TNM_TypTNM_L TNM_L { get; set; }
        
        public TNM_TypTNM_V TNM_V { get; set; }
       
        public TNM_TypTNM_Pn TNM_Pn { get; set; }

        public TNM_TypTNM_S TNM_S { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TNM_ID { get; set; }
    }
}