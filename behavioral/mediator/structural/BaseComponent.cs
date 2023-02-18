public abstract class BaseComponent {
    protected IMediator _mediator;

    public void SetMediator(IMediator mediator) {
        _mediator = mediator;
    }

    public void Send(string message) {
        _mediator.Send(message, this);
    }

    public abstract void HandleNotification(string message);
}