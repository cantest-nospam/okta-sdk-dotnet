# Okta.Sdk.Api.ApplicationApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateApplication**](ApplicationApi.md#activateapplication) | **POST** /api/v1/apps/{appId}/lifecycle/activate | Activate Application
[**AssignUserToApplication**](ApplicationApi.md#assignusertoapplication) | **POST** /api/v1/apps/{appId}/users | Assign User to Application for SSO &amp; Provisioning
[**CloneApplicationKey**](ApplicationApi.md#cloneapplicationkey) | **POST** /api/v1/apps/{appId}/credentials/keys/{keyId}/clone | Clone Application Key Credential
[**CreateApplication**](ApplicationApi.md#createapplication) | **POST** /api/v1/apps | Add Application
[**CreateApplicationGroupAssignment**](ApplicationApi.md#createapplicationgroupassignment) | **PUT** /api/v1/apps/{appId}/groups/{groupId} | Assign Group to Application
[**DeactivateApplication**](ApplicationApi.md#deactivateapplication) | **POST** /api/v1/apps/{appId}/lifecycle/deactivate | Deactivate Application
[**DeleteApplication**](ApplicationApi.md#deleteapplication) | **DELETE** /api/v1/apps/{appId} | Delete Application
[**DeleteApplicationGroupAssignment**](ApplicationApi.md#deleteapplicationgroupassignment) | **DELETE** /api/v1/apps/{appId}/groups/{groupId} | Remove Group from Application
[**DeleteApplicationUser**](ApplicationApi.md#deleteapplicationuser) | **DELETE** /api/v1/apps/{appId}/users/{userId} | Remove User from Application
[**GenerateApplicationKey**](ApplicationApi.md#generateapplicationkey) | **POST** /api/v1/apps/{appId}/credentials/keys/generate | 
[**GenerateCsrForApplication**](ApplicationApi.md#generatecsrforapplication) | **POST** /api/v1/apps/{appId}/credentials/csrs | Generate Certificate Signing Request for Application
[**GetApplication**](ApplicationApi.md#getapplication) | **GET** /api/v1/apps/{appId} | Get Application
[**GetApplicationGroupAssignment**](ApplicationApi.md#getapplicationgroupassignment) | **GET** /api/v1/apps/{appId}/groups/{groupId} | Get Assigned Group for Application
[**GetApplicationKey**](ApplicationApi.md#getapplicationkey) | **GET** /api/v1/apps/{appId}/credentials/keys/{keyId} | Get Key Credential for Application
[**GetApplicationUser**](ApplicationApi.md#getapplicationuser) | **GET** /api/v1/apps/{appId}/users/{userId} | Get Assigned User for Application
[**GetCsrForApplication**](ApplicationApi.md#getcsrforapplication) | **GET** /api/v1/apps/{appId}/credentials/csrs/{csrId} | Get Certificate Signing Request
[**GetOAuth2TokenForApplication**](ApplicationApi.md#getoauth2tokenforapplication) | **GET** /api/v1/apps/{appId}/tokens/{tokenId} | 
[**GetScopeConsentGrant**](ApplicationApi.md#getscopeconsentgrant) | **GET** /api/v1/apps/{appId}/grants/{grantId} | 
[**GrantConsentToScope**](ApplicationApi.md#grantconsenttoscope) | **POST** /api/v1/apps/{appId}/grants | 
[**ListApplicationGroupAssignments**](ApplicationApi.md#listapplicationgroupassignments) | **GET** /api/v1/apps/{appId}/groups | List Groups Assigned to Application
[**ListApplicationKeys**](ApplicationApi.md#listapplicationkeys) | **GET** /api/v1/apps/{appId}/credentials/keys | List Key Credentials for Application
[**ListApplicationUsers**](ApplicationApi.md#listapplicationusers) | **GET** /api/v1/apps/{appId}/users | List Users Assigned to Application
[**ListApplications**](ApplicationApi.md#listapplications) | **GET** /api/v1/apps | List Applications
[**ListCsrsForApplication**](ApplicationApi.md#listcsrsforapplication) | **GET** /api/v1/apps/{appId}/credentials/csrs | List Certificate Signing Requests for Application
[**ListOAuth2TokensForApplication**](ApplicationApi.md#listoauth2tokensforapplication) | **GET** /api/v1/apps/{appId}/tokens | 
[**ListScopeConsentGrants**](ApplicationApi.md#listscopeconsentgrants) | **GET** /api/v1/apps/{appId}/grants | 
[**PublishCsrFromApplication**](ApplicationApi.md#publishcsrfromapplication) | **POST** /api/v1/apps/{appId}/credentials/csrs/{csrId}/lifecycle/publish | Publish Certificate Signing Request
[**RevokeCsrFromApplication**](ApplicationApi.md#revokecsrfromapplication) | **DELETE** /api/v1/apps/{appId}/credentials/csrs/{csrId} | Revoke Certificate Signing Request
[**RevokeOAuth2TokenForApplication**](ApplicationApi.md#revokeoauth2tokenforapplication) | **DELETE** /api/v1/apps/{appId}/tokens/{tokenId} | 
[**RevokeOAuth2TokensForApplication**](ApplicationApi.md#revokeoauth2tokensforapplication) | **DELETE** /api/v1/apps/{appId}/tokens | 
[**RevokeScopeConsentGrant**](ApplicationApi.md#revokescopeconsentgrant) | **DELETE** /api/v1/apps/{appId}/grants/{grantId} | 
[**UpdateApplication**](ApplicationApi.md#updateapplication) | **PUT** /api/v1/apps/{appId} | Update Application
[**UpdateApplicationUser**](ApplicationApi.md#updateapplicationuser) | **POST** /api/v1/apps/{appId}/users/{userId} | Update Application Profile for Assigned User

<a name="activateapplication"></a>
# **ActivateApplication**
> void ActivateApplication (string appId)

Activate Application

Activates an inactive application.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ActivateApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 

            try
            {
                // Activate Application
                apiInstance.ActivateApplication(appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ActivateApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="assignusertoapplication"></a>
# **AssignUserToApplication**
> AppUser AssignUserToApplication (AppUser body, string appId)

Assign User to Application for SSO & Provisioning

Assigns an user to an application with [credentials](#application-user-credentials-object) and an app-specific [profile](#application-user-profile-object). Profile mappings defined for the application are first applied before applying any profile properties specified in the request.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class AssignUserToApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var body = new AppUser(); // AppUser | 
            var appId = appId_example;  // string | 

            try
            {
                // Assign User to Application for SSO & Provisioning
                AppUser result = apiInstance.AssignUserToApplication(body, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.AssignUserToApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppUser**](AppUser.md)|  | 
 **appId** | **string**|  | 

### Return type

[**AppUser**](AppUser.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cloneapplicationkey"></a>
# **CloneApplicationKey**
> JsonWebKey CloneApplicationKey (string appId, string keyId, string targetAid)

Clone Application Key Credential

Clones a X.509 certificate for an application key credential from a source application to target application.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CloneApplicationKeyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var keyId = keyId_example;  // string | 
            var targetAid = targetAid_example;  // string | Unique key of the target Application

            try
            {
                // Clone Application Key Credential
                JsonWebKey result = apiInstance.CloneApplicationKey(appId, keyId, targetAid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.CloneApplicationKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **keyId** | **string**|  | 
 **targetAid** | **string**| Unique key of the target Application | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createapplication"></a>
# **CreateApplication**
> Application CreateApplication (Application body, string oktaAccessGatewayAgent = null, bool? activate = null)

Add Application

Adds a new application to your Okta organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var body = new Application(); // Application | 
            var oktaAccessGatewayAgent = oktaAccessGatewayAgent_example;  // string |  (optional) 
            var activate = true;  // bool? | Executes activation lifecycle operation when creating the app (optional)  (default to true)

            try
            {
                // Add Application
                Application result = apiInstance.CreateApplication(body, oktaAccessGatewayAgent, activate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.CreateApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Application**](Application.md)|  | 
 **oktaAccessGatewayAgent** | **string**|  | [optional] 
 **activate** | **bool?**| Executes activation lifecycle operation when creating the app | [optional] [default to true]

### Return type

[**Application**](Application.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createapplicationgroupassignment"></a>
# **CreateApplicationGroupAssignment**
> ApplicationGroupAssignment CreateApplicationGroupAssignment (string appId, string groupId, ApplicationGroupAssignment body = null)

Assign Group to Application

Assigns a group to an application

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateApplicationGroupAssignmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var groupId = groupId_example;  // string | 
            var body = new ApplicationGroupAssignment(); // ApplicationGroupAssignment |  (optional) 

            try
            {
                // Assign Group to Application
                ApplicationGroupAssignment result = apiInstance.CreateApplicationGroupAssignment(appId, groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.CreateApplicationGroupAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **groupId** | **string**|  | 
 **body** | [**ApplicationGroupAssignment**](ApplicationGroupAssignment.md)|  | [optional] 

### Return type

[**ApplicationGroupAssignment**](ApplicationGroupAssignment.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deactivateapplication"></a>
# **DeactivateApplication**
> void DeactivateApplication (string appId)

Deactivate Application

Deactivates an active application.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeactivateApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 

            try
            {
                // Deactivate Application
                apiInstance.DeactivateApplication(appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.DeactivateApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteapplication"></a>
# **DeleteApplication**
> void DeleteApplication (string appId)

Delete Application

Removes an inactive application.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 

            try
            {
                // Delete Application
                apiInstance.DeleteApplication(appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.DeleteApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteapplicationgroupassignment"></a>
# **DeleteApplicationGroupAssignment**
> void DeleteApplicationGroupAssignment (string appId, string groupId)

Remove Group from Application

Removes a group assignment from an application.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteApplicationGroupAssignmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var groupId = groupId_example;  // string | 

            try
            {
                // Remove Group from Application
                apiInstance.DeleteApplicationGroupAssignment(appId, groupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.DeleteApplicationGroupAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **groupId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteapplicationuser"></a>
# **DeleteApplicationUser**
> void DeleteApplicationUser (string appId, string userId, bool? sendEmail = null)

Remove User from Application

Removes an assignment for a user from an application.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteApplicationUserExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var userId = userId_example;  // string | 
            var sendEmail = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Remove User from Application
                apiInstance.DeleteApplicationUser(appId, userId, sendEmail);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.DeleteApplicationUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **userId** | **string**|  | 
 **sendEmail** | **bool?**|  | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="generateapplicationkey"></a>
# **GenerateApplicationKey**
> JsonWebKey GenerateApplicationKey (string appId, int? validityYears = null)



Generates a new X.509 certificate for an application key credential

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GenerateApplicationKeyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var validityYears = 56;  // int? |  (optional) 

            try
            {
                JsonWebKey result = apiInstance.GenerateApplicationKey(appId, validityYears);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GenerateApplicationKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **validityYears** | **int?**|  | [optional] 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="generatecsrforapplication"></a>
# **GenerateCsrForApplication**
> Csr GenerateCsrForApplication (CsrMetadata body, string appId)

Generate Certificate Signing Request for Application

Generates a new key pair and returns the Certificate Signing Request for it.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GenerateCsrForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var body = new CsrMetadata(); // CsrMetadata | 
            var appId = appId_example;  // string | 

            try
            {
                // Generate Certificate Signing Request for Application
                Csr result = apiInstance.GenerateCsrForApplication(body, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GenerateCsrForApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CsrMetadata**](CsrMetadata.md)|  | 
 **appId** | **string**|  | 

### Return type

[**Csr**](Csr.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapplication"></a>
# **GetApplication**
> Application GetApplication (string appId, string expand = null)

Get Application

Fetches an application from your Okta organization by `id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var expand = expand_example;  // string |  (optional) 

            try
            {
                // Get Application
                Application result = apiInstance.GetApplication(appId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **expand** | **string**|  | [optional] 

### Return type

[**Application**](Application.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapplicationgroupassignment"></a>
# **GetApplicationGroupAssignment**
> ApplicationGroupAssignment GetApplicationGroupAssignment (string appId, string groupId, string expand = null)

Get Assigned Group for Application

Fetches an application group assignment

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetApplicationGroupAssignmentExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var groupId = groupId_example;  // string | 
            var expand = expand_example;  // string |  (optional) 

            try
            {
                // Get Assigned Group for Application
                ApplicationGroupAssignment result = apiInstance.GetApplicationGroupAssignment(appId, groupId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetApplicationGroupAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **groupId** | **string**|  | 
 **expand** | **string**|  | [optional] 

### Return type

[**ApplicationGroupAssignment**](ApplicationGroupAssignment.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapplicationkey"></a>
# **GetApplicationKey**
> JsonWebKey GetApplicationKey (string appId, string keyId)

Get Key Credential for Application

Gets a specific application key credential by kid

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetApplicationKeyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var keyId = keyId_example;  // string | 

            try
            {
                // Get Key Credential for Application
                JsonWebKey result = apiInstance.GetApplicationKey(appId, keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetApplicationKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **keyId** | **string**|  | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapplicationuser"></a>
# **GetApplicationUser**
> AppUser GetApplicationUser (string appId, string userId, string expand = null)

Get Assigned User for Application

Fetches a specific user assignment for application by `id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetApplicationUserExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var userId = userId_example;  // string | 
            var expand = expand_example;  // string |  (optional) 

            try
            {
                // Get Assigned User for Application
                AppUser result = apiInstance.GetApplicationUser(appId, userId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetApplicationUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **userId** | **string**|  | 
 **expand** | **string**|  | [optional] 

### Return type

[**AppUser**](AppUser.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcsrforapplication"></a>
# **GetCsrForApplication**
> Csr GetCsrForApplication (string appId, string csrId)

Get Certificate Signing Request

Fetches a certificate signing request for the app by `id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetCsrForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var csrId = csrId_example;  // string | 

            try
            {
                // Get Certificate Signing Request
                Csr result = apiInstance.GetCsrForApplication(appId, csrId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetCsrForApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **csrId** | **string**|  | 

### Return type

[**Csr**](Csr.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getoauth2tokenforapplication"></a>
# **GetOAuth2TokenForApplication**
> OAuth2Token GetOAuth2TokenForApplication (string appId, string tokenId, string expand = null)



Gets a token for the specified application

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetOAuth2TokenForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var tokenId = tokenId_example;  // string | 
            var expand = expand_example;  // string |  (optional) 

            try
            {
                OAuth2Token result = apiInstance.GetOAuth2TokenForApplication(appId, tokenId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetOAuth2TokenForApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **tokenId** | **string**|  | 
 **expand** | **string**|  | [optional] 

### Return type

[**OAuth2Token**](OAuth2Token.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getscopeconsentgrant"></a>
# **GetScopeConsentGrant**
> OAuth2ScopeConsentGrant GetScopeConsentGrant (string appId, string grantId, string expand = null)



Fetches a single scope consent grant for the application

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetScopeConsentGrantExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var grantId = grantId_example;  // string | 
            var expand = expand_example;  // string |  (optional) 

            try
            {
                OAuth2ScopeConsentGrant result = apiInstance.GetScopeConsentGrant(appId, grantId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetScopeConsentGrant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **grantId** | **string**|  | 
 **expand** | **string**|  | [optional] 

### Return type

[**OAuth2ScopeConsentGrant**](OAuth2ScopeConsentGrant.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="grantconsenttoscope"></a>
# **GrantConsentToScope**
> OAuth2ScopeConsentGrant GrantConsentToScope (OAuth2ScopeConsentGrant body, string appId)



Grants consent for the application to request an OAuth 2.0 Okta scope

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GrantConsentToScopeExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var body = new OAuth2ScopeConsentGrant(); // OAuth2ScopeConsentGrant | 
            var appId = appId_example;  // string | 

            try
            {
                OAuth2ScopeConsentGrant result = apiInstance.GrantConsentToScope(body, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GrantConsentToScope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OAuth2ScopeConsentGrant**](OAuth2ScopeConsentGrant.md)|  | 
 **appId** | **string**|  | 

### Return type

[**OAuth2ScopeConsentGrant**](OAuth2ScopeConsentGrant.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listapplicationgroupassignments"></a>
# **ListApplicationGroupAssignments**
> List<ApplicationGroupAssignment> ListApplicationGroupAssignments (string appId, string q = null, string after = null, int? limit = null, string expand = null)

List Groups Assigned to Application

Enumerates group assignments for an application.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListApplicationGroupAssignmentsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var q = q_example;  // string |  (optional) 
            var after = after_example;  // string | Specifies the pagination cursor for the next page of assignments (optional) 
            var limit = 56;  // int? | Specifies the number of results for a page (optional) 
            var expand = expand_example;  // string |  (optional) 

            try
            {
                // List Groups Assigned to Application
                List&lt;ApplicationGroupAssignment&gt; result = apiInstance.ListApplicationGroupAssignments(appId, q, after, limit, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ListApplicationGroupAssignments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **q** | **string**|  | [optional] 
 **after** | **string**| Specifies the pagination cursor for the next page of assignments | [optional] 
 **limit** | **int?**| Specifies the number of results for a page | [optional] 
 **expand** | **string**|  | [optional] 

### Return type

[**List<ApplicationGroupAssignment>**](ApplicationGroupAssignment.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listapplicationkeys"></a>
# **ListApplicationKeys**
> List<JsonWebKey> ListApplicationKeys (string appId)

List Key Credentials for Application

Enumerates key credentials for an application

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListApplicationKeysExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 

            try
            {
                // List Key Credentials for Application
                List&lt;JsonWebKey&gt; result = apiInstance.ListApplicationKeys(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ListApplicationKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 

### Return type

[**List<JsonWebKey>**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listapplicationusers"></a>
# **ListApplicationUsers**
> List<AppUser> ListApplicationUsers (string appId, string q = null, string queryScope = null, string after = null, int? limit = null, string filter = null, string expand = null)

List Users Assigned to Application

Enumerates all assigned [application users](#application-user-model) for an application.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListApplicationUsersExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var q = q_example;  // string |  (optional) 
            var queryScope = queryScope_example;  // string |  (optional) 
            var after = after_example;  // string | specifies the pagination cursor for the next page of assignments (optional) 
            var limit = 56;  // int? | specifies the number of results for a page (optional) 
            var filter = filter_example;  // string |  (optional) 
            var expand = expand_example;  // string |  (optional) 

            try
            {
                // List Users Assigned to Application
                List&lt;AppUser&gt; result = apiInstance.ListApplicationUsers(appId, q, queryScope, after, limit, filter, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ListApplicationUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **q** | **string**|  | [optional] 
 **queryScope** | **string**|  | [optional] 
 **after** | **string**| specifies the pagination cursor for the next page of assignments | [optional] 
 **limit** | **int?**| specifies the number of results for a page | [optional] 
 **filter** | **string**|  | [optional] 
 **expand** | **string**|  | [optional] 

### Return type

[**List<AppUser>**](AppUser.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listapplications"></a>
# **ListApplications**
> List<Application> ListApplications (string q = null, string after = null, int? limit = null, string filter = null, string expand = null, bool? includeNonDeleted = null)

List Applications

Enumerates apps added to your organization with pagination. A subset of apps can be returned that match a supported filter expression or query.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListApplicationsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var q = q_example;  // string |  (optional) 
            var after = after_example;  // string | Specifies the pagination cursor for the next page of apps (optional) 
            var limit = 56;  // int? | Specifies the number of results for a page (optional) 
            var filter = filter_example;  // string | Filters apps by status, user.id, group.id or credentials.signing.kid expression (optional) 
            var expand = expand_example;  // string | Traverses users link relationship and optionally embeds Application User resource (optional) 
            var includeNonDeleted = true;  // bool? |  (optional)  (default to false)

            try
            {
                // List Applications
                List&lt;Application&gt; result = apiInstance.ListApplications(q, after, limit, filter, expand, includeNonDeleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ListApplications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**|  | [optional] 
 **after** | **string**| Specifies the pagination cursor for the next page of apps | [optional] 
 **limit** | **int?**| Specifies the number of results for a page | [optional] 
 **filter** | **string**| Filters apps by status, user.id, group.id or credentials.signing.kid expression | [optional] 
 **expand** | **string**| Traverses users link relationship and optionally embeds Application User resource | [optional] 
 **includeNonDeleted** | **bool?**|  | [optional] [default to false]

### Return type

[**List<Application>**](Application.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listcsrsforapplication"></a>
# **ListCsrsForApplication**
> List<Csr> ListCsrsForApplication (string appId)

List Certificate Signing Requests for Application

Enumerates Certificate Signing Requests for an application

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListCsrsForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 

            try
            {
                // List Certificate Signing Requests for Application
                List&lt;Csr&gt; result = apiInstance.ListCsrsForApplication(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ListCsrsForApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 

### Return type

[**List<Csr>**](Csr.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listoauth2tokensforapplication"></a>
# **ListOAuth2TokensForApplication**
> List<OAuth2Token> ListOAuth2TokensForApplication (string appId, string expand = null, string after = null, int? limit = null)



Lists all tokens for the application

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListOAuth2TokensForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var expand = expand_example;  // string |  (optional) 
            var after = after_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                List&lt;OAuth2Token&gt; result = apiInstance.ListOAuth2TokensForApplication(appId, expand, after, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ListOAuth2TokensForApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **expand** | **string**|  | [optional] 
 **after** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**List<OAuth2Token>**](OAuth2Token.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listscopeconsentgrants"></a>
# **ListScopeConsentGrants**
> List<OAuth2ScopeConsentGrant> ListScopeConsentGrants (string appId, string expand = null)



Lists all scope consent grants for the application

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListScopeConsentGrantsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var expand = expand_example;  // string |  (optional) 

            try
            {
                List&lt;OAuth2ScopeConsentGrant&gt; result = apiInstance.ListScopeConsentGrants(appId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ListScopeConsentGrants: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **expand** | **string**|  | [optional] 

### Return type

[**List<OAuth2ScopeConsentGrant>**](OAuth2ScopeConsentGrant.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="publishcsrfromapplication"></a>
# **PublishCsrFromApplication**
> JsonWebKey PublishCsrFromApplication (Object body, string appId, string csrId)

Publish Certificate Signing Request

Updates a certificate signing request for the app with a signed X.509 certificate and adds it into the application key credentials

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class PublishCsrFromApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var body = new Object(); // Object | 
            var appId = appId_example;  // string | 
            var csrId = csrId_example;  // string | 

            try
            {
                // Publish Certificate Signing Request
                JsonWebKey result = apiInstance.PublishCsrFromApplication(body, appId, csrId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.PublishCsrFromApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **Object**|  | 
 **appId** | **string**|  | 
 **csrId** | **string**|  | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/octet-stream, application/x-x509-ca-cert, application/pkix-cert, application/x-pem-file
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="revokecsrfromapplication"></a>
# **RevokeCsrFromApplication**
> void RevokeCsrFromApplication (string appId, string csrId)

Revoke Certificate Signing Request

Revokes a certificate signing request and deletes the key pair from the application.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RevokeCsrFromApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var csrId = csrId_example;  // string | 

            try
            {
                // Revoke Certificate Signing Request
                apiInstance.RevokeCsrFromApplication(appId, csrId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.RevokeCsrFromApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **csrId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="revokeoauth2tokenforapplication"></a>
# **RevokeOAuth2TokenForApplication**
> void RevokeOAuth2TokenForApplication (string appId, string tokenId)



Revokes the specified token for the specified application

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RevokeOAuth2TokenForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var tokenId = tokenId_example;  // string | 

            try
            {
                apiInstance.RevokeOAuth2TokenForApplication(appId, tokenId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.RevokeOAuth2TokenForApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **tokenId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="revokeoauth2tokensforapplication"></a>
# **RevokeOAuth2TokensForApplication**
> void RevokeOAuth2TokensForApplication (string appId)



Revokes all tokens for the specified application

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RevokeOAuth2TokensForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 

            try
            {
                apiInstance.RevokeOAuth2TokensForApplication(appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.RevokeOAuth2TokensForApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="revokescopeconsentgrant"></a>
# **RevokeScopeConsentGrant**
> void RevokeScopeConsentGrant (string appId, string grantId)



Revokes permission for the application to request the given scope

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RevokeScopeConsentGrantExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var appId = appId_example;  // string | 
            var grantId = grantId_example;  // string | 

            try
            {
                apiInstance.RevokeScopeConsentGrant(appId, grantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.RevokeScopeConsentGrant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **grantId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateapplication"></a>
# **UpdateApplication**
> Application UpdateApplication (Application body, string appId)

Update Application

Updates an application in your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var body = new Application(); // Application | 
            var appId = appId_example;  // string | 

            try
            {
                // Update Application
                Application result = apiInstance.UpdateApplication(body, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Application**](Application.md)|  | 
 **appId** | **string**|  | 

### Return type

[**Application**](Application.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateapplicationuser"></a>
# **UpdateApplicationUser**
> AppUser UpdateApplicationUser (AppUser body, string appId, string userId)

Update Application Profile for Assigned User

Updates a user's profile for an application

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateApplicationUserExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var body = new AppUser(); // AppUser | 
            var appId = appId_example;  // string | 
            var userId = userId_example;  // string | 

            try
            {
                // Update Application Profile for Assigned User
                AppUser result = apiInstance.UpdateApplicationUser(body, appId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateApplicationUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AppUser**](AppUser.md)|  | 
 **appId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

[**AppUser**](AppUser.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
