public interface IChatRoom {
    void Send(string message, ChatMember chatMember);
    void SendTo<T>(string message, ChatMember chatMember) where T : ChatMember;
}
