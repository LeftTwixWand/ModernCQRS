using ModernCQRS.Configuration.Commands;

namespace ModernCQRS.Commands.ProcessPayment;

internal sealed class ProcessPaymentCommandHandler : ICommandHandler<ProcessPaymentCommand, bool>
{
    public Task<bool> Handle(ProcessPaymentCommand command, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine($"ProcessPaymentCommandHandler: Payment with id: {command.PaymentId} has been processed.");

        return Task.FromResult(true);
    }
}