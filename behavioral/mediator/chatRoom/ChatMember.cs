namespace designPatterns.behavioral.mediator.chatRoom;

public abstract class ChatMember {

    protected IChatRoom _chatRoom;
    public string Name { get; private set; }

    protected ChatMember(string name) {
        _chatRoom = new ChatRoom();
        Name = !string.IsNullOrWhiteSpace(name) ? name : $"{Guid.NewGuid()}-ChatMember";
    }

    public void SetChatRoom(ChatRoom chatRoom) {
        _chatRoom = chatRoom;
    }

    public void Send(string message) {
        _chatRoom.Send(message, this);
    }
    
    public void SendTo<T>(string message) where T : ChatMember{
        _chatRoom.SendTo<T>(message, this);
    }
    public abstract void Receive(string message, string senderName);
}
