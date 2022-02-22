using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator
{
    public static class Globals
    {
        public const string APPNAME = "CancerDataGenerator";
        public const string XSDFILENAME = "ADT_GEKID_v3.0.0.3_RKI.xsd";
        public const string XSDPATHRELATIVE = "Samples/" + XSDFILENAME;
        public const string XSDNAMESPACE = "http://www.gekid.de/namespace";
        public const string XSINAMESPACE = "http://www.w3.org/2001/XMLSchema-instance";

        public const string ROUTESTRING = "/api/v{version:apiVersion}/[controller]";

        public const int MAXANZTAGEZWISCHENEREIGNISSE = 10 * 365;
 
    }
}
