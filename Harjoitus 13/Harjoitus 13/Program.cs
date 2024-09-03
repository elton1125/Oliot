using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_13
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Mitä haluat tehdä?");
                Console.WriteLine("Lisää - Kirjota lisää jos haluat lisätä uuden pelaajan ");
                Console.WriteLine("Poista - Kirjota poista jos haluat poista pelaajan ");
                Console.WriteLine("Tulosta - Kirjota tulosta jos haluat tulosaa pelaajan tiedot ");
                Console.WriteLine("Poistu - kirjota poistu jos haluat poistua ohjelmasta ");
                string syöte = Console.ReadLine();

                switch (syöte)
                {
                    case "Lisää":
                        
                        Liiga.Lisää();
                        break;

                    case "Poista":
                        
                        Liiga.Poista();
                        break;

                    case "Tulosta":
                        
                        Liiga.Näytä();
                        break;

                    case "Poistu":
                        
                        return;


                    default:
                        Console.WriteLine("Tuntematon syöte yritä uudestaan ");
                        break;


                }

            }
            Liiga.Lisää();
            Liiga.Poista();
            Liiga.Näytä();
        }
    }
}