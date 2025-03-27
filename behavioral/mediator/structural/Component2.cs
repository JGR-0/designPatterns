namespace designPatterns.behavioral.mediator.structural;

public class Component2 : BaseComponent
{
    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Component 2 receives the message: {message}");
    }
}