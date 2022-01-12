# Okta.Sdk.Api.TemplateApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSmsTemplate**](TemplateApi.md#createsmstemplate) | **POST** /api/v1/templates/sms | Add SMS Template
[**DeleteSmsTemplate**](TemplateApi.md#deletesmstemplate) | **DELETE** /api/v1/templates/sms/{templateId} | Remove SMS Template
[**GetSmsTemplate**](TemplateApi.md#getsmstemplate) | **GET** /api/v1/templates/sms/{templateId} | Get SMS Template
[**ListSmsTemplates**](TemplateApi.md#listsmstemplates) | **GET** /api/v1/templates/sms | List SMS Templates
[**PartialUpdateSmsTemplate**](TemplateApi.md#partialupdatesmstemplate) | **POST** /api/v1/templates/sms/{templateId} | Partial SMS Template Update
[**UpdateSmsTemplate**](TemplateApi.md#updatesmstemplate) | **PUT** /api/v1/templates/sms/{templateId} | Update SMS Template

<a name="createsmstemplate"></a>
# **CreateSmsTemplate**
> SmsTemplate CreateSmsTemplate (SmsTemplate body)

Add SMS Template

Adds a new custom SMS template to your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateSmsTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateApi();
            var body = new SmsTemplate(); // SmsTemplate | 

            try
            {
                // Add SMS Template
                SmsTemplate result = apiInstance.CreateSmsTemplate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.CreateSmsTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SmsTemplate**](SmsTemplate.md)|  | 

### Return type

[**SmsTemplate**](SmsTemplate.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesmstemplate"></a>
# **DeleteSmsTemplate**
> void DeleteSmsTemplate (string templateId)

Remove SMS Template

Removes an SMS template.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteSmsTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateApi();
            var templateId = templateId_example;  // string | 

            try
            {
                // Remove SMS Template
                apiInstance.DeleteSmsTemplate(templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.DeleteSmsTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsmstemplate"></a>
# **GetSmsTemplate**
> SmsTemplate GetSmsTemplate (string templateId)

Get SMS Template

Fetches a specific template by `id`

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetSmsTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateApi();
            var templateId = templateId_example;  // string | 

            try
            {
                // Get SMS Template
                SmsTemplate result = apiInstance.GetSmsTemplate(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.GetSmsTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**|  | 

### Return type

[**SmsTemplate**](SmsTemplate.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listsmstemplates"></a>
# **ListSmsTemplates**
> List<SmsTemplate> ListSmsTemplates (SmsTemplateType templateType = null)

List SMS Templates

Enumerates custom SMS templates in your organization. A subset of templates can be returned that match a template type.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListSmsTemplatesExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateApi();
            var templateType = new SmsTemplateType(); // SmsTemplateType |  (optional) 

            try
            {
                // List SMS Templates
                List&lt;SmsTemplate&gt; result = apiInstance.ListSmsTemplates(templateType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.ListSmsTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateType** | [**SmsTemplateType**](SmsTemplateType.md)|  | [optional] 

### Return type

[**List<SmsTemplate>**](SmsTemplate.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="partialupdatesmstemplate"></a>
# **PartialUpdateSmsTemplate**
> SmsTemplate PartialUpdateSmsTemplate (SmsTemplate body, string templateId)

Partial SMS Template Update

Updates only some of the SMS template properties:

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class PartialUpdateSmsTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateApi();
            var body = new SmsTemplate(); // SmsTemplate | 
            var templateId = templateId_example;  // string | 

            try
            {
                // Partial SMS Template Update
                SmsTemplate result = apiInstance.PartialUpdateSmsTemplate(body, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PartialUpdateSmsTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SmsTemplate**](SmsTemplate.md)|  | 
 **templateId** | **string**|  | 

### Return type

[**SmsTemplate**](SmsTemplate.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatesmstemplate"></a>
# **UpdateSmsTemplate**
> SmsTemplate UpdateSmsTemplate (SmsTemplate body, string templateId)

Update SMS Template

Updates the SMS template.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateSmsTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateApi();
            var body = new SmsTemplate(); // SmsTemplate | 
            var templateId = templateId_example;  // string | 

            try
            {
                // Update SMS Template
                SmsTemplate result = apiInstance.UpdateSmsTemplate(body, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.UpdateSmsTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SmsTemplate**](SmsTemplate.md)|  | 
 **templateId** | **string**|  | 

### Return type

[**SmsTemplate**](SmsTemplate.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
