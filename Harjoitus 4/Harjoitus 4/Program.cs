using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kappale> kappaleet = new List<Kappale>()
            {
                new Kappale("Kappale 1", "Artisti 1"),
                new Kappale("Kappale 2", "Artisti 2"),
                new Kappale("Kappale 3", "Artisti 3")
            };

            Albumi albumi = new Albumi("Albumin Nimi", "Artisti", kappaleet);
            albumi.TulostaAlbumi();
        }
    }
}
