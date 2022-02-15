// <copyright file="EmailChallenge.Generated.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

// This file was automatically generated. Don't modify it directly.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Okta.Sdk.Internal;

namespace Okta.Sdk
{
    /// <inheritdoc/>
    public sealed partial class EmailChallenge : Resource, IEmailChallenge
    {
        /// <inheritdoc/>
        public DateTimeOffset? ExpiresAt => GetDateTimeProperty("expiresAt");
        
        /// <inheritdoc/>
        public string Id => GetStringProperty("id");
        
        /// <inheritdoc/>
        public IEmailProfile Profile 
        {
            get => GetResourceProperty<EmailProfile>("profile");
            set => this["profile"] = value;
        }
        
        /// <inheritdoc/>
        public string Status => GetStringProperty("status");
        
    }
}
