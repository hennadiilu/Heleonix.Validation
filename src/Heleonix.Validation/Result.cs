// <copyright file="Result.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) Heleonix - Hennadii Lutsyshyn. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the repository root for full license information.
// </copyright>

namespace Heleonix.Validation
{
    /// <summary>
    /// Represents the validation result of a field, which is selected from the defined possible outcomes results depending on the ou class for all results.
    /// </summary>
    [Serializable]
    public class Result
    {
        /// <summary>
        /// Gets or sets an outcome of an executed <see cref="Rule"/>.
        /// </summary>
        public object Outcome { get; set; }

        /// <summary>
        /// Gets or sets a resource name.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets a resource key.
        /// </summary>
        public string Key { get; set; }
    }
}