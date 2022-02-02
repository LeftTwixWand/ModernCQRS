using BuildingBlocks.Application.Queries;

namespace ComplexApp.Application.Queries;

public record MyQuery(string Text) : QueryBase<string>;