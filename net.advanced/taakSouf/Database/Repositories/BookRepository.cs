using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taakSouf.Database.Entities;

namespace taakSouf.Database.Repositories
{
    public class BookRepository
    {
        private AppDbContext _appDbContext { get; }
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(Book book)
        {
            _appDbContext.Books.Add(book);
            _appDbContext.SaveChanges();
        }

        public List<Book> GetBookByTilte(string title)
        {
            var books = from s in _appDbContext.Books
                        where s.Title.Contains(title)
                        select s;
            return books.Include(x => x.Author).ToList();
        }
        public List<Book> GetBooks()
        {
           return _appDbContext.Books.Include(x => x.Author).ToList();
        }
    }
}
