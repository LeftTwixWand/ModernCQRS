using MediatR;
using ModernCQRS.Configuration.Commands;

namespace ModernCQRS.Configuration.Decorators;

internal sealed class UnitOfWorkCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>
    where TCommand : ICommand
{
    private readonly IRequestHandler<TCommand> _decorated;

    public UnitOfWorkCommandHandlerDecorator(IRequestHandler<TCommand> decorated)
    {
        _decorated = decorated;
    }

    public async Task Handle(TCommand command, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("UnitOfWorkCommandHandlerDecorator: Started");

        await _decorated.Handle(command, cancellationToken);

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("UnitOfWorkCommandHandlerDecorator: Transaction has been committed.");
    }
}

internal sealed class UnitOfWorkCommandHandlerDecorator<TCommand, TResult> : ICommandHandler<TCommand, TResult>
    where TCommand : ICommand<TResult>
{
    private readonly IRequestHandler<TCommand, TResult> _decorated;

    public UnitOfWorkCommandHandlerDecorator(IRequestHandler<TCommand, TResult> decorated)
    {
        _decorated = decorated;
    }

    public async Task<TResult> Handle(TCommand command, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("UnitOfWorkCommandHandlerDecorator: Started");

        var result = await _decorated.Handle(command, cancellationToken);

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("UnitOfWorkCommandHandlerDecorator: Transaction has been committed.");

        return result;
    }
}