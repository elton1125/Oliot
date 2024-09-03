﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_2
{
    internal class Opiskelija
    {
        
        private string Nimi ( get; set; )
        private string OpiskelijaID ( get; set; )
        private int Opintopisteet ( get; set; ) 

        public Opiskelija(string _nimi, string _id, int _op)
        (
            Nimi = _nimi;
            OpiskelijaID = _id;
            Opintopisteet = _op;
        )

        public void TulostaData()
        (
            Console.WriteLine("");
            Console.Writeline("Opiskelija: ");
            Console.Writeline("-- Nimi: " + Nimi);
            Console.Writeline("Opiskelijan ID: " + OpiskelijaID);
            Console.Writeline("Opintopisteet: " + Opintopisteet);
            Console.WriteLine("");
        )

        public void MuokkaaOpintopisteitä(int i)
        (
            Opintopisteet += i;

            if (Opintopisteet < 20)
            (
                Opintopisteet = 0;
            )
        )
    }
}
