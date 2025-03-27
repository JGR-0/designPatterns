namespace designPatterns.behavioral.mediator.airTrafficControlSystem.contracts;

public interface IAirTrafficControlCenter
{

    void RegisterAirplanes();

    void BroadcastMessage(string message);

    void DisplayUpdate(Airplane airplane);

    void DetectCollision(Airplane airplane1, Airplane airplane2);

}