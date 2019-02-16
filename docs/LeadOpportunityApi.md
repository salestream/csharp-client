# Org.OpenAPITools.Api.LeadOpportunityApi

All URIs are relative to *https://rest-dev.salestream.io/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LeadIdOpportunityGet**](LeadOpportunityApi.md#leadidopportunityget) | **GET** /lead/{id}/opportunity | 
[**LeadIdOpportunityOpportunityIdDelete**](LeadOpportunityApi.md#leadidopportunityopportunityiddelete) | **DELETE** /lead/{id}/opportunity/{opportunityId} | 
[**LeadIdOpportunityOpportunityIdPut**](LeadOpportunityApi.md#leadidopportunityopportunityidput) | **PUT** /lead/{id}/opportunity/{opportunityId} | 
[**LeadIdOpportunityPost**](LeadOpportunityApi.md#leadidopportunitypost) | **POST** /lead/{id}/opportunity | 


<a name="leadidopportunityget"></a>
# **LeadIdOpportunityGet**
> SuccessResponse LeadIdOpportunityGet (string id)



get lead opportunities

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdOpportunityGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadOpportunityApi();
            var id = id_example;  // string | lead id

            try
            {
                SuccessResponse result = apiInstance.LeadIdOpportunityGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadOpportunityApi.LeadIdOpportunityGet: " + e.Message );
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

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidopportunityopportunityiddelete"></a>
# **LeadIdOpportunityOpportunityIdDelete**
> SuccessResponse LeadIdOpportunityOpportunityIdDelete (string id, string opportunityId)



Update opportunity

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdOpportunityOpportunityIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadOpportunityApi();
            var id = id_example;  // string | lead id
            var opportunityId = opportunityId_example;  // string | opportunity id

            try
            {
                SuccessResponse result = apiInstance.LeadIdOpportunityOpportunityIdDelete(id, opportunityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadOpportunityApi.LeadIdOpportunityOpportunityIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **opportunityId** | **string**| opportunity id | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidopportunityopportunityidput"></a>
# **LeadIdOpportunityOpportunityIdPut**
> SuccessResponse LeadIdOpportunityOpportunityIdPut (string id, string opportunityId, int? value, int? estCloseDate, string assignee, int? confidence, string contact = null, Text comment = null)



Update opportunity

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdOpportunityOpportunityIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadOpportunityApi();
            var id = id_example;  // string | lead id
            var opportunityId = opportunityId_example;  // string | opportunity id
            var value = 56;  // int? | 
            var estCloseDate = 56;  // int? | 
            var assignee = assignee_example;  // string | 
            var confidence = 56;  // int? | 
            var contact = contact_example;  // string |  (optional) 
            var comment = new Text(); // Text |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdOpportunityOpportunityIdPut(id, opportunityId, value, estCloseDate, assignee, confidence, contact, comment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadOpportunityApi.LeadIdOpportunityOpportunityIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **opportunityId** | **string**| opportunity id | 
 **value** | **int?**|  | 
 **estCloseDate** | **int?**|  | 
 **assignee** | **string**|  | 
 **confidence** | **int?**|  | 
 **contact** | **string**|  | [optional] 
 **comment** | [**Text**](Text.md)|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidopportunitypost"></a>
# **LeadIdOpportunityPost**
> SuccessResponse LeadIdOpportunityPost (string id, int? value, int? estCloseDate, string assignee, int? confidence, string contact = null, Text comment = null)



Create opportunity

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdOpportunityPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadOpportunityApi();
            var id = id_example;  // string | lead id
            var value = 56;  // int? | 
            var estCloseDate = 56;  // int? | 
            var assignee = assignee_example;  // string | 
            var confidence = 56;  // int? | 
            var contact = contact_example;  // string |  (optional) 
            var comment = new Text(); // Text |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdOpportunityPost(id, value, estCloseDate, assignee, confidence, contact, comment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadOpportunityApi.LeadIdOpportunityPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **value** | **int?**|  | 
 **estCloseDate** | **int?**|  | 
 **assignee** | **string**|  | 
 **confidence** | **int?**|  | 
 **contact** | **string**|  | [optional] 
 **comment** | [**Text**](Text.md)|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

