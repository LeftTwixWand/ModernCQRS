using MediatR;

namespace SimpleApp.Configuration.Queries;

internal interface IQueryHandler<in TQuery, TResult> : IRequestHandler<TQuery, TResult>
   where TQuery : IQuery<TResult>
{
}