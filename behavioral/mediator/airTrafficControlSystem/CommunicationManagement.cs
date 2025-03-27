using designPatterns.behavioral.mediator.airTrafficControlSystem.contracts;

namespace designPatterns.behavioral.mediator.airTrafficControlSystem;

public class CommunicationManagement : ICommunicationMediator
{
    private readonly List<Airplane> RegisteredAirplanes = new List<Airplane>();

    public void RegisterAirplane(Airplane airplane)
    {
        RegisteredAirplanes.Add(airplane);
    }

    public void SendMessage(string message, Airplane sender, Airplane receiver)
    {
        Console.WriteLine($"Message from {sender.Id} to {receiver.Id}: {message}");
    }

    public void UpdateAirplanePosition(Airplane airplane, Position newPosition)
    {
        
        Console.WriteLine($"{airplane.Id} position updated to ({newPosition.Latitude}, {newPosition.Longitude})");
    }
}
