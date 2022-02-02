using BuildingBlocks.Application.Commands;
using MediatR;

namespace ComplexApp.Infrastructure.Decorators;

internal sealed class UnitOfWorkCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>
    where TCommand : CommandBase
{
    private readonly IRequestHandler<TCommand> _decorated;

    public UnitOfWorkCommandHandlerDecorator(IRequestHandler<TCommand> decorated)
    {
        _decorated = decorated;
    }

    public async Task<Unit> Handle(TCommand command, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("UnitOfWorkCommandHandlerDecorator start");

        await _decorated.Handle(command, cancellationToken);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("UnitOfWorkCommandHandlerDecorator end");
        return Unit.Value;
    }
}