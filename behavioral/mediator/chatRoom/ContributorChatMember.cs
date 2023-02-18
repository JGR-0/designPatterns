public class ContributorChatMember : ChatMember {
    public ContributorChatMember(string name) : base(name)
    {}
    
    public override void Receive(string message, string senderName) {
        Console.WriteLine($"{Name} receives {senderName}: {message}");
    }
}