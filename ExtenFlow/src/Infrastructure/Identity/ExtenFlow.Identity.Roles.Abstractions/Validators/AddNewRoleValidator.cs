﻿using System;

using ExtenFlow.Identity.Roles.Commands;

using FluentValidation;

#pragma warning disable CA1710 // Identifiers should have correct suffix

namespace ExtenFlow.Identity.Roles.Validators
{
    /// <summary>
    /// Add new role command validation
    /// </summary>
    public class AddNewRoleValidator : RoleCommandValidator<AddNewRole>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AddNewRoleValidator(Func<string, bool>? normalizedRoleNameExist = null) : base(true)
        {
            RuleFor(command => command.Name).NotEmpty().WithMessage(Properties.Resources.RoleNameNotDefined);
            RuleFor(command => command.NormalizedName).NotEmpty().WithMessage(Properties.Resources.NormalizedRoleNameNotDefined);
            if (normalizedRoleNameExist != null)
            {
                RuleFor(command => command.NormalizedName).SetValidator(new UniqueNormalizedRoleNameValidator(normalizedRoleNameExist));
            }
        }
    }
}