public class ConcreteMediator : IMediator {
    private List<BaseComponent> _components = new List<BaseComponent>();

    public ConcreteMediator() {}

    public void Register(BaseComponent component) {

        component.SetMediator(this);
        _components.Add(component);
    }

    public T CreateComponent<T>() where T : BaseComponent, new() {
        var component = new T();
        Register(component);
        return component;
    }

    public void Send(string message, BaseComponent component) {
        this._components
            .Where(c => c != component)
            .ToList()
            .ForEach(c => c.HandleNotification(message));
    }
}