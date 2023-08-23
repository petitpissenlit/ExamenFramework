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
    public partial class LoginForm : Form
    {
        private UserViewModel UserViewModel { get; set; }
        private UserService _userService { get; }

        public LoginForm()
        {
            InitializeComponent();
            UserViewModel = new UserViewModel();
            var userRepository = new UserRepository(new AppDbContext());
            _userService = new UserService(userRepository);
            TextBoxConfiguration();
        }

        private void TextBoxConfiguration()
        {
            emailTextbox.DataBindings.Add("Text", UserViewModel, "Email");
            passwordTextbox.DataBindings.Add("Text", UserViewModel, "Password");
            rememberMeButton.DataBindings.Add("Checked", UserViewModel, "IsLoggedIn");
            passwordTextbox.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.Login(UserViewModel);
                var homeForm = new HomeForm();
                this.Hide();
                homeForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            var createAccountForm = new CreateAccountForm();
            this.Hide();
            createAccountForm.Show();
        }
    }
}
