using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace BtkCamp.Models.Validators
{
    public class CandidateValidator : AbstractValidator<Candidate>
    {
        public CandidateValidator()
        {
            RuleFor(c => c.Email).NotNull().WithMessage("Email alanı boş bırakılamaz");
            RuleFor(c => c.FirstName).NotNull().WithMessage("FirstName alanı boş bırakılamaz");
            RuleFor(c => c.LastName).NotNull().WithMessage("LastName alanı boş bırakılamaz");
        }
    }
}