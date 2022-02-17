using Rki.CancerDataGenerator.Models.Dimensions;
using System;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class TNM_Typ : AdtgekidBase
    {
        public TNM_Typ(){}

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
    }
}