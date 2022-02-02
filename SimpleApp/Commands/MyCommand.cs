using SimpleApp.Configuration.Commands;

namespace SimpleApp.Commands;

public record MyCommand(string Text) : CommandBase;