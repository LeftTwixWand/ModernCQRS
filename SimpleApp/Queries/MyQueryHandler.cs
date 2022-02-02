using SimpleApp.Configuration.Queries;

namespace SimpleApp.Queries;

public class MyQueryHandler : IQueryHandler<MyQuery, string>
{
    public Task<string> Handle(MyQuery request, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"QueryHandler");
        return Task.FromResult(request.Text);
    }
}