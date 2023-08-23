using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taakSouf.Database.Entities;
using taakSouf.ViewModels;

namespace taakSouf.Database.Repositories
{
    public class AuthorRepository
    {
        private AppDbContext _appDbContext { get; }
        public AuthorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(Author author)
        {
            _appDbContext.Authors.Add(author);
            _appDbContext.SaveChanges();
        }

        public List<Author> GetAllAuthors()
        {
            return _appDbContext.Authors.ToList();
        }

    }
}
