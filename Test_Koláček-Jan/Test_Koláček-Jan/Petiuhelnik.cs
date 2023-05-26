using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Koláček_Jan
{
    class Petiuhelnik
    {

        private double strana;
        private string jednotky;

        public Petiuhelnik()
        {
            strana = 1;
            jednotky = "m";
        }

        public Petiuhelnik(double a, string j)
        {
            strana = a;
            jednotky = j;
        }

        public double getStrana()
        {
            return strana;
        }
        public string getJednotky()
        {
            return jednotky;
        }
        public void setStrana(double a)
        {
            strana = a;
        }
        public void setJednotky(string j)
        {
            jednotky = j;
        }
        public double Obsah()
        {
            return ((Math.Sqrt(25 + 10 * Math.Sqrt(5))) / 4) * Math.Pow(strana, 2);
        }
        public double Obvod()
        {
            return 5 * strana;
        }
    }
}
