# Okta.Sdk.Api.TrustedOriginApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateOrigin**](TrustedOriginApi.md#activateorigin) | **POST** /api/v1/trustedOrigins/{trustedOriginId}/lifecycle/activate | 
[**CreateOrigin**](TrustedOriginApi.md#createorigin) | **POST** /api/v1/trustedOrigins | 
[**DeactivateOrigin**](TrustedOriginApi.md#deactivateorigin) | **POST** /api/v1/trustedOrigins/{trustedOriginId}/lifecycle/deactivate | 
[**DeleteOrigin**](TrustedOriginApi.md#deleteorigin) | **DELETE** /api/v1/trustedOrigins/{trustedOriginId} | 
[**GetOrigin**](TrustedOriginApi.md#getorigin) | **GET** /api/v1/trustedOrigins/{trustedOriginId} | 
[**ListOrigins**](TrustedOriginApi.md#listorigins) | **GET** /api/v1/trustedOrigins | 
[**UpdateOrigin**](TrustedOriginApi.md#updateorigin) | **PUT** /api/v1/trustedOrigins/{trustedOriginId} | 

<a name="activateorigin"></a>
# **ActivateOrigin**
> TrustedOrigin ActivateOrigin (string trustedOriginId)



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
    public class ActivateOriginExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TrustedOriginApi();
            var trustedOriginId = trustedOriginId_example;  // string | 

            try
            {
                TrustedOrigin result = apiInstance.ActivateOrigin(trustedOriginId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrustedOriginApi.ActivateOrigin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **trustedOriginId** | **string**|  | 

### Return type

[**TrustedOrigin**](TrustedOrigin.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createorigin"></a>
# **CreateOrigin**
> TrustedOrigin CreateOrigin (TrustedOrigin body)



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
    public class CreateOriginExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TrustedOriginApi();
            var body = new TrustedOrigin(); // TrustedOrigin | 

            try
            {
                TrustedOrigin result = apiInstance.CreateOrigin(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrustedOriginApi.CreateOrigin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrustedOrigin**](TrustedOrigin.md)|  | 

### Return type

[**TrustedOrigin**](TrustedOrigin.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deactivateorigin"></a>
# **DeactivateOrigin**
> TrustedOrigin DeactivateOrigin (string trustedOriginId)



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
    public class DeactivateOriginExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TrustedOriginApi();
            var trustedOriginId = trustedOriginId_example;  // string | 

            try
            {
                TrustedOrigin result = apiInstance.DeactivateOrigin(trustedOriginId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrustedOriginApi.DeactivateOrigin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **trustedOriginId** | **string**|  | 

### Return type

[**TrustedOrigin**](TrustedOrigin.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteorigin"></a>
# **DeleteOrigin**
> void DeleteOrigin (string trustedOriginId)



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
    public class DeleteOriginExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TrustedOriginApi();
            var trustedOriginId = trustedOriginId_example;  // string | 

            try
            {
                apiInstance.DeleteOrigin(trustedOriginId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrustedOriginApi.DeleteOrigin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **trustedOriginId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorigin"></a>
# **GetOrigin**
> TrustedOrigin GetOrigin (string trustedOriginId)



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
    public class GetOriginExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TrustedOriginApi();
            var trustedOriginId = trustedOriginId_example;  // string | 

            try
            {
                TrustedOrigin result = apiInstance.GetOrigin(trustedOriginId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrustedOriginApi.GetOrigin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **trustedOriginId** | **string**|  | 

### Return type

[**TrustedOrigin**](TrustedOrigin.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listorigins"></a>
# **ListOrigins**
> List<TrustedOrigin> ListOrigins (string q = null, string filter = null, string after = null, int? limit = null)



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
    public class ListOriginsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TrustedOriginApi();
            var q = q_example;  // string |  (optional) 
            var filter = filter_example;  // string |  (optional) 
            var after = after_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                List&lt;TrustedOrigin&gt; result = apiInstance.ListOrigins(q, filter, after, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrustedOriginApi.ListOrigins: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**|  | [optional] 
 **filter** | **string**|  | [optional] 
 **after** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**List<TrustedOrigin>**](TrustedOrigin.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateorigin"></a>
# **UpdateOrigin**
> TrustedOrigin UpdateOrigin (TrustedOrigin body, string trustedOriginId)



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
    public class UpdateOriginExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TrustedOriginApi();
            var body = new TrustedOrigin(); // TrustedOrigin | 
            var trustedOriginId = trustedOriginId_example;  // string | 

            try
            {
                TrustedOrigin result = apiInstance.UpdateOrigin(body, trustedOriginId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrustedOriginApi.UpdateOrigin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrustedOrigin**](TrustedOrigin.md)|  | 
 **trustedOriginId** | **string**|  | 

### Return type

[**TrustedOrigin**](TrustedOrigin.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
