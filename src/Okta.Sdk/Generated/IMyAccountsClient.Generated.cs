// <copyright file="IMyAccountsClient.Generated.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

// This file was automatically generated. Don't modify it directly.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Okta.Sdk
{
    /// <summary>A client that works with Okta MyAccount resources.</summary>
    public partial interface IMyAccountsClient
    {
        /// <summary>
        /// TODO
        /// </summary>
        /// <returns>A collection of <see cref="IEmail"/> that can be enumerated asynchronously.</returns>
        ICollectionClient<IEmail> ListEmails();

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="emailRequest">The <see cref="IAddEmailRequest"/> resource.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="IEmail"/> response.</returns>
        Task<IEmail> AddNewEmailAsync(IAddEmailRequest emailRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        Task DeleteEmailAsync(string emailId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="IEmail"/> response.</returns>
        Task<IEmail> ListEmailAsync(string emailId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="emailChallengeRequest">The <see cref="IEmailChallengeRequest"/> resource.</param>
        /// <param name="emailId"></param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="IEmail"/> response.</returns>
        Task<IEmail> SendEmailChallengeAsync(IEmailChallengeRequest emailChallengeRequest, string emailId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="emailId"></param>
        /// <param name="challengeId"></param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="IEmailChallenge"/> response.</returns>
        Task<IEmailChallenge> PollForEmailMagicLinkAsync(string emailId, string challengeId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="verificationRequest">The <see cref="IVerifyEmailOTP"/> resource.</param>
        /// <param name="emailId"></param>
        /// <param name="challengeId"></param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        Task VerifyEmailOtpAsync(IVerifyEmailOTP verificationRequest, string emailId, string challengeId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <returns>A collection of <see cref="IPhone"/> that can be enumerated asynchronously.</returns>
        ICollectionClient<IPhone> ListPhones();

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="addPhoneRequest">The <see cref="IAddPhoneRequest"/> resource.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="IPhone"/> response.</returns>
        Task<IPhone> AddPhoneAsync(IAddPhoneRequest addPhoneRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="phoneId"></param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        Task DeletePhoneAsync(string phoneId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="phoneId"></param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="IPhone"/> response.</returns>
        Task<IPhone> GetPhoneAsync(string phoneId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="phoneChallengeRequest">The <see cref="IPhoneChallengeRequest"/> resource.</param>
        /// <param name="phoneId"></param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        Task SendPhoneChallengeAsync(IPhoneChallengeRequest phoneChallengeRequest, string phoneId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="verifyPhoneChallengeRequest">The <see cref="IVerifyPhoneChallengeRequest"/> resource.</param>
        /// <param name="phoneId"></param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        Task VerifyPhoneChallengeAsync(IVerifyPhoneChallengeRequest verifyPhoneChallengeRequest, string phoneId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="IMyProfile"/> response.</returns>
        Task<IMyProfile> GetMyProfileAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="updateRequest">The <see cref="IUpdateMyProfileRequest"/> resource.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="IMyProfile"/> response.</returns>
        Task<IMyProfile> UpdateMyProfileAsync(IUpdateMyProfileRequest updateRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="IMyProfileSchema"/> response.</returns>
        Task<IMyProfileSchema> GetMyProfileSchemaAsync(CancellationToken cancellationToken = default(CancellationToken));

    }
}
