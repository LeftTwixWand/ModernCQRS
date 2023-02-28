using ModernCQRS.Configuration.Requests;

namespace ModernCQRS.Configuration.Queries;

/// <summary>
/// Abstract record, that encapsulate functionality of <see cref="IQuery{TResult}"/> and adding request identity.
/// </summary>
/// <typeparam name="TResult"><inheritdoc cref="RequestBase{TResult}" path="/typeparam"/></typeparam>
internal abstract record QueryBase<TResult> : RequestBase<TResult>, IQuery<TResult>;