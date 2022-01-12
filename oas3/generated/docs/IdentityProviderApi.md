# Okta.Sdk.Api.IdentityProviderApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateIdentityProvider**](IdentityProviderApi.md#activateidentityprovider) | **POST** /api/v1/idps/{idpId}/lifecycle/activate | Activate Identity Provider
[**CloneIdentityProviderKey**](IdentityProviderApi.md#cloneidentityproviderkey) | **POST** /api/v1/idps/{idpId}/credentials/keys/{keyId}/clone | Clone Signing Key Credential for IdP
[**CreateIdentityProvider**](IdentityProviderApi.md#createidentityprovider) | **POST** /api/v1/idps | Add Identity Provider
[**CreateIdentityProviderKey**](IdentityProviderApi.md#createidentityproviderkey) | **POST** /api/v1/idps/credentials/keys | Add X.509 Certificate Public Key
[**DeactivateIdentityProvider**](IdentityProviderApi.md#deactivateidentityprovider) | **POST** /api/v1/idps/{idpId}/lifecycle/deactivate | Deactivate Identity Provider
[**DeleteIdentityProvider**](IdentityProviderApi.md#deleteidentityprovider) | **DELETE** /api/v1/idps/{idpId} | Delete Identity Provider
[**DeleteIdentityProviderKey**](IdentityProviderApi.md#deleteidentityproviderkey) | **DELETE** /api/v1/idps/credentials/keys/{keyId} | Delete Key
[**GenerateCsrForIdentityProvider**](IdentityProviderApi.md#generatecsrforidentityprovider) | **POST** /api/v1/idps/{idpId}/credentials/csrs | Generate Certificate Signing Request for IdP
[**GenerateIdentityProviderSigningKey**](IdentityProviderApi.md#generateidentityprovidersigningkey) | **POST** /api/v1/idps/{idpId}/credentials/keys/generate | Generate New IdP Signing Key Credential
[**GetCsrForIdentityProvider**](IdentityProviderApi.md#getcsrforidentityprovider) | **GET** /api/v1/idps/{idpId}/credentials/csrs/{csrId} | 
[**GetIdentityProvider**](IdentityProviderApi.md#getidentityprovider) | **GET** /api/v1/idps/{idpId} | Get Identity Provider
[**GetIdentityProviderApplicationUser**](IdentityProviderApi.md#getidentityproviderapplicationuser) | **GET** /api/v1/idps/{idpId}/users/{userId} | 
[**GetIdentityProviderKey**](IdentityProviderApi.md#getidentityproviderkey) | **GET** /api/v1/idps/credentials/keys/{keyId} | Get Key
[**GetIdentityProviderSigningKey**](IdentityProviderApi.md#getidentityprovidersigningkey) | **GET** /api/v1/idps/{idpId}/credentials/keys/{keyId} | Get Signing Key Credential for IdP
[**LinkUserToIdentityProvider**](IdentityProviderApi.md#linkusertoidentityprovider) | **POST** /api/v1/idps/{idpId}/users/{userId} | Link a user to a Social IdP without a transaction
[**ListCsrsForIdentityProvider**](IdentityProviderApi.md#listcsrsforidentityprovider) | **GET** /api/v1/idps/{idpId}/credentials/csrs | List Certificate Signing Requests for IdP
[**ListIdentityProviderApplicationUsers**](IdentityProviderApi.md#listidentityproviderapplicationusers) | **GET** /api/v1/idps/{idpId}/users | Find Users
[**ListIdentityProviderKeys**](IdentityProviderApi.md#listidentityproviderkeys) | **GET** /api/v1/idps/credentials/keys | List Keys
[**ListIdentityProviderSigningKeys**](IdentityProviderApi.md#listidentityprovidersigningkeys) | **GET** /api/v1/idps/{idpId}/credentials/keys | List Signing Key Credentials for IdP
[**ListIdentityProviders**](IdentityProviderApi.md#listidentityproviders) | **GET** /api/v1/idps | List Identity Providers
[**ListSocialAuthTokens**](IdentityProviderApi.md#listsocialauthtokens) | **GET** /api/v1/idps/{idpId}/users/{userId}/credentials/tokens | Social Authentication Token Operation
[**PublishCsrForIdentityProvider**](IdentityProviderApi.md#publishcsrforidentityprovider) | **POST** /api/v1/idps/{idpId}/credentials/csrs/{csrId}/lifecycle/publish | 
[**RevokeCsrForIdentityProvider**](IdentityProviderApi.md#revokecsrforidentityprovider) | **DELETE** /api/v1/idps/{idpId}/credentials/csrs/{csrId} | 
[**UnlinkUserFromIdentityProvider**](IdentityProviderApi.md#unlinkuserfromidentityprovider) | **DELETE** /api/v1/idps/{idpId}/users/{userId} | Unlink User from IdP
[**UpdateIdentityProvider**](IdentityProviderApi.md#updateidentityprovider) | **PUT** /api/v1/idps/{idpId} | Update Identity Provider

<a name="activateidentityprovider"></a>
# **ActivateIdentityProvider**
> IdentityProvider ActivateIdentityProvider (string idpId)

Activate Identity Provider

Activates an inactive IdP.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ActivateIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 

            try
            {
                // Activate Identity Provider
                IdentityProvider result = apiInstance.ActivateIdentityProvider(idpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ActivateIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cloneidentityproviderkey"></a>
# **CloneIdentityProviderKey**
> JsonWebKey CloneIdentityProviderKey (string idpId, string keyId, string targetIdpId)

Clone Signing Key Credential for IdP

Clones a X.509 certificate for an IdP signing key credential from a source IdP to target IdP

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CloneIdentityProviderKeyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 
            var keyId = keyId_example;  // string | 
            var targetIdpId = targetIdpId_example;  // string | 

            try
            {
                // Clone Signing Key Credential for IdP
                JsonWebKey result = apiInstance.CloneIdentityProviderKey(idpId, keyId, targetIdpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.CloneIdentityProviderKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **keyId** | **string**|  | 
 **targetIdpId** | **string**|  | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createidentityprovider"></a>
# **CreateIdentityProvider**
> IdentityProvider CreateIdentityProvider (IdentityProvider body)

Add Identity Provider

Adds a new IdP to your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var body = new IdentityProvider(); // IdentityProvider | 

            try
            {
                // Add Identity Provider
                IdentityProvider result = apiInstance.CreateIdentityProvider(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.CreateIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IdentityProvider**](IdentityProvider.md)|  | 

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createidentityproviderkey"></a>
# **CreateIdentityProviderKey**
> JsonWebKey CreateIdentityProviderKey (JsonWebKey body)

Add X.509 Certificate Public Key

Adds a new X.509 certificate credential to the IdP key store.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateIdentityProviderKeyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var body = new JsonWebKey(); // JsonWebKey | 

            try
            {
                // Add X.509 Certificate Public Key
                JsonWebKey result = apiInstance.CreateIdentityProviderKey(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.CreateIdentityProviderKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JsonWebKey**](JsonWebKey.md)|  | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deactivateidentityprovider"></a>
# **DeactivateIdentityProvider**
> IdentityProvider DeactivateIdentityProvider (string idpId)

Deactivate Identity Provider

Deactivates an active IdP.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeactivateIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 

            try
            {
                // Deactivate Identity Provider
                IdentityProvider result = apiInstance.DeactivateIdentityProvider(idpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeactivateIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteidentityprovider"></a>
# **DeleteIdentityProvider**
> void DeleteIdentityProvider (string idpId)

Delete Identity Provider

Removes an IdP from your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 

            try
            {
                // Delete Identity Provider
                apiInstance.DeleteIdentityProvider(idpId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteidentityproviderkey"></a>
# **DeleteIdentityProviderKey**
> void DeleteIdentityProviderKey (string keyId)

Delete Key

Deletes a specific IdP Key Credential by `kid` if it is not currently being used by an Active or Inactive IdP.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteIdentityProviderKeyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var keyId = keyId_example;  // string | 

            try
            {
                // Delete Key
                apiInstance.DeleteIdentityProviderKey(keyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteIdentityProviderKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="generatecsrforidentityprovider"></a>
# **GenerateCsrForIdentityProvider**
> Csr GenerateCsrForIdentityProvider (CsrMetadata body, string idpId)

Generate Certificate Signing Request for IdP

Generates a new key pair and returns a Certificate Signing Request for it.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GenerateCsrForIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var body = new CsrMetadata(); // CsrMetadata | 
            var idpId = idpId_example;  // string | 

            try
            {
                // Generate Certificate Signing Request for IdP
                Csr result = apiInstance.GenerateCsrForIdentityProvider(body, idpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GenerateCsrForIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CsrMetadata**](CsrMetadata.md)|  | 
 **idpId** | **string**|  | 

### Return type

[**Csr**](Csr.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="generateidentityprovidersigningkey"></a>
# **GenerateIdentityProviderSigningKey**
> JsonWebKey GenerateIdentityProviderSigningKey (string idpId, int? validityYears)

Generate New IdP Signing Key Credential

Generates a new X.509 certificate for an IdP signing key credential to be used for signing assertions sent to the IdP

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GenerateIdentityProviderSigningKeyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 
            var validityYears = 56;  // int? | expiry of the IdP Key Credential

            try
            {
                // Generate New IdP Signing Key Credential
                JsonWebKey result = apiInstance.GenerateIdentityProviderSigningKey(idpId, validityYears);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GenerateIdentityProviderSigningKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **validityYears** | **int?**| expiry of the IdP Key Credential | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcsrforidentityprovider"></a>
# **GetCsrForIdentityProvider**
> Csr GetCsrForIdentityProvider (string idpId, string csrId)



Gets a specific Certificate Signing Request model by id

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetCsrForIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 
            var csrId = csrId_example;  // string | 

            try
            {
                Csr result = apiInstance.GetCsrForIdentityProvider(idpId, csrId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetCsrForIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **csrId** | **string**|  | 

### Return type

[**Csr**](Csr.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getidentityprovider"></a>
# **GetIdentityProvider**
> IdentityProvider GetIdentityProvider (string idpId)

Get Identity Provider

Fetches an IdP by `id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 

            try
            {
                // Get Identity Provider
                IdentityProvider result = apiInstance.GetIdentityProvider(idpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getidentityproviderapplicationuser"></a>
# **GetIdentityProviderApplicationUser**
> IdentityProviderApplicationUser GetIdentityProviderApplicationUser (string idpId, string userId)



Fetches a linked IdP user by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetIdentityProviderApplicationUserExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 
            var userId = userId_example;  // string | 

            try
            {
                IdentityProviderApplicationUser result = apiInstance.GetIdentityProviderApplicationUser(idpId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityProviderApplicationUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

[**IdentityProviderApplicationUser**](IdentityProviderApplicationUser.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getidentityproviderkey"></a>
# **GetIdentityProviderKey**
> JsonWebKey GetIdentityProviderKey (string keyId)

Get Key

Gets a specific IdP Key Credential by `kid`

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetIdentityProviderKeyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var keyId = keyId_example;  // string | 

            try
            {
                // Get Key
                JsonWebKey result = apiInstance.GetIdentityProviderKey(keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityProviderKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyId** | **string**|  | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getidentityprovidersigningkey"></a>
# **GetIdentityProviderSigningKey**
> JsonWebKey GetIdentityProviderSigningKey (string idpId, string keyId)

Get Signing Key Credential for IdP

Gets a specific IdP Key Credential by `kid`

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetIdentityProviderSigningKeyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 
            var keyId = keyId_example;  // string | 

            try
            {
                // Get Signing Key Credential for IdP
                JsonWebKey result = apiInstance.GetIdentityProviderSigningKey(idpId, keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityProviderSigningKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **keyId** | **string**|  | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="linkusertoidentityprovider"></a>
# **LinkUserToIdentityProvider**
> IdentityProviderApplicationUser LinkUserToIdentityProvider (UserIdentityProviderLinkRequest body, string idpId, string userId)

Link a user to a Social IdP without a transaction

Links an Okta user to an existing Social Identity Provider. This does not support the SAML2 Identity Provider Type

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class LinkUserToIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var body = new UserIdentityProviderLinkRequest(); // UserIdentityProviderLinkRequest | 
            var idpId = idpId_example;  // string | 
            var userId = userId_example;  // string | 

            try
            {
                // Link a user to a Social IdP without a transaction
                IdentityProviderApplicationUser result = apiInstance.LinkUserToIdentityProvider(body, idpId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.LinkUserToIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIdentityProviderLinkRequest**](UserIdentityProviderLinkRequest.md)|  | 
 **idpId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

[**IdentityProviderApplicationUser**](IdentityProviderApplicationUser.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listcsrsforidentityprovider"></a>
# **ListCsrsForIdentityProvider**
> List<Csr> ListCsrsForIdentityProvider (string idpId)

List Certificate Signing Requests for IdP

Enumerates Certificate Signing Requests for an IdP

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListCsrsForIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 

            try
            {
                // List Certificate Signing Requests for IdP
                List&lt;Csr&gt; result = apiInstance.ListCsrsForIdentityProvider(idpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ListCsrsForIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

[**List<Csr>**](Csr.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listidentityproviderapplicationusers"></a>
# **ListIdentityProviderApplicationUsers**
> List<IdentityProviderApplicationUser> ListIdentityProviderApplicationUsers (string idpId)

Find Users

Find all the users linked to an identity provider

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListIdentityProviderApplicationUsersExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 

            try
            {
                // Find Users
                List&lt;IdentityProviderApplicationUser&gt; result = apiInstance.ListIdentityProviderApplicationUsers(idpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ListIdentityProviderApplicationUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

[**List<IdentityProviderApplicationUser>**](IdentityProviderApplicationUser.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listidentityproviderkeys"></a>
# **ListIdentityProviderKeys**
> List<JsonWebKey> ListIdentityProviderKeys (string after = null, int? limit = null)

List Keys

Enumerates IdP key credentials.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListIdentityProviderKeysExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var after = after_example;  // string | Specifies the pagination cursor for the next page of keys (optional) 
            var limit = 56;  // int? | Specifies the number of key results in a page (optional) 

            try
            {
                // List Keys
                List&lt;JsonWebKey&gt; result = apiInstance.ListIdentityProviderKeys(after, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ListIdentityProviderKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **after** | **string**| Specifies the pagination cursor for the next page of keys | [optional] 
 **limit** | **int?**| Specifies the number of key results in a page | [optional] 

### Return type

[**List<JsonWebKey>**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listidentityprovidersigningkeys"></a>
# **ListIdentityProviderSigningKeys**
> List<JsonWebKey> ListIdentityProviderSigningKeys (string idpId)

List Signing Key Credentials for IdP

Enumerates signing key credentials for an IdP

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListIdentityProviderSigningKeysExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 

            try
            {
                // List Signing Key Credentials for IdP
                List&lt;JsonWebKey&gt; result = apiInstance.ListIdentityProviderSigningKeys(idpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ListIdentityProviderSigningKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 

### Return type

[**List<JsonWebKey>**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listidentityproviders"></a>
# **ListIdentityProviders**
> List<IdentityProvider> ListIdentityProviders (string q = null, string after = null, int? limit = null, string type = null)

List Identity Providers

Enumerates IdPs in your organization with pagination. A subset of IdPs can be returned that match a supported filter expression or query.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListIdentityProvidersExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var q = q_example;  // string | Searches the name property of IdPs for matching value (optional) 
            var after = after_example;  // string | Specifies the pagination cursor for the next page of IdPs (optional) 
            var limit = 56;  // int? | Specifies the number of IdP results in a page (optional) 
            var type = type_example;  // string | Filters IdPs by type (optional) 

            try
            {
                // List Identity Providers
                List&lt;IdentityProvider&gt; result = apiInstance.ListIdentityProviders(q, after, limit, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ListIdentityProviders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Searches the name property of IdPs for matching value | [optional] 
 **after** | **string**| Specifies the pagination cursor for the next page of IdPs | [optional] 
 **limit** | **int?**| Specifies the number of IdP results in a page | [optional] 
 **type** | **string**| Filters IdPs by type | [optional] 

### Return type

[**List<IdentityProvider>**](IdentityProvider.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listsocialauthtokens"></a>
# **ListSocialAuthTokens**
> List<SocialAuthToken> ListSocialAuthTokens (string idpId, string userId)

Social Authentication Token Operation

Fetches the tokens minted by the Social Authentication Provider when the user authenticates with Okta via Social Auth.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListSocialAuthTokensExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 
            var userId = userId_example;  // string | 

            try
            {
                // Social Authentication Token Operation
                List&lt;SocialAuthToken&gt; result = apiInstance.ListSocialAuthTokens(idpId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.ListSocialAuthTokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

[**List<SocialAuthToken>**](SocialAuthToken.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="publishcsrforidentityprovider"></a>
# **PublishCsrForIdentityProvider**
> JsonWebKey PublishCsrForIdentityProvider (Object body, string idpId, string csrId)



Update the Certificate Signing Request with a signed X.509 certificate and add it into the signing key credentials for the IdP.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class PublishCsrForIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var body = new Object(); // Object | 
            var idpId = idpId_example;  // string | 
            var csrId = csrId_example;  // string | 

            try
            {
                JsonWebKey result = apiInstance.PublishCsrForIdentityProvider(body, idpId, csrId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PublishCsrForIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **Object**|  | 
 **idpId** | **string**|  | 
 **csrId** | **string**|  | 

### Return type

[**JsonWebKey**](JsonWebKey.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/octet-stream, application/x-x509-ca-cert, application/pkix-cert, application/x-pem-file
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="revokecsrforidentityprovider"></a>
# **RevokeCsrForIdentityProvider**
> void RevokeCsrForIdentityProvider (string idpId, string csrId)



Revoke a Certificate Signing Request and delete the key pair from the IdP

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RevokeCsrForIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 
            var csrId = csrId_example;  // string | 

            try
            {
                apiInstance.RevokeCsrForIdentityProvider(idpId, csrId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.RevokeCsrForIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **csrId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="unlinkuserfromidentityprovider"></a>
# **UnlinkUserFromIdentityProvider**
> void UnlinkUserFromIdentityProvider (string idpId, string userId)

Unlink User from IdP

Removes the link between the Okta user and the IdP user.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UnlinkUserFromIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var idpId = idpId_example;  // string | 
            var userId = userId_example;  // string | 

            try
            {
                // Unlink User from IdP
                apiInstance.UnlinkUserFromIdentityProvider(idpId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.UnlinkUserFromIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idpId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateidentityprovider"></a>
# **UpdateIdentityProvider**
> IdentityProvider UpdateIdentityProvider (IdentityProvider body, string idpId)

Update Identity Provider

Updates the configuration for an IdP.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateIdentityProviderExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IdentityProviderApi();
            var body = new IdentityProvider(); // IdentityProvider | 
            var idpId = idpId_example;  // string | 

            try
            {
                // Update Identity Provider
                IdentityProvider result = apiInstance.UpdateIdentityProvider(body, idpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.UpdateIdentityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IdentityProvider**](IdentityProvider.md)|  | 
 **idpId** | **string**|  | 

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
