using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taakSouf.Database;
using taakSouf.Database.Repositories;
using taakSouf.Database.Services;

namespace taakSouf
{
    public partial class BookListForm : BaseForm
    {
        private BookService _bookService { get; }

        public BookListForm(HomeForm homeForm, Guid g) : base(homeForm,g)
        {
            InitializeComponent();
            var context = new AppDbContext();
            var bookRepository = new BookRepository(context);
            _bookService = new BookService(bookRepository);
            BooksGridView.DataSource = _bookService.GetBooks();
            BooksGridView.Columns["AuthorId"].Visible = false;
        }

        private void BooksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
