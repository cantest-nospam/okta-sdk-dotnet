# Okta.Sdk.Api.PolicyApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivatePolicy**](PolicyApi.md#activatepolicy) | **POST** /api/v1/policies/{policyId}/lifecycle/activate | 
[**ActivatePolicyRule**](PolicyApi.md#activatepolicyrule) | **POST** /api/v1/policies/{policyId}/rules/{ruleId}/lifecycle/activate | 
[**CreatePolicy**](PolicyApi.md#createpolicy) | **POST** /api/v1/policies | 
[**CreatePolicyRule**](PolicyApi.md#createpolicyrule) | **POST** /api/v1/policies/{policyId}/rules | 
[**DeactivatePolicy**](PolicyApi.md#deactivatepolicy) | **POST** /api/v1/policies/{policyId}/lifecycle/deactivate | 
[**DeactivatePolicyRule**](PolicyApi.md#deactivatepolicyrule) | **POST** /api/v1/policies/{policyId}/rules/{ruleId}/lifecycle/deactivate | 
[**DeletePolicy**](PolicyApi.md#deletepolicy) | **DELETE** /api/v1/policies/{policyId} | 
[**DeletePolicyRule**](PolicyApi.md#deletepolicyrule) | **DELETE** /api/v1/policies/{policyId}/rules/{ruleId} | 
[**GetPolicy**](PolicyApi.md#getpolicy) | **GET** /api/v1/policies/{policyId} | 
[**GetPolicyRule**](PolicyApi.md#getpolicyrule) | **GET** /api/v1/policies/{policyId}/rules/{ruleId} | 
[**ListPolicies**](PolicyApi.md#listpolicies) | **GET** /api/v1/policies | 
[**ListPolicyRules**](PolicyApi.md#listpolicyrules) | **GET** /api/v1/policies/{policyId}/rules | 
[**UpdatePolicy**](PolicyApi.md#updatepolicy) | **PUT** /api/v1/policies/{policyId} | 
[**UpdatePolicyRule**](PolicyApi.md#updatepolicyrule) | **PUT** /api/v1/policies/{policyId}/rules/{ruleId} | 

<a name="activatepolicy"></a>
# **ActivatePolicy**
> void ActivatePolicy (string policyId)



Activates a policy.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ActivatePolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var policyId = policyId_example;  // string | 

            try
            {
                apiInstance.ActivatePolicy(policyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.ActivatePolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="activatepolicyrule"></a>
# **ActivatePolicyRule**
> void ActivatePolicyRule (string policyId, string ruleId)



Activates a policy rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ActivatePolicyRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var policyId = policyId_example;  // string | 
            var ruleId = ruleId_example;  // string | 

            try
            {
                apiInstance.ActivatePolicyRule(policyId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.ActivatePolicyRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**|  | 
 **ruleId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createpolicy"></a>
# **CreatePolicy**
> Policy CreatePolicy (Policy body, bool? activate = null)



Creates a policy.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreatePolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var body = new Policy(); // Policy | 
            var activate = true;  // bool? |  (optional)  (default to true)

            try
            {
                Policy result = apiInstance.CreatePolicy(body, activate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.CreatePolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Policy**](Policy.md)|  | 
 **activate** | **bool?**|  | [optional] [default to true]

### Return type

[**Policy**](Policy.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createpolicyrule"></a>
# **CreatePolicyRule**
> PolicyRule CreatePolicyRule (PolicyRule body, string policyId)



Creates a policy rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreatePolicyRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var body = new PolicyRule(); // PolicyRule | 
            var policyId = policyId_example;  // string | 

            try
            {
                PolicyRule result = apiInstance.CreatePolicyRule(body, policyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.CreatePolicyRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PolicyRule**](PolicyRule.md)|  | 
 **policyId** | **string**|  | 

### Return type

[**PolicyRule**](PolicyRule.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deactivatepolicy"></a>
# **DeactivatePolicy**
> void DeactivatePolicy (string policyId)



Deactivates a policy.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeactivatePolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var policyId = policyId_example;  // string | 

            try
            {
                apiInstance.DeactivatePolicy(policyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.DeactivatePolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deactivatepolicyrule"></a>
# **DeactivatePolicyRule**
> void DeactivatePolicyRule (string policyId, string ruleId)



Deactivates a policy rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeactivatePolicyRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var policyId = policyId_example;  // string | 
            var ruleId = ruleId_example;  // string | 

            try
            {
                apiInstance.DeactivatePolicyRule(policyId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.DeactivatePolicyRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**|  | 
 **ruleId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepolicy"></a>
# **DeletePolicy**
> void DeletePolicy (string policyId)



Removes a policy.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeletePolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var policyId = policyId_example;  // string | 

            try
            {
                apiInstance.DeletePolicy(policyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.DeletePolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepolicyrule"></a>
# **DeletePolicyRule**
> void DeletePolicyRule (string policyId, string ruleId)



Removes a policy rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeletePolicyRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var policyId = policyId_example;  // string | 
            var ruleId = ruleId_example;  // string | 

            try
            {
                apiInstance.DeletePolicyRule(policyId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.DeletePolicyRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**|  | 
 **ruleId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpolicy"></a>
# **GetPolicy**
> Policy GetPolicy (string policyId, string expand = null)



Gets a policy.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var policyId = policyId_example;  // string | 
            var expand = expand_example;  // string |  (optional) 

            try
            {
                Policy result = apiInstance.GetPolicy(policyId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.GetPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**|  | 
 **expand** | **string**|  | [optional] 

### Return type

[**Policy**](Policy.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpolicyrule"></a>
# **GetPolicyRule**
> PolicyRule GetPolicyRule (string policyId, string ruleId)



Gets a policy rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetPolicyRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var policyId = policyId_example;  // string | 
            var ruleId = ruleId_example;  // string | 

            try
            {
                PolicyRule result = apiInstance.GetPolicyRule(policyId, ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.GetPolicyRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**|  | 
 **ruleId** | **string**|  | 

### Return type

[**PolicyRule**](PolicyRule.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listpolicies"></a>
# **ListPolicies**
> List<Policy> ListPolicies (string type, string status = null, string expand = null)



Gets all policies with the specified type.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListPoliciesExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var type = type_example;  // string | 
            var status = status_example;  // string |  (optional) 
            var expand = expand_example;  // string |  (optional) 

            try
            {
                List&lt;Policy&gt; result = apiInstance.ListPolicies(type, status, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.ListPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|  | 
 **status** | **string**|  | [optional] 
 **expand** | **string**|  | [optional] 

### Return type

[**List<Policy>**](Policy.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listpolicyrules"></a>
# **ListPolicyRules**
> List<PolicyRule> ListPolicyRules (string policyId)



Enumerates all policy rules.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListPolicyRulesExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var policyId = policyId_example;  // string | 

            try
            {
                List&lt;PolicyRule&gt; result = apiInstance.ListPolicyRules(policyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.ListPolicyRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**|  | 

### Return type

[**List<PolicyRule>**](PolicyRule.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatepolicy"></a>
# **UpdatePolicy**
> Policy UpdatePolicy (Policy body, string policyId)



Updates a policy.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdatePolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var body = new Policy(); // Policy | 
            var policyId = policyId_example;  // string | 

            try
            {
                Policy result = apiInstance.UpdatePolicy(body, policyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.UpdatePolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Policy**](Policy.md)|  | 
 **policyId** | **string**|  | 

### Return type

[**Policy**](Policy.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatepolicyrule"></a>
# **UpdatePolicyRule**
> PolicyRule UpdatePolicyRule (PolicyRule body, string policyId, string ruleId)



Updates a policy rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class UpdatePolicyRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PolicyApi();
            var body = new PolicyRule(); // PolicyRule | 
            var policyId = policyId_example;  // string | 
            var ruleId = ruleId_example;  // string | 

            try
            {
                PolicyRule result = apiInstance.UpdatePolicyRule(body, policyId, ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PolicyApi.UpdatePolicyRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PolicyRule**](PolicyRule.md)|  | 
 **policyId** | **string**|  | 
 **ruleId** | **string**|  | 

### Return type

[**PolicyRule**](PolicyRule.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
