using System.Collections.Generic;
using Chatolino.Models;

namespace Chatolino.Managers {
    public class MessageManager {
        private List<Message> messages;

        public MessageManager() {
            messages = new List<Message>();
        }

        public void AddMessage(Message message) {
            messages.Add(message);
        }

        public List<Message> GetMessagesByChatRoom(ChatRoom chatRoom) {
            return messages.FindAll(m => m.ChatRoom.Name == chatRoom.Name);
        }

        public List<Message> GetMessagesByUser(User user) {
            return messages.FindAll(m => m.User.Name == user.Name);
        }
    }
}
