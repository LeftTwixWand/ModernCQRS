using ModernCQRS.Configuration.Commands;

namespace ModernCQRS.Commands.UpdatePrice;

internal sealed class UpdatePriceCommandHandler : ICommandHandler<UpdatePriceCommand>
{
    public Task Handle(UpdatePriceCommand request, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("UpdatePriceCommandHandler: Price has been updated.");

        return Task.CompletedTask;
    }
}