using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef3
{
    internal class Franken : USD
    {
        public double f;
        public Franken(double a) : base(a)
        {
            f = a * 0.93;
        }

        public override string ToString()
        {
            return f.ToString();
        }
    }
}
