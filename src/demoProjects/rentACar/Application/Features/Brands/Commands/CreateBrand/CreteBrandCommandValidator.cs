using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.CreateBrand
{
    public class CreteBrandCommandValidator:AbstractValidator<CreateBrandCommand>
    {

        public CreteBrandCommandValidator()
        {
            RuleFor(x=>x.Name).NotEmpty();
            RuleFor(x=>x.Name).MinimumLength(2);
        }
    }
}
