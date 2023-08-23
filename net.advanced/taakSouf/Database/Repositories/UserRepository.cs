using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taakSouf.Database.Entities;
using taakSouf.ViewModels;

namespace taakSouf.Database.Repositories
{
    public class UserRepository
    {
        private AppDbContext _appDbContext { get; }
        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;       
        }

        public User GetUserByEmail(string email)
        {
            var user =  _appDbContext.Users.Where(x => x.Email == email).FirstOrDefault();
            return user;
        }

        public void Add(UserViewModel user) 
        {
            _appDbContext.Users.Add(new User
            {
                Username = user.Username,
                Email = user.Email,
                Password = user.Password,
            });

            _appDbContext.SaveChanges();
        }
    }
}
