using MediatR;

namespace BuildingBlocks.Application.Queries;

public interface IQuery<out TResult> : IRequest<TResult>
{
}