using ModernCQRS.Configuration.Requests;

namespace ModernCQRS.Configuration.Commands;

/// <summary>
/// Abstract record, that encapsulate functionality of <see cref="ICommand"/> and adding request identity.
/// </summary>
internal abstract record CommandBase : RequestBase, ICommand;

/// <summary>
/// Abstract record, that encapsulate functionality of <see cref="ICommand{TResult}"/> and adding request identity.
/// </summary>
/// <typeparam name="TResult"><inheritdoc cref="RequestBase{TResult}" path="/typeparam"/></typeparam>
internal abstract record CommandBase<TResult> : RequestBase<TResult>, ICommand<TResult>;