using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_26
{
    public class Kirja
    {
        public string Nimi { get; set; }
        public string Kirjailija { get; set; }
        public int Sivumäärä { get; set; }
        public bool Onlainassa { get; set; }
    }
}
