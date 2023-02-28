using SimpleApp.Configuration.Queries;

namespace SimpleApp.Queries;

public sealed record GetProductsCountQuery(string ProductName) : QueryBase<int>;