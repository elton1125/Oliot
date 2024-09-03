using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_11
{
    class Opiskelija
    {
        public Etunimi Etunimi { get; set; }
        public Sukunimi Sukunimi { get; set; }
        public Ryhmätunnus Ryhmätunnus { get; set; }
        public OpiskelijaID OpiskelijaID { get; set; }

        public Opiskelija(Etunimi etunimi, Sukunimi sukunimi, Ryhmätunnus ryhmätunnus, OpiskelijaID opiskelijaID)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Ryhmätunnus = ryhmätunnus;
            OpiskelijaID = opiskelijaID;
        }
    }
}
