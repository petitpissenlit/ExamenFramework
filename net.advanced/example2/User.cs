using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public User(int id, string userName)
        {
            Id = id;
            UserName = userName;
        }

        public static IList<User> GenerateUsers()
        {
            return new List<User> { new User(1, "User1"), new User(2, "User2") };
        }

        public void ClearUserName()
        {
            UserName = "";
        }

        public override string ToString()
        {
            return $"id: {Id} Username: {UserName}";
        }
    }
}
