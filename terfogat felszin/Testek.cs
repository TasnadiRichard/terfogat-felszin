using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terfogat_felszin
{
    abstract class Testek
    {
        public string tipus;

        protected Testek(string tipus)
        {
            this.tipus = tipus;
        }

        public abstract double Felszin();
        public abstract double Terfogat();

        public override string ToString()
        {
            return tipus;
        }

    }
}