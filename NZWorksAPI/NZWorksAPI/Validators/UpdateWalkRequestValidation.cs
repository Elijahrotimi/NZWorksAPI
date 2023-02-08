using FluentValidation;

namespace NZWorksAPI.Validators
{
    public class UpdateWalkRequestValidation : AbstractValidator<Models.DTO.UpdateWalkRequest>
    {
        public UpdateWalkRequestValidation()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Length).GreaterThan(0);
        }
    }
}
