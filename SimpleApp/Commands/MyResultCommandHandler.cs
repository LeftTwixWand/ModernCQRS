using SimpleApp.Configuration.Commands;

namespace SimpleApp.Commands;

internal sealed class MyResultCommandHandler : ICommandHandler<MyResultCommand, string>
{
    public Task<string> Handle(MyResultCommand command, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("CommandHandler with result");
        return Task.FromResult(command.Text);
    }
}
