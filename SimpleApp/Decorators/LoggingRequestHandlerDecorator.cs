using MediatR;
using SimpleApp.Configuration.Requests;

namespace SimpleApp.Decorators;

internal sealed class LoggingRequestHandlerDecorator<TRequest> : IRequestHandler<TRequest>
        where TRequest : IIdentifiableRequest
{
    private readonly IRequestHandler<TRequest> _decorated;

    public LoggingRequestHandlerDecorator(IRequestHandler<TRequest> decorated)
    {
        _decorated = decorated;
    }

    public async Task Handle(TRequest request, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine($"LoggingRequestHandlerDecorator: Request {request.RequestId} started.");

        await _decorated.Handle(request, cancellationToken);

        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine($"LoggingRequestHandlerDecorator: Request {request.RequestId} ended.");
    }
}

internal sealed class LoggingRequestHandlerDecorator<TRequest, TResult> : IRequestHandler<TRequest, TResult>
        where TRequest :  IIdentifiableRequest<TResult>
{
    private readonly IRequestHandler<TRequest, TResult> _decorated;

    public LoggingRequestHandlerDecorator(IRequestHandler<TRequest, TResult> decorated)
    {
        _decorated = decorated;
    }

    public async Task<TResult> Handle(TRequest request, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine($"LoggingRequestHandlerDecorator: Request {request.RequestId} started.");

        var result = await _decorated.Handle(request, cancellationToken);

        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine($"LoggingRequestHandlerDecorator: Request {request.RequestId} ended.");

        return result;
    }
}