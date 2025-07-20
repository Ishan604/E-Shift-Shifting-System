using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Shipping_System.Models;

namespace Shipping_System.Validators
{
    public class AdminModelValidator : AbstractValidator<AdminModel>
    {
        public AdminModelValidator()
        {
            RuleFor(admin => admin.Firstname)
                .NotEmpty().WithMessage("First name is required.")
                .Length(2, 50).WithMessage("First name must be between 2 and 50 characters.");
            RuleFor(admin => admin.Lastname)
                .NotEmpty().WithMessage("Last name is required.")
                .Length(2, 50).WithMessage("Last name must be between 2 and 50 characters.");
            RuleFor(admin => admin.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");
            RuleFor(admin => admin.Phonenumber)
                .NotEmpty().WithMessage("Phone number is required.")
                .Matches(@"^\d{10}$").WithMessage("Phone number must be exactly 10 digits.");
            RuleFor(admin => admin.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(15).WithMessage("Password must be at least 15 characters long.");
        }
    }
}
