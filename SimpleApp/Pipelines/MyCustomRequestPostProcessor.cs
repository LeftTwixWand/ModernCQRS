using MediatR.Pipeline;
using System;

namespace SimpleApp.Pipelines;

internal sealed class MyCustomRequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    where TRequest : notnull
{
    public Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("MyCustomRequestPostProcessor");
        return Task.CompletedTask;
    }
}