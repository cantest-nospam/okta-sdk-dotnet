# Okta.Sdk.Api.InlineHookApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateInlineHook**](InlineHookApi.md#activateinlinehook) | **POST** /api/v1/inlineHooks/{inlineHookId}/lifecycle/activate | 
[**CreateInlineHook**](InlineHookApi.md#createinlinehook) | **POST** /api/v1/inlineHooks | 
[**DeactivateInlineHook**](InlineHookApi.md#deactivateinlinehook) | **POST** /api/v1/inlineHooks/{inlineHookId}/lifecycle/deactivate | 
[**DeleteInlineHook**](InlineHookApi.md#deleteinlinehook) | **DELETE** /api/v1/inlineHooks/{inlineHookId} | 
[**ExecuteInlineHook**](InlineHookApi.md#executeinlinehook) | **POST** /api/v1/inlineHooks/{inlineHookId}/execute | 
[**GetInlineHook**](InlineHookApi.md#getinlinehook) | **GET** /api/v1/inlineHooks/{inlineHookId} | 
[**ListInlineHooks**](InlineHookApi.md#listinlinehooks) | **GET** /api/v1/inlineHooks | 
[**UpdateInlineHook**](InlineHookApi.md#updateinlinehook) | **PUT** /api/v1/inlineHooks/{inlineHookId} | 

<a name="activateinlinehook"></a>
# **ActivateInlineHook**
> InlineHook ActivateInlineHook (string inlineHookId)



Activates the Inline Hook matching the provided id

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ActivateInlineHookExample
    {
        public void main()
        {
            var apiInstance = new InlineHookApi();
            var inlineHookId = inlineHookId_example;  // string | 

            try
            {
                InlineHook result = apiInstance.ActivateInlineHook(inlineHookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InlineHookApi.ActivateInlineHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inlineHookId** | **string**|  | 

### Return type

[**InlineHook**](InlineHook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createinlinehook"></a>
# **CreateInlineHook**
> InlineHook CreateInlineHook (InlineHook body)



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
    public class CreateInlineHookExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InlineHookApi();
            var body = new InlineHook(); // InlineHook | 

            try
            {
                InlineHook result = apiInstance.CreateInlineHook(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InlineHookApi.CreateInlineHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InlineHook**](InlineHook.md)|  | 

### Return type

[**InlineHook**](InlineHook.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deactivateinlinehook"></a>
# **DeactivateInlineHook**
> InlineHook DeactivateInlineHook (string inlineHookId)



Deactivates the Inline Hook matching the provided id

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeactivateInlineHookExample
    {
        public void main()
        {
            var apiInstance = new InlineHookApi();
            var inlineHookId = inlineHookId_example;  // string | 

            try
            {
                InlineHook result = apiInstance.DeactivateInlineHook(inlineHookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InlineHookApi.DeactivateInlineHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inlineHookId** | **string**|  | 

### Return type

[**InlineHook**](InlineHook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteinlinehook"></a>
# **DeleteInlineHook**
> void DeleteInlineHook (string inlineHookId)



Deletes the Inline Hook matching the provided id. Once deleted, the Inline Hook is unrecoverable. As a safety precaution, only Inline Hooks with a status of INACTIVE are eligible for deletion.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteInlineHookExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InlineHookApi();
            var inlineHookId = inlineHookId_example;  // string | 

            try
            {
                apiInstance.DeleteInlineHook(inlineHookId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InlineHookApi.DeleteInlineHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inlineHookId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="executeinlinehook"></a>
# **ExecuteInlineHook**
> InlineHookResponse ExecuteInlineHook (InlineHookPayload body, string inlineHookId)



Executes the Inline Hook matching the provided inlineHookId using the request body as the input. This will send the provided data through the Channel and return a response if it matches the correct data contract. This execution endpoint should only be used for testing purposes.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ExecuteInlineHookExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InlineHookApi();
            var body = new InlineHookPayload(); // InlineHookPayload | 
            var inlineHookId = inlineHookId_example;  // string | 

            try
            {
                InlineHookResponse result = apiInstance.ExecuteInlineHook(body, inlineHookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InlineHookApi.ExecuteInlineHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InlineHookPayload**](InlineHookPayload.md)|  | 
 **inlineHookId** | **string**|  | 

### Return type

[**InlineHookResponse**](InlineHookResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getinlinehook"></a>
# **GetInlineHook**
> InlineHook GetInlineHook (string inlineHookId)



Gets an inline hook by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetInlineHookExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InlineHookApi();
            var inlineHookId = inlineHookId_example;  // string | 

            try
            {
                InlineHook result = apiInstance.GetInlineHook(inlineHookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InlineHookApi.GetInlineHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inlineHookId** | **string**|  | 

### Return type

[**InlineHook**](InlineHook.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listinlinehooks"></a>
# **ListInlineHooks**
> List<InlineHook> ListInlineHooks (string type = null)



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
    public class ListInlineHooksExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InlineHookApi();
            var type = type_example;  // string |  (optional) 

            try
            {
                List&lt;InlineHook&gt; result = apiInstance.ListInlineHooks(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InlineHookApi.ListInlineHooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|  | [optional] 

### Return type

[**List<InlineHook>**](InlineHook.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateinlinehook"></a>
# **UpdateInlineHook**
> InlineHook UpdateInlineHook (InlineHook body, string inlineHookId)



Updates an inline hook by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateInlineHookExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InlineHookApi();
            var body = new InlineHook(); // InlineHook | 
            var inlineHookId = inlineHookId_example;  // string | 

            try
            {
                InlineHook result = apiInstance.UpdateInlineHook(body, inlineHookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InlineHookApi.UpdateInlineHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InlineHook**](InlineHook.md)|  | 
 **inlineHookId** | **string**|  | 

### Return type

[**InlineHook**](InlineHook.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
