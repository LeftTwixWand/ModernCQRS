using System;

namespace Application.Commands
{
    public record CommandBase : ICommand
    {
        public Guid Id { get; private set; }

        public CommandBase()
        {
            Id = Guid.NewGuid();
        }

        protected CommandBase(Guid id)
        {
            Id = id;
        }
    }

    /// <summary>
    /// An abstract class, that incapsulate functional of <see cref="ICommand{TResult}"/>
    /// <para/><typeparamref name="TResult"/> is the type of an object, that will be returned as the result of the command execution
    /// </summary>
    /// <typeparam name="TResult"> The type of object, that will be returned as the resilt of command execution</typeparam>
    public abstract record CommandBase<TResult> : ICommand<TResult>
    {
        public Guid Id { get; private set; }

        protected CommandBase()
        {
            Id = Guid.NewGuid();
        }

        protected CommandBase(Guid id)
        {
            this.Id = id;
        }
    }
}