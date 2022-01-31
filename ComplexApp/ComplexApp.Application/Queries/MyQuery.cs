using BuildingBlocks.Application.Queries;

namespace ComplexApp.Application.Queries;

public record MyQuery(string Text) : IQuery<string>;