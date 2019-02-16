# Org.OpenAPITools.Api.LeadContactApi

All URIs are relative to *https://rest-dev.salestream.io/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LeadIdContactsContactIdDelete**](LeadContactApi.md#leadidcontactscontactiddelete) | **DELETE** /lead/{id}/contacts/{contactId} | 
[**LeadIdContactsContactIdGet**](LeadContactApi.md#leadidcontactscontactidget) | **GET** /lead/{id}/contacts/{contactId} | 
[**LeadIdContactsContactIdPut**](LeadContactApi.md#leadidcontactscontactidput) | **PUT** /lead/{id}/contacts/{contactId} | 
[**LeadIdContactsGet**](LeadContactApi.md#leadidcontactsget) | **GET** /lead/{id}/contacts | 
[**LeadIdContactsPost**](LeadContactApi.md#leadidcontactspost) | **POST** /lead/{id}/contacts | 


<a name="leadidcontactscontactiddelete"></a>
# **LeadIdContactsContactIdDelete**
> SuccessResponse LeadIdContactsContactIdDelete (string id, string contactId)



delete lead contact

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdContactsContactIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadContactApi();
            var id = id_example;  // string | lead id
            var contactId = contactId_example;  // string | contact id

            try
            {
                SuccessResponse result = apiInstance.LeadIdContactsContactIdDelete(id, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadContactApi.LeadIdContactsContactIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **contactId** | **string**| contact id | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidcontactscontactidget"></a>
# **LeadIdContactsContactIdGet**
> SuccessResponse LeadIdContactsContactIdGet (string id, string contactId)



get lead contact

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdContactsContactIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadContactApi();
            var id = id_example;  // string | lead id
            var contactId = contactId_example;  // string | contactId id

            try
            {
                SuccessResponse result = apiInstance.LeadIdContactsContactIdGet(id, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadContactApi.LeadIdContactsContactIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **contactId** | **string**| contactId id | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidcontactscontactidput"></a>
# **LeadIdContactsContactIdPut**
> SuccessResponse LeadIdContactsContactIdPut (string id, string contactId, string name = null, string title = null, List<CreateContactDetails> details = null)



update lead contact

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdContactsContactIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadContactApi();
            var id = id_example;  // string | lead id
            var contactId = contactId_example;  // string | contact id
            var name = name_example;  // string |  (optional) 
            var title = title_example;  // string |  (optional) 
            var details = new List<CreateContactDetails>(); // List<CreateContactDetails> |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdContactsContactIdPut(id, contactId, name, title, details);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadContactApi.LeadIdContactsContactIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **contactId** | **string**| contact id | 
 **name** | **string**|  | [optional] 
 **title** | **string**|  | [optional] 
 **details** | [**List&lt;CreateContactDetails&gt;**](CreateContactDetails.md)|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidcontactsget"></a>
# **LeadIdContactsGet**
> SuccessResponse LeadIdContactsGet (string id)



get lead contacts

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdContactsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadContactApi();
            var id = id_example;  // string | lead id

            try
            {
                SuccessResponse result = apiInstance.LeadIdContactsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadContactApi.LeadIdContactsGet: " + e.Message );
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

<a name="leadidcontactspost"></a>
# **LeadIdContactsPost**
> SuccessResponse LeadIdContactsPost (string id, string name, string title = null, List<CreateContactDetails> details = null)



Create lead contact

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdContactsPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new LeadContactApi();
            var id = id_example;  // string | lead id
            var name = name_example;  // string | 
            var title = title_example;  // string |  (optional) 
            var details = new List<CreateContactDetails>(); // List<CreateContactDetails> |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdContactsPost(id, name, title, details);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadContactApi.LeadIdContactsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **name** | **string**|  | 
 **title** | **string**|  | [optional] 
 **details** | [**List&lt;CreateContactDetails&gt;**](CreateContactDetails.md)|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

