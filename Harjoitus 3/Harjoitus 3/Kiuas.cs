using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_3
{
    class Kiuas
    {
        private int Päällä;
        private int Lämpötila;
        private int Kosteus;

        public Kiuas()
        {
            Päällä = false;
            Lämpötila = 10;
            Kosteus = 30;
        }

        public void LaitaPäälle()
        {
            Päällä = true;
            Console.WriteLine("Kiuas päällä");
        }

        public void LaitaPois()
        {
            Päällä = false;
            Console.WriteLine("Kiuas on pois päältä");
        }

        public void Vaihdalämpötila(int lämp)
        {
            Lämpötila = lämp;
            Console.WriteLine("Asetettu lämpötila: (Lämpötila) astetta");
        }

        public void MuutaKosteus(int kos)
        {
            Kosteus = kos;
            Console.WriteLine("Asetettu kosteus: (Kosteus");
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Kiuas päällä: (Päällä)");
            Console.WriteLine("Lämpötila: (Lämpötila) astetta");
            Console.WriteLine("Kosteus: (Kosteus)");
        }
    }
}
