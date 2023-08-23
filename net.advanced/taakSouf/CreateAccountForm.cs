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
using taakSouf.ViewModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace taakSouf
{
    public partial class CreateAccountForm : Form
    {
        private UserViewModel UserViewModel { get; set; }
        private UserService _userService { get; }
        
        public CreateAccountForm()
        {
            InitializeComponent();
            UserViewModel = new UserViewModel();
            var userRepository = new UserRepository(new AppDbContext());
            _userService = new UserService(userRepository);
            TextBoxConfiguration();
        }

        private void TextBoxConfiguration()
        {
            EmailTextbox.DataBindings.Add("Text", UserViewModel, "Email");
            PasswordTextbox.DataBindings.Add("Text", UserViewModel, "Password");
            GebruikersnaamTextbox.DataBindings.Add("Text", UserViewModel, "Username");
            PasswordTextbox.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.Add(UserViewModel);
                MessageBox.Show("Gebruiker werd aangemaakt.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kon de gebruiker niet aanmaken.");
            }
        }
    }
}
