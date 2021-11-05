using Application.Commands;
using Application.Decorators;
using Application.Modules;
using Application.Processing;
using Application.Queries;
using Autofac;
using MediatR;
using System.Threading.Tasks;

namespace Application
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var container = ConfigureCQRS();
            using var scope = container.BeginLifetimeScope();

            var mediatr = scope.Resolve<IMediator>();

            await mediatr.Send(new MyCommand("Command1"));
            await mediatr.Send(new MyQuery("Query1"));
        }

        private static IContainer ConfigureCQRS()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new MediatRModule(typeof(Program).Assembly));
            builder.RegisterGenericDecorator(typeof(UnitOfWorkCommandHandlerDecorator<,>), typeof(IRequestHandler<,>));
            builder.RegisterGenericDecorator(typeof(DiagnosticQueryHandlerDecorator<,>), typeof(IRequestHandler<,>));
            builder.RegisterGenericDecorator(typeof(LoggingRequestHandlerDecorator<,>), typeof(IRequestHandler<,>));

            return builder.Build();
        }
    }
}