using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terfogat_felszin
{
    internal class Kocka : Testek
    {
        readonly double aoldal;
    public Kocka(double aoldal) : base("Kocka")
        {
            this.aoldal = aoldal;
        }
        public double Aoldal => Aoldal;

        public override double Felszin()
        {
            return 6 * (aoldal * aoldal);
        }

        public override double Terfogat()
        {
            return aoldal * aoldal * aoldal;
        }
    }
}
