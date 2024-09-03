using System;
using System.Collections.Generic;

namespace Harjoitus_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pakka = new List<string>();

            for (int i = 0; i < 13; i++)
            {
                pakka.Add("Pata - " + (i + 1));
                pakka.Add("Hertta - " + (i + 1));
                pakka.Add("Risti - " + (i + 1));
                pakka.Add("Ruutu - " + (i + 1));
            }

            
            for (int i = 44; i < 52; i++)
            {
                Console.WriteLine($"{i + 1}. {pakka[i]}");
            }

            Console.WriteLine("\nKorttipakka on sekoitettu.");
            Console.WriteLine("Tässä sekoitetun korttipakan viisi ensimmäistä korttia:");

            
            Shuffle(pakka);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. {pakka[i]}");
            }
        }

        
        static void Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
