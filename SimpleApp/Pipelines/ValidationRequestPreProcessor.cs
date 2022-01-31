using FluentValidation;
using MediatR.Pipeline;
using System.Text;

namespace SimpleApp.Pipelines;

internal sealed class ValidationRequestPreProcessor<TRequest> : IRequestPreProcessor<TRequest>
    where TRequest : notnull
{
    private readonly IList<IValidator<TRequest>> _validators;

    public ValidationRequestPreProcessor(IList<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public Task Process(TRequest request, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("ValidationRequestPreProcessor");

        var errors = _validators
            .Select(validator => validator.Validate(request))
            .SelectMany(validationResult => validationResult.Errors)
            .Where(error => error != null)
            .ToList();

        if (errors.Any())
        {
            var errorBuilder = new StringBuilder();

            errorBuilder.AppendLine("Invalid command, reason: ");

            errors.ForEach(error => errorBuilder.AppendLine(error.ErrorMessage));

            throw new Exception(errorBuilder.ToString());
        }

        return Task.CompletedTask;
    }
}