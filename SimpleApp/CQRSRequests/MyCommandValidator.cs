using FluentValidation;

namespace SimpleApp.CQRSRequests;

internal class MyCommandValidator : AbstractValidator<MyCommand>
{
    public MyCommandValidator()
    {
        RuleFor(command => command.Text)
            .NotNull()
            .NotEmpty();
    }
}