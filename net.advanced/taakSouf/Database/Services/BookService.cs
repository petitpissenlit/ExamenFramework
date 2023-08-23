using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taakSouf.Database.Entities;
using taakSouf.Database.Repositories;
using taakSouf.ViewModels;

namespace taakSouf.Database.Services
{
    public class BookService
    {
        BookRepository _bookRepository { get; }
        public BookService(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(BookViewModel bookViewModel)
        {
            _bookRepository.Add(new Book { AuthorId = bookViewModel.AuthorId, Title = bookViewModel.Title });
        }

        public List<BookViewModel> GetBooks()
        {
            return _bookRepository.GetBooks().Select(x => new BookViewModel() { 
                Id = x.Id, Title = x.Title, 
                AuthorId = x.AuthorId,
                Author = new AuthorViewModel { Id = x.Author.Id, Naam = x.Author.Naam, Voornaam = x.Author.Voornaam}
            }).ToList();
        }

        public List<BookViewModel> GetBooksByTitle(string title)
        {
            return _bookRepository.GetBookByTilte(title).Select(x => new BookViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                AuthorId = x.AuthorId,
                Author = new AuthorViewModel { Id = x.Author.Id, Naam = x.Author.Naam, Voornaam = x.Author.Voornaam }
            }).ToList();
        }
    }
}
