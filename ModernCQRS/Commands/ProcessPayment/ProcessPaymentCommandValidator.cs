﻿using FluentValidation;

namespace ModernCQRS.Commands.ProcessPayment;

internal sealed class ProcessPaymentCommandValidator : AbstractValidator<ProcessPaymentCommand>
{
    public ProcessPaymentCommandValidator()
    {
        RuleFor(command => command.PaymentId)
            .NotNull()
            .NotEmpty();

        RuleFor(command => command.Description)
            .NotEmpty();
    }
}