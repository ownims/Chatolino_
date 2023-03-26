using System.Collections.Generic;

namespace Chatolino.Models {
    public class ChatRoom {
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public List<Message> Messages { get; set; }

        public ChatRoom(string name) {
            Name = name;
            Users = new List<User>();
            Messages = new List<Message>();
        }

        public void AddUser(User user) {
            Users.Add(user);
        }

        public void RemoveUser(User user) {
            Users.Remove(user);
        }

        public void AddMessage(Message message) {
            Messages.Add(message);
        }
    }
}
