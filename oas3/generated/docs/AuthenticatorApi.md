# Okta.Sdk.Api.AuthenticatorApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateAuthenticator**](AuthenticatorApi.md#activateauthenticator) | **POST** /api/v1/authenticators/{authenticatorId}/lifecycle/activate | Activate Authenticator
[**DeactivateAuthenticator**](AuthenticatorApi.md#deactivateauthenticator) | **POST** /api/v1/authenticators/{authenticatorId}/lifecycle/deactivate | Deactivate Authenticator
[**GetAuthenticator**](AuthenticatorApi.md#getauthenticator) | **GET** /api/v1/authenticators/{authenticatorId} | Get Authenticator
[**ListAuthenticators**](AuthenticatorApi.md#listauthenticators) | **GET** /api/v1/authenticators | List Authenticators
[**UpdateAuthenticator**](AuthenticatorApi.md#updateauthenticator) | **PUT** /api/v1/authenticators/{authenticatorId} | Update Authenticator

<a name="activateauthenticator"></a>
# **ActivateAuthenticator**
> Authenticator ActivateAuthenticator (string authenticatorId)

Activate Authenticator

Activates an authenticator by `authenticatorId`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ActivateAuthenticatorExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticatorApi();
            var authenticatorId = authenticatorId_example;  // string | 

            try
            {
                // Activate Authenticator
                Authenticator result = apiInstance.ActivateAuthenticator(authenticatorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticatorApi.ActivateAuthenticator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authenticatorId** | **string**|  | 

### Return type

[**Authenticator**](Authenticator.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deactivateauthenticator"></a>
# **DeactivateAuthenticator**
> Authenticator DeactivateAuthenticator (string authenticatorId)

Deactivate Authenticator

Deactivates an authenticator by `authenticatorId`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeactivateAuthenticatorExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticatorApi();
            var authenticatorId = authenticatorId_example;  // string | 

            try
            {
                // Deactivate Authenticator
                Authenticator result = apiInstance.DeactivateAuthenticator(authenticatorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticatorApi.DeactivateAuthenticator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authenticatorId** | **string**|  | 

### Return type

[**Authenticator**](Authenticator.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getauthenticator"></a>
# **GetAuthenticator**
> Authenticator GetAuthenticator (string authenticatorId)

Get Authenticator

Fetches an authenticator from your Okta organization by `authenticatorId`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetAuthenticatorExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticatorApi();
            var authenticatorId = authenticatorId_example;  // string | 

            try
            {
                // Get Authenticator
                Authenticator result = apiInstance.GetAuthenticator(authenticatorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticatorApi.GetAuthenticator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authenticatorId** | **string**|  | 

### Return type

[**Authenticator**](Authenticator.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listauthenticators"></a>
# **ListAuthenticators**
> List<Authenticator> ListAuthenticators ()

List Authenticators

Enumerates authenticators in your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListAuthenticatorsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticatorApi();

            try
            {
                // List Authenticators
                List&lt;Authenticator&gt; result = apiInstance.ListAuthenticators();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticatorApi.ListAuthenticators: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Authenticator>**](Authenticator.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateauthenticator"></a>
# **UpdateAuthenticator**
> Authenticator UpdateAuthenticator (string authenticatorId, Authenticator body = null)

Update Authenticator

Updates an authenticator

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateAuthenticatorExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticatorApi();
            var authenticatorId = authenticatorId_example;  // string | 
            var body = new Authenticator(); // Authenticator |  (optional) 

            try
            {
                // Update Authenticator
                Authenticator result = apiInstance.UpdateAuthenticator(authenticatorId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticatorApi.UpdateAuthenticator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authenticatorId** | **string**|  | 
 **body** | [**Authenticator**](Authenticator.md)|  | [optional] 

### Return type

[**Authenticator**](Authenticator.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
