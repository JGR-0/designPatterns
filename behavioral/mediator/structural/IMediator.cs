namespace designPatterns.behavioral.mediator.structural;

public interface IMediator {
    void Send(string message, BaseComponent component);
}