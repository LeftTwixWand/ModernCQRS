using Autofac;
using ComplexApp.Application.Queries;
using FluentValidation;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;

namespace ComplexApp.Infrastructure.Modules;

public class MediatorModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        var assemblies = typeof(MyQuery).Assembly;
        builder.RegisterMediatR(assemblies);

        var openHandlerTypes = new[]
        {
                typeof(IRequestHandler<,>),
                typeof(INotificationHandler<>),
                typeof(IValidator<>),
            };

        foreach (var openHandlerType in openHandlerTypes)
        {
            builder.RegisterAssemblyTypes(assemblies)
                .AsClosedTypesOf(openHandlerType)
                .AsImplementedInterfaces();
        }
    }
}