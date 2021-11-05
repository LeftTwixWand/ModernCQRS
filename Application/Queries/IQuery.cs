using MediatR;

namespace Application.Queries
{
    internal interface IQuery<out TResult> : IRequest<TResult>
    {
    }
}