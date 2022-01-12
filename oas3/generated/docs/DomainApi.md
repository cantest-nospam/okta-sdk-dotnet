# Okta.Sdk.Api.DomainApi

All URIs are relative to *https://{subdomain}.{domain}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCertificate**](DomainApi.md#createcertificate) | **PUT** /api/v1/domains/{domainId}/certificate | Create Certificate
[**CreateDomain**](DomainApi.md#createdomain) | **POST** /api/v1/domains | Create Domain
[**DeleteDomain**](DomainApi.md#deletedomain) | **DELETE** /api/v1/domains/{domainId} | Delete Domain
[**GetDomain**](DomainApi.md#getdomain) | **GET** /api/v1/domains/{domainId} | Get Domain
[**ListDomains**](DomainApi.md#listdomains) | **GET** /api/v1/domains | List Domains
[**VerifyDomain**](DomainApi.md#verifydomain) | **POST** /api/v1/domains/{domainId}/verify | Verify Domain

<a name="createcertificate"></a>
# **CreateCertificate**
> void CreateCertificate (DomainCertificate body, string domainId)

Create Certificate

Creates the Certificate for the Domain.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateCertificateExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DomainApi();
            var body = new DomainCertificate(); // DomainCertificate | 
            var domainId = domainId_example;  // string | 

            try
            {
                // Create Certificate
                apiInstance.CreateCertificate(body, domainId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.CreateCertificate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DomainCertificate**](DomainCertificate.md)|  | 
 **domainId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createdomain"></a>
# **CreateDomain**
> DomainResponse CreateDomain (Domain body)

Create Domain

Creates your domain.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class CreateDomainExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DomainApi();
            var body = new Domain(); // Domain | 

            try
            {
                // Create Domain
                DomainResponse result = apiInstance.CreateDomain(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.CreateDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Domain**](Domain.md)|  | 

### Return type

[**DomainResponse**](DomainResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletedomain"></a>
# **DeleteDomain**
> void DeleteDomain (string domainId)

Delete Domain

Deletes a Domain by `id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class DeleteDomainExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DomainApi();
            var domainId = domainId_example;  // string | 

            try
            {
                // Delete Domain
                apiInstance.DeleteDomain(domainId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DeleteDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domainId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdomain"></a>
# **GetDomain**
> DomainResponse GetDomain (string domainId)

Get Domain

Fetches a Domain by `id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class GetDomainExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DomainApi();
            var domainId = domainId_example;  // string | 

            try
            {
                // Get Domain
                DomainResponse result = apiInstance.GetDomain(domainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.GetDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domainId** | **string**|  | 

### Return type

[**DomainResponse**](DomainResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listdomains"></a>
# **ListDomains**
> DomainListResponse ListDomains ()

List Domains

List all verified custom Domains for the org.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class ListDomainsExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DomainApi();

            try
            {
                // List Domains
                DomainListResponse result = apiInstance.ListDomains();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.ListDomains: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DomainListResponse**](DomainListResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="verifydomain"></a>
# **VerifyDomain**
> DomainResponse VerifyDomain (string domainId)

Verify Domain

Verifies the Domain by `id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Okta.Sdk.Api;
using Okta.Sdk.Client;
using Okta.Sdk.Model;

namespace Example
{
    public class VerifyDomainExample
    {
        public void main()
        {
            // Configure API key authorization: api_token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DomainApi();
            var domainId = domainId_example;  // string | 

            try
            {
                // Verify Domain
                DomainResponse result = apiInstance.VerifyDomain(domainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.VerifyDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domainId** | **string**|  | 

### Return type

[**DomainResponse**](DomainResponse.md)

### Authorization

[api_token](../README.md#api_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
