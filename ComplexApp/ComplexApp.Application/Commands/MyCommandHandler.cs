using BuildingBlocks.Application.Commands;
using MediatR;

namespace ComplexApp.Application.Commands;

internal sealed class MyCommandHandler : ICommandHandler<MyCommand>
{
    public Task<Unit> Handle(MyCommand request, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("MyCommandHandler");
        return Task.FromResult(Unit.Value);
    }
}