// <copyright file="GroupsClient.Generated.cs" company="Okta, Inc">
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
    public sealed partial class GroupsClient : OktaClient, IGroupsClient
    {
        // Remove parameterless constructor
        private GroupsClient()
        {
        }

        internal GroupsClient(IDataStore dataStore, OktaClientConfiguration configuration, RequestContext requestContext)
            : base(dataStore, configuration, requestContext)
        {
        }
        
        /// <inheritdoc />
        public ICollectionClient<IGroup> ListGroups(string q = null, string search = null, string after = null, int? limit = 10000, string expand = null)
            => GetCollectionClient<IGroup>(new HttpRequest
            {
                Uri = "/api/v1/groups",
                Verb = HttpVerb.Get,
                
                QueryParameters = new Dictionary<string, object>()
                {
                    ["q"] = q,
                    ["search"] = search,
                    ["after"] = after,
                    ["limit"] = limit,
                    ["expand"] = expand,
                },
            });
                    
        /// <inheritdoc />
        public async Task<IGroup> CreateGroupAsync(IGroup group, CancellationToken cancellationToken = default(CancellationToken))
            => await PostAsync<Group>(new HttpRequest
            {
                Uri = "/api/v1/groups",
                Verb = HttpVerb.Post,
                Payload = group,
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public ICollectionClient<IGroupRule> ListGroupRules(int? limit = 50, string after = null, string search = null, string expand = null)
            => GetCollectionClient<IGroupRule>(new HttpRequest
            {
                Uri = "/api/v1/groups/rules",
                Verb = HttpVerb.Get,
                
                QueryParameters = new Dictionary<string, object>()
                {
                    ["limit"] = limit,
                    ["after"] = after,
                    ["search"] = search,
                    ["expand"] = expand,
                },
            });
                    
        /// <inheritdoc />
        public async Task<IGroupRule> CreateGroupRuleAsync(IGroupRule groupRule, CancellationToken cancellationToken = default(CancellationToken))
            => await PostAsync<GroupRule>(new HttpRequest
            {
                Uri = "/api/v1/groups/rules",
                Verb = HttpVerb.Post,
                Payload = groupRule,
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task DeleteGroupRuleAsync(string ruleId, bool? removeUsers = null, CancellationToken cancellationToken = default(CancellationToken))
            => await DeleteAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/rules/{ruleId}",
                Verb = HttpVerb.Delete,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["ruleId"] = ruleId,
                },
                QueryParameters = new Dictionary<string, object>()
                {
                    ["removeUsers"] = removeUsers,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task<IGroupRule> GetGroupRuleAsync(string ruleId, string expand = null, CancellationToken cancellationToken = default(CancellationToken))
            => await GetAsync<GroupRule>(new HttpRequest
            {
                Uri = "/api/v1/groups/rules/{ruleId}",
                Verb = HttpVerb.Get,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["ruleId"] = ruleId,
                },
                QueryParameters = new Dictionary<string, object>()
                {
                    ["expand"] = expand,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task<IGroupRule> UpdateGroupRuleAsync(IGroupRule groupRule, string ruleId, CancellationToken cancellationToken = default(CancellationToken))
            => await PutAsync<GroupRule>(new HttpRequest
            {
                Uri = "/api/v1/groups/rules/{ruleId}",
                Verb = HttpVerb.Put,
                Payload = groupRule,
                PathParameters = new Dictionary<string, object>()
                {
                    ["ruleId"] = ruleId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task ActivateGroupRuleAsync(string ruleId, CancellationToken cancellationToken = default(CancellationToken))
            => await PostAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/rules/{ruleId}/lifecycle/activate",
                Verb = HttpVerb.Post,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["ruleId"] = ruleId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task DeactivateGroupRuleAsync(string ruleId, CancellationToken cancellationToken = default(CancellationToken))
            => await PostAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/rules/{ruleId}/lifecycle/deactivate",
                Verb = HttpVerb.Post,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["ruleId"] = ruleId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task DeleteGroupAsync(string groupId, CancellationToken cancellationToken = default(CancellationToken))
            => await DeleteAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}",
                Verb = HttpVerb.Delete,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task<IGroup> GetGroupAsync(string groupId, CancellationToken cancellationToken = default(CancellationToken))
            => await GetAsync<Group>(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}",
                Verb = HttpVerb.Get,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task<IGroup> UpdateGroupAsync(IGroup group, string groupId, CancellationToken cancellationToken = default(CancellationToken))
            => await PutAsync<Group>(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}",
                Verb = HttpVerb.Put,
                Payload = group,
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public ICollectionClient<IApplication> ListAssignedApplicationsForGroup(string groupId, string after = null, int? limit = 20)
            => GetCollectionClient<IApplication>(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/apps",
                Verb = HttpVerb.Get,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                },
                QueryParameters = new Dictionary<string, object>()
                {
                    ["after"] = after,
                    ["limit"] = limit,
                },
            });
                    
        /// <inheritdoc />
        public ICollectionClient<IRole> ListGroupAssignedRoles(string groupId, string expand = null)
            => GetCollectionClient<IRole>(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/roles",
                Verb = HttpVerb.Get,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                },
                QueryParameters = new Dictionary<string, object>()
                {
                    ["expand"] = expand,
                },
            });
                    
        /// <inheritdoc />
        public async Task<IRole> AssignRoleToGroupAsync(IAssignRoleRequest assignRoleRequest, string groupId, bool? disableNotifications = null, CancellationToken cancellationToken = default(CancellationToken))
            => await PostAsync<Role>(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/roles",
                Verb = HttpVerb.Post,
                Payload = assignRoleRequest,
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                },
                QueryParameters = new Dictionary<string, object>()
                {
                    ["disableNotifications"] = disableNotifications,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task RemoveRoleFromGroupAsync(string groupId, string roleId, CancellationToken cancellationToken = default(CancellationToken))
            => await DeleteAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/roles/{roleId}",
                Verb = HttpVerb.Delete,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                    ["roleId"] = roleId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task<IRole> GetRoleAsync(string groupId, string roleId, CancellationToken cancellationToken = default(CancellationToken))
            => await GetAsync<Role>(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/roles/{roleId}",
                Verb = HttpVerb.Get,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                    ["roleId"] = roleId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public ICollectionClient<ICatalogApplication> ListApplicationTargetsForApplicationAdministratorRoleForGroup(string groupId, string roleId, string after = null, int? limit = 20)
            => GetCollectionClient<ICatalogApplication>(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/roles/{roleId}/targets/catalog/apps",
                Verb = HttpVerb.Get,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                    ["roleId"] = roleId,
                },
                QueryParameters = new Dictionary<string, object>()
                {
                    ["after"] = after,
                    ["limit"] = limit,
                },
            });
                    
        /// <inheritdoc />
        public async Task RemoveApplicationTargetFromApplicationAdministratorRoleGivenToGroupAsync(string groupId, string roleId, string appName, CancellationToken cancellationToken = default(CancellationToken))
            => await DeleteAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/roles/{roleId}/targets/catalog/apps/{appName}",
                Verb = HttpVerb.Delete,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                    ["roleId"] = roleId,
                    ["appName"] = appName,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task AddApplicationTargetToAdminRoleGivenToGroupAsync(string groupId, string roleId, string appName, CancellationToken cancellationToken = default(CancellationToken))
            => await PutAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/roles/{roleId}/targets/catalog/apps/{appName}",
                Verb = HttpVerb.Put,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                    ["roleId"] = roleId,
                    ["appName"] = appName,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task RemoveApplicationTargetFromAdministratorRoleGivenToGroupAsync(string groupId, string roleId, string appName, string applicationId, CancellationToken cancellationToken = default(CancellationToken))
            => await DeleteAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/roles/{roleId}/targets/catalog/apps/{appName}/{applicationId}",
                Verb = HttpVerb.Delete,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                    ["roleId"] = roleId,
                    ["appName"] = appName,
                    ["applicationId"] = applicationId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task AddApplicationInstanceTargetToAppAdminRoleGivenToGroupAsync(string groupId, string roleId, string appName, string applicationId, CancellationToken cancellationToken = default(CancellationToken))
            => await PutAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/roles/{roleId}/targets/catalog/apps/{appName}/{applicationId}",
                Verb = HttpVerb.Put,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                    ["roleId"] = roleId,
                    ["appName"] = appName,
                    ["applicationId"] = applicationId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public ICollectionClient<IGroup> ListGroupTargetsForGroupRole(string groupId, string roleId, string after = null, int? limit = 20)
            => GetCollectionClient<IGroup>(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/roles/{roleId}/targets/groups",
                Verb = HttpVerb.Get,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                    ["roleId"] = roleId,
                },
                QueryParameters = new Dictionary<string, object>()
                {
                    ["after"] = after,
                    ["limit"] = limit,
                },
            });
                    
        /// <inheritdoc />
        public async Task RemoveGroupTargetFromGroupAdministratorRoleGivenToGroupAsync(string groupId, string roleId, string targetGroupId, CancellationToken cancellationToken = default(CancellationToken))
            => await DeleteAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/roles/{roleId}/targets/groups/{targetGroupId}",
                Verb = HttpVerb.Delete,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                    ["roleId"] = roleId,
                    ["targetGroupId"] = targetGroupId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task AddGroupTargetToGroupAdministratorRoleForGroupAsync(string groupId, string roleId, string targetGroupId, CancellationToken cancellationToken = default(CancellationToken))
            => await PutAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/roles/{roleId}/targets/groups/{targetGroupId}",
                Verb = HttpVerb.Put,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                    ["roleId"] = roleId,
                    ["targetGroupId"] = targetGroupId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public ICollectionClient<IUser> ListGroupUsers(string groupId, string after = null, int? limit = 1000)
            => GetCollectionClient<IUser>(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/users",
                Verb = HttpVerb.Get,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                },
                QueryParameters = new Dictionary<string, object>()
                {
                    ["after"] = after,
                    ["limit"] = limit,
                },
            });
                    
        /// <inheritdoc />
        public async Task RemoveUserFromGroupAsync(string groupId, string userId, CancellationToken cancellationToken = default(CancellationToken))
            => await DeleteAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/users/{userId}",
                Verb = HttpVerb.Delete,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                    ["userId"] = userId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
        /// <inheritdoc />
        public async Task AddUserToGroupAsync(string groupId, string userId, CancellationToken cancellationToken = default(CancellationToken))
            => await PutAsync(new HttpRequest
            {
                Uri = "/api/v1/groups/{groupId}/users/{userId}",
                Verb = HttpVerb.Put,
                
                PathParameters = new Dictionary<string, object>()
                {
                    ["groupId"] = groupId,
                    ["userId"] = userId,
                },
                }, cancellationToken).ConfigureAwait(false);
        
    }
}
