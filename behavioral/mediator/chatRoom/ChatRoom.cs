namespace designPatterns.behavioral.mediator.chatRoom;

public class ChatRoom : IChatRoom {

    private IEnumerable <ChatMember> chatMembers;

    public ChatRoom() {
        chatMembers = new List <ChatMember>();
    }

    public void Register(ChatMember chatMember){
        chatMembers = chatMembers.Append(chatMember);
        chatMember.SetChatRoom(this);
    }

    public void RegisterMembers(params ChatMember[] chatMembers){
        foreach(var chatMember in chatMembers){
            Register(chatMember);
        }
    }

    public void Send(string message, ChatMember chatMember) {
        chatMembers
            .Where(c => c != chatMember)
            .ToList()
            .ForEach(c => c.Receive(message, chatMember.Name));
    }

    public void SendTo<T>(string message, ChatMember chatMember) where T : ChatMember {
        chatMembers.OfType<T>()
            .Where(c => c != chatMember)
            .ToList()
            .ForEach(c => c.Receive(message, chatMember.Name));
    }
}
