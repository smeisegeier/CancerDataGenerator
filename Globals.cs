using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator
{
    public static class Globals
    {
        // TODO const vs static getter
        public const string PROJECTVERSION = "3.0.0.5.2";
        public const string APPNAME = "CancerDataGenerator";

        public const string ROUTESTRING = "/api/v{version:apiVersion}/[controller]";

        public const int MAXANZTAGEZWISCHENEREIGNISSE = 1 * 365;

        public static string AppDir => Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);


        // TODO replace public key
        public static string PUBLICKEY => @"
-----BEGIN PGP PUBLIC KEY BLOCK-----
Version: GnuPG v2

mQENBE5wbMsBCADSo3YJydB4cN/01KzSMPkww+ALrKPJ04xAH+PTO+jYPm2KmWCe
8Dh5o47bx52FJfx1gG0hF9YCqZumLzxH3V++8LncWeS+9Iws1K60BwA7wPDrc3Ih
/lW1dpg646wJaaRAd9yvpBQ4JBBgbyOnL/R0qxvUvWDFG/AW4C4WKNezB7qAYTTl
YLGtfHQIBZgmaxJTyBR5KJYayRjWstLOjulh4Wmm7GkCO5ffCbDxlSfm1dlo2nqa
KeTlgQi3j9UwGpgva3ZEK7DWppc3XkdTfqSDy7ZyVZlCGsSn9ayfrskSjfblEEUp
g8kwuyau7mRFnauRacsOJbqOnvoUaaN+FyZ1ABEBAAG0I01hbnVlbGEgU3TDtmNr
ZXIgPFN0b2Vja2VyTUBya2kuZGU+iQE4BBMBAgAiBQJOcGzLAhsDBgsJCAcDAgYV
CAIJCgsEFgIDAQIeAQIXgAAKCRAwQIKFesj7pkYeB/98+AX4A4fOxh7mjg+0UnYo
ikaJRKI/CjajLF7sSo/96tNZ47ZtqxFa816jbSjKmTb8Vws+BCBzVgYqIioUTIdT
q0nTwDacPwBA51oem2Che1etnVNA62yLLv/PiT8FBr5fMkC/XMkhINxQ6I5GZxD3
zm1TcvSJy04K7KQyw6y8sA9weTg8D2N19/Ob8dn6hHCsBpbVWY05d7BZv5wy2Ty5
71/ASMssLghJ3ny5AVvBLDD8+3WAUg6OrnKWvz+MhrJKBGcd0tsZCYLZB4G0/ZRR
YnSR6Nz3e4IXVtK1GEhnxMKf6srrWFE99hpEFiu1DFyo0JDDg82fb7d56c5VYMAB
tCZTdGVmYW4gTWVpc2VnZWllciA8TWVpc2VnZWllclNAcmtpLmRlPokBOQQTAQgA
IwUCVX6e0AIbAwcLCQgHAwIBBhUIAgkKCwQWAgMBAh4BAheAAAoJEDBAgoV6yPum
tnEIAKgCG9taPd0++Y7SXfBNiOjMqHKXRno6bnWCefhJ3ypo2fr1djehnc+KI8tp
zMUS4zmlDdCrNEm9wajFnhAWdcZVNQFKZXIDZtYfuB4tGibT8G6pg9GvJO0eZwna
as5aWKis5iXQz1kJY9F2Yni0UbeX18G+5pU8ypwyJIfAEbFXlcMwxgIed3gFDaFz
6pIjyX8P9omDdxjkDL5WMijAwzPn0sq2ZYlvEhmQdqWig097XP2LkbeVjygaXaK3
ZFRjPXNMk0Hgl45/AtPlWFlrPR7b3SvxfjfVp2eSpPXEcHkf7LWvfK18X3NQTRHL
KnfW/+N/lgybZrVqN7J+SMeCr5C5AQ0ETnBsywEIAKXBO1ZH3yNsp6g3VA82ZQwf
b3NQqurVeLKf6QI2vgcPLxATL3clG26C59khTnN0zUUO2a+h2cb5F7R10KSpVDh5
HDiweVcte58Oz1x6crHt6G5fdYdAeGyaCoWJe5DGKC35VzSCEt5qN9vjwzX6pO5j
RpdW3ZLuXuJRVN2Iw+kfsinjLfx0mYOLB7+aa294Pgf1JsgMCyLzg522/PjnbZqd
Qlsbt03GlvN2Oqj4E55vS89zMwHVDSCgwWPgN93q3ScU+IGATo3uKArRzNamCyZv
l84TPPPjoYflKHa4iSW7zGnVGWpsSN9O7zuOakyf3k9bMxMJv8e3kz9lP6qK8eEA
EQEAAYkBHwQYAQIACQUCTnBsywIbDAAKCRAwQIKFesj7puXhB/4+31xbfSxB3Fmp
AF5zdKms1dB8uwVW2VJnbnZDN5X0S4c9GBxPmQOBZJxG1WzRcF/pzJdEbpQSWsz2
dy8IidixQ8hbh792F6/s5dwn+PlXkQ1wTedsrVpmt/nwLnzjZpgrpn7EJjphoSKa
Strq5Rhmb/t9wyQNjbK0db7XHfvibvqchZeqqkk1+3q23w5ULQmQSifbmud2FPqe
cglHXdmbz5T4llmol7U0S/BKqg9+XgUT77YVMCXaVaR15TqsqbhPBipxsHBT40+q
kCUgao3WJlw3F7yfgyyVsZYBb7XvPonggYjO6zHBiKANaYijzWYtmMB0zJmVvxAr
JcHjy29m
=Yib7
-----END PGP PUBLIC KEY BLOCK-----
";
 
    }
}
