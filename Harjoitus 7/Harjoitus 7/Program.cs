using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Kerros kerros = new Kerros();
            kerros.Ylinkerros = 6;
            kerros.Hissi = 1;
            Console.WriteLine("Hissin kerros: " + kerros.Hissi.ToString());
        }
    }
}