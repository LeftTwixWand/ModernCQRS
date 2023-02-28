using SimpleApp.Configuration.Commands;

namespace SimpleApp.Commands.UpdatePrice;

public record UpdatePriceCommand(decimal NewPrice) : CommandBase;