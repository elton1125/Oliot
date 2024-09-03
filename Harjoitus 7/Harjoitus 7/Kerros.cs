namespace Harjoitus_7
{
    public class Kerros
    {
        private int hissi;
        public int Ylinkerros = 9;
        public int Hissi
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
    }
}