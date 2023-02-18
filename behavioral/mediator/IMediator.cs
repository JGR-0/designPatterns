using mediator;

public interface IMediator {
    void Send(string message, BaseComponent component);
}