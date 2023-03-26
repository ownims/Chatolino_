using System.Collections.Generic;
using Chatolino.Models;

namespace Chatolino.Managers {
    public class ChatManager {
        private List<ChatRoom> _chatRooms;

        public ChatManager() {
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
            return _chatRooms.Find(c => c.Name == name);
        }

        public List<Message> GetMessagesByChatRoom(ChatRoom chatRoom) {
            List<Message> messages = new List<Message>();
            foreach (var room in _chatRooms) {
                if (room.Name == chatRoom.Name) {
                    messages.AddRange(room.Messages);
                }
            }
            return messages;
        }

        public void AddUserToChatRoom(ChatRoom chatRoom, User user) {
            chatRoom.AddUser(user);
        }

        public void RemoveUserFromChatRoom(ChatRoom chatRoom, User user) {
            chatRoom.RemoveUser(user);
        }

        public void AddMessageToChatRoom(ChatRoom chatRoom, Message message) {
            chatRoom.AddMessage(message);
        }
    }
}
