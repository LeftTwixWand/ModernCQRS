using SimpleApp.Configuration.Commands;

namespace SimpleApp.CQRSRequests;

internal record MyCommand(string Text) : CommandBase<string>;