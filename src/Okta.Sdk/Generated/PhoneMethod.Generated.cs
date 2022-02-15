// <copyright file="PhoneMethod.Generated.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

// This file was automatically generated. Don't modify it directly.

namespace Okta.Sdk
{
    /// <summary>
    /// An enumeration of PhoneMethod values in the Okta API.
    /// </summary>
    public sealed class PhoneMethod : StringEnum
    {
        /// <summary>The SMS PhoneMethod.</summary>
        public static PhoneMethod Sms = new PhoneMethod("SMS");

        /// <summary>The CALL PhoneMethod.</summary>
        public static PhoneMethod Call = new PhoneMethod("CALL");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="PhoneMethod"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator PhoneMethod(string value) => new PhoneMethod(value);

        /// <summary>
        /// Creates a new <see cref="PhoneMethod"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public PhoneMethod(string value)
            : base(value)
        {
        }

    }
}
