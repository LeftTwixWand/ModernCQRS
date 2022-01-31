using FluentValidation;

namespace ComplexApp.Application.Commands;

internal sealed class MyCommandValidator : AbstractValidator<MyCommand>
{
    public MyCommandValidator()
    {
        RuleFor(command => command.Text)
            .NotNull()
            .NotEmpty();
    }
}