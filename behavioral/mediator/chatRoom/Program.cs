namespace designPatterns.behavioral.mediator.chatRoom;

public static class Program 
{
    public static void Main(string[] args) 
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Welcome to the mediator chat room!");
        Console.WriteLine();

        var chatRoom = new ChatRoom();
        var bob = new AdminChatMember("Bob");
        var mary = new AdminChatMember("Mary");
        var steve = new ContributorChatMember("Steve");
        chatRoom.RegisterMembers(bob, mary, steve);

        bob.Send("Hi guys, I am going to the zoo tomorrow afternoon, anyone wants to come?");
        mary.Send("Hi steve, I am in, how do you plan to go?");
        steve.Send("Sorry guys, I have a birthday party. Enjoy it & send pics!");
        Console.WriteLine();
        bob.SendTo<AdminChatMember>("Let's talk privately, so we do not disturb Steve. I am going by car. Shall I pick you up?");
        mary.SendTo<AdminChatMember>("Sure! That will be fantastic.");
    }
}