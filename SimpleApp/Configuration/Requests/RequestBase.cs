using MediatR;

namespace SimpleApp.Configuration.Requests;

/// <summary>
/// Abstract record, that encapsulate functionality of <see cref="IRequest"/> and adding request identity.
/// </summary>
public record RequestBase : RequestBase<Unit>
{
    protected RequestBase() : base()
    {
    }

    protected RequestBase(Guid id) : base(id)
    {
    }
}

/// <summary>
/// Abstract record, that encapsulate functionality of <see cref="IRequest{TResult}"/> and adding request identity.
/// <para/><typeparamref name="TResult"/> is the type of an object, that will be returned as the result of the command execution
/// </summary>
/// <typeparam name="TResult">Type of the object, that will be returned as the command execution result.</typeparam>
public record RequestBase<TResult> : IIdentifiableRequest<TResult>
{
    /// <inheritdoc cref="RequestBase()"/>
    protected RequestBase()
    {
        RequestId = Guid.NewGuid();
    }

    /// <summary>
    /// <inheritdoc cref="RequestBase(Guid)"/>
    /// </summary>
    /// <param name="id"><inheritdoc cref="RequestBase(Guid)" path="/param"/></param>
    protected RequestBase(Guid id)
    {
        RequestId = id;
    }

    /// <inheritdoc/>
    public Guid RequestId { get; private set; }
}