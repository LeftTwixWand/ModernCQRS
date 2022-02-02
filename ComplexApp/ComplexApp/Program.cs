using Autofac;
using ComplexApp.Application.Commands;
using ComplexApp.Application.Queries;
using ComplexApp.Infrastructure.Modules;
using MediatR;

var container = ConfigureDIContainer();
using var scope = container.BeginLifetimeScope();

var mediatr = scope.Resolve<IMediator>();

await mediatr.Send(new MyCommand("MyCommand"));

Console.WriteLine();

var commandResult = await mediatr.Send(new MyResultCommand("MyResultCommand"));

Console.WriteLine();

var queryResult = await mediatr.Send(new MyQuery("MyQuery"));

Console.ForegroundColor = ConsoleColor.White;

static IContainer ConfigureDIContainer()
{
    var builder = new ContainerBuilder();

    builder.RegisterModule<MediatorModule>();
    builder.RegisterModule<ProcessingModule>();

    return builder.Build();
}