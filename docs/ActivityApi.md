# Org.OpenAPITools.Api.ActivityApi

All URIs are relative to *https://rest-dev.salestream.io/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LeadIdActivityEmailEmailIdDelete**](ActivityApi.md#leadidactivityemailemailiddelete) | **DELETE** /lead/{id}/activity/email/{emailId} | 
[**LeadIdActivityEmailEmailIdPut**](ActivityApi.md#leadidactivityemailemailidput) | **PUT** /lead/{id}/activity/email/{emailId} | 
[**LeadIdActivityEmailPost**](ActivityApi.md#leadidactivityemailpost) | **POST** /lead/{id}/activity/email | 
[**LeadIdActivityGet**](ActivityApi.md#leadidactivityget) | **GET** /lead/{id}/activity | 
[**LeadIdActivityNoteNoteIdDelete**](ActivityApi.md#leadidactivitynotenoteiddelete) | **DELETE** /lead/{id}/activity/note/{noteId} | 
[**LeadIdActivityNoteNoteIdPut**](ActivityApi.md#leadidactivitynotenoteidput) | **PUT** /lead/{id}/activity/note/{noteId} | 
[**LeadIdActivityNotePost**](ActivityApi.md#leadidactivitynotepost) | **POST** /lead/{id}/activity/note | 
[**LeadIdActivitySmsPost**](ActivityApi.md#leadidactivitysmspost) | **POST** /lead/{id}/activity/sms | 
[**LeadIdActivitySmsSmsIdDelete**](ActivityApi.md#leadidactivitysmssmsiddelete) | **DELETE** /lead/{id}/activity/sms/{smsId} | 
[**LeadIdActivitySmsSmsIdPut**](ActivityApi.md#leadidactivitysmssmsidput) | **PUT** /lead/{id}/activity/sms/{smsId} | 


<a name="leadidactivityemailemailiddelete"></a>
# **LeadIdActivityEmailEmailIdDelete**
> SuccessResponse LeadIdActivityEmailEmailIdDelete (string id, string emailId)



delete email

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdActivityEmailEmailIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new ActivityApi();
            var id = id_example;  // string | lead id
            var emailId = emailId_example;  // string | email id

            try
            {
                SuccessResponse result = apiInstance.LeadIdActivityEmailEmailIdDelete(id, emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.LeadIdActivityEmailEmailIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **emailId** | **string**| email id | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidactivityemailemailidput"></a>
# **LeadIdActivityEmailEmailIdPut**
> SuccessResponse LeadIdActivityEmailEmailIdPut (string id, string emailId, string emailId = null, List<string> to = null, List<string> cc = null, List<string> bcc = null, string subject = null, string message = null, bool? draft = null, bool? reminderEnabled = null, int? reminderDate = null, int? schedule = null)



update email

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdActivityEmailEmailIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new ActivityApi();
            var id = id_example;  // string | lead id
            var emailId = emailId_example;  // string | email id
            var emailId = emailId_example;  // string |  (optional) 
            var to = new List<string>(); // List<string> |  (optional) 
            var cc = new List<string>(); // List<string> |  (optional) 
            var bcc = new List<string>(); // List<string> |  (optional) 
            var subject = subject_example;  // string |  (optional) 
            var message = message_example;  // string |  (optional) 
            var draft = true;  // bool? |  (optional) 
            var reminderEnabled = true;  // bool? |  (optional) 
            var reminderDate = 56;  // int? |  (optional) 
            var schedule = 56;  // int? |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdActivityEmailEmailIdPut(id, emailId, emailId, to, cc, bcc, subject, message, draft, reminderEnabled, reminderDate, schedule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.LeadIdActivityEmailEmailIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **emailId** | **string**| email id | 
 **emailId** | **string**|  | [optional] 
 **to** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **cc** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **bcc** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **subject** | **string**|  | [optional] 
 **message** | **string**|  | [optional] 
 **draft** | **bool?**|  | [optional] 
 **reminderEnabled** | **bool?**|  | [optional] 
 **reminderDate** | **int?**|  | [optional] 
 **schedule** | **int?**|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidactivityemailpost"></a>
# **LeadIdActivityEmailPost**
> SuccessResponse LeadIdActivityEmailPost (string id, string emailId, List<string> to, string subject, string message, List<string> cc = null, List<string> bcc = null, bool? draft = null, bool? reminderEnabled = null, int? reminderDate = null, int? schedule = null)



create activity

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdActivityEmailPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new ActivityApi();
            var id = id_example;  // string | lead id
            var emailId = emailId_example;  // string | 
            var to = new List<string>(); // List<string> | 
            var subject = subject_example;  // string | 
            var message = message_example;  // string | 
            var cc = new List<string>(); // List<string> |  (optional) 
            var bcc = new List<string>(); // List<string> |  (optional) 
            var draft = true;  // bool? |  (optional) 
            var reminderEnabled = true;  // bool? |  (optional) 
            var reminderDate = 56;  // int? |  (optional) 
            var schedule = 56;  // int? |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdActivityEmailPost(id, emailId, to, subject, message, cc, bcc, draft, reminderEnabled, reminderDate, schedule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.LeadIdActivityEmailPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **emailId** | **string**|  | 
 **to** | [**List&lt;string&gt;**](string.md)|  | 
 **subject** | **string**|  | 
 **message** | **string**|  | 
 **cc** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **bcc** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **draft** | **bool?**|  | [optional] 
 **reminderEnabled** | **bool?**|  | [optional] 
 **reminderDate** | **int?**|  | [optional] 
 **schedule** | **int?**|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidactivityget"></a>
# **LeadIdActivityGet**
> SuccessResponse LeadIdActivityGet (string id, string after = null, string before = null)



get lead activity

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdActivityGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new ActivityApi();
            var id = id_example;  // string | lead id
            var after = after_example;  // string | after token (optional) 
            var before = before_example;  // string | before token (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdActivityGet(id, after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.LeadIdActivityGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **after** | **string**| after token | [optional] 
 **before** | **string**| before token | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidactivitynotenoteiddelete"></a>
# **LeadIdActivityNoteNoteIdDelete**
> SuccessResponse LeadIdActivityNoteNoteIdDelete (string id, string noteId)



delete note

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdActivityNoteNoteIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new ActivityApi();
            var id = id_example;  // string | lead id
            var noteId = noteId_example;  // string | note id

            try
            {
                SuccessResponse result = apiInstance.LeadIdActivityNoteNoteIdDelete(id, noteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.LeadIdActivityNoteNoteIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **noteId** | **string**| note id | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidactivitynotenoteidput"></a>
# **LeadIdActivityNoteNoteIdPut**
> SuccessResponse LeadIdActivityNoteNoteIdPut (string id, string noteId, string note = null)



udpate note

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdActivityNoteNoteIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new ActivityApi();
            var id = id_example;  // string | lead id
            var noteId = noteId_example;  // string | note id
            var note = note_example;  // string |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdActivityNoteNoteIdPut(id, noteId, note);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.LeadIdActivityNoteNoteIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **noteId** | **string**| note id | 
 **note** | **string**|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidactivitynotepost"></a>
# **LeadIdActivityNotePost**
> SuccessResponse LeadIdActivityNotePost (string id, string note)



create note

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdActivityNotePostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new ActivityApi();
            var id = id_example;  // string | lead id
            var note = note_example;  // string | 

            try
            {
                SuccessResponse result = apiInstance.LeadIdActivityNotePost(id, note);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.LeadIdActivityNotePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **note** | **string**|  | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidactivitysmspost"></a>
# **LeadIdActivitySmsPost**
> SuccessResponse LeadIdActivitySmsPost (string id, string phoneId = null, string detailId = null, Text message = null, bool? draft = null, int? schedule = null)



create sms

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdActivitySmsPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new ActivityApi();
            var id = id_example;  // string | lead id
            var phoneId = phoneId_example;  // string |  (optional) 
            var detailId = detailId_example;  // string |  (optional) 
            var message = new Text(); // Text |  (optional) 
            var draft = true;  // bool? |  (optional) 
            var schedule = 56;  // int? |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdActivitySmsPost(id, phoneId, detailId, message, draft, schedule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.LeadIdActivitySmsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **phoneId** | **string**|  | [optional] 
 **detailId** | **string**|  | [optional] 
 **message** | [**Text**](Text.md)|  | [optional] 
 **draft** | **bool?**|  | [optional] 
 **schedule** | **int?**|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidactivitysmssmsiddelete"></a>
# **LeadIdActivitySmsSmsIdDelete**
> SuccessResponse LeadIdActivitySmsSmsIdDelete (string id, string smsId)



delete sms

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdActivitySmsSmsIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new ActivityApi();
            var id = id_example;  // string | lead id
            var smsId = smsId_example;  // string | sms id

            try
            {
                SuccessResponse result = apiInstance.LeadIdActivitySmsSmsIdDelete(id, smsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.LeadIdActivitySmsSmsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **smsId** | **string**| sms id | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadidactivitysmssmsidput"></a>
# **LeadIdActivitySmsSmsIdPut**
> SuccessResponse LeadIdActivitySmsSmsIdPut (string id, string smsId, string phoneId, string detailId, Text message, bool? draft = null, int? schedule = null)



create sms

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LeadIdActivitySmsSmsIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new ActivityApi();
            var id = id_example;  // string | lead id
            var smsId = smsId_example;  // string | sms id
            var phoneId = phoneId_example;  // string | 
            var detailId = detailId_example;  // string | 
            var message = new Text(); // Text | 
            var draft = true;  // bool? |  (optional) 
            var schedule = 56;  // int? |  (optional) 

            try
            {
                SuccessResponse result = apiInstance.LeadIdActivitySmsSmsIdPut(id, smsId, phoneId, detailId, message, draft, schedule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.LeadIdActivitySmsSmsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| lead id | 
 **smsId** | **string**| sms id | 
 **phoneId** | **string**|  | 
 **detailId** | **string**|  | 
 **message** | [**Text**](Text.md)|  | 
 **draft** | **bool?**|  | [optional] 
 **schedule** | **int?**|  | [optional] 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

