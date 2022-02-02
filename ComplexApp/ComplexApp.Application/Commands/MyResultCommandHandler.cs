using BuildingBlocks.Application.Commands;

namespace ComplexApp.Application.Commands;

internal sealed class MyResultCommandHandler : ICommandHandler<MyResultCommand, string>
{
    public Task<string> Handle(MyResultCommand command, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("MyResultCommandHandler");
        return Task.FromResult(command.Text);
    }
}
