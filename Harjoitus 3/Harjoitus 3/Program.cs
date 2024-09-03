using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas sauna = new Kiuas();
            sauna.DisplayStatus();

            Console.WriteLine("Kiuas päälle.");
            sauna.LaitaPäälle();
            sauna.Vaihdalämpötila(50);
            sauna.MuutaKosteus(30);
            sauna.DisplayStatus();

            Console.WriteLine("Kiuas on pois päältä");
            sauna.LaitaPois();
            sauna.DisplayStatus();
        }
    }
}
