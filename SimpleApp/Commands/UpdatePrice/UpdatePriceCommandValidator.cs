using FluentValidation;

namespace SimpleApp.Commands.UpdatePrice;

internal sealed class UpdatePriceCommandValidator : AbstractValidator<UpdatePriceCommand>
{
    public UpdatePriceCommandValidator()
    {
        RuleFor(command => command.NewPrice)
            .GreaterThan(decimal.Zero);
    }
}