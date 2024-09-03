using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_13
{
    class Pelaaja
    {
        public string Etunimi;
        public string Sukunimi;
        public int Pelinumero;

        public Pelaaja(string _etunimi, string _sukunimi, int _pelinumero)
        {
            Etunimi = _etunimi;
            Sukunimi = _sukunimi;
            Pelinumero = _pelinumero;
        }

        public string TulostaTiedot()
        {
            return "Pelaaja:  " + Etunimi + " " + Sukunimi + " " + Pelinumero;

        }

    }
}