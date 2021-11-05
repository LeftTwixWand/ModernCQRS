using Autofac;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using MediatR.Pipeline;
using System.Reflection;

namespace Application.Modules
{
    internal class MediatRModule : Autofac.Module
    {
        private readonly Assembly[] assemblies;

        internal MediatRModule(params Assembly[] assemblies)
        {
            this.assemblies = assemblies;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterMediatR(assemblies);

            var openHandlerTypes = new[]
            {
                typeof(IRequestHandler<,>),
                typeof(IRequestExceptionHandler<,,>),
                typeof(IRequestExceptionAction<,>),
                typeof(INotificationHandler<>),
            };

            foreach (var openHandlerType in openHandlerTypes)
            {
                builder.RegisterAssemblyTypes(this.assemblies)
                 .AsClosedTypesOf(openHandlerType)
                 .AsImplementedInterfaces();
            }

            builder.RegisterGeneric(typeof(RequestPostProcessorBehavior<,>)).As(typeof(IPipelineBehavior<,>));
            builder.RegisterGeneric(typeof(RequestPreProcessorBehavior<,>)).As(typeof(IPipelineBehavior<,>));
            builder.RegisterGeneric(typeof(RequestExceptionActionProcessorBehavior<,>)).As(typeof(IPipelineBehavior<,>));
            builder.RegisterGeneric(typeof(RequestExceptionProcessorBehavior<,>)).As(typeof(IPipelineBehavior<,>));

            builder.Register<ServiceFactory>(outerContext =>
            {
                var innerContext = outerContext.Resolve<IComponentContext>();

                return serviceType => innerContext.Resolve(serviceType);
            })
                .InstancePerLifetimeScope();
        }
    }
}