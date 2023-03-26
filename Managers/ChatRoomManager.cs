using System.Collections.Generic;
using System.Linq;
using Chatolino.Models;

namespace Chatolino.Managers {
    public class ChatRoomManager {
        private readonly List<ChatRoom> _chatRooms;

        public ChatRoomManager() {
            _chatRooms = new List<ChatRoom>();
        }

        public void AddChatRoom(ChatRoom chatRoom) {
            _chatRooms.Add(chatRoom);
        }

        public void RemoveChatRoom(ChatRoom chatRoom) {
            _chatRooms.Remove(chatRoom);
        }

        public List<ChatRoom> GetChatRooms() {
            return _chatRooms;
        }

        public ChatRoom GetChatRoomByName(string name) {
            return _chatRooms.FirstOrDefault(c => c.Name == name);
        }
    }
}
