using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediatorPattern
{
    internal class Crafting(IMediator mediator) : IBaseComponent
    {
        public IMediator Mediator { get; } = mediator;

        public void Notify(string sender, string message)
        {
            Console.WriteLine();
            Console.WriteLine($"An interaction has taken place with {sender} functionality. It has sent us this message: {message}");
        }

        public void Send(string message)
        {
            this.Mediator.Send(this, message);
        }
    }
}
