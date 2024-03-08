namespace MediatorPattern
{
    public class RecipeSystem(IMediator mediator) : IBaseComponent
    {
        public IMediator Mediator { get; } = mediator;

        public void Notify(string message)
        {
            throw new NotImplementedException();
        }

        public void Send(string message)
        {
            throw new NotImplementedException();
        }
    }
}