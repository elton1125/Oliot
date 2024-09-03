using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    class Eläinluokka
    {
        private static int instanssit = 0;

        public koira()
        {
            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä luotu " + instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("Woof");
        }
    }
}
