using BuildingBlocks.Application.Requests;
using MediatR;

namespace ComplexApp.Infrastructure.Decorators;

internal sealed class LoggingRequestHandlerDecorator<TRequest, TResult> : IRequestHandler<TRequest, TResult>
        where TRequest : IIdentifiableRequest<TResult>
{
    private readonly IRequestHandler<TRequest, TResult> _decorated;

    public LoggingRequestHandlerDecorator(IRequestHandler<TRequest, TResult> decorated)
    {
        _decorated = decorated;
    }

    public async Task<TResult> Handle(TRequest request, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"LoggingRequestHandlerDecorator start. Request id: {request.RequestId}");

        var result = await _decorated.Handle(request, cancellationToken);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"LoggingRequestHandlerDecorator end. Request id: {request.RequestId}");
        return result;
    }
}