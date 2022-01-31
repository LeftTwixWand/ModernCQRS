using MediatR;
using SimpleApp.Configuration.Queries;

namespace SimpleApp.Decorators;

internal sealed class DiagnosticQueryHandlerDecorator<TQuery, TResult> : IQueryHandler<TQuery, TResult>
    where TQuery : IQuery<TResult>
{
    private readonly IRequestHandler<TQuery, TResult> _decorated;

    public DiagnosticQueryHandlerDecorator(IRequestHandler<TQuery, TResult> decorated)
    {
        _decorated = decorated;
    }

    public async Task<TResult> Handle(TQuery query, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("DiagnosticQueryHandlerDecorator start");

        var result = await _decorated.Handle(query, cancellationToken);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("DiagnosticQueryHandlerDecorator end");
        return result;
    }
}