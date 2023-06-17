using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef3
{
    internal class Yen : USD
    {
        public double y;
        public Yen(double a) : base(a)
        {
            y = a * 112.20;
        }

        public override string ToString()
        {
            return y.ToString();
        }
    }
}
