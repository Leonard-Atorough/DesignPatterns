using System.Xml.Linq;

namespace MediatorPattern
{
    public class WorkSystem(IMediator mediator) : IBaseComponent
    {
        public IMediator Mediator { get; } = mediator;

        public void Notify(string sender, string message)
        {
            Console.WriteLine($"An interaction has taken place with {sender} functionality. It has sent us this message: {message}");
        }

        public void Send(string message)
        {
            Mediator.Send(this, message);
        }
    }
}