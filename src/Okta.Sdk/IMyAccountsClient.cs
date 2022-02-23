// <copyright file="IMyAccountsClient.cs" company="Okta, Inc">
// Copyright (c) 2020 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

namespace Okta.Sdk
{
    public partial interface IMyAccountsClient
    {
        /// <summary>
        /// Clones the current client and returns a new one configured with the access token provided. API calls made via the cloned client will use the provided bearer token in the authorization header.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <returns>A new MyAccountsClient configured with the access token provided.</returns>
        IMyAccountsClient WithAccessToken(string accessToken);
    }
}
