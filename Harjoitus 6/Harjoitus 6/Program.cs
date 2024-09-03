using System;

namespace Harjoitus_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Eläinluokka.KuinkaMonta();

            Koira koira = new Koira();
            koira.Ääntele();


            Kissa kissa = new Kissa();
            kissa.Ääntele();

            koira.KuinkaMonta();
            Eläinluokka.KuinkaMonta();
            Kissa.KuinkaMonta();
        }
    }
}