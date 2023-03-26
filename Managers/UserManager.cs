using System.Collections.Generic;
using Chatolino.Models;

namespace Chatolino.Managers {
    public class UserManager {
        private List<User> users;

        public UserManager() {
            users = new List<User>();
        }

        public void AddUser(User user) {
            users.Add(user);
        }

        public void RemoveUser(User user) {
            users.Remove(user);
        }

        public User GetUserByName(string name) {
            return users.Find(u => u.Name == name);
        }

        public List<User> GetAllUsers() {
            return users;
        }
    }
}
