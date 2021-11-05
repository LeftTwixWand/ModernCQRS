using MediatR;

namespace Application.Commands
{
    internal interface ICommandHandler<in TCommand> :
        IRequestHandler<TCommand>
        where TCommand : ICommand
    {
    }

    internal interface ICommandHandler<in TCommand, TResult> :
        IRequestHandler<TCommand, TResult>
        where TCommand : ICommand<TResult>
    {
    }
}