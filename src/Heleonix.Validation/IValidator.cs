﻿// <copyright file="IValidator.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) Heleonix - Hennadii Lutsyshyn. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the repository root for full license information.
// </copyright>

namespace Heleonix.Validation
{
    /// <summary>
    /// Represents the <see langword="interface"/> of an invariant validator.
    /// </summary>
    public interface IValidator
    {
        /// <summary>
        /// Executes validation.
        /// </summary>
        /// <param name="context">A context of a validator.</param>
        /// <returns>A validator result.</returns>
        RulesetResult Validate(object obj, ValidationOptions options = null, ValidatorContext context = null);
    }
}