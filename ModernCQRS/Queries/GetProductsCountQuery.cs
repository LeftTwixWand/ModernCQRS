using ModernCQRS.Configuration.Queries;

namespace ModernCQRS.Queries;

internal sealed record GetProductsCountQuery(string ProductName) : QueryBase<int>;