using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taakSouf.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorViewModel Author { get; set; }
        public int AuthorId { get; set; }
    }
}
