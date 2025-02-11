﻿// <copyright file="UsersClient.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Okta.Sdk
{
    /// <summary>
    /// Provides methods that manipulate <see cref="User"/> resources, by communicating with the Okta Users API.
    /// </summary>
    public sealed partial class UsersClient : OktaClient, IUsersClient, IAsyncEnumerable<IUser>
    {
        /// <inheritdoc/>
        public IAsyncEnumerator<IUser> GetAsyncEnumerator(CancellationToken cancellationToken = default) => ListUsers().GetAsyncEnumerator(cancellationToken);

        /// <inheritdoc/>
        public Task<IUser> CreateUserAsync(CreateUserWithoutCredentialsOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var user = new CreateUserRequest
            {
                Profile = options.Profile,
            };

            return CreateUserAsync(user, options.Activate, cancellationToken: cancellationToken);
        }

        /// <inheritdoc/>
        public Task<IUser> CreateUserAsync(CreateUserWithImportedHashedPasswordOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var user = new CreateUserRequest
            {
                Profile = options.Profile,
                Credentials = new UserCredentials
                {
                    Password = new PasswordCredential
                    {
                        Hash = options.PasswordCredentialHash,
                    },
                },
            };

            return CreateUserAsync(user, options.Activate, cancellationToken: cancellationToken);
        }

        /// <inheritdoc/>
        public Task<IUser> CreateUserAsync(CreateUserWithPasswordImportInlineHookOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var user = new CreateUserRequest
            {
                Profile = options.Profile,
                Credentials = new UserCredentials
                {
                    Password = new PasswordCredential { Hook = new PasswordCredentialHook() { Type = "default" } },
                },
            };

            return CreateUserAsync(user, options.Activate, cancellationToken: cancellationToken);
        }

        /// <inheritdoc/>
        public Task<IUser> CreateUserAsync(CreateUserWithRecoveryQuestionOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var user = new CreateUserRequest
            {
                Profile = options.Profile,
                Credentials = new UserCredentials
                {
                    RecoveryQuestion = new RecoveryQuestionCredential
                    {
                        Question = options.RecoveryQuestion,
                        Answer = options.RecoveryAnswer,
                    },
                },
            };

            return CreateUserAsync(user, options.Activate, cancellationToken: cancellationToken);
        }

        /// <inheritdoc/>
        public Task<IUser> CreateUserAsync(CreateUserWithPasswordOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var user = new CreateUserRequest
            {
                Profile = options.Profile,
                Credentials = new UserCredentials
                {
                    Password = new PasswordCredential { Value = options.Password },
                },
            };

            var hasRecoveryQuestionAndAnswer = !string.IsNullOrEmpty(options.RecoveryQuestion) && !string.IsNullOrEmpty(options.RecoveryAnswer);
            if (hasRecoveryQuestionAndAnswer)
            {
                user.Credentials.RecoveryQuestion = new RecoveryQuestionCredential
                {
                    Question = options.RecoveryQuestion,
                    Answer = options.RecoveryAnswer,
                };
            }

            return CreateUserAsync(user, options.Activate, cancellationToken: cancellationToken);
        }

        /// <inheritdoc/>
        public Task<IUser> CreateUserAsync(CreateUserWithProviderOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var user = new CreateUserRequest
            {
                Profile = options.Profile,
                Credentials = new UserCredentials
                {
                    Provider = new AuthenticationProvider
                    {
                        Type = options.ProviderType,
                        Name = options.ProviderName,
                    },
                },
            };

            return CreateUserAsync(user, options.Activate, true, cancellationToken: cancellationToken);
        }

        /// <inheritdoc/>
        public Task<IUserCredentials> ChangePasswordAsync(
            string userId,
            ChangePasswordOptions options,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var changePasswordRequest = new ChangePasswordRequest
            {
                OldPassword = new PasswordCredential { Value = options.CurrentPassword },
                NewPassword = new PasswordCredential { Value = options.NewPassword },
            };

            return ChangePasswordAsync(changePasswordRequest, userId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<IUserCredentials> ChangePasswordAsync(IChangePasswordRequest changePasswordRequest, string userId, CancellationToken cancellationToken = default)
            => ChangePasswordAsync(changePasswordRequest, userId, null, cancellationToken);

        /// <inheritdoc/>
        public Task ChangeRecoveryQuestionAsync(string userId, ChangeRecoveryQuestionOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var newCredentials = new UserCredentials
            {
                Password = new PasswordCredential { Value = options.CurrentPassword },
                RecoveryQuestion = new RecoveryQuestionCredential
                {
                    Question = options.RecoveryQuestion,
                    Answer = options.RecoveryAnswer,
                },
            };

            return ChangeRecoveryQuestionAsync(newCredentials, userId, cancellationToken);
        }

        /// <inheritdoc />
        public Task DeactivateOrDeleteUserAsync(string userId, CancellationToken cancellationToken = default(CancellationToken))
            => DeactivateOrDeleteUserAsync(userId, false, cancellationToken);

        /// <inheritdoc />
        public Task DeactivateOrDeleteUserAsync(string userId)
            => DeactivateOrDeleteUserAsync(userId, false, default(CancellationToken));

        /// <inheritdoc />
        public Task<IUser> UpdateUserAsync(IUser user, string userId, CancellationToken cancellationToken = default)
            => UpdateUserAsync(user, userId, null, cancellationToken);

        /// <inheritdoc />
        public Task<IRole> AssignRoleToUserAsync(IAssignRoleRequest assignRoleRequest, string userId,
            string disableNotifications, CancellationToken cancellationToken = default(CancellationToken))
            => AssignRoleToUserAsync(assignRoleRequest, userId, (bool?)null, cancellationToken);
    }
}
