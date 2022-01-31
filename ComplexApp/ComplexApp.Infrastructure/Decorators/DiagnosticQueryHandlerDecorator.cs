using BuildingBlocks.Application.Queries;
using MediatR;

namespace ComplexApp.Infrastructure.Decorators;

internal sealed class DiagnosticQueryHandlerDecorator<TRequest, TResult> : IQueryHandler<TRequest, TResult>
    where TRequest : IQuery<TResult>
{
    private readonly IRequestHandler<TRequest, TResult> _decorated;

    public DiagnosticQueryHandlerDecorator(IRequestHandler<TRequest, TResult> decorated)
    {
        _decorated = decorated;
    }

    public async Task<TResult> Handle(TRequest query, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("DiagnosticQueryHandlerDecorator start");

        var result = await _decorated.Handle(query, cancellationToken);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("DiagnosticQueryHandlerDecorator end");
        return result;
    }
}