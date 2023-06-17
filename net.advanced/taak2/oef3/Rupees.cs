using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef3
{
    internal class Rupees : USD
    {
        public double r;
        public Rupees(double a) : base(a)
        {
            r = a * 75.13;
        }

        public override string ToString()
        {
            return r.ToString();
        }
    }
}
