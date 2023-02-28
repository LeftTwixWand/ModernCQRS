using ModernCQRS.Configuration.Commands;

namespace ModernCQRS.Commands.ProcessPayment;

internal sealed record ProcessPaymentCommand(Guid PaymentId, string Description) : CommandBase<bool>;