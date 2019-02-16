# Org.OpenAPITools.Api.LeadApi

All URIs are relative to *https://rest-dev.salestream.io/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LeadIdGet**](LeadApi.md#leadidget) | **GET** /lead/{id} | 
[**LeadIdPut**](LeadApi.md#leadidput) | **PUT** /lead/{id} | 
[**LeadPost**](LeadApi.md#leadpost) | **POST** /lead | 
[**LeadSearchPost**](LeadApi.md#leadsearchpost) | **POST** /lead/search | 


<a name="leadidget"></a>
# **LeadIdGet**
> void LeadIdGet (string id)



Get lead

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadApi();
            var id = id_example;  // string | lead id

            try
            {
                apiInstance.LeadIdGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadApi.LeadIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidput"></a>
# **LeadIdPut**
> SuccessResponse LeadIdPut (string id, string company = null, string url = null, string description = null, List<CreateLeadContacts> contacts = null, List<CreateLeadAddresses> addresses = null, Object customFields = null, string status = null)



Update lead

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadApi();
            var id = id_example;  // string | lead id
            var company = company_example;  // string |  (optional) 
            var url = url_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var contacts = new List<CreateLeadContacts>(); // List<CreateLeadContacts> |  (optional) 
            var addresses = new List<CreateLeadAddresses>(); // List<CreateLeadAddresses> |  (optional) 
            var customFields = new Object(); // Object |  (optional) 
            var status = status_example;  // string |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdPut(id, company, url, description, contacts, addresses, customFields, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadApi.LeadIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **company** | **string**|  | [optional] 
 **url** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 
 **contacts** | [**List&lt;CreateLeadContacts&gt;**](CreateLeadContacts.md)|  | [optional] 
 **addresses** | [**List&lt;CreateLeadAddresses&gt;**](CreateLeadAddresses.md)|  | [optional] 
 **customFields** | [**Object**](Object.md)|  | [optional] 
 **status** | **string**|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadpost"></a>
# **LeadPost**
> SuccessResponse LeadPost (string company, string url = null, string description = null, List<CreateLeadContacts> contacts = null, List<CreateLeadAddresses> addresses = null, Object customFields = null, string status = null)



Create lead

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadApi();
            var company = company_example;  // string | 
            var url = url_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var contacts = new List<CreateLeadContacts>(); // List<CreateLeadContacts> |  (optional) 
            var addresses = new List<CreateLeadAddresses>(); // List<CreateLeadAddresses> |  (optional) 
            var customFields = new Object(); // Object |  (optional) 
            var status = status_example;  // string |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadPost(company, url, description, contacts, addresses, customFields, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadApi.LeadPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **company** | **string**|  | 
 **url** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 
 **contacts** | [**List&lt;CreateLeadContacts&gt;**](CreateLeadContacts.md)|  | [optional] 
 **addresses** | [**List&lt;CreateLeadAddresses&gt;**](CreateLeadAddresses.md)|  | [optional] 
 **customFields** | [**Object**](Object.md)|  | [optional] 
 **status** | **string**|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsearchpost"></a>
# **LeadSearchPost**
> void LeadSearchPost (string searchString = null, List<string> columns = null)



Search for leads

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadSearchPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadApi();
            var searchString = searchString_example;  // string |  (optional) 
            var columns = new List<string>(); // List<string> |  (optional) 

            try
            {
                apiInstance.LeadSearchPost(searchString, columns);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadApi.LeadSearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchString** | **string**|  | [optional] 
 **columns** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

