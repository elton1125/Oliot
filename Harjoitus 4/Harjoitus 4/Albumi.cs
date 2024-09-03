using System;
using System.Collections.Generic;

namespace Harjoitus_4
{
    class Albumi
    {
        public string Nimi { get; set; }
        public string Artisti { get; set; }
        public List<Kappale> Kappaleet { get; set; }

        public Albumi(string nimi, string artisti, List<Kappale> kappaleet)
        {
            Nimi = nimi;
            Artisti = artisti;
            Kappaleet = kappaleet;
        }

        public void TulostaAlbumi()
        {
            Console.WriteLine($"Albumi: {Nimi}");
            Console.WriteLine($"Artisti: {Artisti}");
            Console.WriteLine("Kappaleet:");
            foreach (var kappale in Kappaleet)
            {
                Console.WriteLine(kappale);
            }
    }   }
}
