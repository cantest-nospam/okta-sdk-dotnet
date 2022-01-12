# Okta.Sdk.Api.LinkedObjectApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLinkedObjectDefinition**](LinkedObjectApi.md#addlinkedobjectdefinition) | **POST** /api/v1/meta/schemas/user/linkedObjects | 
[**DeleteLinkedObjectDefinition**](LinkedObjectApi.md#deletelinkedobjectdefinition) | **DELETE** /api/v1/meta/schemas/user/linkedObjects/{linkedObjectName} | 
[**GetLinkedObjectDefinition**](LinkedObjectApi.md#getlinkedobjectdefinition) | **GET** /api/v1/meta/schemas/user/linkedObjects/{linkedObjectName} | 
[**ListLinkedObjectDefinitions**](LinkedObjectApi.md#listlinkedobjectdefinitions) | **GET** /api/v1/meta/schemas/user/linkedObjects | 

<a name="addlinkedobjectdefinition"></a>
# **AddLinkedObjectDefinition**
> LinkedObject AddLinkedObjectDefinition (LinkedObject body)



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
    public class AddLinkedObjectDefinitionExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LinkedObjectApi();
            var body = new LinkedObject(); // LinkedObject | 

            try
            {
                LinkedObject result = apiInstance.AddLinkedObjectDefinition(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedObjectApi.AddLinkedObjectDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LinkedObject**](LinkedObject.md)|  | 

### Return type

[**LinkedObject**](LinkedObject.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletelinkedobjectdefinition"></a>
# **DeleteLinkedObjectDefinition**
> void DeleteLinkedObjectDefinition (string linkedObjectName)



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
    public class DeleteLinkedObjectDefinitionExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LinkedObjectApi();
            var linkedObjectName = linkedObjectName_example;  // string | 

            try
            {
                apiInstance.DeleteLinkedObjectDefinition(linkedObjectName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedObjectApi.DeleteLinkedObjectDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkedObjectName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlinkedobjectdefinition"></a>
# **GetLinkedObjectDefinition**
> LinkedObject GetLinkedObjectDefinition (string linkedObjectName)



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
    public class GetLinkedObjectDefinitionExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LinkedObjectApi();
            var linkedObjectName = linkedObjectName_example;  // string | 

            try
            {
                LinkedObject result = apiInstance.GetLinkedObjectDefinition(linkedObjectName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedObjectApi.GetLinkedObjectDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkedObjectName** | **string**|  | 

### Return type

[**LinkedObject**](LinkedObject.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listlinkedobjectdefinitions"></a>
# **ListLinkedObjectDefinitions**
> List<LinkedObject> ListLinkedObjectDefinitions ()



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
    public class ListLinkedObjectDefinitionsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LinkedObjectApi();

            try
            {
                List&lt;LinkedObject&gt; result = apiInstance.ListLinkedObjectDefinitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedObjectApi.ListLinkedObjectDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<LinkedObject>**](LinkedObject.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
