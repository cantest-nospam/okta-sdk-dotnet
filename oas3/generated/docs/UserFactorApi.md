# Okta.Sdk.Api.UserFactorApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateFactor**](UserFactorApi.md#activatefactor) | **POST** /api/v1/users/{userId}/factors/{factorId}/lifecycle/activate | Activate Factor
[**DeleteFactor**](UserFactorApi.md#deletefactor) | **DELETE** /api/v1/users/{userId}/factors/{factorId} | 
[**EnrollFactor**](UserFactorApi.md#enrollfactor) | **POST** /api/v1/users/{userId}/factors | Enroll Factor
[**GetFactor**](UserFactorApi.md#getfactor) | **GET** /api/v1/users/{userId}/factors/{factorId} | 
[**GetFactorTransactionStatus**](UserFactorApi.md#getfactortransactionstatus) | **GET** /api/v1/users/{userId}/factors/{factorId}/transactions/{transactionId} | 
[**ListFactors**](UserFactorApi.md#listfactors) | **GET** /api/v1/users/{userId}/factors | 
[**ListSupportedFactors**](UserFactorApi.md#listsupportedfactors) | **GET** /api/v1/users/{userId}/factors/catalog | 
[**ListSupportedSecurityQuestions**](UserFactorApi.md#listsupportedsecurityquestions) | **GET** /api/v1/users/{userId}/factors/questions | 
[**VerifyFactor**](UserFactorApi.md#verifyfactor) | **POST** /api/v1/users/{userId}/factors/{factorId}/verify | Verify MFA Factor

<a name="activatefactor"></a>
# **ActivateFactor**
> UserFactor ActivateFactor (string userId, string factorId, ActivateFactorRequest body = null)

Activate Factor

The `sms` and `token:software:totp` factor types require activation to complete the enrollment process.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ActivateFactorExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserFactorApi();
            var userId = userId_example;  // string | 
            var factorId = factorId_example;  // string | 
            var body = new ActivateFactorRequest(); // ActivateFactorRequest |  (optional) 

            try
            {
                // Activate Factor
                UserFactor result = apiInstance.ActivateFactor(userId, factorId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserFactorApi.ActivateFactor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **factorId** | **string**|  | 
 **body** | [**ActivateFactorRequest**](ActivateFactorRequest.md)|  | [optional] 

### Return type

[**UserFactor**](UserFactor.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletefactor"></a>
# **DeleteFactor**
> void DeleteFactor (string userId, string factorId)



Unenrolls an existing factor for the specified user, allowing the user to enroll a new factor.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteFactorExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserFactorApi();
            var userId = userId_example;  // string | 
            var factorId = factorId_example;  // string | 

            try
            {
                apiInstance.DeleteFactor(userId, factorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserFactorApi.DeleteFactor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **factorId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="enrollfactor"></a>
# **EnrollFactor**
> UserFactor EnrollFactor (UserFactor body, string userId, bool? updatePhone = null, string templateId = null, int? tokenLifetimeSeconds = null, bool? activate = null)

Enroll Factor

Enrolls a user with a supported factor.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class EnrollFactorExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserFactorApi();
            var body = new UserFactor(); // UserFactor | Factor
            var userId = userId_example;  // string | 
            var updatePhone = true;  // bool? |  (optional)  (default to false)
            var templateId = templateId_example;  // string | id of SMS template (only for SMS factor) (optional) 
            var tokenLifetimeSeconds = 56;  // int? |  (optional) 
            var activate = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Enroll Factor
                UserFactor result = apiInstance.EnrollFactor(body, userId, updatePhone, templateId, tokenLifetimeSeconds, activate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserFactorApi.EnrollFactor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserFactor**](UserFactor.md)| Factor | 
 **userId** | **string**|  | 
 **updatePhone** | **bool?**|  | [optional] [default to false]
 **templateId** | **string**| id of SMS template (only for SMS factor) | [optional] 
 **tokenLifetimeSeconds** | **int?**|  | [optional] 
 **activate** | **bool?**|  | [optional] [default to false]

### Return type

[**UserFactor**](UserFactor.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getfactor"></a>
# **GetFactor**
> UserFactor GetFactor (string userId, string factorId)



Fetches a factor for the specified user

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetFactorExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserFactorApi();
            var userId = userId_example;  // string | 
            var factorId = factorId_example;  // string | 

            try
            {
                UserFactor result = apiInstance.GetFactor(userId, factorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserFactorApi.GetFactor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **factorId** | **string**|  | 

### Return type

[**UserFactor**](UserFactor.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getfactortransactionstatus"></a>
# **GetFactorTransactionStatus**
> VerifyUserFactorResponse GetFactorTransactionStatus (string userId, string factorId, string transactionId)



Polls factors verification transaction for status.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetFactorTransactionStatusExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserFactorApi();
            var userId = userId_example;  // string | 
            var factorId = factorId_example;  // string | 
            var transactionId = transactionId_example;  // string | 

            try
            {
                VerifyUserFactorResponse result = apiInstance.GetFactorTransactionStatus(userId, factorId, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserFactorApi.GetFactorTransactionStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **factorId** | **string**|  | 
 **transactionId** | **string**|  | 

### Return type

[**VerifyUserFactorResponse**](VerifyUserFactorResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listfactors"></a>
# **ListFactors**
> List<UserFactor> ListFactors (string userId)



Enumerates all the enrolled factors for the specified user

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListFactorsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserFactorApi();
            var userId = userId_example;  // string | 

            try
            {
                List&lt;UserFactor&gt; result = apiInstance.ListFactors(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserFactorApi.ListFactors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

[**List<UserFactor>**](UserFactor.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listsupportedfactors"></a>
# **ListSupportedFactors**
> List<UserFactor> ListSupportedFactors (string userId)



Enumerates all the supported factors that can be enrolled for the specified user

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListSupportedFactorsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserFactorApi();
            var userId = userId_example;  // string | 

            try
            {
                List&lt;UserFactor&gt; result = apiInstance.ListSupportedFactors(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserFactorApi.ListSupportedFactors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

[**List<UserFactor>**](UserFactor.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listsupportedsecurityquestions"></a>
# **ListSupportedSecurityQuestions**
> List<SecurityQuestion> ListSupportedSecurityQuestions (string userId)



Enumerates all available security questions for a user's `question` factor

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListSupportedSecurityQuestionsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserFactorApi();
            var userId = userId_example;  // string | 

            try
            {
                List&lt;SecurityQuestion&gt; result = apiInstance.ListSupportedSecurityQuestions(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserFactorApi.ListSupportedSecurityQuestions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

[**List<SecurityQuestion>**](SecurityQuestion.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="verifyfactor"></a>
# **VerifyFactor**
> VerifyUserFactorResponse VerifyFactor (string userId, string factorId, VerifyFactorRequest body = null, string xForwardedFor = null, string userAgent = null, string acceptLanguage = null, string templateId = null, int? tokenLifetimeSeconds = null)

Verify MFA Factor

Verifies an OTP for a `token` or `token:hardware` factor

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class VerifyFactorExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserFactorApi();
            var userId = userId_example;  // string | 
            var factorId = factorId_example;  // string | 
            var body = new VerifyFactorRequest(); // VerifyFactorRequest |  (optional) 
            var xForwardedFor = xForwardedFor_example;  // string |  (optional) 
            var userAgent = userAgent_example;  // string |  (optional) 
            var acceptLanguage = acceptLanguage_example;  // string |  (optional) 
            var templateId = templateId_example;  // string |  (optional) 
            var tokenLifetimeSeconds = 56;  // int? |  (optional) 

            try
            {
                // Verify MFA Factor
                VerifyUserFactorResponse result = apiInstance.VerifyFactor(userId, factorId, body, xForwardedFor, userAgent, acceptLanguage, templateId, tokenLifetimeSeconds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserFactorApi.VerifyFactor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **factorId** | **string**|  | 
 **body** | [**VerifyFactorRequest**](VerifyFactorRequest.md)|  | [optional] 
 **xForwardedFor** | **string**|  | [optional] 
 **userAgent** | **string**|  | [optional] 
 **acceptLanguage** | **string**|  | [optional] 
 **templateId** | **string**|  | [optional] 
 **tokenLifetimeSeconds** | **int?**|  | [optional] 

### Return type

[**VerifyUserFactorResponse**](VerifyUserFactorResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
