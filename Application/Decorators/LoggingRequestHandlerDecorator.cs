using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Decorators
{
    internal class LoggingRequestHandlerDecorator<TRequest, TResult> :
        IRequestHandler<TRequest, TResult>
        where TRequest : IRequest<TResult>
    {
        private readonly IRequestHandler<TRequest, TResult> _decorated;

        public LoggingRequestHandlerDecorator(IRequestHandler<TRequest, TResult> decorated)
        {
            this._decorated = decorated;
        }

        public async Task<TResult> Handle(TRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine("LoggingRequestHandlerDecorator start");
            var result = await _decorated.Handle(request, cancellationToken);
            Console.WriteLine("LoggingRequestHandlerDecorator end");
            return result;
        }
    }
}