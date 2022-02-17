// <copyright file="MyAccountTokenProvider.cs" company="Okta, Inc">
// Copyright (c) 2020 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Okta.Sdk.Internal;

namespace Okta.Sdk
{
    public class MyAccountTokenProvider : IOAuthTokenProvider
    {
        private string _accessToken;

        public MyAccountTokenProvider(string accessToken)
        {
            _accessToken = accessToken;
        }

        public Task<string> GetAccessTokenAsync(bool forceRenew = false) => Task.FromResult<string>(_accessToken);
    }
}
