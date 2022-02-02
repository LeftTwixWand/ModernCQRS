using Autofac;
using BuildingBlocks.Application.Commands;
using ComplexApp.Infrastructure.Decorators;
using ComplexApp.Infrastructure.Pipelines;
using MediatR;
using MediatR.Pipeline;

namespace ComplexApp.Infrastructure.Modules;

public class ProcessingModule : Module
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