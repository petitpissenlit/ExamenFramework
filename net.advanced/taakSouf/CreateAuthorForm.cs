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

namespace taakSouf
{
    public partial class CreateAuthorForm : BaseForm
    {
        private AuthorViewModel _authorViewModel;
        private AuthorService _authorService;

        public CreateAuthorForm(HomeForm homeForm, Guid g) : base(homeForm, g)
        {
            InitializeComponent();
            _authorViewModel = new AuthorViewModel();
            var authorRepository = new AuthorRepository(new AppDbContext());
            _authorService = new AuthorService(authorRepository);
            TextBoxConfiguration();
            
        }

        private void TextBoxConfiguration()
        {
            VoornaamTextbox.DataBindings.Add("Text", _authorViewModel, "Voornaam");
            naamTextbox.DataBindings.Add("Text", _authorViewModel, "Naam");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _authorService.Add(_authorViewModel);
                this.Hide();
                MessageBox.Show("Auteur aangemaakt.");
            }

            catch(Exception ex)
            {
                this.Hide();
                string message = ex.Message;
                MessageBox.Show("Kon auteur niet aanmaken.");
            }
        }
    }
}
