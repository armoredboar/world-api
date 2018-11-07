using FluentValidation;

namespace Kosmos.Application.world.commands
{
    public sealed class CreateWorldCommandValidator : AbstractValidator<CreateWorldCommand>
    {
        public CreateWorldCommandValidator()
        {
            this.RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Name cannot be empty.");
            
            this.RuleFor(x => x.GameServer)
                .NotNull()
                .NotEmpty().
                WithMessage("Game Server cannot me empty.");
        }
    }
}