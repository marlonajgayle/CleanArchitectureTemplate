using FluentValidation;

namespace CleanArchitectureTemplate.Application.Clients.Queries.GetClientDetails
{
    public class GetClientByIdQueryValidator : AbstractValidator<GetClientByIdQuery>
    {
        public GetClientByIdQueryValidator()
        {
            RuleFor(v => v.ClientId)
                .NotEmpty().WithMessage("Client Id required.");
        }
    }
}
