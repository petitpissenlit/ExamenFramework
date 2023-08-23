using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taakSouf.ViewModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }

        public override string ToString()
        {
            return $"{Naam} {Voornaam}";
        }
    }
}
