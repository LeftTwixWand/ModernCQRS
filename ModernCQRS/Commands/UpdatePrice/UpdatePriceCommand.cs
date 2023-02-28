using ModernCQRS.Configuration.Commands;

namespace ModernCQRS.Commands.UpdatePrice;

internal sealed record UpdatePriceCommand(decimal NewPrice) : CommandBase;