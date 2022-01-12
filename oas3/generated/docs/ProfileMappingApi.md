# Okta.Sdk.Api.ProfileMappingApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProfileMapping**](ProfileMappingApi.md#getprofilemapping) | **GET** /api/v1/mappings/{mappingId} | Get Profile Mapping
[**ListProfileMappings**](ProfileMappingApi.md#listprofilemappings) | **GET** /api/v1/mappings | 
[**UpdateProfileMapping**](ProfileMappingApi.md#updateprofilemapping) | **POST** /api/v1/mappings/{mappingId} | Update Profile Mapping

<a name="getprofilemapping"></a>
# **GetProfileMapping**
> ProfileMapping GetProfileMapping (string mappingId)

Get Profile Mapping

Fetches a single Profile Mapping referenced by its ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetProfileMappingExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfileMappingApi();
            var mappingId = mappingId_example;  // string | 

            try
            {
                // Get Profile Mapping
                ProfileMapping result = apiInstance.GetProfileMapping(mappingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileMappingApi.GetProfileMapping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mappingId** | **string**|  | 

### Return type

[**ProfileMapping**](ProfileMapping.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listprofilemappings"></a>
# **ListProfileMappings**
> List<ProfileMapping> ListProfileMappings (string after = null, int? limit = null, string sourceId = null, string targetId = null)



Enumerates Profile Mappings in your organization with pagination.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListProfileMappingsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfileMappingApi();
            var after = after_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var sourceId = sourceId_example;  // string |  (optional) 
            var targetId = targetId_example;  // string |  (optional) 

            try
            {
                List&lt;ProfileMapping&gt; result = apiInstance.ListProfileMappings(after, limit, sourceId, targetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileMappingApi.ListProfileMappings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **after** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **sourceId** | **string**|  | [optional] 
 **targetId** | **string**|  | [optional] 

### Return type

[**List<ProfileMapping>**](ProfileMapping.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateprofilemapping"></a>
# **UpdateProfileMapping**
> ProfileMapping UpdateProfileMapping (ProfileMapping body, string mappingId)

Update Profile Mapping

Updates an existing Profile Mapping by adding, updating, or removing one or many Property Mappings.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateProfileMappingExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfileMappingApi();
            var body = new ProfileMapping(); // ProfileMapping | 
            var mappingId = mappingId_example;  // string | 

            try
            {
                // Update Profile Mapping
                ProfileMapping result = apiInstance.UpdateProfileMapping(body, mappingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileMappingApi.UpdateProfileMapping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProfileMapping**](ProfileMapping.md)|  | 
 **mappingId** | **string**|  | 

### Return type

[**ProfileMapping**](ProfileMapping.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
