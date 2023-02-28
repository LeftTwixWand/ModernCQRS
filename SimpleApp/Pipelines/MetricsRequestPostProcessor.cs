using MediatR.Pipeline;
using System;

namespace SimpleApp.Pipelines;

internal sealed class MetricsRequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    where TRequest : notnull
{
    public Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("MetricsRequestPostProcessor: All the operation metrics has been uploaded.");

        return Task.CompletedTask;
    }
}