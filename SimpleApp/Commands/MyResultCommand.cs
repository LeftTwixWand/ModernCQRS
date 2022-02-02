using SimpleApp.Configuration.Commands;

namespace SimpleApp.Commands;

public record MyResultCommand(string Text) : CommandBase<string>;