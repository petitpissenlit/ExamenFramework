using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taakSouf.Database.Repositories;
using taakSouf.Database.Services;
using taakSouf.Database;
using taakSouf.ViewModels;
using taakSouf.Database.Entities;

namespace taakSouf
{
    public partial class AuthorListForm : BaseForm
    {
        private AuthorService _authorService { get;  }

        public AuthorListForm(HomeForm homeForm, Guid g) : base(homeForm, g)
        {
            InitializeComponent();
            var authorRepository = new AuthorRepository(new AppDbContext());
            _authorService = new AuthorService(authorRepository);
            
            dataGridView1.DataSource = _authorService.GetAllAuthors().Select(x => new AuthorViewModel
            {
                Naam = x.Naam, 
                Voornaam = x.Voornaam
            }).ToList();
        }
    }
}
