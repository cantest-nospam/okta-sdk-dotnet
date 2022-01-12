# Okta.Sdk.Api.ThreatInsightApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCurrentConfiguration**](ThreatInsightApi.md#getcurrentconfiguration) | **GET** /api/v1/threats/configuration | 
[**UpdateConfiguration**](ThreatInsightApi.md#updateconfiguration) | **POST** /api/v1/threats/configuration | 

<a name="getcurrentconfiguration"></a>
# **GetCurrentConfiguration**
> ThreatInsightConfiguration GetCurrentConfiguration ()



Gets current ThreatInsight configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetCurrentConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ThreatInsightApi();

            try
            {
                ThreatInsightConfiguration result = apiInstance.GetCurrentConfiguration();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThreatInsightApi.GetCurrentConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ThreatInsightConfiguration**](ThreatInsightConfiguration.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateconfiguration"></a>
# **UpdateConfiguration**
> ThreatInsightConfiguration UpdateConfiguration (ThreatInsightConfiguration body)



Updates ThreatInsight configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ThreatInsightApi();
            var body = new ThreatInsightConfiguration(); // ThreatInsightConfiguration | 

            try
            {
                ThreatInsightConfiguration result = apiInstance.UpdateConfiguration(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThreatInsightApi.UpdateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ThreatInsightConfiguration**](ThreatInsightConfiguration.md)|  | 

### Return type

[**ThreatInsightConfiguration**](ThreatInsightConfiguration.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
