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
    public class AuthorService
    {
        AuthorRepository _authorRepository { get; }
        public AuthorService(AuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void Add(AuthorViewModel author)
        {
            _authorRepository.Add(new Author() { Naam = author.Naam, Voornaam = author.Voornaam });
        }

        public List<AuthorViewModel> GetAllAuthors()
        {
           return _authorRepository.GetAllAuthors().Select(x => new AuthorViewModel
           {
               Id = x.Id,
               Naam = x.Naam, 
               Voornaam = x.Voornaam
           }).ToList();
        }
    }
}
