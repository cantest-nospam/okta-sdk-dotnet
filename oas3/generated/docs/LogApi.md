# Okta.Sdk.Api.LogApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLogs**](LogApi.md#getlogs) | **GET** /api/v1/logs | Fetch a list of events from your Okta organization system log.

<a name="getlogs"></a>
# **GetLogs**
> List<LogEvent> GetLogs (DateTime? since = null, DateTime? until = null, string filter = null, string q = null, int? limit = null, string sortOrder = null, string after = null)

Fetch a list of events from your Okta organization system log.

The Okta System Log API provides read access to your organization’s system log. This API provides more functionality than the Events API

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetLogsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LogApi();
            var since = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var until = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var filter = filter_example;  // string |  (optional) 
            var q = q_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var sortOrder = sortOrder_example;  // string |  (optional)  (default to ASCENDING)
            var after = after_example;  // string |  (optional) 

            try
            {
                // Fetch a list of events from your Okta organization system log.
                List&lt;LogEvent&gt; result = apiInstance.GetLogs(since, until, filter, q, limit, sortOrder, after);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogApi.GetLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **DateTime?**|  | [optional] 
 **until** | **DateTime?**|  | [optional] 
 **filter** | **string**|  | [optional] 
 **q** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **sortOrder** | **string**|  | [optional] [default to ASCENDING]
 **after** | **string**|  | [optional] 

### Return type

[**List<LogEvent>**](LogEvent.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
