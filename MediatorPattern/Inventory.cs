using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class Inventory(IMediator mediator) : IBaseComponent
    {
        public IMediator Mediator { get; } = mediator;

        public void Notify(string name, string message)
        {
            Console.WriteLine($"An interaction has taken place with {name} functionality. It has sent us this message: {message}");
        }

        public void Send(string message)
        {
            Mediator.Send(this, message);
        }
    }
}
