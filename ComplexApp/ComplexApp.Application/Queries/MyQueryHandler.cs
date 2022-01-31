using BuildingBlocks.Application.Queries;

namespace ComplexApp.Application.Queries;

public class MyQueryHandler : IQueryHandler<MyQuery, string>
{
    public Task<string> Handle(MyQuery request, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"MyQueryHandler result: {request.Text}");
        return Task.FromResult(request.Text);
    }
}