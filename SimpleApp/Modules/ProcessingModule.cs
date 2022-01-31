using Autofac;
using MediatR;
using MediatR.Pipeline;
using SimpleApp.Decorators;
using SimpleApp.Pipelines;

namespace SimpleApp.Modules;

internal sealed class ProcessingModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterGeneric(typeof(ValidationRequestPreProcessor<>)).As(typeof(IRequestPreProcessor<>));
        builder.RegisterGeneric(typeof(MyCustomRequestPostProcessor<,>)).As(typeof(IRequestPostProcessor<,>));

        builder.RegisterGenericDecorator(typeof(UnitOfWorkCommandHandlerDecorator<,>), typeof(IRequestHandler<,>));
        builder.RegisterGenericDecorator(typeof(DiagnosticQueryHandlerDecorator<,>), typeof(IRequestHandler<,>));
        builder.RegisterGenericDecorator(typeof(LoggingRequestHandlerDecorator<,>), typeof(IRequestHandler<,>));
    }
}