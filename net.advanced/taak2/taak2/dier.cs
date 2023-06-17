using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taak2
{
    internal class dier
    {
        public int gewicht { get; set; }

        protected dier(int gewicht)
        {
            this.gewicht = gewicht;
        }

        public string Zegt(string geluid)
        {
            return geluid;
        }

        public override string? ToString()
        {
            return "geluid " + gewicht;
        }


    }
}
