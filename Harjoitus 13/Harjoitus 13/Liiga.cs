using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_13
{
    class Liiga
    {
        private string Etunimi;
        private string Sukunimi;
        private int pelinumero;

        static Dictionary<int, Pelaaja> Joukkue = new Dictionary<int, Pelaaja>();

        public static void Lisää()
        {
            bool Tarkista = false;
            Console.WriteLine();
            Console.WriteLine("Syötä pelaajan etunimi");
            string Etunimi = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Syötä pelaajan sukunimi");
            string Sukunimi = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Syötä pelaajan pelinumero");
            int Pelinumero = int.Parse(Console.ReadLine());
            while (!Tarkista)
            {
                Tarkista = Tarkistus(Pelinumero);
            }
            if (Tarkista)
            {
                Joukkue.Add(Pelinumero, new Pelaaja(Etunimi, Sukunimi, Pelinumero));
                Console.WriteLine(Joukkue[Pelinumero].TulostaTiedot() + " Lisätty joukkueeseen ");
            }
        }

        public static bool Tarkistus(int e)
        {
            foreach (int value in Joukkue.Keys)
            {
                if (e == value)
                {
                    Console.WriteLine(" Tämä pelaajan numero löytyi joukkueesta");

                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        public static void Poista()
        {
            foreach (int value in Joukkue.Keys)
            {
                Console.WriteLine();
                Console.WriteLine(Joukkue[value].TulostaTiedot());
            }
            int e = int.Parse(Console.ReadLine());
            foreach (int value in Joukkue.Keys)
            {
                if (e == value)
                {
                    Console.WriteLine(Joukkue[e].TulostaTiedot() + " Poistettu joukkueesta ");
                    Joukkue.Remove(e);
                }
                else
                {
                    Console.WriteLine(" Tätä pelaaja ei löydetty joukkueesta");
                    return;
                }
            }
        }

        public static void Näytä()
        {
            foreach (int value in Joukkue.Keys)
            {
                Console.WriteLine();
                Console.WriteLine(Joukkue[value].TulostaTiedot());
            }
        }
    }
}