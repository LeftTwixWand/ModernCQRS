using SimpleApp.Configuration.Commands;

namespace SimpleApp.Commands.ProcessPayment;

public sealed record ProcessPaymentCommand(Guid PaymentId, string Description) : CommandBase<bool>;