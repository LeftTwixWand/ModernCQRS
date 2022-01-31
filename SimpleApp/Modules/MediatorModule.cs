using Autofac;
using FluentValidation;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;

namespace SimpleApp.Modules;

internal sealed class MediatorModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        var assemblies = ThisAssembly;
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