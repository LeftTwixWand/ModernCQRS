using FluentValidation;

namespace ModernCQRS.Commands.UpdatePrice;

internal sealed class UpdatePriceCommandValidator : AbstractValidator<UpdatePriceCommand>
{
    public UpdatePriceCommandValidator()
    {
        RuleFor(command => command.NewPrice)
            .GreaterThan(decimal.Zero);
    }
}