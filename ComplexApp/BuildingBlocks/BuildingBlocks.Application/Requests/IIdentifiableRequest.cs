using MediatR;

namespace BuildingBlocks.Application.Requests;

/// <summary>
/// Add unique identifyier for request.
/// </summary>
public interface IIdentifiableRequest<out TRequest> : IRequest<TRequest>
{
    /// <summary>
    /// Unique identifyier of request.
    /// </summary>
    Guid RequestId { get; }
}

/// <summary>
/// Add unique identifyier for request.
/// </summary>
public interface IIdentifiableRequest : IIdentifiableRequest<Unit>
{
}