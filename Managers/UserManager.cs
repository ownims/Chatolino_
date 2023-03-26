using System.Collections.Generic;
using Chatolino.Models;

namespace Chatolino.Managers {
    public class UserManager {
        private List<User> _users;

        public UserManager() {
            _users = new List<User>();
        }

        public void AddUser(User user) {
            _users.Add(user);
        }

        public void RemoveUser(User user) {
            _users.Remove(user);
        }

        public User GetUserByName(string name) {
            return _users.Find(u => u.Name == name);
        }

        public List<User> GetAllUsers() {
            return _users;
        }
    }
}
