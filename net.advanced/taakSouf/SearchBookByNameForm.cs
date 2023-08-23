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

namespace taakSouf
{
    public partial class SearchBookByNameForm : BaseForm
    {
        private BookService _bookService { get; }

        public SearchBookByNameForm(HomeForm homeForm, Guid g) : base(homeForm, g)
        {
            InitializeComponent();
            var context = new AppDbContext();
            var bookRepository = new BookRepository(context);
            _bookService = new BookService(bookRepository);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var books = _bookService.GetBooksByTitle(titleTextbox.Text);
            BookDatagridView.DataSource = books;
            BookDatagridView.Columns["AuthorId"].Visible = false;
        }
    }
}
