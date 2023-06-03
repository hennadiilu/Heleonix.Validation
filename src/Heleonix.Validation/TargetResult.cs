﻿// <copyright file="TargetResult.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) Heleonix - Hennadii Lutsyshyn. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the repository root for full license information.
// </copyright>

namespace Heleonix.Validation
{
    /// <summary>
    /// Represents the target result.
    /// </summary>
    [Serializable]
    public class TargetResult : Result
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetResult"/> class.
        /// </summary>
        /// <param name="name">A name of a target.</param>
        /// <param name="value">A value of a target.</param>
        public TargetResult(string name, object value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Gets or sets a name of a target.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value of a target.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Gets rule results.
        /// </summary>
        public ICollection<RuleResult> RuleResults { get; } = new List<RuleResult>();

        /// <summary>
        /// Indicates whether the result is empty.
        /// </summary>
        /// <returns><see langword="true"/> if the result is empty, otherwise <see langword="false"/>.</returns>
        public override bool IsEmpty() => this.RuleResults.Count == 0;
    }
}