// <copyright file="MyAccountsClient.Generated.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

// This file was automatically generated. Don't modify it directly.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Okta.Sdk.Configuration;
using Okta.Sdk.Internal;

namespace Okta.Sdk
{
    /// <inheritdoc/>
    public sealed partial class MyAccountsClient : OktaClient, IMyAccountsClient
    {
        // Remove parameterless constructor
        private MyAccountsClient()
        {
        }

        internal MyAccountsClient(IDataStore dataStore, OktaClientConfiguration configuration, RequestContext requestContext)
            : base(dataStore, configuration, requestContext)
        {
        }
        
        /// <inheritdoc />
        public ICollectionClient<IEmail> ListEmails()
            => GetCollectionClient<IEmail>(new HttpRequest
            {
                Uri = "/idp/myaccount/emails",
                Verb = HttpVerb.Get,
                
            });
                    
        /// <inheritdoc />
        public async Task<IEmail> AddNewEmailAsync(IAddEmailRequest emailRequest, CancellationToken cancellationToken = default(CancellationToken))
            => await PostAsync<Email>(new HttpRequest
            {
                Uri = "/idp/myaccount/emails",
                Verb = HttpVerb.Post,
                Payload = emailRequest,
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task DeleteEmailAsync(string emailId, CancellationToken cancellationToken = default(CancellationToken))
            => await DeleteAsync(new HttpRequest
            {
                Uri = "/idp/myaccount/emails/{emailId}",
                Verb = HttpVerb.Delete,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["emailId"] = emailId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task<IEmail> ListEmailAsync(string emailId, CancellationToken cancellationToken = default(CancellationToken))
            => await GetAsync<Email>(new HttpRequest
            {
                Uri = "/idp/myaccount/emails/{emailId}",
                Verb = HttpVerb.Get,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["emailId"] = emailId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task<IEmail> SendEmailChallengeAsync(IEmailChallengeRequest emailChallengeRequest, string emailId, CancellationToken cancellationToken = default(CancellationToken))
            => await PostAsync<Email>(new HttpRequest
            {
                Uri = "/idp/myaccount/emails/{emailId}/challenge",
                Verb = HttpVerb.Post,
                Payload = emailChallengeRequest,
                PathParameters = new Dictionary<string, object>()
                {
                    ["emailId"] = emailId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task<IEmailChallenge> PollForEmailMagicLinkAsync(string emailId, string challengeId, CancellationToken cancellationToken = default(CancellationToken))
            => await GetAsync<EmailChallenge>(new HttpRequest
            {
                Uri = "/idp/myaccount/emails/{emailId}/challenge/{challengeId}",
                Verb = HttpVerb.Get,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["emailId"] = emailId,
                    ["challengeId"] = challengeId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task VerifyEmailOtpAsync(IVerifyEmailOTP verificationRequest, string emailId, string challengeId, CancellationToken cancellationToken = default(CancellationToken))
            => await PostAsync(new HttpRequest
            {
                Uri = "/idp/myaccount/emails/{emailId}/challenge/{challengeId}/verify",
                Verb = HttpVerb.Post,
                Payload = verificationRequest,
                PathParameters = new Dictionary<string, object>()
                {
                    ["emailId"] = emailId,
                    ["challengeId"] = challengeId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public ICollectionClient<IPhone> ListPhones()
            => GetCollectionClient<IPhone>(new HttpRequest
            {
                Uri = "/idp/myaccount/phones",
                Verb = HttpVerb.Get,
                
            });
                    
        /// <inheritdoc />
        public async Task<IPhone> AddPhoneAsync(IAddPhoneRequest addPhoneRequest, CancellationToken cancellationToken = default(CancellationToken))
            => await PostAsync<Phone>(new HttpRequest
            {
                Uri = "/idp/myaccount/phones",
                Verb = HttpVerb.Post,
                Payload = addPhoneRequest,
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task DeletePhoneAsync(string phoneId, CancellationToken cancellationToken = default(CancellationToken))
            => await DeleteAsync(new HttpRequest
            {
                Uri = "/idp/myaccount/phones/{phoneId}",
                Verb = HttpVerb.Delete,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["phoneId"] = phoneId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task<IPhone> GetPhoneAsync(string phoneId, CancellationToken cancellationToken = default(CancellationToken))
            => await GetAsync<Phone>(new HttpRequest
            {
                Uri = "/idp/myaccount/phones/{phoneId}",
                Verb = HttpVerb.Get,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["phoneId"] = phoneId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task SendPhoneChallengeAsync(IPhoneChallengeRequest phoneChallengeRequest, string phoneId, CancellationToken cancellationToken = default(CancellationToken))
            => await PostAsync(new HttpRequest
            {
                Uri = "/idp/myaccount/phones/{phoneId}/challenge",
                Verb = HttpVerb.Post,
                Payload = phoneChallengeRequest,
                PathParameters = new Dictionary<string, object>()
                {
                    ["phoneId"] = phoneId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task VerifyPhoneChallengeAsync(IVerifyPhoneChallengeRequest verifyPhoneChallengeRequest, string phoneId, CancellationToken cancellationToken = default(CancellationToken))
            => await PostAsync(new HttpRequest
            {
                Uri = "/idp/myaccount/phones/{phoneId}/verify",
                Verb = HttpVerb.Post,
                Payload = verifyPhoneChallengeRequest,
                PathParameters = new Dictionary<string, object>()
                {
                    ["phoneId"] = phoneId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task<IMyProfile> GetMyProfileAsync(CancellationToken cancellationToken = default(CancellationToken))
            => await GetAsync<MyProfile>(new HttpRequest
            {
                Uri = "/idp/myaccount/profile",
                Verb = HttpVerb.Get,
                
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task<IMyProfile> UpdateMyProfileAsync(IUpdateMyProfileRequest updateRequest, CancellationToken cancellationToken = default(CancellationToken))
            => await PutAsync<MyProfile>(new HttpRequest
            {
                Uri = "/idp/myaccount/profile",
                Verb = HttpVerb.Put,
                Payload = updateRequest,
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task<IMyProfileSchema> GetMyProfileSchemaAsync(CancellationToken cancellationToken = default(CancellationToken))
            => await GetAsync<MyProfileSchema>(new HttpRequest
            {
                Uri = "/idp/myaccount/profile/schema",
                Verb = HttpVerb.Get,
                
                }, cancellationToken).ConfigureAwait(false);
        
    }
}
