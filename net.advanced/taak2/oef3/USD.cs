using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef3
{
    internal class USD
    {

        public double a { get; set; }

        public USD(double a)
        {
            this.a = a;
        }

        public USD()
        {
            this.a = a;
        }



        public override string ToString()
        {
            return a.ToString();
        }

    }
}
