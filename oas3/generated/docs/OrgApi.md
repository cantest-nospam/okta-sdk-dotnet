# Okta.Sdk.Api.OrgApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExtendOktaSupport**](OrgApi.md#extendoktasupport) | **POST** /api/v1/org/privacy/oktaSupport/extend | Extend Okta Support
[**GetOktaCommunicationSettings**](OrgApi.md#getoktacommunicationsettings) | **GET** /api/v1/org/privacy/oktaCommunication | Get Okta Communication Settings
[**GetOrgContactTypes**](OrgApi.md#getorgcontacttypes) | **GET** /api/v1/org/contacts | Get org contact types
[**GetOrgContactUser**](OrgApi.md#getorgcontactuser) | **GET** /api/v1/org/contacts/{contactType} | Get org contact user
[**GetOrgOktaSupportSettings**](OrgApi.md#getorgoktasupportsettings) | **GET** /api/v1/org/privacy/oktaSupport | Get Okta Support settings
[**GetOrgPreferences**](OrgApi.md#getorgpreferences) | **GET** /api/v1/org/preferences | Get org preferences
[**GetOrgSettings**](OrgApi.md#getorgsettings) | **GET** /api/v1/org | Get org settings
[**GrantOktaSupport**](OrgApi.md#grantoktasupport) | **POST** /api/v1/org/privacy/oktaSupport/grant | Grant Okta Support
[**HideOktaUIFooter**](OrgApi.md#hideoktauifooter) | **POST** /api/v1/org/preferences/hideEndUserFooter | Show Okta UI Footer
[**OptInUsersToOktaCommunicationEmails**](OrgApi.md#optinuserstooktacommunicationemails) | **POST** /api/v1/org/privacy/oktaCommunication/optIn | Opt in all users to Okta Communication emails
[**OptOutUsersFromOktaCommunicationEmails**](OrgApi.md#optoutusersfromoktacommunicationemails) | **POST** /api/v1/org/privacy/oktaCommunication/optOut | Opt out all users from Okta Communication emails
[**PartialUpdateOrgSetting**](OrgApi.md#partialupdateorgsetting) | **POST** /api/v1/org | Partial update Org Setting
[**RevokeOktaSupport**](OrgApi.md#revokeoktasupport) | **POST** /api/v1/org/privacy/oktaSupport/revoke | Extend Okta Support
[**ShowOktaUIFooter**](OrgApi.md#showoktauifooter) | **POST** /api/v1/org/preferences/showEndUserFooter | Show Okta UI Footer
[**UpdateOrgContactUser**](OrgApi.md#updateorgcontactuser) | **PUT** /api/v1/org/contacts/{contactType} | Update org contact user
[**UpdateOrgLogo**](OrgApi.md#updateorglogo) | **POST** /api/v1/org/logo | Update org logo
[**UpdateOrgSetting**](OrgApi.md#updateorgsetting) | **PUT** /api/v1/org | Update Org setting

<a name="extendoktasupport"></a>
# **ExtendOktaSupport**
> OrgOktaSupportSettingsObj ExtendOktaSupport ()

Extend Okta Support

Extends the length of time that Okta Support can access your org by 24 hours. This means that 24 hours are added to the remaining access time.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ExtendOktaSupportExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Extend Okta Support
                OrgOktaSupportSettingsObj result = apiInstance.ExtendOktaSupport();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.ExtendOktaSupport: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrgOktaSupportSettingsObj**](OrgOktaSupportSettingsObj.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getoktacommunicationsettings"></a>
# **GetOktaCommunicationSettings**
> OrgOktaCommunicationSetting GetOktaCommunicationSettings ()

Get Okta Communication Settings

Gets Okta Communication Settings of your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetOktaCommunicationSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Get Okta Communication Settings
                OrgOktaCommunicationSetting result = apiInstance.GetOktaCommunicationSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.GetOktaCommunicationSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrgOktaCommunicationSetting**](OrgOktaCommunicationSetting.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorgcontacttypes"></a>
# **GetOrgContactTypes**
> List<OrgContactTypeObj> GetOrgContactTypes ()

Get org contact types

Gets Contact Types of your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetOrgContactTypesExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Get org contact types
                List&lt;OrgContactTypeObj&gt; result = apiInstance.GetOrgContactTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.GetOrgContactTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<OrgContactTypeObj>**](OrgContactTypeObj.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorgcontactuser"></a>
# **GetOrgContactUser**
> OrgContactUser GetOrgContactUser (string contactType)

Get org contact user

Retrieves the URL of the User associated with the specified Contact Type.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetOrgContactUserExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();
            var contactType = contactType_example;  // string | 

            try
            {
                // Get org contact user
                OrgContactUser result = apiInstance.GetOrgContactUser(contactType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.GetOrgContactUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactType** | **string**|  | 

### Return type

[**OrgContactUser**](OrgContactUser.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorgoktasupportsettings"></a>
# **GetOrgOktaSupportSettings**
> OrgOktaSupportSettingsObj GetOrgOktaSupportSettings ()

Get Okta Support settings

Gets Okta Support Settings of your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetOrgOktaSupportSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Get Okta Support settings
                OrgOktaSupportSettingsObj result = apiInstance.GetOrgOktaSupportSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.GetOrgOktaSupportSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrgOktaSupportSettingsObj**](OrgOktaSupportSettingsObj.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorgpreferences"></a>
# **GetOrgPreferences**
> OrgPreferences GetOrgPreferences ()

Get org preferences

Gets preferences of your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetOrgPreferencesExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Get org preferences
                OrgPreferences result = apiInstance.GetOrgPreferences();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.GetOrgPreferences: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrgPreferences**](OrgPreferences.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorgsettings"></a>
# **GetOrgSettings**
> OrgSetting GetOrgSettings ()

Get org settings

Get settings of your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetOrgSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Get org settings
                OrgSetting result = apiInstance.GetOrgSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.GetOrgSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrgSetting**](OrgSetting.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="grantoktasupport"></a>
# **GrantOktaSupport**
> OrgOktaSupportSettingsObj GrantOktaSupport ()

Grant Okta Support

Enables you to temporarily allow Okta Support to access your org as an administrator for eight hours.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GrantOktaSupportExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Grant Okta Support
                OrgOktaSupportSettingsObj result = apiInstance.GrantOktaSupport();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.GrantOktaSupport: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrgOktaSupportSettingsObj**](OrgOktaSupportSettingsObj.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="hideoktauifooter"></a>
# **HideOktaUIFooter**
> OrgPreferences HideOktaUIFooter ()

Show Okta UI Footer

Hide the Okta UI footer for all end users of your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class HideOktaUIFooterExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Show Okta UI Footer
                OrgPreferences result = apiInstance.HideOktaUIFooter();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.HideOktaUIFooter: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrgPreferences**](OrgPreferences.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="optinuserstooktacommunicationemails"></a>
# **OptInUsersToOktaCommunicationEmails**
> OrgOktaCommunicationSetting OptInUsersToOktaCommunicationEmails ()

Opt in all users to Okta Communication emails

Opts in all users of this org to Okta Communication emails.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class OptInUsersToOktaCommunicationEmailsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Opt in all users to Okta Communication emails
                OrgOktaCommunicationSetting result = apiInstance.OptInUsersToOktaCommunicationEmails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.OptInUsersToOktaCommunicationEmails: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrgOktaCommunicationSetting**](OrgOktaCommunicationSetting.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="optoutusersfromoktacommunicationemails"></a>
# **OptOutUsersFromOktaCommunicationEmails**
> OrgOktaCommunicationSetting OptOutUsersFromOktaCommunicationEmails ()

Opt out all users from Okta Communication emails

Opts out all users of this org from Okta Communication emails.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class OptOutUsersFromOktaCommunicationEmailsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Opt out all users from Okta Communication emails
                OrgOktaCommunicationSetting result = apiInstance.OptOutUsersFromOktaCommunicationEmails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.OptOutUsersFromOktaCommunicationEmails: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrgOktaCommunicationSetting**](OrgOktaCommunicationSetting.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="partialupdateorgsetting"></a>
# **PartialUpdateOrgSetting**
> OrgSetting PartialUpdateOrgSetting (OrgSetting body = null)

Partial update Org Setting

Partial update settings of your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class PartialUpdateOrgSettingExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();
            var body = new OrgSetting(); // OrgSetting |  (optional) 

            try
            {
                // Partial update Org Setting
                OrgSetting result = apiInstance.PartialUpdateOrgSetting(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.PartialUpdateOrgSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrgSetting**](OrgSetting.md)|  | [optional] 

### Return type

[**OrgSetting**](OrgSetting.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="revokeoktasupport"></a>
# **RevokeOktaSupport**
> OrgOktaSupportSettingsObj RevokeOktaSupport ()

Extend Okta Support

Revokes Okta Support access to your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class RevokeOktaSupportExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Extend Okta Support
                OrgOktaSupportSettingsObj result = apiInstance.RevokeOktaSupport();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.RevokeOktaSupport: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrgOktaSupportSettingsObj**](OrgOktaSupportSettingsObj.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="showoktauifooter"></a>
# **ShowOktaUIFooter**
> OrgPreferences ShowOktaUIFooter ()

Show Okta UI Footer

Makes the Okta UI footer visible for all end users of your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ShowOktaUIFooterExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Show Okta UI Footer
                OrgPreferences result = apiInstance.ShowOktaUIFooter();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.ShowOktaUIFooter: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrgPreferences**](OrgPreferences.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateorgcontactuser"></a>
# **UpdateOrgContactUser**
> OrgContactUser UpdateOrgContactUser (OrgContactUser body, string contactType)

Update org contact user

Updates the User associated with the specified Contact Type.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateOrgContactUserExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();
            var body = new OrgContactUser(); // OrgContactUser | 
            var contactType = contactType_example;  // string | 

            try
            {
                // Update org contact user
                OrgContactUser result = apiInstance.UpdateOrgContactUser(body, contactType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.UpdateOrgContactUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrgContactUser**](OrgContactUser.md)|  | 
 **contactType** | **string**|  | 

### Return type

[**OrgContactUser**](OrgContactUser.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateorglogo"></a>
# **UpdateOrgLogo**
> void UpdateOrgLogo ()

Update org logo

Updates the logo for your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateOrgLogoExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();

            try
            {
                // Update org logo
                apiInstance.UpdateOrgLogo();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.UpdateOrgLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateorgsetting"></a>
# **UpdateOrgSetting**
> OrgSetting UpdateOrgSetting (OrgSetting body)

Update Org setting

Update settings of your organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdateOrgSettingExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrgApi();
            var body = new OrgSetting(); // OrgSetting | 

            try
            {
                // Update Org setting
                OrgSetting result = apiInstance.UpdateOrgSetting(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgApi.UpdateOrgSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrgSetting**](OrgSetting.md)|  | 

### Return type

[**OrgSetting**](OrgSetting.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
