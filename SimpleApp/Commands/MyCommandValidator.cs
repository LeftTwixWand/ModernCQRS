using FluentValidation;

namespace SimpleApp.Commands;

internal sealed class MyCommandValidator : AbstractValidator<MyCommand>
{
    public MyCommandValidator()
    {
        RuleFor(command => command.Text)
            .NotNull()
            .NotEmpty();
    }
}