﻿using FluentValidation;
using UsersData.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsersData.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object.");
                });

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Is necessary to inform the CPF.")
                .NotNull().WithMessage("Is necessary to inform the CPF.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Is necessary to inform the birth date.")
                .NotNull().WithMessage("Is necessary to inform the birth date.");

            RuleFor(c => c.Tipo)
                .NotEmpty().WithMessage("Is necessary to inform the name.")
                .NotNull().WithMessage("Is necessary to inform the name.");
        }
    }
}
