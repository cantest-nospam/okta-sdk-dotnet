# Okta.Sdk.Api.CAPTCHAApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCaptchaInstance**](CAPTCHAApi.md#createcaptchainstance) | **POST** /api/v1/captchas | Create new CAPTCHA instance
[**DeleteCaptchaInstance**](CAPTCHAApi.md#deletecaptchainstance) | **DELETE** /api/v1/captchas/{captchaId} | Delete CAPTCHA Instance
[**GetCaptchaInstance**](CAPTCHAApi.md#getcaptchainstance) | **GET** /api/v1/captchas/{captchaId} | Get CAPTCHA Instance
[**ListCaptchaInstances**](CAPTCHAApi.md#listcaptchainstances) | **GET** /api/v1/captchas | List CAPTCHA instances
[**PartialUpdateCaptchaInstance**](CAPTCHAApi.md#partialupdatecaptchainstance) | **POST** /api/v1/captchas/{captchaId} | Partial Update CAPTCHA instance
[**UpdateCaptchaInstance**](CAPTCHAApi.md#updatecaptchainstance) | **PUT** /api/v1/captchas/{captchaId} | Update CAPTCHA instance

<a name="createcaptchainstance"></a>
# **CreateCaptchaInstance**
> CAPTCHAInstance CreateCaptchaInstance (CAPTCHAInstance body = null)

Create new CAPTCHA instance

Adds a new CAPTCHA instance to your organization. In current release, we only allow one CAPTCHA instance per org.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateCaptchaInstanceExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CAPTCHAApi();
            var body = new CAPTCHAInstance(); // CAPTCHAInstance |  (optional) 

            try
            {
                // Create new CAPTCHA instance
                CAPTCHAInstance result = apiInstance.CreateCaptchaInstance(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CAPTCHAApi.CreateCaptchaInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CAPTCHAInstance**](CAPTCHAInstance.md)|  | [optional] 

### Return type

[**CAPTCHAInstance**](CAPTCHAInstance.md)

### Authorization

[api_token](../README.md#api_token), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecaptchainstance"></a>
# **DeleteCaptchaInstance**
> void DeleteCaptchaInstance (string captchaId)

Delete CAPTCHA Instance

Delete a CAPTCHA instance by `id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteCaptchaInstanceExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CAPTCHAApi();
            var captchaId = captchaId_example;  // string | id of the CAPTCHA

            try
            {
                // Delete CAPTCHA Instance
                apiInstance.DeleteCaptchaInstance(captchaId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CAPTCHAApi.DeleteCaptchaInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **captchaId** | **string**| id of the CAPTCHA | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcaptchainstance"></a>
# **GetCaptchaInstance**
> CAPTCHAInstance GetCaptchaInstance (string captchaId)

Get CAPTCHA Instance

Fetches a CAPTCHA instance by `id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetCaptchaInstanceExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CAPTCHAApi();
            var captchaId = captchaId_example;  // string | id of the CAPTCHA

            try
            {
                // Get CAPTCHA Instance
                CAPTCHAInstance result = apiInstance.GetCaptchaInstance(captchaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CAPTCHAApi.GetCaptchaInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **captchaId** | **string**| id of the CAPTCHA | 

### Return type

[**CAPTCHAInstance**](CAPTCHAInstance.md)

### Authorization

[api_token](../README.md#api_token), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listcaptchainstances"></a>
# **ListCaptchaInstances**
> List<CAPTCHAInstance> ListCaptchaInstances ()

List CAPTCHA instances

Enumerates CAPTCHA instances in your organization with pagination. A subset of CAPTCHA instances can be returned that match a supported filter expression or query.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListCaptchaInstancesExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CAPTCHAApi();

            try
            {
                // List CAPTCHA instances
                List&lt;CAPTCHAInstance&gt; result = apiInstance.ListCaptchaInstances();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CAPTCHAApi.ListCaptchaInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CAPTCHAInstance>**](CAPTCHAInstance.md)

### Authorization

[api_token](../README.md#api_token), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="partialupdatecaptchainstance"></a>
# **PartialUpdateCaptchaInstance**
> CAPTCHAInstance PartialUpdateCaptchaInstance (CAPTCHAInstance body, string captchaId)

Partial Update CAPTCHA instance

Partially update a CAPTCHA instance by `id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class PartialUpdateCaptchaInstanceExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CAPTCHAApi();
            var body = new CAPTCHAInstance(); // CAPTCHAInstance | 
            var captchaId = captchaId_example;  // string | id of the CAPTCHA

            try
            {
                // Partial Update CAPTCHA instance
                CAPTCHAInstance result = apiInstance.PartialUpdateCaptchaInstance(body, captchaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CAPTCHAApi.PartialUpdateCaptchaInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CAPTCHAInstance**](CAPTCHAInstance.md)|  | 
 **captchaId** | **string**| id of the CAPTCHA | 

### Return type

[**CAPTCHAInstance**](CAPTCHAInstance.md)

### Authorization

[api_token](../README.md#api_token), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecaptchainstance"></a>
# **UpdateCaptchaInstance**
> CAPTCHAInstance UpdateCaptchaInstance (CAPTCHAInstance body, string captchaId)

Update CAPTCHA instance

Update a CAPTCHA instance by `id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateCaptchaInstanceExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CAPTCHAApi();
            var body = new CAPTCHAInstance(); // CAPTCHAInstance | 
            var captchaId = captchaId_example;  // string | id of the CAPTCHA

            try
            {
                // Update CAPTCHA instance
                CAPTCHAInstance result = apiInstance.UpdateCaptchaInstance(body, captchaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CAPTCHAApi.UpdateCaptchaInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CAPTCHAInstance**](CAPTCHAInstance.md)|  | 
 **captchaId** | **string**| id of the CAPTCHA | 

### Return type

[**CAPTCHAInstance**](CAPTCHAInstance.md)

### Authorization

[api_token](../README.md#api_token), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
