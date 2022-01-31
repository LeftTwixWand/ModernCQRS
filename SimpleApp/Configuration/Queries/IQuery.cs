using MediatR;

namespace SimpleApp.Configuration.Queries;

internal interface IQuery<out TResult> : IRequest<TResult>
{
}