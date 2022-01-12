# Okta.Sdk.Api.AuthorizationServerApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateAuthorizationServer**](AuthorizationServerApi.md#activateauthorizationserver) | **POST** /api/v1/authorizationServers/{authServerId}/lifecycle/activate | 
[**ActivateAuthorizationServerPolicy**](AuthorizationServerApi.md#activateauthorizationserverpolicy) | **POST** /api/v1/authorizationServers/{authServerId}/policies/{policyId}/lifecycle/activate | 
[**ActivateAuthorizationServerPolicyRule**](AuthorizationServerApi.md#activateauthorizationserverpolicyrule) | **POST** /api/v1/authorizationServers/{authServerId}/policies/{policyId}/rules/{ruleId}/lifecycle/activate | 
[**CreateAuthorizationServer**](AuthorizationServerApi.md#createauthorizationserver) | **POST** /api/v1/authorizationServers | 
[**CreateAuthorizationServerPolicy**](AuthorizationServerApi.md#createauthorizationserverpolicy) | **POST** /api/v1/authorizationServers/{authServerId}/policies | 
[**CreateAuthorizationServerPolicyRule**](AuthorizationServerApi.md#createauthorizationserverpolicyrule) | **POST** /api/v1/authorizationServers/{authServerId}/policies/{policyId}/rules | 
[**CreateOAuth2Claim**](AuthorizationServerApi.md#createoauth2claim) | **POST** /api/v1/authorizationServers/{authServerId}/claims | 
[**CreateOAuth2Scope**](AuthorizationServerApi.md#createoauth2scope) | **POST** /api/v1/authorizationServers/{authServerId}/scopes | 
[**DeactivateAuthorizationServer**](AuthorizationServerApi.md#deactivateauthorizationserver) | **POST** /api/v1/authorizationServers/{authServerId}/lifecycle/deactivate | 
[**DeactivateAuthorizationServerPolicy**](AuthorizationServerApi.md#deactivateauthorizationserverpolicy) | **POST** /api/v1/authorizationServers/{authServerId}/policies/{policyId}/lifecycle/deactivate | 
[**DeactivateAuthorizationServerPolicyRule**](AuthorizationServerApi.md#deactivateauthorizationserverpolicyrule) | **POST** /api/v1/authorizationServers/{authServerId}/policies/{policyId}/rules/{ruleId}/lifecycle/deactivate | 
[**DeleteAuthorizationServer**](AuthorizationServerApi.md#deleteauthorizationserver) | **DELETE** /api/v1/authorizationServers/{authServerId} | 
[**DeleteAuthorizationServerPolicy**](AuthorizationServerApi.md#deleteauthorizationserverpolicy) | **DELETE** /api/v1/authorizationServers/{authServerId}/policies/{policyId} | 
[**DeleteAuthorizationServerPolicyRule**](AuthorizationServerApi.md#deleteauthorizationserverpolicyrule) | **DELETE** /api/v1/authorizationServers/{authServerId}/policies/{policyId}/rules/{ruleId} | 
[**DeleteOAuth2Claim**](AuthorizationServerApi.md#deleteoauth2claim) | **DELETE** /api/v1/authorizationServers/{authServerId}/claims/{claimId} | 
[**DeleteOAuth2Scope**](AuthorizationServerApi.md#deleteoauth2scope) | **DELETE** /api/v1/authorizationServers/{authServerId}/scopes/{scopeId} | 
[**GetAuthorizationServer**](AuthorizationServerApi.md#getauthorizationserver) | **GET** /api/v1/authorizationServers/{authServerId} | 
[**GetAuthorizationServerPolicy**](AuthorizationServerApi.md#getauthorizationserverpolicy) | **GET** /api/v1/authorizationServers/{authServerId}/policies/{policyId} | 
[**GetAuthorizationServerPolicyRule**](AuthorizationServerApi.md#getauthorizationserverpolicyrule) | **GET** /api/v1/authorizationServers/{authServerId}/policies/{policyId}/rules/{ruleId} | 
[**GetOAuth2Claim**](AuthorizationServerApi.md#getoauth2claim) | **GET** /api/v1/authorizationServers/{authServerId}/claims/{claimId} | 
[**GetOAuth2Scope**](AuthorizationServerApi.md#getoauth2scope) | **GET** /api/v1/authorizationServers/{authServerId}/scopes/{scopeId} | 
[**GetRefreshTokenForAuthorizationServerAndClient**](AuthorizationServerApi.md#getrefreshtokenforauthorizationserverandclient) | **GET** /api/v1/authorizationServers/{authServerId}/clients/{clientId}/tokens/{tokenId} | 
[**ListAuthorizationServerKeys**](AuthorizationServerApi.md#listauthorizationserverkeys) | **GET** /api/v1/authorizationServers/{authServerId}/credentials/keys | 
[**ListAuthorizationServerPolicies**](AuthorizationServerApi.md#listauthorizationserverpolicies) | **GET** /api/v1/authorizationServers/{authServerId}/policies | 
[**ListAuthorizationServerPolicyRules**](AuthorizationServerApi.md#listauthorizationserverpolicyrules) | **GET** /api/v1/authorizationServers/{authServerId}/policies/{policyId}/rules | 
[**ListAuthorizationServers**](AuthorizationServerApi.md#listauthorizationservers) | **GET** /api/v1/authorizationServers | 
[**ListOAuth2Claims**](AuthorizationServerApi.md#listoauth2claims) | **GET** /api/v1/authorizationServers/{authServerId}/claims | 
[**ListOAuth2ClientsForAuthorizationServer**](AuthorizationServerApi.md#listoauth2clientsforauthorizationserver) | **GET** /api/v1/authorizationServers/{authServerId}/clients | 
[**ListOAuth2Scopes**](AuthorizationServerApi.md#listoauth2scopes) | **GET** /api/v1/authorizationServers/{authServerId}/scopes | 
[**ListRefreshTokensForAuthorizationServerAndClient**](AuthorizationServerApi.md#listrefreshtokensforauthorizationserverandclient) | **GET** /api/v1/authorizationServers/{authServerId}/clients/{clientId}/tokens | 
[**RevokeRefreshTokenForAuthorizationServerAndClient**](AuthorizationServerApi.md#revokerefreshtokenforauthorizationserverandclient) | **DELETE** /api/v1/authorizationServers/{authServerId}/clients/{clientId}/tokens/{tokenId} | 
[**RevokeRefreshTokensForAuthorizationServerAndClient**](AuthorizationServerApi.md#revokerefreshtokensforauthorizationserverandclient) | **DELETE** /api/v1/authorizationServers/{authServerId}/clients/{clientId}/tokens | 
[**RotateAuthorizationServerKeys**](AuthorizationServerApi.md#rotateauthorizationserverkeys) | **POST** /api/v1/authorizationServers/{authServerId}/credentials/lifecycle/keyRotate | 
[**UpdateAuthorizationServer**](AuthorizationServerApi.md#updateauthorizationserver) | **PUT** /api/v1/authorizationServers/{authServerId} | 
[**UpdateAuthorizationServerPolicy**](AuthorizationServerApi.md#updateauthorizationserverpolicy) | **PUT** /api/v1/authorizationServers/{authServerId}/policies/{policyId} | 
[**UpdateAuthorizationServerPolicyRule**](AuthorizationServerApi.md#updateauthorizationserverpolicyrule) | **PUT** /api/v1/authorizationServers/{authServerId}/policies/{policyId}/rules/{ruleId} | 
[**UpdateOAuth2Claim**](AuthorizationServerApi.md#updateoauth2claim) | **PUT** /api/v1/authorizationServers/{authServerId}/claims/{claimId} | 
[**UpdateOAuth2Scope**](AuthorizationServerApi.md#updateoauth2scope) | **PUT** /api/v1/authorizationServers/{authServerId}/scopes/{scopeId} | 

<a name="activateauthorizationserver"></a>
# **ActivateAuthorizationServer**
> void ActivateAuthorizationServer (string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ActivateAuthorizationServerExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 

            try
            {
                apiInstance.ActivateAuthorizationServer(authServerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.ActivateAuthorizationServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="activateauthorizationserverpolicy"></a>
# **ActivateAuthorizationServerPolicy**
> void ActivateAuthorizationServerPolicy (string authServerId, string policyId)



Activate Authorization Server Policy

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ActivateAuthorizationServerPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var policyId = policyId_example;  // string | 

            try
            {
                apiInstance.ActivateAuthorizationServerPolicy(authServerId, policyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.ActivateAuthorizationServerPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **policyId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="activateauthorizationserverpolicyrule"></a>
# **ActivateAuthorizationServerPolicyRule**
> void ActivateAuthorizationServerPolicyRule (string authServerId, string policyId, string ruleId)



Activate Authorization Server Policy Rule

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ActivateAuthorizationServerPolicyRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var policyId = policyId_example;  // string | 
            var ruleId = ruleId_example;  // string | 

            try
            {
                apiInstance.ActivateAuthorizationServerPolicyRule(authServerId, policyId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.ActivateAuthorizationServerPolicyRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **policyId** | **string**|  | 
 **ruleId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createauthorizationserver"></a>
# **CreateAuthorizationServer**
> AuthorizationServer CreateAuthorizationServer (AuthorizationServer body)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateAuthorizationServerExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var body = new AuthorizationServer(); // AuthorizationServer | 

            try
            {
                AuthorizationServer result = apiInstance.CreateAuthorizationServer(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.CreateAuthorizationServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthorizationServer**](AuthorizationServer.md)|  | 

### Return type

[**AuthorizationServer**](AuthorizationServer.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createauthorizationserverpolicy"></a>
# **CreateAuthorizationServerPolicy**
> AuthorizationServerPolicy CreateAuthorizationServerPolicy (AuthorizationServerPolicy body, string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateAuthorizationServerPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var body = new AuthorizationServerPolicy(); // AuthorizationServerPolicy | 
            var authServerId = authServerId_example;  // string | 

            try
            {
                AuthorizationServerPolicy result = apiInstance.CreateAuthorizationServerPolicy(body, authServerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.CreateAuthorizationServerPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthorizationServerPolicy**](AuthorizationServerPolicy.md)|  | 
 **authServerId** | **string**|  | 

### Return type

[**AuthorizationServerPolicy**](AuthorizationServerPolicy.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createauthorizationserverpolicyrule"></a>
# **CreateAuthorizationServerPolicyRule**
> AuthorizationServerPolicyRule CreateAuthorizationServerPolicyRule (AuthorizationServerPolicyRule body, string policyId, string authServerId)



Creates a policy rule for the specified Custom Authorization Server and Policy.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateAuthorizationServerPolicyRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var body = new AuthorizationServerPolicyRule(); // AuthorizationServerPolicyRule | 
            var policyId = policyId_example;  // string | 
            var authServerId = authServerId_example;  // string | 

            try
            {
                AuthorizationServerPolicyRule result = apiInstance.CreateAuthorizationServerPolicyRule(body, policyId, authServerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.CreateAuthorizationServerPolicyRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthorizationServerPolicyRule**](AuthorizationServerPolicyRule.md)|  | 
 **policyId** | **string**|  | 
 **authServerId** | **string**|  | 

### Return type

[**AuthorizationServerPolicyRule**](AuthorizationServerPolicyRule.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createoauth2claim"></a>
# **CreateOAuth2Claim**
> OAuth2Claim CreateOAuth2Claim (OAuth2Claim body, string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateOAuth2ClaimExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var body = new OAuth2Claim(); // OAuth2Claim | 
            var authServerId = authServerId_example;  // string | 

            try
            {
                OAuth2Claim result = apiInstance.CreateOAuth2Claim(body, authServerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.CreateOAuth2Claim: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OAuth2Claim**](OAuth2Claim.md)|  | 
 **authServerId** | **string**|  | 

### Return type

[**OAuth2Claim**](OAuth2Claim.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createoauth2scope"></a>
# **CreateOAuth2Scope**
> OAuth2Scope CreateOAuth2Scope (OAuth2Scope body, string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateOAuth2ScopeExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var body = new OAuth2Scope(); // OAuth2Scope | 
            var authServerId = authServerId_example;  // string | 

            try
            {
                OAuth2Scope result = apiInstance.CreateOAuth2Scope(body, authServerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.CreateOAuth2Scope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OAuth2Scope**](OAuth2Scope.md)|  | 
 **authServerId** | **string**|  | 

### Return type

[**OAuth2Scope**](OAuth2Scope.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deactivateauthorizationserver"></a>
# **DeactivateAuthorizationServer**
> void DeactivateAuthorizationServer (string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeactivateAuthorizationServerExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 

            try
            {
                apiInstance.DeactivateAuthorizationServer(authServerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.DeactivateAuthorizationServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deactivateauthorizationserverpolicy"></a>
# **DeactivateAuthorizationServerPolicy**
> void DeactivateAuthorizationServerPolicy (string authServerId, string policyId)



Deactivate Authorization Server Policy

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeactivateAuthorizationServerPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var policyId = policyId_example;  // string | 

            try
            {
                apiInstance.DeactivateAuthorizationServerPolicy(authServerId, policyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.DeactivateAuthorizationServerPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **policyId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deactivateauthorizationserverpolicyrule"></a>
# **DeactivateAuthorizationServerPolicyRule**
> void DeactivateAuthorizationServerPolicyRule (string authServerId, string policyId, string ruleId)



Deactivate Authorization Server Policy Rule

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeactivateAuthorizationServerPolicyRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var policyId = policyId_example;  // string | 
            var ruleId = ruleId_example;  // string | 

            try
            {
                apiInstance.DeactivateAuthorizationServerPolicyRule(authServerId, policyId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.DeactivateAuthorizationServerPolicyRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **policyId** | **string**|  | 
 **ruleId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteauthorizationserver"></a>
# **DeleteAuthorizationServer**
> void DeleteAuthorizationServer (string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteAuthorizationServerExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 

            try
            {
                apiInstance.DeleteAuthorizationServer(authServerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.DeleteAuthorizationServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteauthorizationserverpolicy"></a>
# **DeleteAuthorizationServerPolicy**
> void DeleteAuthorizationServerPolicy (string authServerId, string policyId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteAuthorizationServerPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var policyId = policyId_example;  // string | 

            try
            {
                apiInstance.DeleteAuthorizationServerPolicy(authServerId, policyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.DeleteAuthorizationServerPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **policyId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteauthorizationserverpolicyrule"></a>
# **DeleteAuthorizationServerPolicyRule**
> void DeleteAuthorizationServerPolicyRule (string policyId, string authServerId, string ruleId)



Deletes a Policy Rule defined in the specified Custom Authorization Server and Policy.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteAuthorizationServerPolicyRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var policyId = policyId_example;  // string | 
            var authServerId = authServerId_example;  // string | 
            var ruleId = ruleId_example;  // string | 

            try
            {
                apiInstance.DeleteAuthorizationServerPolicyRule(policyId, authServerId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.DeleteAuthorizationServerPolicyRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**|  | 
 **authServerId** | **string**|  | 
 **ruleId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteoauth2claim"></a>
# **DeleteOAuth2Claim**
> void DeleteOAuth2Claim (string authServerId, string claimId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteOAuth2ClaimExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var claimId = claimId_example;  // string | 

            try
            {
                apiInstance.DeleteOAuth2Claim(authServerId, claimId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.DeleteOAuth2Claim: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **claimId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteoauth2scope"></a>
# **DeleteOAuth2Scope**
> void DeleteOAuth2Scope (string authServerId, string scopeId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteOAuth2ScopeExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var scopeId = scopeId_example;  // string | 

            try
            {
                apiInstance.DeleteOAuth2Scope(authServerId, scopeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.DeleteOAuth2Scope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **scopeId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getauthorizationserver"></a>
# **GetAuthorizationServer**
> AuthorizationServer GetAuthorizationServer (string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetAuthorizationServerExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 

            try
            {
                AuthorizationServer result = apiInstance.GetAuthorizationServer(authServerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.GetAuthorizationServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 

### Return type

[**AuthorizationServer**](AuthorizationServer.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getauthorizationserverpolicy"></a>
# **GetAuthorizationServerPolicy**
> AuthorizationServerPolicy GetAuthorizationServerPolicy (string authServerId, string policyId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetAuthorizationServerPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var policyId = policyId_example;  // string | 

            try
            {
                AuthorizationServerPolicy result = apiInstance.GetAuthorizationServerPolicy(authServerId, policyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.GetAuthorizationServerPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **policyId** | **string**|  | 

### Return type

[**AuthorizationServerPolicy**](AuthorizationServerPolicy.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getauthorizationserverpolicyrule"></a>
# **GetAuthorizationServerPolicyRule**
> AuthorizationServerPolicyRule GetAuthorizationServerPolicyRule (string policyId, string authServerId, string ruleId)



Returns a Policy Rule by ID that is defined in the specified Custom Authorization Server and Policy.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetAuthorizationServerPolicyRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var policyId = policyId_example;  // string | 
            var authServerId = authServerId_example;  // string | 
            var ruleId = ruleId_example;  // string | 

            try
            {
                AuthorizationServerPolicyRule result = apiInstance.GetAuthorizationServerPolicyRule(policyId, authServerId, ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.GetAuthorizationServerPolicyRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**|  | 
 **authServerId** | **string**|  | 
 **ruleId** | **string**|  | 

### Return type

[**AuthorizationServerPolicyRule**](AuthorizationServerPolicyRule.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getoauth2claim"></a>
# **GetOAuth2Claim**
> OAuth2Claim GetOAuth2Claim (string authServerId, string claimId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetOAuth2ClaimExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var claimId = claimId_example;  // string | 

            try
            {
                OAuth2Claim result = apiInstance.GetOAuth2Claim(authServerId, claimId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.GetOAuth2Claim: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **claimId** | **string**|  | 

### Return type

[**OAuth2Claim**](OAuth2Claim.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getoauth2scope"></a>
# **GetOAuth2Scope**
> OAuth2Scope GetOAuth2Scope (string authServerId, string scopeId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetOAuth2ScopeExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var scopeId = scopeId_example;  // string | 

            try
            {
                OAuth2Scope result = apiInstance.GetOAuth2Scope(authServerId, scopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.GetOAuth2Scope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **scopeId** | **string**|  | 

### Return type

[**OAuth2Scope**](OAuth2Scope.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrefreshtokenforauthorizationserverandclient"></a>
# **GetRefreshTokenForAuthorizationServerAndClient**
> OAuth2RefreshToken GetRefreshTokenForAuthorizationServerAndClient (string authServerId, string clientId, string tokenId, string expand = null)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetRefreshTokenForAuthorizationServerAndClientExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var clientId = clientId_example;  // string | 
            var tokenId = tokenId_example;  // string | 
            var expand = expand_example;  // string |  (optional) 

            try
            {
                OAuth2RefreshToken result = apiInstance.GetRefreshTokenForAuthorizationServerAndClient(authServerId, clientId, tokenId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.GetRefreshTokenForAuthorizationServerAndClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **clientId** | **string**|  | 
 **tokenId** | **string**|  | 
 **expand** | **string**|  | [optional] 

### Return type

[**OAuth2RefreshToken**](OAuth2RefreshToken.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listauthorizationserverkeys"></a>
# **ListAuthorizationServerKeys**
> List<JsonWebKey> ListAuthorizationServerKeys (string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListAuthorizationServerKeysExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 

            try
            {
                List&lt;JsonWebKey&gt; result = apiInstance.ListAuthorizationServerKeys(authServerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.ListAuthorizationServerKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 

### Return type

[**List<JsonWebKey>**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listauthorizationserverpolicies"></a>
# **ListAuthorizationServerPolicies**
> List<AuthorizationServerPolicy> ListAuthorizationServerPolicies (string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListAuthorizationServerPoliciesExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 

            try
            {
                List&lt;AuthorizationServerPolicy&gt; result = apiInstance.ListAuthorizationServerPolicies(authServerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.ListAuthorizationServerPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 

### Return type

[**List<AuthorizationServerPolicy>**](AuthorizationServerPolicy.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listauthorizationserverpolicyrules"></a>
# **ListAuthorizationServerPolicyRules**
> List<AuthorizationServerPolicyRule> ListAuthorizationServerPolicyRules (string policyId, string authServerId)



Enumerates all policy rules for the specified Custom Authorization Server and Policy.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListAuthorizationServerPolicyRulesExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var policyId = policyId_example;  // string | 
            var authServerId = authServerId_example;  // string | 

            try
            {
                List&lt;AuthorizationServerPolicyRule&gt; result = apiInstance.ListAuthorizationServerPolicyRules(policyId, authServerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.ListAuthorizationServerPolicyRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**|  | 
 **authServerId** | **string**|  | 

### Return type

[**List<AuthorizationServerPolicyRule>**](AuthorizationServerPolicyRule.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listauthorizationservers"></a>
# **ListAuthorizationServers**
> List<AuthorizationServer> ListAuthorizationServers (string q = null, string limit = null, string after = null)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListAuthorizationServersExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var q = q_example;  // string |  (optional) 
            var limit = limit_example;  // string |  (optional) 
            var after = after_example;  // string |  (optional) 

            try
            {
                List&lt;AuthorizationServer&gt; result = apiInstance.ListAuthorizationServers(q, limit, after);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.ListAuthorizationServers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**|  | [optional] 
 **limit** | **string**|  | [optional] 
 **after** | **string**|  | [optional] 

### Return type

[**List<AuthorizationServer>**](AuthorizationServer.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listoauth2claims"></a>
# **ListOAuth2Claims**
> List<OAuth2Claim> ListOAuth2Claims (string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListOAuth2ClaimsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 

            try
            {
                List&lt;OAuth2Claim&gt; result = apiInstance.ListOAuth2Claims(authServerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.ListOAuth2Claims: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 

### Return type

[**List<OAuth2Claim>**](OAuth2Claim.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listoauth2clientsforauthorizationserver"></a>
# **ListOAuth2ClientsForAuthorizationServer**
> List<OAuth2Client> ListOAuth2ClientsForAuthorizationServer (string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListOAuth2ClientsForAuthorizationServerExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 

            try
            {
                List&lt;OAuth2Client&gt; result = apiInstance.ListOAuth2ClientsForAuthorizationServer(authServerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.ListOAuth2ClientsForAuthorizationServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 

### Return type

[**List<OAuth2Client>**](OAuth2Client.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listoauth2scopes"></a>
# **ListOAuth2Scopes**
> List<OAuth2Scope> ListOAuth2Scopes (string authServerId, string q = null, string filter = null, string cursor = null, int? limit = null)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListOAuth2ScopesExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var q = q_example;  // string |  (optional) 
            var filter = filter_example;  // string |  (optional) 
            var cursor = cursor_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                List&lt;OAuth2Scope&gt; result = apiInstance.ListOAuth2Scopes(authServerId, q, filter, cursor, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.ListOAuth2Scopes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **q** | **string**|  | [optional] 
 **filter** | **string**|  | [optional] 
 **cursor** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**List<OAuth2Scope>**](OAuth2Scope.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listrefreshtokensforauthorizationserverandclient"></a>
# **ListRefreshTokensForAuthorizationServerAndClient**
> List<OAuth2RefreshToken> ListRefreshTokensForAuthorizationServerAndClient (string authServerId, string clientId, string expand = null, string after = null, int? limit = null)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListRefreshTokensForAuthorizationServerAndClientExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var clientId = clientId_example;  // string | 
            var expand = expand_example;  // string |  (optional) 
            var after = after_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                List&lt;OAuth2RefreshToken&gt; result = apiInstance.ListRefreshTokensForAuthorizationServerAndClient(authServerId, clientId, expand, after, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.ListRefreshTokensForAuthorizationServerAndClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **clientId** | **string**|  | 
 **expand** | **string**|  | [optional] 
 **after** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**List<OAuth2RefreshToken>**](OAuth2RefreshToken.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="revokerefreshtokenforauthorizationserverandclient"></a>
# **RevokeRefreshTokenForAuthorizationServerAndClient**
> void RevokeRefreshTokenForAuthorizationServerAndClient (string authServerId, string clientId, string tokenId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RevokeRefreshTokenForAuthorizationServerAndClientExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var clientId = clientId_example;  // string | 
            var tokenId = tokenId_example;  // string | 

            try
            {
                apiInstance.RevokeRefreshTokenForAuthorizationServerAndClient(authServerId, clientId, tokenId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.RevokeRefreshTokenForAuthorizationServerAndClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **clientId** | **string**|  | 
 **tokenId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="revokerefreshtokensforauthorizationserverandclient"></a>
# **RevokeRefreshTokensForAuthorizationServerAndClient**
> void RevokeRefreshTokensForAuthorizationServerAndClient (string authServerId, string clientId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RevokeRefreshTokensForAuthorizationServerAndClientExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var authServerId = authServerId_example;  // string | 
            var clientId = clientId_example;  // string | 

            try
            {
                apiInstance.RevokeRefreshTokensForAuthorizationServerAndClient(authServerId, clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.RevokeRefreshTokensForAuthorizationServerAndClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authServerId** | **string**|  | 
 **clientId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="rotateauthorizationserverkeys"></a>
# **RotateAuthorizationServerKeys**
> List<JsonWebKey> RotateAuthorizationServerKeys (JwkUse body, string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RotateAuthorizationServerKeysExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var body = new JwkUse(); // JwkUse | 
            var authServerId = authServerId_example;  // string | 

            try
            {
                List&lt;JsonWebKey&gt; result = apiInstance.RotateAuthorizationServerKeys(body, authServerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.RotateAuthorizationServerKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JwkUse**](JwkUse.md)|  | 
 **authServerId** | **string**|  | 

### Return type

[**List<JsonWebKey>**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateauthorizationserver"></a>
# **UpdateAuthorizationServer**
> AuthorizationServer UpdateAuthorizationServer (AuthorizationServer body, string authServerId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateAuthorizationServerExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var body = new AuthorizationServer(); // AuthorizationServer | 
            var authServerId = authServerId_example;  // string | 

            try
            {
                AuthorizationServer result = apiInstance.UpdateAuthorizationServer(body, authServerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.UpdateAuthorizationServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthorizationServer**](AuthorizationServer.md)|  | 
 **authServerId** | **string**|  | 

### Return type

[**AuthorizationServer**](AuthorizationServer.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateauthorizationserverpolicy"></a>
# **UpdateAuthorizationServerPolicy**
> AuthorizationServerPolicy UpdateAuthorizationServerPolicy (AuthorizationServerPolicy body, string authServerId, string policyId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateAuthorizationServerPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var body = new AuthorizationServerPolicy(); // AuthorizationServerPolicy | 
            var authServerId = authServerId_example;  // string | 
            var policyId = policyId_example;  // string | 

            try
            {
                AuthorizationServerPolicy result = apiInstance.UpdateAuthorizationServerPolicy(body, authServerId, policyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.UpdateAuthorizationServerPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthorizationServerPolicy**](AuthorizationServerPolicy.md)|  | 
 **authServerId** | **string**|  | 
 **policyId** | **string**|  | 

### Return type

[**AuthorizationServerPolicy**](AuthorizationServerPolicy.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateauthorizationserverpolicyrule"></a>
# **UpdateAuthorizationServerPolicyRule**
> AuthorizationServerPolicyRule UpdateAuthorizationServerPolicyRule (AuthorizationServerPolicyRule body, string policyId, string authServerId, string ruleId)



Updates the configuration of the Policy Rule defined in the specified Custom Authorization Server and Policy.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateAuthorizationServerPolicyRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var body = new AuthorizationServerPolicyRule(); // AuthorizationServerPolicyRule | 
            var policyId = policyId_example;  // string | 
            var authServerId = authServerId_example;  // string | 
            var ruleId = ruleId_example;  // string | 

            try
            {
                AuthorizationServerPolicyRule result = apiInstance.UpdateAuthorizationServerPolicyRule(body, policyId, authServerId, ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.UpdateAuthorizationServerPolicyRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthorizationServerPolicyRule**](AuthorizationServerPolicyRule.md)|  | 
 **policyId** | **string**|  | 
 **authServerId** | **string**|  | 
 **ruleId** | **string**|  | 

### Return type

[**AuthorizationServerPolicyRule**](AuthorizationServerPolicyRule.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateoauth2claim"></a>
# **UpdateOAuth2Claim**
> OAuth2Claim UpdateOAuth2Claim (OAuth2Claim body, string authServerId, string claimId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateOAuth2ClaimExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var body = new OAuth2Claim(); // OAuth2Claim | 
            var authServerId = authServerId_example;  // string | 
            var claimId = claimId_example;  // string | 

            try
            {
                OAuth2Claim result = apiInstance.UpdateOAuth2Claim(body, authServerId, claimId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.UpdateOAuth2Claim: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OAuth2Claim**](OAuth2Claim.md)|  | 
 **authServerId** | **string**|  | 
 **claimId** | **string**|  | 

### Return type

[**OAuth2Claim**](OAuth2Claim.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateoauth2scope"></a>
# **UpdateOAuth2Scope**
> OAuth2Scope UpdateOAuth2Scope (OAuth2Scope body, string authServerId, string scopeId)



Success

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateOAuth2ScopeExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthorizationServerApi();
            var body = new OAuth2Scope(); // OAuth2Scope | 
            var authServerId = authServerId_example;  // string | 
            var scopeId = scopeId_example;  // string | 

            try
            {
                OAuth2Scope result = apiInstance.UpdateOAuth2Scope(body, authServerId, scopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationServerApi.UpdateOAuth2Scope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OAuth2Scope**](OAuth2Scope.md)|  | 
 **authServerId** | **string**|  | 
 **scopeId** | **string**|  | 

### Return type

[**OAuth2Scope**](OAuth2Scope.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
