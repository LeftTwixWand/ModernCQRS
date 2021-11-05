using Application.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Processing
{
    internal record MyCommand(string Text) : CommandBase<string>;

    internal class MyCommandHandler : ICommandHandler<MyCommand, string>
    {
        public Task<string> Handle(MyCommand command, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Command result: {command.Text}");
            return Task.FromResult(command.Text);
        }
    }
}