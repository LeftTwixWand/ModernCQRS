using BuildingBlocks.Application.Commands;

namespace ComplexApp.Application.Commands;

public record MyResultCommand(string Text) : CommandBase<string>;