# Okta.Sdk.Api.BrandApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEmailCustomization**](BrandApi.md#createemailcustomization) | **POST** /api/v1/brands/{brandId}/templates/email/{templateName}/customizations | Create Email Customization
[**DeleteAllCustomizations**](BrandApi.md#deleteallcustomizations) | **DELETE** /api/v1/brands/{brandId}/templates/email/{templateName}/customizations | Delete Email Customizations
[**DeleteBrandThemeBackgroundImage**](BrandApi.md#deletebrandthemebackgroundimage) | **DELETE** /api/v1/brands/{brandId}/themes/{themeId}/background-image | Deletes a Theme background image
[**DeleteBrandThemeFavicon**](BrandApi.md#deletebrandthemefavicon) | **DELETE** /api/v1/brands/{brandId}/themes/{themeId}/favicon | Deletes a Theme favicon. The org then uses the Okta default favicon.
[**DeleteBrandThemeLogo**](BrandApi.md#deletebrandthemelogo) | **DELETE** /api/v1/brands/{brandId}/themes/{themeId}/logo | Deletes a Theme logo. The org then uses the Okta default logo.
[**DeleteEmailCustomization**](BrandApi.md#deleteemailcustomization) | **DELETE** /api/v1/brands/{brandId}/templates/email/{templateName}/customizations/{customizationId} | Delete Email Customization
[**GetAllEmailCustomizations**](BrandApi.md#getallemailcustomizations) | **GET** /api/v1/brands/{brandId}/templates/email/{templateName}/customizations | List Email Customizations
[**GetBrand**](BrandApi.md#getbrand) | **GET** /api/v1/brands/{brandId} | Get Brand
[**GetBrandTheme**](BrandApi.md#getbrandtheme) | **GET** /api/v1/brands/{brandId}/themes/{themeId} | Get a theme for a brand
[**GetEmailCustomization**](BrandApi.md#getemailcustomization) | **GET** /api/v1/brands/{brandId}/templates/email/{templateName}/customizations/{customizationId} | Get Email Customization
[**GetEmailTemplate**](BrandApi.md#getemailtemplate) | **GET** /api/v1/brands/{brandId}/templates/email/{templateName} | Get Email Template
[**GetEmailTemplateDefaultContent**](BrandApi.md#getemailtemplatedefaultcontent) | **GET** /api/v1/brands/{brandId}/templates/email/{templateName}/default-content | Get Default Content of Email Template
[**ListBrandThemes**](BrandApi.md#listbrandthemes) | **GET** /api/v1/brands/{brandId}/themes | Get Brand Themes
[**ListBrands**](BrandApi.md#listbrands) | **GET** /api/v1/brands | List Brands
[**ListEmailTemplates**](BrandApi.md#listemailtemplates) | **GET** /api/v1/brands/{brandId}/templates/email | List Email Templates
[**PreviewEmailCustomizationContent**](BrandApi.md#previewemailcustomizationcontent) | **GET** /api/v1/brands/{brandId}/templates/email/{templateName}/customizations/{customizationId}/preview | Get Preview Content of Email Customization
[**PreviewEmailDefaultContent**](BrandApi.md#previewemaildefaultcontent) | **GET** /api/v1/brands/{brandId}/templates/email/{templateName}/default-content/preview | Get Preview of Email Template Default Content
[**SendTestEmailFromTemplate**](BrandApi.md#sendtestemailfromtemplate) | **POST** /api/v1/brands/{brandId}/templates/email/{templateName}/test | Send Test Email
[**UpdateBrand**](BrandApi.md#updatebrand) | **PUT** /api/v1/brands/{brandId} | Update Brand
[**UpdateBrandTheme**](BrandApi.md#updatebrandtheme) | **PUT** /api/v1/brands/{brandId}/themes/{themeId} | Update a theme for a brand
[**UpdateEmailCustomization**](BrandApi.md#updateemailcustomization) | **PUT** /api/v1/brands/{brandId}/templates/email/{templateName}/customizations/{customizationId} | Update Email Customization
[**UploadBrandThemeBackgroundImage**](BrandApi.md#uploadbrandthemebackgroundimage) | **POST** /api/v1/brands/{brandId}/themes/{themeId}/background-image | Updates the background image for your Theme
[**UploadBrandThemeFavicon**](BrandApi.md#uploadbrandthemefavicon) | **POST** /api/v1/brands/{brandId}/themes/{themeId}/favicon | Updates the favicon for your theme
[**UploadBrandThemeLogo**](BrandApi.md#uploadbrandthemelogo) | **POST** /api/v1/brands/{brandId}/themes/{themeId}/logo | Update a themes logo

<a name="createemailcustomization"></a>
# **CreateEmailCustomization**
> EmailCustomization CreateEmailCustomization (string brandId, string templateName, EmailCustomization body = null)

Create Email Customization

Create an email customization

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateEmailCustomizationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var templateName = templateName_example;  // string | 
            var body = new EmailCustomization(); // EmailCustomization |  (optional) 

            try
            {
                // Create Email Customization
                EmailCustomization result = apiInstance.CreateEmailCustomization(brandId, templateName, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.CreateEmailCustomization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **templateName** | **string**|  | 
 **body** | [**EmailCustomization**](EmailCustomization.md)|  | [optional] 

### Return type

[**EmailCustomization**](EmailCustomization.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteallcustomizations"></a>
# **DeleteAllCustomizations**
> void DeleteAllCustomizations (string brandId, string templateName)

Delete Email Customizations

Delete all customizations for an email template. Also known as “Reset to Default”.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteAllCustomizationsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var templateName = templateName_example;  // string | 

            try
            {
                // Delete Email Customizations
                apiInstance.DeleteAllCustomizations(brandId, templateName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.DeleteAllCustomizations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **templateName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletebrandthemebackgroundimage"></a>
# **DeleteBrandThemeBackgroundImage**
> void DeleteBrandThemeBackgroundImage (string brandId, string themeId)

Deletes a Theme background image

Deletes a Theme background image

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteBrandThemeBackgroundImageExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var themeId = themeId_example;  // string | 

            try
            {
                // Deletes a Theme background image
                apiInstance.DeleteBrandThemeBackgroundImage(brandId, themeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.DeleteBrandThemeBackgroundImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **themeId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletebrandthemefavicon"></a>
# **DeleteBrandThemeFavicon**
> void DeleteBrandThemeFavicon (string brandId, string themeId)

Deletes a Theme favicon. The org then uses the Okta default favicon.

Deletes a Theme favicon. The org then uses the Okta default favicon.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteBrandThemeFaviconExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var themeId = themeId_example;  // string | 

            try
            {
                // Deletes a Theme favicon. The org then uses the Okta default favicon.
                apiInstance.DeleteBrandThemeFavicon(brandId, themeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.DeleteBrandThemeFavicon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **themeId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletebrandthemelogo"></a>
# **DeleteBrandThemeLogo**
> void DeleteBrandThemeLogo (string brandId, string themeId)

Deletes a Theme logo. The org then uses the Okta default logo.

Deletes a Theme logo. The org then uses the Okta default logo.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteBrandThemeLogoExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var themeId = themeId_example;  // string | 

            try
            {
                // Deletes a Theme logo. The org then uses the Okta default logo.
                apiInstance.DeleteBrandThemeLogo(brandId, themeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.DeleteBrandThemeLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **themeId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteemailcustomization"></a>
# **DeleteEmailCustomization**
> void DeleteEmailCustomization (string brandId, string templateName, string customizationId)

Delete Email Customization

Delete an email customization

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteEmailCustomizationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var templateName = templateName_example;  // string | 
            var customizationId = customizationId_example;  // string | 

            try
            {
                // Delete Email Customization
                apiInstance.DeleteEmailCustomization(brandId, templateName, customizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.DeleteEmailCustomization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **templateName** | **string**|  | 
 **customizationId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallemailcustomizations"></a>
# **GetAllEmailCustomizations**
> List<EmailCustomization> GetAllEmailCustomizations (string brandId, string templateName)

List Email Customizations

List all email customcations for an email template

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetAllEmailCustomizationsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var templateName = templateName_example;  // string | 

            try
            {
                // List Email Customizations
                List&lt;EmailCustomization&gt; result = apiInstance.GetAllEmailCustomizations(brandId, templateName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.GetAllEmailCustomizations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **templateName** | **string**|  | 

### Return type

[**List<EmailCustomization>**](EmailCustomization.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbrand"></a>
# **GetBrand**
> Brand GetBrand (string brandId)

Get Brand

Fetches a brand by `brandId`

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetBrandExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 

            try
            {
                // Get Brand
                Brand result = apiInstance.GetBrand(brandId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.GetBrand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 

### Return type

[**Brand**](Brand.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbrandtheme"></a>
# **GetBrandTheme**
> ThemeResponse GetBrandTheme (string brandId, string themeId)

Get a theme for a brand

Fetches a theme for a brand

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetBrandThemeExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var themeId = themeId_example;  // string | 

            try
            {
                // Get a theme for a brand
                ThemeResponse result = apiInstance.GetBrandTheme(brandId, themeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.GetBrandTheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **themeId** | **string**|  | 

### Return type

[**ThemeResponse**](ThemeResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getemailcustomization"></a>
# **GetEmailCustomization**
> EmailCustomization GetEmailCustomization (string brandId, string templateName, string customizationId)

Get Email Customization

Fetch an email customization by `id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetEmailCustomizationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var templateName = templateName_example;  // string | 
            var customizationId = customizationId_example;  // string | 

            try
            {
                // Get Email Customization
                EmailCustomization result = apiInstance.GetEmailCustomization(brandId, templateName, customizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.GetEmailCustomization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **templateName** | **string**|  | 
 **customizationId** | **string**|  | 

### Return type

[**EmailCustomization**](EmailCustomization.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getemailtemplate"></a>
# **GetEmailTemplate**
> EmailTemplate GetEmailTemplate (string brandId, string templateName)

Get Email Template

Fetch an email template by `templateName`

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetEmailTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var templateName = templateName_example;  // string | 

            try
            {
                // Get Email Template
                EmailTemplate result = apiInstance.GetEmailTemplate(brandId, templateName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.GetEmailTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **templateName** | **string**|  | 

### Return type

[**EmailTemplate**](EmailTemplate.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getemailtemplatedefaultcontent"></a>
# **GetEmailTemplateDefaultContent**
> EmailDefaultContent GetEmailTemplateDefaultContent (string brandId, string templateName)

Get Default Content of Email Template

Fetch the default content for an email template.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetEmailTemplateDefaultContentExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var templateName = templateName_example;  // string | 

            try
            {
                // Get Default Content of Email Template
                EmailDefaultContent result = apiInstance.GetEmailTemplateDefaultContent(brandId, templateName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.GetEmailTemplateDefaultContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **templateName** | **string**|  | 

### Return type

[**EmailDefaultContent**](EmailDefaultContent.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listbrandthemes"></a>
# **ListBrandThemes**
> List<ThemeResponse> ListBrandThemes (string brandId)

Get Brand Themes

List all the themes in your brand

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListBrandThemesExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 

            try
            {
                // Get Brand Themes
                List&lt;ThemeResponse&gt; result = apiInstance.ListBrandThemes(brandId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.ListBrandThemes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 

### Return type

[**List<ThemeResponse>**](ThemeResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listbrands"></a>
# **ListBrands**
> List<Brand> ListBrands ()

List Brands

List all the brands in your org.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListBrandsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();

            try
            {
                // List Brands
                List&lt;Brand&gt; result = apiInstance.ListBrands();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.ListBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Brand>**](Brand.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listemailtemplates"></a>
# **ListEmailTemplates**
> List<EmailTemplate> ListEmailTemplates (string brandId, string after = null, int? limit = null)

List Email Templates

List email templates in your organization with pagination.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListEmailTemplatesExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | brand id
            var after = after_example;  // string | Specifies the pagination cursor for the next page of email templates. (optional) 
            var limit = 56;  // int? | Specifies the number of results returned (maximum 200) (optional) 

            try
            {
                // List Email Templates
                List&lt;EmailTemplate&gt; result = apiInstance.ListEmailTemplates(brandId, after, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.ListEmailTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**| brand id | 
 **after** | **string**| Specifies the pagination cursor for the next page of email templates. | [optional] 
 **limit** | **int?**| Specifies the number of results returned (maximum 200) | [optional] 

### Return type

[**List<EmailTemplate>**](EmailTemplate.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="previewemailcustomizationcontent"></a>
# **PreviewEmailCustomizationContent**
> EmailPreview PreviewEmailCustomizationContent (string brandId, string templateName, string customizationId)

Get Preview Content of Email Customization

Get a preview of an email template customization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class PreviewEmailCustomizationContentExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var templateName = templateName_example;  // string | 
            var customizationId = customizationId_example;  // string | 

            try
            {
                // Get Preview Content of Email Customization
                EmailPreview result = apiInstance.PreviewEmailCustomizationContent(brandId, templateName, customizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.PreviewEmailCustomizationContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **templateName** | **string**|  | 
 **customizationId** | **string**|  | 

### Return type

[**EmailPreview**](EmailPreview.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="previewemaildefaultcontent"></a>
# **PreviewEmailDefaultContent**
> EmailPreview PreviewEmailDefaultContent (string brandId, string templateName)

Get Preview of Email Template Default Content

Fetch a preview of an email template's default content by populating velocity references with the current user's environment.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class PreviewEmailDefaultContentExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var templateName = templateName_example;  // string | 

            try
            {
                // Get Preview of Email Template Default Content
                EmailPreview result = apiInstance.PreviewEmailDefaultContent(brandId, templateName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.PreviewEmailDefaultContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **templateName** | **string**|  | 

### Return type

[**EmailPreview**](EmailPreview.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sendtestemailfromtemplate"></a>
# **SendTestEmailFromTemplate**
> void SendTestEmailFromTemplate (string templateName, string brandId, EmailTestResponse body = null)

Send Test Email

Send a test email to the current user’s primary and secondary email addresses. The email content is selected based on the following priority: 1. An email customization specifically for the user’s locale. 2. The default language of email customizations. 3. The email template’s default content.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class SendTestEmailFromTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var templateName = templateName_example;  // string | 
            var brandId = brandId_example;  // string | 
            var body = new EmailTestResponse(); // EmailTestResponse |  (optional) 

            try
            {
                // Send Test Email
                apiInstance.SendTestEmailFromTemplate(templateName, brandId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.SendTestEmailFromTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateName** | **string**|  | 
 **brandId** | **string**|  | 
 **body** | [**EmailTestResponse**](EmailTestResponse.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatebrand"></a>
# **UpdateBrand**
> Brand UpdateBrand (string brandId, Brand body = null)

Update Brand

Updates a brand by `brandId`

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateBrandExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var body = new Brand(); // Brand |  (optional) 

            try
            {
                // Update Brand
                Brand result = apiInstance.UpdateBrand(brandId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.UpdateBrand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **body** | [**Brand**](Brand.md)|  | [optional] 

### Return type

[**Brand**](Brand.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatebrandtheme"></a>
# **UpdateBrandTheme**
> ThemeResponse UpdateBrandTheme (string brandId, string themeId, Theme body = null)

Update a theme for a brand

Updates a theme for a brand

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateBrandThemeExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var themeId = themeId_example;  // string | 
            var body = new Theme(); // Theme |  (optional) 

            try
            {
                // Update a theme for a brand
                ThemeResponse result = apiInstance.UpdateBrandTheme(brandId, themeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.UpdateBrandTheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **themeId** | **string**|  | 
 **body** | [**Theme**](Theme.md)|  | [optional] 

### Return type

[**ThemeResponse**](ThemeResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateemailcustomization"></a>
# **UpdateEmailCustomization**
> EmailCustomization UpdateEmailCustomization (string brandId, string templateName, string customizationId, EmailCustomization body = null)

Update Email Customization

Update an email customization

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateEmailCustomizationExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var templateName = templateName_example;  // string | 
            var customizationId = customizationId_example;  // string | 
            var body = new EmailCustomization(); // EmailCustomization | Request (optional) 

            try
            {
                // Update Email Customization
                EmailCustomization result = apiInstance.UpdateEmailCustomization(brandId, templateName, customizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.UpdateEmailCustomization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **templateName** | **string**|  | 
 **customizationId** | **string**|  | 
 **body** | [**EmailCustomization**](EmailCustomization.md)| Request | [optional] 

### Return type

[**EmailCustomization**](EmailCustomization.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadbrandthemebackgroundimage"></a>
# **UploadBrandThemeBackgroundImage**
> ImageUploadResponse UploadBrandThemeBackgroundImage (string brandId, string themeId)

Updates the background image for your Theme

Updates the background image for your Theme

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UploadBrandThemeBackgroundImageExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var themeId = themeId_example;  // string | 

            try
            {
                // Updates the background image for your Theme
                ImageUploadResponse result = apiInstance.UploadBrandThemeBackgroundImage(brandId, themeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.UploadBrandThemeBackgroundImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **themeId** | **string**|  | 

### Return type

[**ImageUploadResponse**](ImageUploadResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadbrandthemefavicon"></a>
# **UploadBrandThemeFavicon**
> ImageUploadResponse UploadBrandThemeFavicon (string brandId, string themeId)

Updates the favicon for your theme

Updates the favicon for your theme

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UploadBrandThemeFaviconExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var themeId = themeId_example;  // string | 

            try
            {
                // Updates the favicon for your theme
                ImageUploadResponse result = apiInstance.UploadBrandThemeFavicon(brandId, themeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.UploadBrandThemeFavicon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **themeId** | **string**|  | 

### Return type

[**ImageUploadResponse**](ImageUploadResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadbrandthemelogo"></a>
# **UploadBrandThemeLogo**
> ImageUploadResponse UploadBrandThemeLogo (string brandId, string themeId)

Update a themes logo

Updates the logo for your Theme

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UploadBrandThemeLogoExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BrandApi();
            var brandId = brandId_example;  // string | 
            var themeId = themeId_example;  // string | 

            try
            {
                // Update a themes logo
                ImageUploadResponse result = apiInstance.UploadBrandThemeLogo(brandId, themeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandApi.UploadBrandThemeLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **string**|  | 
 **themeId** | **string**|  | 

### Return type

[**ImageUploadResponse**](ImageUploadResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
