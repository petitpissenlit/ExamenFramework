using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using taakSouf.Database.Repositories;
using taakSouf.ViewModels;

namespace taakSouf.Database.Services
{
    public class UserService
    {
        UserRepository _userRepository { get; }
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(UserViewModel user)
        {
            user.Password = ComputeSha256Hash(user.Password);
            _userRepository.Add(user);
        }

        public void Login(UserViewModel user)
        {
            var userToSearch = _userRepository.GetUserByEmail(user.Email);
            if (userToSearch == null) throw new Exception("Gebruiker bestaat niet");
            if (userToSearch.Password != ComputeSha256Hash(user.Password)) throw new Exception("Wachtwoord is niet juist.");
            if (user.IsLoggedIn)
            {
                String separator = ","; StringBuilder output = new StringBuilder();
                String[] headings = { "IsLoggedIn" };
                output.AppendLine(string.Join(separator, headings));
                String[] newLine = {"true"};
                output.AppendLine(string.Join(separator, newLine));
                try
                {
                    string path = "C:\\Souf\\Output.csv";
                    using (StreamWriter sw = File.AppendText(path))
                    { 
                        if (!File.Exists(path))
                        {
                            sw.WriteLine("UserIsLoggedIn;");
                        }
                        sw.WriteLine("true;");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Internal error, gelieve een IT'er te contacteren.");
                }
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
