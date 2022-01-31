using BuildingBlocks.Application.Commands;

namespace ComplexApp.Application.Commands;

public record MyCommand(string Text) : CommandBase<string>;