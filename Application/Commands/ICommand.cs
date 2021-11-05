using System;
using MediatR;

namespace Application.Commands
{
    internal interface ICommand : IRequest
    {
        Guid Id { get; }
    }

    internal interface ICommand<out TResult> : IRequest<TResult>
    {
        Guid Id { get; }
    }
}