using SimpleApp.Configuration.Queries;

namespace SimpleApp.CQRSRequests;

internal record MyQuery(string Text) : IQuery<string>;