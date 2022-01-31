using MediatR;

namespace SimpleApp.Configuration.Commands;

internal interface ICommand : IRequest
{
    Guid Id { get; }
}

internal interface ICommand<out TResult> : IRequest<TResult>
{
    Guid Id { get; }
}