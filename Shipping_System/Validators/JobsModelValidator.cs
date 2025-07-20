using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Shipping_System.Models;

namespace Shipping_System.Validators
{
    public class JobsModelValidator : AbstractValidator<JobsModel>
    {
        public JobsModelValidator()
        {
            RuleFor(job => job.fullName)
                .NotEmpty().WithMessage("Full name is required.")
                .Length(2, 100).WithMessage("Full name must be between 2 and 100 characters.");
            RuleFor(job => job.startLocation)
                .NotEmpty().WithMessage("Start location is required.")
                .Length(2, 200).WithMessage("Start location must be between 2 and 200 characters.");
            RuleFor(job => job.destination)
                .NotEmpty().WithMessage("Destination is required.")
                .Length(2, 200).WithMessage("Destination must be between 2 and 200 characters.");
            RuleFor(job => job.email)
                .EmailAddress().WithMessage("Invalid email format.");
            RuleFor(job => job.phoneNumber)
                .Matches(@"^\d{10}$").WithMessage("Phone number must be exactly 10 digits.");
            RuleFor(job => job.itemDescription)
                .NotEmpty().WithMessage("Item description is required.")
                .Length(5, 500).WithMessage("Item description must be between 5 and 500 characters.");
        }
    }
}
