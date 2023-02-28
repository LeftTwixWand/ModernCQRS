using MediatR;

namespace ModernCQRS.Configuration.Requests;

/// <summary>
/// Adds unique identifier for request.
/// </summary>
internal interface IIdentifiableRequest : IRequest
{
    /// <summary>
    /// Unique identifier of request.
    /// </summary>
    Guid RequestId { get; }
}

/// <summary>
/// Adds unique identifier for request.
/// </summary>
internal interface IIdentifiableRequest<TResult> : IRequest<TResult>
{
    /// <summary>
    /// Unique identifier of request.
    /// </summary>
    Guid RequestId { get; }
}