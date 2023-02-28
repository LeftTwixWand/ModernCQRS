using ModernCQRS.Configuration.Queries;

namespace ModernCQRS.Queries;

internal sealed class GetProductsCountQueryHandler : IQueryHandler<GetProductsCountQuery, int>
{
    public Task<int> Handle(GetProductsCountQuery request, CancellationToken cancellationToken)
    {
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("GetProductsCountQueryHandler: Make a database call.");

        return Task.FromResult(20);
    }
}