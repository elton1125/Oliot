using System;

namespace Harjoitus_2
(
    class Program
    (
        static void Main(string[] args)
        (
            // Tuodaan opiskelija olio
            Opiskelija opiskelija1 = new Opiskelija("Matti", "TVT1234", 0);
            
            opiskelija1.TulostaData();
            opiskelija1.MuokkaaOpintopisteiä(5);
            opiskelija1.TulostaData();
        )
    )
)