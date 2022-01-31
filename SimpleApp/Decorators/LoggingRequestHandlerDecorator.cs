using MediatR;

namespace SimpleApp.Decorators;

internal sealed class LoggingRequestHandlerDecorator<TRequest, TResult> : IRequestHandler<TRequest, TResult>
        where TRequest : IRequest<TResult>
{
    private readonly IRequestHandler<TRequest, TResult> _decorated;

    public LoggingRequestHandlerDecorator(IRequestHandler<TRequest, TResult> decorated)
    {
        _decorated = decorated;
    }

    public async Task<TResult> Handle(TRequest request, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("LoggingRequestHandlerDecorator start");

        var result = await _decorated.Handle(request, cancellationToken);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("LoggingRequestHandlerDecorator end");
        return result;
    }
}