using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_4
{
    class Kappale
    {
        public string Nimi {  get; set; }
        public string Artisti { get; set; }
        public int Kesto { get; set; }

        public Kappale(string nimi, string artisti, int kesto)
        {
            Nimi = nimi;
            Artisti = artisti;
            Kesto = kesto;
        }

        public override string ToString()
        {
            return "Kappale: (Nimi) - (Artisti), Kesto (Kesto)";
        }
    }
}
