using MediatR;

namespace SimpleApp.Configuration.Requests;

/// <summary>
/// Adds unique identifier for request.
/// </summary>
public interface IIdentifiableRequest : IRequest
{
    /// <summary>
    /// Unique identifier of request.
    /// </summary>
    Guid RequestId { get; }
}

/// <summary>
/// Adds unique identifier for request.
/// </summary>
public interface IIdentifiableRequest<TResult> : IRequest<TResult>
{
    /// <summary>
    /// Unique identifier of request.
    /// </summary>
    Guid RequestId { get; }
}