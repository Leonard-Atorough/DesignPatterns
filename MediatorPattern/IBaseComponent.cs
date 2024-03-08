namespace MediatorPattern
{
    public interface IBaseComponent
    {
        public string Name => GetType().Name;
        public IMediator Mediator { get; }
        public void Notify(string name, string message);

        public void Send(string message);
    }
}