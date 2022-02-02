using Autofac;
using MediatR;
using SimpleApp.Commands;
using SimpleApp.Modules;
using SimpleApp.Queries;

var container = ConfigureDIContainer();
using var scope = container.BeginLifetimeScope();

var mediatr = scope.Resolve<IMediator>();

var commandResult = await mediatr.Send(new MyResultCommand("MyResultCommand"));

Console.WriteLine();

await mediatr.Send(new MyCommand("MyCommand"));

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