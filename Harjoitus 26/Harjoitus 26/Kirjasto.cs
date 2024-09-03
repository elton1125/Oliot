using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_26
{
    public class Kirjasto
    {
        private ObservableCollection<Kirja> kirjat = new ObservableCollection<Kirja>();

        public ObservableCollection<Kirja> Kirjat
        {
            get { return kirjat; }
            set { kirjat = value; }
        }

        public void LisääKirja(Kirja kirja)
        {
            kirjat.Add(kirja);
        }

        public void PoistaKirja(Kirja kirja)
        {
            kirjat.Remove(kirja);
        }

        public void LainaaKirja(Kirja kirja)
        {
            if (!kirja.Onlainassa)
            {
                kirja.Onlainassa = true;
            }
            else
            {
                throw new Exception("Kirja on jo lainassa.");
            }
        }

        public void PalautaKirja(Kirja kirja)
        {
            if (kirja.Onlainassa)
            {
                kirja.Onlainassa = false;
            }
            else
            {
                throw new Exception("Kirjaa ei ole lainassa.");
            }
        }
    }
}