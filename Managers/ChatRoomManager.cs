using System.Collections.Generic;
using Chatolino.Models;

namespace Chatolino.Managers {
    public class ChatManager {
        private List<ChatRoom> _chatRooms;

        public ChatManager() {
            _chatRooms = new List<ChatRoom>();
        }

        public void AddRoom(ChatRoom chatRoom) {
            _chatRooms.Add(chatRoom);
        }

        public void RemoveRoom(ChatRoom chatRoom) {
            _chatRooms.Remove(chatRoom);
        }

        public List<ChatRoom> GetAllRooms() {
            return _chatRooms;
        }

        public ChatRoom GetRoomByName(string name) {
            return _chatRooms.Find(room => room.Name == name);
        }

        public bool RoomExists(string name) {
            return _chatRooms.Exists(room => room.Name == name);
        }
    }
}
