using SimpleApp.Configuration.Queries;

namespace SimpleApp.Queries;

public record MyQuery(string Text) : IQuery<string>;