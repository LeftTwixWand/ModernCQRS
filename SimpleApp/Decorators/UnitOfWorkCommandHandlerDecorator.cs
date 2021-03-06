using MediatR;
using SimpleApp.Configuration.Commands;

namespace SimpleApp.Decorators;

internal sealed class UnitOfWorkCommandHandlerDecorator<TCommand, TResult> : ICommandHandler<TCommand, TResult>
    where TCommand : CommandBase<TResult>
{
    private readonly IRequestHandler<TCommand, TResult> _decorated;

    public UnitOfWorkCommandHandlerDecorator(IRequestHandler<TCommand, TResult> decorated)
    {
        _decorated = decorated;
    }

    public async Task<TResult> Handle(TCommand command, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("UnitOfWorkCommandHandlerDecorator start");

        var result = await _decorated.Handle(command, cancellationToken);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("UnitOfWorkCommandHandlerDecorator end");
        return result;
    }
}