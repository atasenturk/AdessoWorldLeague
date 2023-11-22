using AdessoWorldLeauge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace AdessoWorldLeague.Infrastructure.Validators
{
    public class DrawRequestValidator : AbstractValidator<DrawRequest>
    {
        public DrawRequestValidator()
        {
            RuleFor(request => request.GroupCount)
                .Must(x => x == 4 || x == 8)
                .WithMessage("Group count must be either 4 or 8.");
            RuleFor(request => request.DrawerFirstName)
                .NotEmpty()
                .WithMessage("Drawer first name must not be empty.");

            RuleFor(request => request.DrawerLastName)
                .NotEmpty()
                .WithMessage("Drawer last name must not be empty.");
        }
    }
}
