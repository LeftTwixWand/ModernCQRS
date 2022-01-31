// See https://aka.ms/new-console-template for more information
using Autofac;
using MediatR;
using SimpleApp.CQRSRequests;
using SimpleApp.Modules;

var container = ConfigureDIContainer();
using var scope = container.BeginLifetimeScope();

var mediatr = scope.Resolve<IMediator>();

await mediatr.Send(new MyCommand("Command1"));

Console.WriteLine();

await mediatr.Send(new MyQuery("Query1"));

Console.ForegroundColor = ConsoleColor.White;

static IContainer ConfigureDIContainer()
{
    var builder = new ContainerBuilder();

    builder.RegisterModule<MediatorModule>();
    builder.RegisterModule<ProcessingModule>();

    return builder.Build();
}