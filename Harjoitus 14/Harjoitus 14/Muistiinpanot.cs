using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_14
{
    class Muistiinpanot
    {
        private const string TiedostoNimi = "muistiinpanot.txt";

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Valitse toiminto:");
                Console.WriteLine("1. Uusi muistiinpano");
                Console.WriteLine("2. Tulosta muistiinpanot");
                Console.WriteLine("3. Tyhjennä muistiinpanot");
                Console.WriteLine("4. Lopeta");

                string valinta = Console.ReadLine();

                switch (valinta)
                {
                    case "1":
                        LuoUusiMuistiinpano();
                        break;
                    case "2":
                        TulostaMuistiinpanot();
                        break;
                    case "3":
                        TyhjennaMuistiinpanot();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                        break;
                }
            }
        }

        static void LuoUusiMuistiinpano()
        {
            Console.WriteLine("Kirjoita uusi muistiinpano:");
            string muistiinpano = Console.ReadLine();
            using (StreamWriter tiedosto = File.AppendText(TiedostoNimi))
            {
                tiedosto.WriteLine(muistiinpano);
            }
            Console.WriteLine("Muistiinpano tallennettu.");
        }

        static void TulostaMuistiinpanot()
        {
            if (!File.Exists(TiedostoNimi))
            {
                Console.WriteLine("Ei muistiinpanoja.");
                return;
            }
            string[] muistiinpanot = File.ReadAllLines(TiedostoNimi);
            if (muistiinpanot.Length == 0)
            {
                Console.WriteLine("Ei muistiinpanoja.");
                return;
            }
            Console.WriteLine("Muistiinpanot:");
            foreach (string muistiinpano in muistiinpanot)
            {
                Console.WriteLine(muistiinpano);
            }
        }

        static void TyhjennaMuistiinpanot()
        {
            File.Delete(TiedostoNimi);
            Console.WriteLine("Muistiinpanot tyhjennetty.");
        }
    }
}
