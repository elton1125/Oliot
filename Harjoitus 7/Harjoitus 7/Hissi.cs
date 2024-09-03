using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harjoitus_7;

namespace Harjoitus_7
{
    public class Hissi
    {
        public int Ylinkerros = 9;
        private int hissi;
        public int MaxHissi
        {
            get { return hissi; }
            set
            {
                if (value > Ylinkerros)
                {
                    hissi = Ylinkerros;
                }
                else
                {
                    hissi = value;
                }
            }
        }

        public static void Main(string[] args)
        {
            Kerros kerros = new Kerros();
            kerros.Ylinkerros = 6;
            kerros.Hissi = 1;
            Console.WriteLine("Hissin kerros: " + kerros.Hissi.ToString());
        }
    }
}