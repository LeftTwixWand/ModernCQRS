using Application.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Decorators
{
    internal class UnitOfWorkCommandHandlerDecorator<TCommand, TResult> :
        ICommandHandler<TCommand, TResult>
        where TCommand : ICommand<TResult>
    {
        private readonly ICommandHandler<TCommand, TResult> _decorated;

        public UnitOfWorkCommandHandlerDecorator(ICommandHandler<TCommand, TResult> decorated)
        {
            _decorated = decorated;
        }

        public async Task<TResult> Handle(TCommand command, CancellationToken cancellationToken)
        {
            Console.WriteLine("UnitOfWorkCommandHandlerDecorator start");
            var result = await _decorated.Handle(command, cancellationToken);
            Console.WriteLine("UnitOfWorkCommandHandlerDecorator end");
            return result;
        }
    }
}