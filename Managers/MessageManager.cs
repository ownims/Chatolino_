using System.Collections.Generic;
using Chatolino.Models;

namespace Chatolino.Managers {
    public class MessageManager {
        private readonly List<Message> _messages;

        public MessageManager() {
            _messages = new List<Message>();
        }

        public void AddMessage(Message message) {
            _messages.Add(message);
        }

        public List<Message> GetMessages(ChatRoom chatRoom) {
            return _messages.FindAll(m => m.ChatRoom.Name == chatRoom.Name);
        }
    }
}
