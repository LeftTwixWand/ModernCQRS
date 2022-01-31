using BuildingBlocks.Application.Commands;

namespace ComplexApp.Application.Commands;

internal sealed class MyCommandHandler : ICommandHandler<MyCommand, string>
{
    public Task<string> Handle(MyCommand command, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Command Handler result: {command.Text}");
        return Task.FromResult(command.Text);
    }
}