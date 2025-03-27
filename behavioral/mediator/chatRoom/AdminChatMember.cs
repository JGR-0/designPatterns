namespace designPatterns.behavioral.mediator.chatRoom;

public class AdminChatMember : ChatMember {
    public AdminChatMember(string name) : base(name)
    {}

    public override void Receive(string message, string senderName) {
        Console.WriteLine($"{Name} receives from {senderName}: {message}");
    }
}
