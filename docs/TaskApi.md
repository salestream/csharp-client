# Org.OpenAPITools.Api.TaskApi

All URIs are relative to *https://rest-dev.salestream.io/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LeadIdTaskPost**](TaskApi.md#leadidtaskpost) | **POST** /lead/{id}/task | 
[**LeadIdTaskTaskIdDelete**](TaskApi.md#leadidtasktaskiddelete) | **DELETE** /lead/{id}/task/{taskId} | 
[**LeadIdTaskTaskIdPut**](TaskApi.md#leadidtasktaskidput) | **PUT** /lead/{id}/task/{taskId} | 


<a name="leadidtaskpost"></a>
# **LeadIdTaskPost**
> SuccessResponse LeadIdTaskPost (string id, int? date, string userId, string desc = null)



Create task

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdTaskPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new TaskApi();
            var id = id_example;  // string | lead id
            var date = 56;  // int? | 
            var userId = userId_example;  // string | 
            var desc = desc_example;  // string |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdTaskPost(id, date, userId, desc);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskApi.LeadIdTaskPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **date** | **int?**|  | 
 **userId** | **string**|  | 
 **desc** | **string**|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidtasktaskiddelete"></a>
# **LeadIdTaskTaskIdDelete**
> SuccessResponse LeadIdTaskTaskIdDelete (string id, string taskId)



Delete task

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdTaskTaskIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new TaskApi();
            var id = id_example;  // string | lead id
            var taskId = taskId_example;  // string | task id

            try
            {
                SuccessResponse result = apiInstance.LeadIdTaskTaskIdDelete(id, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskApi.LeadIdTaskTaskIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **taskId** | **string**| task id | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidtasktaskidput"></a>
# **LeadIdTaskTaskIdPut**
> SuccessResponse LeadIdTaskTaskIdPut (string id, string taskId, int? date = null, string userId = null, string desc = null)



Update task

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdTaskTaskIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new TaskApi();
            var id = id_example;  // string | lead id
            var taskId = taskId_example;  // string | task id
            var date = 56;  // int? |  (optional) 
            var userId = userId_example;  // string |  (optional) 
            var desc = desc_example;  // string |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdTaskTaskIdPut(id, taskId, date, userId, desc);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskApi.LeadIdTaskTaskIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **taskId** | **string**| task id | 
 **date** | **int?**|  | [optional] 
 **userId** | **string**|  | [optional] 
 **desc** | **string**|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

