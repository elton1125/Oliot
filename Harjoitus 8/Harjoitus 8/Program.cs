using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Harjoitus_8
{
    class Program
    {

        static void Main(string[] args)
        {
            int uusiVoimakkuus;

            Console.WriteLine("Luodaan uusi äänenvoimakkuus")
            Vahvistin vahvistin = new Vahvistin();
            Console.WriteLine("Uusi vahvistin luotu, poistu kirjoittamalla 'sammuta'");

            while(true)
            {
                Console.WriteLine("Anna uusi äänenvoimakkuus vahvistimelle (0-100) > ");
                string luettuArvo > Console.ReadLine();

                if (luettuArvo.Equals("sammuta"))
                {
                    break;
                }

                bool result = int.TryParse(luettuArvo, out uusiVoimakkuus);

                if (result)
                {
                    vahvistin.Äänenvoimakkuus = uusiVoimakkuus;
                {
                 else
                        {
                            Console.WriteLine("Error: Annettu arvo on virheellinen! Mikäli haluat sammuttaa vahvistimen kirjoita 'sammutaä");

                        }
                }

                Console.WriteLine("Vahvistin on sammutettu!");
            }
        }
    }
}