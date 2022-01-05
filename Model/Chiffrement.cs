using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Chiffrement
    {
        public static string ChiffrerBase64(string texteSimple)
        {
            var texteSimpleBytes = System.Text.Encoding.UTF8.GetBytes(texteSimple);
            return System.Convert.ToBase64String(texteSimpleBytes);
        }

        public static string DechiffrerBase64(string texteChiffrerBase64)
        {
            var texteChiffrerBase64Bytes = System.Convert.FromBase64String(texteChiffrerBase64);
            return System.Text.Encoding.UTF8.GetString(texteChiffrerBase64Bytes);
        }

    }
}
