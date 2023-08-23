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
using System.Diagnostics;

namespace taakSouf
{
    public partial class HomeForm : Form
    {
        public event EventHandler<Guid> NewWindow;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void CreateAuthorToolStrip_Click(object sender, EventArgs e)
        {
            var guid = Guid.NewGuid();
            var authorForm = new CreateAuthorForm(this, guid);
            NewWindow?.Invoke(this, guid);
            authorForm.Show();
        }

        private void auteursBekijkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var guid = Guid.NewGuid();
            var authorForm = new AuthorListForm(this, guid);
            NewWindow?.Invoke(this, guid);
            authorForm.Show();
        }

        private void boekAanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var guid = Guid.NewGuid();
            var bookForm = new CreateBookForm(this, guid);
            NewWindow?.Invoke(this, guid);
            bookForm.Show();
        }

        private void boekenBekijkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var guid = Guid.NewGuid();
            var bookForm = new BookListForm(this, guid);
            NewWindow?.Invoke(this, guid);
            bookForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Souf\Output.csv";
            if(File.Exists(path)) File.Delete(path);
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void boekZoekenOpNaamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var guid = Guid.NewGuid();
            var searchBookForm = new SearchBookByNameForm(this, guid);
            NewWindow?.Invoke(this, guid);
            searchBookForm.Show();
        }
    }
}
