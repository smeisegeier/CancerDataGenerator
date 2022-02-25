using Rki.CancerDataGenerator.Models.Dimensions;
using System;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class TNM : AdtgekidBase
    {

        public TNM_Version_Typ Version { get; set; }
        
        public TNM_TypTNM_y_Symbol y_Symbol { get; set; }
        
        public TNM_TypTNM_r_Symbol r_Symbol { get; set; }

        public TNM_TypTNM_a_Symbol a_Symbol { get; set; }
        
        public TNM_TypTNM_c_p_u_Praefix_T c_p_u_Praefix_T { get; set; }

        public string T { get; set; }
        
        public string m_Symbol { get; set; }
        
        public TNM_TypTNM_c_p_u_Praefix_N c_p_u_Praefix_N { get; set; }

        public string N { get; set; }

        public TNM_TypTNM_c_p_u_Praefix_M c_p_u_Praefix_M { get; set; }
        
        public string M { get; set; }

        public TNM_TypTNM_L L { get; set; }
        
        public TNM_TypTNM_V V { get; set; }
       
        public TNM_TypTNM_Pn Pn { get; set; }

        public TNM_TypTNM_S S { get; set; }

        public UICC_Stadium_Typ UICC_Stadium { get; set; }
    }
}