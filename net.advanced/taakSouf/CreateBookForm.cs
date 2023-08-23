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
using taakSouf.Database;
using taakSouf.Database.Services;
using taakSouf.ViewModels;

namespace taakSouf
{
    public partial class CreateBookForm : BaseForm
    {
        private AuthorService _authorService { get; }
        private BookService _bookService { get; }
        private BookViewModel _bookViewModel { get; }
        private int _selectedAuthorId { get; set; }
        public CreateBookForm(HomeForm homeForm, Guid g) : base(homeForm, g)
        {
            InitializeComponent();
            var context = new AppDbContext();
            var authorRepository = new AuthorRepository(context);
            _authorService = new AuthorService(authorRepository);
            var bookRepository = new BookRepository(context);
            _bookService = new BookService(bookRepository);
            comboBoxAuthors.DataSource = _authorService.GetAllAuthors();
            _bookViewModel = new BookViewModel();
            TitleTextbox.DataBindings.Add("Text", _bookViewModel, "Title");
        }

        private void CreateBookForm_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var b = (AuthorViewModel)comboBoxAuthors.SelectedItem;
            _selectedAuthorId = b.Id;
        }

        private void CreateBookbutton_Click(object sender, EventArgs e)
        {
            try
            {
                _bookViewModel.AuthorId = _selectedAuthorId;
                _bookService.Add(_bookViewModel);
                MessageBox.Show("Boek werd aangemaakt a sahbe");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Kon boek niet aanmaken");
            }
        }
    }
}
