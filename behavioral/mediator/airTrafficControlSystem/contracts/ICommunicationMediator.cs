public interface ICommunicationMediator
{
    void RegisterAirplane(Airplane airplane);

    void SendMessage(string message, Airplane sender, Airplane receiver);

    void UpdateAirplanePosition(Airplane airplane, Position newPosition);
}
