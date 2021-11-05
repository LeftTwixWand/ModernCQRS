using MediatR;

namespace Application.Queries
{
    internal interface IQueryHandler<in TQuery, TResult> :
       IRequestHandler<TQuery, TResult>
       where TQuery : IQuery<TResult>
    {
    }
}