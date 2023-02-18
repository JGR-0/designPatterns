namespace mediator
{
    public class Component1 : BaseComponent
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Component 1 receives the message: {message}");
        }
    }
}