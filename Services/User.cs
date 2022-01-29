using System.Collections.Generic;
using System.Linq;

namespace Rki.CancerDataGenerator.Services
{
    public class User
    {
        public enum UserRole
        {
            DEV = 1,
            USER = 2,
            ADMIN = 3
        }

        public int Id { get; set; }
        public string Username { get; internal set; }
        public string Password { get; internal set; }
        public string[] Roles { get; set; }



        public User(string username, string password, string[] roles)
        {
            Username = username;
            Password = password;
            Roles = roles;
        }

        public static List<User> GetDefaultValues() 
        {
            var list = new List<User>();
            User.AddItemToList(ref list, 
                new User( "user1", "pass1", new string[] { nameof(UserRole.ADMIN) })
                );
            User.AddItemToList(ref list, 
                new User("user2", "pass2", new string[] { nameof(UserRole.USER), nameof(UserRole.DEV) })
                );

            return list;
        }


        /// <summary>
        /// Add new user if username not registered
        /// </summary>
        /// <param name="users">ref to list</param>
        /// <param name="user">new item</param>
        /// <returns>success of operation</returns>
        public static bool AddItemToList(ref List<User> users, User user)
        {
            if (user == null || users.Any(x=>x.Username == user.Username))
                return false;
            user.Id = users.Any()? users.Max(x => x.Id) + 1 : 1;
            users.Add(user);
            return true;
        }
    }
}