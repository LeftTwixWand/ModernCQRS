using Application.Queries;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Decorators
{
    internal class DiagnosticQueryHandlerDecorator<TQuery, TResult> :
        IQueryHandler<TQuery, TResult>
        where TQuery : IQuery<TResult>
    {
        private readonly IRequestHandler<TQuery, TResult> _decorated;

        public DiagnosticQueryHandlerDecorator(IRequestHandler<TQuery, TResult> decorated)
        {
            this._decorated = decorated;
        }

        public async Task<TResult> Handle(TQuery query, CancellationToken cancellationToken)
        {
            Console.WriteLine("DiagnosticQueryHandlerDecorator start");
            var result = await _decorated.Handle(query, cancellationToken);
            Console.WriteLine("DiagnosticQueryHandlerDecorator end");
            return result;
        }
    }
}