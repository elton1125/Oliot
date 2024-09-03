using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8
{
    class Radio
    {
        private int äänenvoimakkuus;

        public int Äänenvoimakkuus {
            get => äänenvoimakkuus;
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Annettu arvo oli suurempi kuin 100");
                    value = 100;
                } 
                else if (value  < 0)
                {
                    Console.WriteLine("Annettu arvo oli pienempi kuin 0");
                    value = 0;
                }

                Console.WriteLine("Äänenvoimakkuus asetettu, uusi arvo on " + value);


                äänenvoimakkuus = value;
            }
        }
    }
}
